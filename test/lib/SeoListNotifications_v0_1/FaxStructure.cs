//
// FaxStructure.cs
//
// This file was generated by XMLSpy 2008r2sp2 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using System;
using System.Collections;
using System.Xml;
using Altova.Types;

namespace SeoListNotifications_v0_1.AddressAndPersonalDetails2
{
	public class FaxStructure : Altova.Xml.Node
	{
		#region Forward constructors

		public FaxStructure() : base() { SetCollectionParents(); }

		public FaxStructure(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public FaxStructure(XmlNode node) : base(node) { SetCollectionParents(); }
		public FaxStructure(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public FaxStructure(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Attribute, "", "FaxUse" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Attribute, "", "FaxUse", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Attribute, "", "FaxMobile" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Attribute, "", "FaxMobile", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Attribute, "", "FaxPreferred" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Attribute, "", "FaxPreferred", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxNationalNumber" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxNationalNumber", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxExtensionNumber" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxExtensionNumber", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxCountryCode" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxCountryCode", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "AddressAndPersonalDetails:FaxStructure");
		}


		#region FaxUse accessor methods
		public static int GetFaxUseMinCount()
		{
			return 0;
		}

		public static int FaxUseMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetFaxUseMaxCount()
		{
			return 1;
		}

		public static int FaxUseMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetFaxUseCount()
		{
			return DomChildCount(NodeType.Attribute, "", "FaxUse");
		}

		public int FaxUseCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "FaxUse");
			}
		}

		public bool HasFaxUse()
		{
			return HasDomChild(NodeType.Attribute, "", "FaxUse");
		}

		public core2.WorkHomeType NewFaxUse()
		{
			return new core2.WorkHomeType();
		}

		public core2.WorkHomeType GetFaxUseAt(int index)
		{
			return new core2.WorkHomeType(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "FaxUse", index)));
		}

		public XmlNode GetStartingFaxUseCursor()
		{
			return GetDomFirstChild( NodeType.Attribute, "", "FaxUse" );
		}

		public XmlNode GetAdvancedFaxUseCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Attribute, "", "FaxUse", curNode );
		}

		public core2.WorkHomeType GetFaxUseValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core2.WorkHomeType( curNode.Value );
		}


		public core2.WorkHomeType GetFaxUse()
		{
			return GetFaxUseAt(0);
		}

		public core2.WorkHomeType FaxUse
		{
			get
			{
				return GetFaxUseAt(0);
			}
		}

		public void RemoveFaxUseAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "FaxUse", index);
		}

		public void RemoveFaxUse()
		{
			RemoveFaxUseAt(0);
		}

		public XmlNode AddFaxUse(core2.WorkHomeType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Attribute, "", "FaxUse", newValue.ToString());
			return null;
		}

		public void InsertFaxUseAt(core2.WorkHomeType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Attribute, "", "FaxUse", index, newValue.ToString());
		}

		public void ReplaceFaxUseAt(core2.WorkHomeType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "FaxUse", index, newValue.ToString());
		}
		#endregion // FaxUse accessor methods

		#region FaxUse collection
        public FaxUseCollection	MyFaxUses = new FaxUseCollection( );

        public class FaxUseCollection: IEnumerable
        {
            FaxStructure parent;
            public FaxStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public FaxUseEnumerator GetEnumerator() 
			{
				return new FaxUseEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class FaxUseEnumerator: IEnumerator 
        {
			int nIndex;
			FaxStructure parent;
			public FaxUseEnumerator(FaxStructure par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.FaxUseCount );
			}
			public core2.WorkHomeType  Current 
			{
				get 
				{
					return(parent.GetFaxUseAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // FaxUse collection

		#region FaxMobile accessor methods
		public static int GetFaxMobileMinCount()
		{
			return 0;
		}

		public static int FaxMobileMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetFaxMobileMaxCount()
		{
			return 1;
		}

		public static int FaxMobileMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetFaxMobileCount()
		{
			return DomChildCount(NodeType.Attribute, "", "FaxMobile");
		}

		public int FaxMobileCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "FaxMobile");
			}
		}

		public bool HasFaxMobile()
		{
			return HasDomChild(NodeType.Attribute, "", "FaxMobile");
		}

		public core2.YesNoType NewFaxMobile()
		{
			return new core2.YesNoType();
		}

		public core2.YesNoType GetFaxMobileAt(int index)
		{
			return new core2.YesNoType(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "FaxMobile", index)));
		}

		public XmlNode GetStartingFaxMobileCursor()
		{
			return GetDomFirstChild( NodeType.Attribute, "", "FaxMobile" );
		}

		public XmlNode GetAdvancedFaxMobileCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Attribute, "", "FaxMobile", curNode );
		}

		public core2.YesNoType GetFaxMobileValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core2.YesNoType( curNode.Value );
		}


		public core2.YesNoType GetFaxMobile()
		{
			return GetFaxMobileAt(0);
		}

		public core2.YesNoType FaxMobile
		{
			get
			{
				return GetFaxMobileAt(0);
			}
		}

		public void RemoveFaxMobileAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "FaxMobile", index);
		}

		public void RemoveFaxMobile()
		{
			RemoveFaxMobileAt(0);
		}

		public XmlNode AddFaxMobile(core2.YesNoType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Attribute, "", "FaxMobile", newValue.ToString());
			return null;
		}

		public void InsertFaxMobileAt(core2.YesNoType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Attribute, "", "FaxMobile", index, newValue.ToString());
		}

		public void ReplaceFaxMobileAt(core2.YesNoType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "FaxMobile", index, newValue.ToString());
		}
		#endregion // FaxMobile accessor methods

		#region FaxMobile collection
        public FaxMobileCollection	MyFaxMobiles = new FaxMobileCollection( );

        public class FaxMobileCollection: IEnumerable
        {
            FaxStructure parent;
            public FaxStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public FaxMobileEnumerator GetEnumerator() 
			{
				return new FaxMobileEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class FaxMobileEnumerator: IEnumerator 
        {
			int nIndex;
			FaxStructure parent;
			public FaxMobileEnumerator(FaxStructure par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.FaxMobileCount );
			}
			public core2.YesNoType  Current 
			{
				get 
				{
					return(parent.GetFaxMobileAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // FaxMobile collection

		#region FaxPreferred accessor methods
		public static int GetFaxPreferredMinCount()
		{
			return 0;
		}

		public static int FaxPreferredMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetFaxPreferredMaxCount()
		{
			return 1;
		}

		public static int FaxPreferredMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetFaxPreferredCount()
		{
			return DomChildCount(NodeType.Attribute, "", "FaxPreferred");
		}

		public int FaxPreferredCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "FaxPreferred");
			}
		}

		public bool HasFaxPreferred()
		{
			return HasDomChild(NodeType.Attribute, "", "FaxPreferred");
		}

		public core2.YesNoType NewFaxPreferred()
		{
			return new core2.YesNoType();
		}

		public core2.YesNoType GetFaxPreferredAt(int index)
		{
			return new core2.YesNoType(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "FaxPreferred", index)));
		}

		public XmlNode GetStartingFaxPreferredCursor()
		{
			return GetDomFirstChild( NodeType.Attribute, "", "FaxPreferred" );
		}

		public XmlNode GetAdvancedFaxPreferredCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Attribute, "", "FaxPreferred", curNode );
		}

		public core2.YesNoType GetFaxPreferredValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core2.YesNoType( curNode.Value );
		}


		public core2.YesNoType GetFaxPreferred()
		{
			return GetFaxPreferredAt(0);
		}

		public core2.YesNoType FaxPreferred
		{
			get
			{
				return GetFaxPreferredAt(0);
			}
		}

		public void RemoveFaxPreferredAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "FaxPreferred", index);
		}

		public void RemoveFaxPreferred()
		{
			RemoveFaxPreferredAt(0);
		}

		public XmlNode AddFaxPreferred(core2.YesNoType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Attribute, "", "FaxPreferred", newValue.ToString());
			return null;
		}

		public void InsertFaxPreferredAt(core2.YesNoType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Attribute, "", "FaxPreferred", index, newValue.ToString());
		}

		public void ReplaceFaxPreferredAt(core2.YesNoType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "FaxPreferred", index, newValue.ToString());
		}
		#endregion // FaxPreferred accessor methods

		#region FaxPreferred collection
        public FaxPreferredCollection	MyFaxPreferreds = new FaxPreferredCollection( );

        public class FaxPreferredCollection: IEnumerable
        {
            FaxStructure parent;
            public FaxStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public FaxPreferredEnumerator GetEnumerator() 
			{
				return new FaxPreferredEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class FaxPreferredEnumerator: IEnumerator 
        {
			int nIndex;
			FaxStructure parent;
			public FaxPreferredEnumerator(FaxStructure par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.FaxPreferredCount );
			}
			public core2.YesNoType  Current 
			{
				get 
				{
					return(parent.GetFaxPreferredAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // FaxPreferred collection

		#region FaxNationalNumber accessor methods
		public static int GetFaxNationalNumberMinCount()
		{
			return 1;
		}

		public static int FaxNationalNumberMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetFaxNationalNumberMaxCount()
		{
			return 1;
		}

		public static int FaxNationalNumberMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetFaxNationalNumberCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxNationalNumber");
		}

		public int FaxNationalNumberCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxNationalNumber");
			}
		}

		public bool HasFaxNationalNumber()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxNationalNumber");
		}

		public core2.TelephoneNumberType NewFaxNationalNumber()
		{
			return new core2.TelephoneNumberType();
		}

		public core2.TelephoneNumberType GetFaxNationalNumberAt(int index)
		{
			return new core2.TelephoneNumberType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxNationalNumber", index)));
		}

		public XmlNode GetStartingFaxNationalNumberCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxNationalNumber" );
		}

		public XmlNode GetAdvancedFaxNationalNumberCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxNationalNumber", curNode );
		}

		public core2.TelephoneNumberType GetFaxNationalNumberValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core2.TelephoneNumberType( curNode.InnerText );
		}


		public core2.TelephoneNumberType GetFaxNationalNumber()
		{
			return GetFaxNationalNumberAt(0);
		}

		public core2.TelephoneNumberType FaxNationalNumber
		{
			get
			{
				return GetFaxNationalNumberAt(0);
			}
		}

		public void RemoveFaxNationalNumberAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxNationalNumber", index);
		}

		public void RemoveFaxNationalNumber()
		{
			RemoveFaxNationalNumberAt(0);
		}

		public XmlNode AddFaxNationalNumber(core2.TelephoneNumberType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxNationalNumber", newValue.ToString());
			return null;
		}

		public void InsertFaxNationalNumberAt(core2.TelephoneNumberType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxNationalNumber", index, newValue.ToString());
		}

		public void ReplaceFaxNationalNumberAt(core2.TelephoneNumberType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxNationalNumber", index, newValue.ToString());
		}
		#endregion // FaxNationalNumber accessor methods

		#region FaxNationalNumber collection
        public FaxNationalNumberCollection	MyFaxNationalNumbers = new FaxNationalNumberCollection( );

        public class FaxNationalNumberCollection: IEnumerable
        {
            FaxStructure parent;
            public FaxStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public FaxNationalNumberEnumerator GetEnumerator() 
			{
				return new FaxNationalNumberEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class FaxNationalNumberEnumerator: IEnumerator 
        {
			int nIndex;
			FaxStructure parent;
			public FaxNationalNumberEnumerator(FaxStructure par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.FaxNationalNumberCount );
			}
			public core2.TelephoneNumberType  Current 
			{
				get 
				{
					return(parent.GetFaxNationalNumberAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // FaxNationalNumber collection

		#region FaxExtensionNumber accessor methods
		public static int GetFaxExtensionNumberMinCount()
		{
			return 0;
		}

		public static int FaxExtensionNumberMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetFaxExtensionNumberMaxCount()
		{
			return 1;
		}

		public static int FaxExtensionNumberMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetFaxExtensionNumberCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxExtensionNumber");
		}

		public int FaxExtensionNumberCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxExtensionNumber");
			}
		}

		public bool HasFaxExtensionNumber()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxExtensionNumber");
		}

		public core2.TelephoneExtensionType NewFaxExtensionNumber()
		{
			return new core2.TelephoneExtensionType();
		}

		public core2.TelephoneExtensionType GetFaxExtensionNumberAt(int index)
		{
			return new core2.TelephoneExtensionType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxExtensionNumber", index)));
		}

		public XmlNode GetStartingFaxExtensionNumberCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxExtensionNumber" );
		}

		public XmlNode GetAdvancedFaxExtensionNumberCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxExtensionNumber", curNode );
		}

		public core2.TelephoneExtensionType GetFaxExtensionNumberValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core2.TelephoneExtensionType( curNode.InnerText );
		}


		public core2.TelephoneExtensionType GetFaxExtensionNumber()
		{
			return GetFaxExtensionNumberAt(0);
		}

		public core2.TelephoneExtensionType FaxExtensionNumber
		{
			get
			{
				return GetFaxExtensionNumberAt(0);
			}
		}

		public void RemoveFaxExtensionNumberAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxExtensionNumber", index);
		}

		public void RemoveFaxExtensionNumber()
		{
			RemoveFaxExtensionNumberAt(0);
		}

		public XmlNode AddFaxExtensionNumber(core2.TelephoneExtensionType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxExtensionNumber", newValue.ToString());
			return null;
		}

		public void InsertFaxExtensionNumberAt(core2.TelephoneExtensionType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxExtensionNumber", index, newValue.ToString());
		}

		public void ReplaceFaxExtensionNumberAt(core2.TelephoneExtensionType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxExtensionNumber", index, newValue.ToString());
		}
		#endregion // FaxExtensionNumber accessor methods

		#region FaxExtensionNumber collection
        public FaxExtensionNumberCollection	MyFaxExtensionNumbers = new FaxExtensionNumberCollection( );

        public class FaxExtensionNumberCollection: IEnumerable
        {
            FaxStructure parent;
            public FaxStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public FaxExtensionNumberEnumerator GetEnumerator() 
			{
				return new FaxExtensionNumberEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class FaxExtensionNumberEnumerator: IEnumerator 
        {
			int nIndex;
			FaxStructure parent;
			public FaxExtensionNumberEnumerator(FaxStructure par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.FaxExtensionNumberCount );
			}
			public core2.TelephoneExtensionType  Current 
			{
				get 
				{
					return(parent.GetFaxExtensionNumberAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // FaxExtensionNumber collection

		#region FaxCountryCode accessor methods
		public static int GetFaxCountryCodeMinCount()
		{
			return 0;
		}

		public static int FaxCountryCodeMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetFaxCountryCodeMaxCount()
		{
			return 1;
		}

		public static int FaxCountryCodeMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetFaxCountryCodeCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxCountryCode");
		}

		public int FaxCountryCodeCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxCountryCode");
			}
		}

		public bool HasFaxCountryCode()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxCountryCode");
		}

		public core2.TelCountryCodeType NewFaxCountryCode()
		{
			return new core2.TelCountryCodeType();
		}

		public core2.TelCountryCodeType GetFaxCountryCodeAt(int index)
		{
			return new core2.TelCountryCodeType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxCountryCode", index)));
		}

		public XmlNode GetStartingFaxCountryCodeCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxCountryCode" );
		}

		public XmlNode GetAdvancedFaxCountryCodeCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxCountryCode", curNode );
		}

		public core2.TelCountryCodeType GetFaxCountryCodeValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core2.TelCountryCodeType( curNode.InnerText );
		}


		public core2.TelCountryCodeType GetFaxCountryCode()
		{
			return GetFaxCountryCodeAt(0);
		}

		public core2.TelCountryCodeType FaxCountryCode
		{
			get
			{
				return GetFaxCountryCodeAt(0);
			}
		}

		public void RemoveFaxCountryCodeAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxCountryCode", index);
		}

		public void RemoveFaxCountryCode()
		{
			RemoveFaxCountryCodeAt(0);
		}

		public XmlNode AddFaxCountryCode(core2.TelCountryCodeType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxCountryCode", newValue.ToString());
			return null;
		}

		public void InsertFaxCountryCodeAt(core2.TelCountryCodeType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxCountryCode", index, newValue.ToString());
		}

		public void ReplaceFaxCountryCodeAt(core2.TelCountryCodeType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "FaxCountryCode", index, newValue.ToString());
		}
		#endregion // FaxCountryCode accessor methods

		#region FaxCountryCode collection
        public FaxCountryCodeCollection	MyFaxCountryCodes = new FaxCountryCodeCollection( );

        public class FaxCountryCodeCollection: IEnumerable
        {
            FaxStructure parent;
            public FaxStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public FaxCountryCodeEnumerator GetEnumerator() 
			{
				return new FaxCountryCodeEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class FaxCountryCodeEnumerator: IEnumerator 
        {
			int nIndex;
			FaxStructure parent;
			public FaxCountryCodeEnumerator(FaxStructure par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.FaxCountryCodeCount );
			}
			public core2.TelCountryCodeType  Current 
			{
				get 
				{
					return(parent.GetFaxCountryCodeAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // FaxCountryCode collection

        private void SetCollectionParents()
        {
            MyFaxUses.Parent = this; 
            MyFaxMobiles.Parent = this; 
            MyFaxPreferreds.Parent = this; 
            MyFaxNationalNumbers.Parent = this; 
            MyFaxExtensionNumbers.Parent = this; 
            MyFaxCountryCodes.Parent = this; 
	}
}
}
