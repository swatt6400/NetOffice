//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.MSHTMLApi
{
	///<summary>
	/// DispatchInterface DispSVGLinearGradientElement SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class DispSVGLinearGradientElement : COMObject
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
                    _type = typeof(DispSVGLinearGradientElement);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispSVGLinearGradientElement(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispSVGLinearGradientElement(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispSVGLinearGradientElement(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispSVGLinearGradientElement() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispSVGLinearGradientElement(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedEnumeration gradientUnits
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "gradientUnits", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedEnumeration newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedEnumeration;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "gradientUnits", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedTransformList gradientTransform
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "gradientTransform", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedTransformList newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedTransformList;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "gradientTransform", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedEnumeration spreadMethod
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "spreadMethod", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedEnumeration newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedEnumeration;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "spreadMethod", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedLength x1
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "x1", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedLength newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedLength;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "x1", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedLength y1
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "y1", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedLength newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedLength;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "y1", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedLength x2
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "x2", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedLength newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedLength;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "x2", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedLength y2
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "y2", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedLength newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedLength;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "y2", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string xmlbase
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "xmlbase", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "xmlbase", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGSVGElement ownerSVGElement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ownerSVGElement", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGSVGElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGSVGElement;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ownerSVGElement", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGElement viewportElement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "viewportElement", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGElement;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "viewportElement", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedEnumeration focusable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "focusable", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedEnumeration newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedEnumeration;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "focusable", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedString href
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "href", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedString newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedString;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedBoolean externalResourcesRequired
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "externalResourcesRequired", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedBoolean newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedBoolean;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedString className
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "className", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedString newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedString;
				return newObject;
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}