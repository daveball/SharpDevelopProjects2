//
// PhotoType.cs
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
	public class PhotoType : Altova.Xml.Node
	{
		#region Forward constructors

		public PhotoType() : base() { SetCollectionParents(); }

		public PhotoType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public PhotoType(XmlNode node) : base(node) { SetCollectionParents(); }
		public PhotoType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public PhotoType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "Photo" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "Photo", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "ImageType" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "ImageType", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "core:PhotoType");
		}


		#region Photo accessor methods
		public static int GetPhotoMinCount()
		{
			return 1;
		}

		public static int PhotoMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetPhotoMaxCount()
		{
			return 1;
		}

		public static int PhotoMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetPhotoCount()
		{
			return DomChildCount(NodeType.Element, "", "Photo");
		}

		public int PhotoCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Photo");
			}
		}

		public bool HasPhoto()
		{
			return HasDomChild(NodeType.Element, "", "Photo");
		}

		public SchemaString NewPhoto()
		{
			return new SchemaString();
		}

		public SchemaString GetPhotoAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Photo", index)));
		}

		public XmlNode GetStartingPhotoCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "Photo" );
		}

		public XmlNode GetAdvancedPhotoCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "Photo", curNode );
		}

		public SchemaString GetPhotoValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaString( curNode.InnerText );
		}


		public SchemaString GetPhoto()
		{
			return GetPhotoAt(0);
		}

		public SchemaString Photo
		{
			get
			{
				return GetPhotoAt(0);
			}
		}

		public void RemovePhotoAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Photo", index);
		}

		public void RemovePhoto()
		{
			RemovePhotoAt(0);
		}

		public XmlNode AddPhoto(SchemaString newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "Photo", newValue.ToString());
			return null;
		}

		public void InsertPhotoAt(SchemaString newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "Photo", index, newValue.ToString());
		}

		public void ReplacePhotoAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Photo", index, newValue.ToString());
		}
		#endregion // Photo accessor methods

		#region Photo collection
        public PhotoCollection	MyPhotos = new PhotoCollection( );

        public class PhotoCollection: IEnumerable
        {
            PhotoType parent;
            public PhotoType Parent
			{
				set
				{
					parent = value;
				}
			}
			public PhotoEnumerator GetEnumerator() 
			{
				return new PhotoEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class PhotoEnumerator: IEnumerator 
        {
			int nIndex;
			PhotoType parent;
			public PhotoEnumerator(PhotoType par) 
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
				return(nIndex < parent.PhotoCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetPhotoAt(nIndex));
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

        #endregion // Photo collection

		#region ImageType accessor methods
		public static int GetImageTypeMinCount()
		{
			return 1;
		}

		public static int ImageTypeMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetImageTypeMaxCount()
		{
			return 1;
		}

		public static int ImageTypeMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetImageTypeCount()
		{
			return DomChildCount(NodeType.Element, "", "ImageType");
		}

		public int ImageTypeCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "ImageType");
			}
		}

		public bool HasImageType()
		{
			return HasDomChild(NodeType.Element, "", "ImageType");
		}

		public ImageTypeType NewImageType()
		{
			return new ImageTypeType();
		}

		public ImageTypeType GetImageTypeAt(int index)
		{
			return new ImageTypeType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "ImageType", index)));
		}

		public XmlNode GetStartingImageTypeCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "ImageType" );
		}

		public XmlNode GetAdvancedImageTypeCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "ImageType", curNode );
		}

		public ImageTypeType GetImageTypeValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new ImageTypeType( curNode.InnerText );
		}


		public ImageTypeType GetImageType()
		{
			return GetImageTypeAt(0);
		}

		public ImageTypeType ImageType
		{
			get
			{
				return GetImageTypeAt(0);
			}
		}

		public void RemoveImageTypeAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "ImageType", index);
		}

		public void RemoveImageType()
		{
			RemoveImageTypeAt(0);
		}

		public XmlNode AddImageType(ImageTypeType newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "ImageType", newValue.ToString());
			return null;
		}

		public void InsertImageTypeAt(ImageTypeType newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "ImageType", index, newValue.ToString());
		}

		public void ReplaceImageTypeAt(ImageTypeType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "ImageType", index, newValue.ToString());
		}
		#endregion // ImageType accessor methods

		#region ImageType collection
        public ImageTypeCollection	MyImageTypes = new ImageTypeCollection( );

        public class ImageTypeCollection: IEnumerable
        {
            PhotoType parent;
            public PhotoType Parent
			{
				set
				{
					parent = value;
				}
			}
			public ImageTypeEnumerator GetEnumerator() 
			{
				return new ImageTypeEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ImageTypeEnumerator: IEnumerator 
        {
			int nIndex;
			PhotoType parent;
			public ImageTypeEnumerator(PhotoType par) 
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
				return(nIndex < parent.ImageTypeCount );
			}
			public ImageTypeType  Current 
			{
				get 
				{
					return(parent.GetImageTypeAt(nIndex));
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

        #endregion // ImageType collection

        private void SetCollectionParents()
        {
            MyPhotos.Parent = this; 
            MyImageTypes.Parent = this; 
	}
}
}
