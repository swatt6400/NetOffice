//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.MSHTMLApi
{
	///<summary>
	/// Interface ISelectionServices SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class ISelectionServices : COMObject
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
                    _type = typeof(ISelectionServices);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISelectionServices(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISelectionServices(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISelectionServices(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISelectionServices() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISelectionServices(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="eType">LateBindingApi.MSHTMLApi.Enums._SELECTION_TYPE eType</param>
		/// <param name="pIListener">LateBindingApi.MSHTMLApi.ISelectionServicesListener pIListener</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 SetSelectionType(LateBindingApi.MSHTMLApi.Enums._SELECTION_TYPE eType, LateBindingApi.MSHTMLApi.ISelectionServicesListener pIListener)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(eType, pIListener);
			object returnItem = Invoker.MethodReturn(this, "SetSelectionType", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="ppIContainer">LateBindingApi.MSHTMLApi.IMarkupContainer ppIContainer</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 GetMarkupContainer(LateBindingApi.MSHTMLApi.IMarkupContainer ppIContainer)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(ppIContainer);
			object returnItem = Invoker.MethodReturn(this, "GetMarkupContainer", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pIStart">LateBindingApi.MSHTMLApi.IMarkupPointer pIStart</param>
		/// <param name="pIEnd">LateBindingApi.MSHTMLApi.IMarkupPointer pIEnd</param>
		/// <param name="ppISegmentAdded">LateBindingApi.MSHTMLApi.ISegment ppISegmentAdded</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 AddSegment(LateBindingApi.MSHTMLApi.IMarkupPointer pIStart, LateBindingApi.MSHTMLApi.IMarkupPointer pIEnd, LateBindingApi.MSHTMLApi.ISegment ppISegmentAdded)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pIStart, pIEnd, ppISegmentAdded);
			object returnItem = Invoker.MethodReturn(this, "AddSegment", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pIElement">LateBindingApi.MSHTMLApi.IHTMLElement pIElement</param>
		/// <param name="ppISegmentAdded">LateBindingApi.MSHTMLApi.IElementSegment ppISegmentAdded</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 AddElementSegment(LateBindingApi.MSHTMLApi.IHTMLElement pIElement, LateBindingApi.MSHTMLApi.IElementSegment ppISegmentAdded)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pIElement, ppISegmentAdded);
			object returnItem = Invoker.MethodReturn(this, "AddElementSegment", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pISegment">LateBindingApi.MSHTMLApi.ISegment pISegment</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 RemoveSegment(LateBindingApi.MSHTMLApi.ISegment pISegment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pISegment);
			object returnItem = Invoker.MethodReturn(this, "RemoveSegment", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="ppISelectionServicesListener">LateBindingApi.MSHTMLApi.ISelectionServicesListener ppISelectionServicesListener</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 GetSelectionServicesListener(LateBindingApi.MSHTMLApi.ISelectionServicesListener ppISelectionServicesListener)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(ppISelectionServicesListener);
			object returnItem = Invoker.MethodReturn(this, "GetSelectionServicesListener", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}