//
// ListOutstandingVerificationsResponseType.cs
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
	public class ListOutstandingVerificationsResponseType : Altova.Xml.Node
	{
		#region Forward constructors

		public ListOutstandingVerificationsResponseType() : base() { SetCollectionParents(); }

		public ListOutstandingVerificationsResponseType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public ListOutstandingVerificationsResponseType(XmlNode node) : base(node) { SetCollectionParents(); }
		public ListOutstandingVerificationsResponseType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public ListOutstandingVerificationsResponseType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "ChangeRequest" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "ChangeRequest", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
				new core3.ChangeAddressType(DOMNode).AdjustPrefix();
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "ListOutstandingVerificationsResponse");
		}


		#region ChangeRequest accessor methods
		public static int GetChangeRequestMinCount()
		{
			return 0;
		}

		public static int ChangeRequestMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetChangeRequestMaxCount()
		{
			return Int32.MaxValue;
		}

		public static int ChangeRequestMaxCount
		{
			get
			{
				return Int32.MaxValue;
			}
		}

		public int GetChangeRequestCount()
		{
			return DomChildCount(NodeType.Element, "", "ChangeRequest");
		}

		public int ChangeRequestCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "ChangeRequest");
			}
		}

		public bool HasChangeRequest()
		{
			return HasDomChild(NodeType.Element, "", "ChangeRequest");
		}

		public core3.ChangeAddressType NewChangeRequest()
		{
			return new core3.ChangeAddressType(domNode.OwnerDocument.CreateElement("ChangeRequest", ""));
		}

		public core3.ChangeAddressType GetChangeRequestAt(int index)
		{
			return new core3.ChangeAddressType(GetDomChildAt(NodeType.Element, "", "ChangeRequest", index));
		}

		public XmlNode GetStartingChangeRequestCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "ChangeRequest" );
		}

		public XmlNode GetAdvancedChangeRequestCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "ChangeRequest", curNode );
		}

		public core3.ChangeAddressType GetChangeRequestValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core3.ChangeAddressType( curNode );
		}


		public core3.ChangeAddressType GetChangeRequest()
		{
			return GetChangeRequestAt(0);
		}

		public core3.ChangeAddressType ChangeRequest
		{
			get
			{
				return GetChangeRequestAt(0);
			}
		}

		public void RemoveChangeRequestAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "ChangeRequest", index);
		}

		public void RemoveChangeRequest()
		{
			while (HasChangeRequest())
				RemoveChangeRequestAt(0);
		}

		public XmlNode AddChangeRequest(core3.ChangeAddressType newValue)
		{
			return AppendDomElement("", "ChangeRequest", newValue);
		}

		public void InsertChangeRequestAt(core3.ChangeAddressType newValue, int index)
		{
			InsertDomElementAt("", "ChangeRequest", index, newValue);
		}

		public void ReplaceChangeRequestAt(core3.ChangeAddressType newValue, int index)
		{
			ReplaceDomElementAt("", "ChangeRequest", index, newValue);
		}
		#endregion // ChangeRequest accessor methods

		#region ChangeRequest collection
        public ChangeRequestCollection	MyChangeRequests = new ChangeRequestCollection( );

        public class ChangeRequestCollection: IEnumerable
        {
            ListOutstandingVerificationsResponseType parent;
            public ListOutstandingVerificationsResponseType Parent
			{
				set
				{
					parent = value;
				}
			}
			public ChangeRequestEnumerator GetEnumerator() 
			{
				return new ChangeRequestEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ChangeRequestEnumerator: IEnumerator 
        {
			int nIndex;
			ListOutstandingVerificationsResponseType parent;
			public ChangeRequestEnumerator(ListOutstandingVerificationsResponseType par) 
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
				return(nIndex < parent.ChangeRequestCount );
			}
			public core3.ChangeAddressType  Current 
			{
				get 
				{
					return(parent.GetChangeRequestAt(nIndex));
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

        #endregion // ChangeRequest collection

        private void SetCollectionParents()
        {
            MyChangeRequests.Parent = this; 
	}
}
}