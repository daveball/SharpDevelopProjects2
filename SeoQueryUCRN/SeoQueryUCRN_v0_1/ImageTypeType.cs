//
// ImageTypeType.cs
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

namespace SeoQueryUCRN_v0_1
{

	public class ImageTypeType : SchemaString
	{
		public static  string[] sEnumValues = {
			"JPG",
			"GIF",
			"PNG",
		};

		public  enum EnumValues
		{
			eJPG = 0, /* JPG */
			eGIF = 1, /* GIF */
			ePNG = 2, /* PNG */
			EnumValueCount
		};

		public ImageTypeType() : base()
		{
		}

		public ImageTypeType(string newValue) : base(newValue)
		{
			Validate();
		}

		public ImageTypeType(SchemaString newValue) : base(newValue)
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
				throw new System.Exception("Value of ImageType is invalid.");
		}
	}
}