//
// GROSQueryType.cs
//
// This file was generated by XMLSpy 2012r2 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using Altova.Types;

namespace SeoNotificationOfDeathCorrection_v0_1.core3
{

	public class GROSQueryType : SchemaString
	{
		public static  string[] sEnumValues = {
			"UCRN",
			"DUP",
			"NOD",
		};

		public  enum EnumValues
		{
			eUCRN = 0, /* UCRN */
			eDUP = 1, /* DUP */
			eNOD = 2, /* NOD */
			EnumValueCount
		};

		public GROSQueryType() : base()
		{
		}

		public GROSQueryType(string newValue) : base(newValue)
		{
			Validate();
		}

		public GROSQueryType(SchemaString newValue) : base(newValue)
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
				throw new System.Exception("Value of GROSQueryType is invalid.");
		}
	}
}
