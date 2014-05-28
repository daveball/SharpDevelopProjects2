//
// AddressLineType.cs
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

namespace SeoReceiveNotification_v0_1.AddressAndPersonalDetails2
{

	public class AddressLineType : core2.RestrictedStringType
	{

		public AddressLineType() : base()
		{
		}

		public AddressLineType(string newValue) : base(newValue)
		{
			Validate();
		}

		public AddressLineType(SchemaString newValue) : base(newValue)
		{
			Validate();
		}

		public new void Validate()
		{
			if (Value.Length < GetMinLength())
				throw new System.Exception("Value of AddressLineType is too short.");
			if (Value.Length > GetMaxLength())
				throw new System.Exception("Value of AddressLineType is too long.");
		}
		public  int GetMinLength()
		{
			return 1;
		}
		public  int GetMaxLength()
		{
			return 35;
		}
	}
}
