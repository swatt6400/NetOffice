using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface MsoDebugOptions_UTManager 
	/// SupportByVersion Office, 12,14
	///</summary>
	[SupportByVersionAttribute("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class MsoDebugOptions_UTManager : _IMsoDispObj
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
                    _type = typeof(MsoDebugOptions_UTManager);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MsoDebugOptions_UTManager(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MsoDebugOptions_UTManager(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MsoDebugOptions_UTManager(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MsoDebugOptions_UTManager() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MsoDebugOptions_UTManager(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.MsoDebugOptions_UTs UnitTests
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UnitTests", paramsArray);
				NetOffice.OfficeApi.MsoDebugOptions_UTs newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.MsoDebugOptions_UTs.LateBindingApiWrapperType) as NetOffice.OfficeApi.MsoDebugOptions_UTs;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public bool ReportErrors
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReportErrors", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReportErrors", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public void NotifyStartOfTestSuiteRun()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "NotifyStartOfTestSuiteRun", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public void NotifyEndOfTestSuiteRun()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "NotifyEndOfTestSuiteRun", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}