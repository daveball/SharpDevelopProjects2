/*
 * Created by SharpDevelop.
 * User: balld
 * Date: 16/09/2011
 * Time: 14:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using SeoQueryUCRN_v0_1;
using System.Xml;

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
	/// <summary>
	/// Description of SeoQueryUCRN_Helper.
	/// </summary>
	public class SeoQueryUCRN_Helper
	{
		public SeoQueryUCRN_Helper()
		{
			string Forename;
			string Surname;
			string DateOfBirth;
		    int Gender;
		}
		public XmlNode UCRNQuery(string forename, string surname,string dob , int gender)
		{
			SeoQueryUCRN_v0_1.SeoQueryUCRN_v0_12 doc = SeoQueryUCRN_v0_1.SeoQueryUCRN_v0_12.CreateDocument();			
			SeoQueryUCRN_v0_1.QueryUCRNRequestType root = doc.QueryUCRNRequest.Append();
			SeoQueryUCRN_v0_1.core0.CitizenSearchDetailsType citizen = root.CitizenDetails.Append();
			PersonGivenNameTypeType Forename =citizen.Forename.Append();
			Forename.Node.InnerText=forename;
			PersonFamilyNameTypeType Surname = citizen.Surname.Append();
			Surname.Value= surname;
				GenderAtRegistrationTypeType Gender = citizen.Gender.Append();
				Gender.Value=gender;
			DateTypeType DOB = citizen.DateOfBirth.Append();
			DOB.Node.InnerText=dob;
				
			//Citizen(forename,surname,dob,gender));
				
				
		//PersonGivenNameType forename = citizen.Append()
		//root.CitizenDetails.
//			   QueryUCRNRequestType root = new QueryUCRNRequestType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "n3:QueryUCRNRequest");
//			  DateType DOB =  new DateType("1971-04-26");
//			PersonGivenNameType Forename = new    PersonGivenNameType("David");
//			   PersonFamilyNameType Surname = new PersonFamilyNameType("Ball");
//			 GenderAtRegistrationType Gender = new  GenderAtRegistrationType("1");
//			root.AddCitizenDetails(Citizen(forename,surname,dob ,gender));
		return doc.Node;
		}
//		private CitizenSearchDetailsType Citizen(string forename, string surname,string dob , string gender)
//		{
//			CitizenSearchDetailsType citizen = new  CitizenSearchDetailsType(;
//			PersonGivenNameType forename = new PersonGivenNameType();
//			citizen.Forename=forename;
//			
////				forename.CreateElement(
////				citizen.Forename.Append()
////			citizen.AddForename(Forename(forename));
////			citizen.AddSurname(Surname(surname));
////			citizen.AddGender(Gender(gender ));
////			citizen.AddDateOfBirth(DateOfBirth(dob));
//			                       
//		   return citizen;
//		}
//		private PersonGivenNameType Forename(string forename)
//		{
//			PersonGivenNameType Forename =  new PersonGivenNameType();
//			return Forename;
//		}
//		private PersonFamilyNameType Surname(string surname)
//		{PersonFamilyNameType Surname =  new PersonFamilyNameType();
//			return Surname;
//			
//			
//		}
//		private GenderAtRegistrationType Gender(string gender)
//		{
//			GenderAtRegistrationType Gender =  new GenderAtRegistrationType();
//			return Gender;
//			
//		}
//		private DateType DateOfBirth(string dob)
//		{DateType  DOB = new DateType(dob);
//			return DOB;
//		}
	}
}
