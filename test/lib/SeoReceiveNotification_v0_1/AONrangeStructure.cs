//
// AONrangeStructure.cs
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
	public class AONrangeStructure : Altova.Xml.Node
	{
		#region Forward constructors

		public AONrangeStructure() : base() { SetCollectionParents(); }

		public AONrangeStructure(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public AONrangeStructure(XmlNode node) : base(node) { SetCollectionParents(); }
		public AONrangeStructure(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public AONrangeStructure(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Number" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Number", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Suffix" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Suffix", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "bs7666:AONrangeStructure");
		}


		#region Number accessor methods
		public static int GetNumberMinCount()
		{
			return 1;
		}

		public static int NumberMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetNumberMaxCount()
		{
			return 1;
		}

		public static int NumberMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetNumberCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Number");
		}

		public int NumberCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Number");
			}
		}

		public bool HasNumber()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Number");
		}

		public NumberType NewNumber()
		{
			return new NumberType();
		}

		public NumberType GetNumberAt(int index)
		{
			return new NumberType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Number", index)));
		}

		public XmlNode GetStartingNumberCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Number" );
		}

		public XmlNode GetAdvancedNumberCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Number", curNode );
		}

		public NumberType GetNumberValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new NumberType( curNode.InnerText );
		}


		public NumberType GetNumber()
		{
			return GetNumberAt(0);
		}

		public NumberType Number
		{
			get
			{
				return GetNumberAt(0);
			}
		}

		public void RemoveNumberAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Number", index);
		}

		public void RemoveNumber()
		{
			RemoveNumberAt(0);
		}

		public XmlNode AddNumber(NumberType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Number", newValue.ToString());
			return null;
		}

		public void InsertNumberAt(NumberType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Number", index, newValue.ToString());
		}

		public void ReplaceNumberAt(NumberType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Number", index, newValue.ToString());
		}
		#endregion // Number accessor methods

		#region Number collection
        public NumberCollection	MyNumbers = new NumberCollection( );

        public class NumberCollection: IEnumerable
        {
            AONrangeStructure parent;
            public AONrangeStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public NumberEnumerator GetEnumerator() 
			{
				return new NumberEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class NumberEnumerator: IEnumerator 
        {
			int nIndex;
			AONrangeStructure parent;
			public NumberEnumerator(AONrangeStructure par) 
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
				return(nIndex < parent.NumberCount );
			}
			public NumberType  Current 
			{
				get 
				{
					return(parent.GetNumberAt(nIndex));
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

        #endregion // Number collection

		#region Suffix accessor methods
		public static int GetSuffixMinCount()
		{
			return 0;
		}

		public static int SuffixMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetSuffixMaxCount()
		{
			return 1;
		}

		public static int SuffixMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetSuffixCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Suffix");
		}

		public int SuffixCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Suffix");
			}
		}

		public bool HasSuffix()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Suffix");
		}

		public SuffixType NewSuffix()
		{
			return new SuffixType();
		}

		public SuffixType GetSuffixAt(int index)
		{
			return new SuffixType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Suffix", index)));
		}

		public XmlNode GetStartingSuffixCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Suffix" );
		}

		public XmlNode GetAdvancedSuffixCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Suffix", curNode );
		}

		public SuffixType GetSuffixValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SuffixType( curNode.InnerText );
		}


		public SuffixType GetSuffix()
		{
			return GetSuffixAt(0);
		}

		public SuffixType Suffix
		{
			get
			{
				return GetSuffixAt(0);
			}
		}

		public void RemoveSuffixAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Suffix", index);
		}

		public void RemoveSuffix()
		{
			RemoveSuffixAt(0);
		}

		public XmlNode AddSuffix(SuffixType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Suffix", newValue.ToString());
			return null;
		}

		public void InsertSuffixAt(SuffixType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Suffix", index, newValue.ToString());
		}

		public void ReplaceSuffixAt(SuffixType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Suffix", index, newValue.ToString());
		}
		#endregion // Suffix accessor methods

		#region Suffix collection
        public SuffixCollection	MySuffixs = new SuffixCollection( );

        public class SuffixCollection: IEnumerable
        {
            AONrangeStructure parent;
            public AONrangeStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public SuffixEnumerator GetEnumerator() 
			{
				return new SuffixEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class SuffixEnumerator: IEnumerator 
        {
			int nIndex;
			AONrangeStructure parent;
			public SuffixEnumerator(AONrangeStructure par) 
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
				return(nIndex < parent.SuffixCount );
			}
			public SuffixType  Current 
			{
				get 
				{
					return(parent.GetSuffixAt(nIndex));
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

        #endregion // Suffix collection

        private void SetCollectionParents()
        {
            MyNumbers.Parent = this; 
            MySuffixs.Parent = this; 
	}
}
}
