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
	/// DispatchInterface Frame 
	/// SupportByVersion Word, 9,10,11,12,14,15
	///</summary>
	///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838720.aspx </remarks>
	[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Frame : COMObject
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
                    _type = typeof(Frame);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public Frame(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Frame(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Frame(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Frame(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Frame(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Frame() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Frame(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff192383.aspx </remarks>
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
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff844850.aspx </remarks>
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
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840298.aspx </remarks>
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
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840683.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Enums.WdFrameSizeRule HeightRule
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HeightRule", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.WordApi.Enums.WdFrameSizeRule)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HeightRule", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838327.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Enums.WdFrameSizeRule WidthRule
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WidthRule", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.WordApi.Enums.WdFrameSizeRule)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WidthRule", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194339.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Single HorizontalDistanceFromText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HorizontalDistanceFromText", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HorizontalDistanceFromText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834569.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Single Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Height", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839718.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Single HorizontalPosition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HorizontalPosition", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HorizontalPosition", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197299.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public bool LockAnchor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LockAnchor", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LockAnchor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff841079.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Enums.WdRelativeHorizontalPosition RelativeHorizontalPosition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RelativeHorizontalPosition", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.WordApi.Enums.WdRelativeHorizontalPosition)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RelativeHorizontalPosition", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198285.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Enums.WdRelativeVerticalPosition RelativeVerticalPosition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RelativeVerticalPosition", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.WordApi.Enums.WdRelativeVerticalPosition)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RelativeVerticalPosition", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845913.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Single VerticalDistanceFromText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VerticalDistanceFromText", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "VerticalDistanceFromText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196281.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Single VerticalPosition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VerticalPosition", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "VerticalPosition", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836554.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Single Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Width", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194727.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public bool TextWrap
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextWrap", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TextWrap", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821644.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Shading Shading
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shading", paramsArray);
				NetOffice.WordApi.Shading newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Shading.LateBindingApiWrapperType) as NetOffice.WordApi.Shading;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff193121.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Borders Borders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Borders", paramsArray);
				NetOffice.WordApi.Borders newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Borders.LateBindingApiWrapperType) as NetOffice.WordApi.Borders;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Borders", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836638.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Range Range
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
				NetOffice.WordApi.Range newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Range.LateBindingApiWrapperType) as NetOffice.WordApi.Range;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff844788.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff193138.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845179.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Copy()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Copy", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194624.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Cut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cut", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}