using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.VisioApi
{
	///<summary>
	/// Interface LPVISIODATACOLUMN 
	/// SupportByVersion Visio, 12,14,15
	///</summary>
	[SupportByVersionAttribute("Visio", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class LPVISIODATACOLUMN : COMObject
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
                    _type = typeof(LPVISIODATACOLUMN);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIODATACOLUMN(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIODATACOLUMN(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIODATACOLUMN(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIODATACOLUMN() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIODATACOLUMN(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public NetOffice.VisioApi.IVApplication Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.VisioApi.IVApplication newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVApplication;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public Int16 Stat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Stat", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public NetOffice.VisioApi.IVDocument Document
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Document", paramsArray);
				NetOffice.VisioApi.IVDocument newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVDocument;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public Int16 ObjectType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ObjectType", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public NetOffice.VisioApi.IVDataRecordset DataRecordset
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataRecordset", paramsArray);
				NetOffice.VisioApi.IVDataRecordset newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVDataRecordset;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public string DisplayName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public bool Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public bool Hyperlink
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Hyperlink", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Hyperlink", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// </summary>
		/// <param name="property">NetOffice.VisioApi.Enums.VisDataColumnProperties Property</param>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public object GetProperty(NetOffice.VisioApi.Enums.VisDataColumnProperties property)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(property);
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
		/// SupportByVersion Visio 12, 14, 15
		/// </summary>
		/// <param name="property">NetOffice.VisioApi.Enums.VisDataColumnProperties Property</param>
		/// <param name="value">object Value</param>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public void SetProperty(NetOffice.VisioApi.Enums.VisDataColumnProperties property, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(property, value);
			Invoker.Method(this, "SetProperty", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}