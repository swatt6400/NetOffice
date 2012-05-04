using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.VisioApi
{
	///<summary>
	/// DispatchInterface IVLayers 
	/// SupportByVersion Visio, 11,12,14
	///</summary>
	[SupportByVersionAttribute("Visio", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IVLayers : COMObject ,IEnumerable<NetOffice.VisioApi.IVLayer>
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
                    _type = typeof(IVLayers);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVLayers(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVLayers(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVLayers(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVLayers() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVLayers(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
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
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
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
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public NetOffice.VisioApi.IVPage Page
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Page", paramsArray);
				NetOffice.VisioApi.IVPage newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVPage;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public NetOffice.VisioApi.IVMaster Master
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Master", paramsArray);
				NetOffice.VisioApi.IVMaster newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVMaster;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public Int16 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="nameOrIndex">object NameOrIndex</param>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.VisioApi.IVLayer this[object nameOrIndex]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(nameOrIndex);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.VisioApi.IVLayer newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVLayer;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
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
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
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
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public NetOffice.VisioApi.IVEventList EventList
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EventList", paramsArray);
				NetOffice.VisioApi.IVEventList newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVEventList;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public Int16 PersistsEvents
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PersistsEvents", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="nameOrIndex">object NameOrIndex</param>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.VisioApi.IVLayer get_ItemU(object nameOrIndex)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(nameOrIndex);
			object returnItem = Invoker.PropertyGet(this, "ItemU", paramsArray);
			NetOffice.VisioApi.IVLayer newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVLayer;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Alias for get_ItemU
		/// </summary>
		/// <param name="nameOrIndex">object NameOrIndex</param>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public NetOffice.VisioApi.IVLayer ItemU(object nameOrIndex)
		{
			return get_ItemU(nameOrIndex);
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// </summary>
		/// <param name="layerName">string LayerName</param>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public NetOffice.VisioApi.IVLayer Add(string layerName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(layerName);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.VisioApi.IVLayer newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVLayer;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.VisioApi.IVLayer> Member
        
        /// <summary>
		/// SupportByVersionAttribute Visio, 11,12,14
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
       public IEnumerator<NetOffice.VisioApi.IVLayer> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.VisioApi.IVLayer item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Visio, 11,12,14
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}