//
// SeoQueryUCRN_v0_1Test.cs
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

namespace SeoQueryUCRN_v0_1
{
	/// <summary>
	/// Summary description for SeoQueryUCRN_v0_1Test.
	/// </summary>
	class SeoQueryUCRN_v0_1Test
	{
		protected static void Example()
		{
			//
			// TODO:
			//   Insert your code here...
			//
			// Example code to create and save a structure:
			//   SeoQueryUCRN_v0_1Doc doc = new SeoQueryUCRN_v0_1Doc();
			//   doc.SetSchemaLocation("SeoQueryUCRN_v0_1.xsd"); // optional
			//   QueryUCRNResponseType root = new QueryUCRNResponseType(doc, "http://www.scottishcitizen.gov.uk/citizen/v0-1", "", "QueryUCRNResponse");
			//   ...
			//   doc.Save("SeoQueryUCRN_v0_11.xml", root);
			//
			// Example code to load and save a structure:
			//   SeoQueryUCRN_v0_1Doc doc = new SeoQueryUCRN_v0_1Doc();
			//   QueryUCRNResponseType root = new QueryUCRNResponseType(doc.Load("SeoQueryUCRN_v0_11.xml"));
			//   ...
			//   doc.Save("SeoQueryUCRN_v0_11.xml", root);
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
				Console.WriteLine("SeoQueryUCRN_v0_1 Test Application");
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
