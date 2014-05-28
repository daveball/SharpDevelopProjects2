//
// InternationalPostCodeType.cs
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

namespace LA_CAS_Messages.AddressAndPersonalDetails2
{

	public class InternationalPostCodeType : core2.RestrictedStringType
	{

		public InternationalPostCodeType() : base()
		{
		}

		public InternationalPostCodeType(string newValue) : base(newValue)
		{
			Validate();
		}

		public InternationalPostCodeType(SchemaString newValue) : base(newValue)
		{
			Validate();
		}

		public new void Validate()
		{
			if (Value.Length > GetMaxLength())
				throw new System.Exception("Value of InternationalPostCodeType is too long.");
			if (Value.Length < GetMinLength())
				throw new System.Exception("Value of InternationalPostCodeType is too short.");
		}
		public  int GetMaxLength()
		{
			return 35;
		}
		public  int GetMinLength()
		{
			return 1;
		}
	}
}