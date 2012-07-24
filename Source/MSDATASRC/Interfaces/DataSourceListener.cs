using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.MSDATASRCApi
{
	///<summary>
	/// Interface DataSourceListener 
	/// SupportByVersion MSDATASRC, 1
	///</summary>
	[SupportByVersionAttribute("MSDATASRC", 1)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class DataSourceListener : COMObject
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
                    _type = typeof(DataSourceListener);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataSourceListener(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataSourceListener(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataSourceListener(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataSourceListener() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataSourceListener(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSDATASRC 1
		/// </summary>
		/// <param name="bstrDM">string bstrDM</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("MSDATASRC", 1)]
		public Int32 dataMemberChanged(string bstrDM)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrDM);
			object returnItem = Invoker.MethodReturn(this, "dataMemberChanged", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion MSDATASRC 1
		/// </summary>
		/// <param name="bstrDM">string bstrDM</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("MSDATASRC", 1)]
		public Int32 dataMemberAdded(string bstrDM)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrDM);
			object returnItem = Invoker.MethodReturn(this, "dataMemberAdded", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion MSDATASRC 1
		/// </summary>
		/// <param name="bstrDM">string bstrDM</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("MSDATASRC", 1)]
		public Int32 dataMemberRemoved(string bstrDM)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrDM);
			object returnItem = Invoker.MethodReturn(this, "dataMemberRemoved", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		#endregion
		#pragma warning restore
	}
}