//
// SeoNotificationOfDeathCorrection_v0_1Test.cs
//
// This file was generated by XMLSpy 2012r2 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using System;
using Altova.Types;

namespace SeoNotificationOfDeathCorrection_v0_1
{
	/// <summary>
	/// Summary description for SeoNotificationOfDeathCorrection_v0_1Test.
	/// </summary>
	class SeoNotificationOfDeathCorrection_v0_1Test
	{
		protected static void Example()
		{
			//
			// TODO:
			//   Insert your code here...
			//
			// Example code to create and save a structure:
			//   SeoNotificationOfDeathCorrection_v0_1Doc doc = new SeoNotificationOfDeathCorrection_v0_1Doc();
			//   doc.SetSchemaLocation("SeoNotificationOfDeathCorrection_v0_1.xsd"); // optional
			//   NotificationOfDeathCorrectionType root = new NotificationOfDeathCorrectionType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "NotificationOfDeathCorrection");
			//   ...
			//   doc.Save("SeoNotificationOfDeathCorrection_v0_11.xml", root);
			//
			// Example code to load and save a structure:
			//   SeoNotificationOfDeathCorrection_v0_1Doc doc = new SeoNotificationOfDeathCorrection_v0_1Doc();
			//   NotificationOfDeathCorrectionType root = new NotificationOfDeathCorrectionType(doc.Load("SeoNotificationOfDeathCorrection_v0_11.xml"));
			//   ...
			//   doc.Save("SeoNotificationOfDeathCorrection_v0_11.xml", root);
			//
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static int Main(string[] args)
		{
			try
			{
				Console.WriteLine("SeoNotificationOfDeathCorrection_v0_1 Test Application");
				Example();
				Console.WriteLine("OK");
				return 0;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return 1;
			}
		}
	}
}