/*
 * Created by SharpDevelop.
 * User: Ball.Dave
 * Date: 21/01/2014
 * Time: 10:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using FileHelpers;
namespace TemporaryUCRNCleaningandConverting
{
	/// <summary>
	/// Description of CASCoreUpdate.
	/// </summary>
	/// 
	[DelimitedRecord(",")]
	public class CASCoreUpdate
	{
		public string recordID;
		public string TransType;
		public string UCRN;
		public string Forename;
		public string Surname;
		public string  DOB;
		public string gender;
		public string DOD;
	    public string CHINumber;
	
		public string T_UCRN;
		public string P_UCRN;
	}
}
