using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface DocumentInspector 
	/// SupportByVersion Office, 12,14
	///</summary>
	[SupportByVersionAttribute("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class DocumentInspector : _IMsoDispObj
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
                    _type = typeof(DocumentInspector);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DocumentInspector(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DocumentInspector(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DocumentInspector(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DocumentInspector() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DocumentInspector(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public string Description
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Description", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="status">NetOffice.OfficeApi.Enums.MsoDocInspectorStatus Status</param>
		/// <param name="results">string Results</param>
		[SupportByVersionAttribute("Office", 12,14)]
		public void Inspect(out NetOffice.OfficeApi.Enums.MsoDocInspectorStatus status, out string results)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true);
			status = 0;
			results = string.Empty;
			object[] paramsArray = Invoker.ValidateParamsArray(status, results);
			Invoker.Method(this, "Inspect", paramsArray, modifiers);
			status = (NetOffice.OfficeApi.Enums.MsoDocInspectorStatus)paramsArray[0];
			results = (string)paramsArray[1];
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="status">NetOffice.OfficeApi.Enums.MsoDocInspectorStatus Status</param>
		/// <param name="results">string Results</param>
		[SupportByVersionAttribute("Office", 12,14)]
		public void Fix(out NetOffice.OfficeApi.Enums.MsoDocInspectorStatus status, out string results)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true);
			status = 0;
			results = string.Empty;
			object[] paramsArray = Invoker.ValidateParamsArray(status, results);
			Invoker.Method(this, "Fix", paramsArray, modifiers);
			status = (NetOffice.OfficeApi.Enums.MsoDocInspectorStatus)paramsArray[0];
			results = (string)paramsArray[1];
		}

		#endregion
		#pragma warning restore
	}
}