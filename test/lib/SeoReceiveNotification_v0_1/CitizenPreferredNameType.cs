//
// CitizenPreferredNameType.cs
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

namespace SeoReceiveNotification_v0_1.core3
{
	public class CitizenPreferredNameType : Altova.Xml.Node
	{
		#region Forward constructors

		public CitizenPreferredNameType() : base() { SetCollectionParents(); }

		public CitizenPreferredNameType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public CitizenPreferredNameType(XmlNode node) : base(node) { SetCollectionParents(); }
		public CitizenPreferredNameType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public CitizenPreferredNameType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "PersonNameTitle" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "PersonNameTitle", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "PreferredName" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "PreferredName", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "core:CitizenPreferredNameType");
		}


		#region PersonNameTitle accessor methods
		public static int GetPersonNameTitleMinCount()
		{
			return 0;
		}

		public static int PersonNameTitleMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetPersonNameTitleMaxCount()
		{
			return 1;
		}

		public static int PersonNameTitleMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetPersonNameTitleCount()
		{
			return DomChildCount(NodeType.Element, "", "PersonNameTitle");
		}

		public int PersonNameTitleCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "PersonNameTitle");
			}
		}

		public bool HasPersonNameTitle()
		{
			return HasDomChild(NodeType.Element, "", "PersonNameTitle");
		}

		public PersonDescriptives2.PersonNameTitleType NewPersonNameTitle()
		{
			return new PersonDescriptives2.PersonNameTitleType();
		}

		public PersonDescriptives2.PersonNameTitleType GetPersonNameTitleAt(int index)
		{
			return new PersonDescriptives2.PersonNameTitleType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "PersonNameTitle", index)));
		}

		public XmlNode GetStartingPersonNameTitleCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "PersonNameTitle" );
		}

		public XmlNode GetAdvancedPersonNameTitleCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "PersonNameTitle", curNode );
		}

		public PersonDescriptives2.PersonNameTitleType GetPersonNameTitleValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new PersonDescriptives2.PersonNameTitleType( curNode.InnerText );
		}


		public PersonDescriptives2.PersonNameTitleType GetPersonNameTitle()
		{
			return GetPersonNameTitleAt(0);
		}

		public PersonDescriptives2.PersonNameTitleType PersonNameTitle
		{
			get
			{
				return GetPersonNameTitleAt(0);
			}
		}

		public void RemovePersonNameTitleAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "PersonNameTitle", index);
		}

		public void RemovePersonNameTitle()
		{
			RemovePersonNameTitleAt(0);
		}

		public XmlNode AddPersonNameTitle(PersonDescriptives2.PersonNameTitleType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "PersonNameTitle", newValue.ToString());
			return null;
		}

		public void InsertPersonNameTitleAt(PersonDescriptives2.PersonNameTitleType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "PersonNameTitle", index, newValue.ToString());
		}

		public void ReplacePersonNameTitleAt(PersonDescriptives2.PersonNameTitleType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "PersonNameTitle", index, newValue.ToString());
		}
		#endregion // PersonNameTitle accessor methods

		#region PersonNameTitle collection
        public PersonNameTitleCollection	MyPersonNameTitles = new PersonNameTitleCollection( );

        public class PersonNameTitleCollection: IEnumerable
        {
            CitizenPreferredNameType parent;
            public CitizenPreferredNameType Parent
			{
				set
				{
					parent = value;
				}
			}
			public PersonNameTitleEnumerator GetEnumerator() 
			{
				return new PersonNameTitleEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class PersonNameTitleEnumerator: IEnumerator 
        {
			int nIndex;
			CitizenPreferredNameType parent;
			public PersonNameTitleEnumerator(CitizenPreferredNameType par) 
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
				return(nIndex < parent.PersonNameTitleCount );
			}
			public PersonDescriptives2.PersonNameTitleType  Current 
			{
				get 
				{
					return(parent.GetPersonNameTitleAt(nIndex));
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

        #endregion // PersonNameTitle collection

		#region PreferredName accessor methods
		public static int GetPreferredNameMinCount()
		{
			return 1;
		}

		public static int PreferredNameMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetPreferredNameMaxCount()
		{
			return 1;
		}

		public static int PreferredNameMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetPreferredNameCount()
		{
			return DomChildCount(NodeType.Element, "", "PreferredName");
		}

		public int PreferredNameCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "PreferredName");
			}
		}

		public bool HasPreferredName()
		{
			return HasDomChild(NodeType.Element, "", "PreferredName");
		}

		public PersonDescriptives2.PersonRequestedNameType NewPreferredName()
		{
			return new PersonDescriptives2.PersonRequestedNameType();
		}

		public PersonDescriptives2.PersonRequestedNameType GetPreferredNameAt(int index)
		{
			return new PersonDescriptives2.PersonRequestedNameType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "PreferredName", index)));
		}

		public XmlNode GetStartingPreferredNameCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "PreferredName" );
		}

		public XmlNode GetAdvancedPreferredNameCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "PreferredName", curNode );
		}

		public PersonDescriptives2.PersonRequestedNameType GetPreferredNameValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new PersonDescriptives2.PersonRequestedNameType( curNode.InnerText );
		}


		public PersonDescriptives2.PersonRequestedNameType GetPreferredName()
		{
			return GetPreferredNameAt(0);
		}

		public PersonDescriptives2.PersonRequestedNameType PreferredName
		{
			get
			{
				return GetPreferredNameAt(0);
			}
		}

		public void RemovePreferredNameAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "PreferredName", index);
		}

		public void RemovePreferredName()
		{
			RemovePreferredNameAt(0);
		}

		public XmlNode AddPreferredName(PersonDescriptives2.PersonRequestedNameType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "PreferredName", newValue.ToString());
			return null;
		}

		public void InsertPreferredNameAt(PersonDescriptives2.PersonRequestedNameType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "PreferredName", index, newValue.ToString());
		}

		public void ReplacePreferredNameAt(PersonDescriptives2.PersonRequestedNameType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "PreferredName", index, newValue.ToString());
		}
		#endregion // PreferredName accessor methods

		#region PreferredName collection
        public PreferredNameCollection	MyPreferredNames = new PreferredNameCollection( );

        public class PreferredNameCollection: IEnumerable
        {
            CitizenPreferredNameType parent;
            public CitizenPreferredNameType Parent
			{
				set
				{
					parent = value;
				}
			}
			public PreferredNameEnumerator GetEnumerator() 
			{
				return new PreferredNameEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class PreferredNameEnumerator: IEnumerator 
        {
			int nIndex;
			CitizenPreferredNameType parent;
			public PreferredNameEnumerator(CitizenPreferredNameType par) 
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
				return(nIndex < parent.PreferredNameCount );
			}
			public PersonDescriptives2.PersonRequestedNameType  Current 
			{
				get 
				{
					return(parent.GetPreferredNameAt(nIndex));
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

        #endregion // PreferredName collection

        private void SetCollectionParents()
        {
            MyPersonNameTitles.Parent = this; 
            MyPreferredNames.Parent = this; 
	}
}
}