//
// DocumentaryProof.cs
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

namespace SeoNotificationOfDeathCorrection_v0_1.core3
{

	public class DocumentaryProof : SchemaString
	{

		public DocumentaryProof() : base()
		{
		}

		public DocumentaryProof(string newValue) : base(newValue)
		{
			Validate();
		}

		public DocumentaryProof(SchemaString newValue) : base(newValue)
		{
			Validate();
		}

		public  void Validate()
		{
			if (Value.Length < GetMinLength())
				throw new System.Exception("Value of DocumentaryProof is too short.");
		}
		public  int GetMinLength()
		{
			return 1;
		}
	}
}
