//
// QueryUCRNRequestType.cs
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

namespace SeoQueryUCRN_v0_1
{
	public class QueryUCRNRequestType : Altova.Xml.Node
	{
		#region Forward constructors

		public QueryUCRNRequestType() : base() { SetCollectionParents(); }

		public QueryUCRNRequestType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public QueryUCRNRequestType(XmlNode node) : base(node) { SetCollectionParents(); }
		public QueryUCRNRequestType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public QueryUCRNRequestType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "CitizenDetails" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "CitizenDetails", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
				new core3.CitizenSearchDetailsType(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "NECNumber" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "NECNumber", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "QueryUCRNRequest");
		}


		#region CitizenDetails accessor methods
		public static int GetCitizenDetailsMinCount()
		{
			return 1;
		}

		public static int CitizenDetailsMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetCitizenDetailsMaxCount()
		{
			return 1;
		}

		public static int CitizenDetailsMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetCitizenDetailsCount()
		{
			return DomChildCount(NodeType.Element, "", "CitizenDetails");
		}

		public int CitizenDetailsCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "CitizenDetails");
			}
		}

		public bool HasCitizenDetails()
		{
			return HasDomChild(NodeType.Element, "", "CitizenDetails");
		}

		public core3.CitizenSearchDetailsType NewCitizenDetails()
		{
			return new core3.CitizenSearchDetailsType(domNode.OwnerDocument.CreateElement("CitizenDetails", ""));
		}

		public core3.CitizenSearchDetailsType GetCitizenDetailsAt(int index)
		{
			return new core3.CitizenSearchDetailsType(GetDomChildAt(NodeType.Element, "", "CitizenDetails", index));
		}

		public XmlNode GetStartingCitizenDetailsCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "CitizenDetails" );
		}

		public XmlNode GetAdvancedCitizenDetailsCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "CitizenDetails", curNode );
		}

		public core3.CitizenSearchDetailsType GetCitizenDetailsValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core3.CitizenSearchDetailsType( curNode );
		}


		public core3.CitizenSearchDetailsType GetCitizenDetails()
		{
			return GetCitizenDetailsAt(0);
		}

		public core3.CitizenSearchDetailsType CitizenDetails
		{
			get
			{
				return GetCitizenDetailsAt(0);
			}
		}

		public void RemoveCitizenDetailsAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "CitizenDetails", index);
		}

		public void RemoveCitizenDetails()
		{
			RemoveCitizenDetailsAt(0);
		}

		public XmlNode AddCitizenDetails(core3.CitizenSearchDetailsType newValue)
		{
			return AppendDomElement("", "CitizenDetails", newValue);
		}

		public void InsertCitizenDetailsAt(core3.CitizenSearchDetailsType newValue, int index)
		{
			InsertDomElementAt("", "CitizenDetails", index, newValue);
		}

		public void ReplaceCitizenDetailsAt(core3.CitizenSearchDetailsType newValue, int index)
		{
			ReplaceDomElementAt("", "CitizenDetails", index, newValue);
		}
		#endregion // CitizenDetails accessor methods

		#region CitizenDetails collection
        public CitizenDetailsCollection	MyCitizenDetailss = new CitizenDetailsCollection( );

        public class CitizenDetailsCollection: IEnumerable
        {
            QueryUCRNRequestType parent;
            public QueryUCRNRequestType Parent
			{
				set
				{
					parent = value;
				}
			}
			public CitizenDetailsEnumerator GetEnumerator() 
			{
				return new CitizenDetailsEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class CitizenDetailsEnumerator: IEnumerator 
        {
			int nIndex;
			QueryUCRNRequestType parent;
			public CitizenDetailsEnumerator(QueryUCRNRequestType par) 
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
				return(nIndex < parent.CitizenDetailsCount );
			}
			public core3.CitizenSearchDetailsType  Current 
			{
				get 
				{
					return(parent.GetCitizenDetailsAt(nIndex));
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

        #endregion // CitizenDetails collection

		#region NECNumber accessor methods
		public static int GetNECNumberMinCount()
		{
			return 1;
		}

		public static int NECNumberMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetNECNumberMaxCount()
		{
			return 1;
		}

		public static int NECNumberMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetNECNumberCount()
		{
			return DomChildCount(NodeType.Element, "", "NECNumber");
		}

		public int NECNumberCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "NECNumber");
			}
		}

		public bool HasNECNumber()
		{
			return HasDomChild(NodeType.Element, "", "NECNumber");
		}

		public core3.EntitlementCardNumberType NewNECNumber()
		{
			return new core3.EntitlementCardNumberType();
		}

		public core3.EntitlementCardNumberType GetNECNumberAt(int index)
		{
			return new core3.EntitlementCardNumberType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "NECNumber", index)));
		}

		public XmlNode GetStartingNECNumberCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "NECNumber" );
		}

		public XmlNode GetAdvancedNECNumberCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "NECNumber", curNode );
		}

		public core3.EntitlementCardNumberType GetNECNumberValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core3.EntitlementCardNumberType( curNode.InnerText );
		}


		public core3.EntitlementCardNumberType GetNECNumber()
		{
			return GetNECNumberAt(0);
		}

		public core3.EntitlementCardNumberType NECNumber
		{
			get
			{
				return GetNECNumberAt(0);
			}
		}

		public void RemoveNECNumberAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "NECNumber", index);
		}

		public void RemoveNECNumber()
		{
			RemoveNECNumberAt(0);
		}

		public XmlNode AddNECNumber(core3.EntitlementCardNumberType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "NECNumber", newValue.ToString());
			return null;
		}

		public void InsertNECNumberAt(core3.EntitlementCardNumberType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "NECNumber", index, newValue.ToString());
		}

		public void ReplaceNECNumberAt(core3.EntitlementCardNumberType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "NECNumber", index, newValue.ToString());
		}
		#endregion // NECNumber accessor methods

		#region NECNumber collection
        public NECNumberCollection	MyNECNumbers = new NECNumberCollection( );

        public class NECNumberCollection: IEnumerable
        {
            QueryUCRNRequestType parent;
            public QueryUCRNRequestType Parent
			{
				set
				{
					parent = value;
				}
			}
			public NECNumberEnumerator GetEnumerator() 
			{
				return new NECNumberEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class NECNumberEnumerator: IEnumerator 
        {
			int nIndex;
			QueryUCRNRequestType parent;
			public NECNumberEnumerator(QueryUCRNRequestType par) 
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
				return(nIndex < parent.NECNumberCount );
			}
			public core3.EntitlementCardNumberType  Current 
			{
				get 
				{
					return(parent.GetNECNumberAt(nIndex));
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

        #endregion // NECNumber collection

        private void SetCollectionParents()
        {
            MyCitizenDetailss.Parent = this; 
            MyNECNumbers.Parent = this; 
	}
}
}
