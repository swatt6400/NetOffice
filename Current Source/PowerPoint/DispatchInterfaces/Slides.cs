using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface Slides 
	/// SupportByVersion PowerPoint, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Slides : Collection
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
                    _type = typeof(Slides);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Slides(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Slides(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Slides(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Slides() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Slides(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Application.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
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
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.PowerPointApi.Slide this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.PowerPointApi.Slide newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Slide.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Slide;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="slideID">Int32 SlideID</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Slide FindBySlideID(Int32 slideID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(slideID);
			object returnItem = Invoker.MethodReturn(this, "FindBySlideID", paramsArray);
			NetOffice.PowerPointApi.Slide newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Slide.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Slide;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 index</param>
		/// <param name="layout">NetOffice.PowerPointApi.Enums.PpSlideLayout Layout</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Slide Add(Int32 index, NetOffice.PowerPointApi.Enums.PpSlideLayout layout)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, layout);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.PowerPointApi.Slide newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Slide.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Slide;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="index">Int32 index</param>
		/// <param name="slideStart">optional Int32 SlideStart = 1</param>
		/// <param name="slideEnd">optional Int32 SlideEnd = -1</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public Int32 InsertFromFile(string fileName, Int32 index, Int32 slideStart, Int32 slideEnd)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, index, slideStart, slideEnd);
			object returnItem = Invoker.MethodReturn(this, "InsertFromFile", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="index">Int32 index</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public Int32 InsertFromFile(string fileName, Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, index);
			object returnItem = Invoker.MethodReturn(this, "InsertFromFile", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="index">Int32 index</param>
		/// <param name="slideStart">optional Int32 SlideStart = 1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public Int32 InsertFromFile(string fileName, Int32 index, Int32 slideStart)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, index, slideStart);
			object returnItem = Invoker.MethodReturn(this, "InsertFromFile", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">optional object index</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.SlideRange Range(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Range", paramsArray);
			NetOffice.PowerPointApi.SlideRange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.SlideRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.SlideRange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.SlideRange Range()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Range", paramsArray);
			NetOffice.PowerPointApi.SlideRange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.SlideRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.SlideRange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">optional Int32 index = -1</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.SlideRange Paste(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
			NetOffice.PowerPointApi.SlideRange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.SlideRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.SlideRange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.SlideRange Paste()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
			NetOffice.PowerPointApi.SlideRange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.SlideRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.SlideRange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14
		/// </summary>
		/// <param name="index">Int32 Index</param>
		/// <param name="pCustomLayout">NetOffice.PowerPointApi.CustomLayout pCustomLayout</param>
		[SupportByVersionAttribute("PowerPoint", 12,14)]
		public NetOffice.PowerPointApi.Slide AddSlide(Int32 index, NetOffice.PowerPointApi.CustomLayout pCustomLayout)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, pCustomLayout);
			object returnItem = Invoker.MethodReturn(this, "AddSlide", paramsArray);
			NetOffice.PowerPointApi.Slide newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Slide.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Slide;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}