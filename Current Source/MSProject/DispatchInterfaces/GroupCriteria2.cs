using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.MSProjectApi
{
	///<summary>
	/// DispatchInterface GroupCriteria2 
	/// SupportByVersion MSProject, 14
	///</summary>
	[SupportByVersionAttribute("MSProject", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class GroupCriteria2 : COMObject ,IEnumerable<NetOffice.MSProjectApi.GroupCriterion2>
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
                    _type = typeof(GroupCriteria2);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public GroupCriteria2(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public GroupCriteria2(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public GroupCriteria2(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public GroupCriteria2() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public GroupCriteria2(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSProject 14
		/// Get
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("MSProject", 14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.MSProjectApi.GroupCriterion2 this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.Group2 Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				NetOffice.MSProjectApi.Group2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Group2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Group2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.MSProjectApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Application.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Application;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		/// <param name="fontBold">optional bool FontBold = true</param>
		/// <param name="fontItalic">optional bool FontItalic = false</param>
		/// <param name="fontUnderLine">optional bool FontUnderLine = false</param>
		/// <param name="fontColor">optional NetOffice.MSProjectApi.Enums.PjColor FontColor = 0</param>
		/// <param name="cellColor">optional NetOffice.MSProjectApi.Enums.PjColor CellColor = 16</param>
		/// <param name="pattern">optional NetOffice.MSProjectApi.Enums.PjBackgroundPattern Pattern = -1</param>
		/// <param name="groupOn">optional NetOffice.MSProjectApi.Enums.PjGroupOn GroupOn = 0</param>
		/// <param name="startAt">optional object StartAt = 0</param>
		/// <param name="groupInterval">optional object GroupInterval = 1</param>
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 Add(string fieldName, bool ascending, string fontName, Int32 fontSize, bool fontBold, bool fontItalic, bool fontUnderLine, NetOffice.MSProjectApi.Enums.PjColor fontColor, NetOffice.MSProjectApi.Enums.PjColor cellColor, NetOffice.MSProjectApi.Enums.PjBackgroundPattern pattern, NetOffice.MSProjectApi.Enums.PjGroupOn groupOn, object startAt, object groupInterval)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize, fontBold, fontItalic, fontUnderLine, fontColor, cellColor, pattern, groupOn, startAt, groupInterval);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 Add(string fieldName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 Add(string fieldName, bool ascending)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 Add(string fieldName, bool ascending, string fontName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 Add(string fieldName, bool ascending, string fontName, Int32 fontSize)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		/// <param name="fontBold">optional bool FontBold = true</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 Add(string fieldName, bool ascending, string fontName, Int32 fontSize, bool fontBold)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize, fontBold);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		/// <param name="fontBold">optional bool FontBold = true</param>
		/// <param name="fontItalic">optional bool FontItalic = false</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 Add(string fieldName, bool ascending, string fontName, Int32 fontSize, bool fontBold, bool fontItalic)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize, fontBold, fontItalic);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		/// <param name="fontBold">optional bool FontBold = true</param>
		/// <param name="fontItalic">optional bool FontItalic = false</param>
		/// <param name="fontUnderLine">optional bool FontUnderLine = false</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 Add(string fieldName, bool ascending, string fontName, Int32 fontSize, bool fontBold, bool fontItalic, bool fontUnderLine)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize, fontBold, fontItalic, fontUnderLine);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		/// <param name="fontBold">optional bool FontBold = true</param>
		/// <param name="fontItalic">optional bool FontItalic = false</param>
		/// <param name="fontUnderLine">optional bool FontUnderLine = false</param>
		/// <param name="fontColor">optional NetOffice.MSProjectApi.Enums.PjColor FontColor = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 Add(string fieldName, bool ascending, string fontName, Int32 fontSize, bool fontBold, bool fontItalic, bool fontUnderLine, NetOffice.MSProjectApi.Enums.PjColor fontColor)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize, fontBold, fontItalic, fontUnderLine, fontColor);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		/// <param name="fontBold">optional bool FontBold = true</param>
		/// <param name="fontItalic">optional bool FontItalic = false</param>
		/// <param name="fontUnderLine">optional bool FontUnderLine = false</param>
		/// <param name="fontColor">optional NetOffice.MSProjectApi.Enums.PjColor FontColor = 0</param>
		/// <param name="cellColor">optional NetOffice.MSProjectApi.Enums.PjColor CellColor = 16</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 Add(string fieldName, bool ascending, string fontName, Int32 fontSize, bool fontBold, bool fontItalic, bool fontUnderLine, NetOffice.MSProjectApi.Enums.PjColor fontColor, NetOffice.MSProjectApi.Enums.PjColor cellColor)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize, fontBold, fontItalic, fontUnderLine, fontColor, cellColor);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		/// <param name="fontBold">optional bool FontBold = true</param>
		/// <param name="fontItalic">optional bool FontItalic = false</param>
		/// <param name="fontUnderLine">optional bool FontUnderLine = false</param>
		/// <param name="fontColor">optional NetOffice.MSProjectApi.Enums.PjColor FontColor = 0</param>
		/// <param name="cellColor">optional NetOffice.MSProjectApi.Enums.PjColor CellColor = 16</param>
		/// <param name="pattern">optional NetOffice.MSProjectApi.Enums.PjBackgroundPattern Pattern = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 Add(string fieldName, bool ascending, string fontName, Int32 fontSize, bool fontBold, bool fontItalic, bool fontUnderLine, NetOffice.MSProjectApi.Enums.PjColor fontColor, NetOffice.MSProjectApi.Enums.PjColor cellColor, NetOffice.MSProjectApi.Enums.PjBackgroundPattern pattern)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize, fontBold, fontItalic, fontUnderLine, fontColor, cellColor, pattern);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		/// <param name="fontBold">optional bool FontBold = true</param>
		/// <param name="fontItalic">optional bool FontItalic = false</param>
		/// <param name="fontUnderLine">optional bool FontUnderLine = false</param>
		/// <param name="fontColor">optional NetOffice.MSProjectApi.Enums.PjColor FontColor = 0</param>
		/// <param name="cellColor">optional NetOffice.MSProjectApi.Enums.PjColor CellColor = 16</param>
		/// <param name="pattern">optional NetOffice.MSProjectApi.Enums.PjBackgroundPattern Pattern = -1</param>
		/// <param name="groupOn">optional NetOffice.MSProjectApi.Enums.PjGroupOn GroupOn = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 Add(string fieldName, bool ascending, string fontName, Int32 fontSize, bool fontBold, bool fontItalic, bool fontUnderLine, NetOffice.MSProjectApi.Enums.PjColor fontColor, NetOffice.MSProjectApi.Enums.PjColor cellColor, NetOffice.MSProjectApi.Enums.PjBackgroundPattern pattern, NetOffice.MSProjectApi.Enums.PjGroupOn groupOn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize, fontBold, fontItalic, fontUnderLine, fontColor, cellColor, pattern, groupOn);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		/// <param name="fontBold">optional bool FontBold = true</param>
		/// <param name="fontItalic">optional bool FontItalic = false</param>
		/// <param name="fontUnderLine">optional bool FontUnderLine = false</param>
		/// <param name="fontColor">optional NetOffice.MSProjectApi.Enums.PjColor FontColor = 0</param>
		/// <param name="cellColor">optional NetOffice.MSProjectApi.Enums.PjColor CellColor = 16</param>
		/// <param name="pattern">optional NetOffice.MSProjectApi.Enums.PjBackgroundPattern Pattern = -1</param>
		/// <param name="groupOn">optional NetOffice.MSProjectApi.Enums.PjGroupOn GroupOn = 0</param>
		/// <param name="startAt">optional object StartAt = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 Add(string fieldName, bool ascending, string fontName, Int32 fontSize, bool fontBold, bool fontItalic, bool fontUnderLine, NetOffice.MSProjectApi.Enums.PjColor fontColor, NetOffice.MSProjectApi.Enums.PjColor cellColor, NetOffice.MSProjectApi.Enums.PjBackgroundPattern pattern, NetOffice.MSProjectApi.Enums.PjGroupOn groupOn, object startAt)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize, fontBold, fontItalic, fontUnderLine, fontColor, cellColor, pattern, groupOn, startAt);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		/// <param name="fontBold">optional bool FontBold = true</param>
		/// <param name="fontItalic">optional bool FontItalic = false</param>
		/// <param name="fontUnderLine">optional bool FontUnderLine = false</param>
		/// <param name="fontColor">optional Int32 FontColor = -16777216</param>
		/// <param name="cellColor">optional Int32 CellColor = -16777216</param>
		/// <param name="pattern">optional NetOffice.MSProjectApi.Enums.PjBackgroundPattern Pattern = -1</param>
		/// <param name="groupOn">optional NetOffice.MSProjectApi.Enums.PjGroupOn GroupOn = 0</param>
		/// <param name="startAt">optional object StartAt = 0</param>
		/// <param name="groupInterval">optional object GroupInterval = 1</param>
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 AddEx(string fieldName, bool ascending, string fontName, Int32 fontSize, bool fontBold, bool fontItalic, bool fontUnderLine, Int32 fontColor, Int32 cellColor, NetOffice.MSProjectApi.Enums.PjBackgroundPattern pattern, NetOffice.MSProjectApi.Enums.PjGroupOn groupOn, object startAt, object groupInterval)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize, fontBold, fontItalic, fontUnderLine, fontColor, cellColor, pattern, groupOn, startAt, groupInterval);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 AddEx(string fieldName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 AddEx(string fieldName, bool ascending)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 AddEx(string fieldName, bool ascending, string fontName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 AddEx(string fieldName, bool ascending, string fontName, Int32 fontSize)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		/// <param name="fontBold">optional bool FontBold = true</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 AddEx(string fieldName, bool ascending, string fontName, Int32 fontSize, bool fontBold)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize, fontBold);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		/// <param name="fontBold">optional bool FontBold = true</param>
		/// <param name="fontItalic">optional bool FontItalic = false</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 AddEx(string fieldName, bool ascending, string fontName, Int32 fontSize, bool fontBold, bool fontItalic)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize, fontBold, fontItalic);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		/// <param name="fontBold">optional bool FontBold = true</param>
		/// <param name="fontItalic">optional bool FontItalic = false</param>
		/// <param name="fontUnderLine">optional bool FontUnderLine = false</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 AddEx(string fieldName, bool ascending, string fontName, Int32 fontSize, bool fontBold, bool fontItalic, bool fontUnderLine)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize, fontBold, fontItalic, fontUnderLine);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		/// <param name="fontBold">optional bool FontBold = true</param>
		/// <param name="fontItalic">optional bool FontItalic = false</param>
		/// <param name="fontUnderLine">optional bool FontUnderLine = false</param>
		/// <param name="fontColor">optional Int32 FontColor = -16777216</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 AddEx(string fieldName, bool ascending, string fontName, Int32 fontSize, bool fontBold, bool fontItalic, bool fontUnderLine, Int32 fontColor)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize, fontBold, fontItalic, fontUnderLine, fontColor);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		/// <param name="fontBold">optional bool FontBold = true</param>
		/// <param name="fontItalic">optional bool FontItalic = false</param>
		/// <param name="fontUnderLine">optional bool FontUnderLine = false</param>
		/// <param name="fontColor">optional Int32 FontColor = -16777216</param>
		/// <param name="cellColor">optional Int32 CellColor = -16777216</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 AddEx(string fieldName, bool ascending, string fontName, Int32 fontSize, bool fontBold, bool fontItalic, bool fontUnderLine, Int32 fontColor, Int32 cellColor)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize, fontBold, fontItalic, fontUnderLine, fontColor, cellColor);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		/// <param name="fontBold">optional bool FontBold = true</param>
		/// <param name="fontItalic">optional bool FontItalic = false</param>
		/// <param name="fontUnderLine">optional bool FontUnderLine = false</param>
		/// <param name="fontColor">optional Int32 FontColor = -16777216</param>
		/// <param name="cellColor">optional Int32 CellColor = -16777216</param>
		/// <param name="pattern">optional NetOffice.MSProjectApi.Enums.PjBackgroundPattern Pattern = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 AddEx(string fieldName, bool ascending, string fontName, Int32 fontSize, bool fontBold, bool fontItalic, bool fontUnderLine, Int32 fontColor, Int32 cellColor, NetOffice.MSProjectApi.Enums.PjBackgroundPattern pattern)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize, fontBold, fontItalic, fontUnderLine, fontColor, cellColor, pattern);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		/// <param name="fontBold">optional bool FontBold = true</param>
		/// <param name="fontItalic">optional bool FontItalic = false</param>
		/// <param name="fontUnderLine">optional bool FontUnderLine = false</param>
		/// <param name="fontColor">optional Int32 FontColor = -16777216</param>
		/// <param name="cellColor">optional Int32 CellColor = -16777216</param>
		/// <param name="pattern">optional NetOffice.MSProjectApi.Enums.PjBackgroundPattern Pattern = -1</param>
		/// <param name="groupOn">optional NetOffice.MSProjectApi.Enums.PjGroupOn GroupOn = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 AddEx(string fieldName, bool ascending, string fontName, Int32 fontSize, bool fontBold, bool fontItalic, bool fontUnderLine, Int32 fontColor, Int32 cellColor, NetOffice.MSProjectApi.Enums.PjBackgroundPattern pattern, NetOffice.MSProjectApi.Enums.PjGroupOn groupOn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize, fontBold, fontItalic, fontUnderLine, fontColor, cellColor, pattern, groupOn);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="fieldName">string FieldName</param>
		/// <param name="ascending">optional bool Ascending = true</param>
		/// <param name="fontName">optional string FontName = </param>
		/// <param name="fontSize">optional Int32 FontSize = 8</param>
		/// <param name="fontBold">optional bool FontBold = true</param>
		/// <param name="fontItalic">optional bool FontItalic = false</param>
		/// <param name="fontUnderLine">optional bool FontUnderLine = false</param>
		/// <param name="fontColor">optional Int32 FontColor = -16777216</param>
		/// <param name="cellColor">optional Int32 CellColor = -16777216</param>
		/// <param name="pattern">optional NetOffice.MSProjectApi.Enums.PjBackgroundPattern Pattern = -1</param>
		/// <param name="groupOn">optional NetOffice.MSProjectApi.Enums.PjGroupOn GroupOn = 0</param>
		/// <param name="startAt">optional object StartAt = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriterion2 AddEx(string fieldName, bool ascending, string fontName, Int32 fontSize, bool fontBold, bool fontItalic, bool fontUnderLine, Int32 fontColor, Int32 cellColor, NetOffice.MSProjectApi.Enums.PjBackgroundPattern pattern, NetOffice.MSProjectApi.Enums.PjGroupOn groupOn, object startAt)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldName, ascending, fontName, fontSize, fontBold, fontItalic, fontUnderLine, fontColor, cellColor, pattern, groupOn, startAt);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.MSProjectApi.GroupCriterion2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.GroupCriterion2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriterion2;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.MSProjectApi.GroupCriterion2> Member
        
        /// <summary>
		/// SupportByVersionAttribute MSProject, 14
		/// </summary>
		[SupportByVersionAttribute("MSProject", 14)]
       public IEnumerator<NetOffice.MSProjectApi.GroupCriterion2> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.MSProjectApi.GroupCriterion2 item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute MSProject, 14
		/// </summary>
		[SupportByVersionAttribute("MSProject", 14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return LateBindingApi.Core.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}