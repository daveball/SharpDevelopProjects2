//
// ResetPasswordRequestType.cs
//
// This file was generated by XMLSpy 2011r3sp1 Enterprise Edition.
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
	public class ResetPasswordRequestType : Altova.Xml.Node
	{
		#region Forward constructors

		public ResetPasswordRequestType() : base() { SetCollectionParents(); }

		public ResetPasswordRequestType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public ResetPasswordRequestType(XmlNode node) : base(node) { SetCollectionParents(); }
		public ResetPasswordRequestType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public ResetPasswordRequestType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "UCRN" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "UCRN", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "CASCitizenGUID" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "CASCitizenGUID", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "ResetPasswordRequest");
		}


		#region UCRN accessor methods
		public static int GetUCRNMinCount()
		{
			return 1;
		}

		public static int UCRNMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetUCRNMaxCount()
		{
			return 1;
		}

		public static int UCRNMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetUCRNCount()
		{
			return DomChildCount(NodeType.Element, "", "UCRN");
		}

		public int UCRNCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "UCRN");
			}
		}

		public bool HasUCRN()
		{
			return HasDomChild(NodeType.Element, "", "UCRN");
		}

		public core3.UCRNType NewUCRN()
		{
			return new core3.UCRNType();
		}

		public core3.UCRNType GetUCRNAt(int index)
		{
			return new core3.UCRNType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "UCRN", index)));
		}

		public XmlNode GetStartingUCRNCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "UCRN" );
		}

		public XmlNode GetAdvancedUCRNCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "UCRN", curNode );
		}

		public core3.UCRNType GetUCRNValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core3.UCRNType( curNode.InnerText );
		}


		public core3.UCRNType GetUCRN()
		{
			return GetUCRNAt(0);
		}

		public core3.UCRNType UCRN
		{
			get
			{
				return GetUCRNAt(0);
			}
		}

		public void RemoveUCRNAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "UCRN", index);
		}

		public void RemoveUCRN()
		{
			RemoveUCRNAt(0);
		}

		public XmlNode AddUCRN(core3.UCRNType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "UCRN", newValue.ToString());
			return null;
		}

		public void InsertUCRNAt(core3.UCRNType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "UCRN", index, newValue.ToString());
		}

		public void ReplaceUCRNAt(core3.UCRNType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "UCRN", index, newValue.ToString());
		}
		#endregion // UCRN accessor methods

		#region UCRN collection
        public UCRNCollection	MyUCRNs = new UCRNCollection( );

        public class UCRNCollection: IEnumerable
        {
            ResetPasswordRequestType parent;
            public ResetPasswordRequestType Parent
			{
				set
				{
					parent = value;
				}
			}
			public UCRNEnumerator GetEnumerator() 
			{
				return new UCRNEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class UCRNEnumerator: IEnumerator 
        {
			int nIndex;
			ResetPasswordRequestType parent;
			public UCRNEnumerator(ResetPasswordRequestType par) 
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
				return(nIndex < parent.UCRNCount );
			}
			public core3.UCRNType  Current 
			{
				get 
				{
					return(parent.GetUCRNAt(nIndex));
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

        #endregion // UCRN collection

		#region CASCitizenGUID accessor methods
		public static int GetCASCitizenGUIDMinCount()
		{
			return 1;
		}

		public static int CASCitizenGUIDMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetCASCitizenGUIDMaxCount()
		{
			return 1;
		}

		public static int CASCitizenGUIDMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetCASCitizenGUIDCount()
		{
			return DomChildCount(NodeType.Element, "", "CASCitizenGUID");
		}

		public int CASCitizenGUIDCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "CASCitizenGUID");
			}
		}

		public bool HasCASCitizenGUID()
		{
			return HasDomChild(NodeType.Element, "", "CASCitizenGUID");
		}

		public core3.CitizenGUIDType NewCASCitizenGUID()
		{
			return new core3.CitizenGUIDType();
		}

		public core3.CitizenGUIDType GetCASCitizenGUIDAt(int index)
		{
			return new core3.CitizenGUIDType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "CASCitizenGUID", index)));
		}

		public XmlNode GetStartingCASCitizenGUIDCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "CASCitizenGUID" );
		}

		public XmlNode GetAdvancedCASCitizenGUIDCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "CASCitizenGUID", curNode );
		}

		public core3.CitizenGUIDType GetCASCitizenGUIDValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core3.CitizenGUIDType( curNode.InnerText );
		}


		public core3.CitizenGUIDType GetCASCitizenGUID()
		{
			return GetCASCitizenGUIDAt(0);
		}

		public core3.CitizenGUIDType CASCitizenGUID
		{
			get
			{
				return GetCASCitizenGUIDAt(0);
			}
		}

		public void RemoveCASCitizenGUIDAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "CASCitizenGUID", index);
		}

		public void RemoveCASCitizenGUID()
		{
			RemoveCASCitizenGUIDAt(0);
		}

		public XmlNode AddCASCitizenGUID(core3.CitizenGUIDType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "CASCitizenGUID", newValue.ToString());
			return null;
		}

		public void InsertCASCitizenGUIDAt(core3.CitizenGUIDType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "CASCitizenGUID", index, newValue.ToString());
		}

		public void ReplaceCASCitizenGUIDAt(core3.CitizenGUIDType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "CASCitizenGUID", index, newValue.ToString());
		}
		#endregion // CASCitizenGUID accessor methods

		#region CASCitizenGUID collection
        public CASCitizenGUIDCollection	MyCASCitizenGUIDs = new CASCitizenGUIDCollection( );

        public class CASCitizenGUIDCollection: IEnumerable
        {
            ResetPasswordRequestType parent;
            public ResetPasswordRequestType Parent
			{
				set
				{
					parent = value;
				}
			}
			public CASCitizenGUIDEnumerator GetEnumerator() 
			{
				return new CASCitizenGUIDEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class CASCitizenGUIDEnumerator: IEnumerator 
        {
			int nIndex;
			ResetPasswordRequestType parent;
			public CASCitizenGUIDEnumerator(ResetPasswordRequestType par) 
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
				return(nIndex < parent.CASCitizenGUIDCount );
			}
			public core3.CitizenGUIDType  Current 
			{
				get 
				{
					return(parent.GetCASCitizenGUIDAt(nIndex));
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

        #endregion // CASCitizenGUID collection

        private void SetCollectionParents()
        {
            MyUCRNs.Parent = this; 
            MyCASCitizenGUIDs.Parent = this; 
	}
}
}
