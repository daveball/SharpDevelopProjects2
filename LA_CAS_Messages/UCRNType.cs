//
// UCRNType.cs
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

	public class UCRNType : SchemaString
	{
		public static  string[] sPatternValues = {
			"[0-9]{19}",
		};


		public UCRNType() : base()
		{
		}

		public UCRNType(string newValue) : base(newValue)
		{
			Validate();
		}

		public UCRNType(SchemaString newValue) : base(newValue)
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
				throw new System.Exception("Value of UCRNType is too long.");
			if (Value.Length < GetMinLength())
				throw new System.Exception("Value of UCRNType is too short.");
		}
		public  int GetMaxLength()
		{
			return 19;
		}
		public  int GetMinLength()
		{
			return 19;
		}
	}
}