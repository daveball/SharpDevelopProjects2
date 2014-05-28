//
// StreetReferenceTypeType.cs
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

namespace SeoReceiveNotification_v0_1.bs76662
{

	public class StreetReferenceTypeType : SchemaLong
	{
		public static  string[] sEnumValues = {
			"1",
			"2",
			"3",
			"4",
		};

		public  enum EnumValues
		{
			e1 = 0, /* 1 */
			e2 = 1, /* 2 */
			e3 = 2, /* 3 */
			e4 = 3, /* 4 */
			EnumValueCount
		};

		public StreetReferenceTypeType() : base()
		{
		}

		public StreetReferenceTypeType(string newValue) : base(newValue)
		{
			Validate();
		}

		public StreetReferenceTypeType(SchemaLong newValue) : base(newValue)
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
				throw new System.Exception("Value of StreetReferenceTypeType is invalid.");
		}
	}
}
