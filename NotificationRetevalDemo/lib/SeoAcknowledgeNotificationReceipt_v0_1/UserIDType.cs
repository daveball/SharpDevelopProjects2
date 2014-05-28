//
// UserIDType.cs
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

	public class UserIDType : SchemaString
	{

		public UserIDType() : base()
		{
		}

		public UserIDType(string newValue) : base(newValue)
		{
			Validate();
		}

		public UserIDType(SchemaString newValue) : base(newValue)
		{
			Validate();
		}

		public  void Validate()
		{
			if (Value.Length > GetMaxLength())
				throw new System.Exception("Value of UserIDType is too long.");
			if (Value.Length < GetMinLength())
				throw new System.Exception("Value of UserIDType is too short.");
		}
		public  int GetMaxLength()
		{
			return 150;
		}
		public  int GetMinLength()
		{
			return 1;
		}
	}
}