/*
 * Created by SharpDevelop.
 * User: balld
 * Date: 12/06/2013
 * Time: 11:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using wse;
using LA_CAS_Messages;
using Microsoft.Web.Services3;

namespace MDMWDiffReporting
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private XmlElement QueryAccountHistory( string UCRN)
		{   SeoQueryCitizenAccount_v0_1Doc doc = new SeoQueryCitizenAccount_v0_1Doc();
			doc.SetSchemaLocation("SeoQueryCitizenAccount_v0_1.xsd");
			QueryCitizenHistoryRequestType root= new QueryCitizenHistoryRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "QueryCitizensAccountRequest");
			
			LA_CAS_Messages.core3.UCRNType myUCRN = new LA_CAS_Messages.core3.UCRNType(UCRN);
			
				root.AddUCRN(myUCRN);
			return doc.GetDomDocument().DocumentElement;
		}
		public string getErrorDecription(Microsoft.Web.Services3.ResponseProcessingException rpex2)
		{
			                        //Create XML Document

			                        XmlDocument myXML = new XmlDocument();
			                        
			                        //Load error XML into XML document
					     			myXML.LoadXml(rpex2.Response.OuterXml);
					     			// Create Namespace Manager for Error
					   
					     			XmlNamespaceManager nmanager = new XmlNamespaceManager(myXML.NameTable);
					     			
					     			// Add namespaces
					     			nmanager.AddNamespace("env","http://schemas.xmlsoap.org/soap/envelope/");
					     			nmanager.AddNamespace("ns0", "http://www.scottishcitizen.gov.uk/service");
					     			
                                    // Select Single node and return error decription
                                    if (myXML.SelectSingleNode("//ns0:ErrorDescription",nmanager) !=null)
                                    {
					     			return myXML.SelectSingleNode("//ns0:ErrorDescription",nmanager).InnerText;
                                    }
                                    else{
                                    	return myXML.InnerXml;
                                    }
				     		
		}
		void Button1Click(object sender, EventArgs e)
		{
			string diffFileLocation = 	System.Configuration.ConfigurationManager.AppSettings["DiffFileToProcess"];
			string outfilenamewithpath=	System.Configuration.ConfigurationManager.AppSettings["OutputFile"];
			string WebserviceURL=System.Configuration.ConfigurationManager.AppSettings["url"];
      		string partnerID=System.Configuration.ConfigurationManager.AppSettings["parnerID"];
      		string policy=System.Configuration.ConfigurationManager.AppSettings["WSEpolicy"];
      			
			XmlDocument diffDoc = new XmlDocument(); 
			diffDoc.Load(diffFileLocation);
			XmlNodeList LeftNodelist = diffDoc.SelectNodes("/diff_result/text_diff/left_content/line");
			XmlNodeList RightNodelist = diffDoc.SelectNodes("/diff_result/text_diff/right_content/line");
			int recordsTotal = LeftNodelist.Count + RightNodelist.Count;
		        progressBar1.Visible= true;
      			progressBar1.Maximum= recordsTotal;
      			
      			int count=0;
      			using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, false))
			      	    {
      				file.WriteLine("UCRN, Status, Forename, Surname,Account Level, Date Of Birth, Postcode");
      				file.WriteLine("Records in NHS File not in Sopra File");
						}
			foreach(XmlNode node in LeftNodelist)
			{ Status.Text =" Processing Record with UCRN :" + node.InnerText;
				
				Status.Update();
			wse.CASEndpointBean myWseEndpoint = new wse.CASEndpointBean();
			myWseEndpoint.Url= WebserviceURL;
			
			wse.CitizenAccountRequestMessage  myRequest =  new wse.CitizenAccountRequestMessage();
			myRequest.CASRequestData = new wse.CitizenAccountRequestType();
			myRequest.CASRequestData.Header= new wse.CitizenAccountRequestHeaderType();
		
			myRequest.CASRequestData.Header.CorrelationID= Guid.NewGuid().ToString();
			myRequest.CASRequestData.Header.UserID="MDMW";
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID=partnerID;
			myRequest.CASRequestData.Any= QueryAccountHistory(node.InnerText);
			//myRequest.CASRequestData.Any= QueryCiztizen(UCRNBox.Text);
			wse.CitizenAccountResponseMessage MyResponse = new wse.CitizenAccountResponseMessage();
			
		  
			XmlDocument requestDoc = new XmlDocument();
			string requeststring = Dock.ToString();

		    //MessageBox.Show("send  request");
		    myWseEndpoint.SetPolicy(policy);
		    //MessageBox.Show(myRequest.CASRequestData.Any.OuterXml);
		    try
		    {
		    	MyResponse= myWseEndpoint.sendCitizenAccountMessage(myRequest);
		    	string AccountStatus= string.Empty;
		        string Forename= string.Empty;
		        string Surname= string.Empty;
		        string AuthenticationLevel= string.Empty;
		        string DateOfBirth= string.Empty;
		        string PostCode= string.Empty;
		        XmlDocument results =new XmlDocument();
		    	results.LoadXml(MyResponse.CASResponseData.Any.OuterXml);
		        QueryCitizensAccountResponseType    myAcountHistoryResponse = new QueryCitizensAccountResponseType(results);
                   	
               if (myAcountHistoryResponse.CitizenDetails.CitizenName.PersonGivenNameCount >0)
               {
	               
	               	
	               		Forename =myAcountHistoryResponse.CitizenDetails.CitizenName.PersonGivenName.Value;
	               	
               	}
               if (myAcountHistoryResponse.CitizenDetails.CitizenName.PersonFamilyNameCount >0)
               {
              
               	Surname = myAcountHistoryResponse.CitizenDetails.CitizenName.PersonFamilyName.Value;
               }
              if (myAcountHistoryResponse.AccountStatusCount >0)
               {
               	AccountStatus= myAcountHistoryResponse.AccountStatus.Value;
               }
            if(myAcountHistoryResponse.AuthenticationLevelCount >0)
               {
             AuthenticationLevel= myAcountHistoryResponse.AuthenticationLevel.Value;
               }
               if (myAcountHistoryResponse.CitizenDetails.DateOfBirthCount >0)
               {
               	DateOfBirth=myAcountHistoryResponse.CitizenDetails.DateOfBirth.PersonBirthDate.Value.ToLongDateString();
               }
               if(myAcountHistoryResponse.CurrentProperty.UKPostalAddress.PostCodeCount >0)
               {
               	PostCode = myAcountHistoryResponse.CurrentProperty.UKPostalAddress.PostCode.ToString();
               }
               
		    	
		    	using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
			      	    {
		    		file.WriteLine(node.InnerText+","+AccountStatus +","+Forename+","+Surname+","+AuthenticationLevel+","+ DateOfBirth +"," + PostCode );
						}
		    }
		    catch(ResponseProcessingException ex)
		    {
		    	using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
			      	    {
		    		file.WriteLine(node.InnerText+","+ getErrorDecription(ex));
						}
		    	
		    }
					
				count++;
				
				progressBar1.Value=count;
				progressBar1.Update();
				
			}
			
			
			
			using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
			      	    {
      			
      				file.WriteLine("Records in Sopra File not in NHS File");
						}
			foreach(XmlNode node in RightNodelist)
			{
				Status.Text =" Processing Record with UCRN :" + node.InnerText;
				
				Status.Update();
				
				wse.CASEndpointBean myWseEndpoint = new wse.CASEndpointBean();
			myWseEndpoint.Url= WebserviceURL;
			wse.CitizenAccountRequestMessage  myRequest =  new wse.CitizenAccountRequestMessage();
			myRequest.CASRequestData = new wse.CitizenAccountRequestType();
			myRequest.CASRequestData.Header= new wse.CitizenAccountRequestHeaderType();
		
			myRequest.CASRequestData.Header.CorrelationID= Guid.NewGuid().ToString();
			myRequest.CASRequestData.Header.UserID="MDMW";
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID=partnerID;
			myRequest.CASRequestData.Any= QueryAccountHistory(node.InnerText);
			//myRequest.CASRequestData.Any= QueryCiztizen(UCRNBox.Text);
			wse.CitizenAccountResponseMessage MyResponse = new wse.CitizenAccountResponseMessage();
			
		  
			XmlDocument requestDoc = new XmlDocument();
			string requeststring = Dock.ToString();

		    //MessageBox.Show("send  request");
		    myWseEndpoint.SetPolicy(policy);
		    //MessageBox.Show(myRequest.CASRequestData.Any.OuterXml);
		    try
		    {
		    	MyResponse= myWseEndpoint.sendCitizenAccountMessage(myRequest);
		    	string AccountStatus= string.Empty;
		        string Forename= string.Empty;
		        string Surname= string.Empty;
		        string AuthenticationLevel= string.Empty;
		        string DateOfBirth= string.Empty;
		        string PostCode= string.Empty;
		        XmlDocument results =new XmlDocument();
		    	results.LoadXml(MyResponse.CASResponseData.Any.OuterXml);
		        QueryCitizensAccountResponseType    myAcountHistoryResponse = new QueryCitizensAccountResponseType(results);
                   	
               if (myAcountHistoryResponse.CitizenDetails.CitizenName.PersonGivenNameCount >0)
               {
	               
	               	
	               		Forename =myAcountHistoryResponse.CitizenDetails.CitizenName.PersonGivenName.Value;
	               	
               	}
               if (myAcountHistoryResponse.CitizenDetails.CitizenName.PersonFamilyNameCount >0)
               {
              
               	Surname = myAcountHistoryResponse.CitizenDetails.CitizenName.PersonFamilyName.Value;
               }
              if (myAcountHistoryResponse.AccountStatusCount >0)
               {
               	AccountStatus= myAcountHistoryResponse.AccountStatus.Value;
               }
            if(myAcountHistoryResponse.AuthenticationLevelCount >0)
               {
             AuthenticationLevel= myAcountHistoryResponse.AuthenticationLevel.Value;
               }
               if (myAcountHistoryResponse.CitizenDetails.DateOfBirthCount >0)
               {
               	DateOfBirth=myAcountHistoryResponse.CitizenDetails.DateOfBirth.PersonBirthDate.Value.ToLongDateString();
               }
               if(myAcountHistoryResponse.CurrentProperty.UKPostalAddress.PostCodeCount >0)
               {
               	PostCode = myAcountHistoryResponse.CurrentProperty.UKPostalAddress.PostCode.ToString();
               }
               
		    	
		    	using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
			      	    {
		    		file.WriteLine(node.InnerText+","+AccountStatus +","+Forename+","+Surname+","+AuthenticationLevel+","+ DateOfBirth +"," + PostCode );
						}
		    }
		    catch(ResponseProcessingException ex)
		    {
		    	using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
			      	    {
		    		file.WriteLine(node.InnerText+","+ getErrorDecription(ex));
						}
		    	
		    }
				count++;
				
				progressBar1.Value=count;
				progressBar1.Update();
			}
			progressBar1.Visible= false;
			Status.Text="Results: "+outfilenamewithpath;
		}
	}
}
