/*
 * Created by SharpDevelop.
 * User: ball.dave
 * Date: 26/11/2013
 * Time: 16:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using FileHelpers;

namespace GUIDResolution
{
	/// <summary>
	/// Description of GUIDFileList.
	/// </summary>
	/// 
	[DelimitedRecord(",")] 
	public class GUIDFileList
	{
		[FieldQuoted()] 
  		public string GUIDFiletoProcess;
	}
}
