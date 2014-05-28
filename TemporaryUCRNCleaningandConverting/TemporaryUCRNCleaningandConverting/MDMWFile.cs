/*
 * Created by SharpDevelop.
 * User: Ball.Dave
 * Date: 20/01/2014
 * Time: 15:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using FileHelpers;

namespace TemporaryUCRNCleaningandConverting
{
	/// <summary>
	/// Description of MDMWFile.
	/// </summary>
	/// 
		[IgnoreEmptyLines] 
	[DelimitedRecord(",")] 
	public class MDMWFile
	{
		public string UCRN;
  		public string Forename;
  		
  		public string Surname;
  		public string DOB;
  		
  	
		  
	}
}
