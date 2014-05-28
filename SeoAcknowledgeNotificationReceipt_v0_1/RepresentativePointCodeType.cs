//
// RepresentativePointCodeType.cs
//
// This file was generated by XMLSpy 2012sp1 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using Altova.Types;

namespace SeoAcknowledgeNotificationReceipt_v0_1.bs76662
{

	public class RepresentativePointCodeType : SchemaLong
	{
		public static  string[] sEnumValues = {
			"1",
			"2",
			"3",
			"4",
			"5",
			"9",
		};

		public  enum EnumValues
		{
			e1 = 0, /* 1 */
			e2 = 1, /* 2 */
			e3 = 2, /* 3 */
			e4 = 3, /* 4 */
			e5 = 4, /* 5 */
			e9 = 5, /* 9 */
			EnumValueCount
		};

		public RepresentativePointCodeType() : base()
		{
		}

		public RepresentativePointCodeType(string newValue) : base(newValue)
		{
			Validate();
		}

		public RepresentativePointCodeType(SchemaLong newValue) : base(newValue)
		{
			Validate();
		}

		public static  int GetEnumerationCount()
		{
			return sEnumValues.Length;
		}

		public static  string GetEnumerationValue(int index)
		{
			return sEnumValues[index];
		}

		public static  bool IsValidEnumerationValue(string val)
		{
			foreach (string s in sEnumValues)
			{
				if (val == s)
					return true;
			}
			return false;
		}

		public  void Validate()
		{

			if (!IsValidEnumerationValue(ToString()))
				throw new System.Exception("Value of RepresentativePointCodeType is invalid.");
		}
	}
}
