//
// CitizenGUIDType.cs
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

	public class CitizenGUIDType : SchemaString
	{
		public static  string[] sPatternValues = {
			"UCR([0-9]){7}",
		};


		public CitizenGUIDType() : base()
		{
		}

		public CitizenGUIDType(string newValue) : base(newValue)
		{
			Validate();
		}

		public CitizenGUIDType(SchemaString newValue) : base(newValue)
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
