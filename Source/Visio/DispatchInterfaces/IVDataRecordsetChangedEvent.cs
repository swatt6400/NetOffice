using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.VisioApi
{
	///<summary>
	/// DispatchInterface IVDataRecordsetChangedEvent 
	/// SupportByVersion Visio, 12,14,15
	///</summary>
	[SupportByVersionAttribute("Visio", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IVDataRecordsetChangedEvent : COMObject
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
                    _type = typeof(IVDataRecordsetChangedEvent);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVDataRecordsetChangedEvent(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVDataRecordsetChangedEvent(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVDataRecordsetChangedEvent(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVDataRecordsetChangedEvent() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVDataRecordsetChangedEvent(string progId) : base(progId)
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
				NetOffice.VisioApi.IVApplication newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVApplication;
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
				NetOffice.VisioApi.IVDataRecordset newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVDataRecordset;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public Int32[] DataRowsAdded
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = (object)Invoker.PropertyGet(this, "DataRowsAdded", paramsArray);
				return (Int32[])returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public Int32[] DataRowsDeleted
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = (object)Invoker.PropertyGet(this, "DataRowsDeleted", paramsArray);
				return (Int32[])returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public String[] DataColumnsAdded
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = (object)Invoker.PropertyGet(this, "DataColumnsAdded", paramsArray);
				return (String[])returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public String[] DataColumnsDeleted
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = (object)Invoker.PropertyGet(this, "DataColumnsDeleted", paramsArray);
				return (String[])returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public String[] DataColumnsChanged
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = (object)Invoker.PropertyGet(this, "DataColumnsChanged", paramsArray);
				return (String[])returnItem;
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}