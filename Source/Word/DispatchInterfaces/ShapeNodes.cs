using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface ShapeNodes 
	/// SupportByVersion Word, 9,10,11,12,14,15
	///</summary>
	///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840439.aspx </remarks>
	[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ShapeNodes : COMObject ,IEnumerable<NetOffice.WordApi.ShapeNode>
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

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public ShapeNodes(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ShapeNodes(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ShapeNodes(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ShapeNodes(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
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
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff192144.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff191955.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
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
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff193861.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
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

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff844838.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
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
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="index">Int32 Index</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff191962.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Delete(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.WordApi.ShapeNode this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.ShapeNode newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.ShapeNode.LateBindingApiWrapperType) as NetOffice.WordApi.ShapeNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="index">Int32 Index</param>
		/// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff193122.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void SetEditingType(Int32 index, NetOffice.OfficeApi.Enums.MsoEditingType editingType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, editingType);
			Invoker.Method(this, "SetEditingType", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="index">Int32 Index</param>
		/// <param name="x1">Single X1</param>
		/// <param name="y1">Single Y1</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845116.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void SetPosition(Int32 index, Single x1, Single y1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, x1, y1);
			Invoker.Method(this, "SetPosition", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="index">Int32 Index</param>
		/// <param name="segmentType">NetOffice.OfficeApi.Enums.MsoSegmentType SegmentType</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822696.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void SetSegmentType(Int32 index, NetOffice.OfficeApi.Enums.MsoSegmentType segmentType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, segmentType);
			Invoker.Method(this, "SetSegmentType", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="index">Int32 Index</param>
		/// <param name="segmentType">NetOffice.OfficeApi.Enums.MsoSegmentType SegmentType</param>
		/// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="x1">Single X1</param>
		/// <param name="y1">Single Y1</param>
		/// <param name="x2">optional Single X2 = 0</param>
		/// <param name="y2">optional Single Y2 = 0</param>
		/// <param name="x3">optional Single X3 = 0</param>
		/// <param name="y3">optional Single Y3 = 0</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835452.aspx </remarks>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(Int32 index, NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1, object x2, object y2, object x3, object y3)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, segmentType, editingType, x1, y1, x2, y2, x3, y3);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="index">Int32 Index</param>
		/// <param name="segmentType">NetOffice.OfficeApi.Enums.MsoSegmentType SegmentType</param>
		/// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="x1">Single X1</param>
		/// <param name="y1">Single Y1</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835452.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(Int32 index, NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, segmentType, editingType, x1, y1);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="index">Int32 Index</param>
		/// <param name="segmentType">NetOffice.OfficeApi.Enums.MsoSegmentType SegmentType</param>
		/// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="x1">Single X1</param>
		/// <param name="y1">Single Y1</param>
		/// <param name="x2">optional Single X2 = 0</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835452.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(Int32 index, NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1, object x2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, segmentType, editingType, x1, y1, x2);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="index">Int32 Index</param>
		/// <param name="segmentType">NetOffice.OfficeApi.Enums.MsoSegmentType SegmentType</param>
		/// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="x1">Single X1</param>
		/// <param name="y1">Single Y1</param>
		/// <param name="x2">optional Single X2 = 0</param>
		/// <param name="y2">optional Single Y2 = 0</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835452.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(Int32 index, NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1, object x2, object y2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, segmentType, editingType, x1, y1, x2, y2);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="index">Int32 Index</param>
		/// <param name="segmentType">NetOffice.OfficeApi.Enums.MsoSegmentType SegmentType</param>
		/// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="x1">Single X1</param>
		/// <param name="y1">Single Y1</param>
		/// <param name="x2">optional Single X2 = 0</param>
		/// <param name="y2">optional Single Y2 = 0</param>
		/// <param name="x3">optional Single X3 = 0</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835452.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Insert(Int32 index, NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1, object x2, object y2, object x3)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, segmentType, editingType, x1, y1, x2, y2, x3);
			Invoker.Method(this, "Insert", paramsArray);
		}

		#endregion

       #region IEnumerable<NetOffice.WordApi.ShapeNode> Member
        
        /// <summary>
		/// SupportByVersionAttribute Word, 9,10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
       public IEnumerator<NetOffice.WordApi.ShapeNode> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.WordApi.ShapeNode item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Word, 9,10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}