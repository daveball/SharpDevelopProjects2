//
// LocalityType.cs
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

	public class LocalityType : SchemaString
	{

		public LocalityType() : base()
		{
		}

		public LocalityType(string newValue) : base(newValue)
		{
			Validate();
		}

		public LocalityType(SchemaString newValue) : base(newValue)
		{
			Validate();
		}

		public  void Validate()
		{
			if (Value.Length > GetMaxLength())
				throw new System.Exception("Value of LocalityType is too long.");
			if (Value.Length < GetMinLength())
				throw new System.Exception("Value of LocalityType is too short.");
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
