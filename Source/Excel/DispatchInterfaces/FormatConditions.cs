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
	/// DispatchInterface FormatConditions 
	/// SupportByVersion Excel, 9,10,11,12,14,15
	///</summary>
	///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195304.aspx </remarks>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class FormatConditions : COMObject ,IEnumerable<object>
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
                    _type = typeof(FormatConditions);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public FormatConditions(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FormatConditions(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FormatConditions(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FormatConditions(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FormatConditions(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FormatConditions() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FormatConditions(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195110.aspx </remarks>
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
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838998.aspx </remarks>
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
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822570.aspx </remarks>
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
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840014.aspx </remarks>
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
		public NetOffice.ExcelApi.FormatCondition this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.FormatCondition newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.FormatCondition.LateBindingApiWrapperType) as NetOffice.ExcelApi.FormatCondition;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlFormatConditionType Type</param>
		/// <param name="_operator">optional object Operator</param>
		/// <param name="formula1">optional object Formula1</param>
		/// <param name="formula2">optional object Formula2</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822801.aspx </remarks>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.FormatCondition Add(NetOffice.ExcelApi.Enums.XlFormatConditionType type, object _operator, object formula1, object formula2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, _operator, formula1, formula2);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.FormatCondition newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.FormatCondition.LateBindingApiWrapperType) as NetOffice.ExcelApi.FormatCondition;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlFormatConditionType Type</param>
		/// <param name="_operator">optional object Operator</param>
		/// <param name="formula1">optional object Formula1</param>
		/// <param name="formula2">optional object Formula2</param>
		/// <param name="_string">optional object String</param>
		/// <param name="textOperator">optional object TextOperator</param>
		/// <param name="dateOperator">optional object DateOperator</param>
		/// <param name="scopeType">optional object ScopeType</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822801.aspx </remarks>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public object Add(NetOffice.ExcelApi.Enums.XlFormatConditionType type, object _operator, object formula1, object formula2, object _string, object textOperator, object dateOperator, object scopeType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, _operator, formula1, formula2, _string, textOperator, dateOperator, scopeType);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			object newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlFormatConditionType Type</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822801.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.FormatCondition Add(NetOffice.ExcelApi.Enums.XlFormatConditionType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.FormatCondition newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.FormatCondition.LateBindingApiWrapperType) as NetOffice.ExcelApi.FormatCondition;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlFormatConditionType Type</param>
		/// <param name="_operator">optional object Operator</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822801.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.FormatCondition Add(NetOffice.ExcelApi.Enums.XlFormatConditionType type, object _operator)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, _operator);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.FormatCondition newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.FormatCondition.LateBindingApiWrapperType) as NetOffice.ExcelApi.FormatCondition;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlFormatConditionType Type</param>
		/// <param name="_operator">optional object Operator</param>
		/// <param name="formula1">optional object Formula1</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822801.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public NetOffice.ExcelApi.FormatCondition Add(NetOffice.ExcelApi.Enums.XlFormatConditionType type, object _operator, object formula1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, _operator, formula1);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.FormatCondition newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.FormatCondition.LateBindingApiWrapperType) as NetOffice.ExcelApi.FormatCondition;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlFormatConditionType Type</param>
		/// <param name="_operator">optional object Operator</param>
		/// <param name="formula1">optional object Formula1</param>
		/// <param name="formula2">optional object Formula2</param>
		/// <param name="_string">optional object String</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822801.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public object Add(NetOffice.ExcelApi.Enums.XlFormatConditionType type, object _operator, object formula1, object formula2, object _string)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, _operator, formula1, formula2, _string);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			object newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlFormatConditionType Type</param>
		/// <param name="_operator">optional object Operator</param>
		/// <param name="formula1">optional object Formula1</param>
		/// <param name="formula2">optional object Formula2</param>
		/// <param name="_string">optional object String</param>
		/// <param name="textOperator">optional object TextOperator</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822801.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public object Add(NetOffice.ExcelApi.Enums.XlFormatConditionType type, object _operator, object formula1, object formula2, object _string, object textOperator)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, _operator, formula1, formula2, _string, textOperator);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			object newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlFormatConditionType Type</param>
		/// <param name="_operator">optional object Operator</param>
		/// <param name="formula1">optional object Formula1</param>
		/// <param name="formula2">optional object Formula2</param>
		/// <param name="_string">optional object String</param>
		/// <param name="textOperator">optional object TextOperator</param>
		/// <param name="dateOperator">optional object DateOperator</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822801.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public object Add(NetOffice.ExcelApi.Enums.XlFormatConditionType type, object _operator, object formula1, object formula2, object _string, object textOperator, object dateOperator)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, _operator, formula1, formula2, _string, textOperator, dateOperator);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			object newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839670.aspx </remarks>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		/// <param name="colorScaleType">Int32 ColorScaleType</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840801.aspx </remarks>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public object AddColorScale(Int32 colorScaleType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(colorScaleType);
			object returnItem = Invoker.MethodReturn(this, "AddColorScale", paramsArray);
			object newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198148.aspx </remarks>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public object AddDatabar()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddDatabar", paramsArray);
			object newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840504.aspx </remarks>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public object AddIconSetCondition()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddIconSetCondition", paramsArray);
			object newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840329.aspx </remarks>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public object AddTop10()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddTop10", paramsArray);
			object newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839582.aspx </remarks>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public object AddAboveAverage()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddAboveAverage", paramsArray);
			object newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836788.aspx </remarks>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public object AddUniqueValues()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddUniqueValues", paramsArray);
			object newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.ExcelApi.FormatCondition> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 9,10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
       public IEnumerator<object> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (object item in innerEnumerator)
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