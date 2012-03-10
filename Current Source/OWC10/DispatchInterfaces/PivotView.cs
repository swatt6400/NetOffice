//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface PivotView 
	/// SupportByLibrary OWC10, 1
	///</summary>
	[SupportByLibraryAttribute("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PivotView : COMObject
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
                    _type = typeof(PivotView);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotView(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotView(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotView(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotView() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotView(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotFieldSets FieldSets
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FieldSets", paramsArray);
				NetOffice.OWC10Api.PivotFieldSets newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PivotFieldSets.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotFieldSets;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotGroupAxis RowAxis
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RowAxis", paramsArray);
				NetOffice.OWC10Api.PivotGroupAxis newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PivotGroupAxis.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotGroupAxis;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotGroupAxis ColumnAxis
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColumnAxis", paramsArray);
				NetOffice.OWC10Api.PivotGroupAxis newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PivotGroupAxis.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotGroupAxis;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotDataAxis DataAxis
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataAxis", paramsArray);
				NetOffice.OWC10Api.PivotDataAxis newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PivotDataAxis.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotDataAxis;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotFilterAxis FilterAxis
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FilterAxis", paramsArray);
				NetOffice.OWC10Api.PivotFilterAxis newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PivotFilterAxis.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotFilterAxis;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotLabel Label
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Label", paramsArray);
				NetOffice.OWC10Api.PivotLabel newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PivotLabel.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotLabel;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotLabel TitleBar
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TitleBar", paramsArray);
				NetOffice.OWC10Api.PivotLabel newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PivotLabel.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotLabel;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotTotals Totals
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Totals", paramsArray);
				NetOffice.OWC10Api.PivotTotals newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PivotTotals.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotTotals;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotFont TotalFont
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TotalFont", paramsArray);
				NetOffice.OWC10Api.PivotFont newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PivotFont.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotFont;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public object TotalForeColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TotalForeColor", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TotalForeColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public object TotalBackColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TotalBackColor", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TotalBackColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotFont HeaderFont
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HeaderFont", paramsArray);
				NetOffice.OWC10Api.PivotFont newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PivotFont.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotFont;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public object HeaderForeColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HeaderForeColor", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HeaderForeColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public object HeaderBackColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HeaderBackColor", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HeaderBackColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.PivotHAlignmentEnum HeaderHAlignment
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HeaderHAlignment", paramsArray);
				return (NetOffice.OWC10Api.Enums.PivotHAlignmentEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HeaderHAlignment", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public Int32 HeaderHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HeaderHeight", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotFont FieldLabelFont
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FieldLabelFont", paramsArray);
				NetOffice.OWC10Api.PivotFont newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PivotFont.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotFont;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public object FieldLabelForeColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FieldLabelForeColor", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FieldLabelForeColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public object FieldLabelBackColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FieldLabelBackColor", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FieldLabelBackColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public Int32 FieldLabelHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FieldLabelHeight", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public Int32 DetailRowHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DetailRowHeight", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DetailRowHeight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public object DetailSortOrder
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DetailSortOrder", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DetailSortOrder", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.PivotViewTotalOrientationEnum TotalOrientation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TotalOrientation", paramsArray);
				return (NetOffice.OWC10Api.Enums.PivotViewTotalOrientationEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TotalOrientation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public bool TotalAllMembers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TotalAllMembers", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TotalAllMembers", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public Int32 DetailMaxWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DetailMaxWidth", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DetailMaxWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public Int32 DetailMaxHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DetailMaxHeight", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DetailMaxHeight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public bool DetailAutoFit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DetailAutoFit", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DetailAutoFit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public bool IsFiltered
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsFiltered", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IsFiltered", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public bool DisplayCalculatedMembers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayCalculatedMembers", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayCalculatedMembers", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public bool UseProviderFormatting
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UseProviderFormatting", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UseProviderFormatting", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.PivotTableExpandEnum ExpandDetails
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ExpandDetails", paramsArray);
				return (NetOffice.OWC10Api.Enums.PivotTableExpandEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ExpandDetails", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.IPivotControl Control
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Control", paramsArray);
				NetOffice.OWC10Api.IPivotControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.IPivotControl;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotGroupAxis PageAxis
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PageAxis", paramsArray);
				NetOffice.OWC10Api.PivotGroupAxis newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PivotGroupAxis.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotGroupAxis;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.PivotTableExpandEnum ExpandMembers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ExpandMembers", paramsArray);
				return (NetOffice.OWC10Api.Enums.PivotTableExpandEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ExpandMembers", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public bool AllowEdits
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllowEdits", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AllowEdits", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public bool AllowAdditions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllowAdditions", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AllowAdditions", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public bool AllowDeletions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllowDeletions", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AllowDeletions", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotFont PropertyCaptionFont
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PropertyCaptionFont", paramsArray);
				NetOffice.OWC10Api.PivotFont newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PivotFont.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotFont;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotFont PropertyValueFont
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PropertyValueFont", paramsArray);
				NetOffice.OWC10Api.PivotFont newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PivotFont.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotFont;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.PivotHAlignmentEnum PropertyCaptionHAlignment
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PropertyCaptionHAlignment", paramsArray);
				return (NetOffice.OWC10Api.Enums.PivotHAlignmentEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PropertyCaptionHAlignment", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.PivotHAlignmentEnum PropertyValueHAlignment
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PropertyValueHAlignment", paramsArray);
				return (NetOffice.OWC10Api.Enums.PivotHAlignmentEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PropertyValueHAlignment", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public bool DisplayCellColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayCellColor", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayCellColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public bool FilterCrossJoins
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FilterCrossJoins", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FilterCrossJoins", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="field">NetOffice.OWC10Api.PivotField Field</param>
		/// <param name="function">NetOffice.OWC10Api.Enums.PivotTotalFunctionEnum Function</param>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotTotal AddTotal(string name, NetOffice.OWC10Api.PivotField field, NetOffice.OWC10Api.Enums.PivotTotalFunctionEnum function)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, field, function);
			object returnItem = Invoker.MethodReturn(this, "AddTotal", paramsArray);
			NetOffice.OWC10Api.PivotTotal newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OWC10Api.PivotTotal.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotTotal;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="total">object Total</param>
		[SupportByLibraryAttribute("OWC10", 1)]
		public void DeleteTotal(object total)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(total);
			Invoker.Method(this, "DeleteTotal", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="name">string Name</param>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotFieldSet AddFieldSet(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "AddFieldSet", paramsArray);
			NetOffice.OWC10Api.PivotFieldSet newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OWC10Api.PivotFieldSet.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotFieldSet;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="fieldSet">object FieldSet</param>
		[SupportByLibraryAttribute("OWC10", 1)]
		public void DeleteFieldSet(object fieldSet)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldSet);
			Invoker.Method(this, "DeleteFieldSet", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="maxDataFields">optional Int32 MaxDataFields = 0</param>
		[SupportByLibraryAttribute("OWC10", 1)]
		public void AutoLayout(Int32 maxDataFields)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(maxDataFields);
			Invoker.Method(this, "AutoLayout", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("OWC10", 1)]
		public void AutoLayout()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AutoLayout", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="caption">string Caption</param>
		/// <param name="expression">string Expression</param>
		/// <param name="solveOrder">optional Int32 SolveOrder = 0</param>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotTotal AddCalculatedTotal(string name, string caption, string expression, Int32 solveOrder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, caption, expression, solveOrder);
			object returnItem = Invoker.MethodReturn(this, "AddCalculatedTotal", paramsArray);
			NetOffice.OWC10Api.PivotTotal newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OWC10Api.PivotTotal.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotTotal;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="caption">string Caption</param>
		/// <param name="expression">string Expression</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotTotal AddCalculatedTotal(string name, string caption, string expression)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, caption, expression);
			object returnItem = Invoker.MethodReturn(this, "AddCalculatedTotal", paramsArray);
			NetOffice.OWC10Api.PivotTotal newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OWC10Api.PivotTotal.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotTotal;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}