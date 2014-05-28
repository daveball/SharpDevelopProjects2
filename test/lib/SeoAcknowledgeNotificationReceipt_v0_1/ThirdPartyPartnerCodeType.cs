//
// ThirdPartyPartnerCodeType.cs
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

namespace SeoAcknowledgeNotificationReceipt_v0_1.core3
{

	public class ThirdPartyPartnerCodeType : SchemaString
	{
		public static  string[] sEnumValues = {
			"GROS",
			"LA",
		};

		public  enum EnumValues
		{
			eGROS = 0, /* GROS */
			eLA = 1, /* LA */
			EnumValueCount
		};

		public ThirdPartyPartnerCodeType() : base()
		{
		}

		public ThirdPartyPartnerCodeType(string newValue) : base(newValue)
		{
			Validate();
		}

		public ThirdPartyPartnerCodeType(SchemaString newValue) : base(newValue)
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
				throw new System.Exception("Value of ThirdPartyPartnerCodeType is invalid.");
		}
	}
}