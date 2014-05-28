/*
 * Created by SharpDevelop.
 * User: ball.dave
 * Date: 26/11/2013
 * Time: 15:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using FileHelpers;

namespace GUIDResolution
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
  		public string PostCode;
	}
}
