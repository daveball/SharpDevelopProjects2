/*
 * Created by SharpDevelop.
 * User: Ball.Dave
 * Date: 25/11/2013
 * Time: 11:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using FileHelpers;

namespace DevartOracletest
{
	/// <summary>
	/// Description of GUIDFile.
	/// </summary>
	/// 
	[DelimitedRecord(",")] 
	public class GUIDFile
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
		
	}
}
