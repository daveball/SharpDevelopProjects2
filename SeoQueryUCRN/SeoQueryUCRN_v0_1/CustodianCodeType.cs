//
// CustodianCodeType.cs
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

namespace SeoQueryUCRN_v0_1.bs76662
{

	public class CustodianCodeType : SchemaLong
	{

		public CustodianCodeType() : base()
		{
		}

		public CustodianCodeType(string newValue) : base(newValue)
		{
			Validate();
		}

		public CustodianCodeType(SchemaLong newValue) : base(newValue)
		{
			Validate();
		}

		public  void Validate()
		{

			if (CompareTo(GetMaxInclusive()) > 0)
				throw new System.Exception("Value of CustodianCodeType is out of range.");

			if (CompareTo(GetMinInclusive()) < 0)
				throw new System.Exception("Value of CustodianCodeType is out of range.");
		}
		public  SchemaLong GetMaxInclusive()
		{
			return new SchemaLong("9999");
		}
		public  SchemaLong GetMinInclusive()
		{
			return new SchemaLong("1");
		}
	}
}