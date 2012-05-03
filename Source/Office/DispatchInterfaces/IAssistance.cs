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
	/// DispatchInterface IAssistance 
	/// SupportByVersion Office, 12,14
	///</summary>
	[SupportByVersionAttribute("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IAssistance : COMObject
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
                    _type = typeof(IAssistance);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAssistance(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAssistance(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAssistance(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAssistance() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAssistance(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="helpId">optional string HelpId = </param>
		/// <param name="scope">optional string Scope = </param>
		[SupportByVersionAttribute("Office", 12,14)]
		public void ShowHelp(string helpId, string scope)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(helpId, scope);
			Invoker.Method(this, "ShowHelp", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14)]
		public void ShowHelp()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ShowHelp", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="helpId">optional string HelpId = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14)]
		public void ShowHelp(string helpId)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(helpId);
			Invoker.Method(this, "ShowHelp", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="query">string Query</param>
		/// <param name="scope">optional string Scope = </param>
		[SupportByVersionAttribute("Office", 12,14)]
		public void SearchHelp(string query, string scope)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(query, scope);
			Invoker.Method(this, "SearchHelp", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="query">string Query</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14)]
		public void SearchHelp(string query)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(query);
			Invoker.Method(this, "SearchHelp", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="helpId">string HelpId</param>
		[SupportByVersionAttribute("Office", 12,14)]
		public void SetDefaultContext(string helpId)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(helpId);
			Invoker.Method(this, "SetDefaultContext", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="helpId">string HelpId</param>
		[SupportByVersionAttribute("Office", 12,14)]
		public void ClearDefaultContext(string helpId)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(helpId);
			Invoker.Method(this, "ClearDefaultContext", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}