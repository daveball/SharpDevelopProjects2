/*
 * Created by SharpDevelop.
 * User: ball.dave
 * Date: 19/11/2013
 * Time: 14:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DevartOracletest
{
	/// <summary>
	/// Description of genderdob.
	/// </summary>
	public class genderdob
	{      public string DOB;
			public string Gender;
			public string Forename;
			public string Surname;
			public string  Title;
			public genderdob()
		{
			
		}
		public genderdob(string dob ,string gender, string forename, string surname, string title)
		{
			DOB=dob;
		 	Gender = gender;
		 	Forename= forename;
		 	Surname = surname;
		    Title =title;
		}
	}
}
