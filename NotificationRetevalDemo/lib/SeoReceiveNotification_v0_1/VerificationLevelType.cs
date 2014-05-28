//
// VerificationLevelType.cs
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

namespace SeoReceiveNotification_v0_1.PersonDescriptives2
{

	public class VerificationLevelType : core2.RestrictedStringType
	{
		public static  string[] sEnumValues = {
			"Level 0",
			"Level 1",
			"Level 2",
			"Level 3",
		};

		public  enum EnumValues
		{
			eLevel_0 = 0, /* Level 0 */
			eLevel_1 = 1, /* Level 1 */
			eLevel_2 = 2, /* Level 2 */
			eLevel_3 = 3, /* Level 3 */
			EnumValueCount
		};

		public VerificationLevelType() : base()
		{
		}

		public VerificationLevelType(string newValue) : base(newValue)
		{
			Validate();
		}

		public VerificationLevelType(SchemaString newValue) : base(newValue)
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

		public new void Validate()
		{

			if (!IsValidEnumerationValue(ToString()))
				throw new System.Exception("Value of VerificationLevelType is invalid.");
		}
	}
}