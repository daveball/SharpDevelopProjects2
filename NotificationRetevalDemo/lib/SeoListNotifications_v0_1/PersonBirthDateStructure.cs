//
// PersonBirthDateStructure.cs
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

namespace SeoListNotifications_v0_1.PersonDescriptives2
{
	public class PersonBirthDateStructure : Altova.Xml.Node
	{
		#region Forward constructors

		public PersonBirthDateStructure() : base() { SetCollectionParents(); }

		public PersonBirthDateStructure(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public PersonBirthDateStructure(XmlNode node) : base(node) { SetCollectionParents(); }
		public PersonBirthDateStructure(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public PersonBirthDateStructure(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonBirthDate" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonBirthDate", DOMNode )
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
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "PersonDescriptives:PersonBirthDateStructure");
		}


		#region PersonBirthDate accessor methods
		public static int GetPersonBirthDateMinCount()
		{
			return 1;
		}

		public static int PersonBirthDateMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetPersonBirthDateMaxCount()
		{
			return 1;
		}

		public static int PersonBirthDateMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetPersonBirthDateCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonBirthDate");
		}

		public int PersonBirthDateCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonBirthDate");
			}
		}

		public bool HasPersonBirthDate()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonBirthDate");
		}

		public core2.DateType NewPersonBirthDate()
		{
			return new core2.DateType();
		}

		public core2.DateType GetPersonBirthDateAt(int index)
		{
			return new core2.DateType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonBirthDate", index)));
		}

		public XmlNode GetStartingPersonBirthDateCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonBirthDate" );
		}

		public XmlNode GetAdvancedPersonBirthDateCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonBirthDate", curNode );
		}

		public core2.DateType GetPersonBirthDateValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core2.DateType( curNode.InnerText );
		}


		public core2.DateType GetPersonBirthDate()
		{
			return GetPersonBirthDateAt(0);
		}

		public core2.DateType PersonBirthDate
		{
			get
			{
				return GetPersonBirthDateAt(0);
			}
		}

		public void RemovePersonBirthDateAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonBirthDate", index);
		}

		public void RemovePersonBirthDate()
		{
			RemovePersonBirthDateAt(0);
		}

		public XmlNode AddPersonBirthDate(core2.DateType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonBirthDate", newValue.ToString());
			return null;
		}

		public void InsertPersonBirthDateAt(core2.DateType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonBirthDate", index, newValue.ToString());
		}

		public void ReplacePersonBirthDateAt(core2.DateType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "PersonBirthDate", index, newValue.ToString());
		}
		#endregion // PersonBirthDate accessor methods

		#region PersonBirthDate collection
        public PersonBirthDateCollection	MyPersonBirthDates = new PersonBirthDateCollection( );

        public class PersonBirthDateCollection: IEnumerable
        {
            PersonBirthDateStructure parent;
            public PersonBirthDateStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public PersonBirthDateEnumerator GetEnumerator() 
			{
				return new PersonBirthDateEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class PersonBirthDateEnumerator: IEnumerator 
        {
			int nIndex;
			PersonBirthDateStructure parent;
			public PersonBirthDateEnumerator(PersonBirthDateStructure par) 
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
				return(nIndex < parent.PersonBirthDateCount );
			}
			public core2.DateType  Current 
			{
				get 
				{
					return(parent.GetPersonBirthDateAt(nIndex));
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

        #endregion // PersonBirthDate collection

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
            PersonBirthDateStructure parent;
            public PersonBirthDateStructure Parent
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
			PersonBirthDateStructure parent;
			public VerificationLevelEnumerator(PersonBirthDateStructure par) 
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
            MyPersonBirthDates.Parent = this; 
            MyVerificationLevels.Parent = this; 
	}
}
}
