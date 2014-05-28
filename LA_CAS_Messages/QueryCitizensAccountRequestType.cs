//
// QueryCitizensAccountRequestType.cs
//
// This file was generated by XMLSpy 2011r3sp1 Enterprise Edition.
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

namespace LA_CAS_Messages
{
	public class QueryCitizensAccountRequestType : Altova.Xml.Node
	{
		#region Forward constructors

		public QueryCitizensAccountRequestType() : base() { SetCollectionParents(); }

		public QueryCitizensAccountRequestType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public QueryCitizensAccountRequestType(XmlNode node) : base(node) { SetCollectionParents(); }
		public QueryCitizensAccountRequestType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public QueryCitizensAccountRequestType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
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

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "NECNumber" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "NECNumber", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "UserID" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "UserID", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "CitizenDetails" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "CitizenDetails", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
				new core3.CitizenSearchDetailsType(DOMNode).AdjustPrefix();
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "QueryCitizensAccountRequest");
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

		public core3.UCRNType NewUCRN()
		{
			return new core3.UCRNType();
		}

		public core3.UCRNType GetUCRNAt(int index)
		{
			return new core3.UCRNType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "UCRN", index)));
		}

		public XmlNode GetStartingUCRNCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "UCRN" );
		}

		public XmlNode GetAdvancedUCRNCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "UCRN", curNode );
		}

		public core3.UCRNType GetUCRNValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core3.UCRNType( curNode.InnerText );
		}


		public core3.UCRNType GetUCRN()
		{
			return GetUCRNAt(0);
		}

		public core3.UCRNType UCRN
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

		public XmlNode AddUCRN(core3.UCRNType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "UCRN", newValue.ToString());
			return null;
		}

		public void InsertUCRNAt(core3.UCRNType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "UCRN", index, newValue.ToString());
		}

		public void ReplaceUCRNAt(core3.UCRNType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "UCRN", index, newValue.ToString());
		}
		#endregion // UCRN accessor methods

		#region UCRN collection
        public UCRNCollection	MyUCRNs = new UCRNCollection( );

        public class UCRNCollection: IEnumerable
        {
            QueryCitizensAccountRequestType parent;
            public QueryCitizensAccountRequestType Parent
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
			QueryCitizensAccountRequestType parent;
			public UCRNEnumerator(QueryCitizensAccountRequestType par) 
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
			public core3.UCRNType  Current 
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

		public core3.CitizenGUIDType NewCASCitizenGUID()
		{
			return new core3.CitizenGUIDType();
		}

		public core3.CitizenGUIDType GetCASCitizenGUIDAt(int index)
		{
			return new core3.CitizenGUIDType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "CASCitizenGUID", index)));
		}

		public XmlNode GetStartingCASCitizenGUIDCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "CASCitizenGUID" );
		}

		public XmlNode GetAdvancedCASCitizenGUIDCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "CASCitizenGUID", curNode );
		}

		public core3.CitizenGUIDType GetCASCitizenGUIDValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core3.CitizenGUIDType( curNode.InnerText );
		}


		public core3.CitizenGUIDType GetCASCitizenGUID()
		{
			return GetCASCitizenGUIDAt(0);
		}

		public core3.CitizenGUIDType CASCitizenGUID
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

		public XmlNode AddCASCitizenGUID(core3.CitizenGUIDType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "CASCitizenGUID", newValue.ToString());
			return null;
		}

		public void InsertCASCitizenGUIDAt(core3.CitizenGUIDType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "CASCitizenGUID", index, newValue.ToString());
		}

		public void ReplaceCASCitizenGUIDAt(core3.CitizenGUIDType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "CASCitizenGUID", index, newValue.ToString());
		}
		#endregion // CASCitizenGUID accessor methods

		#region CASCitizenGUID collection
        public CASCitizenGUIDCollection	MyCASCitizenGUIDs = new CASCitizenGUIDCollection( );

        public class CASCitizenGUIDCollection: IEnumerable
        {
            QueryCitizensAccountRequestType parent;
            public QueryCitizensAccountRequestType Parent
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
			QueryCitizensAccountRequestType parent;
			public CASCitizenGUIDEnumerator(QueryCitizensAccountRequestType par) 
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
			public core3.CitizenGUIDType  Current 
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

		#region NECNumber accessor methods
		public static int GetNECNumberMinCount()
		{
			return 1;
		}

		public static int NECNumberMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetNECNumberMaxCount()
		{
			return 1;
		}

		public static int NECNumberMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetNECNumberCount()
		{
			return DomChildCount(NodeType.Element, "", "NECNumber");
		}

		public int NECNumberCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "NECNumber");
			}
		}

		public bool HasNECNumber()
		{
			return HasDomChild(NodeType.Element, "", "NECNumber");
		}

		public core3.EntitlementCardNumberType NewNECNumber()
		{
			return new core3.EntitlementCardNumberType();
		}

		public core3.EntitlementCardNumberType GetNECNumberAt(int index)
		{
			return new core3.EntitlementCardNumberType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "NECNumber", index)));
		}

		public XmlNode GetStartingNECNumberCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "NECNumber" );
		}

		public XmlNode GetAdvancedNECNumberCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "NECNumber", curNode );
		}

		public core3.EntitlementCardNumberType GetNECNumberValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core3.EntitlementCardNumberType( curNode.InnerText );
		}


		public core3.EntitlementCardNumberType GetNECNumber()
		{
			return GetNECNumberAt(0);
		}

		public core3.EntitlementCardNumberType NECNumber
		{
			get
			{
				return GetNECNumberAt(0);
			}
		}

		public void RemoveNECNumberAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "NECNumber", index);
		}

		public void RemoveNECNumber()
		{
			RemoveNECNumberAt(0);
		}

		public XmlNode AddNECNumber(core3.EntitlementCardNumberType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "NECNumber", newValue.ToString());
			return null;
		}

		public void InsertNECNumberAt(core3.EntitlementCardNumberType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "NECNumber", index, newValue.ToString());
		}

		public void ReplaceNECNumberAt(core3.EntitlementCardNumberType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "NECNumber", index, newValue.ToString());
		}
		#endregion // NECNumber accessor methods

		#region NECNumber collection
        public NECNumberCollection	MyNECNumbers = new NECNumberCollection( );

        public class NECNumberCollection: IEnumerable
        {
            QueryCitizensAccountRequestType parent;
            public QueryCitizensAccountRequestType Parent
			{
				set
				{
					parent = value;
				}
			}
			public NECNumberEnumerator GetEnumerator() 
			{
				return new NECNumberEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class NECNumberEnumerator: IEnumerator 
        {
			int nIndex;
			QueryCitizensAccountRequestType parent;
			public NECNumberEnumerator(QueryCitizensAccountRequestType par) 
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
				return(nIndex < parent.NECNumberCount );
			}
			public core3.EntitlementCardNumberType  Current 
			{
				get 
				{
					return(parent.GetNECNumberAt(nIndex));
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

        #endregion // NECNumber collection

		#region UserID accessor methods
		public static int GetUserIDMinCount()
		{
			return 1;
		}

		public static int UserIDMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetUserIDMaxCount()
		{
			return 1;
		}

		public static int UserIDMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetUserIDCount()
		{
			return DomChildCount(NodeType.Element, "", "UserID");
		}

		public int UserIDCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "UserID");
			}
		}

		public bool HasUserID()
		{
			return HasDomChild(NodeType.Element, "", "UserID");
		}

		public core3.UserIDType NewUserID()
		{
			return new core3.UserIDType();
		}

		public core3.UserIDType GetUserIDAt(int index)
		{
			return new core3.UserIDType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "UserID", index)));
		}

		public XmlNode GetStartingUserIDCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "UserID" );
		}

		public XmlNode GetAdvancedUserIDCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "UserID", curNode );
		}

		public core3.UserIDType GetUserIDValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core3.UserIDType( curNode.InnerText );
		}


		public core3.UserIDType GetUserID()
		{
			return GetUserIDAt(0);
		}

		public core3.UserIDType UserID
		{
			get
			{
				return GetUserIDAt(0);
			}
		}

		public void RemoveUserIDAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "UserID", index);
		}

		public void RemoveUserID()
		{
			RemoveUserIDAt(0);
		}

		public XmlNode AddUserID(core3.UserIDType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "UserID", newValue.ToString());
			return null;
		}

		public void InsertUserIDAt(core3.UserIDType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "UserID", index, newValue.ToString());
		}

		public void ReplaceUserIDAt(core3.UserIDType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "UserID", index, newValue.ToString());
		}
		#endregion // UserID accessor methods

		#region UserID collection
        public UserIDCollection	MyUserIDs = new UserIDCollection( );

        public class UserIDCollection: IEnumerable
        {
            QueryCitizensAccountRequestType parent;
            public QueryCitizensAccountRequestType Parent
			{
				set
				{
					parent = value;
				}
			}
			public UserIDEnumerator GetEnumerator() 
			{
				return new UserIDEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class UserIDEnumerator: IEnumerator 
        {
			int nIndex;
			QueryCitizensAccountRequestType parent;
			public UserIDEnumerator(QueryCitizensAccountRequestType par) 
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
				return(nIndex < parent.UserIDCount );
			}
			public core3.UserIDType  Current 
			{
				get 
				{
					return(parent.GetUserIDAt(nIndex));
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

        #endregion // UserID collection

		#region CitizenDetails accessor methods
		public static int GetCitizenDetailsMinCount()
		{
			return 1;
		}

		public static int CitizenDetailsMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetCitizenDetailsMaxCount()
		{
			return 1;
		}

		public static int CitizenDetailsMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetCitizenDetailsCount()
		{
			return DomChildCount(NodeType.Element, "", "CitizenDetails");
		}

		public int CitizenDetailsCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "CitizenDetails");
			}
		}

		public bool HasCitizenDetails()
		{
			return HasDomChild(NodeType.Element, "", "CitizenDetails");
		}

		public core3.CitizenSearchDetailsType NewCitizenDetails()
		{
			return new core3.CitizenSearchDetailsType(domNode.OwnerDocument.CreateElement("CitizenDetails", ""));
		}

		public core3.CitizenSearchDetailsType GetCitizenDetailsAt(int index)
		{
			return new core3.CitizenSearchDetailsType(GetDomChildAt(NodeType.Element, "", "CitizenDetails", index));
		}

		public XmlNode GetStartingCitizenDetailsCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "CitizenDetails" );
		}

		public XmlNode GetAdvancedCitizenDetailsCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "CitizenDetails", curNode );
		}

		public core3.CitizenSearchDetailsType GetCitizenDetailsValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core3.CitizenSearchDetailsType( curNode );
		}


		public core3.CitizenSearchDetailsType GetCitizenDetails()
		{
			return GetCitizenDetailsAt(0);
		}

		public core3.CitizenSearchDetailsType CitizenDetails
		{
			get
			{
				return GetCitizenDetailsAt(0);
			}
		}

		public void RemoveCitizenDetailsAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "CitizenDetails", index);
		}

		public void RemoveCitizenDetails()
		{
			RemoveCitizenDetailsAt(0);
		}

		public XmlNode AddCitizenDetails(core3.CitizenSearchDetailsType newValue)
		{
			return AppendDomElement("", "CitizenDetails", newValue);
		}

		public void InsertCitizenDetailsAt(core3.CitizenSearchDetailsType newValue, int index)
		{
			InsertDomElementAt("", "CitizenDetails", index, newValue);
		}

		public void ReplaceCitizenDetailsAt(core3.CitizenSearchDetailsType newValue, int index)
		{
			ReplaceDomElementAt("", "CitizenDetails", index, newValue);
		}
		#endregion // CitizenDetails accessor methods

		#region CitizenDetails collection
        public CitizenDetailsCollection	MyCitizenDetailss = new CitizenDetailsCollection( );

        public class CitizenDetailsCollection: IEnumerable
        {
            QueryCitizensAccountRequestType parent;
            public QueryCitizensAccountRequestType Parent
			{
				set
				{
					parent = value;
				}
			}
			public CitizenDetailsEnumerator GetEnumerator() 
			{
				return new CitizenDetailsEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class CitizenDetailsEnumerator: IEnumerator 
        {
			int nIndex;
			QueryCitizensAccountRequestType parent;
			public CitizenDetailsEnumerator(QueryCitizensAccountRequestType par) 
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
				return(nIndex < parent.CitizenDetailsCount );
			}
			public core3.CitizenSearchDetailsType  Current 
			{
				get 
				{
					return(parent.GetCitizenDetailsAt(nIndex));
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

        #endregion // CitizenDetails collection

        private void SetCollectionParents()
        {
            MyUCRNs.Parent = this; 
            MyCASCitizenGUIDs.Parent = this; 
            MyNECNumbers.Parent = this; 
            MyUserIDs.Parent = this; 
            MyCitizenDetailss.Parent = this; 
	}
}
}
