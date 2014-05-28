//
// LogicalStatusType.cs
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

namespace SeoReceiveNotification_v0_1.bs76662
{

	public class LogicalStatusType : SchemaLong
	{
		public static  string[] sEnumValues = {
			"1",
			"2",
			"3",
			"5",
			"6",
			"8",
			"9",
		};

		public  enum EnumValues
		{
			e1 = 0, /* 1 */
			e2 = 1, /* 2 */
			e3 = 2, /* 3 */
			e5 = 3, /* 5 */
			e6 = 4, /* 6 */
			e8 = 5, /* 8 */
			e9 = 6, /* 9 */
			EnumValueCount
		};

		public LogicalStatusType() : base()
		{
		}

		public LogicalStatusType(string newValue) : base(newValue)
		{
			Validate();
		}

		public LogicalStatusType(SchemaLong newValue) : base(newValue)
		{
			Validate();
		}

		public static  int GetEnumerationCount()
		{
			return sEnumValues.Length;
		}

		public static  string GetEnumerationValue(int index)
		{
			return sEnumValues[index];
		}

		public static  bool IsValidEnumerationValue(string val)
		{
			foreach (string s in sEnumValues)
			{
				if (val == s)
					return true;
			}
			return false;
		}

		public  void Validate()
		{

			if (CompareTo(GetMaxInclusive()) > 0)
				throw new System.Exception("Value of LogicalStatusType is out of range.");

			if (CompareTo(GetMinInclusive()) < 0)
				throw new System.Exception("Value of LogicalStatusType is out of range.");

			if (!IsValidEnumerationValue(ToString()))
				throw new System.Exception("Value of LogicalStatusType is invalid.");
		}
		public  SchemaLong GetMaxInclusive()
		{
			return new SchemaLong("9");
		}
		public  SchemaLong GetMinInclusive()
		{
			return new SchemaLong("1");
		}
	}
}