//
// BoSGUIDType.cs
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

namespace SeoQueryUCRN_v0_1.core3
{

	public class BoSGUIDType : SchemaString
	{
		public static  string[] sPatternValues = {
			"[0-9A-F]{32}",
		};


		public BoSGUIDType() : base()
		{
		}

		public BoSGUIDType(string newValue) : base(newValue)
		{
			Validate();
		}

		public BoSGUIDType(SchemaString newValue) : base(newValue)
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
