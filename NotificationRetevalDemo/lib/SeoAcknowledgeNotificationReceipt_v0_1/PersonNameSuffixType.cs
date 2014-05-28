//
// PersonNameSuffixType.cs
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

namespace SeoAcknowledgeNotificationReceipt_v0_1.PersonDescriptives2
{

	public class PersonNameSuffixType : core2.RestrictedStringType
	{

		public PersonNameSuffixType() : base()
		{
		}

		public PersonNameSuffixType(string newValue) : base(newValue)
		{
			Validate();
		}

		public PersonNameSuffixType(SchemaString newValue) : base(newValue)
		{
			Validate();
		}

		public new void Validate()
		{
			if (Value.Length > GetMaxLength())
				throw new System.Exception("Value of PersonNameSuffixType is too long.");
			if (Value.Length < GetMinLength())
				throw new System.Exception("Value of PersonNameSuffixType is too short.");
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
