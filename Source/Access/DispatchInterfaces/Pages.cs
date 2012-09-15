using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.AccessApi
{
	///<summary>
	/// DispatchInterface Pages 
	/// SupportByVersion Access, 9,10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Pages : COMObject ,IEnumerable<NetOffice.AccessApi.Page>
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
                    _type = typeof(Pages);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Pages(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Pages(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Pages(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Pages() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Pages(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.AccessApi.Page this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.AccessApi.Page newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.AccessApi.Page.LateBindingApiWrapperType) as NetOffice.AccessApi.Page;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="before">optional object Before</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public NetOffice.AccessApi.Page Add(object before)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(before);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.AccessApi.Page newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.AccessApi.Page.LateBindingApiWrapperType) as NetOffice.AccessApi.Page;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public NetOffice.AccessApi.Page Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.AccessApi.Page newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.AccessApi.Page.LateBindingApiWrapperType) as NetOffice.AccessApi.Page;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="item">optional object Item</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public void Remove(object item)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(item);
			Invoker.Method(this, "Remove", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public void Remove()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Remove", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Access 11, 12, 14, 15
		/// </summary>
		/// <param name="dispid">Int32 dispid</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Access", 11,12,14,15)]
		public bool IsMemberSafe(Int32 dispid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dispid);
			object returnItem = Invoker.MethodReturn(this, "IsMemberSafe", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		#endregion

       #region IEnumerable<NetOffice.AccessApi.Page> Member
        
        /// <summary>
		/// SupportByVersionAttribute Access, 9,10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
       public IEnumerator<NetOffice.AccessApi.Page> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.AccessApi.Page item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Access, 9,10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsMethod(this);
		}

		#endregion
		#pragma warning restore
	}
}