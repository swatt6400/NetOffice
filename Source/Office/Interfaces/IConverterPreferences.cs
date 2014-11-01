using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// Interface IConverterPreferences 
	/// SupportByVersion Office, 14,15
	/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff864179.aspx
	///</summary>
	[SupportByVersionAttribute("Office", 14,15)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IConverterPreferences : COMObject
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
                    _type = typeof(IConverterPreferences);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public IConverterPreferences(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IConverterPreferences(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IConverterPreferences(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IConverterPreferences(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IConverterPreferences(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IConverterPreferences() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IConverterPreferences(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff863141.aspx
		/// </summary>
		/// <param name="pfMacroEnabled">Int32 pfMacroEnabled</param>
		[SupportByVersionAttribute("Office", 14,15)]
		public Int32 HrGetMacroEnabled(out Int32 pfMacroEnabled)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			pfMacroEnabled = 0;
			object[] paramsArray = Invoker.ValidateParamsArray(pfMacroEnabled);
			object returnItem = Invoker.MethodReturn(this, "HrGetMacroEnabled", paramsArray);
			pfMacroEnabled = (Int32)paramsArray[0];
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Office 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff865570.aspx
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

		/// <summary>
		/// SupportByVersion Office 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff860851.aspx
		/// </summary>
		/// <param name="pfLossySave">Int32 pfLossySave</param>
		[SupportByVersionAttribute("Office", 14,15)]
		public Int32 HrGetLossySave(out Int32 pfLossySave)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			pfLossySave = 0;
			object[] paramsArray = Invoker.ValidateParamsArray(pfLossySave);
			object returnItem = Invoker.MethodReturn(this, "HrGetLossySave", paramsArray);
			pfLossySave = (Int32)paramsArray[0];
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		#endregion
		#pragma warning restore
	}
}