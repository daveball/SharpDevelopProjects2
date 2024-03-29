//
// ChangeAddressType.cs
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

namespace SeoListNotifications_v0_1.core3
{
	public class ChangeAddressType : Altova.Xml.Node
	{
		#region Forward constructors

		public ChangeAddressType() : base() { SetCollectionParents(); }

		public ChangeAddressType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public ChangeAddressType(XmlNode node) : base(node) { SetCollectionParents(); }
		public ChangeAddressType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public ChangeAddressType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
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

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "CASCitizenGUID" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "CASCitizenGUID", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "PreviousProperty" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "PreviousProperty", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
				new PreviousPropertyType(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "NewProperty" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "NewProperty", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
				new NewPropertyType(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "RequestedDate" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "RequestedDate", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "EffectiveDate" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "EffectiveDate", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "core:ChangeAddressType");
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
            ChangeAddressType parent;
            public ChangeAddressType Parent
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
			ChangeAddressType parent;
			public UCRNEnumerator(ChangeAddressType par) 
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

		#region CASCitizenGUID accessor methods
		public static int GetCASCitizenGUIDMinCount()
		{
			return 1;
		}

		public static int CASCitizenGUIDMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetCASCitizenGUIDMaxCount()
		{
			return 1;
		}

		public static int CASCitizenGUIDMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetCASCitizenGUIDCount()
		{
			return DomChildCount(NodeType.Element, "", "CASCitizenGUID");
		}

		public int CASCitizenGUIDCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "CASCitizenGUID");
			}
		}

		public bool HasCASCitizenGUID()
		{
			return HasDomChild(NodeType.Element, "", "CASCitizenGUID");
		}

		public CitizenGUIDType NewCASCitizenGUID()
		{
			return new CitizenGUIDType();
		}

		public CitizenGUIDType GetCASCitizenGUIDAt(int index)
		{
			return new CitizenGUIDType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "CASCitizenGUID", index)));
		}

		public XmlNode GetStartingCASCitizenGUIDCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "CASCitizenGUID" );
		}

		public XmlNode GetAdvancedCASCitizenGUIDCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "CASCitizenGUID", curNode );
		}

		public CitizenGUIDType GetCASCitizenGUIDValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new CitizenGUIDType( curNode.InnerText );
		}


		public CitizenGUIDType GetCASCitizenGUID()
		{
			return GetCASCitizenGUIDAt(0);
		}

		public CitizenGUIDType CASCitizenGUID
		{
			get
			{
				return GetCASCitizenGUIDAt(0);
			}
		}

		public void RemoveCASCitizenGUIDAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "CASCitizenGUID", index);
		}

		public void RemoveCASCitizenGUID()
		{
			RemoveCASCitizenGUIDAt(0);
		}

		public XmlNode AddCASCitizenGUID(CitizenGUIDType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "CASCitizenGUID", newValue.ToString());
			return null;
		}

		public void InsertCASCitizenGUIDAt(CitizenGUIDType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "CASCitizenGUID", index, newValue.ToString());
		}

		public void ReplaceCASCitizenGUIDAt(CitizenGUIDType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "CASCitizenGUID", index, newValue.ToString());
		}
		#endregion // CASCitizenGUID accessor methods

		#region CASCitizenGUID collection
        public CASCitizenGUIDCollection	MyCASCitizenGUIDs = new CASCitizenGUIDCollection( );

        public class CASCitizenGUIDCollection: IEnumerable
        {
            ChangeAddressType parent;
            public ChangeAddressType Parent
			{
				set
				{
					parent = value;
				}
			}
			public CASCitizenGUIDEnumerator GetEnumerator() 
			{
				return new CASCitizenGUIDEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class CASCitizenGUIDEnumerator: IEnumerator 
        {
			int nIndex;
			ChangeAddressType parent;
			public CASCitizenGUIDEnumerator(ChangeAddressType par) 
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
				return(nIndex < parent.CASCitizenGUIDCount );
			}
			public CitizenGUIDType  Current 
			{
				get 
				{
					return(parent.GetCASCitizenGUIDAt(nIndex));
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

        #endregion // CASCitizenGUID collection

		#region PreviousProperty accessor methods
		public static int GetPreviousPropertyMinCount()
		{
			return 1;
		}

		public static int PreviousPropertyMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetPreviousPropertyMaxCount()
		{
			return 1;
		}

		public static int PreviousPropertyMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetPreviousPropertyCount()
		{
			return DomChildCount(NodeType.Element, "", "PreviousProperty");
		}

		public int PreviousPropertyCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "PreviousProperty");
			}
		}

		public bool HasPreviousProperty()
		{
			return HasDomChild(NodeType.Element, "", "PreviousProperty");
		}

		public PreviousPropertyType NewPreviousProperty()
		{
			return new PreviousPropertyType(domNode.OwnerDocument.CreateElement("PreviousProperty", ""));
		}

		public PreviousPropertyType GetPreviousPropertyAt(int index)
		{
			return new PreviousPropertyType(GetDomChildAt(NodeType.Element, "", "PreviousProperty", index));
		}

		public XmlNode GetStartingPreviousPropertyCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "PreviousProperty" );
		}

		public XmlNode GetAdvancedPreviousPropertyCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "PreviousProperty", curNode );
		}

		public PreviousPropertyType GetPreviousPropertyValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new PreviousPropertyType( curNode );
		}


		public PreviousPropertyType GetPreviousProperty()
		{
			return GetPreviousPropertyAt(0);
		}

		public PreviousPropertyType PreviousProperty
		{
			get
			{
				return GetPreviousPropertyAt(0);
			}
		}

		public void RemovePreviousPropertyAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "PreviousProperty", index);
		}

		public void RemovePreviousProperty()
		{
			RemovePreviousPropertyAt(0);
		}

		public XmlNode AddPreviousProperty(PreviousPropertyType newValue)
		{
			return AppendDomElement("", "PreviousProperty", newValue);
		}

		public void InsertPreviousPropertyAt(PreviousPropertyType newValue, int index)
		{
			InsertDomElementAt("", "PreviousProperty", index, newValue);
		}

		public void ReplacePreviousPropertyAt(PreviousPropertyType newValue, int index)
		{
			ReplaceDomElementAt("", "PreviousProperty", index, newValue);
		}
		#endregion // PreviousProperty accessor methods

		#region PreviousProperty collection
        public PreviousPropertyCollection	MyPreviousPropertys = new PreviousPropertyCollection( );

        public class PreviousPropertyCollection: IEnumerable
        {
            ChangeAddressType parent;
            public ChangeAddressType Parent
			{
				set
				{
					parent = value;
				}
			}
			public PreviousPropertyEnumerator GetEnumerator() 
			{
				return new PreviousPropertyEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class PreviousPropertyEnumerator: IEnumerator 
        {
			int nIndex;
			ChangeAddressType parent;
			public PreviousPropertyEnumerator(ChangeAddressType par) 
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
				return(nIndex < parent.PreviousPropertyCount );
			}
			public PreviousPropertyType  Current 
			{
				get 
				{
					return(parent.GetPreviousPropertyAt(nIndex));
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

        #endregion // PreviousProperty collection

		#region NewProperty accessor methods
		public static int GetNewPropertyMinCount()
		{
			return 1;
		}

		public static int NewPropertyMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetNewPropertyMaxCount()
		{
			return 1;
		}

		public static int NewPropertyMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetNewPropertyCount()
		{
			return DomChildCount(NodeType.Element, "", "NewProperty");
		}

		public int NewPropertyCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "NewProperty");
			}
		}

		public bool HasNewProperty()
		{
			return HasDomChild(NodeType.Element, "", "NewProperty");
		}

		public NewPropertyType NewNewProperty()
		{
			return new NewPropertyType(domNode.OwnerDocument.CreateElement("NewProperty", ""));
		}

		public NewPropertyType GetNewPropertyAt(int index)
		{
			return new NewPropertyType(GetDomChildAt(NodeType.Element, "", "NewProperty", index));
		}

		public XmlNode GetStartingNewPropertyCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "NewProperty" );
		}

		public XmlNode GetAdvancedNewPropertyCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "NewProperty", curNode );
		}

		public NewPropertyType GetNewPropertyValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new NewPropertyType( curNode );
		}


		public NewPropertyType GetNewProperty()
		{
			return GetNewPropertyAt(0);
		}

		public NewPropertyType NewProperty
		{
			get
			{
				return GetNewPropertyAt(0);
			}
		}

		public void RemoveNewPropertyAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "NewProperty", index);
		}

		public void RemoveNewProperty()
		{
			RemoveNewPropertyAt(0);
		}

		public XmlNode AddNewProperty(NewPropertyType newValue)
		{
			return AppendDomElement("", "NewProperty", newValue);
		}

		public void InsertNewPropertyAt(NewPropertyType newValue, int index)
		{
			InsertDomElementAt("", "NewProperty", index, newValue);
		}

		public void ReplaceNewPropertyAt(NewPropertyType newValue, int index)
		{
			ReplaceDomElementAt("", "NewProperty", index, newValue);
		}
		#endregion // NewProperty accessor methods

		#region NewProperty collection
        public NewPropertyCollection	MyNewPropertys = new NewPropertyCollection( );

        public class NewPropertyCollection: IEnumerable
        {
            ChangeAddressType parent;
            public ChangeAddressType Parent
			{
				set
				{
					parent = value;
				}
			}
			public NewPropertyEnumerator GetEnumerator() 
			{
				return new NewPropertyEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class NewPropertyEnumerator: IEnumerator 
        {
			int nIndex;
			ChangeAddressType parent;
			public NewPropertyEnumerator(ChangeAddressType par) 
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
				return(nIndex < parent.NewPropertyCount );
			}
			public NewPropertyType  Current 
			{
				get 
				{
					return(parent.GetNewPropertyAt(nIndex));
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

        #endregion // NewProperty collection

		#region RequestedDate accessor methods
		public static int GetRequestedDateMinCount()
		{
			return 1;
		}

		public static int RequestedDateMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetRequestedDateMaxCount()
		{
			return 1;
		}

		public static int RequestedDateMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetRequestedDateCount()
		{
			return DomChildCount(NodeType.Element, "", "RequestedDate");
		}

		public int RequestedDateCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "RequestedDate");
			}
		}

		public bool HasRequestedDate()
		{
			return HasDomChild(NodeType.Element, "", "RequestedDate");
		}

		public SchemaDate NewRequestedDate()
		{
			return new SchemaDate();
		}

		public SchemaDate GetRequestedDateAt(int index)
		{
			return new SchemaDate(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "RequestedDate", index)));
		}

		public XmlNode GetStartingRequestedDateCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "RequestedDate" );
		}

		public XmlNode GetAdvancedRequestedDateCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "RequestedDate", curNode );
		}

		public SchemaDate GetRequestedDateValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaDate( curNode.InnerText );
		}


		public SchemaDate GetRequestedDate()
		{
			return GetRequestedDateAt(0);
		}

		public SchemaDate RequestedDate
		{
			get
			{
				return GetRequestedDateAt(0);
			}
		}

		public void RemoveRequestedDateAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "RequestedDate", index);
		}

		public void RemoveRequestedDate()
		{
			RemoveRequestedDateAt(0);
		}

		public XmlNode AddRequestedDate(SchemaDate newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "RequestedDate", newValue.ToString());
			return null;
		}

		public void InsertRequestedDateAt(SchemaDate newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "RequestedDate", index, newValue.ToString());
		}

		public void ReplaceRequestedDateAt(SchemaDate newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "RequestedDate", index, newValue.ToString());
		}
		#endregion // RequestedDate accessor methods

		#region RequestedDate collection
        public RequestedDateCollection	MyRequestedDates = new RequestedDateCollection( );

        public class RequestedDateCollection: IEnumerable
        {
            ChangeAddressType parent;
            public ChangeAddressType Parent
			{
				set
				{
					parent = value;
				}
			}
			public RequestedDateEnumerator GetEnumerator() 
			{
				return new RequestedDateEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class RequestedDateEnumerator: IEnumerator 
        {
			int nIndex;
			ChangeAddressType parent;
			public RequestedDateEnumerator(ChangeAddressType par) 
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
				return(nIndex < parent.RequestedDateCount );
			}
			public SchemaDate  Current 
			{
				get 
				{
					return(parent.GetRequestedDateAt(nIndex));
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

        #endregion // RequestedDate collection

		#region EffectiveDate accessor methods
		public static int GetEffectiveDateMinCount()
		{
			return 1;
		}

		public static int EffectiveDateMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetEffectiveDateMaxCount()
		{
			return 1;
		}

		public static int EffectiveDateMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetEffectiveDateCount()
		{
			return DomChildCount(NodeType.Element, "", "EffectiveDate");
		}

		public int EffectiveDateCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "EffectiveDate");
			}
		}

		public bool HasEffectiveDate()
		{
			return HasDomChild(NodeType.Element, "", "EffectiveDate");
		}

		public SchemaDate NewEffectiveDate()
		{
			return new SchemaDate();
		}

		public SchemaDate GetEffectiveDateAt(int index)
		{
			return new SchemaDate(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "EffectiveDate", index)));
		}

		public XmlNode GetStartingEffectiveDateCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "EffectiveDate" );
		}

		public XmlNode GetAdvancedEffectiveDateCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "EffectiveDate", curNode );
		}

		public SchemaDate GetEffectiveDateValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaDate( curNode.InnerText );
		}


		public SchemaDate GetEffectiveDate()
		{
			return GetEffectiveDateAt(0);
		}

		public SchemaDate EffectiveDate
		{
			get
			{
				return GetEffectiveDateAt(0);
			}
		}

		public void RemoveEffectiveDateAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "EffectiveDate", index);
		}

		public void RemoveEffectiveDate()
		{
			RemoveEffectiveDateAt(0);
		}

		public XmlNode AddEffectiveDate(SchemaDate newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "EffectiveDate", newValue.ToString());
			return null;
		}

		public void InsertEffectiveDateAt(SchemaDate newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "EffectiveDate", index, newValue.ToString());
		}

		public void ReplaceEffectiveDateAt(SchemaDate newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "EffectiveDate", index, newValue.ToString());
		}
		#endregion // EffectiveDate accessor methods

		#region EffectiveDate collection
        public EffectiveDateCollection	MyEffectiveDates = new EffectiveDateCollection( );

        public class EffectiveDateCollection: IEnumerable
        {
            ChangeAddressType parent;
            public ChangeAddressType Parent
			{
				set
				{
					parent = value;
				}
			}
			public EffectiveDateEnumerator GetEnumerator() 
			{
				return new EffectiveDateEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class EffectiveDateEnumerator: IEnumerator 
        {
			int nIndex;
			ChangeAddressType parent;
			public EffectiveDateEnumerator(ChangeAddressType par) 
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
				return(nIndex < parent.EffectiveDateCount );
			}
			public SchemaDate  Current 
			{
				get 
				{
					return(parent.GetEffectiveDateAt(nIndex));
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

        #endregion // EffectiveDate collection

        private void SetCollectionParents()
        {
            MyUCRNs.Parent = this; 
            MyCASCitizenGUIDs.Parent = this; 
            MyPreviousPropertys.Parent = this; 
            MyNewPropertys.Parent = this; 
            MyRequestedDates.Parent = this; 
            MyEffectiveDates.Parent = this; 
	}
}
}
