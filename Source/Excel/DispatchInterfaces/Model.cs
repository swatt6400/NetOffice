using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface Model 
	/// SupportByVersion Excel, 15
	///</summary>
	[SupportByVersionAttribute("Excel", 15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Model : COMObject
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
                    _type = typeof(Model);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Model(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Model(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Model(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Model() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Model(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlCreator)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.ModelTables ModelTables
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ModelTables", paramsArray);
				NetOffice.ExcelApi.ModelTables newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.ModelTables.LateBindingApiWrapperType) as NetOffice.ExcelApi.ModelTables;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.ModelRelationships ModelRelationships
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ModelRelationships", paramsArray);
				NetOffice.ExcelApi.ModelRelationships newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.ModelRelationships.LateBindingApiWrapperType) as NetOffice.ExcelApi.ModelRelationships;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.WorkbookConnection DataModelConnection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataModelConnection", paramsArray);
				NetOffice.ExcelApi.WorkbookConnection newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 15
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
		public void Refresh()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Refresh", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// </summary>
		/// <param name="connectionToDataSource">NetOffice.ExcelApi.WorkbookConnection ConnectionToDataSource</param>
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.WorkbookConnection AddConnection(NetOffice.ExcelApi.WorkbookConnection connectionToDataSource)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(connectionToDataSource);
			object returnItem = Invoker.MethodReturn(this, "AddConnection", paramsArray);
			NetOffice.ExcelApi.WorkbookConnection newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// </summary>
		/// <param name="modelTable">object ModelTable</param>
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.WorkbookConnection CreateModelWorkbookConnection(object modelTable)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(modelTable);
			object returnItem = Invoker.MethodReturn(this, "CreateModelWorkbookConnection", paramsArray);
			NetOffice.ExcelApi.WorkbookConnection newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
		public void Initialize()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Initialize", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}