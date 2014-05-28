//
// StreetCrossReferencesType.cs
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

namespace SeoReceiveNotification_v0_1.bs76662
{
	public class StreetCrossReferencesType : Altova.Xml.Node
	{
		#region Forward constructors

		public StreetCrossReferencesType() : base() { SetCollectionParents(); }

		public StreetCrossReferencesType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public StreetCrossReferencesType(XmlNode node) : base(node) { SetCollectionParents(); }
		public StreetCrossReferencesType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public StreetCrossReferencesType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "UniqueStreetReferenceNumbers" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "UniqueStreetReferenceNumbers", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ElementaryStreetUnit" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ElementaryStreetUnit", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
				new ElementaryStreetUnitStructure(DOMNode).AdjustPrefix();
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "bs7666:StreetCrossReferences");
		}


		#region UniqueStreetReferenceNumbers accessor methods
		public static int GetUniqueStreetReferenceNumbersMinCount()
		{
			return 1;
		}

		public static int UniqueStreetReferenceNumbersMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetUniqueStreetReferenceNumbersMaxCount()
		{
			return 1;
		}

		public static int UniqueStreetReferenceNumbersMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetUniqueStreetReferenceNumbersCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "UniqueStreetReferenceNumbers");
		}

		public int UniqueStreetReferenceNumbersCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "UniqueStreetReferenceNumbers");
			}
		}

		public bool HasUniqueStreetReferenceNumbers()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "UniqueStreetReferenceNumbers");
		}

		public USRNlistType NewUniqueStreetReferenceNumbers()
		{
			return new USRNlistType();
		}

		public USRNlistType GetUniqueStreetReferenceNumbersAt(int index)
		{
			return new USRNlistType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "UniqueStreetReferenceNumbers", index)));
		}

		public XmlNode GetStartingUniqueStreetReferenceNumbersCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "UniqueStreetReferenceNumbers" );
		}

		public XmlNode GetAdvancedUniqueStreetReferenceNumbersCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "UniqueStreetReferenceNumbers", curNode );
		}

		public USRNlistType GetUniqueStreetReferenceNumbersValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new USRNlistType( curNode.InnerText );
		}


		public USRNlistType GetUniqueStreetReferenceNumbers()
		{
			return GetUniqueStreetReferenceNumbersAt(0);
		}

		public USRNlistType UniqueStreetReferenceNumbers
		{
			get
			{
				return GetUniqueStreetReferenceNumbersAt(0);
			}
		}

		public void RemoveUniqueStreetReferenceNumbersAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "UniqueStreetReferenceNumbers", index);
		}

		public void RemoveUniqueStreetReferenceNumbers()
		{
			RemoveUniqueStreetReferenceNumbersAt(0);
		}

		public XmlNode AddUniqueStreetReferenceNumbers(USRNlistType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "UniqueStreetReferenceNumbers", newValue.ToString());
			return null;
		}

		public void InsertUniqueStreetReferenceNumbersAt(USRNlistType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "UniqueStreetReferenceNumbers", index, newValue.ToString());
		}

		public void ReplaceUniqueStreetReferenceNumbersAt(USRNlistType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "UniqueStreetReferenceNumbers", index, newValue.ToString());
		}
		#endregion // UniqueStreetReferenceNumbers accessor methods

		#region UniqueStreetReferenceNumbers collection
        public UniqueStreetReferenceNumbersCollection	MyUniqueStreetReferenceNumberss = new UniqueStreetReferenceNumbersCollection( );

        public class UniqueStreetReferenceNumbersCollection: IEnumerable
        {
            StreetCrossReferencesType parent;
            public StreetCrossReferencesType Parent
			{
				set
				{
					parent = value;
				}
			}
			public UniqueStreetReferenceNumbersEnumerator GetEnumerator() 
			{
				return new UniqueStreetReferenceNumbersEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class UniqueStreetReferenceNumbersEnumerator: IEnumerator 
        {
			int nIndex;
			StreetCrossReferencesType parent;
			public UniqueStreetReferenceNumbersEnumerator(StreetCrossReferencesType par) 
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
				return(nIndex < parent.UniqueStreetReferenceNumbersCount );
			}
			public USRNlistType  Current 
			{
				get 
				{
					return(parent.GetUniqueStreetReferenceNumbersAt(nIndex));
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

        #endregion // UniqueStreetReferenceNumbers collection

		#region ElementaryStreetUnit accessor methods
		public static int GetElementaryStreetUnitMinCount()
		{
			return 0;
		}

		public static int ElementaryStreetUnitMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetElementaryStreetUnitMaxCount()
		{
			return Int32.MaxValue;
		}

		public static int ElementaryStreetUnitMaxCount
		{
			get
			{
				return Int32.MaxValue;
			}
		}

		public int GetElementaryStreetUnitCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ElementaryStreetUnit");
		}

		public int ElementaryStreetUnitCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ElementaryStreetUnit");
			}
		}

		public bool HasElementaryStreetUnit()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ElementaryStreetUnit");
		}

		public ElementaryStreetUnitStructure NewElementaryStreetUnit()
		{
			return new ElementaryStreetUnitStructure(domNode.OwnerDocument.CreateElement("ElementaryStreetUnit", "http://www.govtalk.gov.uk/people/bs7666"));
		}

		public ElementaryStreetUnitStructure GetElementaryStreetUnitAt(int index)
		{
			return new ElementaryStreetUnitStructure(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ElementaryStreetUnit", index));
		}

		public XmlNode GetStartingElementaryStreetUnitCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ElementaryStreetUnit" );
		}

		public XmlNode GetAdvancedElementaryStreetUnitCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ElementaryStreetUnit", curNode );
		}

		public ElementaryStreetUnitStructure GetElementaryStreetUnitValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new ElementaryStreetUnitStructure( curNode );
		}


		public ElementaryStreetUnitStructure GetElementaryStreetUnit()
		{
			return GetElementaryStreetUnitAt(0);
		}

		public ElementaryStreetUnitStructure ElementaryStreetUnit
		{
			get
			{
				return GetElementaryStreetUnitAt(0);
			}
		}

		public void RemoveElementaryStreetUnitAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ElementaryStreetUnit", index);
		}

		public void RemoveElementaryStreetUnit()
		{
			while (HasElementaryStreetUnit())
				RemoveElementaryStreetUnitAt(0);
		}

		public XmlNode AddElementaryStreetUnit(ElementaryStreetUnitStructure newValue)
		{
			return AppendDomElement("http://www.govtalk.gov.uk/people/bs7666", "ElementaryStreetUnit", newValue);
		}

		public void InsertElementaryStreetUnitAt(ElementaryStreetUnitStructure newValue, int index)
		{
			InsertDomElementAt("http://www.govtalk.gov.uk/people/bs7666", "ElementaryStreetUnit", index, newValue);
		}

		public void ReplaceElementaryStreetUnitAt(ElementaryStreetUnitStructure newValue, int index)
		{
			ReplaceDomElementAt("http://www.govtalk.gov.uk/people/bs7666", "ElementaryStreetUnit", index, newValue);
		}
		#endregion // ElementaryStreetUnit accessor methods

		#region ElementaryStreetUnit collection
        public ElementaryStreetUnitCollection	MyElementaryStreetUnits = new ElementaryStreetUnitCollection( );

        public class ElementaryStreetUnitCollection: IEnumerable
        {
            StreetCrossReferencesType parent;
            public StreetCrossReferencesType Parent
			{
				set
				{
					parent = value;
				}
			}
			public ElementaryStreetUnitEnumerator GetEnumerator() 
			{
				return new ElementaryStreetUnitEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ElementaryStreetUnitEnumerator: IEnumerator 
        {
			int nIndex;
			StreetCrossReferencesType parent;
			public ElementaryStreetUnitEnumerator(StreetCrossReferencesType par) 
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
				return(nIndex < parent.ElementaryStreetUnitCount );
			}
			public ElementaryStreetUnitStructure  Current 
			{
				get 
				{
					return(parent.GetElementaryStreetUnitAt(nIndex));
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

        #endregion // ElementaryStreetUnit collection

        private void SetCollectionParents()
        {
            MyUniqueStreetReferenceNumberss.Parent = this; 
            MyElementaryStreetUnits.Parent = this; 
	}
}
}
