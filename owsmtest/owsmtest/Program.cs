/*
 * Created by SharpDevelop.
 * User: balld
 * Date: 16/09/2011
 * Time: 14:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using owsmtest.casuat;
using owsmtest;
using System.Xml;
using SeoQueryUCRN_v0_1;
using System.Diagnostics;
using System.Collections;
using SeoQueryUCRN_v0_1.core0;
using SeoQueryUCRN_v0_1.PersonDescriptives;
using SeoQueryUCRN_v0_1.core;
using System.IO;
using System.Data;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;


namespace owsmtest
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			CASEndpointBean myEndpoint = new CASEndpointBean();
			CitizenAccountRequestMessage myRequest = new CitizenAccountRequestMessage();
			myRequest.CASRequestData = new CitizenAccountRequestType();
			myRequest.CASRequestData.Header= new CitizenAccountRequestHeaderType();
		
			myRequest.CASRequestData.Header.CorrelationID= Guid.NewGuid().ToString();
			myRequest.CASRequestData.Header.UserID="Stirling";
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID="30";
			string BaseURL = @"http://owsm04.";
			string  domain =System.Configuration.ConfigurationManager.AppSettings["domain"];
			BaseURL=BaseURL+domain;
			BaseURL=BaseURL+":7777/gateway/services/";
			string UATCASURL= BaseURL+"CASEndpointBean_UAT";
			string LiveCASURL=BaseURL+"CASEndpointBean_LIVE";
			//XmlNode temp=   ;//     
			myRequest.CASRequestData.Any= owsmtest.Program.UCRNQuery("David","Ball",1971,04,26,1);
			//myRequest.CASRequestData.Any.SetAttribute();
			
			System.IO.StreamWriter file = new StreamWriter(domain+".txt");
			 file.WriteLine("*********************************************************************");
		     file.WriteLine("                  Testing OWSM  for "+ domain );
             file.WriteLine("*********************************************************************");
		     Console.WriteLine("*********************************************************************");
		     Console.WriteLine("                  Testing OWSM  for "+ domain );
             Console.WriteLine("*********************************************************************");
			CitizenAccountResponseMessage MyResponse = new CitizenAccountResponseMessage();
			try{file.WriteLine();
				file.WriteLine("******* Testing UAT CASEndpointBean Webservices **********************");
				file.WriteLine(UATCASURL);
				Console.WriteLine();
				Console.WriteLine("******* Testing UAT CASEndpointBean Webservices **********************");
				Console.WriteLine(UATCASURL);
				myEndpoint.Url= UATCASURL;
			      Trace.WriteLine(myRequest.CASRequestData.Header);
			      MyResponse=myEndpoint.sendCitizenAccountMessage(myRequest);
			  
			
			if(MyResponse!= null)
			{  file.WriteLine("UAT CAS Webservices OK");
				Console.WriteLine("UAT CAS Webservices OK");
			}
			else
			{   file.WriteLine("UAT CAS Webservices Failure");
				Console.WriteLine("UAT CAS Webservices Failure");}
			}
			catch(WebException webex)
			{   Console.WriteLine("UAT CAS Webservices Failure");
				Console.WriteLine("Web Exception = " + webex.Message);
				file.WriteLine("UAT CAS Webservices Failure");
				file.WriteLine("Web Exception = " + webex.Message);
				
			}
			catch(Exception ex)
			{
				Console.WriteLine("UAT CAS Webservices Failure");
				Console.WriteLine(ex.Message);
					file.WriteLine("UAT CAS Webservices Failure");
				file.WriteLine(ex.Message);
			}
				
			try{
				myEndpoint.Url=LiveCASURL;
				file.WriteLine();
				file.WriteLine("******* Testing Live CASEndpointBean Webservices  ****************");
			    file.WriteLine(LiveCASURL);
				Console.WriteLine();
				Console.WriteLine("******* Testing Live CASEndpointBean Webservices  ****************");
				Console.WriteLine(LiveCASURL);
			MyResponse=myEndpoint.sendCitizenAccountMessage(myRequest);
			
			
			if(MyResponse!= null)
			{
				Console.WriteLine( "Live CAS Webservices OK");
				file.WriteLine( "Live CAS Webservices OK");
			}
			else
			{ file.WriteLine("Failure");
				Console.WriteLine("Failure");}
			}
			catch(WebException webex)
			{   Console.WriteLine("Live CAS Webservices Failure");				
				Console.WriteLine("Web Exception = " +webex.Message);
				file.WriteLine("Live CAS Webservices Failure");				
				file.WriteLine("Web Exception = " +webex.Message);
				
			}
			catch(Exception ex)
			{   Console.WriteLine("Live CAS Webservices Failure");
				Console.WriteLine("Exception = " +ex.Message);
			file.WriteLine("Live CAS Webservices Failure");
				file.WriteLine("Exception = " +ex.Message);
			
			}
			

			//Console.WriteLine(myRequest.CASRequestData.Any.OuterXml);
			// TODO: Implement Functionality Here
		//Console.WriteLine(MyResponse.CASResponseData.Any.OuterXml);
		file.Close();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		private static XmlElement UCRNQuery(string forename, string surname,int YearOfBirth,int MonthOfBirth,int DayOfBirth , int gender)
		{
			SeoQueryUCRN_v0_1.SeoQueryUCRN_v0_12 doc = SeoQueryUCRN_v0_1.SeoQueryUCRN_v0_12.CreateDocument();
	         			//mynodnew System.Xml.XmlAttribute(("n3","QueryUCRNRequest", "http://www.scottishcitizen.gov.uk/citizen/v0-1");
				
	         			SeoQueryUCRN_v0_1.QueryUCRNRequestType root =doc.QueryUCRNRequest.Append();
		
			//Altova.TypeInfo.MemberInfo member = root.GetAttribute();
			//member.LocalName.="n3:QueryUCRNRequest";
			//Altova.TypeInfo.MemberInfo member = new Altova.TypeInfo.MemberInfo(
			//doc.QueryUCRNRequest.First.CreateAttribute(member);
			//Console.WriteLine();
			//Console.WriteLine(Altova.Xml.XmlTreeOperations.FindUnusedPrefix(doc.QueryUCRNRequest.First.Node,"n3"));
		    
			//root.CreateAttribute(new Altova.TypeInfo.MemberInfo(
			SeoQueryUCRN_v0_1.core0.CitizenSearchDetailsType citizen = root.CitizenDetails.Append();
			PersonGivenNameTypeType Forename =citizen.Forename.Append();
			Forename.Value=forename;
			PersonFamilyNameTypeType Surname = citizen.Surname.Append();
			Surname.Value= surname;
				GenderAtRegistrationTypeType Gender = citizen.Gender.Append();
				Gender.Value=gender;
			DateTypeType DOB = citizen.DateOfBirth.Append();
			Altova.Types.DateTime mydob= new Altova.Types.DateTime(YearOfBirth,MonthOfBirth,DayOfBirth);
			DOB.Value=mydob;
			//doc.SetXsiType();	
			//Citizen(forename,surname,dob,gender));
			
			//Console.WriteLine( doc.QueryUCRNRequest.First.Node.OuterXml);
			XmlElement myelement=doc.QueryUCRNRequest.First.Node as XmlElement;
			XmlDocument mydoc = new XmlDocument();
			mydoc.LoadXml(doc.QueryUCRNRequest.First.Node.OuterXml);
			//XmlAttribute myattribute = XmlAttribute
	   mydoc.CreateAttribute("n3","QueryUCRNRequest","http://www.scottishcitizen.gov.uk/citizen/v0-1");
	   
	   	   //Console.WriteLine(mydoc.OuterXml);
	//myelement.SetAttributeNode("n3:QueryUCRNRequest","http://www.scottishcitizen.gov.uk/citizen/v0-1");
		//PersonGivenNameType forename = citizen.Append()
		//root.CitizenDetails.
//			   QueryUCRNRequestType root = new QueryUCRNRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "n3:QueryUCRNRequest");
//			  DateType DOB =  new DateType("1971-04-26");
//			PersonGivenNameType Forename = new    PersonGivenNameType("David");
//			   PersonFamilyNameType Surname = new PersonFamilyNameType("Ball");
//			 GenderAtRegistrationType Gender = new  GenderAtRegistrationType("1");
//			root.AddCitizenDetails(Citizen(forename,surname,dob ,gender));
		return myelement;
		}
	}
}