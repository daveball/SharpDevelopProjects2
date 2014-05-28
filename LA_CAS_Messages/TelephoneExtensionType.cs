//
// TelephoneExtensionType.cs
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

namespace LA_CAS_Messages.core2
{

	public class TelephoneExtensionType : SchemaString
	{
		public static  string[] sPatternValues = {
			"[0-9]{1,6}",
		};


		public TelephoneExtensionType() : base()
		{
		}

		public TelephoneExtensionType(string newValue) : base(newValue)
		{
			Validate();
		}

		public TelephoneExtensionType(SchemaString newValue) : base(newValue)
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
		}
	}
}
