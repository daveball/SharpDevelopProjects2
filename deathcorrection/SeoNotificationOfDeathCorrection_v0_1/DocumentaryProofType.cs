//
// DocumentaryProofType.cs
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
	public class DocumentaryProofType : Altova.Xml.Node
	{
		#region Forward constructors

		public DocumentaryProofType() : base() { SetCollectionParents(); }

		public DocumentaryProofType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public DocumentaryProofType(XmlNode node) : base(node) { SetCollectionParents(); }
		public DocumentaryProofType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public DocumentaryProofType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "Code" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "Code", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "Description" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "Description", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "core:DocumentaryProofType");
		}


		#region Code accessor methods
		public static int GetCodeMinCount()
		{
			return 1;
		}

		public static int CodeMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetCodeMaxCount()
		{
			return 1;
		}

		public static int CodeMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetCodeCount()
		{
			return DomChildCount(NodeType.Element, "", "Code");
		}

		public int CodeCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Code");
			}
		}

		public bool HasCode()
		{
			return HasDomChild(NodeType.Element, "", "Code");
		}

		public CodeType NewCode()
		{
			return new CodeType();
		}

		public CodeType GetCodeAt(int index)
		{
			return new CodeType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Code", index)));
		}

		public XmlNode GetStartingCodeCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "Code" );
		}

		public XmlNode GetAdvancedCodeCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "Code", curNode );
		}

		public CodeType GetCodeValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new CodeType( curNode.InnerText );
		}


		public CodeType GetCode()
		{
			return GetCodeAt(0);
		}

		public CodeType Code
		{
			get
			{
				return GetCodeAt(0);
			}
		}

		public void RemoveCodeAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Code", index);
		}

		public void RemoveCode()
		{
			RemoveCodeAt(0);
		}

		public XmlNode AddCode(CodeType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "Code", newValue.ToString());
			return null;
		}

		public void InsertCodeAt(CodeType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "Code", index, newValue.ToString());
		}

		public void ReplaceCodeAt(CodeType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Code", index, newValue.ToString());
		}
		#endregion // Code accessor methods

		#region Code collection
        public CodeCollection	MyCodes = new CodeCollection( );

        public class CodeCollection: IEnumerable
        {
            DocumentaryProofType parent;
            public DocumentaryProofType Parent
			{
				set
				{
					parent = value;
				}
			}
			public CodeEnumerator GetEnumerator() 
			{
				return new CodeEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class CodeEnumerator: IEnumerator 
        {
			int nIndex;
			DocumentaryProofType parent;
			public CodeEnumerator(DocumentaryProofType par) 
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
				return(nIndex < parent.CodeCount );
			}
			public CodeType  Current 
			{
				get 
				{
					return(parent.GetCodeAt(nIndex));
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

        #endregion // Code collection

		#region Description accessor methods
		public static int GetDescriptionMinCount()
		{
			return 1;
		}

		public static int DescriptionMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetDescriptionMaxCount()
		{
			return 1;
		}

		public static int DescriptionMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetDescriptionCount()
		{
			return DomChildCount(NodeType.Element, "", "Description");
		}

		public int DescriptionCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Description");
			}
		}

		public bool HasDescription()
		{
			return HasDomChild(NodeType.Element, "", "Description");
		}

		public DescriptionType NewDescription()
		{
			return new DescriptionType();
		}

		public DescriptionType GetDescriptionAt(int index)
		{
			return new DescriptionType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Description", index)));
		}

		public XmlNode GetStartingDescriptionCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "Description" );
		}

		public XmlNode GetAdvancedDescriptionCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "Description", curNode );
		}

		public DescriptionType GetDescriptionValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new DescriptionType( curNode.InnerText );
		}


		public DescriptionType GetDescription()
		{
			return GetDescriptionAt(0);
		}

		public DescriptionType Description
		{
			get
			{
				return GetDescriptionAt(0);
			}
		}

		public void RemoveDescriptionAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Description", index);
		}

		public void RemoveDescription()
		{
			RemoveDescriptionAt(0);
		}

		public XmlNode AddDescription(DescriptionType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "Description", newValue.ToString());
			return null;
		}

		public void InsertDescriptionAt(DescriptionType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "Description", index, newValue.ToString());
		}

		public void ReplaceDescriptionAt(DescriptionType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Description", index, newValue.ToString());
		}
		#endregion // Description accessor methods

		#region Description collection
        public DescriptionCollection	MyDescriptions = new DescriptionCollection( );

        public class DescriptionCollection: IEnumerable
        {
            DocumentaryProofType parent;
            public DocumentaryProofType Parent
			{
				set
				{
					parent = value;
				}
			}
			public DescriptionEnumerator GetEnumerator() 
			{
				return new DescriptionEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class DescriptionEnumerator: IEnumerator 
        {
			int nIndex;
			DocumentaryProofType parent;
			public DescriptionEnumerator(DocumentaryProofType par) 
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
				return(nIndex < parent.DescriptionCount );
			}
			public DescriptionType  Current 
			{
				get 
				{
					return(parent.GetDescriptionAt(nIndex));
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

        #endregion // Description collection

        private void SetCollectionParents()
        {
            MyCodes.Parent = this; 
            MyDescriptions.Parent = this; 
	}
}
}
