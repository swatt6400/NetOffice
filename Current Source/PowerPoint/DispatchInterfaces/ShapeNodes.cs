using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface ShapeNodes 
	/// SupportByVersion PowerPoint, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ShapeNodes : COMObject ,IEnumerable<NetOffice.PowerPointApi.ShapeNode>
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
                    _type = typeof(ShapeNodes);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ShapeNodes(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ShapeNodes(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ShapeNodes(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ShapeNodes() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ShapeNodes(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public object Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
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

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
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
		public NetOffice.PowerPointApi.ShapeNode this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.PowerPointApi.ShapeNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.ShapeNode.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ShapeNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public void Delete(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 index</param>
		/// <param name="segmentType">NetOffice.OfficeApi.Enums.MsoSegmentType SegmentType</param>
		/// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="x1">Single X1</param>
		/// <param name="y1">Single Y1</param>
		/// <param name="x2">optional Single X2 = 0</param>
		/// <param name="y2">optional Single Y2 = 0</param>
		/// <param name="x3">optional Single X3 = 0</param>
		/// <param name="y3">optional Single Y3 = 0</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public void Insert(Int32 index, NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1, Single x2, Single y2, Single x3, Single y3)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, segmentType, editingType, x1, y1, x2, y2, x3, y3);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 index</param>
		/// <param name="segmentType">NetOffice.OfficeApi.Enums.MsoSegmentType SegmentType</param>
		/// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="x1">Single X1</param>
		/// <param name="y1">Single Y1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public void Insert(Int32 index, NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, segmentType, editingType, x1, y1);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 index</param>
		/// <param name="segmentType">NetOffice.OfficeApi.Enums.MsoSegmentType SegmentType</param>
		/// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="x1">Single X1</param>
		/// <param name="y1">Single Y1</param>
		/// <param name="x2">optional Single X2 = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public void Insert(Int32 index, NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1, Single x2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, segmentType, editingType, x1, y1, x2);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 index</param>
		/// <param name="segmentType">NetOffice.OfficeApi.Enums.MsoSegmentType SegmentType</param>
		/// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="x1">Single X1</param>
		/// <param name="y1">Single Y1</param>
		/// <param name="x2">optional Single X2 = 0</param>
		/// <param name="y2">optional Single Y2 = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public void Insert(Int32 index, NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1, Single x2, Single y2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, segmentType, editingType, x1, y1, x2, y2);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 index</param>
		/// <param name="segmentType">NetOffice.OfficeApi.Enums.MsoSegmentType SegmentType</param>
		/// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="x1">Single X1</param>
		/// <param name="y1">Single Y1</param>
		/// <param name="x2">optional Single X2 = 0</param>
		/// <param name="y2">optional Single Y2 = 0</param>
		/// <param name="x3">optional Single X3 = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public void Insert(Int32 index, NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1, Single x2, Single y2, Single x3)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, segmentType, editingType, x1, y1, x2, y2, x3);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 index</param>
		/// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public void SetEditingType(Int32 index, NetOffice.OfficeApi.Enums.MsoEditingType editingType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, editingType);
			Invoker.Method(this, "SetEditingType", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 index</param>
		/// <param name="x1">Single X1</param>
		/// <param name="y1">Single Y1</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public void SetPosition(Int32 index, Single x1, Single y1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, x1, y1);
			Invoker.Method(this, "SetPosition", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 index</param>
		/// <param name="segmentType">NetOffice.OfficeApi.Enums.MsoSegmentType SegmentType</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public void SetSegmentType(Int32 index, NetOffice.OfficeApi.Enums.MsoSegmentType segmentType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, segmentType);
			Invoker.Method(this, "SetSegmentType", paramsArray);
		}

		#endregion

       #region IEnumerable<NetOffice.PowerPointApi.ShapeNode> Member
        
        /// <summary>
		/// SupportByVersionAttribute PowerPoint, 9,10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
       public IEnumerator<NetOffice.PowerPointApi.ShapeNode> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.PowerPointApi.ShapeNode item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute PowerPoint, 9,10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return LateBindingApi.Core.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}