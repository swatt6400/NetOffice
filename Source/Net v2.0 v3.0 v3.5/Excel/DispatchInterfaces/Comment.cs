//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface Comment SupportByLibrary Excel, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Comment : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Comment);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Comment(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Comment(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Comment(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Comment()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public string Author
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Author", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Shape Shape
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shape", paramsArray);
				NetOffice.ExcelApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Shape;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public bool Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Text">optional object Text</param>
		/// <param name="Start">optional object Start</param>
		/// <param name="Overwrite">optional object Overwrite</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public string Text(object text, object start, object overwrite)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text, start, overwrite);
			object returnItem = Invoker.MethodReturn(this, "Text", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public string Text()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Text", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Comment Next()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Next", paramsArray);
			NetOffice.ExcelApi.Comment newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Comment;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Comment Previous()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Previous", paramsArray);
			NetOffice.ExcelApi.Comment newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Comment;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}