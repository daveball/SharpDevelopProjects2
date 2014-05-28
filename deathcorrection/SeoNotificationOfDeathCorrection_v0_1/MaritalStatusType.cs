//
// MaritalStatusType.cs
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

namespace SeoNotificationOfDeathCorrection_v0_1.core2
{

	public class MaritalStatusType : SchemaString
	{
		public static  string[] sEnumValues = {
			"s",
			"m",
			"d",
			"w",
			"n",
			"p",
		};

		public  enum EnumValues
		{
			es = 0, /* s */
			em = 1, /* m */
			ed = 2, /* d */
			ew = 3, /* w */
			en = 4, /* n */
			ep = 5, /* p */
			EnumValueCount
		};

		public MaritalStatusType() : base()
		{
		}

		public MaritalStatusType(string newValue) : base(newValue)
		{
			Validate();
		}

		public MaritalStatusType(SchemaString newValue) : base(newValue)
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
				throw new System.Exception("Value of MaritalStatusType is invalid.");
		}
	}
}
