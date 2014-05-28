//
// ProofOfResidenceType.cs
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

	public class ProofOfResidenceType : SchemaString
	{
		public static  string[] sEnumValues = {
			"Gas Bill",
			"Electricity Bill",
			"Council Tax Bill",
			"Driving License (Card)",
			"Driving License (Old)",
			"Bank",
			"Mortgage Provider",
			"Rental Agreement",
			"Benefit",
			"NEC",
			"CRM",
		};

		public  enum EnumValues
		{
			eGas_Bill = 0, /* Gas Bill */
			eElectricity_Bill = 1, /* Electricity Bill */
			eCouncil_Tax_Bill = 2, /* Council Tax Bill */
			eDriving_License__Card_ = 3, /* Driving License (Card) */
			eDriving_License__Old_ = 4, /* Driving License (Old) */
			eBank = 5, /* Bank */
			eMortgage_Provider = 6, /* Mortgage Provider */
			eRental_Agreement = 7, /* Rental Agreement */
			eBenefit = 8, /* Benefit */
			eNEC = 9, /* NEC */
			eCRM = 10, /* CRM */
			EnumValueCount
		};

		public ProofOfResidenceType() : base()
		{
		}

		public ProofOfResidenceType(string newValue) : base(newValue)
		{
			Validate();
		}

		public ProofOfResidenceType(SchemaString newValue) : base(newValue)
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
				throw new System.Exception("Value of ProofOfResidenceType is invalid.");
		}
	}
}
