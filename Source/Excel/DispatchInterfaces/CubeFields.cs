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
	/// DispatchInterface CubeFields 
	/// SupportByVersion Excel, 9,10,11,12,14,15
	/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839259.aspx
	///</summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class CubeFields : COMObject ,IEnumerable<NetOffice.ExcelApi.CubeField>
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
                    _type = typeof(CubeFields);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public CubeFields(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CubeFields(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CubeFields(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CubeFields(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CubeFields(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CubeFields() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CubeFields(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff841082.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
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
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194016.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
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
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835001.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
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
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836786.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
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
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.CubeField this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.CubeField newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.CubeField.LateBindingApiWrapperType) as NetOffice.ExcelApi.CubeField;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196044.aspx
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="caption">string Caption</param>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.CubeField AddSet(string name, string caption)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, caption);
			object returnItem = Invoker.MethodReturn(this, "AddSet", paramsArray);
			NetOffice.ExcelApi.CubeField newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CubeField.LateBindingApiWrapperType) as NetOffice.ExcelApi.CubeField;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj228159.aspx
		/// </summary>
		/// <param name="attributeHierarchy">object AttributeHierarchy</param>
		/// <param name="function">NetOffice.ExcelApi.Enums.XlConsolidationFunction Function</param>
		/// <param name="caption">optional object Caption</param>
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.CubeField GetMeasure(object attributeHierarchy, NetOffice.ExcelApi.Enums.XlConsolidationFunction function, object caption)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(attributeHierarchy, function, caption);
			object returnItem = Invoker.MethodReturn(this, "GetMeasure", paramsArray);
			NetOffice.ExcelApi.CubeField newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CubeField.LateBindingApiWrapperType) as NetOffice.ExcelApi.CubeField;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj228159.aspx
		/// </summary>
		/// <param name="attributeHierarchy">object AttributeHierarchy</param>
		/// <param name="function">NetOffice.ExcelApi.Enums.XlConsolidationFunction Function</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.CubeField GetMeasure(object attributeHierarchy, NetOffice.ExcelApi.Enums.XlConsolidationFunction function)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(attributeHierarchy, function);
			object returnItem = Invoker.MethodReturn(this, "GetMeasure", paramsArray);
			NetOffice.ExcelApi.CubeField newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CubeField.LateBindingApiWrapperType) as NetOffice.ExcelApi.CubeField;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.ExcelApi.CubeField> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 9,10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
       public IEnumerator<NetOffice.ExcelApi.CubeField> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.ExcelApi.CubeField item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Excel, 9,10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}