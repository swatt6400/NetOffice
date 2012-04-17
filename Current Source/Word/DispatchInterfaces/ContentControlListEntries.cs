using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface ContentControlListEntries 
	/// SupportByVersion Word, 12,14
	///</summary>
	[SupportByVersionAttribute("Word", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ContentControlListEntries : COMObject ,IEnumerable<NetOffice.WordApi.ContentControlListEntry>
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
                    _type = typeof(ContentControlListEntries);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ContentControlListEntries(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ContentControlListEntries(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ContentControlListEntries(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ContentControlListEntries() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ContentControlListEntries(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14)]
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
		/// SupportByVersion Word 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14)]
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
		/// SupportByVersion Word 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14)]
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
		/// SupportByVersion Word 12, 14
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14)]
		public void Clear()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Clear", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Word", 12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.WordApi.ContentControlListEntry this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.ContentControlListEntry newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.ContentControlListEntry.LateBindingApiWrapperType) as NetOffice.WordApi.ContentControlListEntry;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="text">string Text</param>
		/// <param name="value">optional string Value = </param>
		/// <param name="index">optional Int32 Index = 0</param>
		[SupportByVersionAttribute("Word", 12,14)]
		public NetOffice.WordApi.ContentControlListEntry Add(string text, string value, Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text, value, index);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.ContentControlListEntry newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.ContentControlListEntry.LateBindingApiWrapperType) as NetOffice.WordApi.ContentControlListEntry;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="text">string Text</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public NetOffice.WordApi.ContentControlListEntry Add(string text)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.ContentControlListEntry newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.ContentControlListEntry.LateBindingApiWrapperType) as NetOffice.WordApi.ContentControlListEntry;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="text">string Text</param>
		/// <param name="value">optional string Value = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public NetOffice.WordApi.ContentControlListEntry Add(string text, string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text, value);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.ContentControlListEntry newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.ContentControlListEntry.LateBindingApiWrapperType) as NetOffice.WordApi.ContentControlListEntry;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.WordApi.ContentControlListEntry> Member
        
        /// <summary>
		/// SupportByVersionAttribute Word, 12,14
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14)]
       public IEnumerator<NetOffice.WordApi.ContentControlListEntry> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.WordApi.ContentControlListEntry item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Word, 12,14
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return LateBindingApi.Core.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}