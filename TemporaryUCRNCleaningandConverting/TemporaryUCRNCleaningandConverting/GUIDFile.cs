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

namespace TemporaryUCRNCleaningandConverting
{
	/// <summary>
	/// Description of GUIDFile.
	/// </summary>
	/// 
	[IgnoreEmptyLines] 
	[DelimitedRecord(",")] 
	public class GUIDFile
	{
		 
  		public string GUID;
		  
  		public string UCRN;
		  
		
	}
}
