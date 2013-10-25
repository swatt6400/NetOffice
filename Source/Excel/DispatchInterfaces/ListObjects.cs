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
	/// DispatchInterface ListObjects 
	/// SupportByVersion Excel, 11,12,14,15
	///</summary>
	///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196851.aspx </remarks>
	[SupportByVersionAttribute("Excel", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ListObjects : COMObject ,IEnumerable<NetOffice.ExcelApi.ListObject>
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
                    _type = typeof(ListObjects);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public ListObjects(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObjects(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObjects(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObjects(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObjects(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObjects() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObjects(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834429.aspx </remarks>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
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
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822511.aspx </remarks>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
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
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197718.aspx </remarks>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
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
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.ListObject this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.ListObject.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListObject;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837797.aspx </remarks>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
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
		/// SupportByVersion Excel 11, 12, 14, 15
		/// </summary>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		/// <param name="source">optional object Source</param>
		/// <param name="linkSource">optional object LinkSource</param>
		/// <param name="xlListObjectHasHeaders">optional NetOffice.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders = 0</param>
		/// <param name="destination">optional object Destination</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff823155.aspx </remarks>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public NetOffice.ExcelApi.ListObject Add(object sourceType, object source, object linkSource, object xlListObjectHasHeaders, object destination)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source, linkSource, xlListObjectHasHeaders, destination);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ListObject.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		/// <param name="source">optional object Source</param>
		/// <param name="linkSource">optional object LinkSource</param>
		/// <param name="xlListObjectHasHeaders">optional NetOffice.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders = 0</param>
		/// <param name="destination">optional object Destination</param>
		/// <param name="tableStyleName">optional object TableStyleName</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff823155.aspx </remarks>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.ListObject Add(object sourceType, object source, object linkSource, object xlListObjectHasHeaders, object destination, object tableStyleName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source, linkSource, xlListObjectHasHeaders, destination, tableStyleName);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ListObject.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff823155.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public NetOffice.ExcelApi.ListObject Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ListObject.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// </summary>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff823155.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public NetOffice.ExcelApi.ListObject Add(object sourceType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ListObject.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// </summary>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		/// <param name="source">optional object Source</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff823155.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public NetOffice.ExcelApi.ListObject Add(object sourceType, object source)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ListObject.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// </summary>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		/// <param name="source">optional object Source</param>
		/// <param name="linkSource">optional object LinkSource</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff823155.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public NetOffice.ExcelApi.ListObject Add(object sourceType, object source, object linkSource)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source, linkSource);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ListObject.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15
		/// </summary>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		/// <param name="source">optional object Source</param>
		/// <param name="linkSource">optional object LinkSource</param>
		/// <param name="xlListObjectHasHeaders">optional NetOffice.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders = 0</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff823155.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		public NetOffice.ExcelApi.ListObject Add(object sourceType, object source, object linkSource, object xlListObjectHasHeaders)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source, linkSource, xlListObjectHasHeaders);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ListObject.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		/// <param name="source">optional object Source</param>
		/// <param name="linkSource">optional object LinkSource</param>
		/// <param name="xlListObjectHasHeaders">optional NetOffice.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders = 0</param>
		/// <param name="destination">optional object Destination</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.ListObject _Add(object sourceType, object source, object linkSource, object xlListObjectHasHeaders, object destination)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source, linkSource, xlListObjectHasHeaders, destination);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ListObject.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.ListObject _Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ListObject.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.ListObject _Add(object sourceType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ListObject.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		/// <param name="source">optional object Source</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.ListObject _Add(object sourceType, object source)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ListObject.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		/// <param name="source">optional object Source</param>
		/// <param name="linkSource">optional object LinkSource</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.ListObject _Add(object sourceType, object source, object linkSource)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source, linkSource);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ListObject.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		/// <param name="source">optional object Source</param>
		/// <param name="linkSource">optional object LinkSource</param>
		/// <param name="xlListObjectHasHeaders">optional NetOffice.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders = 0</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.ListObject _Add(object sourceType, object source, object linkSource, object xlListObjectHasHeaders)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source, linkSource, xlListObjectHasHeaders);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ListObject.LateBindingApiWrapperType) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.ExcelApi.ListObject> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
       public IEnumerator<NetOffice.ExcelApi.ListObject> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.ExcelApi.ListObject item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Excel, 11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 11,12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}