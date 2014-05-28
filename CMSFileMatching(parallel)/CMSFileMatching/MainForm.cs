﻿/*
 * Created by SharpDevelop.
 * User: balld
 * Date: 02/06/2013
 * Time: 14:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using LA_CAS_Messages;
using LA_CAS_Messages.core3;
using LA_CAS_Messages.PersonDescriptives2;
using LA_CAS_Messages.core2;
using wse;
using System.Diagnostics;
using Microsoft.Web.Services3.Diagnostics;
using System.Web.Services.Protocols;
using System.Net;
using System.Collections;
using FileHelpers;
 using System.Threading.Tasks;
namespace CMSFileMatching
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
		
	static int CountLinesInFile(string fileName)
    {
	int count = 0;
		using ( System.IO.StreamReader r = new  System.IO.StreamReader(fileName))
		{	    
      		while(r.Peek() !=-1)
      		{   string[] words;
     
     			words=r.ReadLine().Split(',');
     	
     		count++;
     		}
	    
	    
		}

	
	return count;
    }
	private XmlElement UCRNQuery(string NECNumber)
		{
			   SeoQueryUCRN_v0_1Doc doc = new SeoQueryUCRN_v0_1Doc();
			   doc.SetSchemaLocation("SeoQueryUCRN_v0_1.xsd"); // optional
			    
			   QueryUCRNRequestType root = new QueryUCRNRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "QueryUCRNRequest");			   
			   
			   root.AddNECNumber(CitizenSearch(NECNumber));
			   XmlElement element = doc.GetDomDocument().DocumentElement;
			element.Prefix = "n3";
			  return element;
		}
	private XmlElement UCRNQuery(string DateofBirth, string Forename, string Surname,int gender)
		{
			   SeoQueryUCRN_v0_1Doc doc = new SeoQueryUCRN_v0_1Doc();
			   doc.SetSchemaLocation("SeoQueryUCRN_v0_1.xsd"); // optional
			  //QueryUCRNResponseType root = new QueryUCRNResponseType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "QueryUCRNResponse");
			   
			   QueryUCRNRequestType root = new QueryUCRNRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "QueryUCRNRequest");			   
			  LA_CAS_Messages.core2.DateType DOB =  new  LA_CAS_Messages.core2.DateType(DateofBirth);
			   LA_CAS_Messages.PersonDescriptives2.PersonGivenNameType Forename1 = new    LA_CAS_Messages.PersonDescriptives2.PersonGivenNameType(Forename);
			   LA_CAS_Messages.PersonDescriptives2.PersonFamilyNameType Surname1 = new LA_CAS_Messages.PersonDescriptives2.PersonFamilyNameType(Surname);
			   string genderString = string.Empty;
			   LA_CAS_Messages.PersonDescriptives2.GenderAtRegistrationType Gender1 = new  LA_CAS_Messages.PersonDescriptives2.GenderAtRegistrationType(gender.ToString());
			   root.AddCitizenDetails(CitizenSearch(DateofBirth,Forename,Surname,gender));
			   XmlElement element = doc.GetDomDocument().DocumentElement;
			element.Prefix = "n3";
			  return element;
		}
		private LA_CAS_Messages.core3.CitizenSearchDetailsType CitizenSearch(string DateofBirth, string forename, string surname,int gender)
		{
			LA_CAS_Messages.core3.CitizenSearchDetailsType citizen = new  LA_CAS_Messages.core3.CitizenSearchDetailsType();
			citizen.AddForename(Forename(forename));
			citizen.AddSurname(Surname(surname));
			citizen.AddGender(Gender(gender));
			citizen.AddDateOfBirth(DateOfBirth(DateofBirth));
			                       
		   return citizen;
		}
		private PersonGivenNameType Forename(string forename)
		{
			PersonGivenNameType Forename =  new PersonGivenNameType(forename);
			return Forename;
		}
		private PersonFamilyNameType Surname(string surname)
		{PersonFamilyNameType Surname =  new PersonFamilyNameType(surname);
			return Surname;
			
			
		}
		private GenderAtRegistrationType Gender(int gender)
		{
			GenderAtRegistrationType Gender =  new GenderAtRegistrationType();
			//Gender.Assign(gender);
			Gender.Value=gender;
			
			return Gender;
			
		}
		private LA_CAS_Messages.core2.DateType DateOfBirth(string dob)
		{LA_CAS_Messages.core2.DateType  DOB = new LA_CAS_Messages.core2.DateType(dob);
			return DOB;
		}
	private LA_CAS_Messages.core3.EntitlementCardNumberType CitizenSearch(string Nec)
		{
		LA_CAS_Messages.core3.EntitlementCardNumberType citizen = new  LA_CAS_Messages.core3.EntitlementCardNumberType(Nec);
		
			                       
		   return citizen;
		}
		void BtnOpenFileClick(object sender, EventArgs e)
		{
			// Open CMS CSV files  and Load dats to array to allow matchning to take place
		try{
				
		
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
   			{
      			System.IO.StreamReader sr = new 
         		System.IO.StreamReader(openFileDialog1.FileName);
      		
      			int rows = CountLinesInFile(openFileDialog1.FileName);
      			string processlabel= "Processing File "+ openFileDialog1.FileName;
      			LblStatus.Text= processlabel;
      			LblStatus.Update();
      			progressBar1.Visible= true;
      			progressBar1.Maximum= rows;
      			string delimeter =System.Configuration.ConfigurationManager.AppSettings["delimeter"];
      			DateTime now = DateTime.Now;
      			string filename ="Matched_Records" +now.ToString("yyyyMMdd-HHmm")+".csv";
      			string filepath =System.Configuration.ConfigurationManager.AppSettings["OutputFilePath"];
      			
      			string WebserviceURL=System.Configuration.ConfigurationManager.AppSettings["url"];
      			string partnerID=System.Configuration.ConfigurationManager.AppSettings["parnerID"];
      			string policy=System.Configuration.ConfigurationManager.AppSettings["WSEpolicy"];
      			string Nec = System.Configuration.ConfigurationManager.AppSettings["NECFeild"];
      			int NECLocation= Convert.ToInt32(Nec);
      			string outfilenamewithpath=filepath+filename;
				string UCRN =string.Empty;
				string UCRN2= string.Empty;
				wse.CASEndpointBean myCasEndpoint = new wse.CASEndpointBean();
				myCasEndpoint.Url= WebserviceURL;
				string proxyStr= System.Configuration.ConfigurationManager.AppSettings["Proxy"];
			
				if (((proxyStr != null) && (proxyStr != "")))
			       {
					//Create Web Proxy
						WebProxy myProxy = new WebProxy( proxyStr ,true);
						string domain =System.Configuration.ConfigurationManager.AppSettings["ProxyDomain"];
						string user = System.Configuration.ConfigurationManager.AppSettings["ProxyUser"];
						string password =System.Configuration.ConfigurationManager.AppSettings["ProxyPassword"];
						if ((domain !="")&&(domain !=null))
							{
							System.Net.NetworkCredential mycredentials = new NetworkCredential(user,password,domain);
							myProxy.Credentials= mycredentials;
							}
						else if((user !="")&&(user !=null)&& (domain !="")&&(domain !=null))
						{
							System.Net.NetworkCredential mycredentials = new NetworkCredential(user,password);
							myProxy.Credentials= mycredentials;	
						}
		    	     myCasEndpoint.Proxy= myProxy; 
					}
				
				myCasEndpoint.SetPolicy(policy);
				int  currentrow = 0;
			      while(sr.Peek() !=-1)
			      { string[] words;
			     
			     	words=sr.ReadLine().Split(',');
			     	//MessageBox.Show( words[NECLocation]);
			     	if (words[NECLocation]== String.Empty)
			     	{
			     		UCRN ="Missing NEC Number";
			     	}
			     	else
			     	{
			     		// code to query UCRN with citizen detials
			     		string Forename = words[1];
			     		string Surname = words[2];
			     	    string DateOfBirth= words[3];
			     	    string[] DOBElements=DateOfBirth.Split('/');
			     	   
			     		//Set gender to Male.
			     	    int gender=1;
						string NECNumber =words[NECLocation];
			          
						string	corrid = Guid.NewGuid().ToString();
						CitizenAccountRequestMessage myRequest =  new CitizenAccountRequestMessage();
						myRequest.CASRequestData = new CitizenAccountRequestType();
						myRequest.CASRequestData.Header= new CitizenAccountRequestHeaderType();
					
						myRequest.CASRequestData.Header.CorrelationID= corrid;
						myRequest.CASRequestData.Header.UserID="CMS_Matching_on_NEC";
						myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
						myRequest.CASRequestData.Header.PartnerID=partnerID;
						string DOB= DOBElements[2]+"-"+DOBElements[1]+"-"+DOBElements[0];
				        //myRequest.CASRequestData.Any= UCRNQuery(NECNumber);
				        myRequest.CASRequestData.Any= UCRNQuery(DOB,Forename,Surname,gender);
				     	CitizenAccountResponseMessage myResponse = new CitizenAccountResponseMessage();
				        try{
					
				     		myResponse = myCasEndpoint.sendCitizenAccountMessage(myRequest);
				     		XmlDocument myXML = new XmlDocument();
                   			myXML.LoadXml(myResponse.CASResponseData.Any.OuterXml);
                   			QueryUCRNResponseType myQueryResponse = new QueryUCRNResponseType(myXML);
                   			
                   			UCRN= myQueryResponse.GetUCRN().Value;
                   
				           }
			     		catch(Microsoft.Web.Services3.ResponseProcessingException rpex)
				     	{   	gender=2;
						     	myRequest.CASRequestData.Any= UCRNQuery(DOB,Forename,Surname,gender);
						     	CitizenAccountResponseMessage myResponse2 = new CitizenAccountResponseMessage();
						        try{
							
						     		myResponse2 = myCasEndpoint.sendCitizenAccountMessage(myRequest);
						     		XmlDocument myXML = new XmlDocument();
		                   			myXML.LoadXml(myResponse2.CASResponseData.Any.OuterXml);
		                   			QueryUCRNResponseType myQueryResponse = new QueryUCRNResponseType(myXML);
		                   			
		                   			UCRN= myQueryResponse.GetUCRN().Value;
		                   
						           }
					     		catch(Microsoft.Web.Services3.ResponseProcessingException rpex2)
						     	{   //MessageBox.Show( rpex.Response.InnerText);
				     			
					     			//MessageBox.Show (getErrorDecription(rpex2));
					     			UCRN= getErrorDecription(rpex2);
				     		
					     			//UCRN=rpex2.Response.Body.GetNamespaceOfPrefix("ns0").ToString();
						     		//MessageBox.Show(rpex.Response.InnerXml.StartsWith("No").ToString());
						     	}
						     	catch(Exception ex)
						        {
						        	UCRN=ex.Message;
						        }
				     	}
				     	catch(Exception ex)
				        {
				        	UCRN=ex.Message;
				        }
				     	

			     		
			     	}


			     	
			    
						using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
			      	    {
						foreach (string userdetail   in words)
						{
											file.Write(userdetail+delimeter);
						}
			
					
						
					      file.WriteLine(UCRN);
//					      foreach (string userdetail   in words)
//						{
//											file.Write(userdetail+delimeter);
//						}
//			
//					
//						
//					      file.WriteLine(UCRN2);
					      
			          }
			   
			      	currentrow++;
			      	LblStatus.Text= processlabel + ": Line " +currentrow.ToString();
      				LblStatus.Update();
			        progressBar1.Value=currentrow;
			      }
			      using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
			      {
			      	file.WriteLine("Contraol Totals: Input Rows="+ rows+ "  ; Processed Rows=" +currentrow);
			      }
			      LblStatus.Text = "Matching Completed  Results at " +outfilenamewithpath; 
			
			      LblStatus.Update();
			}
				
			}
			catch ( Exception ex)
			{
				DisplayException(ex);
				//MessageBox.Show(ex.Message);
			}
			
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
					               // myXML.SelectSingleNode("\\
					     			return myXML.SelectSingleNode("//ns0:ErrorDescription",nmanager).InnerText;
				     		
		}
		
		public static int exceptionLevel = 0;
		
		
		public static void DisplayException(Exception e)
{
    // Increment exception level.
    exceptionLevel++;
    // Make spacer for level.
    string indent = new string('\t',exceptionLevel-1);
    // Write out exception level data.
   Trace.WriteLine(indent + "*** Exception Level {0} " +
                    "***************************************"+ " "+ exceptionLevel.ToString());
     Trace.WriteLine(indent + "ExceptionType: " + e.GetType().Name.ToString());
    Trace.WriteLine(indent + "HelpLine: " + e.HelpLink);
     Trace.WriteLine(indent + "Message: " + e.Message);
  Trace.WriteLine(indent + "Source: " + e.Source);
    Trace.WriteLine(indent + "StackTrace: " + e.StackTrace);
     Trace.WriteLine(indent + "TargetSite: " + e.TargetSite);
    Trace.WriteLine(indent + "Data:");
    foreach (DictionaryEntry de in e.Data)
    {
    	Trace.WriteLine(indent + "\t"+de.Key.ToString()+" : "+ de.Value.ToString());
    }
    
    // Get the inner exception for this exception.
    Exception ie = e.InnerException;
    
    // Print out the inner exceptions recursively.
    while(ie != null)
    {
        DisplayException(ie);
        // Check to see if we are doing the inner exceptions.
        if(exceptionLevel>1)
            ie = ie.InnerException;
        else // back to main level
            ie = null;
    }
    // Decrement exception level.
    exceptionLevel--;
}
		
		void ProgressBar1Click(object sender, EventArgs e)
		{
			
		}
		
		void ESPClick(object sender, EventArgs e)
		{
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
   			{
      			FileHelperEngine engine = new FileHelperEngine(typeof(CMSFile)); 
	 
			
				CMSFile[] res = engine.ReadFile(openFileDialog1.FileName) as CMSFile[]; 
      		
      			int rows = CountLinesInFile(openFileDialog1.FileName);
      			string processlabel= "Processing File "+ openFileDialog1.FileName;
      			LblStatus.Text= processlabel;
      			LblStatus.Update();
      			
      			
      			progressBar1.Visible= true;
      			progressBar1.Maximum= rows;
      			this.SuspendLayout();
      			string delimeter =System.Configuration.ConfigurationManager.AppSettings["delimeter"];
      			DateTime now = DateTime.Now;
      			string filename ="Matched_Records" +now.ToString("yyyyMMdd-HHmm")+".csv";
      			string filepath =System.Configuration.ConfigurationManager.AppSettings["OutputFilePath"];
      			
      			string WebserviceURL=System.Configuration.ConfigurationManager.AppSettings["url"];
      			string partnerID=System.Configuration.ConfigurationManager.AppSettings["parnerID"];
      			string policy=System.Configuration.ConfigurationManager.AppSettings["WSEpolicy"];
      			string Nec = System.Configuration.ConfigurationManager.AppSettings["NECFeild"];
      			int NECLocation= Convert.ToInt32(Nec);
      			string outfilenamewithpath=filepath+filename;
				string UCRN =string.Empty;
				string UCRN2= string.Empty;
				wse.CASEndpointBean myCasEndpoint = new wse.CASEndpointBean();
				myCasEndpoint.Url= WebserviceURL;
				string proxyStr= System.Configuration.ConfigurationManager.AppSettings["Proxy"];
			
				if (((proxyStr != null) && (proxyStr != "")))
			       {
					//Create Web Proxy
						WebProxy myProxy = new WebProxy( proxyStr ,true);
						string domain =System.Configuration.ConfigurationManager.AppSettings["ProxyDomain"];
						string user = System.Configuration.ConfigurationManager.AppSettings["ProxyUser"];
						string password =System.Configuration.ConfigurationManager.AppSettings["ProxyPassword"];
						if ((domain !="")&&(domain !=null))
							{
							System.Net.NetworkCredential mycredentials = new NetworkCredential(user,password,domain);
							myProxy.Credentials= mycredentials;
							}
						else if((user !="")&&(user !=null)&& (domain !="")&&(domain !=null))
						{
							System.Net.NetworkCredential mycredentials = new NetworkCredential(user,password);
							myProxy.Credentials= mycredentials;	
						}
		    	     myCasEndpoint.Proxy= myProxy; 
					}
				
				myCasEndpoint.SetPolicy(policy);
				int  currentrow = 0;
				List<CMSFile> list_lines = new List<CMSFile>(res);
				int ParallelMax = Convert.ToInt16(MaxThreads.Text);
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				 Parallel.ForEach(list_lines,
    new ParallelOptions { MaxDegreeOfParallelism = ParallelMax }, cust =>
				{   int attemptcount=0;    
    	Query_UCRN:
    	                string	corrid = Guid.NewGuid().ToString();
					    CitizenAccountRequestMessage myRequest =  new CitizenAccountRequestMessage();
						myRequest.CASRequestData = new CitizenAccountRequestType();
						myRequest.CASRequestData.Header= new CitizenAccountRequestHeaderType();
					
						myRequest.CASRequestData.Header.CorrelationID= corrid;
						myRequest.CASRequestData.Header.UserID="CMS_Matching_on_NEC";
						myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
						myRequest.CASRequestData.Header.PartnerID=partnerID;
						
					 CitizenAccountResponseMessage myResponse = new CitizenAccountResponseMessage();
				     try{
					       int gender;
					       
					       	if (cust.Gender =="M")
			     	{
			     	     gender=1;
			     	}
			     	else 
			     	{
			     		 gender =2;
			     	}
			     	myRequest.CASRequestData.Any= UCRNQuery(cust.DateOfBirth.ToString("yyyy-MM-dd"),cust.FirstName,cust.Surname,gender);
				     	   
				     		myResponse = myCasEndpoint.sendCitizenAccountMessage(myRequest);
				     		XmlDocument myXML = new XmlDocument();
                   			myXML.LoadXml(myResponse.CASResponseData.Any.OuterXml);
                   			QueryUCRNResponseType myQueryResponse = new QueryUCRNResponseType(myXML);
                   			
                   		UCRN= myQueryResponse.GetUCRN().Value;
                   
				           }
			     	 catch(Microsoft.Web.Services3.ResponseProcessingException rpex)
				     		{  
				     			
				     			
					     			//MessageBox.Show (getErrorDecription(rpex));
					     			UCRN= getErrorDecription(rpex);
				     		
						     	
			     			}
						catch(Exception ex)
						        {
						        	UCRN=ex.Message;
						        }
						if (UCRN=="The operation has timed out"||UCRN=="The request was aborted: The request was canceled.")  
						{ if  ( attemptcount <10)
							{   attemptcount++;
								goto Query_UCRN;
							}
								
							
						}
				     cust.UCRNNumber=UCRN;
					//Trace.WriteLine("NEC Number:" + cust.NECNumber+ "   UCRN:" +UCRN);
				});
				stopwatch.Stop();
				Trace.WriteLine(rows + " Records Processed  in " +stopwatch.Elapsed+ "with MAX set to " +ParallelMax);
//				List<string> lines = new List<string>();
//				
//					using (StreamReader r = new StreamReader(f))
//					{
//					    // 3
//					    // Use while != null pattern for loop
//					    string line;
//					    while ((line = r.ReadLine()) != null)
//					    {
//						// 4
//						// Insert logic here.
//						// ...
//						// "line" is a line in the file. Add it to our List.
//						lines.Add(line);
//					    }
//					}
					
//			      while(sr.Peek() !=-1)
//			     { string[] words;
//			     
//			     	words=sr.ReadLine().Split(',');
//			     	//MessageBox.Show( words[NECLocation]);
//			     	string Forename = words[8];
//			     	Forename = Forename.Replace("\"","");
//			     		string Surname = words[10];
//			     		Surname = Surname.Replace("\"","");
//			     	    string DateOfBirth= words[12];
//			     	   DateOfBirth= DateOfBirth.Replace("\"","");
//			     	    if (DateOfBirth== "Date of Birth")
//			     	    {
//			     	    	currentrow++;
//			     	    	using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
//			      	       {
//							foreach (string userdetail   in words)
//							{
//												file.Write(userdetail+delimeter);
//							}
//				
//						
//							
//					      file.WriteLine("UCRN");
//	          			}
//			     	    }
//			     	    else{
//			     		// code to query UCRN with citizen detials
//			     		
//			     	    string[] DOBElements=DateOfBirth.Split('-');
//						if (DOBElements == null)
//							return;
//			     	    int gender;
//			     		//Set gender to Male.
//			     		string  GenderStr =words[6] ;
//			     		GenderStr =GenderStr.Replace("\"","");  
//			     	if (GenderStr =="M")
//			     	{
//			     	     gender=1;
//			     	}
//			     	else 
//			     	{
//			     		 gender =2;
//			     	}
//						string NECNumber =words[NECLocation];
//			          
//						string	corrid = Guid.NewGuid().ToString();
//						CitizenAccountRequestMessage myRequest =  new CitizenAccountRequestMessage();
//						myRequest.CASRequestData = new CitizenAccountRequestType();
//						myRequest.CASRequestData.Header= new CitizenAccountRequestHeaderType();
//					
//						myRequest.CASRequestData.Header.CorrelationID= corrid;
//						myRequest.CASRequestData.Header.UserID="CMS_Matching_on_NEC";
//						myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
//						myRequest.CASRequestData.Header.PartnerID=partnerID;
//						string DOB= string.Empty;
//						if (DOBElements.Length==3)
//						{
//						DOB= DOBElements[2]+"-"+DOBElements[1]+"-"+DOBElements[0];
//						}
//						
//				        //myRequest.CASRequestData.Any= UCRNQuery(NECNumber);
//				        CitizenAccountResponseMessage myResponse = new CitizenAccountResponseMessage();
//				        try{
//					        myRequest.CASRequestData.Any= UCRNQuery(DOB,Forename,Surname,gender);
//				     	   
//				     		myResponse = myCasEndpoint.sendCitizenAccountMessage(myRequest);
//				     		XmlDocument myXML = new XmlDocument();
//                   			myXML.LoadXml(myResponse.CASResponseData.Any.OuterXml);
//                   			QueryUCRNResponseType myQueryResponse = new QueryUCRNResponseType(myXML);
//                   			
//                   			UCRN= myQueryResponse.GetUCRN().Value;
//                   
//				           }
//			     		catch(Microsoft.Web.Services3.ResponseProcessingException rpex)
//				     		{  
//				     			
//				     			
//					     			//MessageBox.Show (getErrorDecription(rpex));
//					     			UCRN= getErrorDecription(rpex);
//				     		
//						     	
//			     			}
//						catch(Exception ex)
//						        {
//						        	UCRN=ex.Message;
//						        }
//				     	
//				     	
//
//			     		
//			     
//
//
//			     	
//			    
//						using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
//			      	    {
//							foreach (string userdetail   in words)
//							{
//												file.Write(userdetail+delimeter);
//							}
//				
//						
//							
//					      file.WriteLine("\""+UCRN+"\"");
//	          			}
//			   
//			      	currentrow++;
//			      	LblStatus.Text= processlabel + ": Line " +currentrow.ToString();
//      				LblStatus.Update();
//			        progressBar1.Value=currentrow;
//			      }
//			      }
			     
			      LblStatus.Text = "Matching Completed  Results at " +outfilenamewithpath; 
			
			      LblStatus.Update();
				}
			}
		}
	}


			
			
		