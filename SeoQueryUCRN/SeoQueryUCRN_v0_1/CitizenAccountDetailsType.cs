//
// CitizenAccountDetailsType.cs
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
	public class CitizenAccountDetailsType : Altova.Xml.Node
	{
		#region Forward constructors

		public CitizenAccountDetailsType() : base() { SetCollectionParents(); }

		public CitizenAccountDetailsType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public CitizenAccountDetailsType(XmlNode node) : base(node) { SetCollectionParents(); }
		public CitizenAccountDetailsType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public CitizenAccountDetailsType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
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

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "CitizenName" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "CitizenName", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
				new PersonDescriptives2.PersonNameStructure(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "DateOfBirth" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "DateOfBirth", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
				new PersonDescriptives2.PersonBirthDateStructure(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "DateOfDeath" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "DateOfDeath", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
				new PersonDescriptives2.PersonDeathDateStructure(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "Gender" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "Gender", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "MothersBirthName" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "MothersBirthName", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "PlaceOfBirth" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "PlaceOfBirth", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "core:CitizenAccountDetailsType");
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
            CitizenAccountDetailsType parent;
            public CitizenAccountDetailsType Parent
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
			CitizenAccountDetailsType parent;
			public UCRNEnumerator(CitizenAccountDetailsType par) 
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

		#region CitizenName accessor methods
		public static int GetCitizenNameMinCount()
		{
			return 1;
		}

		public static int CitizenNameMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetCitizenNameMaxCount()
		{
			return 1;
		}

		public static int CitizenNameMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetCitizenNameCount()
		{
			return DomChildCount(NodeType.Element, "", "CitizenName");
		}

		public int CitizenNameCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "CitizenName");
			}
		}

		public bool HasCitizenName()
		{
			return HasDomChild(NodeType.Element, "", "CitizenName");
		}

		public PersonDescriptives2.PersonNameStructure NewCitizenName()
		{
			return new PersonDescriptives2.PersonNameStructure(domNode.OwnerDocument.CreateElement("CitizenName", ""));
		}

		public PersonDescriptives2.PersonNameStructure GetCitizenNameAt(int index)
		{
			return new PersonDescriptives2.PersonNameStructure(GetDomChildAt(NodeType.Element, "", "CitizenName", index));
		}

		public XmlNode GetStartingCitizenNameCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "CitizenName" );
		}

		public XmlNode GetAdvancedCitizenNameCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "CitizenName", curNode );
		}

		public PersonDescriptives2.PersonNameStructure GetCitizenNameValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new PersonDescriptives2.PersonNameStructure( curNode );
		}


		public PersonDescriptives2.PersonNameStructure GetCitizenName()
		{
			return GetCitizenNameAt(0);
		}

		public PersonDescriptives2.PersonNameStructure CitizenName
		{
			get
			{
				return GetCitizenNameAt(0);
			}
		}

		public void RemoveCitizenNameAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "CitizenName", index);
		}

		public void RemoveCitizenName()
		{
			RemoveCitizenNameAt(0);
		}

		public XmlNode AddCitizenName(PersonDescriptives2.PersonNameStructure newValue)
		{
			return AppendDomElement("", "CitizenName", newValue);
		}

		public void InsertCitizenNameAt(PersonDescriptives2.PersonNameStructure newValue, int index)
		{
			InsertDomElementAt("", "CitizenName", index, newValue);
		}

		public void ReplaceCitizenNameAt(PersonDescriptives2.PersonNameStructure newValue, int index)
		{
			ReplaceDomElementAt("", "CitizenName", index, newValue);
		}
		#endregion // CitizenName accessor methods

		#region CitizenName collection
        public CitizenNameCollection	MyCitizenNames = new CitizenNameCollection( );

        public class CitizenNameCollection: IEnumerable
        {
            CitizenAccountDetailsType parent;
            public CitizenAccountDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public CitizenNameEnumerator GetEnumerator() 
			{
				return new CitizenNameEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class CitizenNameEnumerator: IEnumerator 
        {
			int nIndex;
			CitizenAccountDetailsType parent;
			public CitizenNameEnumerator(CitizenAccountDetailsType par) 
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
				return(nIndex < parent.CitizenNameCount );
			}
			public PersonDescriptives2.PersonNameStructure  Current 
			{
				get 
				{
					return(parent.GetCitizenNameAt(nIndex));
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

        #endregion // CitizenName collection

		#region DateOfBirth accessor methods
		public static int GetDateOfBirthMinCount()
		{
			return 1;
		}

		public static int DateOfBirthMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetDateOfBirthMaxCount()
		{
			return 1;
		}

		public static int DateOfBirthMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetDateOfBirthCount()
		{
			return DomChildCount(NodeType.Element, "", "DateOfBirth");
		}

		public int DateOfBirthCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "DateOfBirth");
			}
		}

		public bool HasDateOfBirth()
		{
			return HasDomChild(NodeType.Element, "", "DateOfBirth");
		}

		public PersonDescriptives2.PersonBirthDateStructure NewDateOfBirth()
		{
			return new PersonDescriptives2.PersonBirthDateStructure(domNode.OwnerDocument.CreateElement("DateOfBirth", ""));
		}

		public PersonDescriptives2.PersonBirthDateStructure GetDateOfBirthAt(int index)
		{
			return new PersonDescriptives2.PersonBirthDateStructure(GetDomChildAt(NodeType.Element, "", "DateOfBirth", index));
		}

		public XmlNode GetStartingDateOfBirthCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "DateOfBirth" );
		}

		public XmlNode GetAdvancedDateOfBirthCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "DateOfBirth", curNode );
		}

		public PersonDescriptives2.PersonBirthDateStructure GetDateOfBirthValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new PersonDescriptives2.PersonBirthDateStructure( curNode );
		}


		public PersonDescriptives2.PersonBirthDateStructure GetDateOfBirth()
		{
			return GetDateOfBirthAt(0);
		}

		public PersonDescriptives2.PersonBirthDateStructure DateOfBirth
		{
			get
			{
				return GetDateOfBirthAt(0);
			}
		}

		public void RemoveDateOfBirthAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "DateOfBirth", index);
		}

		public void RemoveDateOfBirth()
		{
			RemoveDateOfBirthAt(0);
		}

		public XmlNode AddDateOfBirth(PersonDescriptives2.PersonBirthDateStructure newValue)
		{
			return AppendDomElement("", "DateOfBirth", newValue);
		}

		public void InsertDateOfBirthAt(PersonDescriptives2.PersonBirthDateStructure newValue, int index)
		{
			InsertDomElementAt("", "DateOfBirth", index, newValue);
		}

		public void ReplaceDateOfBirthAt(PersonDescriptives2.PersonBirthDateStructure newValue, int index)
		{
			ReplaceDomElementAt("", "DateOfBirth", index, newValue);
		}
		#endregion // DateOfBirth accessor methods

		#region DateOfBirth collection
        public DateOfBirthCollection	MyDateOfBirths = new DateOfBirthCollection( );

        public class DateOfBirthCollection: IEnumerable
        {
            CitizenAccountDetailsType parent;
            public CitizenAccountDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public DateOfBirthEnumerator GetEnumerator() 
			{
				return new DateOfBirthEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class DateOfBirthEnumerator: IEnumerator 
        {
			int nIndex;
			CitizenAccountDetailsType parent;
			public DateOfBirthEnumerator(CitizenAccountDetailsType par) 
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
				return(nIndex < parent.DateOfBirthCount );
			}
			public PersonDescriptives2.PersonBirthDateStructure  Current 
			{
				get 
				{
					return(parent.GetDateOfBirthAt(nIndex));
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

        #endregion // DateOfBirth collection

		#region DateOfDeath accessor methods
		public static int GetDateOfDeathMinCount()
		{
			return 0;
		}

		public static int DateOfDeathMinCount
		{
			get
			{
				return 0;
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
            CitizenAccountDetailsType parent;
            public CitizenAccountDetailsType Parent
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
			CitizenAccountDetailsType parent;
			public DateOfDeathEnumerator(CitizenAccountDetailsType par) 
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

		#region Gender accessor methods
		public static int GetGenderMinCount()
		{
			return 1;
		}

		public static int GenderMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetGenderMaxCount()
		{
			return 1;
		}

		public static int GenderMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetGenderCount()
		{
			return DomChildCount(NodeType.Element, "", "Gender");
		}

		public int GenderCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Gender");
			}
		}

		public bool HasGender()
		{
			return HasDomChild(NodeType.Element, "", "Gender");
		}

		public PersonDescriptives2.GenderAtRegistrationType NewGender()
		{
			return new PersonDescriptives2.GenderAtRegistrationType();
		}

		public PersonDescriptives2.GenderAtRegistrationType GetGenderAt(int index)
		{
			return new PersonDescriptives2.GenderAtRegistrationType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Gender", index)));
		}

		public XmlNode GetStartingGenderCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "Gender" );
		}

		public XmlNode GetAdvancedGenderCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "Gender", curNode );
		}

		public PersonDescriptives2.GenderAtRegistrationType GetGenderValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new PersonDescriptives2.GenderAtRegistrationType( curNode.InnerText );
		}


		public PersonDescriptives2.GenderAtRegistrationType GetGender()
		{
			return GetGenderAt(0);
		}

		public PersonDescriptives2.GenderAtRegistrationType Gender
		{
			get
			{
				return GetGenderAt(0);
			}
		}

		public void RemoveGenderAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Gender", index);
		}

		public void RemoveGender()
		{
			RemoveGenderAt(0);
		}

		public XmlNode AddGender(PersonDescriptives2.GenderAtRegistrationType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "Gender", newValue.ToString());
			return null;
		}

		public void InsertGenderAt(PersonDescriptives2.GenderAtRegistrationType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "Gender", index, newValue.ToString());
		}

		public void ReplaceGenderAt(PersonDescriptives2.GenderAtRegistrationType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Gender", index, newValue.ToString());
		}
		#endregion // Gender accessor methods

		#region Gender collection
        public GenderCollection	MyGenders = new GenderCollection( );

        public class GenderCollection: IEnumerable
        {
            CitizenAccountDetailsType parent;
            public CitizenAccountDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public GenderEnumerator GetEnumerator() 
			{
				return new GenderEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class GenderEnumerator: IEnumerator 
        {
			int nIndex;
			CitizenAccountDetailsType parent;
			public GenderEnumerator(CitizenAccountDetailsType par) 
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
				return(nIndex < parent.GenderCount );
			}
			public PersonDescriptives2.GenderAtRegistrationType  Current 
			{
				get 
				{
					return(parent.GetGenderAt(nIndex));
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

        #endregion // Gender collection

		#region MothersBirthName accessor methods
		public static int GetMothersBirthNameMinCount()
		{
			return 0;
		}

		public static int MothersBirthNameMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetMothersBirthNameMaxCount()
		{
			return 1;
		}

		public static int MothersBirthNameMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetMothersBirthNameCount()
		{
			return DomChildCount(NodeType.Element, "", "MothersBirthName");
		}

		public int MothersBirthNameCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "MothersBirthName");
			}
		}

		public bool HasMothersBirthName()
		{
			return HasDomChild(NodeType.Element, "", "MothersBirthName");
		}

		public MothersBirthNameType NewMothersBirthName()
		{
			return new MothersBirthNameType();
		}

		public MothersBirthNameType GetMothersBirthNameAt(int index)
		{
			return new MothersBirthNameType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "MothersBirthName", index)));
		}

		public XmlNode GetStartingMothersBirthNameCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "MothersBirthName" );
		}

		public XmlNode GetAdvancedMothersBirthNameCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "MothersBirthName", curNode );
		}

		public MothersBirthNameType GetMothersBirthNameValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new MothersBirthNameType( curNode.InnerText );
		}


		public MothersBirthNameType GetMothersBirthName()
		{
			return GetMothersBirthNameAt(0);
		}

		public MothersBirthNameType MothersBirthName
		{
			get
			{
				return GetMothersBirthNameAt(0);
			}
		}

		public void RemoveMothersBirthNameAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "MothersBirthName", index);
		}

		public void RemoveMothersBirthName()
		{
			RemoveMothersBirthNameAt(0);
		}

		public XmlNode AddMothersBirthName(MothersBirthNameType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "MothersBirthName", newValue.ToString());
			return null;
		}

		public void InsertMothersBirthNameAt(MothersBirthNameType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "MothersBirthName", index, newValue.ToString());
		}

		public void ReplaceMothersBirthNameAt(MothersBirthNameType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "MothersBirthName", index, newValue.ToString());
		}
		#endregion // MothersBirthName accessor methods

		#region MothersBirthName collection
        public MothersBirthNameCollection	MyMothersBirthNames = new MothersBirthNameCollection( );

        public class MothersBirthNameCollection: IEnumerable
        {
            CitizenAccountDetailsType parent;
            public CitizenAccountDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public MothersBirthNameEnumerator GetEnumerator() 
			{
				return new MothersBirthNameEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class MothersBirthNameEnumerator: IEnumerator 
        {
			int nIndex;
			CitizenAccountDetailsType parent;
			public MothersBirthNameEnumerator(CitizenAccountDetailsType par) 
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
				return(nIndex < parent.MothersBirthNameCount );
			}
			public MothersBirthNameType  Current 
			{
				get 
				{
					return(parent.GetMothersBirthNameAt(nIndex));
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

        #endregion // MothersBirthName collection

		#region PlaceOfBirth accessor methods
		public static int GetPlaceOfBirthMinCount()
		{
			return 0;
		}

		public static int PlaceOfBirthMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetPlaceOfBirthMaxCount()
		{
			return 1;
		}

		public static int PlaceOfBirthMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetPlaceOfBirthCount()
		{
			return DomChildCount(NodeType.Element, "", "PlaceOfBirth");
		}

		public int PlaceOfBirthCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "PlaceOfBirth");
			}
		}

		public bool HasPlaceOfBirth()
		{
			return HasDomChild(NodeType.Element, "", "PlaceOfBirth");
		}

		public PlaceOfBirthType NewPlaceOfBirth()
		{
			return new PlaceOfBirthType();
		}

		public PlaceOfBirthType GetPlaceOfBirthAt(int index)
		{
			return new PlaceOfBirthType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "PlaceOfBirth", index)));
		}

		public XmlNode GetStartingPlaceOfBirthCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "PlaceOfBirth" );
		}

		public XmlNode GetAdvancedPlaceOfBirthCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "PlaceOfBirth", curNode );
		}

		public PlaceOfBirthType GetPlaceOfBirthValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new PlaceOfBirthType( curNode.InnerText );
		}


		public PlaceOfBirthType GetPlaceOfBirth()
		{
			return GetPlaceOfBirthAt(0);
		}

		public PlaceOfBirthType PlaceOfBirth
		{
			get
			{
				return GetPlaceOfBirthAt(0);
			}
		}

		public void RemovePlaceOfBirthAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "PlaceOfBirth", index);
		}

		public void RemovePlaceOfBirth()
		{
			RemovePlaceOfBirthAt(0);
		}

		public XmlNode AddPlaceOfBirth(PlaceOfBirthType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "PlaceOfBirth", newValue.ToString());
			return null;
		}

		public void InsertPlaceOfBirthAt(PlaceOfBirthType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "PlaceOfBirth", index, newValue.ToString());
		}

		public void ReplacePlaceOfBirthAt(PlaceOfBirthType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "PlaceOfBirth", index, newValue.ToString());
		}
		#endregion // PlaceOfBirth accessor methods

		#region PlaceOfBirth collection
        public PlaceOfBirthCollection	MyPlaceOfBirths = new PlaceOfBirthCollection( );

        public class PlaceOfBirthCollection: IEnumerable
        {
            CitizenAccountDetailsType parent;
            public CitizenAccountDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public PlaceOfBirthEnumerator GetEnumerator() 
			{
				return new PlaceOfBirthEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class PlaceOfBirthEnumerator: IEnumerator 
        {
			int nIndex;
			CitizenAccountDetailsType parent;
			public PlaceOfBirthEnumerator(CitizenAccountDetailsType par) 
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
				return(nIndex < parent.PlaceOfBirthCount );
			}
			public PlaceOfBirthType  Current 
			{
				get 
				{
					return(parent.GetPlaceOfBirthAt(nIndex));
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

        #endregion // PlaceOfBirth collection

        private void SetCollectionParents()
        {
            MyUCRNs.Parent = this; 
            MyCitizenNames.Parent = this; 
            MyDateOfBirths.Parent = this; 
            MyDateOfDeaths.Parent = this; 
            MyGenders.Parent = this; 
            MyMothersBirthNames.Parent = this; 
            MyPlaceOfBirths.Parent = this; 
	}
}
}
