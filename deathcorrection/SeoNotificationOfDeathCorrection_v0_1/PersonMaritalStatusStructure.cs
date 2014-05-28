//
// PersonMaritalStatusStructure.cs
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

namespace SeoNotificationOfDeathCorrection_v0_1.PersonDescriptives2
{
	public class PersonMaritalStatusStructure : Altova.Xml.Node
	{
		#region Forward constructors

		public PersonMaritalStatusStructure() : base() { SetCollectionParents(); }

		public PersonMaritalStatusStructure(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public PersonMaritalStatusStructure(XmlNode node) : base(node) { SetCollectionParents(); }
		public PersonMaritalStatusStructure(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public PersonMaritalStatusStructure(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "MaritalStatus" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "MaritalStatus", DOMNode )
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
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "PersonDescriptives:PersonMaritalStatusStructure");
		}


		#region MaritalStatus accessor methods
		public static int GetMaritalStatusMinCount()
		{
			return 1;
		}

		public static int MaritalStatusMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetMaritalStatusMaxCount()
		{
			return 1;
		}

		public static int MaritalStatusMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetMaritalStatusCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "MaritalStatus");
		}

		public int MaritalStatusCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "MaritalStatus");
			}
		}

		public bool HasMaritalStatus()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "MaritalStatus");
		}

		public core2.MaritalStatusType NewMaritalStatus()
		{
			return new core2.MaritalStatusType();
		}

		public core2.MaritalStatusType GetMaritalStatusAt(int index)
		{
			return new core2.MaritalStatusType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "MaritalStatus", index)));
		}

		public XmlNode GetStartingMaritalStatusCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "MaritalStatus" );
		}

		public XmlNode GetAdvancedMaritalStatusCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "MaritalStatus", curNode );
		}

		public core2.MaritalStatusType GetMaritalStatusValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new core2.MaritalStatusType( curNode.InnerText );
		}


		public core2.MaritalStatusType GetMaritalStatus()
		{
			return GetMaritalStatusAt(0);
		}

		public core2.MaritalStatusType MaritalStatus
		{
			get
			{
				return GetMaritalStatusAt(0);
			}
		}

		public void RemoveMaritalStatusAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "MaritalStatus", index);
		}

		public void RemoveMaritalStatus()
		{
			RemoveMaritalStatusAt(0);
		}

		public XmlNode AddMaritalStatus(core2.MaritalStatusType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "MaritalStatus", newValue.ToString());
			return null;
		}

		public void InsertMaritalStatusAt(core2.MaritalStatusType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "MaritalStatus", index, newValue.ToString());
		}

		public void ReplaceMaritalStatusAt(core2.MaritalStatusType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/PersonDescriptives", "MaritalStatus", index, newValue.ToString());
		}
		#endregion // MaritalStatus accessor methods

		#region MaritalStatus collection
        public MaritalStatusCollection	MyMaritalStatuss = new MaritalStatusCollection( );

        public class MaritalStatusCollection: IEnumerable
        {
            PersonMaritalStatusStructure parent;
            public PersonMaritalStatusStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public MaritalStatusEnumerator GetEnumerator() 
			{
				return new MaritalStatusEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class MaritalStatusEnumerator: IEnumerator 
        {
			int nIndex;
			PersonMaritalStatusStructure parent;
			public MaritalStatusEnumerator(PersonMaritalStatusStructure par) 
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
				return(nIndex < parent.MaritalStatusCount );
			}
			public core2.MaritalStatusType  Current 
			{
				get 
				{
					return(parent.GetMaritalStatusAt(nIndex));
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

        #endregion // MaritalStatus collection

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
            PersonMaritalStatusStructure parent;
            public PersonMaritalStatusStructure Parent
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
			PersonMaritalStatusStructure parent;
			public VerificationLevelEnumerator(PersonMaritalStatusStructure par) 
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
            MyMaritalStatuss.Parent = this; 
            MyVerificationLevels.Parent = this; 
	}
}
}