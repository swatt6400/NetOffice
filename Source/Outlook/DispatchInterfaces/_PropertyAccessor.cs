using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface _PropertyAccessor 
	/// SupportByVersion Outlook, 12,14,15
	///</summary>
	[SupportByVersionAttribute("Outlook", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _PropertyAccessor : COMObject
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
                    _type = typeof(_PropertyAccessor);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _PropertyAccessor(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _PropertyAccessor(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _PropertyAccessor(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _PropertyAccessor() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _PropertyAccessor(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="schemaName">string SchemaName</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public object GetProperty(string schemaName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(schemaName);
			object returnItem = Invoker.MethodReturn(this, "GetProperty", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="schemaName">string SchemaName</param>
		/// <param name="value">object Value</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void SetProperty(string schemaName, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(schemaName, value);
			Invoker.Method(this, "SetProperty", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="schemaNames">object SchemaNames</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public object GetProperties(object schemaNames)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(schemaNames);
			object returnItem = Invoker.MethodReturn(this, "GetProperties", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="schemaNames">object SchemaNames</param>
		/// <param name="values">object Values</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public object SetProperties(object schemaNames, object values)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(schemaNames, values);
			object returnItem = Invoker.MethodReturn(this, "SetProperties", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="value">DateTime Value</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public DateTime UTCToLocalTime(DateTime value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(this, "UTCToLocalTime", paramsArray);
			return NetRuntimeSystem.Convert.ToDateTime(returnItem);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="value">DateTime Value</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public DateTime LocalTimeToUTC(DateTime value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(this, "LocalTimeToUTC", paramsArray);
			return NetRuntimeSystem.Convert.ToDateTime(returnItem);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="value">string Value</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public object StringToBinary(string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(this, "StringToBinary", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="value">object Value</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public string BinaryToString(object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(this, "BinaryToString", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="schemaName">string SchemaName</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void DeleteProperty(string schemaName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(schemaName);
			Invoker.Method(this, "DeleteProperty", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// </summary>
		/// <param name="schemaNames">object SchemaNames</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public object DeleteProperties(object schemaNames)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(schemaNames);
			object returnItem = Invoker.MethodReturn(this, "DeleteProperties", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		#endregion
		#pragma warning restore
	}
}