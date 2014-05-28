//
// InvestigationPropertyDetailsType.cs
//
// This file was generated by XMLSpy 2012r2 Enterprise Edition.
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

namespace SeoQueryUCRN_v0_1.core3
{
	public class InvestigationPropertyDetailsType : Altova.Xml.Node
	{
		#region Forward constructors

		public InvestigationPropertyDetailsType() : base() { SetCollectionParents(); }

		public InvestigationPropertyDetailsType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public InvestigationPropertyDetailsType(XmlNode node) : base(node) { SetCollectionParents(); }
		public InvestigationPropertyDetailsType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public InvestigationPropertyDetailsType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "UPRN" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "UPRN", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "CASAddressGUID" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "CASAddressGUID", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "CAGOwner" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "CAGOwner", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "UKPostalAddress" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "UKPostalAddress", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
				new AddressAndPersonalDetails2.UKPostalAddressStructure(DOMNode).AdjustPrefix();
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "core:InvestigationPropertyDetailsType");
		}


		#region UPRN accessor methods
		public static int GetUPRNMinCount()
		{
			return 0;
		}

		public static int UPRNMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetUPRNMaxCount()
		{
			return 1;
		}

		public static int UPRNMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetUPRNCount()
		{
			return DomChildCount(NodeType.Element, "", "UPRN");
		}

		public int UPRNCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "UPRN");
			}
		}

		public bool HasUPRN()
		{
			return HasDomChild(NodeType.Element, "", "UPRN");
		}

		public UPRNType2 NewUPRN()
		{
			return new UPRNType2();
		}

		public UPRNType2 GetUPRNAt(int index)
		{
			return new UPRNType2(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "UPRN", index)));
		}

		public XmlNode GetStartingUPRNCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "UPRN" );
		}

		public XmlNode GetAdvancedUPRNCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "UPRN", curNode );
		}

		public UPRNType2 GetUPRNValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new UPRNType2( curNode.InnerText );
		}


		public UPRNType2 GetUPRN()
		{
			return GetUPRNAt(0);
		}

		public UPRNType2 UPRN
		{
			get
			{
				return GetUPRNAt(0);
			}
		}

		public void RemoveUPRNAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "UPRN", index);
		}

		public void RemoveUPRN()
		{
			RemoveUPRNAt(0);
		}

		public XmlNode AddUPRN(UPRNType2 newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "UPRN", newValue.ToString());
			return null;
		}

		public void InsertUPRNAt(UPRNType2 newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "UPRN", index, newValue.ToString());
		}

		public void ReplaceUPRNAt(UPRNType2 newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "UPRN", index, newValue.ToString());
		}
		#endregion // UPRN accessor methods

		#region UPRN collection
        public UPRNCollection	MyUPRNs = new UPRNCollection( );

        public class UPRNCollection: IEnumerable
        {
            InvestigationPropertyDetailsType parent;
            public InvestigationPropertyDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public UPRNEnumerator GetEnumerator() 
			{
				return new UPRNEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class UPRNEnumerator: IEnumerator 
        {
			int nIndex;
			InvestigationPropertyDetailsType parent;
			public UPRNEnumerator(InvestigationPropertyDetailsType par) 
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
				return(nIndex < parent.UPRNCount );
			}
			public UPRNType2  Current 
			{
				get 
				{
					return(parent.GetUPRNAt(nIndex));
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

        #endregion // UPRN collection

		#region CASAddressGUID accessor methods
		public static int GetCASAddressGUIDMinCount()
		{
			return 0;
		}

		public static int CASAddressGUIDMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetCASAddressGUIDMaxCount()
		{
			return 1;
		}

		public static int CASAddressGUIDMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetCASAddressGUIDCount()
		{
			return DomChildCount(NodeType.Element, "", "CASAddressGUID");
		}

		public int CASAddressGUIDCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "CASAddressGUID");
			}
		}

		public bool HasCASAddressGUID()
		{
			return HasDomChild(NodeType.Element, "", "CASAddressGUID");
		}

		public AddressGUIDType NewCASAddressGUID()
		{
			return new AddressGUIDType();
		}

		public AddressGUIDType GetCASAddressGUIDAt(int index)
		{
			return new AddressGUIDType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "CASAddressGUID", index)));
		}

		public XmlNode GetStartingCASAddressGUIDCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "CASAddressGUID" );
		}

		public XmlNode GetAdvancedCASAddressGUIDCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "CASAddressGUID", curNode );
		}

		public AddressGUIDType GetCASAddressGUIDValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new AddressGUIDType( curNode.InnerText );
		}


		public AddressGUIDType GetCASAddressGUID()
		{
			return GetCASAddressGUIDAt(0);
		}

		public AddressGUIDType CASAddressGUID
		{
			get
			{
				return GetCASAddressGUIDAt(0);
			}
		}

		public void RemoveCASAddressGUIDAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "CASAddressGUID", index);
		}

		public void RemoveCASAddressGUID()
		{
			RemoveCASAddressGUIDAt(0);
		}

		public XmlNode AddCASAddressGUID(AddressGUIDType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "CASAddressGUID", newValue.ToString());
			return null;
		}

		public void InsertCASAddressGUIDAt(AddressGUIDType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "CASAddressGUID", index, newValue.ToString());
		}

		public void ReplaceCASAddressGUIDAt(AddressGUIDType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "CASAddressGUID", index, newValue.ToString());
		}
		#endregion // CASAddressGUID accessor methods

		#region CASAddressGUID collection
        public CASAddressGUIDCollection	MyCASAddressGUIDs = new CASAddressGUIDCollection( );

        public class CASAddressGUIDCollection: IEnumerable
        {
            InvestigationPropertyDetailsType parent;
            public InvestigationPropertyDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public CASAddressGUIDEnumerator GetEnumerator() 
			{
				return new CASAddressGUIDEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class CASAddressGUIDEnumerator: IEnumerator 
        {
			int nIndex;
			InvestigationPropertyDetailsType parent;
			public CASAddressGUIDEnumerator(InvestigationPropertyDetailsType par) 
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
				return(nIndex < parent.CASAddressGUIDCount );
			}
			public AddressGUIDType  Current 
			{
				get 
				{
					return(parent.GetCASAddressGUIDAt(nIndex));
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

        #endregion // CASAddressGUID collection

		#region CAGOwner accessor methods
		public static int GetCAGOwnerMinCount()
		{
			return 1;
		}

		public static int CAGOwnerMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetCAGOwnerMaxCount()
		{
			return 1;
		}

		public static int CAGOwnerMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetCAGOwnerCount()
		{
			return DomChildCount(NodeType.Element, "", "CAGOwner");
		}

		public int CAGOwnerCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "CAGOwner");
			}
		}

		public bool HasCAGOwner()
		{
			return HasDomChild(NodeType.Element, "", "CAGOwner");
		}

		public ScottishLocalAuthorityCodeType NewCAGOwner()
		{
			return new ScottishLocalAuthorityCodeType();
		}

		public ScottishLocalAuthorityCodeType GetCAGOwnerAt(int index)
		{
			return new ScottishLocalAuthorityCodeType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "CAGOwner", index)));
		}

		public XmlNode GetStartingCAGOwnerCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "CAGOwner" );
		}

		public XmlNode GetAdvancedCAGOwnerCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "CAGOwner", curNode );
		}

		public ScottishLocalAuthorityCodeType GetCAGOwnerValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new ScottishLocalAuthorityCodeType( curNode.InnerText );
		}


		public ScottishLocalAuthorityCodeType GetCAGOwner()
		{
			return GetCAGOwnerAt(0);
		}

		public ScottishLocalAuthorityCodeType CAGOwner
		{
			get
			{
				return GetCAGOwnerAt(0);
			}
		}

		public void RemoveCAGOwnerAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "CAGOwner", index);
		}

		public void RemoveCAGOwner()
		{
			RemoveCAGOwnerAt(0);
		}

		public XmlNode AddCAGOwner(ScottishLocalAuthorityCodeType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "CAGOwner", newValue.ToString());
			return null;
		}

		public void InsertCAGOwnerAt(ScottishLocalAuthorityCodeType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "CAGOwner", index, newValue.ToString());
		}

		public void ReplaceCAGOwnerAt(ScottishLocalAuthorityCodeType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "CAGOwner", index, newValue.ToString());
		}
		#endregion // CAGOwner accessor methods

		#region CAGOwner collection
        public CAGOwnerCollection	MyCAGOwners = new CAGOwnerCollection( );

        public class CAGOwnerCollection: IEnumerable
        {
            InvestigationPropertyDetailsType parent;
            public InvestigationPropertyDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public CAGOwnerEnumerator GetEnumerator() 
			{
				return new CAGOwnerEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class CAGOwnerEnumerator: IEnumerator 
        {
			int nIndex;
			InvestigationPropertyDetailsType parent;
			public CAGOwnerEnumerator(InvestigationPropertyDetailsType par) 
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
				return(nIndex < parent.CAGOwnerCount );
			}
			public ScottishLocalAuthorityCodeType  Current 
			{
				get 
				{
					return(parent.GetCAGOwnerAt(nIndex));
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

        #endregion // CAGOwner collection

		#region UKPostalAddress accessor methods
		public static int GetUKPostalAddressMinCount()
		{
			return 1;
		}

		public static int UKPostalAddressMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetUKPostalAddressMaxCount()
		{
			return 1;
		}

		public static int UKPostalAddressMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetUKPostalAddressCount()
		{
			return DomChildCount(NodeType.Element, "", "UKPostalAddress");
		}

		public int UKPostalAddressCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "UKPostalAddress");
			}
		}

		public bool HasUKPostalAddress()
		{
			return HasDomChild(NodeType.Element, "", "UKPostalAddress");
		}

		public AddressAndPersonalDetails2.UKPostalAddressStructure NewUKPostalAddress()
		{
			return new AddressAndPersonalDetails2.UKPostalAddressStructure(domNode.OwnerDocument.CreateElement("UKPostalAddress", ""));
		}

		public AddressAndPersonalDetails2.UKPostalAddressStructure GetUKPostalAddressAt(int index)
		{
			return new AddressAndPersonalDetails2.UKPostalAddressStructure(GetDomChildAt(NodeType.Element, "", "UKPostalAddress", index));
		}

		public XmlNode GetStartingUKPostalAddressCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "UKPostalAddress" );
		}

		public XmlNode GetAdvancedUKPostalAddressCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "UKPostalAddress", curNode );
		}

		public AddressAndPersonalDetails2.UKPostalAddressStructure GetUKPostalAddressValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new AddressAndPersonalDetails2.UKPostalAddressStructure( curNode );
		}


		public AddressAndPersonalDetails2.UKPostalAddressStructure GetUKPostalAddress()
		{
			return GetUKPostalAddressAt(0);
		}

		public AddressAndPersonalDetails2.UKPostalAddressStructure UKPostalAddress
		{
			get
			{
				return GetUKPostalAddressAt(0);
			}
		}

		public void RemoveUKPostalAddressAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "UKPostalAddress", index);
		}

		public void RemoveUKPostalAddress()
		{
			RemoveUKPostalAddressAt(0);
		}

		public XmlNode AddUKPostalAddress(AddressAndPersonalDetails2.UKPostalAddressStructure newValue)
		{
			return AppendDomElement("", "UKPostalAddress", newValue);
		}

		public void InsertUKPostalAddressAt(AddressAndPersonalDetails2.UKPostalAddressStructure newValue, int index)
		{
			InsertDomElementAt("", "UKPostalAddress", index, newValue);
		}

		public void ReplaceUKPostalAddressAt(AddressAndPersonalDetails2.UKPostalAddressStructure newValue, int index)
		{
			ReplaceDomElementAt("", "UKPostalAddress", index, newValue);
		}
		#endregion // UKPostalAddress accessor methods

		#region UKPostalAddress collection
        public UKPostalAddressCollection	MyUKPostalAddresss = new UKPostalAddressCollection( );

        public class UKPostalAddressCollection: IEnumerable
        {
            InvestigationPropertyDetailsType parent;
            public InvestigationPropertyDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public UKPostalAddressEnumerator GetEnumerator() 
			{
				return new UKPostalAddressEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class UKPostalAddressEnumerator: IEnumerator 
        {
			int nIndex;
			InvestigationPropertyDetailsType parent;
			public UKPostalAddressEnumerator(InvestigationPropertyDetailsType par) 
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
				return(nIndex < parent.UKPostalAddressCount );
			}
			public AddressAndPersonalDetails2.UKPostalAddressStructure  Current 
			{
				get 
				{
					return(parent.GetUKPostalAddressAt(nIndex));
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

        #endregion // UKPostalAddress collection

        private void SetCollectionParents()
        {
            MyUPRNs.Parent = this; 
            MyCASAddressGUIDs.Parent = this; 
            MyCAGOwners.Parent = this; 
            MyUKPostalAddresss.Parent = this; 
	}
}
}
