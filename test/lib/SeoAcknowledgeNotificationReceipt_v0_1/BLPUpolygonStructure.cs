//
// BLPUpolygonStructure.cs
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

namespace SeoAcknowledgeNotificationReceipt_v0_1.bs76662
{
	public class BLPUpolygonStructure : Altova.Xml.Node
	{
		#region Forward constructors

		public BLPUpolygonStructure() : base() { SetCollectionParents(); }

		public BLPUpolygonStructure(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public BLPUpolygonStructure(XmlNode node) : base(node) { SetCollectionParents(); }
		public BLPUpolygonStructure(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public BLPUpolygonStructure(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonID" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonID", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonType" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonType", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Vertices" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Vertices", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
				new CoordinateStructure(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ExternalRef" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ExternalRef", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "bs7666:BLPUpolygonStructure");
		}


		#region PolygonID accessor methods
		public static int GetPolygonIDMinCount()
		{
			return 1;
		}

		public static int PolygonIDMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetPolygonIDMaxCount()
		{
			return 1;
		}

		public static int PolygonIDMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetPolygonIDCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonID");
		}

		public int PolygonIDCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonID");
			}
		}

		public bool HasPolygonID()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonID");
		}

		public PolygonIDType NewPolygonID()
		{
			return new PolygonIDType();
		}

		public PolygonIDType GetPolygonIDAt(int index)
		{
			return new PolygonIDType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonID", index)));
		}

		public XmlNode GetStartingPolygonIDCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonID" );
		}

		public XmlNode GetAdvancedPolygonIDCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonID", curNode );
		}

		public PolygonIDType GetPolygonIDValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new PolygonIDType( curNode.InnerText );
		}


		public PolygonIDType GetPolygonID()
		{
			return GetPolygonIDAt(0);
		}

		public PolygonIDType PolygonID
		{
			get
			{
				return GetPolygonIDAt(0);
			}
		}

		public void RemovePolygonIDAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonID", index);
		}

		public void RemovePolygonID()
		{
			RemovePolygonIDAt(0);
		}

		public XmlNode AddPolygonID(PolygonIDType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonID", newValue.ToString());
			return null;
		}

		public void InsertPolygonIDAt(PolygonIDType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonID", index, newValue.ToString());
		}

		public void ReplacePolygonIDAt(PolygonIDType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonID", index, newValue.ToString());
		}
		#endregion // PolygonID accessor methods

		#region PolygonID collection
        public PolygonIDCollection	MyPolygonIDs = new PolygonIDCollection( );

        public class PolygonIDCollection: IEnumerable
        {
            BLPUpolygonStructure parent;
            public BLPUpolygonStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public PolygonIDEnumerator GetEnumerator() 
			{
				return new PolygonIDEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class PolygonIDEnumerator: IEnumerator 
        {
			int nIndex;
			BLPUpolygonStructure parent;
			public PolygonIDEnumerator(BLPUpolygonStructure par) 
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
				return(nIndex < parent.PolygonIDCount );
			}
			public PolygonIDType  Current 
			{
				get 
				{
					return(parent.GetPolygonIDAt(nIndex));
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

        #endregion // PolygonID collection

		#region PolygonType accessor methods
		public static int GetPolygonTypeMinCount()
		{
			return 0;
		}

		public static int PolygonTypeMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetPolygonTypeMaxCount()
		{
			return 1;
		}

		public static int PolygonTypeMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetPolygonTypeCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonType");
		}

		public int PolygonTypeCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonType");
			}
		}

		public bool HasPolygonType()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonType");
		}

		public PolygonTypeType NewPolygonType()
		{
			return new PolygonTypeType();
		}

		public PolygonTypeType GetPolygonTypeAt(int index)
		{
			return new PolygonTypeType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonType", index)));
		}

		public XmlNode GetStartingPolygonTypeCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonType" );
		}

		public XmlNode GetAdvancedPolygonTypeCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonType", curNode );
		}

		public PolygonTypeType GetPolygonTypeValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new PolygonTypeType( curNode.InnerText );
		}


		public PolygonTypeType GetPolygonType()
		{
			return GetPolygonTypeAt(0);
		}

		public PolygonTypeType PolygonType
		{
			get
			{
				return GetPolygonTypeAt(0);
			}
		}

		public void RemovePolygonTypeAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonType", index);
		}

		public void RemovePolygonType()
		{
			RemovePolygonTypeAt(0);
		}

		public XmlNode AddPolygonType(PolygonTypeType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonType", newValue.ToString());
			return null;
		}

		public void InsertPolygonTypeAt(PolygonTypeType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonType", index, newValue.ToString());
		}

		public void ReplacePolygonTypeAt(PolygonTypeType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "PolygonType", index, newValue.ToString());
		}
		#endregion // PolygonType accessor methods

		#region PolygonType collection
        public PolygonTypeCollection	MyPolygonTypes = new PolygonTypeCollection( );

        public class PolygonTypeCollection: IEnumerable
        {
            BLPUpolygonStructure parent;
            public BLPUpolygonStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public PolygonTypeEnumerator GetEnumerator() 
			{
				return new PolygonTypeEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class PolygonTypeEnumerator: IEnumerator 
        {
			int nIndex;
			BLPUpolygonStructure parent;
			public PolygonTypeEnumerator(BLPUpolygonStructure par) 
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
				return(nIndex < parent.PolygonTypeCount );
			}
			public PolygonTypeType  Current 
			{
				get 
				{
					return(parent.GetPolygonTypeAt(nIndex));
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

        #endregion // PolygonType collection

		#region Vertices accessor methods
		public static int GetVerticesMinCount()
		{
			return 3;
		}

		public static int VerticesMinCount
		{
			get
			{
				return 3;
			}
		}

		public static int GetVerticesMaxCount()
		{
			return Int32.MaxValue;
		}

		public static int VerticesMaxCount
		{
			get
			{
				return Int32.MaxValue;
			}
		}

		public int GetVerticesCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Vertices");
		}

		public int VerticesCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Vertices");
			}
		}

		public bool HasVertices()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Vertices");
		}

		public CoordinateStructure NewVertices()
		{
			return new CoordinateStructure(domNode.OwnerDocument.CreateElement("Vertices", "http://www.govtalk.gov.uk/people/bs7666"));
		}

		public CoordinateStructure GetVerticesAt(int index)
		{
			return new CoordinateStructure(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Vertices", index));
		}

		public XmlNode GetStartingVerticesCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Vertices" );
		}

		public XmlNode GetAdvancedVerticesCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Vertices", curNode );
		}

		public CoordinateStructure GetVerticesValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new CoordinateStructure( curNode );
		}


		public CoordinateStructure GetVertices()
		{
			return GetVerticesAt(0);
		}

		public CoordinateStructure Vertices
		{
			get
			{
				return GetVerticesAt(0);
			}
		}

		public void RemoveVerticesAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Vertices", index);
		}

		public void RemoveVertices()
		{
			while (HasVertices())
				RemoveVerticesAt(0);
		}

		public XmlNode AddVertices(CoordinateStructure newValue)
		{
			return AppendDomElement("http://www.govtalk.gov.uk/people/bs7666", "Vertices", newValue);
		}

		public void InsertVerticesAt(CoordinateStructure newValue, int index)
		{
			InsertDomElementAt("http://www.govtalk.gov.uk/people/bs7666", "Vertices", index, newValue);
		}

		public void ReplaceVerticesAt(CoordinateStructure newValue, int index)
		{
			ReplaceDomElementAt("http://www.govtalk.gov.uk/people/bs7666", "Vertices", index, newValue);
		}
		#endregion // Vertices accessor methods

		#region Vertices collection
        public VerticesCollection	MyVerticess = new VerticesCollection( );

        public class VerticesCollection: IEnumerable
        {
            BLPUpolygonStructure parent;
            public BLPUpolygonStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public VerticesEnumerator GetEnumerator() 
			{
				return new VerticesEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class VerticesEnumerator: IEnumerator 
        {
			int nIndex;
			BLPUpolygonStructure parent;
			public VerticesEnumerator(BLPUpolygonStructure par) 
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
				return(nIndex < parent.VerticesCount );
			}
			public CoordinateStructure  Current 
			{
				get 
				{
					return(parent.GetVerticesAt(nIndex));
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

        #endregion // Vertices collection

		#region ExternalRef accessor methods
		public static int GetExternalRefMinCount()
		{
			return 1;
		}

		public static int ExternalRefMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetExternalRefMaxCount()
		{
			return 1;
		}

		public static int ExternalRefMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetExternalRefCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ExternalRef");
		}

		public int ExternalRefCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ExternalRef");
			}
		}

		public bool HasExternalRef()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ExternalRef");
		}

		public SchemaLong NewExternalRef()
		{
			return new SchemaLong();
		}

		public SchemaLong GetExternalRefAt(int index)
		{
			return new SchemaLong(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ExternalRef", index)));
		}

		public XmlNode GetStartingExternalRefCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ExternalRef" );
		}

		public XmlNode GetAdvancedExternalRefCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ExternalRef", curNode );
		}

		public SchemaLong GetExternalRefValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaLong( curNode.InnerText );
		}


		public SchemaLong GetExternalRef()
		{
			return GetExternalRefAt(0);
		}

		public SchemaLong ExternalRef
		{
			get
			{
				return GetExternalRefAt(0);
			}
		}

		public void RemoveExternalRefAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ExternalRef", index);
		}

		public void RemoveExternalRef()
		{
			RemoveExternalRefAt(0);
		}

		public XmlNode AddExternalRef(SchemaLong newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ExternalRef", newValue.ToString());
			return null;
		}

		public void InsertExternalRefAt(SchemaLong newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ExternalRef", index, newValue.ToString());
		}

		public void ReplaceExternalRefAt(SchemaLong newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ExternalRef", index, newValue.ToString());
		}
		#endregion // ExternalRef accessor methods

		#region ExternalRef collection
        public ExternalRefCollection	MyExternalRefs = new ExternalRefCollection( );

        public class ExternalRefCollection: IEnumerable
        {
            BLPUpolygonStructure parent;
            public BLPUpolygonStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public ExternalRefEnumerator GetEnumerator() 
			{
				return new ExternalRefEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ExternalRefEnumerator: IEnumerator 
        {
			int nIndex;
			BLPUpolygonStructure parent;
			public ExternalRefEnumerator(BLPUpolygonStructure par) 
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
				return(nIndex < parent.ExternalRefCount );
			}
			public SchemaLong  Current 
			{
				get 
				{
					return(parent.GetExternalRefAt(nIndex));
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

        #endregion // ExternalRef collection

        private void SetCollectionParents()
        {
            MyPolygonIDs.Parent = this; 
            MyPolygonTypes.Parent = this; 
            MyVerticess.Parent = this; 
            MyExternalRefs.Parent = this; 
	}
}
}