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
	/// DispatchInterface CalculatedMembers 
	/// SupportByVersion Excel, 10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Excel", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class CalculatedMembers : COMObject ,IEnumerable<NetOffice.ExcelApi.CalculatedMember>
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
                    _type = typeof(CalculatedMembers);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CalculatedMembers(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CalculatedMembers(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CalculatedMembers(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CalculatedMembers() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CalculatedMembers(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
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
		/// SupportByVersion Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
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
		/// SupportByVersion Excel 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
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
		/// SupportByVersion Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
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
		/// SupportByVersion Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.CalculatedMember this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="formula">string Formula</param>
		/// <param name="solveOrder">optional object SolveOrder</param>
		/// <param name="type">optional object Type</param>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.CalculatedMember Add(string name, string formula, object solveOrder, object type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula, solveOrder, type);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="formula">object Formula</param>
		/// <param name="solveOrder">optional object SolveOrder</param>
		/// <param name="type">optional object Type</param>
		/// <param name="dynamic">optional object Dynamic</param>
		/// <param name="displayFolder">optional object DisplayFolder</param>
		/// <param name="hierarchizeDistinct">optional object HierarchizeDistinct</param>
		[SupportByVersionAttribute("Excel", 14)]
		public NetOffice.ExcelApi.CalculatedMember Add(string name, object formula, object solveOrder, object type, object dynamic, object displayFolder, object hierarchizeDistinct)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula, solveOrder, type, dynamic, displayFolder, hierarchizeDistinct);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="formula">string Formula</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.CalculatedMember Add(string name, string formula)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="formula">string Formula</param>
		/// <param name="solveOrder">optional object SolveOrder</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.CalculatedMember Add(string name, string formula, object solveOrder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula, solveOrder);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="formula">object Formula</param>
		/// <param name="solveOrder">optional object SolveOrder</param>
		/// <param name="type">optional object Type</param>
		/// <param name="dynamic">optional object Dynamic</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 14)]
		public NetOffice.ExcelApi.CalculatedMember Add(string name, object formula, object solveOrder, object type, object dynamic)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula, solveOrder, type, dynamic);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="formula">object Formula</param>
		/// <param name="solveOrder">optional object SolveOrder</param>
		/// <param name="type">optional object Type</param>
		/// <param name="dynamic">optional object Dynamic</param>
		/// <param name="displayFolder">optional object DisplayFolder</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 14)]
		public NetOffice.ExcelApi.CalculatedMember Add(string name, object formula, object solveOrder, object type, object dynamic, object displayFolder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula, solveOrder, type, dynamic, displayFolder);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="formula">string Formula</param>
		/// <param name="solveOrder">optional object SolveOrder</param>
		/// <param name="type">optional object Type</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Excel", 14)]
		public NetOffice.ExcelApi.CalculatedMember _Add(string name, string formula, object solveOrder, object type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula, solveOrder, type);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="formula">string Formula</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 14)]
		public NetOffice.ExcelApi.CalculatedMember _Add(string name, string formula)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="formula">string Formula</param>
		/// <param name="solveOrder">optional object SolveOrder</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 14)]
		public NetOffice.ExcelApi.CalculatedMember _Add(string name, string formula, object solveOrder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, formula, solveOrder);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.CalculatedMember newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.CalculatedMember.LateBindingApiWrapperType) as NetOffice.ExcelApi.CalculatedMember;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.ExcelApi.CalculatedMember> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
       public IEnumerator<NetOffice.ExcelApi.CalculatedMember> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.ExcelApi.CalculatedMember item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Excel, 10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}