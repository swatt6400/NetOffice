using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// Interface IConverterApplicationPreferences 
	/// SupportByVersion Office, 14,15
	///</summary>
	[SupportByVersionAttribute("Office", 14,15)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IConverterApplicationPreferences : COMObject
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
                    _type = typeof(IConverterApplicationPreferences);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IConverterApplicationPreferences(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IConverterApplicationPreferences(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IConverterApplicationPreferences(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IConverterApplicationPreferences() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IConverterApplicationPreferences(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 14, 15
		/// </summary>
		/// <param name="plcid">Int32 plcid</param>
		[SupportByVersionAttribute("Office", 14,15)]
		public Int32 HrGetLcid(out Int32 plcid)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			plcid = 0;
			object[] paramsArray = Invoker.ValidateParamsArray(plcid);
			object returnItem = Invoker.MethodReturn(this, "HrGetLcid", paramsArray);
			plcid = (Int32)paramsArray[0];
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Office 14, 15
		/// </summary>
		/// <param name="phwnd">Int32 phwnd</param>
		[SupportByVersionAttribute("Office", 14,15)]
		public Int32 HrGetHwnd(out Int32 phwnd)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			phwnd = 0;
			object[] paramsArray = Invoker.ValidateParamsArray(phwnd);
			object returnItem = Invoker.MethodReturn(this, "HrGetHwnd", paramsArray);
			phwnd = (Int32)paramsArray[0];
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Office 14, 15
		/// </summary>
		/// <param name="pbstrApplication">string pbstrApplication</param>
		[SupportByVersionAttribute("Office", 14,15)]
		public Int32 HrGetApplication(out string pbstrApplication)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			pbstrApplication = string.Empty;
			object[] paramsArray = Invoker.ValidateParamsArray(pbstrApplication);
			object returnItem = Invoker.MethodReturn(this, "HrGetApplication", paramsArray);
			pbstrApplication = (string)paramsArray[0];
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Office 14, 15
		/// </summary>
		/// <param name="pFormat">Int32 pFormat</param>
		[SupportByVersionAttribute("Office", 14,15)]
		public Int32 HrCheckFormat(out Int32 pFormat)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			pFormat = 0;
			object[] paramsArray = Invoker.ValidateParamsArray(pFormat);
			object returnItem = Invoker.MethodReturn(this, "HrCheckFormat", paramsArray);
			pFormat = (Int32)paramsArray[0];
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		#endregion
		#pragma warning restore
	}
}