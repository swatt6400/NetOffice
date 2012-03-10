//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface Diagram 
	/// SupportByLibrary Word, 10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Word", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Diagram : COMObject
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
                    _type = typeof(Diagram);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Diagram(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Diagram(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Diagram(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Diagram() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Diagram(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 10,11,12,14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 10,11,12,14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 10,11,12,14)]
		public NetOffice.WordApi.DiagramNodes Nodes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Nodes", paramsArray);
				NetOffice.WordApi.DiagramNodes newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.DiagramNodes.LateBindingApiWrapperType) as NetOffice.WordApi.DiagramNodes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoDiagramType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoDiagramType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Word", 10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState AutoLayout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoLayout", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoLayout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Word", 10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Reverse
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Reverse", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Reverse", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Word", 10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState AutoFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormat", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFormat", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		/// <param name="type">NetOffice.OfficeApi.Enums.MsoDiagramType Type</param>
		[SupportByLibraryAttribute("Word", 10,11,12,14)]
		public void Convert(NetOffice.OfficeApi.Enums.MsoDiagramType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			Invoker.Method(this, "Convert", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public void FitText()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "FitText", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}