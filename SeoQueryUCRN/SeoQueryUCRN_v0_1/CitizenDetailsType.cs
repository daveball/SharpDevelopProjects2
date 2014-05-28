//
// CitizenDetailsType.cs
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
	public class CitizenDetailsType : Altova.Xml.Node
	{
		#region Forward constructors

		public CitizenDetailsType() : base() { SetCollectionParents(); }

		public CitizenDetailsType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public CitizenDetailsType(XmlNode node) : base(node) { SetCollectionParents(); }
		public CitizenDetailsType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public CitizenDetailsType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "Forename" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "Forename", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "Surname" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "Surname", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "Gender" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "Gender", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "DateOfBirth" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "DateOfBirth", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "core:CitizenDetailsType");
		}


		#region Forename accessor methods
		public static int GetForenameMinCount()
		{
			return 1;
		}

		public static int ForenameMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetForenameMaxCount()
		{
			return 1;
		}

		public static int ForenameMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetForenameCount()
		{
			return DomChildCount(NodeType.Element, "", "Forename");
		}

		public int ForenameCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Forename");
			}
		}

		public bool HasForename()
		{
			return HasDomChild(NodeType.Element, "", "Forename");
		}

		public PersonDescriptives2.PersonGivenNameType NewForename()
		{
			return new PersonDescriptives2.PersonGivenNameType();
		}

		public PersonDescriptives2.PersonGivenNameType GetForenameAt(int index)
		{
			return new PersonDescriptives2.PersonGivenNameType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Forename", index)));
		}

		public XmlNode GetStartingForenameCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "Forename" );
		}

		public XmlNode GetAdvancedForenameCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "Forename", curNode );
		}

		public PersonDescriptives2.PersonGivenNameType GetForenameValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new PersonDescriptives2.PersonGivenNameType( curNode.InnerText );
		}


		public PersonDescriptives2.PersonGivenNameType GetForename()
		{
			return GetForenameAt(0);
		}

		public PersonDescriptives2.PersonGivenNameType Forename
		{
			get
			{
				return GetForenameAt(0);
			}
		}

		public void RemoveForenameAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Forename", index);
		}

		public void RemoveForename()
		{
			RemoveForenameAt(0);
		}

		public XmlNode AddForename(PersonDescriptives2.PersonGivenNameType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "Forename", newValue.ToString());
			return null;
		}

		public void InsertForenameAt(PersonDescriptives2.PersonGivenNameType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "Forename", index, newValue.ToString());
		}

		public void ReplaceForenameAt(PersonDescriptives2.PersonGivenNameType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Forename", index, newValue.ToString());
		}
		#endregion // Forename accessor methods

		#region Forename collection
        public ForenameCollection	MyForenames = new ForenameCollection( );

        public class ForenameCollection: IEnumerable
        {
            CitizenDetailsType parent;
            public CitizenDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public ForenameEnumerator GetEnumerator() 
			{
				return new ForenameEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ForenameEnumerator: IEnumerator 
        {
			int nIndex;
			CitizenDetailsType parent;
			public ForenameEnumerator(CitizenDetailsType par) 
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
				return(nIndex < parent.ForenameCount );
			}
			public PersonDescriptives2.PersonGivenNameType  Current 
			{
				get 
				{
					return(parent.GetForenameAt(nIndex));
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

        #endregion // Forename collection

		#region Surname accessor methods
		public static int GetSurnameMinCount()
		{
			return 1;
		}

		public static int SurnameMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetSurnameMaxCount()
		{
			return 1;
		}

		public static int SurnameMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetSurnameCount()
		{
			return DomChildCount(NodeType.Element, "", "Surname");
		}

		public int SurnameCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Surname");
			}
		}

		public bool HasSurname()
		{
			return HasDomChild(NodeType.Element, "", "Surname");
		}

		public PersonDescriptives2.PersonFamilyNameType NewSurname()
		{
			return new PersonDescriptives2.PersonFamilyNameType();
		}

		public PersonDescriptives2.PersonFamilyNameType GetSurnameAt(int index)
		{
			return new PersonDescriptives2.PersonFamilyNameType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Surname", index)));
		}

		public XmlNode GetStartingSurnameCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "Surname" );
		}

		public XmlNode GetAdvancedSurnameCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "Surname", curNode );
		}

		public PersonDescriptives2.PersonFamilyNameType GetSurnameValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new PersonDescriptives2.PersonFamilyNameType( curNode.InnerText );
		}


		public PersonDescriptives2.PersonFamilyNameType GetSurname()
		{
			return GetSurnameAt(0);
		}

		public PersonDescriptives2.PersonFamilyNameType Surname
		{
			get
			{
				return GetSurnameAt(0);
			}
		}

		public void RemoveSurnameAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Surname", index);
		}

		public void RemoveSurname()
		{
			RemoveSurnameAt(0);
		}

		public XmlNode AddSurname(PersonDescriptives2.PersonFamilyNameType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "Surname", newValue.ToString());
			return null;
		}

		public void InsertSurnameAt(PersonDescriptives2.PersonFamilyNameType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "Surname", index, newValue.ToString());
		}

		public void ReplaceSurnameAt(PersonDescriptives2.PersonFamilyNameType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Surname", index, newValue.ToString());
		}
		#endregion // Surname accessor methods

		#region Surname collection
        public SurnameCollection	MySurnames = new SurnameCollection( );

        public class SurnameCollection: IEnumerable
        {
            CitizenDetailsType parent;
            public CitizenDetailsType Parent
			{
				set
				{
					parent = value;
				}
			}
			public SurnameEnumerator GetEnumerator() 
			{
				return new SurnameEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class SurnameEnumerator: IEnumerator 
        {
			int nIndex;
			CitizenDetailsType parent;
			public SurnameEnumerator(CitizenDetailsType par) 
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
				return(nIndex < parent.SurnameCount );
			}
			public PersonDescriptives2.PersonFamilyNameType  Current 
			{
				get 
				{
					return(parent.GetSurnameAt(nIndex));
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

        #endregion // Surname collection

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
            CitizenDetailsType parent;
            public CitizenDetailsType Parent
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
			CitizenDetailsType parent;
			public GenderEnumerator(CitizenDetailsType par) 
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

		public core2.DateType NewDateOfBirth()
		{
			return new core2.DateType();
		}

		public core2.DateType GetDateOfBirthAt(int index)
		{
			return new core2.DateType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "DateOfBirth", index)));
		}

		public XmlNode GetStartingDateOfBirthCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "DateOfBirth" );
		}

		public XmlNode GetAdvancedDateOfBirthCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "DateOfBirth", curNode );
		}

		public core2.DateType GetDateOfBirthValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core2.DateType( curNode.InnerText );
		}


		public core2.DateType GetDateOfBirth()
		{
			return GetDateOfBirthAt(0);
		}

		public core2.DateType DateOfBirth
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

		public XmlNode AddDateOfBirth(core2.DateType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "DateOfBirth", newValue.ToString());
			return null;
		}

		public void InsertDateOfBirthAt(core2.DateType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "DateOfBirth", index, newValue.ToString());
		}

		public void ReplaceDateOfBirthAt(core2.DateType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "DateOfBirth", index, newValue.ToString());
		}
		#endregion // DateOfBirth accessor methods

		#region DateOfBirth collection
        public DateOfBirthCollection	MyDateOfBirths = new DateOfBirthCollection( );

        public class DateOfBirthCollection: IEnumerable
        {
            CitizenDetailsType parent;
            public CitizenDetailsType Parent
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
			CitizenDetailsType parent;
			public DateOfBirthEnumerator(CitizenDetailsType par) 
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
			public core2.DateType  Current 
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

        private void SetCollectionParents()
        {
            MyForenames.Parent = this; 
            MySurnames.Parent = this; 
            MyGenders.Parent = this; 
            MyDateOfBirths.Parent = this; 
	}
}
}
