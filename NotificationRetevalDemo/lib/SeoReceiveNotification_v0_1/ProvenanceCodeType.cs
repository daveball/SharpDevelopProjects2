//
// ProvenanceCodeType.cs
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

	public class ProvenanceCodeType : SchemaString
	{
		public static  string[] sEnumValues = {
			"T",
			"L",
			"F",
			"R",
			"P",
			"O",
			"U",
		};

		public  enum EnumValues
		{
			eT = 0, /* T */
			eL = 1, /* L */
			eF = 2, /* F */
			eR = 3, /* R */
			eP = 4, /* P */
			eO = 5, /* O */
			eU = 6, /* U */
			EnumValueCount
		};

		public ProvenanceCodeType() : base()
		{
		}

		public ProvenanceCodeType(string newValue) : base(newValue)
		{
			Validate();
		}

		public ProvenanceCodeType(SchemaString newValue) : base(newValue)
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
				throw new System.Exception("Value of ProvenanceCodeType is invalid.");
		}
	}
}
