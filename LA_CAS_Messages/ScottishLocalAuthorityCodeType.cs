//
// ScottishLocalAuthorityCodeType.cs
//
// This file was generated by XMLSpy 2011r3sp1 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using Altova.Types;

namespace LA_CAS_Messages.core3
{

	public class ScottishLocalAuthorityCodeType : SchemaString
	{
		public static  string[] sEnumValues = {
			"01",
			"02",
			"03",
			"04",
			"05",
			"06",
			"07",
			"08",
			"09",
			"10",
			"11",
			"12",
			"13",
			"14",
			"15",
			"16",
			"17",
			"18",
			"19",
			"20",
			"21",
			"22",
			"23",
			"24",
			"25",
			"26",
			"27",
			"28",
			"29",
			"30",
			"31",
			"32",
		};

		public  enum EnumValues
		{
			e01 = 0, /* 01 */
			e02 = 1, /* 02 */
			e03 = 2, /* 03 */
			e04 = 3, /* 04 */
			e05 = 4, /* 05 */
			e06 = 5, /* 06 */
			e07 = 6, /* 07 */
			e08 = 7, /* 08 */
			e09 = 8, /* 09 */
			e10 = 9, /* 10 */
			e11 = 10, /* 11 */
			e12 = 11, /* 12 */
			e13 = 12, /* 13 */
			e14 = 13, /* 14 */
			e15 = 14, /* 15 */
			e16 = 15, /* 16 */
			e17 = 16, /* 17 */
			e18 = 17, /* 18 */
			e19 = 18, /* 19 */
			e20 = 19, /* 20 */
			e21 = 20, /* 21 */
			e22 = 21, /* 22 */
			e23 = 22, /* 23 */
			e24 = 23, /* 24 */
			e25 = 24, /* 25 */
			e26 = 25, /* 26 */
			e27 = 26, /* 27 */
			e28 = 27, /* 28 */
			e29 = 28, /* 29 */
			e30 = 29, /* 30 */
			e31 = 30, /* 31 */
			e32 = 31, /* 32 */
			EnumValueCount
		};

		public ScottishLocalAuthorityCodeType() : base()
		{
		}

		public ScottishLocalAuthorityCodeType(string newValue) : base(newValue)
		{
			Validate();
		}

		public ScottishLocalAuthorityCodeType(SchemaString newValue) : base(newValue)
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
				throw new System.Exception("Value of ScottishLocalAuthorityCodeType is invalid.");
		}
	}
}
