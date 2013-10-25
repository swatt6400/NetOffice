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
	/// DispatchInterface CalculatedItems 
	/// SupportByVersion Excel, 9,10,11,12,14,15
	///</summary>
	///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839820.aspx </remarks>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class CalculatedItems : COMObject ,IEnumerable<NetOffice.ExcelApi.PivotItem>
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
                    _type = typeof(CalculatedItems);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public CalculatedItems(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CalculatedItems(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CalculatedItems(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CalculatedItems(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CalculatedItems(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CalculatedItems() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CalculatedItems(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840461.aspx </remarks>
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
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197883.aspx </remarks>
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
		/// Unknown COM Proxy
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834647.aspx </remarks>
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
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835194.aspx </remarks>
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
		/// <param name="field">object Field</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.PivotItem this[object field]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(field);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.PivotItem newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.PivotItem.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotItem;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="formula">string Formula</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195712.aspx </remarks>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.PivotItem Add(string name, string formula)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.PivotItem newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotItem.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotItem;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="formula">string Formula</param>
		/// <param name="useStandardFormula">optional object UseStandardFormula</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195712.aspx </remarks>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.PivotItem Add(string name, string formula, object useStandardFormula)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula, useStandardFormula);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.PivotItem newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotItem.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotItem;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="formula">string Formula</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.PivotItem _Add(string name, string formula)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.PivotItem newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.PivotItem.LateBindingApiWrapperType) as NetOffice.ExcelApi.PivotItem;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.ExcelApi.PivotItem> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 9,10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
       public IEnumerator<NetOffice.ExcelApi.PivotItem> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.ExcelApi.PivotItem item in innerEnumerator)
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
			return NetOffice.Utils.GetProxyEnumeratorAsMethod(this);
		}

		#endregion
		#pragma warning restore
	}
}