using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.VisioApi
{
	///<summary>
	/// Interface LPVISIOSTATUSBARITEMS 
	/// SupportByVersion Visio, 11,12,14
	///</summary>
	[SupportByVersionAttribute("Visio", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class LPVISIOSTATUSBARITEMS : COMObject ,IEnumerable<NetOffice.VisioApi.IVStatusBarItem>
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
                    _type = typeof(LPVISIOSTATUSBARITEMS);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOSTATUSBARITEMS(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOSTATUSBARITEMS(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOSTATUSBARITEMS(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOSTATUSBARITEMS() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOSTATUSBARITEMS(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="lIndex">Int32 lIndex</param>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.VisioApi.IVStatusBarItem this[Int32 lIndex]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(lIndex);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.VisioApi.IVStatusBarItem newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVStatusBarItem;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
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
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public NetOffice.VisioApi.IVStatusBar Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				NetOffice.VisioApi.IVStatusBar newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVStatusBar;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public NetOffice.VisioApi.IVStatusBarItem ParentItem
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentItem", paramsArray);
				NetOffice.VisioApi.IVStatusBarItem newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVStatusBarItem;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public NetOffice.VisioApi.IVStatusBarItem Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.VisioApi.IVStatusBarItem newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVStatusBarItem;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// </summary>
		/// <param name="lIndex">Int32 lIndex</param>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public NetOffice.VisioApi.IVStatusBarItem AddAt(Int32 lIndex)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(lIndex);
			object returnItem = Invoker.MethodReturn(this, "AddAt", paramsArray);
			NetOffice.VisioApi.IVStatusBarItem newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVStatusBarItem;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.VisioApi.IVStatusBarItem> Member
        
        /// <summary>
		/// SupportByVersionAttribute Visio, 11,12,14
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
       public IEnumerator<NetOffice.VisioApi.IVStatusBarItem> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.VisioApi.IVStatusBarItem item in innerEnumerator)
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