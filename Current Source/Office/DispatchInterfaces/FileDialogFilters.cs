using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface FileDialogFilters 
	/// SupportByVersion Office, 10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Office", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class FileDialogFilters : _IMsoDispObj ,IEnumerable<NetOffice.OfficeApi.FileDialogFilter>
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
                    _type = typeof(FileDialogFilters);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileDialogFilters(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileDialogFilters(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileDialogFilters(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileDialogFilters() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileDialogFilters(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
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
		/// SupportByVersion Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
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
		/// SupportByVersion Office 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.FileDialogFilter this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.OfficeApi.FileDialogFilter newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.FileDialogFilter.LateBindingApiWrapperType) as NetOffice.OfficeApi.FileDialogFilter;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// </summary>
		/// <param name="filter">optional object filter</param>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		public void Delete(object filter)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filter);
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		public void Clear()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Clear", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// </summary>
		/// <param name="description">string Description</param>
		/// <param name="extensions">string Extensions</param>
		/// <param name="position">optional object Position</param>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.FileDialogFilter Add(string description, string extensions, object position)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(description, extensions, position);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.FileDialogFilter newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.FileDialogFilter.LateBindingApiWrapperType) as NetOffice.OfficeApi.FileDialogFilter;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// </summary>
		/// <param name="description">string Description</param>
		/// <param name="extensions">string Extensions</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.FileDialogFilter Add(string description, string extensions)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(description, extensions);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.FileDialogFilter newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.FileDialogFilter.LateBindingApiWrapperType) as NetOffice.OfficeApi.FileDialogFilter;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.OfficeApi.FileDialogFilter> Member
        
        /// <summary>
		/// SupportByVersionAttribute Office, 10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
       public IEnumerator<NetOffice.OfficeApi.FileDialogFilter> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.OfficeApi.FileDialogFilter item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Office, 10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return LateBindingApi.Core.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}