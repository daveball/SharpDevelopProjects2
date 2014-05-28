//
// TelephoneNumberType.cs
//
// This file was generated by XMLSpy 2008r2sp2 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using Altova.Types;

namespace SeoReceiveNotification_v0_1.core2
{

	public class TelephoneNumberType : SchemaString
	{
		public static  string[] sPatternValues = {
			"[0-9 \\-]{1,20}",
		};


		public TelephoneNumberType() : base()
		{
		}

		public TelephoneNumberType(string newValue) : base(newValue)
		{
			Validate();
		}

		public TelephoneNumberType(SchemaString newValue) : base(newValue)
		{
			Validate();
		}


		public static  int GetPatternCount()
		{
			return sPatternValues.Length;
		}

		public static  string GetPatternValue(int index)
		{
			return sPatternValues[index];
		}
		public  void Validate()
		{
		}
	}
}
