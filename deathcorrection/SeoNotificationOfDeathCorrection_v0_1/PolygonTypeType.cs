//
// PolygonTypeType.cs
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

namespace SeoNotificationOfDeathCorrection_v0_1.bs76662
{

	public class PolygonTypeType : SchemaString
	{
		public static  string[] sEnumValues = {
			"H",
		};

		public  enum EnumValues
		{
			eH = 0, /* H */
			EnumValueCount
		};

		public PolygonTypeType() : base()
		{
		}

		public PolygonTypeType(string newValue) : base(newValue)
		{
			Validate();
		}

		public PolygonTypeType(SchemaString newValue) : base(newValue)
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
				throw new System.Exception("Value of PolygonType is invalid.");
		}
	}
}