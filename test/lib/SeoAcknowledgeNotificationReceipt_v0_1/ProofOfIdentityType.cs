//
// ProofOfIdentityType.cs
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

	public class ProofOfIdentityType : SchemaString
	{
		public static  string[] sEnumValues = {
			"Passport",
			"Driving License (Card)",
			"Driving License (Old)",
			"Benefit",
			"NEC",
			"CRM",
		};

		public  enum EnumValues
		{
			ePassport = 0, /* Passport */
			eDriving_License__Card_ = 1, /* Driving License (Card) */
			eDriving_License__Old_ = 2, /* Driving License (Old) */
			eBenefit = 3, /* Benefit */
			eNEC = 4, /* NEC */
			eCRM = 5, /* CRM */
			EnumValueCount
		};

		public ProofOfIdentityType() : base()
		{
		}

		public ProofOfIdentityType(string newValue) : base(newValue)
		{
			Validate();
		}

		public ProofOfIdentityType(SchemaString newValue) : base(newValue)
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
				throw new System.Exception("Value of ProofOfIdentityType is invalid.");
		}
	}
}
