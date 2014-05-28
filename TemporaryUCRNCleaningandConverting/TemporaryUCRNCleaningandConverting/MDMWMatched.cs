/*
 * Created by SharpDevelop.
 * User: Ball.Dave
 * Date: 21/01/2014
 * Time: 11:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using FileHelpers;

namespace TemporaryUCRNCleaningandConverting
{
	/// <summary>
	/// Description of MDMWMatched.
	/// </summary>
	/// 
	
	[DelimitedRecord(",")]
	public class MDMWMatched
	{
		public string Forename;
  		
  		public string Surname;
	
  		public string UCRN;
  		
  		public string tempUCRN;
  		public string DOB;
  		public string Gender; 
  		public string username;
  		public string email;
	}
}
