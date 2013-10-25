using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface Envelope 
	/// SupportByVersion Word, 9,10,11,12,14,15
	///</summary>
	///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff844948.aspx </remarks>
	[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Envelope : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Envelope);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public Envelope(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Envelope(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Envelope(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Envelope(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Envelope(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Envelope() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Envelope(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839987.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837451.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837283.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff844876.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Range Address
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Address", paramsArray);
				NetOffice.WordApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Range.LateBindingApiWrapperType) as NetOffice.WordApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838288.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Range ReturnAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReturnAddress", paramsArray);
				NetOffice.WordApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Range.LateBindingApiWrapperType) as NetOffice.WordApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public bool DefaultPrintBarCode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultPrintBarCode", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultPrintBarCode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845764.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public bool DefaultPrintFIMA
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultPrintFIMA", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultPrintFIMA", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195334.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Single DefaultHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultHeight", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultHeight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff192764.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Single DefaultWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultWidth", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff192360.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public string DefaultSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultSize", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838668.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public bool DefaultOmitReturnAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultOmitReturnAddress", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultOmitReturnAddress", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837953.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Enums.WdPaperTray FeedSource
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FeedSource", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.WordApi.Enums.WdPaperTray)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FeedSource", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194709.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Single AddressFromLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AddressFromLeft", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AddressFromLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194512.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Single AddressFromTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AddressFromTop", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AddressFromTop", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836104.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Single ReturnAddressFromLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReturnAddressFromLeft", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReturnAddressFromLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845802.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Single ReturnAddressFromTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReturnAddressFromTop", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReturnAddressFromTop", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194331.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Style AddressStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AddressStyle", paramsArray);
				NetOffice.WordApi.Style newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Style.LateBindingApiWrapperType) as NetOffice.WordApi.Style;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838363.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Style ReturnAddressStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReturnAddressStyle", paramsArray);
				NetOffice.WordApi.Style newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Style.LateBindingApiWrapperType) as NetOffice.WordApi.Style;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836699.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Enums.WdEnvelopeOrientation DefaultOrientation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultOrientation", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.WordApi.Enums.WdEnvelopeOrientation)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultOrientation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838355.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public bool DefaultFaceUp
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultFaceUp", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultFaceUp", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff192380.aspx </remarks>
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public bool Vertical
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Vertical", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Vertical", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838725.aspx </remarks>
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public Single RecipientNamefromLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecipientNamefromLeft", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RecipientNamefromLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196823.aspx </remarks>
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public Single RecipientNamefromTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecipientNamefromTop", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RecipientNamefromTop", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838472.aspx </remarks>
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public Single RecipientPostalfromLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecipientPostalfromLeft", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RecipientPostalfromLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837337.aspx </remarks>
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public Single RecipientPostalfromTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecipientPostalfromTop", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RecipientPostalfromTop", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194048.aspx </remarks>
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public Single SenderNamefromLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SenderNamefromLeft", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SenderNamefromLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff844790.aspx </remarks>
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public Single SenderNamefromTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SenderNamefromTop", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SenderNamefromTop", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194353.aspx </remarks>
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public Single SenderPostalfromLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SenderPostalfromLeft", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SenderPostalfromLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835494.aspx </remarks>
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public Single SenderPostalfromTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SenderPostalfromTop", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SenderPostalfromTop", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		/// <param name="vertical">optional object Vertical</param>
		/// <param name="recipientNamefromLeft">optional object RecipientNamefromLeft</param>
		/// <param name="recipientNamefromTop">optional object RecipientNamefromTop</param>
		/// <param name="recipientPostalfromLeft">optional object RecipientPostalfromLeft</param>
		/// <param name="recipientPostalfromTop">optional object RecipientPostalfromTop</param>
		/// <param name="senderNamefromLeft">optional object SenderNamefromLeft</param>
		/// <param name="senderNamefromTop">optional object SenderNamefromTop</param>
		/// <param name="senderPostalfromLeft">optional object SenderPostalfromLeft</param>
		/// <param name="senderPostalfromTop">optional object SenderPostalfromTop</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical, object recipientNamefromLeft, object recipientNamefromTop, object recipientPostalfromLeft, object recipientPostalfromTop, object senderNamefromLeft, object senderNamefromTop, object senderPostalfromLeft, object senderPostalfromTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical, recipientNamefromLeft, recipientNamefromTop, recipientPostalfromLeft, recipientPostalfromTop, senderNamefromLeft, senderNamefromTop, senderPostalfromLeft, senderPostalfromTop);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(object extractAddress)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(object extractAddress, object address)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		/// <param name="vertical">optional object Vertical</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		/// <param name="vertical">optional object Vertical</param>
		/// <param name="recipientNamefromLeft">optional object RecipientNamefromLeft</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical, object recipientNamefromLeft)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical, recipientNamefromLeft);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		/// <param name="vertical">optional object Vertical</param>
		/// <param name="recipientNamefromLeft">optional object RecipientNamefromLeft</param>
		/// <param name="recipientNamefromTop">optional object RecipientNamefromTop</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical, object recipientNamefromLeft, object recipientNamefromTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical, recipientNamefromLeft, recipientNamefromTop);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		/// <param name="vertical">optional object Vertical</param>
		/// <param name="recipientNamefromLeft">optional object RecipientNamefromLeft</param>
		/// <param name="recipientNamefromTop">optional object RecipientNamefromTop</param>
		/// <param name="recipientPostalfromLeft">optional object RecipientPostalfromLeft</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical, object recipientNamefromLeft, object recipientNamefromTop, object recipientPostalfromLeft)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical, recipientNamefromLeft, recipientNamefromTop, recipientPostalfromLeft);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		/// <param name="vertical">optional object Vertical</param>
		/// <param name="recipientNamefromLeft">optional object RecipientNamefromLeft</param>
		/// <param name="recipientNamefromTop">optional object RecipientNamefromTop</param>
		/// <param name="recipientPostalfromLeft">optional object RecipientPostalfromLeft</param>
		/// <param name="recipientPostalfromTop">optional object RecipientPostalfromTop</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical, object recipientNamefromLeft, object recipientNamefromTop, object recipientPostalfromLeft, object recipientPostalfromTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical, recipientNamefromLeft, recipientNamefromTop, recipientPostalfromLeft, recipientPostalfromTop);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		/// <param name="vertical">optional object Vertical</param>
		/// <param name="recipientNamefromLeft">optional object RecipientNamefromLeft</param>
		/// <param name="recipientNamefromTop">optional object RecipientNamefromTop</param>
		/// <param name="recipientPostalfromLeft">optional object RecipientPostalfromLeft</param>
		/// <param name="recipientPostalfromTop">optional object RecipientPostalfromTop</param>
		/// <param name="senderNamefromLeft">optional object SenderNamefromLeft</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical, object recipientNamefromLeft, object recipientNamefromTop, object recipientPostalfromLeft, object recipientPostalfromTop, object senderNamefromLeft)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical, recipientNamefromLeft, recipientNamefromTop, recipientPostalfromLeft, recipientPostalfromTop, senderNamefromLeft);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		/// <param name="vertical">optional object Vertical</param>
		/// <param name="recipientNamefromLeft">optional object RecipientNamefromLeft</param>
		/// <param name="recipientNamefromTop">optional object RecipientNamefromTop</param>
		/// <param name="recipientPostalfromLeft">optional object RecipientPostalfromLeft</param>
		/// <param name="recipientPostalfromTop">optional object RecipientPostalfromTop</param>
		/// <param name="senderNamefromLeft">optional object SenderNamefromLeft</param>
		/// <param name="senderNamefromTop">optional object SenderNamefromTop</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical, object recipientNamefromLeft, object recipientNamefromTop, object recipientPostalfromLeft, object recipientPostalfromTop, object senderNamefromLeft, object senderNamefromTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical, recipientNamefromLeft, recipientNamefromTop, recipientPostalfromLeft, recipientPostalfromTop, senderNamefromLeft, senderNamefromTop);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		/// <param name="vertical">optional object Vertical</param>
		/// <param name="recipientNamefromLeft">optional object RecipientNamefromLeft</param>
		/// <param name="recipientNamefromTop">optional object RecipientNamefromTop</param>
		/// <param name="recipientPostalfromLeft">optional object RecipientPostalfromLeft</param>
		/// <param name="recipientPostalfromTop">optional object RecipientPostalfromTop</param>
		/// <param name="senderNamefromLeft">optional object SenderNamefromLeft</param>
		/// <param name="senderNamefromTop">optional object SenderNamefromTop</param>
		/// <param name="senderPostalfromLeft">optional object SenderPostalfromLeft</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198190.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical, object recipientNamefromLeft, object recipientNamefromTop, object recipientPostalfromLeft, object recipientPostalfromTop, object senderNamefromLeft, object senderNamefromTop, object senderPostalfromLeft)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical, recipientNamefromLeft, recipientNamefromTop, recipientPostalfromLeft, recipientPostalfromTop, senderNamefromLeft, senderNamefromTop, senderPostalfromLeft);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		/// <param name="vertical">optional object Vertical</param>
		/// <param name="recipientNamefromLeft">optional object RecipientNamefromLeft</param>
		/// <param name="recipientNamefromTop">optional object RecipientNamefromTop</param>
		/// <param name="recipientPostalfromLeft">optional object RecipientPostalfromLeft</param>
		/// <param name="recipientPostalfromTop">optional object RecipientPostalfromTop</param>
		/// <param name="senderNamefromLeft">optional object SenderNamefromLeft</param>
		/// <param name="senderNamefromTop">optional object SenderNamefromTop</param>
		/// <param name="senderPostalfromLeft">optional object SenderPostalfromLeft</param>
		/// <param name="senderPostalfromTop">optional object SenderPostalfromTop</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical, object recipientNamefromLeft, object recipientNamefromTop, object recipientPostalfromLeft, object recipientPostalfromTop, object senderNamefromLeft, object senderNamefromTop, object senderPostalfromLeft, object senderPostalfromTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical, recipientNamefromLeft, recipientNamefromTop, recipientPostalfromLeft, recipientPostalfromTop, senderNamefromLeft, senderNamefromTop, senderPostalfromLeft, senderPostalfromTop);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut(object extractAddress)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		/// <param name="vertical">optional object Vertical</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		/// <param name="vertical">optional object Vertical</param>
		/// <param name="recipientNamefromLeft">optional object RecipientNamefromLeft</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical, object recipientNamefromLeft)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical, recipientNamefromLeft);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		/// <param name="vertical">optional object Vertical</param>
		/// <param name="recipientNamefromLeft">optional object RecipientNamefromLeft</param>
		/// <param name="recipientNamefromTop">optional object RecipientNamefromTop</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical, object recipientNamefromLeft, object recipientNamefromTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical, recipientNamefromLeft, recipientNamefromTop);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		/// <param name="vertical">optional object Vertical</param>
		/// <param name="recipientNamefromLeft">optional object RecipientNamefromLeft</param>
		/// <param name="recipientNamefromTop">optional object RecipientNamefromTop</param>
		/// <param name="recipientPostalfromLeft">optional object RecipientPostalfromLeft</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical, object recipientNamefromLeft, object recipientNamefromTop, object recipientPostalfromLeft)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical, recipientNamefromLeft, recipientNamefromTop, recipientPostalfromLeft);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		/// <param name="vertical">optional object Vertical</param>
		/// <param name="recipientNamefromLeft">optional object RecipientNamefromLeft</param>
		/// <param name="recipientNamefromTop">optional object RecipientNamefromTop</param>
		/// <param name="recipientPostalfromLeft">optional object RecipientPostalfromLeft</param>
		/// <param name="recipientPostalfromTop">optional object RecipientPostalfromTop</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical, object recipientNamefromLeft, object recipientNamefromTop, object recipientPostalfromLeft, object recipientPostalfromTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical, recipientNamefromLeft, recipientNamefromTop, recipientPostalfromLeft, recipientPostalfromTop);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		/// <param name="vertical">optional object Vertical</param>
		/// <param name="recipientNamefromLeft">optional object RecipientNamefromLeft</param>
		/// <param name="recipientNamefromTop">optional object RecipientNamefromTop</param>
		/// <param name="recipientPostalfromLeft">optional object RecipientPostalfromLeft</param>
		/// <param name="recipientPostalfromTop">optional object RecipientPostalfromTop</param>
		/// <param name="senderNamefromLeft">optional object SenderNamefromLeft</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical, object recipientNamefromLeft, object recipientNamefromTop, object recipientPostalfromLeft, object recipientPostalfromTop, object senderNamefromLeft)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical, recipientNamefromLeft, recipientNamefromTop, recipientPostalfromLeft, recipientPostalfromTop, senderNamefromLeft);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		/// <param name="vertical">optional object Vertical</param>
		/// <param name="recipientNamefromLeft">optional object RecipientNamefromLeft</param>
		/// <param name="recipientNamefromTop">optional object RecipientNamefromTop</param>
		/// <param name="recipientPostalfromLeft">optional object RecipientPostalfromLeft</param>
		/// <param name="recipientPostalfromTop">optional object RecipientPostalfromTop</param>
		/// <param name="senderNamefromLeft">optional object SenderNamefromLeft</param>
		/// <param name="senderNamefromTop">optional object SenderNamefromTop</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical, object recipientNamefromLeft, object recipientNamefromTop, object recipientPostalfromLeft, object recipientPostalfromTop, object senderNamefromLeft, object senderNamefromTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical, recipientNamefromLeft, recipientNamefromTop, recipientPostalfromLeft, recipientPostalfromTop, senderNamefromLeft, senderNamefromTop);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		/// <param name="printEPostage">optional object PrintEPostage</param>
		/// <param name="vertical">optional object Vertical</param>
		/// <param name="recipientNamefromLeft">optional object RecipientNamefromLeft</param>
		/// <param name="recipientNamefromTop">optional object RecipientNamefromTop</param>
		/// <param name="recipientPostalfromLeft">optional object RecipientPostalfromLeft</param>
		/// <param name="recipientPostalfromTop">optional object RecipientPostalfromTop</param>
		/// <param name="senderNamefromLeft">optional object SenderNamefromLeft</param>
		/// <param name="senderNamefromTop">optional object SenderNamefromTop</param>
		/// <param name="senderPostalfromLeft">optional object SenderPostalfromLeft</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197594.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical, object recipientNamefromLeft, object recipientNamefromTop, object recipientPostalfromLeft, object recipientPostalfromTop, object senderNamefromLeft, object senderNamefromTop, object senderPostalfromLeft)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical, recipientNamefromLeft, recipientNamefromTop, recipientPostalfromLeft, recipientPostalfromTop, senderNamefromLeft, senderNamefromTop, senderPostalfromLeft);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197914.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void UpdateDocument()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "UpdateDocument", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000(object extractAddress)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000(object extractAddress, object address)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000(object extractAddress, object address, object autoText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000(object extractAddress, object address, object autoText, object omitReturnAddress)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Insert2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="defaultOrientation">optional object DefaultOrientation</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000(object extractAddress)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000(object extractAddress, object address)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000(object extractAddress, object address, object autoText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000(object extractAddress, object address, object autoText, object omitReturnAddress)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="extractAddress">optional object ExtractAddress</param>
		/// <param name="address">optional object Address</param>
		/// <param name="autoText">optional object AutoText</param>
		/// <param name="omitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="returnAddress">optional object ReturnAddress</param>
		/// <param name="returnAutoText">optional object ReturnAutoText</param>
		/// <param name="printBarCode">optional object PrintBarCode</param>
		/// <param name="printFIMA">optional object PrintFIMA</param>
		/// <param name="size">optional object Size</param>
		/// <param name="height">optional object Height</param>
		/// <param name="width">optional object Width</param>
		/// <param name="feedSource">optional object FeedSource</param>
		/// <param name="addressFromLeft">optional object AddressFromLeft</param>
		/// <param name="addressFromTop">optional object AddressFromTop</param>
		/// <param name="returnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="returnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="defaultFaceUp">optional object DefaultFaceUp</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void PrintOut2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196101.aspx </remarks>
		[SupportByVersionAttribute("Word", 10,11,12,14,15)]
		public void Options()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Options", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}