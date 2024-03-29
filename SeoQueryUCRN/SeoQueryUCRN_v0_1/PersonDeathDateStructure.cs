//
// PersonDeathDateStructure.cs
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

namespace SeoQueryUCRN_v0_1.PersonDescriptives2
{
	public class PersonDeathDateStructure : Altova.Xml.Node
	{
		#region Forward constructors

		public PersonDeathDateStructure() : base() { SetCollectionParents(); }

		public PersonDeathDateStructure(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public PersonDeathDateStructure(XmlNode node) : base(node) { SetCollectionParents(); }
		public PersonDeathDateStructure(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public PersonDeathDateStructure(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonDeathDate" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonDeathDate", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "VerificationLevel" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "VerificationLevel", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "PersonDescriptives:PersonDeathDateStructure");
		}


		#region PersonDeathDate accessor methods
		public static int GetPersonDeathDateMinCount()
		{
			return 1;
		}

		public static int PersonDeathDateMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetPersonDeathDateMaxCount()
		{
			return 1;
		}

		public static int PersonDeathDateMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetPersonDeathDateCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonDeathDate");
		}

		public int PersonDeathDateCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonDeathDate");
			}
		}

		public bool HasPersonDeathDate()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonDeathDate");
		}

		public core2.DateType NewPersonDeathDate()
		{
			return new core2.DateType();
		}

		public core2.DateType GetPersonDeathDateAt(int index)
		{
			return new core2.DateType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonDeathDate", index)));
		}

		public XmlNode GetStartingPersonDeathDateCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonDeathDate" );
		}

		public XmlNode GetAdvancedPersonDeathDateCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonDeathDate", curNode );
		}

		public core2.DateType GetPersonDeathDateValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core2.DateType( curNode.InnerText );
		}


		public core2.DateType GetPersonDeathDate()
		{
			return GetPersonDeathDateAt(0);
		}

		public core2.DateType PersonDeathDate
		{
			get
			{
				return GetPersonDeathDateAt(0);
			}
		}

		public void RemovePersonDeathDateAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonDeathDate", index);
		}

		public void RemovePersonDeathDate()
		{
			RemovePersonDeathDateAt(0);
		}

		public XmlNode AddPersonDeathDate(core2.DateType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonDeathDate", newValue.ToString());
			return null;
		}

		public void InsertPersonDeathDateAt(core2.DateType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonDeathDate", index, newValue.ToString());
		}

		public void ReplacePersonDeathDateAt(core2.DateType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonDeathDate", index, newValue.ToString());
		}
		#endregion // PersonDeathDate accessor methods

		#region PersonDeathDate collection
        public PersonDeathDateCollection	MyPersonDeathDates = new PersonDeathDateCollection( );

        public class PersonDeathDateCollection: IEnumerable
        {
            PersonDeathDateStructure parent;
            public PersonDeathDateStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public PersonDeathDateEnumerator GetEnumerator() 
			{
				return new PersonDeathDateEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class PersonDeathDateEnumerator: IEnumerator 
        {
			int nIndex;
			PersonDeathDateStructure parent;
			public PersonDeathDateEnumerator(PersonDeathDateStructure par) 
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
				return(nIndex < parent.PersonDeathDateCount );
			}
			public core2.DateType  Current 
			{
				get 
				{
					return(parent.GetPersonDeathDateAt(nIndex));
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

        #endregion // PersonDeathDate collection

		#region VerificationLevel accessor methods
		public static int GetVerificationLevelMinCount()
		{
			return 0;
		}

		public static int VerificationLevelMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetVerificationLevelMaxCount()
		{
			return 1;
		}

		public static int VerificationLevelMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetVerificationLevelCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "VerificationLevel");
		}

		public int VerificationLevelCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "VerificationLevel");
			}
		}

		public bool HasVerificationLevel()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "VerificationLevel");
		}

		public VerificationLevelType NewVerificationLevel()
		{
			return new VerificationLevelType();
		}

		public VerificationLevelType GetVerificationLevelAt(int index)
		{
			return new VerificationLevelType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "VerificationLevel", index)));
		}

		public XmlNode GetStartingVerificationLevelCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "VerificationLevel" );
		}

		public XmlNode GetAdvancedVerificationLevelCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "VerificationLevel", curNode );
		}

		public VerificationLevelType GetVerificationLevelValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new VerificationLevelType( curNode.InnerText );
		}


		public VerificationLevelType GetVerificationLevel()
		{
			return GetVerificationLevelAt(0);
		}

		public VerificationLevelType VerificationLevel
		{
			get
			{
				return GetVerificationLevelAt(0);
			}
		}

		public void RemoveVerificationLevelAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "VerificationLevel", index);
		}

		public void RemoveVerificationLevel()
		{
			RemoveVerificationLevelAt(0);
		}

		public XmlNode AddVerificationLevel(VerificationLevelType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "VerificationLevel", newValue.ToString());
			return null;
		}

		public void InsertVerificationLevelAt(VerificationLevelType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "VerificationLevel", index, newValue.ToString());
		}

		public void ReplaceVerificationLevelAt(VerificationLevelType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "VerificationLevel", index, newValue.ToString());
		}
		#endregion // VerificationLevel accessor methods

		#region VerificationLevel collection
        public VerificationLevelCollection	MyVerificationLevels = new VerificationLevelCollection( );

        public class VerificationLevelCollection: IEnumerable
        {
            PersonDeathDateStructure parent;
            public PersonDeathDateStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public VerificationLevelEnumerator GetEnumerator() 
			{
				return new VerificationLevelEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class VerificationLevelEnumerator: IEnumerator 
        {
			int nIndex;
			PersonDeathDateStructure parent;
			public VerificationLevelEnumerator(PersonDeathDateStructure par) 
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
				return(nIndex < parent.VerificationLevelCount );
			}
			public VerificationLevelType  Current 
			{
				get 
				{
					return(parent.GetVerificationLevelAt(nIndex));
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

        #endregion // VerificationLevel collection

        private void SetCollectionParents()
        {
            MyPersonDeathDates.Parent = this; 
            MyVerificationLevels.Parent = this; 
	}
}
}
