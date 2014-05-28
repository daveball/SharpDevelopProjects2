//
// PersonFullNameType.cs
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

namespace SeoNotificationOfDeathCorrection_v0_1.PersonDescriptives2
{

	public class PersonFullNameType : core2.RestrictedStringType
	{

		public PersonFullNameType() : base()
		{
		}

		public PersonFullNameType(string newValue) : base(newValue)
		{
			Validate();
		}

		public PersonFullNameType(SchemaString newValue) : base(newValue)
		{
			Validate();
		}

		public new void Validate()
		{
			if (Value.Length > GetMaxLength())
				throw new System.Exception("Value of PersonFullNameType is too long.");
			if (Value.Length < GetMinLength())
				throw new System.Exception("Value of PersonFullNameType is too short.");
		}
		public  int GetMaxLength()
		{
			return 70;
		}
		public  int GetMinLength()
		{
			return 1;
		}
	}
}