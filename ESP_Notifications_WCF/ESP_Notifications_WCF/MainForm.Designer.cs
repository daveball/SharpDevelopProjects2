/*
 * Created by SharpDevelop.
 * User: balld
 * Date: 24/07/2013
 * Time: 10:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
using System.Xml;
using SeoAcknowledgeNotificationReceipt_v0_1;
using SeoReceiveNotification_v0_1;
using SeoListNotifications_v0_1;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Net;
using wse;
using System.Collections;
using System.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using LA_CAS_Messages;
using LA_CAS_Messages.core3;
using LA_CAS_Messages.PersonDescriptives2;
using LA_CAS_Messages.core2;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Globalization;

namespace ESP_Notifications_WCF
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.RetrevieNotificationsBtn = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton1.Checked=true;
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// RetrevieNotificationsBtn
			// 
			this.RetrevieNotificationsBtn.Location = new System.Drawing.Point(12, 94);
			this.RetrevieNotificationsBtn.Name = "RetrevieNotificationsBtn";
			this.RetrevieNotificationsBtn.Size = new System.Drawing.Size(125, 38);
			this.RetrevieNotificationsBtn.TabIndex = 0;
			this.RetrevieNotificationsBtn.Text = "Retreive Death Notification for ESP";
			this.RetrevieNotificationsBtn.UseVisualStyleBackColor = true;
			this.RetrevieNotificationsBtn.Click += new System.EventHandler(this.RetrevieNotificationsBtnClick);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(33, 25);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "UAT Queue";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(33, 55);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Live Queue";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(783, 266);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.RetrevieNotificationsBtn);
			this.Name = "MainForm";
			this.Text = "ESP_Notifications_WCF";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button RetrevieNotificationsBtn;
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
					
					     			return myXML.SelectSingleNode("//ns0:ErrorDescription",nmanager).InnerText;
				     		
		}
		
		private XmlElement QueryAccountHistory( string UCRN)
		{   SeoQueryCitizenAccount_v0_1Doc doc = new SeoQueryCitizenAccount_v0_1Doc();
			doc.SetSchemaLocation("SeoQueryCitizenAccount_v0_1.xsd");
			QueryCitizenHistoryRequestType root= new QueryCitizenHistoryRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "QueryCitizensAccountRequest");
			
			LA_CAS_Messages.core3.UCRNType myUCRN = new LA_CAS_Messages.core3.UCRNType(UCRN);
			
				root.AddUCRN(myUCRN);
			return doc.GetDomDocument().DocumentElement;
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
		/// <summary>
        /// Gets the current UPRN from citizen history response.
        /// </summary>
        /// <param name="response">QueryCitizenHistoryResponseType</param>
        /// <returns>Success - returns the UPRN or GUID of the current citizen address.
        /// Failure - returns empty UPRN string.</returns>
        private string GetCurrentUprnFromCas(QueryCitizensAccountResponseType response)
        {
         string casUprn = string.Empty;
                                               
         int propertyCount = response.GetCurrentPropertyCount();
                                               
                                                if(propertyCount >= 1)
                                                {
                                                                for(int i = 0; i < propertyCount; i++)
                                                                {
                                                                                string propertyType = response.GetCurrentPropertyAt(i).GetPropertyType().Value;
                                                                               
                                                                                if(propertyType == "Primary")
                                                                                {
                                                                                                int addressLineCount = response.GetCurrentPropertyAt(i).UKPostalAddress.LineCount;
                                                                                                int postCodeCount = response.GetCurrentPropertyAt(i).UKPostalAddress.PostCodeCount;
                                                                                                int uprnCount = response.GetCurrentPropertyAt(i).UPRNCount;
                                                                                                int guidCount = response.GetCurrentPropertyAt(i).CASAddressGUIDCount;
                                                                                               
                                                                                                if(addressLineCount >= 1 && postCodeCount == 1 && uprnCount == 1)
                                                                                                {
                                                                                                                casUprn = response.GetCurrentPropertyAt(i).UPRN.ToString();
                                                                                                                break;
                                                                                                }
                                                                                                else if (addressLineCount >= 1 && postCodeCount == 1 && guidCount == 1)
                                                                                                {
                                                                                                                casUprn = response.GetCurrentPropertyAt(i).CASAddressGUID.ToString();
                                                                                                                break;
                                                                                                }
                                                                                }
                                                                }
                                                }
                                                return casUprn;
                                }
 
		void RetrevieNotificationsBtnClick(object sender, System.EventArgs e)
		{   int CountNotificationOfDeath =0;
            int CountNotificationOfDeathCorrection =0;		
			#region ReadConfigurationVariables
			
			string policy		= 	string.Empty;
			string URL			=	 string.Empty;
			string partnerID	= 	System.Configuration.ConfigurationManager.AppSettings["PartnerID"];
			string outputfile 	=	System.Configuration.ConfigurationManager.AppSettings["file"] +"_"+DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")+".txt";
			string delimiter 	=	System.Configuration.ConfigurationManager.AppSettings["delimiter"];
			bool   delete		=	Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["RemoveNotificationFromQueueAfterProcessing"]);
			bool   deleteError	=	Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["RemoveNotificationsThatThrowErrorsFromQueue"]);
			string proxyStr		= 	System.Configuration.ConfigurationManager.AppSettings["Proxy"];	
			string domain 		=	System.Configuration.ConfigurationManager.AppSettings["ProxyDomain"];
			string user 		= 	System.Configuration.ConfigurationManager.AppSettings["ProxyUser"];
			string password 	=	System.Configuration.ConfigurationManager.AppSettings["ProxyPassword"];
							
			#endregion			
			#region SelectingWhichSystemToUse
			if (radioButton1.Checked)
			{
				policy=System.Configuration.ConfigurationManager.AppSettings["UAT_Policy"];
				URL=System.Configuration.ConfigurationManager.AppSettings["UAT_URL"];
			}
			if (radioButton2.Checked)
			{
				policy=System.Configuration.ConfigurationManager.AppSettings["Live_Policy"];
				URL=System.Configuration.ConfigurationManager.AppSettings["Live_URL"];
				
			}
			#endregion
			
			#region CreateEndpointAndSetPolicy
			wse.CASEndpointBean myCASEndpoint = new wse.CASEndpointBean();
			myCASEndpoint.Url= URL;
				
			// Set WSE policy to be used
			myCASEndpoint.SetPolicy(policy);
			#endregion	
			// Check to see if a proxy server is used
			#region SetupProxyServer
			WebProxy myProxy;
			
			if (((proxyStr != null) && (proxyStr != "")))
			{
			 	//Create Web Proxy
				myProxy = new WebProxy( proxyStr ,true);
				if ((domain !="")&&(domain !=null))
				{
				System.Net.NetworkCredential mycredentials = new NetworkCredential(user,password,domain);
				myProxy.Credentials= mycredentials;
				}
				else if((user !="")&&(user !=null))
				{
				System.Net.NetworkCredential mycredentials = new NetworkCredential(user,password);
				myProxy.Credentials= mycredentials;	
				}
		    	    
				myCASEndpoint.Proxy= myProxy;
			 }
			#endregion	
             // create citizen account request message  
			#region CreateNotificationListQuery             
			CitizenAccountRequestMessage myRequest =  new CitizenAccountRequestMessage();
			myRequest.CASRequestData = new CitizenAccountRequestType();
			//Create cas message header
			myRequest.CASRequestData.Header= new CitizenAccountRequestHeaderType();
		    // populate cas request header
			myRequest.CASRequestData.Header.CorrelationID= Guid.NewGuid().ToString();
			myRequest.CASRequestData.Header.UserID=partnerID;
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID=partnerID;
			//Create payload of list notification type
		    myRequest.CASRequestData.Any= listNotification();	
            #endregion
		    
		    // Create CAS Response Message
		    CitizenAccountResponseMessage MyResponse = new CitizenAccountResponseMessage();
		    // Call Cas Webservices and get a response
		    #region SendNotificationListRequesttoWebserviceEndpoint
		    try
		    {
		    MyResponse = myCASEndpoint.sendCitizenAccountMessage(myRequest);
		    }
		    catch(Microsoft.Web.Services3.ResponseProcessingException repx)
		    {
		    	MessageBox.Show(repx.Message);
		    }
		    catch(Exception ex)
		    {
		    	
		    }
			#endregion	    
		    // Create Notification XML document to allow  selection of notification nodes
		    XmlDocument  NotificationsDoc= new XmlDocument();
			NotificationsDoc.LoadXml(MyResponse.CASResponseData.Any.OuterXml);
		    //Select notification node list and store as node list of notification
			XmlNodeList Nodelist = NotificationsDoc.SelectNodes("//Notification");
			System.IO.StreamWriter file = new StreamWriter(outputfile);
			
           file.WriteLine("UCRN" +delimiter+"Forename"+delimiter+"Surname"+delimiter+"Gender"+delimiter+"DateofBirth"+delimiter+"DateofDeath"+delimiter+"PreferedForename"+delimiter+"PreferedSurname"+delimiter+"NECNumber"+delimiter+ "Address1"  +delimiter+ "Address2" +delimiter+ "Address3" +delimiter+ "Address4" +delimiter+"City" +delimiter+ "County" +delimiter+"PostCode" +delimiter+"UPRN"+delimiter+ "OldDateofDeath" );
			
			//process each node list
			foreach(XmlNode node in Nodelist)
			{   bool messageprocessed =true;
			
				#region ProcessNotificationList
				string notifcationID = string.Empty;
				string notificationType = string.Empty;
				XmlDocument tempxml = new XmlDocument();
				tempxml.LoadXml(node.OuterXml);
                // Select Notification ID Value from Node      
				notifcationID = tempxml.SelectSingleNode("//NotificationID").InnerText;
				
				// Select Notification type Value from Node    
					
				notificationType = tempxml.SelectSingleNode("//NotificationType").InnerText;
				#endregion
				
				try{
				//Check to see if notification is a death notification or a Death correction notification
				
				
		    	      if (notificationType=="NotificationOfDeathCorrection" ||  notificationType=="NotificationOfDeath")
		    	      {
				        #region CreateNotificationRequest
		    	      	string corrid = Guid.NewGuid().ToString();
				        DateTime now = DateTime.Now;
						myRequest.CASRequestData.Header = new wse.CitizenAccountRequestHeaderType();
						myRequest.CASRequestData.Header.CorrelationID=corrid;
						myRequest.CASRequestData.Header.UserID="ESP";
						myRequest.CASRequestData.Header.PartnerID=partnerID;
						myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
				
						//Status mystatus = new Status();

				
						myRequest.CASRequestData.Any = requestNotification(notifcationID);
					    #endregion
						// get notification of death or death correction from QUEUE
		    	      	#region GetNotificationFromQueue
				        MyResponse = myCASEndpoint.sendCitizenAccountMessage(myRequest);
			    	    string UCRN= string.Empty;
			    	    DateTime personDeathDate;
			    	    #endregion
						// Process Notification of Death Response
					    #region NotificationofDeathProcessing	
				        if(notificationType=="NotificationOfDeath")
			    	    {
				        	XmlDocument DeathNotificationXML = new XmlDocument();
				        	//MessageBox.Show(MyResponse.CASResponseData.Any.OuterXml);
				           	Trace.WriteLine(MyResponse.CASResponseData.Any.OuterXml);
				        	DeathNotificationXML.LoadXml(MyResponse.CASResponseData.Any.OuterXml);
				        	ReceiveNotificationResponseType  myNotificationResponse= new ReceiveNotificationResponseType(DeathNotificationXML);
				         
				        	XmlNamespaceManager nmanager = new XmlNamespaceManager(DeathNotificationXML.NameTable);
					     	
					     	// Add namespaces
					     	nmanager.AddNamespace("n3","http://www.scottishcitizen.gov.uk/citizen/v0-1");
					     	nmanager.AddNamespace("PersonDescriptives","http://www.govtalk.gov.uk/people/PersonDescriptives");
					     		                      
				        	
				        	XmlNode DeathNotificationNode = DeathNotificationXML.SelectSingleNode("//n3:NotificationOfDeath",nmanager);
				        	NotificationOfDeathType myDeathNotification = new NotificationOfDeathType(DeathNotificationNode);
			    	        personDeathDate =myDeathNotification.DateOfDeath.PersonDeathDate.Value;
			    	        //MessageBox.Show(personDeathDate.ToString());
			    	        UCRN= myDeathNotification.UCRN.Value;
			    	        //MessageBox.Show(UCRN);
			    	        CountNotificationOfDeath++ ;
			    	    }
				        #endregion
						// Process Notification of Death Correction
						DateTime personOrginalDeathDate = new DateTime();
						#region NotificationOfDeathCorrectionProcessing
				        if(notificationType=="NotificationOfDeathCorrection")
			    	    {
				        	XmlDocument DeathNotificationCorrectionXML = new XmlDocument();
				        	DeathNotificationCorrectionXML .LoadXml(MyResponse.CASResponseData.Any.OuterXml);
				        	XmlNamespaceManager nmanager = new XmlNamespaceManager(DeathNotificationCorrectionXML.NameTable);
					     	
					     	// Add namespaces
					     	nmanager.AddNamespace("n3","http://www.scottishcitizen.gov.uk/citizen/v0-1");
					     	nmanager.AddNamespace("PersonDescriptives","http://www.govtalk.gov.uk/people/PersonDescriptives");
					     	NotificationOfDeathCorrectionType myDeathCorrectionNotification = new NotificationOfDeathCorrectionType(DeathNotificationCorrectionXML.SelectSingleNode("//n3:NotificationOfDeathCorrection",nmanager));
			    	        personOrginalDeathDate =myDeathCorrectionNotification.OriginalDateOfDeath.PersonDeathDate.Value;
			    	        
			    	        UCRN=myDeathCorrectionNotification.UCRN.Value;
			    	        //MessageBox.Show(personOrginalDeathDate.ToString());
			    	        CountNotificationOfDeathCorrection++;
			    	    }
				        #endregion
			    	    // put in code to query account using  ucrn
				        #region QueryCitizenAccount
				        corrid = Guid.NewGuid().ToString();
				        now = DateTime.Now;
						myRequest.CASRequestData.Header = new wse.CitizenAccountRequestHeaderType();
						myRequest.CASRequestData.Header.CorrelationID=corrid;
						myRequest.CASRequestData.Header.UserID="ESP";
						myRequest.CASRequestData.Header.PartnerID=partnerID;
						myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
				        myRequest.CASRequestData.Any=QueryAccountHistory(UCRN);
				        // put in code to write to file
						 
				        MyResponse = myCASEndpoint.sendCitizenAccountMessage(myRequest);
				        #endregion
				        
				        #region ProcessCitizenRecord
				        XmlDocument AccountQueryXML = new XmlDocument();
				        AccountQueryXML.LoadXml(MyResponse.CASResponseData.Any.OuterXml);
				   
                   		QueryCitizensAccountResponseType    myAcountHistoryResponse = new QueryCitizensAccountResponseType(AccountQueryXML);
				   
				        

                 		
                   		string forename = string.Empty;
                		string surname = string.Empty;
                 		string preferedforename =string.Empty;
                 		string preferedsurname= string.Empty;
                 		string Gender =string.Empty;
                 		string DateofBirth= string.Empty;
                 		string DateofDeath= string.Empty;
                 		string previousDateofDeath = string.Empty;
                 		if (personOrginalDeathDate !=null)
                 		{
                 			previousDateofDeath= personOrginalDeathDate.ToShortDateString();
                 		}
                 		string NECNumber= string.Empty;
                 		string[] AddressLines = new string[5];
                 		string Address1 = string.Empty;
						string Address2 = string.Empty;
						string Address3 = string.Empty;
						string Address4 = string.Empty;
						string City = string.Empty;
						string County = string.Empty;
						string PostCode = string.Empty;
						string UPRN= GetCurrentUprnFromCas(myAcountHistoryResponse);
						string NewDateofDeath= string.Empty;

                 		if ( personOrginalDeathDate!=null)
                 		{
                 			//Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB"); 
                 			previousDateofDeath  =personOrginalDeathDate.ToShortDateString();
                 		}
                 		
                 		if(myAcountHistoryResponse.CitizenDetails.DateOfDeathCount>0)
                 		{
                 			DateofDeath=myAcountHistoryResponse.CitizenDetails.DateOfDeath.PersonDeathDate.Value.ToLongDateString();
                 		}
                 
               
               			if (myAcountHistoryResponse.CitizenDetails.CitizenName.PersonGivenNameCount >0)
               			{
	               
	               			forename =myAcountHistoryResponse.CitizenDetails.CitizenName.PersonGivenName.Value;
	               	
               			}
               
               			if (myAcountHistoryResponse.CitizenDetails.CitizenName.PersonFamilyNameCount >0)
               			{
              
               				surname = myAcountHistoryResponse.CitizenDetails.CitizenName.PersonFamilyName.Value;
               			}
             
                
             
               			if(myAcountHistoryResponse.CitizenDetails.CitizenName.PersonRequestedNameCount >0)
              			{	
               			preferedforename= myAcountHistoryResponse.CitizenDetails.CitizenName.PersonRequestedName.Value;
             
               			}
             

               
               			if (myAcountHistoryResponse.CitizenDetails.GenderCount >0)
               			{
               				switch(myAcountHistoryResponse.CitizenDetails.Gender.Value)
               				{ case 1:
                  		
                    					Gender="M";
                  						break;
                  			  case 2:
                  						Gender="F";
                  						break;
                  			  default:
                  						break;
                  	
                  			}
               	
               			}
               			if (myAcountHistoryResponse.CitizenDetails.NECNumberCount >0)
               			{
               				NECNumber= myAcountHistoryResponse.CitizenDetails.NECNumber.Value;
               			}
               			if (myAcountHistoryResponse.CitizenDetails.DateOfBirthCount >0)
              			{
               				DateofBirth=myAcountHistoryResponse.CitizenDetails.DateOfBirth.PersonBirthDate.Value.ToShortDateString();
               			}
                		#endregion
                        #region WriteResultsToFile
              			
              			
              			file.WriteLine(UCRN +delimiter+forename+delimiter+surname+delimiter+Gender+delimiter+DateofBirth+delimiter+DateofDeath+delimiter+preferedforename+delimiter+delimiter+NECNumber+delimiter+ Address1  +delimiter+ Address2 +delimiter+ Address3 +delimiter+ Address4 +delimiter+City +delimiter+ County +delimiter+PostCode +delimiter+UPRN+ previousDateofDeath );
              			file.Flush();
              		
              			#endregion
						
		    	      }
					
				}
		   		catch(Microsoft.Web.Services3.ResponseProcessingException repx)
		    	{
		   			messageprocessed =deleteError;
		   		
		    	MessageBox.Show(repx.Message);
		    	}
		    	catch(Exception ex)
		    	{
			    	    
						 
						if(delete&&messageprocessed)
		    		messageprocessed =deleteError;
		    	}
		    		// check to see if notifications should be  delete
						#region DeleteMessageFromQueueForProcessedMessage
						{
					
						string corrid = Guid.NewGuid().ToString();
			    		myRequest.CASRequestData.Header = new wse.CitizenAccountRequestHeaderType();
			    		myRequest.CASRequestData.Header.CorrelationID=corrid;
			    		myRequest.CASRequestData.Header.UserID="ESP";
			    		myRequest.CASRequestData.Header.PartnerID=partnerID;
			    		myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
						myRequest.CASRequestData.Any = acknowledgeNoticiation(notifcationID);
						//mystatus = new Status();

						try
						{
							MyResponse=myCASEndpoint.sendCitizenAccountMessage(myRequest);
						}						
		   				catch(Microsoft.Web.Services3.ResponseProcessingException repx)
		    			{
		    			MessageBox.Show(repx.Message);
		    			}
		    			catch(Exception ex)
		    			{
		    			}
			    	    
		    	   
						}
						#endregion
		    
			
		    	
			
			}
		file.Close();
		MessageBox.Show("Processed 1000 notifications  from queue, Death Notifications  "+ CountNotificationOfDeath.ToString() +", Death Corrections " + CountNotificationOfDeathCorrection.ToString());
		}
	}
}
			
	


	


	
	

