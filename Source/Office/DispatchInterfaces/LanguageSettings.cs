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
	/// DispatchInterface LanguageSettings 
	/// SupportByVersion Office, 9,10,11,12,14,15
	///</summary>
	///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff863125.aspx </remarks>
	[SupportByVersionAttribute("Office", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class LanguageSettings : _IMsoDispObj
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
                    _type = typeof(LanguageSettings);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public LanguageSettings(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LanguageSettings(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LanguageSettings(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LanguageSettings(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LanguageSettings(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LanguageSettings() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LanguageSettings(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="id">NetOffice.OfficeApi.Enums.MsoAppLanguageID Id</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff863438.aspx </remarks>
		[SupportByVersionAttribute("Office", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Int32 get_LanguageID(NetOffice.OfficeApi.Enums.MsoAppLanguageID id)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(id);
			object returnItem = Invoker.PropertyGet(this, "LanguageID", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14, 15
		/// Alias for get_LanguageID
		/// </summary>
		/// <param name="id">NetOffice.OfficeApi.Enums.MsoAppLanguageID Id</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff863438.aspx </remarks>
		[SupportByVersionAttribute("Office", 9,10,11,12,14,15)]
		public Int32 LanguageID(NetOffice.OfficeApi.Enums.MsoAppLanguageID id)
		{
			return get_LanguageID(id);
		}

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="lid">NetOffice.OfficeApi.Enums.MsoLanguageID lid</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff861143.aspx </remarks>
		[SupportByVersionAttribute("Office", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public bool get_LanguagePreferredForEditing(NetOffice.OfficeApi.Enums.MsoLanguageID lid)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(lid);
			object returnItem = Invoker.PropertyGet(this, "LanguagePreferredForEditing", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14, 15
		/// Alias for get_LanguagePreferredForEditing
		/// </summary>
		/// <param name="lid">NetOffice.OfficeApi.Enums.MsoLanguageID lid</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff861143.aspx </remarks>
		[SupportByVersionAttribute("Office", 9,10,11,12,14,15)]
		public bool LanguagePreferredForEditing(NetOffice.OfficeApi.Enums.MsoLanguageID lid)
		{
			return get_LanguagePreferredForEditing(lid);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff862054.aspx </remarks>
		[SupportByVersionAttribute("Office", 10,11,12,14,15)]
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

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}