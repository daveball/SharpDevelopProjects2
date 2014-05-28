//
// QueryNoteType.cs
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

	public class QueryNoteType : SchemaString
	{

		public QueryNoteType() : base()
		{
		}

		public QueryNoteType(string newValue) : base(newValue)
		{
			Validate();
		}

		public QueryNoteType(SchemaString newValue) : base(newValue)
		{
			Validate();
		}

		public  void Validate()
		{
			if (Value.Length > GetMaxLength())
				throw new System.Exception("Value of QueryNoteType is too long.");
		}
		public  int GetMaxLength()
		{
			return 2048;
		}
	}
}
