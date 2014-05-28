/*
 * Created by SharpDevelop.
 * User: balld
 * Date: 05/12/2008
 * Time: 13:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NotificationRetevalDemo.casgway.stirling.gov.uk;
using System.Xml;
using SeoListNotifications_v0_1;
using SeoReceiveNotification_v0_1;
using SeoReceiveNotification_v0_1.core3;
using System.Configuration;
using wse;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections;
using System.Data;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Net;
using LA_CAS_Messages;
using LA_CAS_Messages.core3;
using LA_CAS_Messages.PersonDescriptives2;
using LA_CAS_Messages.core2;

using SeoAcknowledgeNotificationReceipt_v0_1;
using SeoAcknowledgeNotificationReceipt_v0_1.core2;
using SeoAcknowledgeNotificationReceipt_v0_1.core3;

namespace NotificationRetevalDemo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class HistoryAccountStatusTxt : Form
	{
		
		private CasGatewayService myGateway;
		private wse.CASEndpointBean myWseEndpoint;
		public HistoryAccountStatusTxt()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			myGateway = new casgway.stirling.gov.uk.CasGatewayService();
			myGateway.Url=System.Configuration.ConfigurationManager.AppSettings["GatewayURL"];
			//myGateway.Url="http://casgway.stirling.gov.uk:8080/cas-gateway/service/GatewayEndpoint.wsdl";
			myWseEndpoint = new CASEndpointBean();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
		{
			XmlNode xNode;
			TreeNode tNode;
			XmlNodeList nodeList;
			int i;

			// Loop through the XML nodes until the leaf is reached.
			// Add the nodes to the TreeView during the looping process.
			if (inXmlNode.HasChildNodes)
			{
				nodeList = inXmlNode.ChildNodes;
				for(i = 0; i<=nodeList.Count - 1; i++)
				{
					xNode = inXmlNode.ChildNodes[i];
					inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
					tNode = inTreeNode.Nodes[i];
					AddNode(xNode, tNode);
				}
			}
			else
			{
				// Here you need to pull the data from the XmlNode based on the
				// type of node, whether attribute values are required, and so forth.
				inTreeNode.Text = (inXmlNode.OuterXml).Trim();
			}
		}
		void StartDemoClick(object sender, EventArgs e)
		{
			LocalCASRequestMessage requestMessage= new LocalCASRequestMessage();
			requestMessage.Header= new RequestHeaderType();
			requestMessage.Header.CorrelationID= Guid.NewGuid().ToString();
			requestMessage.Header.UserID="Stirling";
			requestMessage.Header.Timestamp= DateTime.Now;
			requestMessage.Any= listNotification();
			
			LocalCASResponseMessage MyResponse = new LocalCASResponseMessage();
			XmlDocument requestDoc = new XmlDocument(); 
			requestDoc.LoadXml(requestMessage.Any.OuterXml);
			MessageBox.Show(requestMessage.Any.OuterXml);
			Trace.WriteLine(requestMessage.Any.OuterXml);
			
			treeView1.Nodes.Clear();
			treeView1.Nodes.Add(new TreeNode(requestDoc.DocumentElement.Name));
			TreeNode tNode = new TreeNode();
			tNode = treeView1.Nodes[0];
			AddNode(requestDoc.DocumentElement, tNode);
			treeView1.ExpandAll();
			MessageBox.Show("send  request");
			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(requestMessage.GetType());
		    	try{ 
				StringWriter writer = new StringWriter();
                      x.Serialize(writer,requestMessage);
		    	      string xmlstring = writer.ToString();
		    	      
		    	      Trace.WriteLine(xmlstring);
			MyResponse = myGateway.LocalCAS(requestMessage);
			}
			catch(SoapException soapEx)
			{ 
	MessageBox.Show(soapEx.Code.ToString());
    //Load the Detail element of the SoaopException object
    Trace.WriteLine("**********************************************");
    Trace.WriteLine("---------------- SOAP Exception --------------");
    Trace.WriteLine("SOAP Exception Code :" + soapEx.Code.Name.ToString()+", "+soapEx.Code.ToString()+", ");
    //Trace.WriteLine(soapEx.Detail.OuterXml);
    Trace.WriteLine(soapEx.Message);

    Trace.WriteLine("---------------- Enf of Exception --------------");
    Trace.WriteLine("************************************************");

			}
//			
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				DisplayException(ex);
				
			}						
			XmlDocument NotificationsDoc = new XmlDocument();
			XmlDocument responseXML= new XmlDocument();
			responseXML.LoadXml(MyResponse.Any.OuterXml);
			treeView1.Nodes.Clear();
			treeView1.Nodes.Add(new TreeNode(responseXML.DocumentElement.Name));
			tNode = new TreeNode();
			tNode = treeView1.Nodes[0];

			// SECTION 3. Populate the TreeView with the DOM nodes.
			AddNode(responseXML.DocumentElement, tNode);
			treeView1.ExpandAll();
			
			
			
			NotificationsDoc.LoadXml(MyResponse.Any.OuterXml);
			XmlNodeList Nodelist = NotificationsDoc.SelectNodes("//Notification");
			
			
			foreach(XmlNode node in Nodelist)
			{
				string notifcationID = string.Empty;
				string notificationType = string.Empty;
				XmlDocument tempxml = new XmlDocument();
				tempxml.LoadXml(node.OuterXml);

				notifcationID = tempxml.SelectSingleNode("//NotificationID").InnerText;
				
				MessageBox.Show(node.OuterXml);
			
				MessageBox.Show(tempxml.SelectSingleNode("//NotificationType").InnerText);
					//Console.ReadKey();
					notificationType = tempxml.SelectSingleNode("//NotificationType").InnerText;
				string message= "process Notification:"+ notifcationID+" which is of type "+notificationType;
				MessageBox.Show(message);
				string corrid = Guid.NewGuid().ToString();
				DateTime now = DateTime.Now;
				requestMessage.Header = new RequestHeaderType();
				requestMessage.Header.CorrelationID=corrid;
				requestMessage.Header.UserID="Stirling";
				requestMessage.Header.Timestamp= DateTime.Now;
				// just in to check code remove once we have proper  web services
				//Status mystatus = new Status();

				
				requestMessage.Any = requestNotification(notifcationID);
				responseXML.LoadXml(requestMessage.Any.OuterXml);
				treeView1.Nodes.Clear();
				treeView1.Nodes.Add(new TreeNode(responseXML.DocumentElement.Name));
				tNode = new TreeNode();
				tNode = treeView1.Nodes[0];
				
				// SECTION 3. Populate the TreeView with the DOM nodes.
				AddNode(responseXML.DocumentElement, tNode);
				treeView1.ExpandAll();
				MessageBox.Show("Send request notification:" + notificationType +" Notification id:" + notifcationID);
				StringWriter writer = new StringWriter();
                      x.Serialize(writer,requestMessage);
		    	      string xmlstring = writer.ToString();
		    	      
		    	      Trace.WriteLine(xmlstring);
				
				MyResponse = myGateway.LocalCAS(requestMessage);
				responseXML.LoadXml(MyResponse.Any.OuterXml);
				treeView1.Nodes.Clear();
				treeView1.Nodes.Add(new TreeNode(responseXML.DocumentElement.Name));
				tNode = new TreeNode();
				tNode = treeView1.Nodes[0];

				// SECTION 3. Populate the TreeView with the DOM nodes.
				AddNode(responseXML.DocumentElement, tNode);
				treeView1.ExpandAll();
				
			}
		}
		private XmlElement listNotification()
		{
			SeoListNotifications_v0_1Doc doc = new SeoListNotifications_v0_1Doc();
			doc.SetSchemaLocation("SeoListNotifications-v0-1.xsd");
			doc.SetEncoding("UTF-8");
			ListNotificationsRequestType root;
			root = new ListNotificationsRequestType(doc, "http://www.scottishcitizen.gov.uk/control/v0-1", "",
			                                        "ListNotificationsRequest");

			return doc.GetDomDocument().DocumentElement;
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
     Trace.WriteLine(indent + "Message: " + e.Message +" Code: ");
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
		private XmlElement requestNotification(string notificationID)
		{
			SeoReceiveNotification_v0_1Doc doc = new SeoReceiveNotification_v0_1Doc();

			doc.SetSchemaLocation("SeoReceiveNotification-v0_1.xsd");
			ReceiveNotificationRequestType root =
				new ReceiveNotificationRequestType(doc, "http://www.scottishcitizen.gov.uk/control/v0-1", "",
				                                   "ReceiveNotificationRequest");


			root.AddNotificationID(Notification(notificationID));
			return doc.GetDomDocument().DocumentElement;
		}
		private SeoReceiveNotification_v0_1.core3.NotificationIDType  Notification(string notificationID)
		{
			 SeoReceiveNotification_v0_1.core3.NotificationIDType id = new  SeoReceiveNotification_v0_1.core3.NotificationIDType(notificationID);
			return id;
		}
		private XmlElement acknowledgeNoticiation(string notificationID)
		{   SeoAcknowledgeNotificationReceipt_v0_1Doc doc = new SeoAcknowledgeNotificationReceipt_v0_1.SeoAcknowledgeNotificationReceipt_v0_1Doc();
			doc.SetSchemaLocation("SeoAcknowledgeNotificationReceipt_v0_1.xsd"); // optional
			   AcknowledgeNotificationReceiptType root = new AcknowledgeNotificationReceiptType(doc, "http://www.scottishcitizen.gov.uk/control/v0-1", "", "AcknowledgeNotificationReceipt");
			   root.AddNotificationID(AckNotification(notificationID));
			return doc.GetDomDocument().DocumentElement;
		}
		
		private SeoAcknowledgeNotificationReceipt_v0_1.core3.NotificationIDType  AckNotification(string notificationID)
		{
			 SeoAcknowledgeNotificationReceipt_v0_1.core3.NotificationIDType id = new  SeoAcknowledgeNotificationReceipt_v0_1.core3.NotificationIDType(notificationID);
			return id;
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
		
		/// <summary>
		/// /
		/// </summary>
		/// <param name="DateofBirth"></param>
		/// <param name="Forename"></param>
		/// <param name="Surname"></param>
		/// <param name="gender"></param>
		/// <param name="uprn"></param>
		/// <param name="identityProof1"></param>
		/// <param name="identityProof2"></param>
		/// <param name="residenceProof1"></param>
		/// <param name="residenceProof2"></param>
		/// <param name="consent"></param>
		/// <returns></returns>
		/// 
		
		private XmlElement CitizenRegistration2(string DateofBirth, string Forename, string Surname,int gender, string uprn,string identityProof1, string identityProof2,string residenceProof1, string residenceProof2, string consent)
		{  SeoCitizenRegistration_v0_2.SeoCitizenRegistration_v0_2Doc doc = new SeoCitizenRegistration_v0_2.SeoCitizenRegistration_v0_2Doc()  ;
		   doc.SetSchemaLocation("SeoCitizenRegistration-v0-2.xsd"); // optional
		   SeoCitizenRegistration_v0_2.CitizenRegistrationRequestType root = new SeoCitizenRegistration_v0_2.CitizenRegistrationRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-2", "", "CitizenRegistrationRequest");
			    root.AddNewCitizenRegistration(RegCitizen2(doc,DateofBirth,  Forename,  Surname, gender, uprn, identityProof1, identityProof2, residenceProof1,  residenceProof2,  consent));
			   //root.MyNewCitizenRegistrations= new CitizenRegistrationRequestType.NewCitizenRegistrationCollection();
			//CitizenRegistrationRequestType.NewCitizenRegistrationCollection MyNewReg = new CitizenRegistrationRequestType.NewCitizenRegistrationCollection();
			   //MyNewReg.Parent=CitizenDetails(DateofBirth,  Forename,  Surname, gender);
			   XmlElement element =doc.GetDomDocument().DocumentElement;
			   element.Prefix="n2";
			  return element;
		
			
		}
		
		private XmlElement CitizenRegistration2(string DateofBirth, string Forename, string Surname,int gender, string Addressline1,string Addressline2,string Town, string PostCode,string identityProof1, string identityProof2,string residenceProof1, string residenceProof2, string consent)
		{  SeoCitizenRegistration_v0_2.SeoCitizenRegistration_v0_2Doc doc = new SeoCitizenRegistration_v0_2.SeoCitizenRegistration_v0_2Doc()  ;
		   doc.SetSchemaLocation("SeoCitizenRegistration-v0-2.xsd"); // optional
		   SeoCitizenRegistration_v0_2.CitizenRegistrationRequestType root = new SeoCitizenRegistration_v0_2.CitizenRegistrationRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-2", "", "CitizenRegistrationRequest");
			    root.AddNewCitizenRegistration(RegCitizen2(doc,DateofBirth,  Forename,  Surname, gender, Addressline1,Addressline2,Town,PostCode, identityProof1, identityProof2, residenceProof1,  residenceProof2,  consent));
			   //root.MyNewCitizenRegistrations= new CitizenRegistrationRequestType.NewCitizenRegistrationCollection();
			//CitizenRegistrationRequestType.NewCitizenRegistrationCollection MyNewReg = new CitizenRegistrationRequestType.NewCitizenRegistrationCollection();
			   //MyNewReg.Parent=CitizenDetails(DateofBirth,  Forename,  Surname, gender);
			   XmlElement element =doc.GetDomDocument().DocumentElement;
			   element.Prefix="n2";
			  return element;
		
			
		}
		
		private XmlElement CitizenRegistration(string DateofBirth, string Forename, string Surname,int gender, string uprn,string identityProof1, string identityProof2,string residenceProof1, string residenceProof2, string consent)
		{  SeoCitizenRegistration_v0_1Doc doc = new SeoCitizenRegistration_v0_1Doc();
		   doc.SetSchemaLocation("SeoCitizenRegistration-v0-1.xsd"); // optional
		   CitizenRegistrationRequestType root = new CitizenRegistrationRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "CitizenRegistrationRequest");
			    root.AddNewCitizenRegistration(RegCitizen(doc,DateofBirth,  Forename,  Surname, gender, uprn, identityProof1, identityProof2, residenceProof1,  residenceProof2,  consent));
			   //root.MyNewCitizenRegistrations= new CitizenRegistrationRequestType.NewCitizenRegistrationCollection();
			//CitizenRegistrationRequestType.NewCitizenRegistrationCollection MyNewReg = new CitizenRegistrationRequestType.NewCitizenRegistrationCollection();
			   //MyNewReg.Parent=CitizenDetails(DateofBirth,  Forename,  Surname, gender);
			   XmlElement element =doc.GetDomDocument().DocumentElement;
			   element.Prefix="n2";
			  return element;
		
			
		}
		
		private XmlElement CitizenRegistration(string DateofBirth, string Forename, string Surname,int gender, string Addressline1,string Addressline2,string Town, string PostCode,string identityProof1, string identityProof2,string residenceProof1, string residenceProof2, string consent)
		{  SeoCitizenRegistration_v0_1Doc doc = new SeoCitizenRegistration_v0_1Doc();
		   doc.SetSchemaLocation("SeoCitizenRegistration-v0-1.xsd"); // optional
		   CitizenRegistrationRequestType root = new CitizenRegistrationRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "CitizenRegistrationRequest");
			    root.AddNewCitizenRegistration(RegCitizen(doc,DateofBirth,  Forename,  Surname, gender, Addressline1,Addressline2,Town,PostCode, identityProof1, identityProof2, residenceProof1,  residenceProof2,  consent));
			   //root.MyNewCitizenRegistrations= new CitizenRegistrationRequestType.NewCitizenRegistrationCollection();
			//CitizenRegistrationRequestType.NewCitizenRegistrationCollection MyNewReg = new CitizenRegistrationRequestType.NewCitizenRegistrationCollection();
			   //MyNewReg.Parent=CitizenDetails(DateofBirth,  Forename,  Surname, gender);
			   XmlElement element =doc.GetDomDocument().DocumentElement;
			   element.Prefix="n2";
			  return element;
		
			
		}
		private XmlElement CitizenRegistration(string NECNumber)
		{
			SeoCitizenRegistration_v0_1Doc doc = new SeoCitizenRegistration_v0_1Doc();
		   	doc.SetSchemaLocation("SeoCitizenRegistration-v0-1.xsd"); // optional
		   	CitizenRegistrationRequestType root = new CitizenRegistrationRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "CitizenRegistrationRequest");
		  
		   	ExistingWebSiteRegistrationType myReg = new ExistingWebSiteRegistrationType();
		   	//NewCitizenRegistrationType myReg= new NewCitizenRegistrationType();
		   	LA_CAS_Messages.core3.EntitlementCardNumberType myNEC = new    	LA_CAS_Messages.core3.EntitlementCardNumberType(NECNumber);
		   	myReg.AddNECNumber(myNEC);
		   	 	root.AddExistingWebSiteRegistration(myReg);
		   	 	XmlElement element =doc.GetDomDocument().DocumentElement;
			element.Prefix="n2";
			return element;
		}
		private LA_CAS_Messages.AddressAndPersonalDetails2.UKPostalAddressStructure CitizenAddress(string Addressline1, string Addressline2,string Town, string Postcode)
		{
			LA_CAS_Messages.AddressAndPersonalDetails2.UKPostalAddressStructure myAddress = new LA_CAS_Messages.AddressAndPersonalDetails2.UKPostalAddressStructure();
			Addressline1="UNIVERSITY OF STIRLING";
			Addressline2="AIRTHREY ROAD";
		string Addressline3="STIRLING";
		Postcode="FK9 4LA";
			myAddress.AddLine(Addressline(Addressline1)).Prefix="AddressAndPersonalDetails";
	
			myAddress.AddLine(Addressline(Addressline2)).Prefix="AddressAndPersonalDetails";
			
			myAddress.AddLine(Addressline(Addressline3)).Prefix="AddressAndPersonalDetails";
			myAddress.AddPostCode(CreatePostCode(Postcode)).Prefix="AddressAndPersonalDetails";
			return myAddress;
			                                    
		}
		private SeoCitizenRegistration_v0_2.AddressAndPersonalDetails2.UKPostalAddressStructure CitizenAddress2(string Addressline1, string Addressline2,string Town, string Postcode)
		{
			SeoCitizenRegistration_v0_2.AddressAndPersonalDetails2.UKPostalAddressStructure myAddress = new SeoCitizenRegistration_v0_2.AddressAndPersonalDetails2.UKPostalAddressStructure();
			Addressline1="UNIVERSITY OF STIRLING";
			Addressline2="AIRTHREY ROAD";
		string Addressline3="STIRLING";
		Postcode="FK9 4LA";
			myAddress.AddLine(Addresslinever2(Addressline1)).Prefix="AddressAndPersonalDetails";
	
			myAddress.AddLine(Addresslinever2(Addressline2)).Prefix="AddressAndPersonalDetails";
			
			myAddress.AddLine(Addresslinever2(Addressline3)).Prefix="AddressAndPersonalDetails";
			myAddress.AddPostCode(CreatePostCode2(Postcode)).Prefix="AddressAndPersonalDetails";
			
			return myAddress;
			                                    
		}
		private LA_CAS_Messages.AddressAndPersonalDetails2.AddressLineType Addressline(string AddressLine)
		{LA_CAS_Messages.AddressAndPersonalDetails2.AddressLineType myLine = new LA_CAS_Messages.AddressAndPersonalDetails2.AddressLineType(AddressLine);
			
			
				return myLine;
			
		}
		private SeoCitizenRegistration_v0_2.AddressAndPersonalDetails2.AddressLineType Addresslinever2(string AddressLine)
		{SeoCitizenRegistration_v0_2.AddressAndPersonalDetails2.AddressLineType myLine = new SeoCitizenRegistration_v0_2.AddressAndPersonalDetails2.AddressLineType(AddressLine);
			
			
				return myLine;
			
		}
		private SeoCitizenRegistration_v0_2.bs76662.PostCodeType CreatePostCode2( string postcode)
		{
			SeoCitizenRegistration_v0_2.bs76662.PostCodeType myPostcode = new SeoCitizenRegistration_v0_2.bs76662.PostCodeType(postcode);
			 
			return myPostcode;
		}
		
		
		private LA_CAS_Messages.bs76662.PostCodeType CreatePostCode( string postcode)
		{
			LA_CAS_Messages.bs76662.PostCodeType myPostcode = new LA_CAS_Messages.bs76662.PostCodeType(postcode);
			 
			return myPostcode;
		}
		
		private SeoCitizenRegistration_v0_2.NewCitizenRegistrationType RegCitizen2(SeoCitizenRegistration_v0_2.SeoCitizenRegistration_v0_2Doc doc,string dateofBirth, string forename, string surname,int gender, string Addressline1,string Addressline2,string Town, string PostCode,string identityProof1, string identityProof2,string residenceProof1, string residenceProof2, string consent)
		{
			
			SeoCitizenRegistration_v0_2.NewCitizenRegistrationType myReg= new  SeoCitizenRegistration_v0_2.NewCitizenRegistrationType();
			myReg.AddCitizenDetails(CitizenDetails2(dateofBirth,  forename,  surname, gender));
			myReg.AddCitizenAddress(CitizenAddress2(Addressline1,Addressline2,Town,PostCode));
			
			myReg.AddNationalLevelConsentFlag(new SeoCitizenRegistration_v0_2.egifcore2.YesNoType(consent));
			myReg.AddLevel2Enrolment(Level2Enrolement2( identityProof1,  identityProof2,residenceProof1, residenceProof2 ));
				myReg.AddLACode(lacode("30"));
	        return myReg;
		}
		private SeoCitizenRegistration_v0_2.NewCitizenRegistrationType RegCitizen2(SeoCitizenRegistration_v0_2.SeoCitizenRegistration_v0_2Doc doc,string dateofBirth, string forename, string surname,int gender, string uprn,string identityProof1, string identityProof2,string residenceProof1, string residenceProof2, string consent)
		{
			
			SeoCitizenRegistration_v0_2.NewCitizenRegistrationType myReg= new SeoCitizenRegistration_v0_2.NewCitizenRegistrationType();
			//myReg.AddCitizenDetails(CitizenDetails2(dateofBirth,  forename,  surname, gender));
		
			SeoCitizenRegistration_v0_2.core2.UCRNType myucrn = new SeoCitizenRegistration_v0_2.core2.UCRNType("9720000000000000061");
			myReg.AddUCRN(myucrn);
			//myReg.AddUPRN(UPRN2(uprn));
			myReg.AddCitizenAddress(CitizenAddress2("","","",""));
			
			myReg.AddNationalLevelConsentFlag(new SeoCitizenRegistration_v0_2.egifcore2.YesNoType(consent));
			myReg.AddLevel2Enrolment(Level2Enrolement2( identityProof1,  identityProof2,residenceProof1, residenceProof2 ));
			myReg.AddLACode(lacode("30"));
	        return myReg;
		}
		private SeoCitizenRegistration_v0_2.core2.ScottishLocalAuthorityCodeType lacode(string lacodenumber)
		{
			SeoCitizenRegistration_v0_2.core2.ScottishLocalAuthorityCodeType mylacode = new SeoCitizenRegistration_v0_2.core2.ScottishLocalAuthorityCodeType(lacodenumber);
			return mylacode;
		}
			private NewCitizenRegistrationType RegCitizen(SeoCitizenRegistration_v0_1Doc doc,string dateofBirth, string forename, string surname,int gender, string Addressline1,string Addressline2,string Town, string PostCode,string identityProof1, string identityProof2,string residenceProof1, string residenceProof2, string consent)
		{
			
			NewCitizenRegistrationType myReg= new NewCitizenRegistrationType();
			myReg.AddCitizenDetails(CitizenDetails(dateofBirth,  forename,  surname, gender));
			myReg.AddCitizenAddress(CitizenAddress(Addressline1,Addressline2,Town,PostCode));
			//myReg.AddUPRN(UPRN(uprn));
			myReg.AddNationalLevelConsentFlag(new LA_CAS_Messages.core2.YesNoType(consent));
			myReg.AddLevel2Enrolment(Level2Enrolement( identityProof1,  identityProof2,residenceProof1, residenceProof2 ));
			
	        return myReg;
		}
		private NewCitizenRegistrationType RegCitizen(SeoCitizenRegistration_v0_1Doc doc,string dateofBirth, string forename, string surname,int gender, string uprn,string identityProof1, string identityProof2,string residenceProof1, string residenceProof2, string consent)
		{
			
			NewCitizenRegistrationType myReg= new NewCitizenRegistrationType();
			myReg.AddCitizenDetails(CitizenDetails(dateofBirth,  forename,  surname, gender));
			myReg.AddUPRN(UPRN(uprn));
			myReg.AddNationalLevelConsentFlag(new LA_CAS_Messages.core2.YesNoType(consent));
			myReg.AddLevel2Enrolment(Level2Enrolement( identityProof1,  identityProof2,residenceProof1, residenceProof2 ));
			
	        return myReg;
		}
		private SeoCitizenRegistration_v0_2.core2.UPRNType2 UPRN2( string uprn)
		{
			 SeoCitizenRegistration_v0_2.core2.UPRNType2 myUPRN = new  SeoCitizenRegistration_v0_2.core2.UPRNType2(uprn);
			return myUPRN;
		}
		private LA_CAS_Messages.core3.UPRNType2 UPRN( string uprn)
		{
			LA_CAS_Messages.core3.UPRNType2 myUPRN = new LA_CAS_Messages.core3.UPRNType2(uprn);
			return myUPRN;
		}
		private LA_CAS_Messages.core3.Level2EnrolmentType Level2Enrolement(string identityProof1, string identityProof2,string residenceProof1, string residenceProof2 )
		{
			LA_CAS_Messages.core3.Level2EnrolmentType myEnrolement= new LA_CAS_Messages.core3.Level2EnrolmentType();
			myEnrolement.AddIdentityDocumentation(new LA_CAS_Messages.core3.DocumentaryProof(identityProof1));
		    myEnrolement.AddIdentityDocumentation(new LA_CAS_Messages.core3.DocumentaryProof(identityProof2));
		    myEnrolement.AddResidenceDocumentation(new LA_CAS_Messages.core3.DocumentaryProof(residenceProof1));
			myEnrolement.AddResidenceDocumentation(new LA_CAS_Messages.core3.DocumentaryProof(residenceProof2));
			return myEnrolement;
		}
		private SeoCitizenRegistration_v0_2.core2.Level2EnrolmentType Level2Enrolement2(string identityProof1, string identityProof2,string residenceProof1, string residenceProof2 )
		{
			 SeoCitizenRegistration_v0_2.core2.Level2EnrolmentType myEnrolement= new  SeoCitizenRegistration_v0_2.core2.Level2EnrolmentType();
			myEnrolement.AddIdentityDocumentation(new  SeoCitizenRegistration_v0_2.core2.DocumentaryProof(identityProof1));
		    myEnrolement.AddIdentityDocumentation(new  SeoCitizenRegistration_v0_2.core2.DocumentaryProof(identityProof2));
		    myEnrolement.AddResidenceDocumentation(new  SeoCitizenRegistration_v0_2.core2.DocumentaryProof(residenceProof1));
			myEnrolement.AddResidenceDocumentation(new  SeoCitizenRegistration_v0_2.core2.DocumentaryProof(residenceProof2));
			return myEnrolement;
		}
		
		private LA_CAS_Messages.core3.CitizenDetailsType CitizenDetails(string dateofBirth, string forename, string surname,int gender)
		{
			LA_CAS_Messages.core3.CitizenDetailsType citizen = new LA_CAS_Messages.core3.CitizenDetailsType();
			citizen.AddForename(Forename(forename));
			citizen.AddSurname(Surname(surname));
				citizen.AddGender(Gender(gender));
				citizen.AddDateOfBirth(DateOfBirth(dateofBirth));
		
			
			return citizen;
			
		}
			private SeoCitizenRegistration_v0_2.core2.CitizenDetailsType CitizenDetails2(string dateofBirth, string forename, string surname,int gender)
		{
				SeoCitizenRegistration_v0_2.core2.CitizenDetailsType citizen = new SeoCitizenRegistration_v0_2.core2.CitizenDetailsType();
//			citizen.AddForename(Forename2(forename));
//			citizen.AddSurname(Surname2(surname));
//				citizen.AddGender(Gender2(gender));
//				citizen.AddDateOfBirth(DateOfBirth2(dateofBirth));
				//citizen.
		
			
			return citizen;
			
		}
		private SeoCitizenRegistration_v0_2.PersonDescriptives2.PersonGivenNameType Forename2(string forename)
		{
			SeoCitizenRegistration_v0_2.PersonDescriptives2.PersonGivenNameType Forename =  new SeoCitizenRegistration_v0_2.PersonDescriptives2.PersonGivenNameType(forename);
			return Forename;
		}
		private SeoCitizenRegistration_v0_2.PersonDescriptives2.PersonFamilyNameType Surname2(string surname)
		{SeoCitizenRegistration_v0_2.PersonDescriptives2.PersonFamilyNameType Surname =  new SeoCitizenRegistration_v0_2.PersonDescriptives2.PersonFamilyNameType(surname);
			return Surname;
			
			
		}
		private SeoCitizenRegistration_v0_2.PersonDescriptives2.GenderAtRegistrationType Gender2(int gender)
		{
			SeoCitizenRegistration_v0_2.PersonDescriptives2.GenderAtRegistrationType Gender =  new SeoCitizenRegistration_v0_2.PersonDescriptives2.GenderAtRegistrationType();
			//Gender.Assign(gender);
			Gender.Value=gender;
			
			return Gender;
			
		}
		private SeoCitizenRegistration_v0_2.egifcore2.DateType DateOfBirth2(string dob)
		{SeoCitizenRegistration_v0_2.egifcore2.DateType DOB = new SeoCitizenRegistration_v0_2.egifcore2.DateType(dob);
			return DOB;
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
		void Button1Click(object sender, EventArgs e)
		{   
			//Create output  file
				string filename = string.Empty;
			string partnerID= System.Configuration.ConfigurationManager.AppSettings["StirlingPartnerID"];
			string council =System.Configuration.ConfigurationManager.AppSettings["StirlingCouncil"];
			filename = "UAT_Testing_"+council+"_"+DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")+".txt";
			
			System.IO.StreamWriter file = new StreamWriter(filename);
			CitizenAccountRequestMessage myRequest =  new CitizenAccountRequestMessage();
			myRequest.CASRequestData = new CitizenAccountRequestType();
			myRequest.CASRequestData.Header= new CitizenAccountRequestHeaderType();
		
			myRequest.CASRequestData.Header.CorrelationID= Guid.NewGuid().ToString();
			myRequest.CASRequestData.Header.UserID=council;
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID=partnerID;
		    myRequest.CASRequestData.Any= listNotification();
		 
			
		    CitizenAccountResponseMessage MyResponse = new CitizenAccountResponseMessage();
			XmlDocument requestDoc = new XmlDocument(); 
			requestDoc.LoadXml(myRequest.CASRequestData.Any.OuterXml);
			MessageBox.Show(myRequest.CASRequestData.Any.OuterXml);
			Trace.WriteLine(myRequest.CASRequestData.Any.OuterXml);
			
			treeView1.Nodes.Clear();
			treeView1.Nodes.Add(new TreeNode(requestDoc.DocumentElement.Name));
			TreeNode tNode = new TreeNode();
			tNode = treeView1.Nodes[0];
			AddNode(requestDoc.DocumentElement, tNode);
			treeView1.ExpandAll();
			MessageBox.Show("send  request");
			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
			System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(MyResponse.GetType());
		    try{ 
				      
				      StringWriter writer = new StringWriter();
                      x.Serialize(writer,myRequest);
		    	      string xmlstring = writer.ToString();
		    	      DateTime date = DateTime.Now;
		    	      file.WriteLine(" Test of Notification from CAS " + date);
		    	      file.WriteLine();
		    	      file.WriteLine( "requesting Notification List");
		    	      file.WriteLine();
		    	      file.WriteLine("********************************************************************************");
		    	       file.WriteLine(" List  of   Notifications");
		    	      Trace.WriteLine(xmlstring);
		    	      
//		    	      Get Proxy Settings
		    	      string proxyStr= System.Configuration.ConfigurationManager.AppSettings["Proxy"];
			
						 if (((proxyStr != null) 
			                        && (proxyStr != "")))
			            {//Create Web Proxy
						WebProxy myProxy = new WebProxy( proxyStr ,true);
						string domain =System.Configuration.ConfigurationManager.AppSettings["ProxyDomain"];
						string user = System.Configuration.ConfigurationManager.AppSettings["ProxyUser"];
						string password =System.Configuration.ConfigurationManager.AppSettings["ProxyPassword"];
						if ((domain !="")&&(domain !=null))
							{System.Net.NetworkCredential mycredentials = new NetworkCredential(user,password,domain);
							myProxy.Credentials= mycredentials;
							}
						else if((user !="")&&(user !=null)&& (domain !="")&&(domain !=null))
						{
							System.Net.NetworkCredential mycredentials = new NetworkCredential(user,password);
							myProxy.Credentials= mycredentials;	
						}
		    	      myWseEndpoint.Proxy= myProxy; }
					    	      
		    	      
		    	      myWseEndpoint.SetPolicy("Seemis");
			           MyResponse =myWseEndpoint.sendCitizenAccountMessage(myRequest);
			           //MessageBox.Show( MyResponse.CASResponseData.Status.StatusCode.Value.ToString());
			XmlDocument NotificationsDoc = new XmlDocument();
			XmlDocument responseXML= new XmlDocument();
			
			responseXML.LoadXml(MyResponse.CASResponseData.Any.OuterXml);
			StringWriter writer3 = new StringWriter();
                      y.Serialize(writer3,MyResponse);
		    	      string xmlstring3 = writer3.ToString();
		    	      file.WriteLine(xmlstring3);
			treeView1.Nodes.Clear();
			treeView1.Nodes.Add(new TreeNode(responseXML.DocumentElement.Name));
			tNode = new TreeNode();
			tNode = treeView1.Nodes[0];

			// SECTION 3. Populate the TreeView with the DOM nodes.
			AddNode(responseXML.DocumentElement, tNode);
			treeView1.ExpandAll();
			
			
			
			NotificationsDoc.LoadXml(MyResponse.CASResponseData.Any.OuterXml);
			XmlNodeList Nodelist = NotificationsDoc.SelectNodes("//Notification");
			
			
			foreach(XmlNode node in Nodelist)
			{
				string notifcationID = string.Empty;
				string notificationType = string.Empty;
				XmlDocument tempxml = new XmlDocument();
				tempxml.LoadXml(node.OuterXml);

				notifcationID = tempxml.SelectSingleNode("//NotificationID").InnerText;
				
				//MessageBox.Show(node.OuterXml);
			
				//MessageBox.Show(tempxml.SelectSingleNode("//NotificationType").InnerText);
					//Console.ReadKey();
					
				notificationType = tempxml.SelectSingleNode("//NotificationType").InnerText;
				
				//write notifiation type and notification ID to output file
				//file.WriteLine("Notification Type = "+ notificationType + ", NotificationID = "+ 	notifcationID);
				file.WriteLine();
				file.WriteLine("*******************************************************************************");
				string message= "process Notification:"+ notifcationID+" which is of type "+notificationType;
				//MessageBox.Show(message);
				string corrid = Guid.NewGuid().ToString();
				DateTime now = DateTime.Now;
				myRequest.CASRequestData.Header = new wse.CitizenAccountRequestHeaderType();
				myRequest.CASRequestData.Header.CorrelationID=corrid;
				myRequest.CASRequestData.Header.UserID=council;
				myRequest.CASRequestData.Header.PartnerID=partnerID;
				myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
				// just in to check code remove once we have proper  web services
				Status mystatus = new Status();

				
				myRequest.CASRequestData.Any = requestNotification(notifcationID);
				responseXML.LoadXml(myRequest.CASRequestData.Any.OuterXml);
				
				treeView1.Nodes.Clear();
				treeView1.Nodes.Add(new TreeNode(responseXML.DocumentElement.Name));
				tNode = new TreeNode();
				tNode = treeView1.Nodes[0];
				
				// SECTION 3. Populate the TreeView with the DOM nodes.
				AddNode(responseXML.DocumentElement, tNode);
				treeView1.ExpandAll();
				//MessageBox.Show("Send request notification:" + notificationType +" Notification id:" + notifcationID);
				file.WriteLine("Request notification:" + notificationType +" Notification id:" + notifcationID);
				file.WriteLine();
				StringWriter writer2 = new StringWriter();
                      x.Serialize(writer2,myRequest);
		    	      string xmlstring2 = writer2.ToString();
		    	      
		    	      Trace.WriteLine(xmlstring2);
		    	      
		    	      file.WriteLine(xmlstring2);
		    	      file.WriteLine();
				MyResponse = myWseEndpoint.sendCitizenAccountMessage(myRequest);
				
				
				responseXML.LoadXml(MyResponse.CASResponseData.Any.OuterXml);
				StringWriter writer4 = new StringWriter();
                      y.Serialize(writer4,MyResponse);
		    	      string xmlstring4 = writer4.ToString();
//		    	      
		    	      file.WriteLine();
		    	      	file.WriteLine(notificationType + "Message Detials:");
		    	      	file.WriteLine();
		    	      file.WriteLine(xmlstring4);
				  //file.WriteLine(responseXML.OuterXml);
				treeView1.Nodes.Clear();
				treeView1.Nodes.Add(new TreeNode(responseXML.DocumentElement.Name));
				tNode = new TreeNode();
				tNode = treeView1.Nodes[0];

				// SECTION 3. Populate the TreeView with the DOM nodes.
				AddNode(responseXML.DocumentElement, tNode);
				treeView1.ExpandAll();
				
				
				
				string delete=System.Configuration.ConfigurationManager.AppSettings["RemoveMessagesFromQueue"];
				if(delete=="True")
				{file.WriteLine("Deleting message from Queue");
					
				corrid = Guid.NewGuid().ToString();
			    now = DateTime.Now;
			    myRequest.CASRequestData.Header = new wse.CitizenAccountRequestHeaderType();
			    myRequest.CASRequestData.Header.CorrelationID=corrid;
			    myRequest.CASRequestData.Header.UserID=council;
			    myRequest.CASRequestData.Header.PartnerID=partnerID;
			    myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
				
			mystatus = new Status();

				
				myRequest.CASRequestData.Any = acknowledgeNoticiation(notifcationID);
					StringWriter writer5 = new StringWriter();
                    x.Serialize(writer5,myRequest);
		    	     string xmlstring5 = writer5.ToString();
//		    	      
		    	    file.WriteLine();
		    	      	file.WriteLine("Acknowledge Noticiation");
		    	      	file.WriteLine();
		    	    file.WriteLine(xmlstring5);
		    	    
		    	    MyResponse = myWseEndpoint.sendCitizenAccountMessage(myRequest);
		    	    StringWriter writer6 = new StringWriter();
                    y.Serialize(writer6, MyResponse);
		    	     string xmlstring6 = writer6.ToString();
//		    	      
		    	    file.WriteLine();
		    	      	file.WriteLine("Message Detials:");
		    	      	file.WriteLine();
		    	    file.WriteLine(xmlstring6);
				}
				else
				{file.WriteLine("Message left on  Queue");
				}
				
			}
			file.Close();
			}
			catch(SoapException soapEx)
			{ 
	MessageBox.Show(soapEx.Code.ToString());
    //Load the Detail element of the SoaopException object
    Trace.WriteLine("**********************************************");
    Trace.WriteLine("---------------- SOAP Exception --------------");
    Trace.WriteLine("SOAP Exception Code :" + soapEx.Code.Name.ToString()+", "+soapEx.Code.ToString()+", ");
    Trace.WriteLine(soapEx.Detail.OuterXml);
    Trace.WriteLine(soapEx.Message);

    Trace.WriteLine("---------------- Enf of Exception --------------");
    Trace.WriteLine("************************************************");

			}
//			
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				DisplayException(ex);
				
			}

            
			
			
		}
		void LiveNotificationBtnClick(object sender, System.EventArgs e)
		{
			wse.CASEndpointBean liveWseEndpoint = new CASEndpointBean();
			//liveWseEndpoint.Url="https://la1.scottishcitizen.gov.uk/CASWebService/CASEndpointBean";
			//liveWseEndpoint.Url="http://calamid2.scottishcitizen.live/CASWebService/CASEndpointBean";
			liveWseEndpoint.Url="http://la1.scottishcitizen.gov.uk/CASWebService/CASEndpointBean";
			string filename = string.Empty;
			string partnerID= "09";;
			string council ="Dundee";
			filename = "Live_Testing_"+council+"_"+DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")+".txt";
			
			System.IO.StreamWriter file = new StreamWriter(filename);
			CitizenAccountRequestMessage myRequest =  new CitizenAccountRequestMessage();
			myRequest.CASRequestData = new CitizenAccountRequestType();
			myRequest.CASRequestData.Header= new CitizenAccountRequestHeaderType();
		
			myRequest.CASRequestData.Header.CorrelationID= Guid.NewGuid().ToString();
			myRequest.CASRequestData.Header.UserID="Test";
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID=partnerID;
		    myRequest.CASRequestData.Any= listNotification();
		 
			
		    CitizenAccountResponseMessage MyResponse = new CitizenAccountResponseMessage();
			XmlDocument requestDoc = new XmlDocument(); 
			requestDoc.LoadXml(myRequest.CASRequestData.Any.OuterXml);
			MessageBox.Show(myRequest.CASRequestData.Any.OuterXml);
			Trace.WriteLine(myRequest.CASRequestData.Any.OuterXml);
			
			treeView1.Nodes.Clear();
			treeView1.Nodes.Add(new TreeNode(requestDoc.DocumentElement.Name));
			TreeNode tNode = new TreeNode();
			tNode = treeView1.Nodes[0];
			AddNode(requestDoc.DocumentElement, tNode);
			treeView1.ExpandAll();
			MessageBox.Show("send  request");
			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
			System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(MyResponse.GetType());
		    try{ 
				      
				      StringWriter writer = new StringWriter();
                      x.Serialize(writer,myRequest);
		    	      string xmlstring = writer.ToString();
		    	      DateTime date = DateTime.Now;
		    	      file.WriteLine(" Test of Notification from CAS " + date);
		    	      file.WriteLine();
		    	      file.WriteLine( "requesting Notification List");
		    	      file.WriteLine();
		    	      file.WriteLine("********************************************************************************");
		    	       file.WriteLine(" List  of   Notifications");
		    	      Trace.WriteLine(xmlstring);
		    	      
//		    	      Get Proxy Settings
//		    	      string proxyStr= System.Configuration.ConfigurationManager.AppSettings["Proxy"];
//			
//						 if (((proxyStr != null) 
//			                        && (proxyStr != "")))
//			            {//Create Web Proxy
//						WebProxy myProxy = new WebProxy( proxyStr ,true);
//						string domain =System.Configuration.ConfigurationManager.AppSettings["ProxyDomain"];
//						string user = System.Configuration.ConfigurationManager.AppSettings["ProxyUser"];
//						string password =System.Configuration.ConfigurationManager.AppSettings["ProxyPassword"];
//						if ((domain !="")&&(domain !=null))
//							{System.Net.NetworkCredential mycredentials = new NetworkCredential(user,password,domain);
//							myProxy.Credentials= mycredentials;
//							}
//						else if((user !="")&&(user !=null)&& (domain !="")&&(domain !=null))
//						{
//							System.Net.NetworkCredential mycredentials = new NetworkCredential(user,password);
//							myProxy.Credentials= mycredentials;	
//						}
//		    	     liveWseEndpoint.Proxy= myProxy; }
					    	      
		    	  
		    	    liveWseEndpoint.SetPolicy("NHS");
			           MyResponse =liveWseEndpoint.sendCitizenAccountMessage(myRequest);
			           //MessageBox.Show( MyResponse.CASResponseData.Status.StatusCode.Value.ToString());
			XmlDocument NotificationsDoc = new XmlDocument();
			XmlDocument responseXML= new XmlDocument();
			
			responseXML.LoadXml(MyResponse.CASResponseData.Any.OuterXml);
			StringWriter writer3 = new StringWriter();
                      y.Serialize(writer3,MyResponse);
		    	      string xmlstring3 = writer3.ToString();
		    	      file.WriteLine(xmlstring3);
			treeView1.Nodes.Clear();
			treeView1.Nodes.Add(new TreeNode(responseXML.DocumentElement.Name));
			tNode = new TreeNode();
			tNode = treeView1.Nodes[0];

			// SECTION 3. Populate the TreeView with the DOM nodes.
			AddNode(responseXML.DocumentElement, tNode);
			treeView1.ExpandAll();
			
			
			
			NotificationsDoc.LoadXml(MyResponse.CASResponseData.Any.OuterXml);
			XmlNodeList Nodelist = NotificationsDoc.SelectNodes("//Notification");
			
			
			foreach(XmlNode node in Nodelist)
			{
				string notifcationID = string.Empty;
				string notificationType = string.Empty;
				XmlDocument tempxml = new XmlDocument();
				tempxml.LoadXml(node.OuterXml);

				notifcationID = tempxml.SelectSingleNode("//NotificationID").InnerText;
				
				//MessageBox.Show(node.OuterXml);
			
				//MessageBox.Show(tempxml.SelectSingleNode("//NotificationType").InnerText);
					//Console.ReadKey();
					
				notificationType = tempxml.SelectSingleNode("//NotificationType").InnerText;
				
				//write notifiation type and notification ID to output file
				//file.WriteLine("Notification Type = "+ notificationType + ", NotificationID = "+ 	notifcationID);
				file.WriteLine();
				file.WriteLine("*******************************************************************************");
				string message= "process Notification:"+ notifcationID+" which is of type "+notificationType;
				//MessageBox.Show(message);
				string corrid = Guid.NewGuid().ToString();
				DateTime now = DateTime.Now;
				myRequest.CASRequestData.Header = new wse.CitizenAccountRequestHeaderType();
				myRequest.CASRequestData.Header.CorrelationID=corrid;
				myRequest.CASRequestData.Header.UserID=council;
				myRequest.CASRequestData.Header.PartnerID=partnerID;
				myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
				// just in to check code remove once we have proper  web services
				Status mystatus = new Status();

				
				myRequest.CASRequestData.Any = requestNotification(notifcationID);
				responseXML.LoadXml(myRequest.CASRequestData.Any.OuterXml);
				
				treeView1.Nodes.Clear();
				treeView1.Nodes.Add(new TreeNode(responseXML.DocumentElement.Name));
				tNode = new TreeNode();
				tNode = treeView1.Nodes[0];
				
				// SECTION 3. Populate the TreeView with the DOM nodes.
				AddNode(responseXML.DocumentElement, tNode);
				treeView1.ExpandAll();
				//MessageBox.Show("Send request notification:" + notificationType +" Notification id:" + notifcationID);
				file.WriteLine("Request notification:" + notificationType +" Notification id:" + notifcationID);
				file.WriteLine();
				StringWriter writer2 = new StringWriter();
                      x.Serialize(writer2,myRequest);
		    	      string xmlstring2 = writer2.ToString();
		    	      
		    	      Trace.WriteLine(xmlstring2);
		    	      
		    	      file.WriteLine(xmlstring2);
		    	      file.WriteLine();
				MyResponse = liveWseEndpoint.sendCitizenAccountMessage(myRequest);
				
				
				responseXML.LoadXml(MyResponse.CASResponseData.Any.OuterXml);
				StringWriter writer4 = new StringWriter();
                      y.Serialize(writer4,MyResponse);
		    	      string xmlstring4 = writer4.ToString();
//		    	      
		    	      file.WriteLine();
		    	      	file.WriteLine(notificationType + "Message Detials:");
		    	      	file.WriteLine();
		    	      file.WriteLine(xmlstring4);
				  //file.WriteLine(responseXML.OuterXml);
				treeView1.Nodes.Clear();
				treeView1.Nodes.Add(new TreeNode(responseXML.DocumentElement.Name));
				tNode = new TreeNode();
				tNode = treeView1.Nodes[0];

				// SECTION 3. Populate the TreeView with the DOM nodes.
				AddNode(responseXML.DocumentElement, tNode);
				treeView1.ExpandAll();
				
				
				
				string delete=System.Configuration.ConfigurationManager.AppSettings["RemoveMessagesFromQueue"];
				if(delete=="True")
				{file.WriteLine("Deleting message from Queue");
					
				corrid = Guid.NewGuid().ToString();
			    now = DateTime.Now;
			    myRequest.CASRequestData.Header = new wse.CitizenAccountRequestHeaderType();
			    myRequest.CASRequestData.Header.CorrelationID=corrid;
			    myRequest.CASRequestData.Header.UserID=council;
			    myRequest.CASRequestData.Header.PartnerID=partnerID;
			    myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
				
			mystatus = new Status();

				
				myRequest.CASRequestData.Any = acknowledgeNoticiation(notifcationID);
					StringWriter writer5 = new StringWriter();
                    x.Serialize(writer5,myRequest);
		    	     string xmlstring5 = writer5.ToString();
//		    	      
		    	    file.WriteLine();
		    	      	file.WriteLine("Acknowledge Noticiation");
		    	      	file.WriteLine();
		    	    file.WriteLine(xmlstring5);
		    	    
		    	    MyResponse = liveWseEndpoint.sendCitizenAccountMessage(myRequest);
		    	    StringWriter writer6 = new StringWriter();
                    y.Serialize(writer6, MyResponse);
		    	     string xmlstring6 = writer6.ToString();
//		    	      
		    	    file.WriteLine();
		    	      	file.WriteLine("Message Detials:");
		    	      	file.WriteLine();
		    	    file.WriteLine(xmlstring6);
				}
				else
				{file.WriteLine("Message left on  Queue");
				}
				
			}
			file.Close();
			}
			catch(SoapException soapEx)
			{ 
	MessageBox.Show(soapEx.Code.ToString());
    //Load the Detail element of the SoaopException object
    Trace.WriteLine("**********************************************");
    Trace.WriteLine("---------------- SOAP Exception --------------");
    Trace.WriteLine("SOAP Exception Code :" + soapEx.Code.Name.ToString()+", "+soapEx.Code.ToString()+", ");
    Trace.WriteLine(soapEx.Detail.OuterXml);
    Trace.WriteLine(soapEx.Message);

    Trace.WriteLine("---------------- Enf of Exception --------------");
    Trace.WriteLine("************************************************");

			}
//			
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				DisplayException(ex);
				
			}

		}
		
		void NorthLanQueueClick(object sender, EventArgs e)
		{
			//Create output  file
			string filename = string.Empty;
			string partnerID= System.Configuration.ConfigurationManager.AppSettings["NorthLanPartnerID"];
			string council =System.Configuration.ConfigurationManager.AppSettings["NorthLanCouncil"];
			filename = "UAT_Testing_"+council+"_"+DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")+".txt";
			
			System.IO.StreamWriter file = new StreamWriter(filename);
			
			CitizenAccountRequestMessage myRequest =  new CitizenAccountRequestMessage();
			myRequest.CASRequestData = new CitizenAccountRequestType();
			myRequest.CASRequestData.Header= new CitizenAccountRequestHeaderType();
		
			myRequest.CASRequestData.Header.CorrelationID= Guid.NewGuid().ToString();
			myRequest.CASRequestData.Header.UserID=council;
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID=partnerID;
		    myRequest.CASRequestData.Any= listNotification();
		 
			
		    CitizenAccountResponseMessage MyResponse = new CitizenAccountResponseMessage();
			XmlDocument requestDoc = new XmlDocument(); 
			requestDoc.LoadXml(myRequest.CASRequestData.Any.OuterXml);
			MessageBox.Show(myRequest.CASRequestData.Any.OuterXml);
			Trace.WriteLine(myRequest.CASRequestData.Any.OuterXml);
			
			treeView1.Nodes.Clear();
			treeView1.Nodes.Add(new TreeNode(requestDoc.DocumentElement.Name));
			TreeNode tNode = new TreeNode();
			tNode = treeView1.Nodes[0];
			AddNode(requestDoc.DocumentElement, tNode);
			treeView1.ExpandAll();
			MessageBox.Show("send  request");
			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
			System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(MyResponse.GetType());
		    try{ 
				      
				      StringWriter writer = new StringWriter();
                      x.Serialize(writer,myRequest);
		    	      string xmlstring = writer.ToString();
		    	      DateTime date = DateTime.Now;
		    	      file.WriteLine(" Test of Notification from CAS " + date);
		    	      file.WriteLine();
		    	      file.WriteLine( "requesting Notification List");
		    	      file.WriteLine();
		    	      file.WriteLine("********************************************************************************");
		    	       file.WriteLine(" List  of   Notifications");
		    	      Trace.WriteLine(xmlstring);
		    	      
//		    	      Get Proxy Settings
		    	      string proxyStr= System.Configuration.ConfigurationManager.AppSettings["Proxy"];
			
						 if (((proxyStr != null) 
			                        && (proxyStr != "")))
			            {//Create Web Proxy
						WebProxy myProxy = new WebProxy( proxyStr ,true);
						string domain =System.Configuration.ConfigurationManager.AppSettings["ProxyDomain"];
						string user = System.Configuration.ConfigurationManager.AppSettings["ProxyUser"];
						string password =System.Configuration.ConfigurationManager.AppSettings["ProxyPassword"];
						if ((domain !="")&&(domain !=null))
							{System.Net.NetworkCredential mycredentials = new NetworkCredential(user,password,domain);
							myProxy.Credentials= mycredentials;
							}
						else if((user !="")&&(user !=null)&& (domain !="")&&(domain !=null))
						{
							System.Net.NetworkCredential mycredentials = new NetworkCredential(user,password);
							myProxy.Credentials= mycredentials;	
						}
		    	      myWseEndpoint.Proxy= myProxy; }
					    	      
		    	      
		    	      myWseEndpoint.SetPolicy("NorthLan");
			           MyResponse =myWseEndpoint.sendCitizenAccountMessage(myRequest);
			           //MessageBox.Show( MyResponse.CASResponseData.Status.StatusCode.Value.ToString());
			XmlDocument NotificationsDoc = new XmlDocument();
			XmlDocument responseXML= new XmlDocument();
			
			responseXML.LoadXml(MyResponse.CASResponseData.Any.OuterXml);
			StringWriter writer3 = new StringWriter();
                      y.Serialize(writer3,MyResponse);
		    	      string xmlstring3 = writer3.ToString();
		    	      file.WriteLine(xmlstring3);
			treeView1.Nodes.Clear();
			treeView1.Nodes.Add(new TreeNode(responseXML.DocumentElement.Name));
			tNode = new TreeNode();
			tNode = treeView1.Nodes[0];

			// SECTION 3. Populate the TreeView with the DOM nodes.
			AddNode(responseXML.DocumentElement, tNode);
			treeView1.ExpandAll();
			
			
			
			NotificationsDoc.LoadXml(MyResponse.CASResponseData.Any.OuterXml);
			XmlNodeList Nodelist = NotificationsDoc.SelectNodes("//Notification");
			
			
			foreach(XmlNode node in Nodelist)
			{
				string notifcationID = string.Empty;
				string notificationType = string.Empty;
				XmlDocument tempxml = new XmlDocument();
				tempxml.LoadXml(node.OuterXml);

				notifcationID = tempxml.SelectSingleNode("//NotificationID").InnerText;
				
				//MessageBox.Show(node.OuterXml);
			
				//MessageBox.Show(tempxml.SelectSingleNode("//NotificationType").InnerText);
					//Console.ReadKey();
					
				notificationType = tempxml.SelectSingleNode("//NotificationType").InnerText;
				
				//write notifiation type and notification ID to output file
				//file.WriteLine("Notification Type = "+ notificationType + ", NotificationID = "+ 	notifcationID);
				file.WriteLine();
				file.WriteLine("*******************************************************************************");
				string message= "process Notification:"+ notifcationID+" which is of type "+notificationType;
				//MessageBox.Show(message);
				string corrid = Guid.NewGuid().ToString();
				DateTime now = DateTime.Now;
				myRequest.CASRequestData.Header = new wse.CitizenAccountRequestHeaderType();
				myRequest.CASRequestData.Header.CorrelationID=corrid;
				myRequest.CASRequestData.Header.UserID=council;
				myRequest.CASRequestData.Header.PartnerID=partnerID;
				myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
				// just in to check code remove once we have proper  web services
				Status mystatus = new Status();

				
				myRequest.CASRequestData.Any = requestNotification(notifcationID);
				responseXML.LoadXml(myRequest.CASRequestData.Any.OuterXml);
				
				treeView1.Nodes.Clear();
				treeView1.Nodes.Add(new TreeNode(responseXML.DocumentElement.Name));
				tNode = new TreeNode();
				tNode = treeView1.Nodes[0];
				
				// SECTION 3. Populate the TreeView with the DOM nodes.
				AddNode(responseXML.DocumentElement, tNode);
				treeView1.ExpandAll();
				//MessageBox.Show("Send request notification:" + notificationType +" Notification id:" + notifcationID);
				file.WriteLine("Request notification:" + notificationType +" Notification id:" + notifcationID);
				file.WriteLine();
				StringWriter writer2 = new StringWriter();
                      x.Serialize(writer2,myRequest);
		    	      string xmlstring2 = writer2.ToString();
		    	      
		    	      Trace.WriteLine(xmlstring2);
		    	      
		    	      file.WriteLine(xmlstring2);
		    	      file.WriteLine();
				MyResponse = myWseEndpoint.sendCitizenAccountMessage(myRequest);
				
				
				responseXML.LoadXml(MyResponse.CASResponseData.Any.OuterXml);
				StringWriter writer4 = new StringWriter();
                      y.Serialize(writer4,MyResponse);
		    	      string xmlstring4 = writer4.ToString();
//		    	      
		    	      file.WriteLine();
		    	      	file.WriteLine(notificationType + "Message Detials:");
		    	      	file.WriteLine();
		    	      file.WriteLine(xmlstring4);
				  //file.WriteLine(responseXML.OuterXml);
				treeView1.Nodes.Clear();
				treeView1.Nodes.Add(new TreeNode(responseXML.DocumentElement.Name));
				tNode = new TreeNode();
				tNode = treeView1.Nodes[0];

				// SECTION 3. Populate the TreeView with the DOM nodes.
				AddNode(responseXML.DocumentElement, tNode);
				treeView1.ExpandAll();
				string delete=System.Configuration.ConfigurationManager.AppSettings["RemoveMessagesFromQueue"];
				if(delete=="True")
				{file.WriteLine("Deleting message from Queue");
					
				corrid = Guid.NewGuid().ToString();
			    now = DateTime.Now;
			    myRequest.CASRequestData.Header = new wse.CitizenAccountRequestHeaderType();
			    myRequest.CASRequestData.Header.CorrelationID=corrid;
			    myRequest.CASRequestData.Header.UserID=council;
			    myRequest.CASRequestData.Header.PartnerID=partnerID;
			    myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
				
			mystatus = new Status();

				
				myRequest.CASRequestData.Any = acknowledgeNoticiation(notifcationID);
					StringWriter writer5 = new StringWriter();
                    x.Serialize(writer5,myRequest);
		    	     string xmlstring5 = writer5.ToString();
//		    	      
		    	    file.WriteLine();
		    	      	file.WriteLine("Acknowledge Noticiation");
		    	      	file.WriteLine();
		    	    file.WriteLine(xmlstring5);
		    	    MyResponse = myWseEndpoint.sendCitizenAccountMessage(myRequest);
		    	    StringWriter writer6 = new StringWriter();
                   y.Serialize(writer6, MyResponse);
		    	     string xmlstring6 = writer6.ToString();
//		    	      
		    	    file.WriteLine();
		    	      	file.WriteLine("Message Detials:");
		    	      	file.WriteLine();
		    	    file.WriteLine(xmlstring6);
				}
				else
				{file.WriteLine("Message left on  Queue");
				}
				
			}
			file.Close();
			}
			catch(SoapException soapEx)
			{ 
	MessageBox.Show(soapEx.Code.ToString());
    //Load the Detail element of the SoaopException object
   file.WriteLine("**********************************************");
    Trace.WriteLine("---------------- SOAP Exception --------------");
    Trace.WriteLine("SOAP Exception Code :" + soapEx.Code.Name.ToString()+", "+soapEx.Code.ToString()+", ");
    Trace.WriteLine(soapEx.Detail.OuterXml);
    Trace.WriteLine(soapEx.Message);

    Trace.WriteLine("---------------- Enf of Exception --------------");
    Trace.WriteLine("************************************************");

			}
//			
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				DisplayException(ex);
				
			}

            
		}
		
		
		
		
		void RegCitizenBtnClick(object sender, EventArgs e)
		{       string forename =ForenametBox1.Text ;
				string surname = SurnameBox1.Text;
				string dateofbirth = DateOfBirthBox1.Text;
				string orginisation = OrginisationCombo.Text; 
				string gender = Gendercombo.Text;
			    string partnerID = string.Empty;
			    string idProof1 = identityBox1.Text;
			    string idProof2= identityBox2.Text;
			    string resProof1 = residencyBox1.Text;
			    string resProof2=residencyBox2.Text;
			    string uprn= UPRNBox1.Text ;
			    string addressline1 = Addressline1.Text;
			    string addressline2= Addressline2.Text;
			    string town = TownText.Text;
			    string postcode = PostCodeTxt.Text;
			    
			    try{
			    if (orginisation== string.Empty) throw new System.ArgumentException("Orginisation cannot  be null please select an oginisation from the Combo Box" );
				if (dateofbirth ==string.Empty)throw new System.ArgumentException("date of Birth not filled in");
				if (forename== string.Empty)throw new System.ArgumentException("Forename  not filled in");
				if (surname==string.Empty) throw new System.ArgumentException("Surname not filled in");
				if (gender== string.Empty)throw new System.ArgumentException("Gender not selected from Combo box");
				if (idProof1== string.Empty)throw new System.ArgumentException("1st Proof of Identity not selected from Combo box");
				if (idProof2== string.Empty)throw new System.ArgumentException("2nd Proof of Identity not selected from Combo box");
				if (resProof1== string.Empty)throw new System.ArgumentException("1st Proof of Residency not selected from Combo box");
				if (resProof2== string.Empty)throw new System.ArgumentException("2nd Proof of Residency not selected from Combo box");
				if (idProof1== idProof2)throw new System.ArgumentException("Need to select  two different Proofs of Identity");
				if (resProof1== resProof2)throw new System.ArgumentException("Need to select  two different Proofs of Residency");
				//!if (uprn==string.Empty) throw new System.ArgumentException("UPRN not filled in");
			    int genderBit=GenderBit(gender);
				partnerID =PartnerID(orginisation);
				
				string	corrid = Guid.NewGuid().ToString();
			CitizenAccountRequestMessage myRequest =  new CitizenAccountRequestMessage();
			myRequest.CASRequestData = new CitizenAccountRequestType();
			myRequest.CASRequestData.Header= new CitizenAccountRequestHeaderType();
		
			myRequest.CASRequestData.Header.CorrelationID= corrid;
			myRequest.CASRequestData.Header.UserID=orginisation;
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID=partnerID;
			
			string consent = string.Empty;
			if(consentBox1.Checked)
			{ consent="yes";
			}
			else
			{
				consent="no";
			}
//			
			idProof2 = IdentityProof(idProof2);
			idProof1= IdentityProof(idProof1);
			resProof2=ResidencyProof(resProof2);
			resProof1=ResidencyProof(resProof1);
			
			if (uprn!= string.Empty)
	        
			{myRequest.CASRequestData.Any= CitizenRegistration(dateofbirth,forename,surname,genderBit,uprn, idProof1, idProof2, resProof1,  resProof2,  consent);
			}
			else
			{
				myRequest.CASRequestData.Any= CitizenRegistration(dateofbirth,forename,surname,genderBit,addressline1,addressline2,town,postcode, idProof1, idProof2, resProof1,  resProof2,  consent);
				
			}
				CitizenAccountResponseMessage MyResponse = new CitizenAccountResponseMessage();
			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
			System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(MyResponse.GetType());
			
		    Trace.WriteLine("--------------------------------------------------------------------------------");
		    Trace.WriteLine("                      UCRN Query   Request Message                    ");
		      Trace.WriteLine("--------------------------------------------------------------------------------");
			
			StringWriter writer5 = new StringWriter();
                    x.Serialize(writer5,myRequest);
                    string xmlstring5 = writer5.ToString();
	        Trace.WriteLine(xmlstring5);
	       RequestTextBox1.Text= xmlstring5;
	        RequestTextBox1.Update();
	        MessageBox.Show( xmlstring5);
	        
			//myWseEndpoint.SetPolicy("NorthLan");
			
		    // myWseEndpoint.SetPolicy("Seemis");
		
			
			MyResponse=myWseEndpoint.sendCitizenAccountMessage(myRequest);
			XmlDocument responseXML = new XmlDocument();
			StringWriter writer6= new StringWriter();
                    y.Serialize(writer6,MyResponse);
                    string xmlstring6 = writer6.ToString();
                    CitizenRegResults.Text=xmlstring6;
                    CitizenRegResults.Update();
                    
                    MessageBox.Show(xmlstring6,"Results of Query:" );
			    }
			    catch(SoapException se)
			    {MessageBox.Show( "An exception has occurred: " + se.Message );
			    	DisplayException(se);
			    }
			    catch(WebException we)
			    {
			    	MessageBox.Show(we.Message);
			    }
			    catch(Exception ex)
			    {

                               
			    	MessageBox.Show(ex.Message +ex.Source+ ex.InnerException.Message );
					DisplayException(ex);
			    }
				
		}
		
		void RegCitizenNECBtnClick(object sender, EventArgs e)
		{
			string myNEC =NECNumberBox1.Text ; 
			string orginisation = OrginisationCombo.Text; 
			try
			{
				if (myNEC== string.Empty) throw new System.ArgumentException("NEC Number  cannot  be null please select an oginisation from the Combo Box" );
				if (orginisation== string.Empty) throw new System.ArgumentException("Orginisation cannot  be null please select an oginisation from the Combo Box" );
				
				string partnerID =PartnerID(orginisation);
				string	corrid = Guid.NewGuid().ToString();
			CitizenAccountRequestMessage myRequest =  new CitizenAccountRequestMessage();
			myRequest.CASRequestData = new CitizenAccountRequestType();
			myRequest.CASRequestData.Header= new CitizenAccountRequestHeaderType();
		
			myRequest.CASRequestData.Header.CorrelationID= corrid;
			myRequest.CASRequestData.Header.UserID=orginisation;
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID=partnerID;
			string consent = string.Empty;
			if(consentBox1.Checked)
			{ consent="yes";
			}
			else
			{
				consent="no";
			}
			myRequest.CASRequestData.Any= CitizenRegistration(myNEC);
			CitizenAccountResponseMessage MyResponse = new CitizenAccountResponseMessage();
			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
			System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(MyResponse.GetType());
			
		    Trace.WriteLine("--------------------------------------------------------------------------------");
		    Trace.WriteLine("                      UCRN Query   Request Message                    ");
		      Trace.WriteLine("--------------------------------------------------------------------------------");
			
			StringWriter writer5 = new StringWriter();
                    x.Serialize(writer5,myRequest);
                    string xmlstring5 = writer5.ToString();
	        Trace.WriteLine(xmlstring5);
	        MessageBox.Show( xmlstring5);
	        
			//myWseEndpoint.SetPolicy("NorthLan");
			
		    // myWseEndpoint.SetPolicy("Seemis");
		
			
			MyResponse=myWseEndpoint.sendCitizenAccountMessage(myRequest);
			XmlDocument responseXML = new XmlDocument();
			StringWriter writer6= new StringWriter();
                    y.Serialize(writer6,MyResponse);
                    string xmlstring6 = writer6.ToString();
                    CitizenRegResults.Text=xmlstring6;
                    CitizenRegResults.Update();
                    
                    MessageBox.Show(xmlstring6,"Results of Registration:" );	
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"Error");
				DisplayException(ex);
			}
		}
		private int GenderBit( string Gender)
		{
			int genderBit =0;
			switch(Gender)
			{ case "Male":
						genderBit=1;
						break;
				 case "Female":
						genderBit=2;
						break;
					default:
						break;
				}
			return genderBit;
			
		}
		
		private string PartnerID (string Orginisation)
		{  string partnerID =string.Empty;
			switch(Orginisation)
			{		case "StirlingCouncil":
						partnerID ="30";
						 myWseEndpoint.SetPolicy("Seemis");
						break;
					case "NorthLanarkshireCouncil":
						 partnerID="22";
						 myWseEndpoint.SetPolicy("NorthLan");
					     break;
					case "CareFX":
					     partnerID="CFX";
					     	break;
					case "NHSTayside":
					     partnerID ="NHST";
					     break;
					    case "Seemis":
					     	partnerID="SEMS";
					     	break;
					default:
					     break;
					
			}return partnerID;				
		}
			
		
		
		private string IdentityProof( string idProof)
		{
			string ID =string.Empty;
			switch(idProof)
			{
				case "Birth Certificate":
					ID="01";
					break;
				case "Passport":
					ID="02";
					break;
					
				case "Photo Driving Licence":
					ID="03";
					break;
				case	"Adoption Certificate":
					ID="04";
					break;
				case	"Marriage Certificate":
					ID="05";
					break;
				case	"Young Scot or other PASS hologrammed card":
					ID="06";
					break;
				case	"Benefit book":
					ID="07";
					break;
				case	"Old style Driving Licence":
					ID="08";
					break;
				case	"SEEMIS or Other Education MIS":
					ID="09";
					break;
				case	"Validated Young Scot Application Form":
					ID="10";
					break;
				case	"Over 60 travel only":
					ID="11";
					break;
				case	"Only One Identity Proof Required by the Local Authority":
					ID="OnlyOne";
					break;
				case	"CRM":
					ID="CRM";
					break;
				case	"NEC":
					ID="NEC";
					break;
			
					default:
					     break;
					     
						
					}
			return ID;
	
		}
		
		private string ResidencyProof(string ResProof)
		{
			string ID =string.Empty;
			switch(ResProof)
					{
				case "Recent Bank or Building Society statement":
					ID="01";
					break;
				case "Photo Driving Licence":
					ID="02";
					break;
					
				case "Court Order":
					ID="03";
					break;
				case	"Local council rent/tenancy agreement":
					ID="04";
					break;
				case	"Council Tax Bill (for current financial year)":
					ID="05";
					break;
				case	"Recent Original Mortgage Statement":
					ID="06";
					break;
				case	"Recent Utility Bill":
					ID="07";
					break;
				case	"Benefit Book/Card/or Original Notification":
					ID="08";
					break;
				case	"Confirmation from an Electoral Search":
					ID="09";
					break;
				case	"Evidence from School/College/University":
					ID="10";
					break;
				case	"TV Licence":
					ID="11";
					break;
				case	"Letter from Care/Residential Home":
					ID="12";
					break;
				case	"Letter from LA (confirming applicant is resident within council area)":
					ID="13";
					break;
				case	"Award letter for Child Benefit":
					ID="14";
					break;
				case	"Letter from Home Office or Immigration Office":
					ID="15";
					break;
				case	"Old style Driving Licence":
					ID="16";
					break;
				case	"Address Proof from School":
					ID="17";
					break;
				case	"Over 60 travel":
					ID="18";
					break;
				case	"CRM":
					ID="CRM";
					break;
				case	"NEC":
					ID="NEC";
					break;
					default:
					     break;
					     
						
					}
			return ID;
	
		}
		void QueryUCRNClick(object sender, EventArgs e)
		{ 		string forename =QueryUCRNForename.Text ;
				string surname = QueryUCRNSurname.Text;
				string dateofbirth = QueryUCRNDateofBirth.Text;
				string orginisation = QueryUCRNOrginisation.Text; 
				
			try{
				
			string gender = QueryUCRNGender.Text;
				MessageBox.Show(gender +", "+ orginisation);
				
					if (orginisation== string.Empty) throw new System.ArgumentException("Orginisation cannot  be null please select an oginisation from the Combo Box" );
				if (dateofbirth ==string.Empty)throw new System.ArgumentException("date of Birth not filled in");
				if (forename== string.Empty)throw new System.ArgumentException("Forename  not filled in");
				if (surname==string.Empty) throw new System.ArgumentException("Surname not filled in");
				if (gender== string.Empty)throw new System.ArgumentException("Gender not selected from Combo box");
				int genderBit = GenderBit(gender);
				MessageBox.Show("Gender ="+genderBit);
				string partnerID = PartnerID(orginisation);
			
				

			string	corrid = Guid.NewGuid().ToString();
			CitizenAccountRequestMessage myRequest =  new CitizenAccountRequestMessage();
			myRequest.CASRequestData = new CitizenAccountRequestType();
			myRequest.CASRequestData.Header= new CitizenAccountRequestHeaderType();
		
			myRequest.CASRequestData.Header.CorrelationID= corrid;
			myRequest.CASRequestData.Header.UserID=orginisation;
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID=partnerID;
			
	        myRequest.CASRequestData.Any= UCRNQuery(dateofbirth,forename,surname,genderBit);
	     
			CitizenAccountResponseMessage MyResponse = new CitizenAccountResponseMessage();
			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
			System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(MyResponse.GetType());
			
		    Trace.WriteLine("--------------------------------------------------------------------------------");
		    Trace.WriteLine("                      UCRN Query   Request Message                    ");
		      Trace.WriteLine("--------------------------------------------------------------------------------");
			
			StringWriter writer5 = new StringWriter();
                    x.Serialize(writer5,myRequest);
                    string xmlstring5 = writer5.ToString();
	        Trace.WriteLine(xmlstring5);
	        MessageBox.Show( xmlstring5);
	   
			
		     
		
			
			MyResponse=myWseEndpoint.sendCitizenAccountMessage(myRequest);
			XmlDocument responseXML = new XmlDocument();
			StringWriter writer6= new StringWriter();
                    y.Serialize(writer6,MyResponse);
                    string xmlstring6 = writer6.ToString();
                   QueryUCRNResults.Text=xmlstring6;
                   SeoQueryUCRN_v0_1Doc doc = new SeoQueryUCRN_v0_1Doc();
                   
                
                     XmlDocument myXML = new XmlDocument();
                   	myXML.LoadXml(MyResponse.CASResponseData.Any.OuterXml);
                   QueryUCRNResponseType myQueryResponse = new QueryUCRNResponseType(myXML);
                   
                   
                   
                   UCRNBox.Text=myQueryResponse.GetUCRN().Value;
                 
                  ucrnTxt.Text =myQueryResponse.GetUCRN().Value;
                  FornameText.Text=myQueryResponse.GetCitizenDetails().GetForename().Value;
                  FornameText.Update();
                  SurnameText.Text=myQueryResponse.GetCitizenDetails().GetSurname().Value;
                  DOBTEXT.Text=myQueryResponse.GetCitizenDetails().GetDateOfBirth().Value.ToLongDateString();
                  switch(myQueryResponse.GetCitizenDetails().GetGender().Value)
                  { case 1:
                  		
                    GenderText.Text="Male";
                  		break;
                  		case 2:
                  		GenderText.Text="Female";
                  		break;
                  	default:
                  		break;
                  	
                  }
                      QueryUCRNResults.Update();
                    
                    
                    MessageBox.Show(xmlstring6,"Results of Query:" );
//	        Trace.WriteLine(xmlstring6);
//                responseXML.Load(xmlstring6);
//				treeViewQuery.Nodes.Clear();
//				treeViewQuery.Nodes.Add(new TreeNode(responseXML.DocumentElement.Name));
//				TreeNode tNode = new TreeNode();
//				tNode = treeView1.Nodes[0];
//				
//				// SECTION 3. Populate the TreeView with the DOM nodes.
//				AddNode(responseXML.DocumentElement, tNode);
//				treeView1.ExpandAll();
			
			Trace.WriteLine("--------------------------------------------------------------------------------");
		    Trace.WriteLine("                        Response  message from UCRN Query                       ");
		     Trace.WriteLine("--------------------------------------------------------------------------------");
			Trace.WriteLine(xmlstring6);
				}
				catch(SoapException soapEx)
			{ 
	MessageBox.Show(soapEx.Code.ToString());
    //Load the Detail element of the SoaopException object
   Trace.WriteLine("**********************************************");
    Trace.WriteLine("---------------- SOAP Exception --------------");
    Trace.WriteLine("SOAP Exception Code :" + soapEx.Code.Name.ToString()+", "+soapEx.Code.ToString()+", ");
    Trace.WriteLine(soapEx.Detail.OuterXml);
    Trace.WriteLine(soapEx.Message);

    Trace.WriteLine("---------------- Enf of Exception --------------");
    Trace.WriteLine("************************************************");

			}
				catch (Exception ex)
				{MessageBox.Show(ex.Message);
					DisplayException(ex);
				 }
				
		}
		
		
		private XmlElement CASAuthentication(string Guid)
		{ //CASAuthentication_v0_1.CASAuthenticationRequestType myAuthentication = new CASAuthentication_v0_1.CASAuthenticationRequestType.MemberElement_BoSGUID();
		CASAuthentication_v0_1Doc doc = new  CASAuthentication_v0_1Doc();
		doc.SetSchemaLocation("CASAuthentication_v0_1.xsd"); // optional
		CASAuthenticationRequestType root = new CASAuthenticationRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "CASAuthenticationRequest");
		
		LA_CAS_Messages.core3.BoSGUIDType GUID= root.NewBoSGUID();
			GUID.Value=Guid;
			 root.AddBoSGUID(GUID);
			 XmlElement myelement =  doc.GetDomDocument().DocumentElement;
			 myelement.Prefix="n3";
			
			 return myelement;
			
			
			
		}
		
		
		void GroupBox3Enter(object sender, EventArgs e)
		{
			
		}
		
		void AuthneticationBtnClick(object sender, EventArgs e)
		{  
			if( wseButton.Checked)
			{
			wse.CASEndpointBean myWseEndpoint = new wse.CASEndpointBean();
			
			wse.CitizenAccountRequestMessage  myRequest =  new wse.CitizenAccountRequestMessage();
			myRequest.CASRequestData = new wse.CitizenAccountRequestType();
			myRequest.CASRequestData.Header= new wse.CitizenAccountRequestHeaderType();
		
			myRequest.CASRequestData.Header.CorrelationID= Guid.NewGuid().ToString();
			myRequest.CASRequestData.Header.UserID="Stirling";
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID="30";
			myRequest.CASRequestData.Any= CASAuthentication(GUIDtxt.Text);
			wse.CitizenAccountResponseMessage MyResponse = new wse.CitizenAccountResponseMessage();
			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
			System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(MyResponse.GetType());
		  
			XmlDocument requestDoc = new XmlDocument();
			string requeststring = Dock.ToString();

		    MessageBox.Show("send  request");
		    myWseEndpoint.SetPolicy("Seemis");
		    MessageBox.Show(myRequest.CASRequestData.Any.OuterXml);
		    try{
		    	StringWriter writer5 = new StringWriter();
                    x.Serialize(writer5,myRequest);
                    string xmlstring5 = writer5.ToString();
                    RequestTxt.Text =xmlstring5;
                    RequestTxt.Update();
		    MyResponse =myWseEndpoint.sendCitizenAccountMessage(myRequest);
		    StringWriter writer6 = new StringWriter();
                    y.Serialize(writer6,MyResponse);
                    string xmlstring6 = writer6.ToString();
                   ResponseTxt.Text =xmlstring6;
                   ResponseTxt.Update();
		    MessageBox.Show(MyResponse.CASResponseData.Any.OuterXml);
		    }
		    catch ( Exception ex)
		    {
		    	DisplayException(ex);
		    }
				
			}
			if(OWSMButton.Checked)
			{
		    wse.CASEndpointBean myEndpoint = new wse.CASEndpointBean();
		   
		    wse.CitizenAccountRequestMessage  myRequest =  new wse.CitizenAccountRequestMessage();
			myRequest.CASRequestData = new wse.CitizenAccountRequestType();
			myRequest.CASRequestData.Header= new wse.CitizenAccountRequestHeaderType();
		
			myRequest.CASRequestData.Header.CorrelationID= Guid.NewGuid().ToString();
			myRequest.CASRequestData.Header.UserID="Dundee";
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID="09";
			myRequest.CASRequestData.Any= CASAuthentication(GUIDtxt.Text);
			wse.CitizenAccountResponseMessage MyResponse = new wse.CitizenAccountResponseMessage();
			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
			System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(MyResponse.GetType());
		  
			XmlDocument requestDoc = new XmlDocument();
			
			MessageBox.Show(myRequest.CASRequestData.Any.OuterXml);
		    MessageBox.Show("send  request");
		    try{
		    	StringWriter writer5 = new StringWriter();
                    x.Serialize(writer5,myRequest);
                    string xmlstring5 = writer5.ToString();
                      RequestTxt.Text =xmlstring5;
                    RequestTxt.Update();
                    RequestTxt.Show();
		    MyResponse = myEndpoint.sendCitizenAccountMessage(myRequest);
		    StringWriter writer6 = new StringWriter();
                    y.Serialize(writer6,MyResponse);
                    string xmlstring6 = writer6.ToString();
                   ResponseTxt.Text =xmlstring6;
                   ResponseTxt.Update();
		    MessageBox.Show(MyResponse.CASResponseData.Any.OuterXml);
		    }
		    catch ( Exception ex)
		    {
		    	DisplayException(ex);
		    }
		    
			}
			if(gatewayButton.Checked)
			{
				
			LocalCASRequestMessage requestMessage= new LocalCASRequestMessage();
			requestMessage.Header= new RequestHeaderType();
			//requestMessage.Header.CorrelationID= Guid.NewGuid().ToString();
			requestMessage.Header.UserID="Stirling";
			requestMessage.Header.Timestamp= DateTime.Now;
			requestMessage.Any=CASAuthentication(GUIDtxt.Text);
			LocalCASResponseMessage MyResponse = new LocalCASResponseMessage();
			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(requestMessage.GetType());
			System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(MyResponse.GetType());
		  
			try{
				StringWriter writer5 = new StringWriter();
                    x.Serialize(writer5,requestMessage);
                    string xmlstring5 = writer5.ToString();
                     RequestTxt.Text =xmlstring5;
                    RequestTxt.Update();
			MyResponse= myGateway.LocalCAS(requestMessage);
			StringWriter writer6 = new StringWriter();
                    y.Serialize(writer6,MyResponse);
                    string xmlstring6 = writer6.ToString();
                   ResponseTxt.Text =xmlstring6;
                   ResponseTxt.Update();
			}
			catch ( Exception ex)
		    {
		    	DisplayException(ex);
		    }
			
			}
		}
		
		void ForenametBox1TextChanged(object sender, EventArgs e)
		{
			
		}
//		private XmlElement PostcodeSearch(string postcode)
//		{
//			SeoPostcodeSearch_v0_1Doc doc = new SeoPostcodeSearch_v0_1Doc();
//			doc.SetSchemaLocation("SeoPostcodeSearch_v0_1.xsd"); 
//			PostcodeSearchRequestType root = new PostcodeSearchRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "PostcodeSearchRequest");
//			root.AddPostcode( CreatePostCode(postcode));
//			XmlElement myelement =doc.GetDomDocument().DocumentElement;
//			myelement.Prefix="n3";
//			
//			return myelement;                                                                 
//		
//			}
		private XmlElement ListKnownFact()
		{ ListSupportedKnownFacts_v0_1Doc doc = new ListSupportedKnownFacts_v0_1Doc();
 			doc.SetSchemaLocation("ListSupportedKnownFacts_v0_1.xsd");
			ListSupportedKnownFactsRequestType root = new ListSupportedKnownFactsRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "ListSupportedKnownFactsRequest");
			XmlElement myelement =doc.GetDomDocument().DocumentElement;
			myelement.Prefix="n3";
			
			return myelement;
		}
		private XmlElement QueryCiztizen( string Username)
		{   SeoQueryCitizenAccount_v0_1Doc doc = new SeoQueryCitizenAccount_v0_1Doc();
			doc.SetSchemaLocation("SeoQueryCitizenAccount_v0_1.xsd");
			QueryCitizensAccountRequestType root = new QueryCitizensAccountRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "QueryCitizensAccountRequest");

			//QueryCitizenHistoryRequestType root= new QueryCitizenHistoryRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "QueryCitizensAccountRequest");
			
			//LA_CAS_Messages.core3.UCRNType myUCRN = new LA_CAS_Messages.core3.UCRNType(UCRN);
			LA_CAS_Messages.core3.UserIDType myuserID = new LA_CAS_Messages.core3.UserIDType(Username);
			root.AddUserID(myuserID);
				//root.AddUCRN(myUCRN);
			return doc.GetDomDocument().DocumentElement;
		}
			private XmlElement QueryAccountHistory( string UCRN)
		{   SeoQueryCitizenAccount_v0_1Doc doc = new SeoQueryCitizenAccount_v0_1Doc();
			doc.SetSchemaLocation("SeoQueryCitizenAccount_v0_1.xsd");
			QueryCitizenHistoryRequestType root= new QueryCitizenHistoryRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "QueryCitizensAccountRequest");
			
			LA_CAS_Messages.core3.UCRNType myUCRN = new LA_CAS_Messages.core3.UCRNType(UCRN);
			
				root.AddUCRN(myUCRN);
			return doc.GetDomDocument().DocumentElement;
		}
		
		void IdProofBtnClick(object sender, EventArgs e)
		{   string	corrid = Guid.NewGuid().ToString();
			CitizenAccountRequestMessage myRequest =  new CitizenAccountRequestMessage();
			myRequest.CASRequestData = new CitizenAccountRequestType();
			myRequest.CASRequestData.Header= new CitizenAccountRequestHeaderType();
		
			myRequest.CASRequestData.Header.CorrelationID= Guid.NewGuid().ToString();
			myRequest.CASRequestData.Header.UserID="NorthLanarkshire";
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID="22";
			myWseEndpoint.SetPolicy("NorthLan");
			CitizenAccountResponseMessage MyResponse = new CitizenAccountResponseMessage();
			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
			System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(MyResponse.GetType());
			
				myRequest.CASRequestData.Any=ListKnownFact();
				StringWriter writer5 = new StringWriter();
                    x.Serialize(writer5,myRequest);
                    string xmlstring5 = writer5.ToString();
                    ListIdentityBox.Text=xmlstring5;
                    ListIdentityBox.Update();
                    try{
				MyResponse = myWseEndpoint.sendCitizenAccountMessage(myRequest);
                    }
                    catch (Exception ex)
                    {
                    	MessageBox.Show(ex.Message);
                    	DisplayException(ex);
                    }
			
		}
		
		void QueryHistoryBtnClick(object sender, EventArgs e)
		{
			wse.CASEndpointBean myWseEndpoint = new wse.CASEndpointBean();
			
			wse.CitizenAccountRequestMessage  myRequest =  new wse.CitizenAccountRequestMessage();
			myRequest.CASRequestData = new wse.CitizenAccountRequestType();
			myRequest.CASRequestData.Header= new wse.CitizenAccountRequestHeaderType();
		
			myRequest.CASRequestData.Header.CorrelationID= Guid.NewGuid().ToString();
			myRequest.CASRequestData.Header.UserID="NorthLanarkshire";
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID="22";
			myRequest.CASRequestData.Any= QueryAccountHistory(UCRNBox.Text);
			//myRequest.CASRequestData.Any= QueryCiztizen(UCRNBox.Text);
			wse.CitizenAccountResponseMessage MyResponse = new wse.CitizenAccountResponseMessage();
			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
			System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(MyResponse.GetType());
		  
			XmlDocument requestDoc = new XmlDocument();
			string requeststring = Dock.ToString();

		    //MessageBox.Show("send  request");
		    myWseEndpoint.SetPolicy("NorthLan");
		    //MessageBox.Show(myRequest.CASRequestData.Any.OuterXml);
		    try{
		    	StringWriter writer5 = new StringWriter();
                    x.Serialize(writer5,myRequest);
                    string xmlstring5 = writer5.ToString();
                    AccountHistoryRequest.Text =xmlstring5;
                    AccountHistoryRequest.Update();
		    MyResponse =myWseEndpoint.sendCitizenAccountMessage(myRequest);
		    StringWriter writer6 = new StringWriter();
                    y.Serialize(writer6,MyResponse);
                    string xmlstring6 = writer6.ToString();
                    AccountHistoryResponse.Text =xmlstring6;
                  AccountHistoryResponse.Update();
                  
                   XmlDocument myXML = new XmlDocument();
                   	myXML.LoadXml(MyResponse.CASResponseData.Any.OuterXml);
                   	QueryCitizensAccountResponseType    myAcountHistoryResponse = new QueryCitizensAccountResponseType(myXML);
                   	if (myAcountHistoryResponse.UserIDDetailsCount >0)
                   	{
               HistoryUserIDTxt.Text=    	myAcountHistoryResponse.UserIDDetails.UserID.Value;
                   HistoryUserIDTxt.Refresh();
                   	}
               string name = string.Empty;
               if ( myAcountHistoryResponse.CitizenDetails.CitizenName.PersonNameTitleCount >0)
               {
               	name =myAcountHistoryResponse.CitizenDetails.CitizenName.PersonNameSuffix.Value;
               }
               if (myAcountHistoryResponse.CitizenDetails.CitizenName.PersonGivenNameCount >0)
               {
	                if( name != string.Empty)
	               	{
	               		name = name +" " +myAcountHistoryResponse.CitizenDetails.CitizenName.PersonGivenName.Value;
	               	}
	               	else
	               	{
	               		name =myAcountHistoryResponse.CitizenDetails.CitizenName.PersonGivenName.Value;
	               	}
               }
               
               if (myAcountHistoryResponse.CitizenDetails.CitizenName.PersonFamilyNameCount >0)
               {
              
               	name = name +" " +myAcountHistoryResponse.CitizenDetails.CitizenName.PersonFamilyName.Value;
               }
               if(myAcountHistoryResponse.CitizenDetails.CitizenName.PersonNameSuffixCount >0)
               {
             
               	name = name +" " +myAcountHistoryResponse.CitizenDetails.CitizenName.PersonNameSuffix.Value;
               }
                HistoryNameTxt.Text= name;
               HistoryNameTxt.Refresh();
               if(myAcountHistoryResponse.CitizenDetails.CitizenName.PersonRequestedNameCount >0)
               {	
               	HistoryPreferedNameTxt.Text= myAcountHistoryResponse.CitizenDetails.CitizenName.PersonRequestedName.Value;
             
               }
               else
               {
               
               	HistoryPreferedNameTxt.Text= " No Prefered Name Set";
               }
               HistoryPreferedNameTxt.Refresh();
               if (myAcountHistoryResponse.AccountStatusCount >0)
               {
               	HistoryAccountStatus.Text= myAcountHistoryResponse.AccountStatus.Value;
               }
               if(myAcountHistoryResponse.CitizenDetails.UCRNCount >0)
               {
               	HistoryUCRNTxt.Text=myAcountHistoryResponse.CitizenDetails.UCRN.Value;
               }
               if (myAcountHistoryResponse.CitizenDetails.GenderCount >0)
               {
               	switch(myAcountHistoryResponse.CitizenDetails.Gender.Value)
               { case 1:
                  		
                    HistoryGenderTxt.Text="Male";
                  		break;
                  		case 2:
                  		HistoryGenderTxt.Text="Female";
                  		break;
                  	default:
                  		break;
                  	
                  }
               	
               }
               if(myAcountHistoryResponse.AuthenticationLevelCount >0)
               {
               	HistoryAuthenticationLevelTxt.Text= myAcountHistoryResponse.AuthenticationLevel.Value;
               }
               if (myAcountHistoryResponse.CitizenDetails.DateOfBirthCount >0)
               {
               	HistoryDateofBirthTxt.Text=myAcountHistoryResponse.CitizenDetails.DateOfBirth.PersonBirthDate.Value.ToLongDateString();
               }
               
               if (myAcountHistoryResponse.NationalLevelConsentFlagCount >0)
               {
               	HistoryConsentLevelFlagTxt.Text= myAcountHistoryResponse.NationalLevelConsentFlag.Value;
               }
               if(myAcountHistoryResponse.Level2EnrolmentProofsCount >0)
               {
               		for(int id=0 ; id< myAcountHistoryResponse.Level2EnrolmentProofsCount ;id++)
               		{ 
               			for(int instance=0; instance < myAcountHistoryResponse.GetLevel2EnrolmentProofsAt(id).IdentityDocumentationCount;instance++)
               			{
               				if (HistoryIDProofTxt.Text == string.Empty)
	               			{
	               				HistoryIDProofTxt.Text = myAcountHistoryResponse.GetLevel2EnrolmentProofsAt(id).GetIdentityDocumentationAt(instance).Value;
	               			}
	               			else
	               			{
	               				   	HistoryIDProofTxt.Text =  	HistoryIDProofTxt.Text + ", " +myAcountHistoryResponse.GetLevel2EnrolmentProofsAt(id).GetIdentityDocumentationAt(instance).Value;
	               			}
               			}
               			for(int instance=0; instance < myAcountHistoryResponse.GetLevel2EnrolmentProofsAt(id).ResidenceDocumentationCount;instance++)
               			{
               				if (HistoryResProofTxt.Text == string.Empty)
	               			{
	               				HistoryResProofTxt.Text = myAcountHistoryResponse.GetLevel2EnrolmentProofsAt(id).GetResidenceDocumentationAt(instance).Value;
	               			}
	               			else
	               			{
	               				   	HistoryResProofTxt.Text =  	HistoryResProofTxt.Text + ", " +myAcountHistoryResponse.GetLevel2EnrolmentProofsAt(id).GetResidenceDocumentationAt(instance).Value;
	               			}
               			}
               		}
               }
               
 #region Address Processing 
 
// checked ToolBar see if there is AnyReturnReader address present by seeing if Authentication current property count is greater than  zero
HistoryAddressTxt.Text= string.Empty;
               if (myAcountHistoryResponse.CurrentPropertyCount >0)
               {
               	
/// Loop through the current properties               	
               	for(int prop=0;prop<myAcountHistoryResponse.CurrentPropertyCount;prop++)
               	{
               	// check to see if property has  a postal address
               		if (myAcountHistoryResponse.GetCurrentPropertyAt(prop).UKPostalAddressCount >0)
               		{
               		//loop through postal addresses
               		for(int ukadd=0 ; ukadd< myAcountHistoryResponse.GetCurrentPropertyAt(prop).UKPostalAddressCount ;ukadd++)
               		    {
               			// check to see if  the postal address has any address lines
               			if(myAcountHistoryResponse.GetCurrentPropertyAt(prop).GetUKPostalAddressAt(ukadd).LineCount >0)
		               		{
		               			
               				//loop through address lines
               				for(int i=0;i<myAcountHistoryResponse.GetCurrentPropertyAt(prop).GetUKPostalAddressAt(ukadd).LineCount;i++)
		               			{
               					HistoryAddressTxt.AppendText(myAcountHistoryResponse.GetCurrentPropertyAt(prop).GetUKPostalAddressAt(ukadd).GetLineAt(i).Value +"\r\n");
               				
		               			}
		               			
		               		}
		               	// Check to see if Postal Address has Post code
		               		if (myAcountHistoryResponse.GetCurrentPropertyAt(prop).GetUKPostalAddressAt(ukadd).PostCodeCount >0)
		               		{
		               			HistoryAddressTxt.AppendText(myAcountHistoryResponse.GetCurrentPropertyAt(prop).GetUKPostalAddressAt(ukadd).PostCode + "\r\n");
		               		}
               		    }
               		}
               
               	if(myAcountHistoryResponse.GetCurrentPropertyAt(prop).UPRNCount >0)
               		{
               		HistoryAddressTxt.Text =HistoryAddressTxt.Text + "UPRN:" +myAcountHistoryResponse.GetCurrentPropertyAt(prop).UPRN.Value + "\r\n";
               		}
               	if(myAcountHistoryResponse.GetCurrentPropertyAt(prop).PropertyTypeCount >0)
               	{
               		HistoryAddressTxt.Text =HistoryAddressTxt.Text +"Property Type: "+ myAcountHistoryResponse.GetCurrentPropertyAt(prop).PropertyType.Value +"\r\n";
               		
               	}
               	if (myAcountHistoryResponse.GetCurrentPropertyAt(prop).LACodeCount >0)
               	{
               		HistoryAddressTxt.Text =HistoryAddressTxt.Text +"Local Authority Code: "+ myAcountHistoryResponse.GetCurrentPropertyAt(prop).LACode.Value +"\r\n";
               	}
               	HistoryAddressTxt.AppendText("\r\n");
               	}
               }
 #endregion              
               MessageBox.Show(MyResponse.CASResponseData.Any.OuterXml);
		    }
		    catch ( Exception ex)
		    {
		    	DisplayException(ex);
		    }
		}
		
		void PostCodeSearchBtnClick(object sender, System.EventArgs e)
		{
			wse.CASEndpointBean myWseEndpoint = new wse.CASEndpointBean();
			
			wse.CitizenAccountRequestMessage  myRequest =  new wse.CitizenAccountRequestMessage();
			myRequest.CASRequestData = new wse.CitizenAccountRequestType();
			myRequest.CASRequestData.Header= new wse.CitizenAccountRequestHeaderType();
		
			myRequest.CASRequestData.Header.CorrelationID= Guid.NewGuid().ToString();
			myRequest.CASRequestData.Header.UserID="Stirling";
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID="30";
			//myRequest.CASRequestData.Any= PostcodeSearch(PostCodeBox.Text);
			wse.CitizenAccountResponseMessage MyResponse = new wse.CitizenAccountResponseMessage();
			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
			System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(MyResponse.GetType());
		  
			XmlDocument requestDoc = new XmlDocument();
			string requeststring = Dock.ToString();

		    //MessageBox.Show("send  request");
		    myWseEndpoint.SetPolicy("Seemis");
		    //MessageBox.Show(myRequest.CASRequestData.Any.OuterXml);
		    try{
		    	StringWriter writer5 = new StringWriter();
                    x.Serialize(writer5,myRequest);
                    string xmlstring5 = writer5.ToString();
                  PostCodeRequest.Text =xmlstring5;
                PostCodeRequest.Update();
		    MyResponse =myWseEndpoint.sendCitizenAccountMessage(myRequest);
		    StringWriter writer6 = new StringWriter();
                    y.Serialize(writer6,MyResponse);
                    string xmlstring6 = writer6.ToString();
                 PostCodeResponse.Text =xmlstring6;
                 PostCodeResponse.Update();
		    }
		    catch(Exception ex)
		    {
		    	DisplayException(ex);
		    }
			
		}
		
		void QueryUCRNtabClick(object sender, EventArgs e)
		{
			
		}
		
		void Label26Click(object sender, EventArgs e)
		{
			
		}
		
		void Label19Click(object sender, EventArgs e)
		{
			
		}
		
		void CitizenRegistrationver2Click(object sender, EventArgs e)
		{
			    string forename =ForenametBox1.Text ;
				string surname = SurnameBox1.Text;
				string dateofbirth = DateOfBirthBox1.Text;
				string orginisation = OrginisationCombo.Text; 
				string gender = Gendercombo.Text;
			    string partnerID = string.Empty;
			    string idProof1 = identityBox1.Text;
			    string idProof2= identityBox2.Text;
			    string resProof1 = residencyBox1.Text;
			    string resProof2=residencyBox2.Text;
			    string uprn= UPRNBox1.Text ;
			    string addressline1 = Addressline1.Text;
			    string addressline2= Addressline2.Text;
			    string town = TownText.Text;
			    string postcode = PostCodeTxt.Text;
			    
			    try{
			    if (orginisation== string.Empty) throw new System.ArgumentException("Orginisation cannot  be null please select an oginisation from the Combo Box" );
				if (dateofbirth ==string.Empty)throw new System.ArgumentException("date of Birth not filled in");
				if (forename== string.Empty)throw new System.ArgumentException("Forename  not filled in");
				if (surname==string.Empty) throw new System.ArgumentException("Surname not filled in");
				if (gender== string.Empty)throw new System.ArgumentException("Gender not selected from Combo box");
				//if (idProof1== string.Empty)throw new System.ArgumentException("1st Proof of Identity not selected from Combo box");
				//if (idProof2== string.Empty)throw new System.ArgumentException("2nd Proof of Identity not selected from Combo box");
				//if (resProof1== string.Empty)throw new System.ArgumentException("1st Proof of Residency not selected from Combo box");
				//if (resProof2== string.Empty)throw new System.ArgumentException("2nd Proof of Residency not selected from Combo box");
				//if (idProof1== idProof2)throw new System.ArgumentException("Need to select  two different Proofs of Identity");
				//if (resProof1== resProof2)throw new System.ArgumentException("Need to select  two different Proofs of Residency");
				//!if (uprn==string.Empty) throw new System.ArgumentException("UPRN not filled in");
			    int genderBit=GenderBit(gender);
				partnerID =PartnerID(orginisation);
				
				string	corrid = Guid.NewGuid().ToString();
			CitizenAccountRequestMessage myRequest =  new CitizenAccountRequestMessage();
			myRequest.CASRequestData = new CitizenAccountRequestType();
			myRequest.CASRequestData.Header= new CitizenAccountRequestHeaderType();
		
			myRequest.CASRequestData.Header.CorrelationID= corrid;
			myRequest.CASRequestData.Header.UserID=orginisation;
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID=partnerID;
			
			string consent = string.Empty;
			if(consentBox1.Checked)
			{ consent="yes";
			}
			else
			{
				consent="no";
			}
//			
			idProof2 = IdentityProof(idProof2);
			idProof1= IdentityProof(idProof1);
			resProof2=ResidencyProof(resProof2);
			resProof1=ResidencyProof(resProof1);
			
			if (uprn!= string.Empty)
	        
			{myRequest.CASRequestData.Any= CitizenRegistration2(dateofbirth,forename,surname,genderBit,uprn, idProof1, idProof2, resProof1,  resProof2,  consent);
			}
			else 
			{
				myRequest.CASRequestData.Any= CitizenRegistration2(dateofbirth,forename,surname,genderBit,addressline1,addressline2,town,postcode, idProof1, idProof2, resProof1,  resProof2,  consent);
				
			}
				CitizenAccountResponseMessage MyResponse = new CitizenAccountResponseMessage();
			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
			System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(MyResponse.GetType());
			
		    Trace.WriteLine("--------------------------------------------------------------------------------");
		    Trace.WriteLine("                      UCRN Query   Request Message                    ");
		      Trace.WriteLine("--------------------------------------------------------------------------------");
			
			StringWriter writer5 = new StringWriter();
                    x.Serialize(writer5,myRequest);
                    string xmlstring5 = writer5.ToString();
	        Trace.WriteLine(xmlstring5);
	       RequestTextBox1.Text= xmlstring5;
	        RequestTextBox1.Update();
	        MessageBox.Show( xmlstring5);
	        
			//myWseEndpoint.SetPolicy("NorthLan");
			
		    myWseEndpoint.SetPolicy("NorthLan");
		
			
			MyResponse=myWseEndpoint.sendCitizenAccountMessage(myRequest);
			XmlDocument responseXML = new XmlDocument();
			StringWriter writer6= new StringWriter();
                    y.Serialize(writer6,MyResponse);
                    string xmlstring6 = writer6.ToString();
                    CitizenRegResults.Text=xmlstring6;
                    CitizenRegResults.Update();
                    
                    MessageBox.Show(xmlstring6,"Results of Query:" );
			    }
			    catch(SoapException se)
			    {MessageBox.Show( "An exception has occurred: " + se.Message );
			    	DisplayException(se);
			    }
			    catch(WebException we)
			    {
			    	MessageBox.Show(we.Message);
			    }
			    catch(Exception ex)
			    {

                               
			    	MessageBox.Show(ex.Message +ex.Source+ ex.InnerException.Message );
					DisplayException(ex);
			    }
		}
		
		void Label40Click(object sender, EventArgs e)
		{
			
		}
		
		void LiveQueryBtnClick(object sender, EventArgs e)
		{    wse.CASEndpointBean liveWseEndpoint = new CASEndpointBean();
			//liveWseEndpoint.Url="http://calamid2.scottishcitizen.live/CASWebService/CASEndpointBean";
			liveWseEndpoint.Url="http://la1.scottishcitizen.gov.uk/CASWebService/CASEndpointBean";
			
			string forename ="David" ;
				string surname = "Ball";
				string dateofbirth = "1971-04-26";
				 
				
			try{
				
			string gender = "Male";
				MessageBox.Show(gender );
				
					//if (orginisation== string.Empty) throw new System.ArgumentException("Orginisation cannot  be null please select an oginisation from the Combo Box" );
				if (dateofbirth ==string.Empty)throw new System.ArgumentException("date of Birth not filled in");
				if (forename== string.Empty)throw new System.ArgumentException("Forename  not filled in");
				if (surname==string.Empty) throw new System.ArgumentException("Surname not filled in");
				if (gender== string.Empty)throw new System.ArgumentException("Gender not selected from Combo box");
				int genderBit = GenderBit(gender);
				MessageBox.Show("Gender ="+genderBit);
				// need to change after new release?
				string partnerID = "09";
			
				liveWseEndpoint.SetPolicy("NHS");

			string	corrid = Guid.NewGuid().ToString();
			CitizenAccountRequestMessage myRequest =  new CitizenAccountRequestMessage();
			myRequest.CASRequestData = new CitizenAccountRequestType();
			myRequest.CASRequestData.Header= new CitizenAccountRequestHeaderType();
		
			myRequest.CASRequestData.Header.CorrelationID= corrid;
			myRequest.CASRequestData.Header.UserID="test";
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID=partnerID;
			
	        myRequest.CASRequestData.Any= UCRNQuery(dateofbirth,forename,surname,genderBit);
	     
			CitizenAccountResponseMessage MyResponse = new CitizenAccountResponseMessage();
			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
			System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(MyResponse.GetType());
			
		    Trace.WriteLine("--------------------------------------------------------------------------------");
		    Trace.WriteLine("                      UCRN Query   Request Message                    ");
		      Trace.WriteLine("--------------------------------------------------------------------------------");
			
			StringWriter writer5 = new StringWriter();
                    x.Serialize(writer5,myRequest);
                    string xmlstring5 = writer5.ToString();
	        Trace.WriteLine(xmlstring5);
	        MessageBox.Show( xmlstring5);
	   
			
		     
		
			
			MyResponse=liveWseEndpoint.sendCitizenAccountMessage(myRequest);
			XmlDocument responseXML = new XmlDocument();
			StringWriter writer6= new StringWriter();
                    y.Serialize(writer6,MyResponse);
                    string xmlstring6 = writer6.ToString();
                   QueryUCRNResults.Text=xmlstring6;
                   SeoQueryUCRN_v0_1Doc doc = new SeoQueryUCRN_v0_1Doc();
                   
                
                     XmlDocument myXML = new XmlDocument();
                   	myXML.LoadXml(MyResponse.CASResponseData.Any.OuterXml);
                   QueryUCRNResponseType myQueryResponse = new QueryUCRNResponseType(myXML);
                   
                   
                   
                   UCRNBox.Text=myQueryResponse.GetUCRN().Value;
                 
                  ucrnTxt.Text =myQueryResponse.GetUCRN().Value;
                  FornameText.Text=myQueryResponse.GetCitizenDetails().GetForename().Value;
                  FornameText.Update();
                  SurnameText.Text=myQueryResponse.GetCitizenDetails().GetSurname().Value;
                  DOBTEXT.Text=myQueryResponse.GetCitizenDetails().GetDateOfBirth().Value.ToLongDateString();
                  switch(myQueryResponse.GetCitizenDetails().GetGender().Value)
                  { case 1:
                  		
                    GenderText.Text="Male";
                  		break;
                  		case 2:
                  		GenderText.Text="Female";
                  		break;
                  	default:
                  		break;
                  	
                  }
                      QueryUCRNResults.Update();
                    
                    
                    MessageBox.Show(xmlstring6,"Results of Query:" );
//	        Trace.WriteLine(xmlstring6);
//                responseXML.Load(xmlstring6);
//				treeViewQuery.Nodes.Clear();
//				treeViewQuery.Nodes.Add(new TreeNode(responseXML.DocumentElement.Name));
//				TreeNode tNode = new TreeNode();
//				tNode = treeView1.Nodes[0];
//				
//				// SECTION 3. Populate the TreeView with the DOM nodes.
//				AddNode(responseXML.DocumentElement, tNode);
//				treeView1.ExpandAll();
			
			Trace.WriteLine("--------------------------------------------------------------------------------");
		    Trace.WriteLine("                        Response  message from UCRN Query                       ");
		     Trace.WriteLine("--------------------------------------------------------------------------------");
			Trace.WriteLine(xmlstring6);
				}
				catch(SoapException soapEx)
			{ 
	MessageBox.Show(soapEx.Code.ToString());
    //Load the Detail element of the SoaopException object
   Trace.WriteLine("**********************************************");
    Trace.WriteLine("---------------- SOAP Exception --------------");
    Trace.WriteLine("SOAP Exception Code :" + soapEx.Code.Name.ToString()+", "+soapEx.Code.ToString()+", ");
    Trace.WriteLine(soapEx.Detail.OuterXml);
    Trace.WriteLine(soapEx.Message);

    Trace.WriteLine("---------------- Enf of Exception --------------");
    Trace.WriteLine("************************************************");

			}
				catch (Exception ex)
				{MessageBox.Show(ex.Message);
					DisplayException(ex);
				 }
				
		}
		
		void Label42Click(object sender, EventArgs e)
		{
			
		}
		XmlElement SubscribetoService(string UCRN, string ServiceID)
		{
			CitizenServiceSubscribeRequest_v0_1.CitizenServiceSubscribeRequest_v0_1Doc doc = new CitizenServiceSubscribeRequest_v0_1.CitizenServiceSubscribeRequest_v0_1Doc();
			
			doc.SetSchemaLocation("CitizenServiceSubscribeRequest_v0_1.xsd");
			CitizenServiceSubscribeRequest_v0_1.CitizenServiceSubscribeRequestType root = new CitizenServiceSubscribeRequest_v0_1.CitizenServiceSubscribeRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "CitizenServiceSubscribeRequest");
			CitizenServiceSubscribeRequest_v0_1.core3.UCRNType myUCRN = new CitizenServiceSubscribeRequest_v0_1.core3.UCRNType(UCRN);
			
			

			Altova.Types.SchemaLong  myserviceID = new Altova.Types.SchemaLong(ServiceID);
			//myserviceID.Value= 		(Convert.ToInt32(ServiceID));
			root.AddServiceId(myserviceID);
			root.AddUCRN(myUCRN)		;
			XmlElement element =doc.GetDomDocument().DocumentElement;
			   element.Prefix="n2";
			  return element;
		}
		void Button2Click(object sender, EventArgs e)
		{
			
			wse.CASEndpointBean myWseEndpoint = new wse.CASEndpointBean();
			
			wse.CitizenAccountRequestMessage  myRequest =  new wse.CitizenAccountRequestMessage();
			myRequest.CASRequestData = new wse.CitizenAccountRequestType();
			myRequest.CASRequestData.Header= new wse.CitizenAccountRequestHeaderType();
		
			myRequest.CASRequestData.Header.CorrelationID= Guid.NewGuid().ToString();
			myRequest.CASRequestData.Header.UserID="NorthLanarkshire";
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID="22";
			myRequest.CASRequestData.Any= SubscribetoService(SubcribeUCRN.Text,ServiceID.Text);
			//myRequest.CASRequestData.Any= QueryCiztizen(UCRNBox.Text);
			wse.CitizenAccountResponseMessage MyResponse = new wse.CitizenAccountResponseMessage();
			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
			System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(MyResponse.GetType());
		  
			XmlDocument requestDoc = new XmlDocument();
			string requeststring = Dock.ToString();

		    //MessageBox.Show("send  request");
		    myWseEndpoint.SetPolicy("NorthLan");
		    //MessageBox.Show(myRequest.CASRequestData.Any.OuterXml);
		    try{
		    	StringWriter writer5 = new StringWriter();
                    x.Serialize(writer5,myRequest);
                    string xmlstring5 = writer5.ToString();
                  SubscribeRequest.Text =xmlstring5;
                    SubscribeRequest.Update();
		    MyResponse =myWseEndpoint.sendCitizenAccountMessage(myRequest);
		    StringWriter writer6 = new StringWriter();
                    y.Serialize(writer6,MyResponse);
                    string xmlstring6 = writer6.ToString();
                 SubScribeResponse.Text =xmlstring6;
                  SubScribeResponse.Update();
		    }
		    catch(SoapException soapEx)
			{ 
	MessageBox.Show(soapEx.Code.ToString());
    //Load the Detail element of the SoaopException object
   Trace.WriteLine("**********************************************");
    Trace.WriteLine("---------------- SOAP Exception --------------");
    Trace.WriteLine("SOAP Exception Code :" + soapEx.Code.Name.ToString()+", "+soapEx.Code.ToString()+", ");
    Trace.WriteLine(soapEx.Detail.OuterXml);
    Trace.WriteLine(soapEx.Message);

    Trace.WriteLine("---------------- Enf of Exception --------------");
    Trace.WriteLine("************************************************");

			}
				catch (Exception ex)
				{MessageBox.Show(ex.Message);
					DisplayException(ex);
				 }
		}
//			 wse.CASEndpointBean liveWseEndpoint = new CASEndpointBean();
//			//liveWseEndpoint.Url="http://calamid2.scottishcitizen.live/CASWebService/CASEndpointBean";
//			liveWseEndpoint.Url="http://la1.scottishcitizen.gov.uk/CASWebService/CASEndpointBean";
//			
//			
//				
//			try{
//				
//			
//				string partnerID = "09";
//			
//				liveWseEndpoint.SetPolicy("NHS");
//
//			string	corrid = Guid.NewGuid().ToString();
//			CitizenAccountRequestMessage myRequest =  new CitizenAccountRequestMessage();
//			myRequest.CASRequestData = new CitizenAccountRequestType();
//			myRequest.CASRequestData.Header= new CitizenAccountRequestHeaderType();
//		
//			myRequest.CASRequestData.Header.CorrelationID= corrid;
//			myRequest.CASRequestData.Header.UserID="test";
//			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
//			myRequest.CASRequestData.Header.PartnerID=partnerID;
//			
//	        myRequest.CASRequestData.Any= SubscribetoService(SubcribeUCRN.Text,ServiceID.Text);
//	     
//			CitizenAccountResponseMessage MyResponse = new CitizenAccountResponseMessage();
//			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
//			System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(MyResponse.GetType());
//			
//		    Trace.WriteLine("--------------------------------------------------------------------------------");
//		    Trace.WriteLine("                      UCRN Query   Request Message                    ");
//		    Trace.WriteLine("--------------------------------------------------------------------------------");
//			
//			StringWriter writer5 = new StringWriter();
//                    x.Serialize(writer5,myRequest);
//                    string xmlstring5 = writer5.ToString();
//	        Trace.WriteLine(xmlstring5);
//	      SubscribeRequest.Text= xmlstring5;
//	   
//			
//		     
//		
//			
//			MyResponse=liveWseEndpoint.sendCitizenAccountMessage(myRequest);
//			XmlDocument responseXML = new XmlDocument();
//			StringWriter writer6= new StringWriter();
//                    y.Serialize(writer6,MyResponse);
//                    string xmlstring6 = writer6.ToString();
//                  SubScribeResponse.Text=xmlstring6;
//                   
////	        Trace.WriteLine(xmlstring6);
////                responseXML.Load(xmlstring6);
////				treeViewQuery.Nodes.Clear();
////				treeViewQuery.Nodes.Add(new TreeNode(responseXML.DocumentElement.Name));
////				TreeNode tNode = new TreeNode();
////				tNode = treeView1.Nodes[0];
////				
////				// SECTION 3. Populate the TreeView with the DOM nodes.
////				AddNode(responseXML.DocumentElement, tNode);
////				treeView1.ExpandAll();
//			
//			Trace.WriteLine("--------------------------------------------------------------------------------");
//		    Trace.WriteLine("                        Response  message from UCRN Query                       ");
//		     Trace.WriteLine("--------------------------------------------------------------------------------");
//			Trace.WriteLine(xmlstring6);
//				}
//				catch(SoapException soapEx)
//			{ 
//	MessageBox.Show(soapEx.Code.ToString());
//    //Load the Detail element of the SoaopException object
//   Trace.WriteLine("**********************************************");
//    Trace.WriteLine("---------------- SOAP Exception --------------");
//    Trace.WriteLine("SOAP Exception Code :" + soapEx.Code.Name.ToString()+", "+soapEx.Code.ToString()+", ");
//    Trace.WriteLine(soapEx.Detail.OuterXml);
//    Trace.WriteLine(soapEx.Message);
//
//    Trace.WriteLine("---------------- Enf of Exception --------------");
//    Trace.WriteLine("************************************************");
//
//			}
//				catch (Exception ex)
//				{MessageBox.Show(ex.Message);
//					DisplayException(ex);
//				 }
		
	}
}
