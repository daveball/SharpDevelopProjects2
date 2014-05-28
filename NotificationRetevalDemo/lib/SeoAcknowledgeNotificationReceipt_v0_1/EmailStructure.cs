//
// EmailStructure.cs
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

namespace SeoAcknowledgeNotificationReceipt_v0_1.AddressAndPersonalDetails2
{
	public class EmailStructure : Altova.Xml.Node
	{
		#region Forward constructors

		public EmailStructure() : base() { SetCollectionParents(); }

		public EmailStructure(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public EmailStructure(XmlNode node) : base(node) { SetCollectionParents(); }
		public EmailStructure(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public EmailStructure(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Attribute, "", "EmailUsage" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Attribute, "", "EmailUsage", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Attribute, "", "EmailPreferred" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Attribute, "", "EmailPreferred", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "EmailAddress" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "EmailAddress", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "AddressAndPersonalDetails:EmailStructure");
		}


		#region EmailUsage accessor methods
		public static int GetEmailUsageMinCount()
		{
			return 0;
		}

		public static int EmailUsageMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetEmailUsageMaxCount()
		{
			return 1;
		}

		public static int EmailUsageMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetEmailUsageCount()
		{
			return DomChildCount(NodeType.Attribute, "", "EmailUsage");
		}

		public int EmailUsageCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "EmailUsage");
			}
		}

		public bool HasEmailUsage()
		{
			return HasDomChild(NodeType.Attribute, "", "EmailUsage");
		}

		public core2.WorkHomeType NewEmailUsage()
		{
			return new core2.WorkHomeType();
		}

		public core2.WorkHomeType GetEmailUsageAt(int index)
		{
			return new core2.WorkHomeType(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "EmailUsage", index)));
		}

		public XmlNode GetStartingEmailUsageCursor()
		{
			return GetDomFirstChild( NodeType.Attribute, "", "EmailUsage" );
		}

		public XmlNode GetAdvancedEmailUsageCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Attribute, "", "EmailUsage", curNode );
		}

		public core2.WorkHomeType GetEmailUsageValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core2.WorkHomeType( curNode.Value );
		}


		public core2.WorkHomeType GetEmailUsage()
		{
			return GetEmailUsageAt(0);
		}

		public core2.WorkHomeType EmailUsage
		{
			get
			{
				return GetEmailUsageAt(0);
			}
		}

		public void RemoveEmailUsageAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "EmailUsage", index);
		}

		public void RemoveEmailUsage()
		{
			RemoveEmailUsageAt(0);
		}

		public XmlNode AddEmailUsage(core2.WorkHomeType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Attribute, "", "EmailUsage", newValue.ToString());
			return null;
		}

		public void InsertEmailUsageAt(core2.WorkHomeType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Attribute, "", "EmailUsage", index, newValue.ToString());
		}

		public void ReplaceEmailUsageAt(core2.WorkHomeType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "EmailUsage", index, newValue.ToString());
		}
		#endregion // EmailUsage accessor methods

		#region EmailUsage collection
        public EmailUsageCollection	MyEmailUsages = new EmailUsageCollection( );

        public class EmailUsageCollection: IEnumerable
        {
            EmailStructure parent;
            public EmailStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public EmailUsageEnumerator GetEnumerator() 
			{
				return new EmailUsageEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class EmailUsageEnumerator: IEnumerator 
        {
			int nIndex;
			EmailStructure parent;
			public EmailUsageEnumerator(EmailStructure par) 
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
				return(nIndex < parent.EmailUsageCount );
			}
			public core2.WorkHomeType  Current 
			{
				get 
				{
					return(parent.GetEmailUsageAt(nIndex));
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

        #endregion // EmailUsage collection

		#region EmailPreferred accessor methods
		public static int GetEmailPreferredMinCount()
		{
			return 0;
		}

		public static int EmailPreferredMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetEmailPreferredMaxCount()
		{
			return 1;
		}

		public static int EmailPreferredMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetEmailPreferredCount()
		{
			return DomChildCount(NodeType.Attribute, "", "EmailPreferred");
		}

		public int EmailPreferredCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "EmailPreferred");
			}
		}

		public bool HasEmailPreferred()
		{
			return HasDomChild(NodeType.Attribute, "", "EmailPreferred");
		}

		public core2.YesNoType NewEmailPreferred()
		{
			return new core2.YesNoType();
		}

		public core2.YesNoType GetEmailPreferredAt(int index)
		{
			return new core2.YesNoType(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "EmailPreferred", index)));
		}

		public XmlNode GetStartingEmailPreferredCursor()
		{
			return GetDomFirstChild( NodeType.Attribute, "", "EmailPreferred" );
		}

		public XmlNode GetAdvancedEmailPreferredCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Attribute, "", "EmailPreferred", curNode );
		}

		public core2.YesNoType GetEmailPreferredValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core2.YesNoType( curNode.Value );
		}


		public core2.YesNoType GetEmailPreferred()
		{
			return GetEmailPreferredAt(0);
		}

		public core2.YesNoType EmailPreferred
		{
			get
			{
				return GetEmailPreferredAt(0);
			}
		}

		public void RemoveEmailPreferredAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "EmailPreferred", index);
		}

		public void RemoveEmailPreferred()
		{
			RemoveEmailPreferredAt(0);
		}

		public XmlNode AddEmailPreferred(core2.YesNoType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Attribute, "", "EmailPreferred", newValue.ToString());
			return null;
		}

		public void InsertEmailPreferredAt(core2.YesNoType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Attribute, "", "EmailPreferred", index, newValue.ToString());
		}

		public void ReplaceEmailPreferredAt(core2.YesNoType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "EmailPreferred", index, newValue.ToString());
		}
		#endregion // EmailPreferred accessor methods

		#region EmailPreferred collection
        public EmailPreferredCollection	MyEmailPreferreds = new EmailPreferredCollection( );

        public class EmailPreferredCollection: IEnumerable
        {
            EmailStructure parent;
            public EmailStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public EmailPreferredEnumerator GetEnumerator() 
			{
				return new EmailPreferredEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class EmailPreferredEnumerator: IEnumerator 
        {
			int nIndex;
			EmailStructure parent;
			public EmailPreferredEnumerator(EmailStructure par) 
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
				return(nIndex < parent.EmailPreferredCount );
			}
			public core2.YesNoType  Current 
			{
				get 
				{
					return(parent.GetEmailPreferredAt(nIndex));
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

        #endregion // EmailPreferred collection

		#region EmailAddress accessor methods
		public static int GetEmailAddressMinCount()
		{
			return 1;
		}

		public static int EmailAddressMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetEmailAddressMaxCount()
		{
			return 1;
		}

		public static int EmailAddressMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetEmailAddressCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "EmailAddress");
		}

		public int EmailAddressCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "EmailAddress");
			}
		}

		public bool HasEmailAddress()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "EmailAddress");
		}

		public core2.RestrictedStringType NewEmailAddress()
		{
			return new core2.RestrictedStringType();
		}

		public core2.RestrictedStringType GetEmailAddressAt(int index)
		{
			return new core2.RestrictedStringType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "EmailAddress", index)));
		}

		public XmlNode GetStartingEmailAddressCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "EmailAddress" );
		}

		public XmlNode GetAdvancedEmailAddressCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "EmailAddress", curNode );
		}

		public core2.RestrictedStringType GetEmailAddressValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core2.RestrictedStringType( curNode.InnerText );
		}


		public core2.RestrictedStringType GetEmailAddress()
		{
			return GetEmailAddressAt(0);
		}

		public core2.RestrictedStringType EmailAddress
		{
			get
			{
				return GetEmailAddressAt(0);
			}
		}

		public void RemoveEmailAddressAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "EmailAddress", index);
		}

		public void RemoveEmailAddress()
		{
			RemoveEmailAddressAt(0);
		}

		public XmlNode AddEmailAddress(core2.RestrictedStringType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "EmailAddress", newValue.ToString());
			return null;
		}

		public void InsertEmailAddressAt(core2.RestrictedStringType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "EmailAddress", index, newValue.ToString());
		}

		public void ReplaceEmailAddressAt(core2.RestrictedStringType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/AddressAndPersonalDetails", "EmailAddress", index, newValue.ToString());
		}
		#endregion // EmailAddress accessor methods

		#region EmailAddress collection
        public EmailAddressCollection	MyEmailAddresss = new EmailAddressCollection( );

        public class EmailAddressCollection: IEnumerable
        {
            EmailStructure parent;
            public EmailStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public EmailAddressEnumerator GetEnumerator() 
			{
				return new EmailAddressEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class EmailAddressEnumerator: IEnumerator 
        {
			int nIndex;
			EmailStructure parent;
			public EmailAddressEnumerator(EmailStructure par) 
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
				return(nIndex < parent.EmailAddressCount );
			}
			public core2.RestrictedStringType  Current 
			{
				get 
				{
					return(parent.GetEmailAddressAt(nIndex));
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

        #endregion // EmailAddress collection

        private void SetCollectionParents()
        {
            MyEmailUsages.Parent = this; 
            MyEmailPreferreds.Parent = this; 
            MyEmailAddresss.Parent = this; 
	}
}
}
