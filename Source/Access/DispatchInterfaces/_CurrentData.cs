using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.AccessApi
{
	///<summary>
	/// DispatchInterface _CurrentData 
	/// SupportByVersion Access, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Access", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _CurrentData : COMObject
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
                    _type = typeof(_CurrentData);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CurrentData(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CurrentData(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CurrentData(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CurrentData() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CurrentData(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14)]
		public NetOffice.AccessApi.AllTables AllTables
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllTables", paramsArray);
				NetOffice.AccessApi.AllTables newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.AccessApi.AllTables.LateBindingApiWrapperType) as NetOffice.AccessApi.AllTables;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14)]
		public NetOffice.AccessApi.AllQueries AllQueries
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllQueries", paramsArray);
				NetOffice.AccessApi.AllQueries newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.AccessApi.AllQueries.LateBindingApiWrapperType) as NetOffice.AccessApi.AllQueries;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14)]
		public NetOffice.AccessApi.AllViews AllViews
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllViews", paramsArray);
				NetOffice.AccessApi.AllViews newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.AccessApi.AllViews.LateBindingApiWrapperType) as NetOffice.AccessApi.AllViews;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14)]
		public NetOffice.AccessApi.AllStoredProcedures AllStoredProcedures
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllStoredProcedures", paramsArray);
				NetOffice.AccessApi.AllStoredProcedures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.AccessApi.AllStoredProcedures.LateBindingApiWrapperType) as NetOffice.AccessApi.AllStoredProcedures;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14)]
		public NetOffice.AccessApi.AllDatabaseDiagrams AllDatabaseDiagrams
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllDatabaseDiagrams", paramsArray);
				NetOffice.AccessApi.AllDatabaseDiagrams newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.AccessApi.AllDatabaseDiagrams.LateBindingApiWrapperType) as NetOffice.AccessApi.AllDatabaseDiagrams;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 10,11,12,14)]
		public NetOffice.AccessApi.AllFunctions AllFunctions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllFunctions", paramsArray);
				NetOffice.AccessApi.AllFunctions newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.AccessApi.AllFunctions.LateBindingApiWrapperType) as NetOffice.AccessApi.AllFunctions;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Access 11, 12, 14
		/// </summary>
		/// <param name="dispid">Int32 dispid</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Access", 11,12,14)]
		public bool IsMemberSafe(Int32 dispid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dispid);
			object returnItem = Invoker.MethodReturn(this, "IsMemberSafe", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		#endregion
		#pragma warning restore
	}
}