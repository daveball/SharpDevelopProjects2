//
// UKAddressStructure.cs
//
// This file was generated by XMLSpy 2012sp1 Enterprise Edition.
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

namespace LA_CAS_Messages.AddressAndPersonalDetails2
{
	public class UKAddressStructure : Altova.Xml.Node
	{
		#region Forward constructors

		public UKAddressStructure() : base() { SetCollectionParents(); }

		public UKAddressStructure(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public UKAddressStructure(XmlNode node) : base(node) { SetCollectionParents(); }
		public UKAddressStructure(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public UKAddressStructure(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "BS7666Address" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "BS7666Address", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
				new bs76662.BSaddressStructure(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "A_5LineAddress" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "A_5LineAddress", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
				new UKPostalAddressStructure(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "UniquePropertyReferenceNumber" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "UniquePropertyReferenceNumber", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "SortCode" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "SortCode", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "WalkSort" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "WalkSort", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "AddressAndPersonalDetails:UKAddressStructure");
		}


		#region BS7666Address accessor methods
		public static int GetBS7666AddressMinCount()
		{
			return 1;
		}

		public static int BS7666AddressMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetBS7666AddressMaxCount()
		{
			return 1;
		}

		public static int BS7666AddressMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetBS7666AddressCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "BS7666Address");
		}

		public int BS7666AddressCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "BS7666Address");
			}
		}

		public bool HasBS7666Address()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "BS7666Address");
		}

		public bs76662.BSaddressStructure NewBS7666Address()
		{
			return new bs76662.BSaddressStructure(domNode.OwnerDocument.CreateElement("BS7666Address", "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails"));
		}

		public bs76662.BSaddressStructure GetBS7666AddressAt(int index)
		{
			return new bs76662.BSaddressStructure(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "BS7666Address", index));
		}

		public XmlNode GetStartingBS7666AddressCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "BS7666Address" );
		}

		public XmlNode GetAdvancedBS7666AddressCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "BS7666Address", curNode );
		}

		public bs76662.BSaddressStructure GetBS7666AddressValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new bs76662.BSaddressStructure( curNode );
		}


		public bs76662.BSaddressStructure GetBS7666Address()
		{
			return GetBS7666AddressAt(0);
		}

		public bs76662.BSaddressStructure BS7666Address
		{
			get
			{
				return GetBS7666AddressAt(0);
			}
		}

		public void RemoveBS7666AddressAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "BS7666Address", index);
		}

		public void RemoveBS7666Address()
		{
			RemoveBS7666AddressAt(0);
		}

		public XmlNode AddBS7666Address(bs76662.BSaddressStructure newValue)
		{
			return AppendDomElement("http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "BS7666Address", newValue);
		}

		public void InsertBS7666AddressAt(bs76662.BSaddressStructure newValue, int index)
		{
			InsertDomElementAt("http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "BS7666Address", index, newValue);
		}

		public void ReplaceBS7666AddressAt(bs76662.BSaddressStructure newValue, int index)
		{
			ReplaceDomElementAt("http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "BS7666Address", index, newValue);
		}
		#endregion // BS7666Address accessor methods

		#region BS7666Address collection
        public BS7666AddressCollection	MyBS7666Addresss = new BS7666AddressCollection( );

        public class BS7666AddressCollection: IEnumerable
        {
            UKAddressStructure parent;
            public UKAddressStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public BS7666AddressEnumerator GetEnumerator() 
			{
				return new BS7666AddressEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class BS7666AddressEnumerator: IEnumerator 
        {
			int nIndex;
			UKAddressStructure parent;
			public BS7666AddressEnumerator(UKAddressStructure par) 
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
				return(nIndex < parent.BS7666AddressCount );
			}
			public bs76662.BSaddressStructure  Current 
			{
				get 
				{
					return(parent.GetBS7666AddressAt(nIndex));
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

        #endregion // BS7666Address collection

		#region A_5LineAddress accessor methods
		public static int GetA_5LineAddressMinCount()
		{
			return 1;
		}

		public static int A_5LineAddressMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetA_5LineAddressMaxCount()
		{
			return 1;
		}

		public static int A_5LineAddressMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetA_5LineAddressCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "A_5LineAddress");
		}

		public int A_5LineAddressCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "A_5LineAddress");
			}
		}

		public bool HasA_5LineAddress()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "A_5LineAddress");
		}

		public UKPostalAddressStructure NewA_5LineAddress()
		{
			return new UKPostalAddressStructure(domNode.OwnerDocument.CreateElement("A_5LineAddress", "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails"));
		}

		public UKPostalAddressStructure GetA_5LineAddressAt(int index)
		{
			return new UKPostalAddressStructure(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "A_5LineAddress", index));
		}

		public XmlNode GetStartingA_5LineAddressCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "A_5LineAddress" );
		}

		public XmlNode GetAdvancedA_5LineAddressCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "A_5LineAddress", curNode );
		}

		public UKPostalAddressStructure GetA_5LineAddressValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new UKPostalAddressStructure( curNode );
		}


		public UKPostalAddressStructure GetA_5LineAddress()
		{
			return GetA_5LineAddressAt(0);
		}

		public UKPostalAddressStructure A_5LineAddress
		{
			get
			{
				return GetA_5LineAddressAt(0);
			}
		}

		public void RemoveA_5LineAddressAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "A_5LineAddress", index);
		}

		public void RemoveA_5LineAddress()
		{
			RemoveA_5LineAddressAt(0);
		}

		public XmlNode AddA_5LineAddress(UKPostalAddressStructure newValue)
		{
			return AppendDomElement("http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "A_5LineAddress", newValue);
		}

		public void InsertA_5LineAddressAt(UKPostalAddressStructure newValue, int index)
		{
			InsertDomElementAt("http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "A_5LineAddress", index, newValue);
		}

		public void ReplaceA_5LineAddressAt(UKPostalAddressStructure newValue, int index)
		{
			ReplaceDomElementAt("http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "A_5LineAddress", index, newValue);
		}
		#endregion // A_5LineAddress accessor methods

		#region A_5LineAddress collection
        public A_5LineAddressCollection	MyA_5LineAddresss = new A_5LineAddressCollection( );

        public class A_5LineAddressCollection: IEnumerable
        {
            UKAddressStructure parent;
            public UKAddressStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public A_5LineAddressEnumerator GetEnumerator() 
			{
				return new A_5LineAddressEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class A_5LineAddressEnumerator: IEnumerator 
        {
			int nIndex;
			UKAddressStructure parent;
			public A_5LineAddressEnumerator(UKAddressStructure par) 
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
				return(nIndex < parent.A_5LineAddressCount );
			}
			public UKPostalAddressStructure  Current 
			{
				get 
				{
					return(parent.GetA_5LineAddressAt(nIndex));
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

        #endregion // A_5LineAddress collection

		#region UniquePropertyReferenceNumber accessor methods
		public static int GetUniquePropertyReferenceNumberMinCount()
		{
			return 0;
		}

		public static int UniquePropertyReferenceNumberMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetUniquePropertyReferenceNumberMaxCount()
		{
			return 1;
		}

		public static int UniquePropertyReferenceNumberMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetUniquePropertyReferenceNumberCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "UniquePropertyReferenceNumber");
		}

		public int UniquePropertyReferenceNumberCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "UniquePropertyReferenceNumber");
			}
		}

		public bool HasUniquePropertyReferenceNumber()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "UniquePropertyReferenceNumber");
		}

		public bs76662.UPRNtype NewUniquePropertyReferenceNumber()
		{
			return new bs76662.UPRNtype();
		}

		public bs76662.UPRNtype GetUniquePropertyReferenceNumberAt(int index)
		{
			return new bs76662.UPRNtype(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "UniquePropertyReferenceNumber", index)));
		}

		public XmlNode GetStartingUniquePropertyReferenceNumberCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "UniquePropertyReferenceNumber" );
		}

		public XmlNode GetAdvancedUniquePropertyReferenceNumberCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "UniquePropertyReferenceNumber", curNode );
		}

		public bs76662.UPRNtype GetUniquePropertyReferenceNumberValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new bs76662.UPRNtype( curNode.InnerText );
		}


		public bs76662.UPRNtype GetUniquePropertyReferenceNumber()
		{
			return GetUniquePropertyReferenceNumberAt(0);
		}

		public bs76662.UPRNtype UniquePropertyReferenceNumber
		{
			get
			{
				return GetUniquePropertyReferenceNumberAt(0);
			}
		}

		public void RemoveUniquePropertyReferenceNumberAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "UniquePropertyReferenceNumber", index);
		}

		public void RemoveUniquePropertyReferenceNumber()
		{
			RemoveUniquePropertyReferenceNumberAt(0);
		}

		public XmlNode AddUniquePropertyReferenceNumber(bs76662.UPRNtype newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "UniquePropertyReferenceNumber", newValue.ToString());
			return null;
		}

		public void InsertUniquePropertyReferenceNumberAt(bs76662.UPRNtype newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "UniquePropertyReferenceNumber", index, newValue.ToString());
		}

		public void ReplaceUniquePropertyReferenceNumberAt(bs76662.UPRNtype newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "UniquePropertyReferenceNumber", index, newValue.ToString());
		}
		#endregion // UniquePropertyReferenceNumber accessor methods

		#region UniquePropertyReferenceNumber collection
        public UniquePropertyReferenceNumberCollection	MyUniquePropertyReferenceNumbers = new UniquePropertyReferenceNumberCollection( );

        public class UniquePropertyReferenceNumberCollection: IEnumerable
        {
            UKAddressStructure parent;
            public UKAddressStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public UniquePropertyReferenceNumberEnumerator GetEnumerator() 
			{
				return new UniquePropertyReferenceNumberEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class UniquePropertyReferenceNumberEnumerator: IEnumerator 
        {
			int nIndex;
			UKAddressStructure parent;
			public UniquePropertyReferenceNumberEnumerator(UKAddressStructure par) 
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
				return(nIndex < parent.UniquePropertyReferenceNumberCount );
			}
			public bs76662.UPRNtype  Current 
			{
				get 
				{
					return(parent.GetUniquePropertyReferenceNumberAt(nIndex));
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

        #endregion // UniquePropertyReferenceNumber collection

		#region SortCode accessor methods
		public static int GetSortCodeMinCount()
		{
			return 0;
		}

		public static int SortCodeMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetSortCodeMaxCount()
		{
			return 1;
		}

		public static int SortCodeMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetSortCodeCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "SortCode");
		}

		public int SortCodeCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "SortCode");
			}
		}

		public bool HasSortCode()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "SortCode");
		}

		public MailSortCodeType NewSortCode()
		{
			return new MailSortCodeType();
		}

		public MailSortCodeType GetSortCodeAt(int index)
		{
			return new MailSortCodeType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "SortCode", index)));
		}

		public XmlNode GetStartingSortCodeCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "SortCode" );
		}

		public XmlNode GetAdvancedSortCodeCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "SortCode", curNode );
		}

		public MailSortCodeType GetSortCodeValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new MailSortCodeType( curNode.InnerText );
		}


		public MailSortCodeType GetSortCode()
		{
			return GetSortCodeAt(0);
		}

		public MailSortCodeType SortCode
		{
			get
			{
				return GetSortCodeAt(0);
			}
		}

		public void RemoveSortCodeAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "SortCode", index);
		}

		public void RemoveSortCode()
		{
			RemoveSortCodeAt(0);
		}

		public XmlNode AddSortCode(MailSortCodeType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "SortCode", newValue.ToString());
			return null;
		}

		public void InsertSortCodeAt(MailSortCodeType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "SortCode", index, newValue.ToString());
		}

		public void ReplaceSortCodeAt(MailSortCodeType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "SortCode", index, newValue.ToString());
		}
		#endregion // SortCode accessor methods

		#region SortCode collection
        public SortCodeCollection	MySortCodes = new SortCodeCollection( );

        public class SortCodeCollection: IEnumerable
        {
            UKAddressStructure parent;
            public UKAddressStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public SortCodeEnumerator GetEnumerator() 
			{
				return new SortCodeEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class SortCodeEnumerator: IEnumerator 
        {
			int nIndex;
			UKAddressStructure parent;
			public SortCodeEnumerator(UKAddressStructure par) 
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
				return(nIndex < parent.SortCodeCount );
			}
			public MailSortCodeType  Current 
			{
				get 
				{
					return(parent.GetSortCodeAt(nIndex));
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

        #endregion // SortCode collection

		#region WalkSort accessor methods
		public static int GetWalkSortMinCount()
		{
			return 0;
		}

		public static int WalkSortMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetWalkSortMaxCount()
		{
			return 1;
		}

		public static int WalkSortMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetWalkSortCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "WalkSort");
		}

		public int WalkSortCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "WalkSort");
			}
		}

		public bool HasWalkSort()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "WalkSort");
		}

		public WalkSortCodeType NewWalkSort()
		{
			return new WalkSortCodeType();
		}

		public WalkSortCodeType GetWalkSortAt(int index)
		{
			return new WalkSortCodeType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "WalkSort", index)));
		}

		public XmlNode GetStartingWalkSortCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "WalkSort" );
		}

		public XmlNode GetAdvancedWalkSortCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "WalkSort", curNode );
		}

		public WalkSortCodeType GetWalkSortValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new WalkSortCodeType( curNode.InnerText );
		}


		public WalkSortCodeType GetWalkSort()
		{
			return GetWalkSortAt(0);
		}

		public WalkSortCodeType WalkSort
		{
			get
			{
				return GetWalkSortAt(0);
			}
		}

		public void RemoveWalkSortAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "WalkSort", index);
		}

		public void RemoveWalkSort()
		{
			RemoveWalkSortAt(0);
		}

		public XmlNode AddWalkSort(WalkSortCodeType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "WalkSort", newValue.ToString());
			return null;
		}

		public void InsertWalkSortAt(WalkSortCodeType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "WalkSort", index, newValue.ToString());
		}

		public void ReplaceWalkSortAt(WalkSortCodeType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "WalkSort", index, newValue.ToString());
		}
		#endregion // WalkSort accessor methods

		#region WalkSort collection
        public WalkSortCollection	MyWalkSorts = new WalkSortCollection( );

        public class WalkSortCollection: IEnumerable
        {
            UKAddressStructure parent;
            public UKAddressStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public WalkSortEnumerator GetEnumerator() 
			{
				return new WalkSortEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class WalkSortEnumerator: IEnumerator 
        {
			int nIndex;
			UKAddressStructure parent;
			public WalkSortEnumerator(UKAddressStructure par) 
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
				return(nIndex < parent.WalkSortCount );
			}
			public WalkSortCodeType  Current 
			{
				get 
				{
					return(parent.GetWalkSortAt(nIndex));
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

        #endregion // WalkSort collection

        private void SetCollectionParents()
        {
            MyBS7666Addresss.Parent = this; 
            MyA_5LineAddresss.Parent = this; 
            MyUniquePropertyReferenceNumbers.Parent = this; 
            MySortCodes.Parent = this; 
            MyWalkSorts.Parent = this; 
	}
}
}