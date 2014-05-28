//
// SuffixType.cs
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

namespace SeoAcknowledgeNotificationReceipt_v0_1.bs76662
{

	public class SuffixType : SchemaString
	{
		public static  string[] sPatternValues = {
			"[A-Z]",
		};


		public SuffixType() : base()
		{
		}

		public SuffixType(string newValue) : base(newValue)
		{
			Validate();
		}

		public SuffixType(SchemaString newValue) : base(newValue)
		{
			Validate();
		}


		public static  int GetPatternCount()
		{
			return sPatternValues.Length;
		}

		public static  string GetPatternValue(int index)
		{
			return sPatternValues[index];
		}
		public  void Validate()
		{
			if (Value.Length > GetMaxLength())
				throw new System.Exception("Value of Suffix is too long.");
			if (Value.Length < GetMinLength())
				throw new System.Exception("Value of Suffix is too short.");
		}
		public  int GetMaxLength()
		{
			return 1;
		}
		public  int GetMinLength()
		{
			return 1;
		}
	}
}
