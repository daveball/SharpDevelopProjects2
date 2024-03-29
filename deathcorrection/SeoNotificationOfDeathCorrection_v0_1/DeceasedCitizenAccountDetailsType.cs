//
// DeceasedCitizenAccountDetailsType.cs
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
	public class DeceasedCitizenAccountDetailsType : Altova.Xml.Node
	{
		#region Forward constructors

		public DeceasedCitizenAccountDetailsType() : base() { SetCollectionParents(); }

		public DeceasedCitizenAccountDetailsType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public DeceasedCitizenAccountDetailsType(XmlNode node) : base(node) { SetCollectionParents(); }
		public DeceasedCitizenAccountDetailsType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public DeceasedCitizenAccountDetailsType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "UCRN" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "UCRN", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "DateOfDeath" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "DateOfDeath", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
				new PersonDescriptives2.PersonDeathDateStructure(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "CreatedBy" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "CreatedBy", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
				new PersonDescriptives2.PersonNameStructure(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "CreatedDate" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "CreatedDate", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "core:DeceasedCitizenAccountDetailsType");
		}


		#region UCRN accessor methods
		public static int GetUCRNMinCount()
		{
			return 1;
		}

		public static int UCRNMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetUCRNMaxCount()
		{
			return 1;
		}

		public static int UCRNMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetUCRNCount()
		{
			return DomChildCount(NodeType.Element, "", "UCRN");
		}

		public int UCRNCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "UCRN");
			}
		}

		public bool HasUCRN()
		{
			return HasDomChild(NodeType.Element, "", "UCRN");
		}

		public UCRNType NewUCRN()
		{
			return new UCRNType();
		}

		public UCRNType GetUCRNAt(int index)
		{
			return new UCRNType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "UCRN", index)));
		}

		public XmlNode GetStartingUCRNCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "UCRN" );
		}

		public XmlNode GetAdvancedUCRNCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "UCRN", curNode );
		}

		public UCRNType GetUCRNValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new UCRNType( curNode.InnerText );
		}


		public UCRNType GetUCRN()
		{
			return GetUCRNAt(0);
		}

		public UCRNType UCRN
		{
			get
			{
				return GetUCRNAt(0);
			}
		}

		public void RemoveUCRNAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "UCRN", index);
		}

		public void RemoveUCRN()
		{
			RemoveUCRNAt(0);
		}

		public XmlNode AddUCRN(UCRNType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "UCRN", newValue.ToString());
			return null;
		}

		public void InsertUCRNAt(UCRNType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "UCRN", index, newValue.ToString());
		}

		public void ReplaceUCRNAt(UCRNType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "UCRN", index, newValue.ToString());
		}
		#endregion // UCRN accessor methods

		#region UCRN collection
        public UCRNCollection	MyUCRNs = new UCRNCollection( );

        public class UCRNCollection: IEnumerable
        {
            DeceasedCitizenAccountDetailsType parent;
            public DeceasedCitizenAccountDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public UCRNEnumerator GetEnumerator() 
			{
				return new UCRNEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class UCRNEnumerator: IEnumerator 
        {
			int nIndex;
			DeceasedCitizenAccountDetailsType parent;
			public UCRNEnumerator(DeceasedCitizenAccountDetailsType par) 
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
				return(nIndex < parent.UCRNCount );
			}
			public UCRNType  Current 
			{
				get 
				{
					return(parent.GetUCRNAt(nIndex));
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

        #endregion // UCRN collection

		#region DateOfDeath accessor methods
		public static int GetDateOfDeathMinCount()
		{
			return 1;
		}

		public static int DateOfDeathMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetDateOfDeathMaxCount()
		{
			return 1;
		}

		public static int DateOfDeathMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetDateOfDeathCount()
		{
			return DomChildCount(NodeType.Element, "", "DateOfDeath");
		}

		public int DateOfDeathCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "DateOfDeath");
			}
		}

		public bool HasDateOfDeath()
		{
			return HasDomChild(NodeType.Element, "", "DateOfDeath");
		}

		public PersonDescriptives2.PersonDeathDateStructure NewDateOfDeath()
		{
			return new PersonDescriptives2.PersonDeathDateStructure(domNode.OwnerDocument.CreateElement("DateOfDeath", ""));
		}

		public PersonDescriptives2.PersonDeathDateStructure GetDateOfDeathAt(int index)
		{
			return new PersonDescriptives2.PersonDeathDateStructure(GetDomChildAt(NodeType.Element, "", "DateOfDeath", index));
		}

		public XmlNode GetStartingDateOfDeathCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "DateOfDeath" );
		}

		public XmlNode GetAdvancedDateOfDeathCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "DateOfDeath", curNode );
		}

		public PersonDescriptives2.PersonDeathDateStructure GetDateOfDeathValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new PersonDescriptives2.PersonDeathDateStructure( curNode );
		}


		public PersonDescriptives2.PersonDeathDateStructure GetDateOfDeath()
		{
			return GetDateOfDeathAt(0);
		}

		public PersonDescriptives2.PersonDeathDateStructure DateOfDeath
		{
			get
			{
				return GetDateOfDeathAt(0);
			}
		}

		public void RemoveDateOfDeathAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "DateOfDeath", index);
		}

		public void RemoveDateOfDeath()
		{
			RemoveDateOfDeathAt(0);
		}

		public XmlNode AddDateOfDeath(PersonDescriptives2.PersonDeathDateStructure newValue)
		{
			return AppendDomElement("", "DateOfDeath", newValue);
		}

		public void InsertDateOfDeathAt(PersonDescriptives2.PersonDeathDateStructure newValue, int index)
		{
			InsertDomElementAt("", "DateOfDeath", index, newValue);
		}

		public void ReplaceDateOfDeathAt(PersonDescriptives2.PersonDeathDateStructure newValue, int index)
		{
			ReplaceDomElementAt("", "DateOfDeath", index, newValue);
		}
		#endregion // DateOfDeath accessor methods

		#region DateOfDeath collection
        public DateOfDeathCollection	MyDateOfDeaths = new DateOfDeathCollection( );

        public class DateOfDeathCollection: IEnumerable
        {
            DeceasedCitizenAccountDetailsType parent;
            public DeceasedCitizenAccountDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public DateOfDeathEnumerator GetEnumerator() 
			{
				return new DateOfDeathEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class DateOfDeathEnumerator: IEnumerator 
        {
			int nIndex;
			DeceasedCitizenAccountDetailsType parent;
			public DateOfDeathEnumerator(DeceasedCitizenAccountDetailsType par) 
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
				return(nIndex < parent.DateOfDeathCount );
			}
			public PersonDescriptives2.PersonDeathDateStructure  Current 
			{
				get 
				{
					return(parent.GetDateOfDeathAt(nIndex));
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

        #endregion // DateOfDeath collection

		#region CreatedBy accessor methods
		public static int GetCreatedByMinCount()
		{
			return 1;
		}

		public static int CreatedByMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetCreatedByMaxCount()
		{
			return 1;
		}

		public static int CreatedByMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetCreatedByCount()
		{
			return DomChildCount(NodeType.Element, "", "CreatedBy");
		}

		public int CreatedByCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "CreatedBy");
			}
		}

		public bool HasCreatedBy()
		{
			return HasDomChild(NodeType.Element, "", "CreatedBy");
		}

		public PersonDescriptives2.PersonNameStructure NewCreatedBy()
		{
			return new PersonDescriptives2.PersonNameStructure(domNode.OwnerDocument.CreateElement("CreatedBy", ""));
		}

		public PersonDescriptives2.PersonNameStructure GetCreatedByAt(int index)
		{
			return new PersonDescriptives2.PersonNameStructure(GetDomChildAt(NodeType.Element, "", "CreatedBy", index));
		}

		public XmlNode GetStartingCreatedByCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "CreatedBy" );
		}

		public XmlNode GetAdvancedCreatedByCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "CreatedBy", curNode );
		}

		public PersonDescriptives2.PersonNameStructure GetCreatedByValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new PersonDescriptives2.PersonNameStructure( curNode );
		}


		public PersonDescriptives2.PersonNameStructure GetCreatedBy()
		{
			return GetCreatedByAt(0);
		}

		public PersonDescriptives2.PersonNameStructure CreatedBy
		{
			get
			{
				return GetCreatedByAt(0);
			}
		}

		public void RemoveCreatedByAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "CreatedBy", index);
		}

		public void RemoveCreatedBy()
		{
			RemoveCreatedByAt(0);
		}

		public XmlNode AddCreatedBy(PersonDescriptives2.PersonNameStructure newValue)
		{
			return AppendDomElement("", "CreatedBy", newValue);
		}

		public void InsertCreatedByAt(PersonDescriptives2.PersonNameStructure newValue, int index)
		{
			InsertDomElementAt("", "CreatedBy", index, newValue);
		}

		public void ReplaceCreatedByAt(PersonDescriptives2.PersonNameStructure newValue, int index)
		{
			ReplaceDomElementAt("", "CreatedBy", index, newValue);
		}
		#endregion // CreatedBy accessor methods

		#region CreatedBy collection
        public CreatedByCollection	MyCreatedBys = new CreatedByCollection( );

        public class CreatedByCollection: IEnumerable
        {
            DeceasedCitizenAccountDetailsType parent;
            public DeceasedCitizenAccountDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public CreatedByEnumerator GetEnumerator() 
			{
				return new CreatedByEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class CreatedByEnumerator: IEnumerator 
        {
			int nIndex;
			DeceasedCitizenAccountDetailsType parent;
			public CreatedByEnumerator(DeceasedCitizenAccountDetailsType par) 
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
				return(nIndex < parent.CreatedByCount );
			}
			public PersonDescriptives2.PersonNameStructure  Current 
			{
				get 
				{
					return(parent.GetCreatedByAt(nIndex));
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

        #endregion // CreatedBy collection

		#region CreatedDate accessor methods
		public static int GetCreatedDateMinCount()
		{
			return 1;
		}

		public static int CreatedDateMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetCreatedDateMaxCount()
		{
			return 1;
		}

		public static int CreatedDateMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetCreatedDateCount()
		{
			return DomChildCount(NodeType.Element, "", "CreatedDate");
		}

		public int CreatedDateCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "CreatedDate");
			}
		}

		public bool HasCreatedDate()
		{
			return HasDomChild(NodeType.Element, "", "CreatedDate");
		}

		public SchemaDateTime NewCreatedDate()
		{
			return new SchemaDateTime();
		}

		public SchemaDateTime GetCreatedDateAt(int index)
		{
			return new SchemaDateTime(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "CreatedDate", index)));
		}

		public XmlNode GetStartingCreatedDateCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "CreatedDate" );
		}

		public XmlNode GetAdvancedCreatedDateCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "CreatedDate", curNode );
		}

		public SchemaDateTime GetCreatedDateValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaDateTime( curNode.InnerText );
		}


		public SchemaDateTime GetCreatedDate()
		{
			return GetCreatedDateAt(0);
		}

		public SchemaDateTime CreatedDate
		{
			get
			{
				return GetCreatedDateAt(0);
			}
		}

		public void RemoveCreatedDateAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "CreatedDate", index);
		}

		public void RemoveCreatedDate()
		{
			RemoveCreatedDateAt(0);
		}

		public XmlNode AddCreatedDate(SchemaDateTime newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "CreatedDate", newValue.ToString());
			return null;
		}

		public void InsertCreatedDateAt(SchemaDateTime newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "CreatedDate", index, newValue.ToString());
		}

		public void ReplaceCreatedDateAt(SchemaDateTime newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "CreatedDate", index, newValue.ToString());
		}
		#endregion // CreatedDate accessor methods

		#region CreatedDate collection
        public CreatedDateCollection	MyCreatedDates = new CreatedDateCollection( );

        public class CreatedDateCollection: IEnumerable
        {
            DeceasedCitizenAccountDetailsType parent;
            public DeceasedCitizenAccountDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public CreatedDateEnumerator GetEnumerator() 
			{
				return new CreatedDateEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class CreatedDateEnumerator: IEnumerator 
        {
			int nIndex;
			DeceasedCitizenAccountDetailsType parent;
			public CreatedDateEnumerator(DeceasedCitizenAccountDetailsType par) 
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
				return(nIndex < parent.CreatedDateCount );
			}
			public SchemaDateTime  Current 
			{
				get 
				{
					return(parent.GetCreatedDateAt(nIndex));
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

        #endregion // CreatedDate collection

        private void SetCollectionParents()
        {
            MyUCRNs.Parent = this; 
            MyDateOfDeaths.Parent = this; 
            MyCreatedBys.Parent = this; 
            MyCreatedDates.Parent = this; 
	}
}
}
