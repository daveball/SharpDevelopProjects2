//
// SimpleUKPhoneNumberType.cs
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
	public class SimpleUKPhoneNumberType : Altova.Xml.Node
	{
		#region Forward constructors

		public SimpleUKPhoneNumberType() : base() { SetCollectionParents(); }

		public SimpleUKPhoneNumberType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public SimpleUKPhoneNumberType(XmlNode node) : base(node) { SetCollectionParents(); }
		public SimpleUKPhoneNumberType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public SimpleUKPhoneNumberType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Attribute, "", "TelMobile" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Attribute, "", "TelMobile", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "TelNationalNumber" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "TelNationalNumber", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "TelExtensionNumber" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "TelExtensionNumber", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "core:SimpleUKPhoneNumberType");
		}


		#region TelMobile accessor methods
		public static int GetTelMobileMinCount()
		{
			return 0;
		}

		public static int TelMobileMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetTelMobileMaxCount()
		{
			return 1;
		}

		public static int TelMobileMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetTelMobileCount()
		{
			return DomChildCount(NodeType.Attribute, "", "TelMobile");
		}

		public int TelMobileCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "TelMobile");
			}
		}

		public bool HasTelMobile()
		{
			return HasDomChild(NodeType.Attribute, "", "TelMobile");
		}

		public core2.YesNoType NewTelMobile()
		{
			return new core2.YesNoType();
		}

		public core2.YesNoType GetTelMobileAt(int index)
		{
			return new core2.YesNoType(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "TelMobile", index)));
		}

		public XmlNode GetStartingTelMobileCursor()
		{
			return GetDomFirstChild( NodeType.Attribute, "", "TelMobile" );
		}

		public XmlNode GetAdvancedTelMobileCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Attribute, "", "TelMobile", curNode );
		}

		public core2.YesNoType GetTelMobileValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core2.YesNoType( curNode.Value );
		}


		public core2.YesNoType GetTelMobile()
		{
			return GetTelMobileAt(0);
		}

		public core2.YesNoType TelMobile
		{
			get
			{
				return GetTelMobileAt(0);
			}
		}

		public void RemoveTelMobileAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "TelMobile", index);
		}

		public void RemoveTelMobile()
		{
			RemoveTelMobileAt(0);
		}

		public XmlNode AddTelMobile(core2.YesNoType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Attribute, "", "TelMobile", newValue.ToString());
			return null;
		}

		public void InsertTelMobileAt(core2.YesNoType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Attribute, "", "TelMobile", index, newValue.ToString());
		}

		public void ReplaceTelMobileAt(core2.YesNoType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "TelMobile", index, newValue.ToString());
		}
		#endregion // TelMobile accessor methods

		#region TelMobile collection
        public TelMobileCollection	MyTelMobiles = new TelMobileCollection( );

        public class TelMobileCollection: IEnumerable
        {
            SimpleUKPhoneNumberType parent;
            public SimpleUKPhoneNumberType Parent
			{
				set
				{
					parent = value;
				}
			}
			public TelMobileEnumerator GetEnumerator() 
			{
				return new TelMobileEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class TelMobileEnumerator: IEnumerator 
        {
			int nIndex;
			SimpleUKPhoneNumberType parent;
			public TelMobileEnumerator(SimpleUKPhoneNumberType par) 
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
				return(nIndex < parent.TelMobileCount );
			}
			public core2.YesNoType  Current 
			{
				get 
				{
					return(parent.GetTelMobileAt(nIndex));
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

        #endregion // TelMobile collection

		#region TelNationalNumber accessor methods
		public static int GetTelNationalNumberMinCount()
		{
			return 1;
		}

		public static int TelNationalNumberMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetTelNationalNumberMaxCount()
		{
			return 1;
		}

		public static int TelNationalNumberMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetTelNationalNumberCount()
		{
			return DomChildCount(NodeType.Element, "", "TelNationalNumber");
		}

		public int TelNationalNumberCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "TelNationalNumber");
			}
		}

		public bool HasTelNationalNumber()
		{
			return HasDomChild(NodeType.Element, "", "TelNationalNumber");
		}

		public core2.TelephoneNumberType NewTelNationalNumber()
		{
			return new core2.TelephoneNumberType();
		}

		public core2.TelephoneNumberType GetTelNationalNumberAt(int index)
		{
			return new core2.TelephoneNumberType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "TelNationalNumber", index)));
		}

		public XmlNode GetStartingTelNationalNumberCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "TelNationalNumber" );
		}

		public XmlNode GetAdvancedTelNationalNumberCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "TelNationalNumber", curNode );
		}

		public core2.TelephoneNumberType GetTelNationalNumberValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core2.TelephoneNumberType( curNode.InnerText );
		}


		public core2.TelephoneNumberType GetTelNationalNumber()
		{
			return GetTelNationalNumberAt(0);
		}

		public core2.TelephoneNumberType TelNationalNumber
		{
			get
			{
				return GetTelNationalNumberAt(0);
			}
		}

		public void RemoveTelNationalNumberAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "TelNationalNumber", index);
		}

		public void RemoveTelNationalNumber()
		{
			RemoveTelNationalNumberAt(0);
		}

		public XmlNode AddTelNationalNumber(core2.TelephoneNumberType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "TelNationalNumber", newValue.ToString());
			return null;
		}

		public void InsertTelNationalNumberAt(core2.TelephoneNumberType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "TelNationalNumber", index, newValue.ToString());
		}

		public void ReplaceTelNationalNumberAt(core2.TelephoneNumberType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "TelNationalNumber", index, newValue.ToString());
		}
		#endregion // TelNationalNumber accessor methods

		#region TelNationalNumber collection
        public TelNationalNumberCollection	MyTelNationalNumbers = new TelNationalNumberCollection( );

        public class TelNationalNumberCollection: IEnumerable
        {
            SimpleUKPhoneNumberType parent;
            public SimpleUKPhoneNumberType Parent
			{
				set
				{
					parent = value;
				}
			}
			public TelNationalNumberEnumerator GetEnumerator() 
			{
				return new TelNationalNumberEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class TelNationalNumberEnumerator: IEnumerator 
        {
			int nIndex;
			SimpleUKPhoneNumberType parent;
			public TelNationalNumberEnumerator(SimpleUKPhoneNumberType par) 
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
				return(nIndex < parent.TelNationalNumberCount );
			}
			public core2.TelephoneNumberType  Current 
			{
				get 
				{
					return(parent.GetTelNationalNumberAt(nIndex));
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

        #endregion // TelNationalNumber collection

		#region TelExtensionNumber accessor methods
		public static int GetTelExtensionNumberMinCount()
		{
			return 0;
		}

		public static int TelExtensionNumberMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetTelExtensionNumberMaxCount()
		{
			return 1;
		}

		public static int TelExtensionNumberMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetTelExtensionNumberCount()
		{
			return DomChildCount(NodeType.Element, "", "TelExtensionNumber");
		}

		public int TelExtensionNumberCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "TelExtensionNumber");
			}
		}

		public bool HasTelExtensionNumber()
		{
			return HasDomChild(NodeType.Element, "", "TelExtensionNumber");
		}

		public core2.TelephoneExtensionType NewTelExtensionNumber()
		{
			return new core2.TelephoneExtensionType();
		}

		public core2.TelephoneExtensionType GetTelExtensionNumberAt(int index)
		{
			return new core2.TelephoneExtensionType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "TelExtensionNumber", index)));
		}

		public XmlNode GetStartingTelExtensionNumberCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "TelExtensionNumber" );
		}

		public XmlNode GetAdvancedTelExtensionNumberCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "TelExtensionNumber", curNode );
		}

		public core2.TelephoneExtensionType GetTelExtensionNumberValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core2.TelephoneExtensionType( curNode.InnerText );
		}


		public core2.TelephoneExtensionType GetTelExtensionNumber()
		{
			return GetTelExtensionNumberAt(0);
		}

		public core2.TelephoneExtensionType TelExtensionNumber
		{
			get
			{
				return GetTelExtensionNumberAt(0);
			}
		}

		public void RemoveTelExtensionNumberAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "TelExtensionNumber", index);
		}

		public void RemoveTelExtensionNumber()
		{
			RemoveTelExtensionNumberAt(0);
		}

		public XmlNode AddTelExtensionNumber(core2.TelephoneExtensionType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "TelExtensionNumber", newValue.ToString());
			return null;
		}

		public void InsertTelExtensionNumberAt(core2.TelephoneExtensionType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "TelExtensionNumber", index, newValue.ToString());
		}

		public void ReplaceTelExtensionNumberAt(core2.TelephoneExtensionType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "TelExtensionNumber", index, newValue.ToString());
		}
		#endregion // TelExtensionNumber accessor methods

		#region TelExtensionNumber collection
        public TelExtensionNumberCollection	MyTelExtensionNumbers = new TelExtensionNumberCollection( );

        public class TelExtensionNumberCollection: IEnumerable
        {
            SimpleUKPhoneNumberType parent;
            public SimpleUKPhoneNumberType Parent
			{
				set
				{
					parent = value;
				}
			}
			public TelExtensionNumberEnumerator GetEnumerator() 
			{
				return new TelExtensionNumberEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class TelExtensionNumberEnumerator: IEnumerator 
        {
			int nIndex;
			SimpleUKPhoneNumberType parent;
			public TelExtensionNumberEnumerator(SimpleUKPhoneNumberType par) 
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
				return(nIndex < parent.TelExtensionNumberCount );
			}
			public core2.TelephoneExtensionType  Current 
			{
				get 
				{
					return(parent.GetTelExtensionNumberAt(nIndex));
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

        #endregion // TelExtensionNumber collection

        private void SetCollectionParents()
        {
            MyTelMobiles.Parent = this; 
            MyTelNationalNumbers.Parent = this; 
            MyTelExtensionNumbers.Parent = this; 
	}
}
}
