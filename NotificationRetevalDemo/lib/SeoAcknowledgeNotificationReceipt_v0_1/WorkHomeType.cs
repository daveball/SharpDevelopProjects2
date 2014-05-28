//
// WorkHomeType.cs
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

namespace SeoAcknowledgeNotificationReceipt_v0_1.core2
{

	public class WorkHomeType : SchemaString
	{
		public static  string[] sEnumValues = {
			"work",
			"home",
		};

		public  enum EnumValues
		{
			ework = 0, /* work */
			ehome = 1, /* home */
			EnumValueCount
		};

		public WorkHomeType() : base()
		{
		}

		public WorkHomeType(string newValue) : base(newValue)
		{
			Validate();
		}

		public WorkHomeType(SchemaString newValue) : base(newValue)
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

			if (!IsValidEnumerationValue(ToString()))
				throw new System.Exception("Value of WorkHomeType is invalid.");
		}
	}
}
