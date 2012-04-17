using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface _Categories 
	/// SupportByVersion Outlook, 12,14
	///</summary>
	[SupportByVersionAttribute("Outlook", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Categories : COMObject ,IEnumerable<NetOffice.OutlookApi._Category>
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
                    _type = typeof(_Categories);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Categories(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Categories(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Categories(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Categories() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Categories(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
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
		/// SupportByVersion Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public object Parent
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
		/// SupportByVersion Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
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
		/// SupportByVersion Outlook 12, 14
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Outlook", 12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OutlookApi._Category this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.OutlookApi._Category newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Category;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="color">optional object Color</param>
		/// <param name="shortcutKey">optional object ShortcutKey</param>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi.Category Add(string name, object color, object shortcutKey)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, color, shortcutKey);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OutlookApi.Category newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.Category.LateBindingApiWrapperType) as NetOffice.OutlookApi.Category;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// </summary>
		/// <param name="name">string Name</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi.Category Add(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OutlookApi.Category newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.Category.LateBindingApiWrapperType) as NetOffice.OutlookApi.Category;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="color">optional object Color</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 12,14)]
		public NetOffice.OutlookApi.Category Add(string name, object color)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, color);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OutlookApi.Category newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.Category.LateBindingApiWrapperType) as NetOffice.OutlookApi.Category;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public void Remove(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Remove", paramsArray);
		}

		#endregion
       #region IEnumerable<NetOffice.OutlookApi._Category> Member
        
        /// <summary>
		/// SupportByVersionAttribute Outlook, 12,14
		/// This is a custom enumerator from NetOffice
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
        [CustomEnumerator]
       public IEnumerator<NetOffice.OutlookApi._Category> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.OutlookApi._Category item in innerEnumerator)
               yield return item;
       }

       #endregion
   
       #region IEnumerable Members
        
       /// <summary>
		/// SupportByVersionAttribute Outlook, 12,14
		/// This is a custom enumerator from NetOffice
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
        [CustomEnumerator]
        IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
       {
            int count = Count;
            object[] enumeratorObjects = new object[count];
            for (int i = 0; i < count; i++)
                enumeratorObjects[i] = this[i+1];

            foreach (object item in enumeratorObjects)
                yield return item;
       }

       #endregion
       		#pragma warning restore
	}
}