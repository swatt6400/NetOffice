//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface IUserAccessList 
	/// SupportByLibrary Excel, 10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Excel", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IUserAccessList : COMObject ,IEnumerable<NetOffice.ExcelApi.UserAccess>
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
                    _type = typeof(IUserAccessList);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IUserAccessList(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IUserAccessList(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IUserAccessList(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IUserAccessList() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IUserAccessList(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
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
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.UserAccess this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.ExcelApi.UserAccess newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.UserAccess.LateBindingApiWrapperType) as NetOffice.ExcelApi.UserAccess;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.UserAccess get__Default(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.UserAccess newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.UserAccess.LateBindingApiWrapperType) as NetOffice.ExcelApi.UserAccess;
			return newObject;
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="allowEdit">bool AllowEdit</param>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.UserAccess Add(string name, bool allowEdit)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, allowEdit);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.UserAccess newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.UserAccess.LateBindingApiWrapperType) as NetOffice.ExcelApi.UserAccess;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		public Int32 DeleteAll()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "DeleteAll", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		#endregion

        #region IEnumerable<NetOffice.ExcelApi.UserAccess> Member
		
		/// <summary>
		/// SupportByLibraryAttribute Excel, 10,11,12,14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
        public IEnumerator<NetOffice.ExcelApi.UserAccess> GetEnumerator()  
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.ExcelApi.UserAccess item in innerEnumerator)
                yield return item;
        }

        #endregion
           
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute Excel, 10,11,12,14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy, true);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}