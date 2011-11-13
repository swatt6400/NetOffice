//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface CanvasShapes SupportByLibraryAttribute Office, 10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Office", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class CanvasShapes : _IMsoDispObj ,IEnumerable
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
                    _type = typeof(CanvasShapes);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CanvasShapes(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CanvasShapes(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CanvasShapes(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CanvasShapes() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CanvasShapes(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
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
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Shape Background
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Background", paramsArray);
				NetOffice.OfficeApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.Shape.LateBindingApiWrapperType) as NetOffice.OfficeApi.Shape;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.Shape this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.OfficeApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Shape.LateBindingApiWrapperType) as NetOffice.OfficeApi.Shape;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.MsoCalloutType Type</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Shape AddCallout(NetOffice.OfficeApi.Enums.MsoCalloutType type, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddCallout", paramsArray);
			NetOffice.OfficeApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Shape.LateBindingApiWrapperType) as NetOffice.OfficeApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.MsoConnectorType Type</param>
		/// <param name="BeginX">Single BeginX</param>
		/// <param name="BeginY">Single BeginY</param>
		/// <param name="EndX">Single EndX</param>
		/// <param name="EndY">Single EndY</param>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Shape AddConnector(NetOffice.OfficeApi.Enums.MsoConnectorType type, Single beginX, Single beginY, Single endX, Single endY)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, beginX, beginY, endX, endY);
			object returnItem = Invoker.MethodReturn(this, "AddConnector", paramsArray);
			NetOffice.OfficeApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Shape.LateBindingApiWrapperType) as NetOffice.OfficeApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="SafeArrayOfPoints">object SafeArrayOfPoints</param>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Shape AddCurve(object safeArrayOfPoints)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(safeArrayOfPoints);
			object returnItem = Invoker.MethodReturn(this, "AddCurve", paramsArray);
			NetOffice.OfficeApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Shape.LateBindingApiWrapperType) as NetOffice.OfficeApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="Orientation">NetOffice.OfficeApi.Enums.MsoTextOrientation Orientation</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Shape AddLabel(NetOffice.OfficeApi.Enums.MsoTextOrientation orientation, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(orientation, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddLabel", paramsArray);
			NetOffice.OfficeApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Shape.LateBindingApiWrapperType) as NetOffice.OfficeApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="BeginX">Single BeginX</param>
		/// <param name="BeginY">Single BeginY</param>
		/// <param name="EndX">Single EndX</param>
		/// <param name="EndY">Single EndY</param>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Shape AddLine(Single beginX, Single beginY, Single endX, Single endY)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(beginX, beginY, endX, endY);
			object returnItem = Invoker.MethodReturn(this, "AddLine", paramsArray);
			NetOffice.OfficeApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Shape.LateBindingApiWrapperType) as NetOffice.OfficeApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="LinkToFile">NetOffice.OfficeApi.Enums.MsoTriState LinkToFile</param>
		/// <param name="SaveWithDocument">NetOffice.OfficeApi.Enums.MsoTriState SaveWithDocument</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Shape AddPicture(string fileName, NetOffice.OfficeApi.Enums.MsoTriState linkToFile, NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, linkToFile, saveWithDocument, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddPicture", paramsArray);
			NetOffice.OfficeApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Shape.LateBindingApiWrapperType) as NetOffice.OfficeApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="SafeArrayOfPoints">object SafeArrayOfPoints</param>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Shape AddPolyline(object safeArrayOfPoints)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(safeArrayOfPoints);
			object returnItem = Invoker.MethodReturn(this, "AddPolyline", paramsArray);
			NetOffice.OfficeApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Shape.LateBindingApiWrapperType) as NetOffice.OfficeApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.MsoAutoShapeType Type</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Shape AddShape(NetOffice.OfficeApi.Enums.MsoAutoShapeType type, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddShape", paramsArray);
			NetOffice.OfficeApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Shape.LateBindingApiWrapperType) as NetOffice.OfficeApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="PresetTextEffect">NetOffice.OfficeApi.Enums.MsoPresetTextEffect PresetTextEffect</param>
		/// <param name="Text">string Text</param>
		/// <param name="FontName">string FontName</param>
		/// <param name="FontSize">Single FontSize</param>
		/// <param name="FontBold">NetOffice.OfficeApi.Enums.MsoTriState FontBold</param>
		/// <param name="FontItalic">NetOffice.OfficeApi.Enums.MsoTriState FontItalic</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Shape AddTextEffect(NetOffice.OfficeApi.Enums.MsoPresetTextEffect presetTextEffect, string text, string fontName, Single fontSize, NetOffice.OfficeApi.Enums.MsoTriState fontBold, NetOffice.OfficeApi.Enums.MsoTriState fontItalic, Single left, Single top)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(presetTextEffect, text, fontName, fontSize, fontBold, fontItalic, left, top);
			object returnItem = Invoker.MethodReturn(this, "AddTextEffect", paramsArray);
			NetOffice.OfficeApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Shape.LateBindingApiWrapperType) as NetOffice.OfficeApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="Orientation">NetOffice.OfficeApi.Enums.MsoTextOrientation Orientation</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Shape AddTextbox(NetOffice.OfficeApi.Enums.MsoTextOrientation orientation, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(orientation, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddTextbox", paramsArray);
			NetOffice.OfficeApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Shape.LateBindingApiWrapperType) as NetOffice.OfficeApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="EditingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="X1">Single X1</param>
		/// <param name="Y1">Single Y1</param>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.FreeformBuilder BuildFreeform(NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(editingType, x1, y1);
			object returnItem = Invoker.MethodReturn(this, "BuildFreeform", paramsArray);
			NetOffice.OfficeApi.FreeformBuilder newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.FreeformBuilder.LateBindingApiWrapperType) as NetOffice.OfficeApi.FreeformBuilder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.ShapeRange Range(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Range", paramsArray);
			NetOffice.OfficeApi.ShapeRange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.ShapeRange.LateBindingApiWrapperType) as NetOffice.OfficeApi.ShapeRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public void SelectAll()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SelectAll", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute Office, 10,11,12,14
		/// </summary>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy, true);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}