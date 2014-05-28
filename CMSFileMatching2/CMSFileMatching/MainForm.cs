/*
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
using System.Threading;

namespace CMSFileMatching
{
	public class Worker
{
    private ProgressBar mybar;
    private Label mylabel;
    private string ESPfilename;
    	public Worker(string filename, ProgressBar bar, Label label)
    { mybar=bar;
    	mylabel= label;
    	ESPfilename =filename;
    }
		// This method will be called when the thread is started.
    public void DoWork()
    {
        while (!_shouldStop)
        {
            Console.WriteLine("worker thread: working...");
        }
        Console.WriteLine("worker thread: terminating gracefully.");
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
    public  void processESPfile()
    {
    	        System.IO.StreamReader sr = new 
         		System.IO.StreamReader(ESPfilename);
      		
      			int rows = CountLinesInFile(ESPfilename);
      			string processlabel= "Processing File "+ESPfilename;
      			
//      			MethodInvoker m=new MethodInvoker( ()=> progressbar.Progress=value);
//    progressbar.invoke(m);
//									MethodInvoker m = new MethodInvoker(  mylabel.Text=processlabel);
//									BeginInvoke(m);
//									mylabel.Invoke(m);
//                                    m = new MethodInvoker( mybar.Visible=true);
//                                    BeginInvoke(m);
//                                    m = new MethodInvoker( mybar.Maximum= rows);
//                                  BeginInvoke.Invoke(m);
      			//mybar.Visible= true;
      			//mybar.Maximum= rows;
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
			     	string Forename = words[8];
			     	Forename = Forename.Replace("\"","");
			     		string Surname = words[10];
			     		Surname = Surname.Replace("\"","");
			     	    string DateOfBirth= words[12];
			     	   DateOfBirth= DateOfBirth.Replace("\"","");
			     	    if (DateOfBirth== "Date of Birth")
			     	    {
			     	    	currentrow++;
			     	    	using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
			      	    {
							foreach (string userdetail   in words)
							{
												file.Write(userdetail+delimeter);
							}
				
						
							
					      file.WriteLine("UCRN");
	          			}
			     	    }
			     	    else{
			     		// code to query UCRN with citizen detials
			     		
			     	    string[] DOBElements=DateOfBirth.Split('-');
						if (DOBElements == null)
							return;
			     	    int gender;
			     		//Set gender to Male.
			     		string  GenderStr =words[6] ;
			     		GenderStr =GenderStr.Replace("\"","");  
			     	if (GenderStr =="M")
			     	{
			     	     gender=1;
			     	}
			     	else 
			     	{
			     		 gender =2;
			     	}
						string NECNumber =words[NECLocation];
			          
						string	corrid = Guid.NewGuid().ToString();
						CitizenAccountRequestMessage myRequest =  new CitizenAccountRequestMessage();
						myRequest.CASRequestData = new CitizenAccountRequestType();
						myRequest.CASRequestData.Header= new CitizenAccountRequestHeaderType();
					
						myRequest.CASRequestData.Header.CorrelationID= corrid;
						myRequest.CASRequestData.Header.UserID="CMS_Matching_on_NEC";
						myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
						myRequest.CASRequestData.Header.PartnerID=partnerID;
						string DOB= string.Empty;
						if (DOBElements.Length==3)
						{
						DOB= DOBElements[2]+"-"+DOBElements[1]+"-"+DOBElements[0];
						}
						
				        //myRequest.CASRequestData.Any= UCRNQuery(NECNumber);
				        CitizenAccountResponseMessage myResponse = new CitizenAccountResponseMessage();
				        try{
					        myRequest.CASRequestData.Any= UCRNQuery(DOB,Forename,Surname,gender);
				     	   
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
				     	
				     	

			     		
			     


			     	
			    
						using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
			      	    {
							foreach (string userdetail   in words)
							{
												file.Write(userdetail+delimeter);
							}
				
						
							
					      file.WriteLine("\""+UCRN+"\"");
	          			}
			   
			      	currentrow++;
//			      	m = new MethodInvoker(()=> mylabel.Text=processlabel + ": Line " +currentrow.ToString());
//			      	mylabel.Invoke(m);
//			      	m = new MethodInvoker(()=> mylabel.Update());
//			      	
//			      	mylabel.Invoke(m);
//			      	m= new MethodInvoker(()=> mybar.Value=currentrow);
//			      	mybar.Invoke(m);
//			      
			      	
			      }
			      }
			      using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
			      {
			      	file.WriteLine("Contraol Totals: Input Rows="+ rows+ "  ; Processed Rows=" +currentrow);
			      }
			     mylabel.Text = "Matching Completed  Results at " +outfilenamewithpath; 
			
			      mylabel.Update();
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
	
    public void RequestStop()
    {
        _shouldStop = true;
    }
    // Volatile is used as hint to the compiler that this data
    // member will be accessed by multiple threads.
    private volatile bool _shouldStop;
}
	
	
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
				     			
					     			MessageBox.Show (getErrorDecription(rpex2));
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
		      	Worker workerObject = new Worker(openFileDialog1.FileName,progressBar1,LblStatus);
		      	Thread workerThread = new Thread(workerObject.processESPfile);
		
		        // Start the worker thread.
		        workerThread.Start();
		        while (!workerThread.IsAlive);
		
		        // Put the main thread to sleep for 1 millisecond to
		        // allow the worker thread to do some work:
		        Thread.Sleep(1);
		
		        // Request that the worker thread stop itself:
		        workerObject.RequestStop();
		
		        // Use the Join method to block the current thread 
		        // until the object's thread terminates.
		        workerThread.Join();
		        
			}
		}
	}
	}


			
			
		
