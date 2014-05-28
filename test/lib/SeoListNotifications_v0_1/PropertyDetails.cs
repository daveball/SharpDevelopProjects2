//
// PropertyDetails.cs
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

namespace SeoListNotifications_v0_1.core3
{
	public class PropertyDetails : Altova.Xml.Node
	{
		#region Forward constructors

		public PropertyDetails() : base() { SetCollectionParents(); }

		public PropertyDetails(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public PropertyDetails(XmlNode node) : base(node) { SetCollectionParents(); }
		public PropertyDetails(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public PropertyDetails(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "UKPostalAddress" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "UKPostalAddress", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
				new AddressAndPersonalDetails2.UKPostalAddressStructure(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "LACode" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "LACode", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "core:PropertyDetails");
		}


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
            PropertyDetails parent;
            public PropertyDetails Parent
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
			PropertyDetails parent;
			public UKPostalAddressEnumerator(PropertyDetails par) 
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

		#region LACode accessor methods
		public static int GetLACodeMinCount()
		{
			return 1;
		}

		public static int LACodeMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetLACodeMaxCount()
		{
			return 1;
		}

		public static int LACodeMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetLACodeCount()
		{
			return DomChildCount(NodeType.Element, "", "LACode");
		}

		public int LACodeCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "LACode");
			}
		}

		public bool HasLACode()
		{
			return HasDomChild(NodeType.Element, "", "LACode");
		}

		public ScottishLocalAuthorityCodeType NewLACode()
		{
			return new ScottishLocalAuthorityCodeType();
		}

		public ScottishLocalAuthorityCodeType GetLACodeAt(int index)
		{
			return new ScottishLocalAuthorityCodeType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "LACode", index)));
		}

		public XmlNode GetStartingLACodeCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "LACode" );
		}

		public XmlNode GetAdvancedLACodeCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "LACode", curNode );
		}

		public ScottishLocalAuthorityCodeType GetLACodeValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new ScottishLocalAuthorityCodeType( curNode.InnerText );
		}


		public ScottishLocalAuthorityCodeType GetLACode()
		{
			return GetLACodeAt(0);
		}

		public ScottishLocalAuthorityCodeType LACode
		{
			get
			{
				return GetLACodeAt(0);
			}
		}

		public void RemoveLACodeAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "LACode", index);
		}

		public void RemoveLACode()
		{
			RemoveLACodeAt(0);
		}

		public XmlNode AddLACode(ScottishLocalAuthorityCodeType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "LACode", newValue.ToString());
			return null;
		}

		public void InsertLACodeAt(ScottishLocalAuthorityCodeType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "LACode", index, newValue.ToString());
		}

		public void ReplaceLACodeAt(ScottishLocalAuthorityCodeType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "LACode", index, newValue.ToString());
		}
		#endregion // LACode accessor methods

		#region LACode collection
        public LACodeCollection	MyLACodes = new LACodeCollection( );

        public class LACodeCollection: IEnumerable
        {
            PropertyDetails parent;
            public PropertyDetails Parent
			{
				set
				{
					parent = value;
				}
			}
			public LACodeEnumerator GetEnumerator() 
			{
				return new LACodeEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class LACodeEnumerator: IEnumerator 
        {
			int nIndex;
			PropertyDetails parent;
			public LACodeEnumerator(PropertyDetails par) 
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
				return(nIndex < parent.LACodeCount );
			}
			public ScottishLocalAuthorityCodeType  Current 
			{
				get 
				{
					return(parent.GetLACodeAt(nIndex));
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

        #endregion // LACode collection

        private void SetCollectionParents()
        {
            MyUKPostalAddresss.Parent = this; 
            MyLACodes.Parent = this; 
	}
}
}
