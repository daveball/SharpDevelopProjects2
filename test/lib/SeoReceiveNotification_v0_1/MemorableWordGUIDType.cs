//
// MemorableWordGUIDType.cs
//
// This file was generated by XMLSpy 2008r2sp2 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using Altova.Types;

namespace SeoReceiveNotification_v0_1.core3
{

	public class MemorableWordGUIDType : SchemaString
	{
		public static  string[] sPatternValues = {
			"[0-9A-F]{32}",
		};


		public MemorableWordGUIDType() : base()
		{
		}

		public MemorableWordGUIDType(string newValue) : base(newValue)
		{
			Validate();
		}

		public MemorableWordGUIDType(SchemaString newValue) : base(newValue)
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
