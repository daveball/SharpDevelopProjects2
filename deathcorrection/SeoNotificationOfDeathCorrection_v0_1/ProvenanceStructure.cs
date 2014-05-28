//
// ProvenanceStructure.cs
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

namespace SeoNotificationOfDeathCorrection_v0_1.bs76662
{
	public class ProvenanceStructure : Altova.Xml.Node
	{
		#region Forward constructors

		public ProvenanceStructure() : base() { SetCollectionParents(); }

		public ProvenanceStructure(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public ProvenanceStructure(XmlNode node) : base(node) { SetCollectionParents(); }
		public ProvenanceStructure(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public ProvenanceStructure(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvenanceCode" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvenanceCode", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Annotation" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Annotation", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEntryDate" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEntryDate", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvStartDate" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvStartDate", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEndDate" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEndDate", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvLastUpdateDate" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvLastUpdateDate", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "BLPUextent" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "BLPUextent", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
				new BLPUextentStructure(DOMNode).AdjustPrefix();
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "bs7666:ProvenanceStructure");
		}


		#region ProvenanceCode accessor methods
		public static int GetProvenanceCodeMinCount()
		{
			return 1;
		}

		public static int ProvenanceCodeMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetProvenanceCodeMaxCount()
		{
			return 1;
		}

		public static int ProvenanceCodeMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetProvenanceCodeCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvenanceCode");
		}

		public int ProvenanceCodeCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvenanceCode");
			}
		}

		public bool HasProvenanceCode()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvenanceCode");
		}

		public ProvenanceCodeType NewProvenanceCode()
		{
			return new ProvenanceCodeType();
		}

		public ProvenanceCodeType GetProvenanceCodeAt(int index)
		{
			return new ProvenanceCodeType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvenanceCode", index)));
		}

		public XmlNode GetStartingProvenanceCodeCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvenanceCode" );
		}

		public XmlNode GetAdvancedProvenanceCodeCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvenanceCode", curNode );
		}

		public ProvenanceCodeType GetProvenanceCodeValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new ProvenanceCodeType( curNode.InnerText );
		}


		public ProvenanceCodeType GetProvenanceCode()
		{
			return GetProvenanceCodeAt(0);
		}

		public ProvenanceCodeType ProvenanceCode
		{
			get
			{
				return GetProvenanceCodeAt(0);
			}
		}

		public void RemoveProvenanceCodeAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvenanceCode", index);
		}

		public void RemoveProvenanceCode()
		{
			RemoveProvenanceCodeAt(0);
		}

		public XmlNode AddProvenanceCode(ProvenanceCodeType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvenanceCode", newValue.ToString());
			return null;
		}

		public void InsertProvenanceCodeAt(ProvenanceCodeType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvenanceCode", index, newValue.ToString());
		}

		public void ReplaceProvenanceCodeAt(ProvenanceCodeType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvenanceCode", index, newValue.ToString());
		}
		#endregion // ProvenanceCode accessor methods

		#region ProvenanceCode collection
        public ProvenanceCodeCollection	MyProvenanceCodes = new ProvenanceCodeCollection( );

        public class ProvenanceCodeCollection: IEnumerable
        {
            ProvenanceStructure parent;
            public ProvenanceStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public ProvenanceCodeEnumerator GetEnumerator() 
			{
				return new ProvenanceCodeEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ProvenanceCodeEnumerator: IEnumerator 
        {
			int nIndex;
			ProvenanceStructure parent;
			public ProvenanceCodeEnumerator(ProvenanceStructure par) 
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
				return(nIndex < parent.ProvenanceCodeCount );
			}
			public ProvenanceCodeType  Current 
			{
				get 
				{
					return(parent.GetProvenanceCodeAt(nIndex));
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

        #endregion // ProvenanceCode collection

		#region Annotation accessor methods
		public static int GetAnnotationMinCount()
		{
			return 0;
		}

		public static int AnnotationMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetAnnotationMaxCount()
		{
			return 1;
		}

		public static int AnnotationMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetAnnotationCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Annotation");
		}

		public int AnnotationCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Annotation");
			}
		}

		public bool HasAnnotation()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Annotation");
		}

		public SchemaString NewAnnotation()
		{
			return new SchemaString();
		}

		public SchemaString GetAnnotationAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Annotation", index)));
		}

		public XmlNode GetStartingAnnotationCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Annotation" );
		}

		public XmlNode GetAdvancedAnnotationCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Annotation", curNode );
		}

		public SchemaString GetAnnotationValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaString( curNode.InnerText );
		}


		public SchemaString GetAnnotation()
		{
			return GetAnnotationAt(0);
		}

		public SchemaString Annotation
		{
			get
			{
				return GetAnnotationAt(0);
			}
		}

		public void RemoveAnnotationAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Annotation", index);
		}

		public void RemoveAnnotation()
		{
			RemoveAnnotationAt(0);
		}

		public XmlNode AddAnnotation(SchemaString newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Annotation", newValue.ToString());
			return null;
		}

		public void InsertAnnotationAt(SchemaString newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Annotation", index, newValue.ToString());
		}

		public void ReplaceAnnotationAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "Annotation", index, newValue.ToString());
		}
		#endregion // Annotation accessor methods

		#region Annotation collection
        public AnnotationCollection	MyAnnotations = new AnnotationCollection( );

        public class AnnotationCollection: IEnumerable
        {
            ProvenanceStructure parent;
            public ProvenanceStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public AnnotationEnumerator GetEnumerator() 
			{
				return new AnnotationEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class AnnotationEnumerator: IEnumerator 
        {
			int nIndex;
			ProvenanceStructure parent;
			public AnnotationEnumerator(ProvenanceStructure par) 
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
				return(nIndex < parent.AnnotationCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetAnnotationAt(nIndex));
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

        #endregion // Annotation collection

		#region ProvEntryDate accessor methods
		public static int GetProvEntryDateMinCount()
		{
			return 1;
		}

		public static int ProvEntryDateMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetProvEntryDateMaxCount()
		{
			return 1;
		}

		public static int ProvEntryDateMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetProvEntryDateCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEntryDate");
		}

		public int ProvEntryDateCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEntryDate");
			}
		}

		public bool HasProvEntryDate()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEntryDate");
		}

		public SchemaDate NewProvEntryDate()
		{
			return new SchemaDate();
		}

		public SchemaDate GetProvEntryDateAt(int index)
		{
			return new SchemaDate(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEntryDate", index)));
		}

		public XmlNode GetStartingProvEntryDateCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEntryDate" );
		}

		public XmlNode GetAdvancedProvEntryDateCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEntryDate", curNode );
		}

		public SchemaDate GetProvEntryDateValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaDate( curNode.InnerText );
		}


		public SchemaDate GetProvEntryDate()
		{
			return GetProvEntryDateAt(0);
		}

		public SchemaDate ProvEntryDate
		{
			get
			{
				return GetProvEntryDateAt(0);
			}
		}

		public void RemoveProvEntryDateAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEntryDate", index);
		}

		public void RemoveProvEntryDate()
		{
			RemoveProvEntryDateAt(0);
		}

		public XmlNode AddProvEntryDate(SchemaDate newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEntryDate", newValue.ToString());
			return null;
		}

		public void InsertProvEntryDateAt(SchemaDate newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEntryDate", index, newValue.ToString());
		}

		public void ReplaceProvEntryDateAt(SchemaDate newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEntryDate", index, newValue.ToString());
		}
		#endregion // ProvEntryDate accessor methods

		#region ProvEntryDate collection
        public ProvEntryDateCollection	MyProvEntryDates = new ProvEntryDateCollection( );

        public class ProvEntryDateCollection: IEnumerable
        {
            ProvenanceStructure parent;
            public ProvenanceStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public ProvEntryDateEnumerator GetEnumerator() 
			{
				return new ProvEntryDateEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ProvEntryDateEnumerator: IEnumerator 
        {
			int nIndex;
			ProvenanceStructure parent;
			public ProvEntryDateEnumerator(ProvenanceStructure par) 
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
				return(nIndex < parent.ProvEntryDateCount );
			}
			public SchemaDate  Current 
			{
				get 
				{
					return(parent.GetProvEntryDateAt(nIndex));
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

        #endregion // ProvEntryDate collection

		#region ProvStartDate accessor methods
		public static int GetProvStartDateMinCount()
		{
			return 1;
		}

		public static int ProvStartDateMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetProvStartDateMaxCount()
		{
			return 1;
		}

		public static int ProvStartDateMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetProvStartDateCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvStartDate");
		}

		public int ProvStartDateCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvStartDate");
			}
		}

		public bool HasProvStartDate()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvStartDate");
		}

		public SchemaDate NewProvStartDate()
		{
			return new SchemaDate();
		}

		public SchemaDate GetProvStartDateAt(int index)
		{
			return new SchemaDate(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvStartDate", index)));
		}

		public XmlNode GetStartingProvStartDateCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvStartDate" );
		}

		public XmlNode GetAdvancedProvStartDateCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvStartDate", curNode );
		}

		public SchemaDate GetProvStartDateValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaDate( curNode.InnerText );
		}


		public SchemaDate GetProvStartDate()
		{
			return GetProvStartDateAt(0);
		}

		public SchemaDate ProvStartDate
		{
			get
			{
				return GetProvStartDateAt(0);
			}
		}

		public void RemoveProvStartDateAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvStartDate", index);
		}

		public void RemoveProvStartDate()
		{
			RemoveProvStartDateAt(0);
		}

		public XmlNode AddProvStartDate(SchemaDate newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvStartDate", newValue.ToString());
			return null;
		}

		public void InsertProvStartDateAt(SchemaDate newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvStartDate", index, newValue.ToString());
		}

		public void ReplaceProvStartDateAt(SchemaDate newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvStartDate", index, newValue.ToString());
		}
		#endregion // ProvStartDate accessor methods

		#region ProvStartDate collection
        public ProvStartDateCollection	MyProvStartDates = new ProvStartDateCollection( );

        public class ProvStartDateCollection: IEnumerable
        {
            ProvenanceStructure parent;
            public ProvenanceStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public ProvStartDateEnumerator GetEnumerator() 
			{
				return new ProvStartDateEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ProvStartDateEnumerator: IEnumerator 
        {
			int nIndex;
			ProvenanceStructure parent;
			public ProvStartDateEnumerator(ProvenanceStructure par) 
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
				return(nIndex < parent.ProvStartDateCount );
			}
			public SchemaDate  Current 
			{
				get 
				{
					return(parent.GetProvStartDateAt(nIndex));
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

        #endregion // ProvStartDate collection

		#region ProvEndDate accessor methods
		public static int GetProvEndDateMinCount()
		{
			return 0;
		}

		public static int ProvEndDateMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetProvEndDateMaxCount()
		{
			return 1;
		}

		public static int ProvEndDateMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetProvEndDateCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEndDate");
		}

		public int ProvEndDateCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEndDate");
			}
		}

		public bool HasProvEndDate()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEndDate");
		}

		public SchemaDate NewProvEndDate()
		{
			return new SchemaDate();
		}

		public SchemaDate GetProvEndDateAt(int index)
		{
			return new SchemaDate(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEndDate", index)));
		}

		public XmlNode GetStartingProvEndDateCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEndDate" );
		}

		public XmlNode GetAdvancedProvEndDateCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEndDate", curNode );
		}

		public SchemaDate GetProvEndDateValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaDate( curNode.InnerText );
		}


		public SchemaDate GetProvEndDate()
		{
			return GetProvEndDateAt(0);
		}

		public SchemaDate ProvEndDate
		{
			get
			{
				return GetProvEndDateAt(0);
			}
		}

		public void RemoveProvEndDateAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEndDate", index);
		}

		public void RemoveProvEndDate()
		{
			RemoveProvEndDateAt(0);
		}

		public XmlNode AddProvEndDate(SchemaDate newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEndDate", newValue.ToString());
			return null;
		}

		public void InsertProvEndDateAt(SchemaDate newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEndDate", index, newValue.ToString());
		}

		public void ReplaceProvEndDateAt(SchemaDate newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvEndDate", index, newValue.ToString());
		}
		#endregion // ProvEndDate accessor methods

		#region ProvEndDate collection
        public ProvEndDateCollection	MyProvEndDates = new ProvEndDateCollection( );

        public class ProvEndDateCollection: IEnumerable
        {
            ProvenanceStructure parent;
            public ProvenanceStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public ProvEndDateEnumerator GetEnumerator() 
			{
				return new ProvEndDateEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ProvEndDateEnumerator: IEnumerator 
        {
			int nIndex;
			ProvenanceStructure parent;
			public ProvEndDateEnumerator(ProvenanceStructure par) 
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
				return(nIndex < parent.ProvEndDateCount );
			}
			public SchemaDate  Current 
			{
				get 
				{
					return(parent.GetProvEndDateAt(nIndex));
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

        #endregion // ProvEndDate collection

		#region ProvLastUpdateDate accessor methods
		public static int GetProvLastUpdateDateMinCount()
		{
			return 1;
		}

		public static int ProvLastUpdateDateMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetProvLastUpdateDateMaxCount()
		{
			return 1;
		}

		public static int ProvLastUpdateDateMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetProvLastUpdateDateCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvLastUpdateDate");
		}

		public int ProvLastUpdateDateCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvLastUpdateDate");
			}
		}

		public bool HasProvLastUpdateDate()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvLastUpdateDate");
		}

		public SchemaDate NewProvLastUpdateDate()
		{
			return new SchemaDate();
		}

		public SchemaDate GetProvLastUpdateDateAt(int index)
		{
			return new SchemaDate(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvLastUpdateDate", index)));
		}

		public XmlNode GetStartingProvLastUpdateDateCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvLastUpdateDate" );
		}

		public XmlNode GetAdvancedProvLastUpdateDateCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvLastUpdateDate", curNode );
		}

		public SchemaDate GetProvLastUpdateDateValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaDate( curNode.InnerText );
		}


		public SchemaDate GetProvLastUpdateDate()
		{
			return GetProvLastUpdateDateAt(0);
		}

		public SchemaDate ProvLastUpdateDate
		{
			get
			{
				return GetProvLastUpdateDateAt(0);
			}
		}

		public void RemoveProvLastUpdateDateAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvLastUpdateDate", index);
		}

		public void RemoveProvLastUpdateDate()
		{
			RemoveProvLastUpdateDateAt(0);
		}

		public XmlNode AddProvLastUpdateDate(SchemaDate newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvLastUpdateDate", newValue.ToString());
			return null;
		}

		public void InsertProvLastUpdateDateAt(SchemaDate newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvLastUpdateDate", index, newValue.ToString());
		}

		public void ReplaceProvLastUpdateDateAt(SchemaDate newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "ProvLastUpdateDate", index, newValue.ToString());
		}
		#endregion // ProvLastUpdateDate accessor methods

		#region ProvLastUpdateDate collection
        public ProvLastUpdateDateCollection	MyProvLastUpdateDates = new ProvLastUpdateDateCollection( );

        public class ProvLastUpdateDateCollection: IEnumerable
        {
            ProvenanceStructure parent;
            public ProvenanceStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public ProvLastUpdateDateEnumerator GetEnumerator() 
			{
				return new ProvLastUpdateDateEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ProvLastUpdateDateEnumerator: IEnumerator 
        {
			int nIndex;
			ProvenanceStructure parent;
			public ProvLastUpdateDateEnumerator(ProvenanceStructure par) 
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
				return(nIndex < parent.ProvLastUpdateDateCount );
			}
			public SchemaDate  Current 
			{
				get 
				{
					return(parent.GetProvLastUpdateDateAt(nIndex));
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

        #endregion // ProvLastUpdateDate collection

		#region BLPUextent accessor methods
		public static int GetBLPUextentMinCount()
		{
			return 0;
		}

		public static int BLPUextentMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetBLPUextentMaxCount()
		{
			return 1;
		}

		public static int BLPUextentMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetBLPUextentCount()
		{
			return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "BLPUextent");
		}

		public int BLPUextentCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "BLPUextent");
			}
		}

		public bool HasBLPUextent()
		{
			return HasDomChild(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "BLPUextent");
		}

		public BLPUextentStructure NewBLPUextent()
		{
			return new BLPUextentStructure(domNode.OwnerDocument.CreateElement("BLPUextent", "http://www.govtalk.gov.uk/people/bs7666"));
		}

		public BLPUextentStructure GetBLPUextentAt(int index)
		{
			return new BLPUextentStructure(GetDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "BLPUextent", index));
		}

		public XmlNode GetStartingBLPUextentCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "BLPUextent" );
		}

		public XmlNode GetAdvancedBLPUextentCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "BLPUextent", curNode );
		}

		public BLPUextentStructure GetBLPUextentValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new BLPUextentStructure( curNode );
		}


		public BLPUextentStructure GetBLPUextent()
		{
			return GetBLPUextentAt(0);
		}

		public BLPUextentStructure BLPUextent
		{
			get
			{
				return GetBLPUextentAt(0);
			}
		}

		public void RemoveBLPUextentAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.govtalk.gov.uk/people/bs7666", "BLPUextent", index);
		}

		public void RemoveBLPUextent()
		{
			RemoveBLPUextentAt(0);
		}

		public XmlNode AddBLPUextent(BLPUextentStructure newValue)
		{
			return AppendDomElement("http://www.govtalk.gov.uk/people/bs7666", "BLPUextent", newValue);
		}

		public void InsertBLPUextentAt(BLPUextentStructure newValue, int index)
		{
			InsertDomElementAt("http://www.govtalk.gov.uk/people/bs7666", "BLPUextent", index, newValue);
		}

		public void ReplaceBLPUextentAt(BLPUextentStructure newValue, int index)
		{
			ReplaceDomElementAt("http://www.govtalk.gov.uk/people/bs7666", "BLPUextent", index, newValue);
		}
		#endregion // BLPUextent accessor methods

		#region BLPUextent collection
        public BLPUextentCollection	MyBLPUextents = new BLPUextentCollection( );

        public class BLPUextentCollection: IEnumerable
        {
            ProvenanceStructure parent;
            public ProvenanceStructure Parent
			{
				set
				{
					parent = value;
				}
			}
			public BLPUextentEnumerator GetEnumerator() 
			{
				return new BLPUextentEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class BLPUextentEnumerator: IEnumerator 
        {
			int nIndex;
			ProvenanceStructure parent;
			public BLPUextentEnumerator(ProvenanceStructure par) 
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
				return(nIndex < parent.BLPUextentCount );
			}
			public BLPUextentStructure  Current 
			{
				get 
				{
					return(parent.GetBLPUextentAt(nIndex));
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

        #endregion // BLPUextent collection

        private void SetCollectionParents()
        {
            MyProvenanceCodes.Parent = this; 
            MyAnnotations.Parent = this; 
            MyProvEntryDates.Parent = this; 
            MyProvStartDates.Parent = this; 
            MyProvEndDates.Parent = this; 
            MyProvLastUpdateDates.Parent = this; 
            MyBLPUextents.Parent = this; 
	}
}
}
