//
// RefPointGridCoordinateType.cs
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

	public class RefPointGridCoordinateType : SchemaString
	{
		public static  string[] sPatternValues = {
			"[0-9]{14}",
		};


		public RefPointGridCoordinateType() : base()
		{
		}

		public RefPointGridCoordinateType(string newValue) : base(newValue)
		{
			Validate();
		}

		public RefPointGridCoordinateType(SchemaString newValue) : base(newValue)
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
