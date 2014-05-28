//
// Level2EnrolmentType.cs
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

namespace SeoNotificationOfDeathCorrection_v0_1.core3
{
	public class Level2EnrolmentType : Altova.Xml.Node
	{
		#region Forward constructors

		public Level2EnrolmentType() : base() { SetCollectionParents(); }

		public Level2EnrolmentType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public Level2EnrolmentType(XmlNode node) : base(node) { SetCollectionParents(); }
		public Level2EnrolmentType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public Level2EnrolmentType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "IdentityDocumentation" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "IdentityDocumentation", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "ResidenceDocumentation" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "ResidenceDocumentation", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "core:Level2EnrolmentType");
		}


		#region IdentityDocumentation accessor methods
		public static int GetIdentityDocumentationMinCount()
		{
			return 2;
		}

		public static int IdentityDocumentationMinCount
		{
			get
			{
				return 2;
			}
		}

		public static int GetIdentityDocumentationMaxCount()
		{
			return 2;
		}

		public static int IdentityDocumentationMaxCount
		{
			get
			{
				return 2;
			}
		}

		public int GetIdentityDocumentationCount()
		{
			return DomChildCount(NodeType.Element, "", "IdentityDocumentation");
		}

		public int IdentityDocumentationCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "IdentityDocumentation");
			}
		}

		public bool HasIdentityDocumentation()
		{
			return HasDomChild(NodeType.Element, "", "IdentityDocumentation");
		}

		public DocumentaryProof NewIdentityDocumentation()
		{
			return new DocumentaryProof();
		}

		public DocumentaryProof GetIdentityDocumentationAt(int index)
		{
			return new DocumentaryProof(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "IdentityDocumentation", index)));
		}

		public XmlNode GetStartingIdentityDocumentationCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "IdentityDocumentation" );
		}

		public XmlNode GetAdvancedIdentityDocumentationCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "IdentityDocumentation", curNode );
		}

		public DocumentaryProof GetIdentityDocumentationValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new DocumentaryProof( curNode.InnerText );
		}


		public DocumentaryProof GetIdentityDocumentation()
		{
			return GetIdentityDocumentationAt(0);
		}

		public DocumentaryProof IdentityDocumentation
		{
			get
			{
				return GetIdentityDocumentationAt(0);
			}
		}

		public void RemoveIdentityDocumentationAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "IdentityDocumentation", index);
		}

		public void RemoveIdentityDocumentation()
		{
			while (HasIdentityDocumentation())
				RemoveIdentityDocumentationAt(0);
		}

		public XmlNode AddIdentityDocumentation(DocumentaryProof newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "IdentityDocumentation", newValue.ToString());
			return null;
		}

		public void InsertIdentityDocumentationAt(DocumentaryProof newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "IdentityDocumentation", index, newValue.ToString());
		}

		public void ReplaceIdentityDocumentationAt(DocumentaryProof newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "IdentityDocumentation", index, newValue.ToString());
		}
		#endregion // IdentityDocumentation accessor methods

		#region IdentityDocumentation collection
        public IdentityDocumentationCollection	MyIdentityDocumentations = new IdentityDocumentationCollection( );

        public class IdentityDocumentationCollection: IEnumerable
        {
            Level2EnrolmentType parent;
            public Level2EnrolmentType Parent
			{
				set
				{
					parent = value;
				}
			}
			public IdentityDocumentationEnumerator GetEnumerator() 
			{
				return new IdentityDocumentationEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class IdentityDocumentationEnumerator: IEnumerator 
        {
			int nIndex;
			Level2EnrolmentType parent;
			public IdentityDocumentationEnumerator(Level2EnrolmentType par) 
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
				return(nIndex < parent.IdentityDocumentationCount );
			}
			public DocumentaryProof  Current 
			{
				get 
				{
					return(parent.GetIdentityDocumentationAt(nIndex));
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

        #endregion // IdentityDocumentation collection

		#region ResidenceDocumentation accessor methods
		public static int GetResidenceDocumentationMinCount()
		{
			return 2;
		}

		public static int ResidenceDocumentationMinCount
		{
			get
			{
				return 2;
			}
		}

		public static int GetResidenceDocumentationMaxCount()
		{
			return 2;
		}

		public static int ResidenceDocumentationMaxCount
		{
			get
			{
				return 2;
			}
		}

		public int GetResidenceDocumentationCount()
		{
			return DomChildCount(NodeType.Element, "", "ResidenceDocumentation");
		}

		public int ResidenceDocumentationCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "ResidenceDocumentation");
			}
		}

		public bool HasResidenceDocumentation()
		{
			return HasDomChild(NodeType.Element, "", "ResidenceDocumentation");
		}

		public DocumentaryProof NewResidenceDocumentation()
		{
			return new DocumentaryProof();
		}

		public DocumentaryProof GetResidenceDocumentationAt(int index)
		{
			return new DocumentaryProof(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "ResidenceDocumentation", index)));
		}

		public XmlNode GetStartingResidenceDocumentationCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "ResidenceDocumentation" );
		}

		public XmlNode GetAdvancedResidenceDocumentationCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "ResidenceDocumentation", curNode );
		}

		public DocumentaryProof GetResidenceDocumentationValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new DocumentaryProof( curNode.InnerText );
		}


		public DocumentaryProof GetResidenceDocumentation()
		{
			return GetResidenceDocumentationAt(0);
		}

		public DocumentaryProof ResidenceDocumentation
		{
			get
			{
				return GetResidenceDocumentationAt(0);
			}
		}

		public void RemoveResidenceDocumentationAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "ResidenceDocumentation", index);
		}

		public void RemoveResidenceDocumentation()
		{
			while (HasResidenceDocumentation())
				RemoveResidenceDocumentationAt(0);
		}

		public XmlNode AddResidenceDocumentation(DocumentaryProof newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "ResidenceDocumentation", newValue.ToString());
			return null;
		}

		public void InsertResidenceDocumentationAt(DocumentaryProof newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "ResidenceDocumentation", index, newValue.ToString());
		}

		public void ReplaceResidenceDocumentationAt(DocumentaryProof newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "ResidenceDocumentation", index, newValue.ToString());
		}
		#endregion // ResidenceDocumentation accessor methods

		#region ResidenceDocumentation collection
        public ResidenceDocumentationCollection	MyResidenceDocumentations = new ResidenceDocumentationCollection( );

        public class ResidenceDocumentationCollection: IEnumerable
        {
            Level2EnrolmentType parent;
            public Level2EnrolmentType Parent
			{
				set
				{
					parent = value;
				}
			}
			public ResidenceDocumentationEnumerator GetEnumerator() 
			{
				return new ResidenceDocumentationEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ResidenceDocumentationEnumerator: IEnumerator 
        {
			int nIndex;
			Level2EnrolmentType parent;
			public ResidenceDocumentationEnumerator(Level2EnrolmentType par) 
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
				return(nIndex < parent.ResidenceDocumentationCount );
			}
			public DocumentaryProof  Current 
			{
				get 
				{
					return(parent.GetResidenceDocumentationAt(nIndex));
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

        #endregion // ResidenceDocumentation collection

        private void SetCollectionParents()
        {
            MyIdentityDocumentations.Parent = this; 
            MyResidenceDocumentations.Parent = this; 
	}
}
}
