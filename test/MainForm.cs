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
using System.Diagnostics;
using System.Collections;
using System.Data;
using System.Web.Services;
using  System.Web.Services.Protocols;
using System.Net;
//using SeoQueryUCRN_v0_1;
//using SeoQueryUCRN_v0_1.core3;
//using SeoQueryUCRN_v0_1.PersonDescriptives2;
//using SeoQueryUCRN_v0_1.core2;

using SeoAcknowledgeNotificationReceipt_v0_1;
using SeoAcknowledgeNotificationReceipt_v0_1.core2;
using SeoAcknowledgeNotificationReceipt_v0_1.core3;

namespace NotificationRetevalDemo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		private CasGatewayService myGateway;
		private wse.CASEndpointBean myWseEndpoint;
		public MainForm()
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
		private XmlElement acknowledgeNoticiation(string notificationID)
		{   SeoAcknowledgeNotificationReceipt_v0_1Doc doc = new SeoAcknowledgeNotificationReceipt_v0_1.SeoAcknowledgeNotificationReceipt_v0_1Doc();
			doc.SetSchemaLocation("SeoAcknowledgeNotificationReceipt_v0_1.xsd"); // optional
			   AcknowledgeNotificationReceiptType root = new AcknowledgeNotificationReceiptType(doc, "http://www.scottishcitizen.gov.uk/control/v0-1", "", "AcknowledgeNotificationReceipt");
			   root.AddNotificationID(AckNotification(notificationID));
			return doc.GetDomDocument().DocumentElement;
		}
		private SeoReceiveNotification_v0_1.core3.NotificationIDType  Notification(string notificationID)
		{
			 SeoReceiveNotification_v0_1.core3.NotificationIDType id = new  SeoReceiveNotification_v0_1.core3.NotificationIDType(notificationID);
			return id;
		}
		private SeoAcknowledgeNotificationReceipt_v0_1.core3.NotificationIDType  AckNotification(string notificationID)
		{
			 SeoAcknowledgeNotificationReceipt_v0_1.core3.NotificationIDType id = new  SeoAcknowledgeNotificationReceipt_v0_1.core3.NotificationIDType(notificationID);
			return id;
		}
		
		
//		private XmlElement UCRNQuery()  
//		{
//			SeoQueryUCRN_v0_1Doc doc = new SeoQueryUCRN_v0_1Doc();
//			   doc.SetSchemaLocation("SeoQueryUCRN_v0_1.xsd"); // optional
//			   QueryUCRNRequestType root = new QueryUCRNRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "QueryUCRNResponse");
//			   SeoQueryUCRN_v0_1.core2.DateType DOB =  new SeoQueryUCRN_v0_1.core2.DateType("1971-04-26");
//			   SeoQueryUCRN_v0_1.PersonDescriptives2.PersonGivenNameType Forename = new    SeoQueryUCRN_v0_1.PersonDescriptives2.PersonGivenNameType("David");
//			   SeoQueryUCRN_v0_1.PersonDescriptives2.PersonFamilyNameType Surname = new SeoQueryUCRN_v0_1.PersonDescriptives2.PersonFamilyNameType("Ball");
//			   SeoQueryUCRN_v0_1.PersonDescriptives2.GenderAtRegistrationType Gender = new  SeoQueryUCRN_v0_1.PersonDescriptives2.GenderAtRegistrationType("1");
//			   root.AddCitizenDetails(Citizen());
//			  			return doc.GetDomDocument().DocumentElement;
//		}
//		private SeoQueryUCRN_v0_1.core3.CitizenSearchDetailsType Citizen()
//		{
//			SeoQueryUCRN_v0_1.core3.CitizenSearchDetailsType citizen = new  SeoQueryUCRN_v0_1.core3.CitizenSearchDetailsType();
//			citizen.AddForename(Forename("David"));
//			citizen.AddSurname(Surname("Ball"));
//			citizen.AddGender(Gender("1"));
//			citizen.AddDateOfBirth(DateOfBirth("1971-04-26"));
//			                       
//		   return citizen;
//		}
//		private PersonGivenNameType Forename(string forename)
//		{
//			PersonGivenNameType Forename =  new PersonGivenNameType(forename);
//			return Forename;
//		}
//		private PersonFamilyNameType Surname(string surname)
//		{PersonFamilyNameType Surname =  new PersonFamilyNameType(surname);
//			return Surname;
//			
//			
//		}
//		private GenderAtRegistrationType Gender(string gender)
//		{
//			GenderAtRegistrationType Gender =  new GenderAtRegistrationType(gender);
//			return Gender;
//			
//		}
//		private DateType DateOfBirth(string dob)
//		{DateType  DOB = new DateType(dob);
//			return DOB;
//		}
		void Button1Click(object sender, EventArgs e)
		{   
			//Create output  file
			string filename = string.Empty;
			string partnerID= System.Configuration.ConfigurationManager.AppSettings["PartnerID"];
			string council =System.Configuration.ConfigurationManager.AppSettings["Council"];
			filename = "UAT_Testing_"+council+"_"+DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")+".txt";
			Trace.WriteLine(filename);
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
			//MessageBox.Show(myRequest.CASRequestData.Any.OuterXml);
			Trace.WriteLine(myRequest.CASRequestData.Any.OuterXml);
			
			treeView1.Nodes.Clear();
			treeView1.Nodes.Add(new TreeNode(requestDoc.DocumentElement.Name));
			TreeNode tNode = new TreeNode();
			tNode = treeView1.Nodes[0];
			AddNode(requestDoc.DocumentElement, tNode);
			treeView1.ExpandAll();
			//MessageBox.Show("send  request");
			System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(myRequest.GetType());
			System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(MyResponse.GetType());
		    try{ 
				      
				      StringWriter writer = new StringWriter();
                      x.Serialize(writer,myRequest);
		    	      string xmlstring = writer.ToString();
		    	      DateTime date = DateTime.Now;
		    	      file.WriteLine("Test of Notifications from CAS on " + date +" For Partner ID:"+partnerID +"  " +council+" Council");
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
					    	      
		    	      
		    	      myWseEndpoint.SetPolicy("test");
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
		    	      	file.WriteLine(notificationType + " Message Detials:");
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
				{Trace.WriteLine("Deleting message from Queue");
					
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
                    y.Serialize(writer5,MyResponse);
		    	     string xmlstring5 = writer5.ToString();
//		    	      
		    	    file.WriteLine();
		    	      	file.WriteLine("Message Detials:");
		    	      	file.WriteLine();
		    	    file.WriteLine(xmlstring5);
				}
				else
				{Trace.WriteLine("Message left on  Queue");
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
	}
}
