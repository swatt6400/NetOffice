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
	/// DispatchInterface IVGraphicItems 
	/// SupportByVersion Visio, 12,14,15
	///</summary>
	[SupportByVersionAttribute("Visio", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IVGraphicItems : COMObject ,IEnumerable<NetOffice.VisioApi.IVGraphicItem>
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
                    _type = typeof(IVGraphicItems);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVGraphicItems(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVGraphicItems(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVGraphicItems(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVGraphicItems() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVGraphicItems(string progId) : base(progId)
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
		public NetOffice.VisioApi.IVDocument Document
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Document", paramsArray);
				NetOffice.VisioApi.IVDocument newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVDocument;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public NetOffice.VisioApi.Enums.VisObjectTypes ObjectType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ObjectType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.VisioApi.Enums.VisObjectTypes)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public NetOffice.VisioApi.IVMaster DataGraphic
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataGraphic", paramsArray);
				NetOffice.VisioApi.IVMaster newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVMaster;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.VisioApi.IVGraphicItem this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.VisioApi.IVGraphicItem newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVGraphicItem;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="objectID">Int32 ObjectID</param>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.VisioApi.IVGraphicItem get_ItemFromID(Int32 objectID)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(objectID);
			object returnItem = Invoker.PropertyGet(this, "ItemFromID", paramsArray);
			NetOffice.VisioApi.IVGraphicItem newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVGraphicItem;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Alias for get_ItemFromID
		/// </summary>
		/// <param name="objectID">Int32 ObjectID</param>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public NetOffice.VisioApi.IVGraphicItem ItemFromID(Int32 objectID)
		{
			return get_ItemFromID(objectID);
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

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// </summary>
		/// <param name="graphicItem">NetOffice.VisioApi.IVGraphicItem GraphicItem</param>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public NetOffice.VisioApi.IVGraphicItem AddCopy(NetOffice.VisioApi.IVGraphicItem graphicItem)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(graphicItem);
			object returnItem = Invoker.MethodReturn(this, "AddCopy", paramsArray);
			NetOffice.VisioApi.IVGraphicItem newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVGraphicItem;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.VisioApi.IVGraphicItem> Member
        
        /// <summary>
		/// SupportByVersionAttribute Visio, 12,14,15
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
       public IEnumerator<NetOffice.VisioApi.IVGraphicItem> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.VisioApi.IVGraphicItem item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Visio, 12,14,15
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}