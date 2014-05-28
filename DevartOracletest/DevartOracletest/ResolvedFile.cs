/*
 * Created by SharpDevelop.
 * User: ball.dave
 * Date: 15/04/2014
 * Time: 13:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using FileHelpers;

namespace DevartOracletest
{
	/// <summary>
	/// Description of ResolvedFile.
	/// </summary>
	/// 
	[DelimitedRecord(",")] 
	public class ResolvedFile
	{
		
		
		[FieldQuoted()] 
  		public string GUID;
		  [FieldQuoted()] 
  		public string Forename;
		  [FieldQuoted()] 
  		public string Surname;
		  [FieldQuoted()] 
  		public string DateOfBirth;
		  [FieldQuoted()] 
  		public string Gender ;
  		  [FieldQuoted()] 
  		public string AD1;
  		 [FieldQuoted()] 
  		public string AD2;
  		 [FieldQuoted()] 
  		public string AD3;
  		 [FieldQuoted()] 
  		public string AD4;
		  [FieldQuoted()] 
  		public string PostCode;
  		[FieldQuoted()] 
  		public string AD5;
  		[FieldQuoted()] 
  		public string AD6;
  		[FieldQuoted()] 
  		public string UPRN;
  			[FieldQuoted()] 
  		public string UCRN;
		
  		public ResolvedFile()
  		{}
		public ResolvedFile(GUIDFile record, string ucrn)
		{
			GUID= record.GUID;
			Forename= record.Forename;
			Surname =record.Surname;
				DateOfBirth =record.DateOfBirth;
				Gender = record.Gender;
				AD1=record.AD1;
   AD2=record.AD2;
  		  AD3=record.AD3;
  		 AD4=record.AD4;
		 PostCode= record.PostCode;
  		 AD5=record.AD5;
  		 AD6=record.AD6;
  		UPRN=record.UPRN;
			UCRN=ucrn;
		}
	}
}
