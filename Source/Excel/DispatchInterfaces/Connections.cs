using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface Connections 
	/// SupportByVersion Excel, 12,14,15
	/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196294.aspx
	///</summary>
	[SupportByVersionAttribute("Excel", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Connections : COMObject ,IEnumerable<NetOffice.ExcelApi.WorkbookConnection>
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
                    _type = typeof(Connections);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public Connections(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connections(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connections(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connections(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connections(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connections() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connections(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838431.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840518.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
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
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834962.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839189.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
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
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.WorkbookConnection this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.WorkbookConnection newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195309.aspx
		/// </summary>
		/// <param name="filename">string Filename</param>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.WorkbookConnection AddFromFile(string filename)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename);
			object returnItem = Invoker.MethodReturn(this, "AddFromFile", paramsArray);
			NetOffice.ExcelApi.WorkbookConnection newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195309.aspx
		/// </summary>
		/// <param name="filename">string Filename</param>
		/// <param name="createModelConnection">optional object CreateModelConnection</param>
		/// <param name="importRelationships">optional object ImportRelationships</param>
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.WorkbookConnection AddFromFile(string filename, object createModelConnection, object importRelationships)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, createModelConnection, importRelationships);
			object returnItem = Invoker.MethodReturn(this, "AddFromFile", paramsArray);
			NetOffice.ExcelApi.WorkbookConnection newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195309.aspx
		/// </summary>
		/// <param name="filename">string Filename</param>
		/// <param name="createModelConnection">optional object CreateModelConnection</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.WorkbookConnection AddFromFile(string filename, object createModelConnection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, createModelConnection);
			object returnItem = Invoker.MethodReturn(this, "AddFromFile", paramsArray);
			NetOffice.ExcelApi.WorkbookConnection newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// 
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="description">string Description</param>
		/// <param name="connectionString">object ConnectionString</param>
		/// <param name="commandText">object CommandText</param>
		/// <param name="lCmdtype">optional object lCmdtype</param>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.WorkbookConnection Add(string name, string description, object connectionString, object commandText, object lCmdtype)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, description, connectionString, commandText, lCmdtype);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.WorkbookConnection newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// 
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="description">string Description</param>
		/// <param name="connectionString">object ConnectionString</param>
		/// <param name="commandText">object CommandText</param>
		/// <param name="lCmdtype">optional object lCmdtype</param>
		/// <param name="createModelConnection">optional object CreateModelConnection</param>
		/// <param name="importRelationships">optional object ImportRelationships</param>
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.WorkbookConnection Add(string name, string description, object connectionString, object commandText, object lCmdtype, object createModelConnection, object importRelationships)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, description, connectionString, commandText, lCmdtype, createModelConnection, importRelationships);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.WorkbookConnection newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// 
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="description">string Description</param>
		/// <param name="connectionString">object ConnectionString</param>
		/// <param name="commandText">object CommandText</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.WorkbookConnection Add(string name, string description, object connectionString, object commandText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, description, connectionString, commandText);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.WorkbookConnection newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// 
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="description">string Description</param>
		/// <param name="connectionString">object ConnectionString</param>
		/// <param name="commandText">object CommandText</param>
		/// <param name="lCmdtype">optional object lCmdtype</param>
		/// <param name="createModelConnection">optional object CreateModelConnection</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.WorkbookConnection Add(string name, string description, object connectionString, object commandText, object lCmdtype, object createModelConnection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, description, connectionString, commandText, lCmdtype, createModelConnection);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.WorkbookConnection newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// 
		/// </summary>
		/// <param name="filename">string Filename</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.WorkbookConnection _AddFromFile(string filename)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename);
			object returnItem = Invoker.MethodReturn(this, "_AddFromFile", paramsArray);
			NetOffice.ExcelApi.WorkbookConnection newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// 
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="description">string Description</param>
		/// <param name="connectionString">object ConnectionString</param>
		/// <param name="commandText">object CommandText</param>
		/// <param name="lCmdtype">optional object lCmdtype</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.WorkbookConnection _Add(string name, string description, object connectionString, object commandText, object lCmdtype)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, description, connectionString, commandText, lCmdtype);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.WorkbookConnection newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// 
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="description">string Description</param>
		/// <param name="connectionString">object ConnectionString</param>
		/// <param name="commandText">object CommandText</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.WorkbookConnection _Add(string name, string description, object connectionString, object commandText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, description, connectionString, commandText);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.WorkbookConnection newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.ExcelApi.WorkbookConnection> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 12,14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
       public IEnumerator<NetOffice.ExcelApi.WorkbookConnection> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.ExcelApi.WorkbookConnection item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Excel, 12,14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}