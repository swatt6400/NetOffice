using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.MSHTMLApi
{
	///<summary>
	/// DispatchInterface IElementSelector 
	/// SupportByVersion MSHTML, 4
	///</summary>
	[SupportByVersionAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IElementSelector : IHTMLElement5
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
                    _type = typeof(IElementSelector);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IElementSelector(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IElementSelector(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IElementSelector(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IElementSelector() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IElementSelector(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="v">string v</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLElement querySelector(string v)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(v);
			object returnItem = Invoker.MethodReturn(this, "querySelector", paramsArray);
			NetOffice.MSHTMLApi.IHTMLElement newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLElement;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="v">string v</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLDOMChildrenCollection querySelectorAll(string v)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(v);
			object returnItem = Invoker.MethodReturn(this, "querySelectorAll", paramsArray);
			NetOffice.MSHTMLApi.IHTMLDOMChildrenCollection newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLDOMChildrenCollection;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}