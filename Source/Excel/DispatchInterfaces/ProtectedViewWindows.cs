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
	/// DispatchInterface ProtectedViewWindows 
	/// SupportByVersion Excel, 14,15
	///</summary>
	///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838667.aspx </remarks>
	[SupportByVersionAttribute("Excel", 14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ProtectedViewWindows : COMObject ,IEnumerable<NetOffice.ExcelApi.ProtectedViewWindow>
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
                    _type = typeof(ProtectedViewWindows);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public ProtectedViewWindows(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ProtectedViewWindows(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ProtectedViewWindows(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ProtectedViewWindows(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ProtectedViewWindows(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ProtectedViewWindows() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ProtectedViewWindows(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196081.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
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
		/// SupportByVersion Excel 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840808.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
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
		/// SupportByVersion Excel 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195468.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
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
		/// SupportByVersion Excel 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195061.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
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
		/// SupportByVersion Excel 14, 15
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Excel", 14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.ProtectedViewWindow this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.ProtectedViewWindow newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.ProtectedViewWindow.LateBindingApiWrapperType) as NetOffice.ExcelApi.ProtectedViewWindow;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// </summary>
		/// <param name="filename">string Filename</param>
		/// <param name="password">optional object Password</param>
		/// <param name="addToMru">optional object AddToMru</param>
		/// <param name="repairMode">optional object RepairMode</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838390.aspx </remarks>
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.ProtectedViewWindow Open(string filename, object password, object addToMru, object repairMode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, password, addToMru, repairMode);
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray);
			NetOffice.ExcelApi.ProtectedViewWindow newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ProtectedViewWindow.LateBindingApiWrapperType) as NetOffice.ExcelApi.ProtectedViewWindow;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// </summary>
		/// <param name="filename">string Filename</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838390.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.ProtectedViewWindow Open(string filename)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename);
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray);
			NetOffice.ExcelApi.ProtectedViewWindow newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ProtectedViewWindow.LateBindingApiWrapperType) as NetOffice.ExcelApi.ProtectedViewWindow;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// </summary>
		/// <param name="filename">string Filename</param>
		/// <param name="password">optional object Password</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838390.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.ProtectedViewWindow Open(string filename, object password)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, password);
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray);
			NetOffice.ExcelApi.ProtectedViewWindow newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ProtectedViewWindow.LateBindingApiWrapperType) as NetOffice.ExcelApi.ProtectedViewWindow;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15
		/// </summary>
		/// <param name="filename">string Filename</param>
		/// <param name="password">optional object Password</param>
		/// <param name="addToMru">optional object AddToMru</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838390.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 14,15)]
		public NetOffice.ExcelApi.ProtectedViewWindow Open(string filename, object password, object addToMru)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, password, addToMru);
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray);
			NetOffice.ExcelApi.ProtectedViewWindow newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ProtectedViewWindow.LateBindingApiWrapperType) as NetOffice.ExcelApi.ProtectedViewWindow;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.ExcelApi.ProtectedViewWindow> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
       public IEnumerator<NetOffice.ExcelApi.ProtectedViewWindow> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.ExcelApi.ProtectedViewWindow item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Excel, 14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}