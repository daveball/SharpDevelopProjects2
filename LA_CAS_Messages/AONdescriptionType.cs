//
// AONdescriptionType.cs
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

namespace LA_CAS_Messages.bs76662
{

	public class AONdescriptionType : SchemaString
	{
		public static  string[] sPatternValues = {
			"[a-zA-Z0-9:;<=>\\?@%&\'\\(\\)\\*\\+,\\-\\. ]{0,90}",
		};


		public AONdescriptionType() : base()
		{
		}

		public AONdescriptionType(string newValue) : base(newValue)
		{
			Validate();
		}

		public AONdescriptionType(SchemaString newValue) : base(newValue)
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
				throw new System.Exception("Value of AONdescriptionType is too long.");
			if (Value.Length < GetMinLength())
				throw new System.Exception("Value of AONdescriptionType is too short.");
		}
		public  int GetMaxLength()
		{
			return 90;
		}
		public  int GetMinLength()
		{
			return 1;
		}
	}
}
