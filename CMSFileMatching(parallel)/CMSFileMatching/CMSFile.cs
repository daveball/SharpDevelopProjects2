/*
 * Created by SharpDevelop.
 * User: balld
 * Date: 02/09/2013
 * Time: 10:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using FileHelpers;

namespace CMSFileMatching
{
	/// <summary>
	/// Description of CMSFile.
	/// </summary>
	/// 
	[DelimitedRecord(",")] 
	[IgnoreFirst] //Ignore first line as this is the header.
  	public class CMSFile
	{
		  [FieldQuoted()] 
  		string ApplicantID;
		  [FieldQuoted()] 
  		string ApplicationID;
		  [FieldQuoted()] 
  		string ApplicationStatus;
		  [FieldQuoted()] 
  		string CreatedBy;
		  [FieldQuoted()] 
  		public string NECNumber ;
		  [FieldQuoted()] 
  		string PhotoID;
		  [FieldQuoted()] 
  		public string Gender;
		  [FieldQuoted()] 
  		string Title;
		  [FieldQuoted()] 
  		public string FirstName;
		  [FieldQuoted()] 
  		string MiddleName;
		  [FieldQuoted()] 
  		public string Surname;
		  [FieldQuoted()] 
  		string PreferredNameOnCard;
			
  		[FieldConverter(ConverterKind.Date, "dd-MM-yyyy")]
		  [FieldQuoted()] 	
  	public	DateTime DateOfBirth;
			[FieldQuoted()]
  		public string UCRNNumber ;
			[FieldQuoted()]
  		string Deceased;
			
			[FieldQuoted()] 
			string Deceaseddate;
			[FieldQuoted()]
			string Address1;
			[FieldQuoted()]
			string Address2;
			[FieldQuoted()]
			string Address3;
			[FieldQuoted()]
			string Address4;
			
			[FieldQuoted()]
			string Postcode;
			[FieldQuoted()]
			string UPRNNumber;
			[FieldQuoted()]
			string LocalAuthority;
			[FieldQuoted()]
			string Telephone;
			[FieldQuoted()]
			string Mobile;
			[FieldQuoted()]
			string Email;
			[FieldQuoted()]
			string DataShare;
			[FieldQuoted()]
			string AgreedTermsConditions;
			[FieldQuoted()]
			string KidzCard;
			[FieldQuoted()]
			string YoungScotOptOut;
			[FieldQuoted()]
			string Volunteer;
			[FieldQuoted()]
			string Elderly;
			[FieldQuoted()]
			string IdentityProof;
			[FieldQuoted()]
			string ResidencyProof;
			[FieldQuoted()]
			string DisabledGeneral;
			[FieldQuoted()]
			string DisabledHearing;
			[FieldQuoted()]
			string DisabledVisual;
			[FieldQuoted()]
			string DisabledMobility;
			  [FieldQuoted()] 
			string Companion;
			
			[FieldQuoted()] 
			string ExpiryDate;
			  [FieldQuoted()] 
			string BaseCard;
			  [FieldQuoted()] 
			string MifareNumber;
			  [FieldQuoted()] 
			string ITSOShellNumber;
			  [FieldQuoted()] 
			string ISRNNumber;
			  [FieldQuoted()] 
			string MCRNNumber;
	
			[FieldQuoted()] 
			string EncodedOn;
	
			[FieldQuoted()] 
			string PrintedOn;
	
			[FieldQuoted()] 
	string DespatchedOn;
		
			[FieldQuoted()] 
		string ExpiredOn;
			  [FieldQuoted()] 
			string TSYPBus;
			  [FieldQuoted()] 
			string TSYPRail;
			  [FieldQuoted()] 
			string TSFerry;
			  [FieldQuoted()] 
			string TSFerryVoucherNumber;
			  [FieldQuoted()] 
			string CardStatus;
			  [FieldQuoted()] 
			string Barcode;
			  [FieldQuoted()] 
			string Magstripe;
			  [FieldQuoted()] 
			string EstablishmentCode;
			  [FieldQuoted()] 
			string DeliverToAddress;
			  [FieldQuoted()] 
			string DeliverToAddress1;
			  [FieldQuoted()] 
			string DeliverToAddress2;
			  [FieldQuoted()] 
			string DeliverToAddress3;
			  [FieldQuoted()] 
			string DeliverToAddress4;
			  [FieldQuoted()] 
			string DeliverToPostcode;
			  [FieldQuoted()] 
			string ReplacementDate;
			  [FieldQuoted()] 
			string ReplacementReason;
			[FieldQuoted()]
			string HotListDate;
			  [FieldQuoted()] 
			string HotListReason;
			  [FieldQuoted()] 
			string LegacyNo;
			  [FieldQuoted()] 
			string PupilID;
			  [FieldQuoted()] 
			string HEFE;
			  [FieldQuoted()] 
			string YPYS;
			
	}
}
