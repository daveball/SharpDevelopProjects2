//
// CASAuthenticationRequestType.cs
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

namespace LA_CAS_Messages
{
	public class CASAuthenticationRequestType : Altova.Xml.Node
	{
		#region Forward constructors

		public CASAuthenticationRequestType() : base() { SetCollectionParents(); }

		public CASAuthenticationRequestType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public CASAuthenticationRequestType(XmlNode node) : base(node) { SetCollectionParents(); }
		public CASAuthenticationRequestType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public CASAuthenticationRequestType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "BoSGUID" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "BoSGUID", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "CASAuthenticationRequest");
		}


		#region BoSGUID accessor methods
		public static int GetBoSGUIDMinCount()
		{
			return 1;
		}

		public static int BoSGUIDMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetBoSGUIDMaxCount()
		{
			return 1;
		}

		public static int BoSGUIDMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetBoSGUIDCount()
		{
			return DomChildCount(NodeType.Element, "", "BoSGUID");
		}

		public int BoSGUIDCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "BoSGUID");
			}
		}

		public bool HasBoSGUID()
		{
			return HasDomChild(NodeType.Element, "", "BoSGUID");
		}

		public core3.BoSGUIDType NewBoSGUID()
		{
			return new core3.BoSGUIDType();
		}

		public core3.BoSGUIDType GetBoSGUIDAt(int index)
		{
			return new core3.BoSGUIDType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "BoSGUID", index)));
		}

		public XmlNode GetStartingBoSGUIDCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "BoSGUID" );
		}

		public XmlNode GetAdvancedBoSGUIDCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "BoSGUID", curNode );
		}

		public core3.BoSGUIDType GetBoSGUIDValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core3.BoSGUIDType( curNode.InnerText );
		}


		public core3.BoSGUIDType GetBoSGUID()
		{
			return GetBoSGUIDAt(0);
		}

		public core3.BoSGUIDType BoSGUID
		{
			get
			{
				return GetBoSGUIDAt(0);
			}
		}

		public void RemoveBoSGUIDAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "BoSGUID", index);
		}

		public void RemoveBoSGUID()
		{
			RemoveBoSGUIDAt(0);
		}

		public XmlNode AddBoSGUID(core3.BoSGUIDType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "BoSGUID", newValue.ToString());
			return null;
		}

		public void InsertBoSGUIDAt(core3.BoSGUIDType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "BoSGUID", index, newValue.ToString());
		}

		public void ReplaceBoSGUIDAt(core3.BoSGUIDType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "BoSGUID", index, newValue.ToString());
		}
		#endregion // BoSGUID accessor methods

		#region BoSGUID collection
        public BoSGUIDCollection	MyBoSGUIDs = new BoSGUIDCollection( );

        public class BoSGUIDCollection: IEnumerable
        {
            CASAuthenticationRequestType parent;
            public CASAuthenticationRequestType Parent
			{
				set
				{
					parent = value;
				}
			}
			public BoSGUIDEnumerator GetEnumerator() 
			{
				return new BoSGUIDEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class BoSGUIDEnumerator: IEnumerator 
        {
			int nIndex;
			CASAuthenticationRequestType parent;
			public BoSGUIDEnumerator(CASAuthenticationRequestType par) 
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
				return(nIndex < parent.BoSGUIDCount );
			}
			public core3.BoSGUIDType  Current 
			{
				get 
				{
					return(parent.GetBoSGUIDAt(nIndex));
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

        #endregion // BoSGUID collection

        private void SetCollectionParents()
        {
            MyBoSGUIDs.Parent = this; 
	}
}
}
