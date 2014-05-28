//
// QueryDetailsType.cs
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

namespace SeoQueryUCRN_v0_1.core3
{
	public class QueryDetailsType : Altova.Xml.Node
	{
		#region Forward constructors

		public QueryDetailsType() : base() { SetCollectionParents(); }

		public QueryDetailsType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public QueryDetailsType(XmlNode node) : base(node) { SetCollectionParents(); }
		public QueryDetailsType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public QueryDetailsType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "QueryingOrganisationName" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "QueryingOrganisationName", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "ContactDetails" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "ContactDetails", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
				new AuditContactDetailsType(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "QueryNote" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "QueryNote", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "QueryDate" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "QueryDate", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "core:QueryDetailsType");
		}


		#region QueryingOrganisationName accessor methods
		public static int GetQueryingOrganisationNameMinCount()
		{
			return 1;
		}

		public static int QueryingOrganisationNameMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetQueryingOrganisationNameMaxCount()
		{
			return 1;
		}

		public static int QueryingOrganisationNameMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetQueryingOrganisationNameCount()
		{
			return DomChildCount(NodeType.Element, "", "QueryingOrganisationName");
		}

		public int QueryingOrganisationNameCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "QueryingOrganisationName");
			}
		}

		public bool HasQueryingOrganisationName()
		{
			return HasDomChild(NodeType.Element, "", "QueryingOrganisationName");
		}

		public OrganisationNameType NewQueryingOrganisationName()
		{
			return new OrganisationNameType();
		}

		public OrganisationNameType GetQueryingOrganisationNameAt(int index)
		{
			return new OrganisationNameType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "QueryingOrganisationName", index)));
		}

		public XmlNode GetStartingQueryingOrganisationNameCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "QueryingOrganisationName" );
		}

		public XmlNode GetAdvancedQueryingOrganisationNameCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "QueryingOrganisationName", curNode );
		}

		public OrganisationNameType GetQueryingOrganisationNameValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new OrganisationNameType( curNode.InnerText );
		}


		public OrganisationNameType GetQueryingOrganisationName()
		{
			return GetQueryingOrganisationNameAt(0);
		}

		public OrganisationNameType QueryingOrganisationName
		{
			get
			{
				return GetQueryingOrganisationNameAt(0);
			}
		}

		public void RemoveQueryingOrganisationNameAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "QueryingOrganisationName", index);
		}

		public void RemoveQueryingOrganisationName()
		{
			RemoveQueryingOrganisationNameAt(0);
		}

		public XmlNode AddQueryingOrganisationName(OrganisationNameType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "QueryingOrganisationName", newValue.ToString());
			return null;
		}

		public void InsertQueryingOrganisationNameAt(OrganisationNameType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "QueryingOrganisationName", index, newValue.ToString());
		}

		public void ReplaceQueryingOrganisationNameAt(OrganisationNameType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "QueryingOrganisationName", index, newValue.ToString());
		}
		#endregion // QueryingOrganisationName accessor methods

		#region QueryingOrganisationName collection
        public QueryingOrganisationNameCollection	MyQueryingOrganisationNames = new QueryingOrganisationNameCollection( );

        public class QueryingOrganisationNameCollection: IEnumerable
        {
            QueryDetailsType parent;
            public QueryDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public QueryingOrganisationNameEnumerator GetEnumerator() 
			{
				return new QueryingOrganisationNameEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class QueryingOrganisationNameEnumerator: IEnumerator 
        {
			int nIndex;
			QueryDetailsType parent;
			public QueryingOrganisationNameEnumerator(QueryDetailsType par) 
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
				return(nIndex < parent.QueryingOrganisationNameCount );
			}
			public OrganisationNameType  Current 
			{
				get 
				{
					return(parent.GetQueryingOrganisationNameAt(nIndex));
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

        #endregion // QueryingOrganisationName collection

		#region ContactDetails accessor methods
		public static int GetContactDetailsMinCount()
		{
			return 1;
		}

		public static int ContactDetailsMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetContactDetailsMaxCount()
		{
			return 1;
		}

		public static int ContactDetailsMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetContactDetailsCount()
		{
			return DomChildCount(NodeType.Element, "", "ContactDetails");
		}

		public int ContactDetailsCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "ContactDetails");
			}
		}

		public bool HasContactDetails()
		{
			return HasDomChild(NodeType.Element, "", "ContactDetails");
		}

		public AuditContactDetailsType NewContactDetails()
		{
			return new AuditContactDetailsType(domNode.OwnerDocument.CreateElement("ContactDetails", ""));
		}

		public AuditContactDetailsType GetContactDetailsAt(int index)
		{
			return new AuditContactDetailsType(GetDomChildAt(NodeType.Element, "", "ContactDetails", index));
		}

		public XmlNode GetStartingContactDetailsCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "ContactDetails" );
		}

		public XmlNode GetAdvancedContactDetailsCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "ContactDetails", curNode );
		}

		public AuditContactDetailsType GetContactDetailsValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new AuditContactDetailsType( curNode );
		}


		public AuditContactDetailsType GetContactDetails()
		{
			return GetContactDetailsAt(0);
		}

		public AuditContactDetailsType ContactDetails
		{
			get
			{
				return GetContactDetailsAt(0);
			}
		}

		public void RemoveContactDetailsAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "ContactDetails", index);
		}

		public void RemoveContactDetails()
		{
			RemoveContactDetailsAt(0);
		}

		public XmlNode AddContactDetails(AuditContactDetailsType newValue)
		{
			return AppendDomElement("", "ContactDetails", newValue);
		}

		public void InsertContactDetailsAt(AuditContactDetailsType newValue, int index)
		{
			InsertDomElementAt("", "ContactDetails", index, newValue);
		}

		public void ReplaceContactDetailsAt(AuditContactDetailsType newValue, int index)
		{
			ReplaceDomElementAt("", "ContactDetails", index, newValue);
		}
		#endregion // ContactDetails accessor methods

		#region ContactDetails collection
        public ContactDetailsCollection	MyContactDetailss = new ContactDetailsCollection( );

        public class ContactDetailsCollection: IEnumerable
        {
            QueryDetailsType parent;
            public QueryDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public ContactDetailsEnumerator GetEnumerator() 
			{
				return new ContactDetailsEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ContactDetailsEnumerator: IEnumerator 
        {
			int nIndex;
			QueryDetailsType parent;
			public ContactDetailsEnumerator(QueryDetailsType par) 
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
				return(nIndex < parent.ContactDetailsCount );
			}
			public AuditContactDetailsType  Current 
			{
				get 
				{
					return(parent.GetContactDetailsAt(nIndex));
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

        #endregion // ContactDetails collection

		#region QueryNote accessor methods
		public static int GetQueryNoteMinCount()
		{
			return 0;
		}

		public static int QueryNoteMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetQueryNoteMaxCount()
		{
			return 1;
		}

		public static int QueryNoteMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetQueryNoteCount()
		{
			return DomChildCount(NodeType.Element, "", "QueryNote");
		}

		public int QueryNoteCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "QueryNote");
			}
		}

		public bool HasQueryNote()
		{
			return HasDomChild(NodeType.Element, "", "QueryNote");
		}

		public QueryNoteType NewQueryNote()
		{
			return new QueryNoteType();
		}

		public QueryNoteType GetQueryNoteAt(int index)
		{
			return new QueryNoteType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "QueryNote", index)));
		}

		public XmlNode GetStartingQueryNoteCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "QueryNote" );
		}

		public XmlNode GetAdvancedQueryNoteCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "QueryNote", curNode );
		}

		public QueryNoteType GetQueryNoteValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new QueryNoteType( curNode.InnerText );
		}


		public QueryNoteType GetQueryNote()
		{
			return GetQueryNoteAt(0);
		}

		public QueryNoteType QueryNote
		{
			get
			{
				return GetQueryNoteAt(0);
			}
		}

		public void RemoveQueryNoteAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "QueryNote", index);
		}

		public void RemoveQueryNote()
		{
			RemoveQueryNoteAt(0);
		}

		public XmlNode AddQueryNote(QueryNoteType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "QueryNote", newValue.ToString());
			return null;
		}

		public void InsertQueryNoteAt(QueryNoteType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "QueryNote", index, newValue.ToString());
		}

		public void ReplaceQueryNoteAt(QueryNoteType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "QueryNote", index, newValue.ToString());
		}
		#endregion // QueryNote accessor methods

		#region QueryNote collection
        public QueryNoteCollection	MyQueryNotes = new QueryNoteCollection( );

        public class QueryNoteCollection: IEnumerable
        {
            QueryDetailsType parent;
            public QueryDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public QueryNoteEnumerator GetEnumerator() 
			{
				return new QueryNoteEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class QueryNoteEnumerator: IEnumerator 
        {
			int nIndex;
			QueryDetailsType parent;
			public QueryNoteEnumerator(QueryDetailsType par) 
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
				return(nIndex < parent.QueryNoteCount );
			}
			public QueryNoteType  Current 
			{
				get 
				{
					return(parent.GetQueryNoteAt(nIndex));
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

        #endregion // QueryNote collection

		#region QueryDate accessor methods
		public static int GetQueryDateMinCount()
		{
			return 1;
		}

		public static int QueryDateMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetQueryDateMaxCount()
		{
			return 1;
		}

		public static int QueryDateMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetQueryDateCount()
		{
			return DomChildCount(NodeType.Element, "", "QueryDate");
		}

		public int QueryDateCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "QueryDate");
			}
		}

		public bool HasQueryDate()
		{
			return HasDomChild(NodeType.Element, "", "QueryDate");
		}

		public SchemaDate NewQueryDate()
		{
			return new SchemaDate();
		}

		public SchemaDate GetQueryDateAt(int index)
		{
			return new SchemaDate(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "QueryDate", index)));
		}

		public XmlNode GetStartingQueryDateCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "QueryDate" );
		}

		public XmlNode GetAdvancedQueryDateCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "QueryDate", curNode );
		}

		public SchemaDate GetQueryDateValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaDate( curNode.InnerText );
		}


		public SchemaDate GetQueryDate()
		{
			return GetQueryDateAt(0);
		}

		public SchemaDate QueryDate
		{
			get
			{
				return GetQueryDateAt(0);
			}
		}

		public void RemoveQueryDateAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "QueryDate", index);
		}

		public void RemoveQueryDate()
		{
			RemoveQueryDateAt(0);
		}

		public XmlNode AddQueryDate(SchemaDate newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "QueryDate", newValue.ToString());
			return null;
		}

		public void InsertQueryDateAt(SchemaDate newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "QueryDate", index, newValue.ToString());
		}

		public void ReplaceQueryDateAt(SchemaDate newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "QueryDate", index, newValue.ToString());
		}
		#endregion // QueryDate accessor methods

		#region QueryDate collection
        public QueryDateCollection	MyQueryDates = new QueryDateCollection( );

        public class QueryDateCollection: IEnumerable
        {
            QueryDetailsType parent;
            public QueryDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public QueryDateEnumerator GetEnumerator() 
			{
				return new QueryDateEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class QueryDateEnumerator: IEnumerator 
        {
			int nIndex;
			QueryDetailsType parent;
			public QueryDateEnumerator(QueryDetailsType par) 
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
				return(nIndex < parent.QueryDateCount );
			}
			public SchemaDate  Current 
			{
				get 
				{
					return(parent.GetQueryDateAt(nIndex));
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

        #endregion // QueryDate collection

        private void SetCollectionParents()
        {
            MyQueryingOrganisationNames.Parent = this; 
            MyContactDetailss.Parent = this; 
            MyQueryNotes.Parent = this; 
            MyQueryDates.Parent = this; 
	}
}
}
