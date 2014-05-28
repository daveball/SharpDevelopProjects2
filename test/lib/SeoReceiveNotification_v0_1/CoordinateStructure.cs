//
// CoordinateStructure.cs
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
	public class CoordinateStructure : Altova.Xml.Node
	{
		#region Forward constructors

		public CoordinateStructure() : base() { SetCollectionParents(); }

		public CoordinateStructure(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public CoordinateStructure(XmlNode node) : base(node) { SetCollectionParents(); }
		public CoordinateStructure(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public CoordinateStructure(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "X" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "X", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Y" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Y", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "bs7666:CoordinateStructure");
		}


		#region X accessor methods
		public static int GetXMinCount()
		{
			return 1;
		}

		public static int XMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetXMaxCount()
		{
			return 1;
		}

		public static int XMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetXCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "X");
		}

		public int XCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "X");
			}
		}

		public bool HasX()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "X");
		}

		public XType NewX()
		{
			return new XType();
		}

		public XType GetXAt(int index)
		{
			return new XType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "X", index)));
		}

		public XmlNode GetStartingXCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "X" );
		}

		public XmlNode GetAdvancedXCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "X", curNode );
		}

		public XType GetXValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new XType( curNode.InnerText );
		}


		public XType GetX()
		{
			return GetXAt(0);
		}

		public XType X
		{
			get
			{
				return GetXAt(0);
			}
		}

		public void RemoveXAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "X", index);
		}

		public void RemoveX()
		{
			RemoveXAt(0);
		}

		public XmlNode AddX(XType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "X", newValue.ToString());
			return null;
		}

		public void InsertXAt(XType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "X", index, newValue.ToString());
		}

		public void ReplaceXAt(XType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "X", index, newValue.ToString());
		}
		#endregion // X accessor methods

		#region X collection
        public XCollection	MyXs = new XCollection( );

        public class XCollection: IEnumerable
        {
            CoordinateStructure parent;
            public CoordinateStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public XEnumerator GetEnumerator() 
			{
				return new XEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class XEnumerator: IEnumerator 
        {
			int nIndex;
			CoordinateStructure parent;
			public XEnumerator(CoordinateStructure par) 
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
				return(nIndex < parent.XCount );
			}
			public XType  Current 
			{
				get 
				{
					return(parent.GetXAt(nIndex));
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

        #endregion // X collection

		#region Y accessor methods
		public static int GetYMinCount()
		{
			return 1;
		}

		public static int YMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetYMaxCount()
		{
			return 1;
		}

		public static int YMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetYCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Y");
		}

		public int YCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Y");
			}
		}

		public bool HasY()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Y");
		}

		public YType NewY()
		{
			return new YType();
		}

		public YType GetYAt(int index)
		{
			return new YType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Y", index)));
		}

		public XmlNode GetStartingYCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Y" );
		}

		public XmlNode GetAdvancedYCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Y", curNode );
		}

		public YType GetYValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new YType( curNode.InnerText );
		}


		public YType GetY()
		{
			return GetYAt(0);
		}

		public YType Y
		{
			get
			{
				return GetYAt(0);
			}
		}

		public void RemoveYAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Y", index);
		}

		public void RemoveY()
		{
			RemoveYAt(0);
		}

		public XmlNode AddY(YType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Y", newValue.ToString());
			return null;
		}

		public void InsertYAt(YType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Y", index, newValue.ToString());
		}

		public void ReplaceYAt(YType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Y", index, newValue.ToString());
		}
		#endregion // Y accessor methods

		#region Y collection
        public YCollection	MyYs = new YCollection( );

        public class YCollection: IEnumerable
        {
            CoordinateStructure parent;
            public CoordinateStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public YEnumerator GetEnumerator() 
			{
				return new YEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class YEnumerator: IEnumerator 
        {
			int nIndex;
			CoordinateStructure parent;
			public YEnumerator(CoordinateStructure par) 
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
				return(nIndex < parent.YCount );
			}
			public YType  Current 
			{
				get 
				{
					return(parent.GetYAt(nIndex));
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

        #endregion // Y collection

        private void SetCollectionParents()
        {
            MyXs.Parent = this; 
            MyYs.Parent = this; 
	}
}
}
