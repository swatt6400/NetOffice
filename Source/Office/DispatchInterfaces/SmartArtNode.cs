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
	/// DispatchInterface SmartArtNode 
	/// SupportByVersion Office, 14
	///</summary>
	[SupportByVersionAttribute("Office", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SmartArtNode : _IMsoDispObj
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
                    _type = typeof(SmartArtNode);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartArtNode(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartArtNode(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartArtNode(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartArtNode() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartArtNode(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
		public NetOffice.OfficeApi.Enums.MsoOrgChartLayoutType OrgChartLayout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OrgChartLayout", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoOrgChartLayoutType)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OrgChartLayout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
		public NetOffice.OfficeApi.ShapeRange Shapes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shapes", paramsArray);
				NetOffice.OfficeApi.ShapeRange newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.ShapeRange.LateBindingApiWrapperType) as NetOffice.OfficeApi.ShapeRange;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
		public NetOffice.OfficeApi.TextFrame2 TextFrame2
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextFrame2", paramsArray);
				NetOffice.OfficeApi.TextFrame2 newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextFrame2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextFrame2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
		public Int32 Level
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Level", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Hidden
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Hidden", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
		public NetOffice.OfficeApi.SmartArtNodes Nodes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Nodes", paramsArray);
				NetOffice.OfficeApi.SmartArtNodes newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SmartArtNodes.LateBindingApiWrapperType) as NetOffice.OfficeApi.SmartArtNodes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
		public NetOffice.OfficeApi.SmartArtNode ParentNode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentNode", paramsArray);
				NetOffice.OfficeApi.SmartArtNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SmartArtNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.SmartArtNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
		public NetOffice.OfficeApi.Enums.MsoSmartArtNodeType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoSmartArtNodeType)intReturnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 14
		/// </summary>
		/// <param name="position">optional NetOffice.OfficeApi.Enums.MsoSmartArtNodePosition Position = 1</param>
		/// <param name="type">optional NetOffice.OfficeApi.Enums.MsoSmartArtNodeType Type = 1</param>
		[SupportByVersionAttribute("Office", 14)]
		public NetOffice.OfficeApi.SmartArtNode AddNode(object position, object type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(position, type);
			object returnItem = Invoker.MethodReturn(this, "AddNode", paramsArray);
			NetOffice.OfficeApi.SmartArtNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.SmartArtNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.SmartArtNode;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 14)]
		public NetOffice.OfficeApi.SmartArtNode AddNode()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddNode", paramsArray);
			NetOffice.OfficeApi.SmartArtNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.SmartArtNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.SmartArtNode;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// </summary>
		/// <param name="position">optional NetOffice.OfficeApi.Enums.MsoSmartArtNodePosition Position = 1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 14)]
		public NetOffice.OfficeApi.SmartArtNode AddNode(object position)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(position);
			object returnItem = Invoker.MethodReturn(this, "AddNode", paramsArray);
			NetOffice.OfficeApi.SmartArtNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.SmartArtNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.SmartArtNode;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
		public void Promote()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Promote", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
		public void Demote()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Demote", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
		public void Larger()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Larger", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
		public void Smaller()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Smaller", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
		public void ReorderUp()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ReorderUp", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 14
		/// </summary>
		[SupportByVersionAttribute("Office", 14)]
		public void ReorderDown()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ReorderDown", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}