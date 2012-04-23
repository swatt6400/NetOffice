using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface ListFormat 
	/// SupportByVersion Word, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ListFormat : COMObject
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
                    _type = typeof(ListFormat);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListFormat(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListFormat(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListFormat(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListFormat() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListFormat(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public Int32 ListLevelNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListLevelNumber", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ListLevelNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.List List
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "List", paramsArray);
				NetOffice.WordApi.List newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.List.LateBindingApiWrapperType) as NetOffice.WordApi.List;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.ListTemplate ListTemplate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListTemplate", paramsArray);
				NetOffice.WordApi.ListTemplate newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.ListTemplate.LateBindingApiWrapperType) as NetOffice.WordApi.ListTemplate;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public Int32 ListValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListValue", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool SingleList
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SingleList", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool SingleListTemplate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SingleListTemplate", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdListType ListType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.WordApi.Enums.WdListType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public string ListString
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListString", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
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
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
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
		/// SupportByVersion Word 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 10,11,12,14)]
		public NetOffice.WordApi.InlineShape ListPictureBullet
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListPictureBullet", paramsArray);
				NetOffice.WordApi.InlineShape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.InlineShape.LateBindingApiWrapperType) as NetOffice.WordApi.InlineShape;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="listTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdContinue CanContinuePreviousList(NetOffice.WordApi.ListTemplate listTemplate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate);
			object returnItem = Invoker.MethodReturn(this, "CanContinuePreviousList", paramsArray);
			int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
			return (NetOffice.WordApi.Enums.WdContinue)intReturnItem;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="numberType">optional object NumberType</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void RemoveNumbers(object numberType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numberType);
			Invoker.Method(this, "RemoveNumbers", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void RemoveNumbers()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RemoveNumbers", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="numberType">optional object NumberType</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ConvertNumbersToText(object numberType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numberType);
			Invoker.Method(this, "ConvertNumbersToText", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ConvertNumbersToText()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ConvertNumbersToText", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="numberType">optional object NumberType</param>
		/// <param name="level">optional object Level</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public Int32 CountNumberedItems(object numberType, object level)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numberType, level);
			object returnItem = Invoker.MethodReturn(this, "CountNumberedItems", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public Int32 CountNumberedItems()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CountNumberedItems", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="numberType">optional object NumberType</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public Int32 CountNumberedItems(object numberType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numberType);
			object returnItem = Invoker.MethodReturn(this, "CountNumberedItems", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ApplyBulletDefaultOld()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ApplyBulletDefaultOld", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ApplyNumberDefaultOld()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ApplyNumberDefaultOld", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ApplyOutlineNumberDefaultOld()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ApplyOutlineNumberDefaultOld", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="listTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		/// <param name="continuePreviousList">optional object ContinuePreviousList</param>
		/// <param name="applyTo">optional object ApplyTo</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ApplyListTemplateOld(NetOffice.WordApi.ListTemplate listTemplate, object continuePreviousList, object applyTo)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate, continuePreviousList, applyTo);
			Invoker.Method(this, "ApplyListTemplateOld", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="listTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ApplyListTemplateOld(NetOffice.WordApi.ListTemplate listTemplate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate);
			Invoker.Method(this, "ApplyListTemplateOld", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="listTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		/// <param name="continuePreviousList">optional object ContinuePreviousList</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ApplyListTemplateOld(NetOffice.WordApi.ListTemplate listTemplate, object continuePreviousList)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate, continuePreviousList);
			Invoker.Method(this, "ApplyListTemplateOld", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ListOutdent()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ListOutdent", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ListIndent()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ListIndent", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="defaultListBehavior">optional object DefaultListBehavior</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ApplyBulletDefault(object defaultListBehavior)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(defaultListBehavior);
			Invoker.Method(this, "ApplyBulletDefault", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ApplyBulletDefault()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ApplyBulletDefault", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="defaultListBehavior">optional object DefaultListBehavior</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ApplyNumberDefault(object defaultListBehavior)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(defaultListBehavior);
			Invoker.Method(this, "ApplyNumberDefault", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ApplyNumberDefault()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ApplyNumberDefault", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="defaultListBehavior">optional object DefaultListBehavior</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ApplyOutlineNumberDefault(object defaultListBehavior)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(defaultListBehavior);
			Invoker.Method(this, "ApplyOutlineNumberDefault", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ApplyOutlineNumberDefault()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ApplyOutlineNumberDefault", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="listTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		/// <param name="continuePreviousList">optional object ContinuePreviousList</param>
		/// <param name="applyTo">optional object ApplyTo</param>
		/// <param name="defaultListBehavior">optional object DefaultListBehavior</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ApplyListTemplate(NetOffice.WordApi.ListTemplate listTemplate, object continuePreviousList, object applyTo, object defaultListBehavior)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate, continuePreviousList, applyTo, defaultListBehavior);
			Invoker.Method(this, "ApplyListTemplate", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="listTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ApplyListTemplate(NetOffice.WordApi.ListTemplate listTemplate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate);
			Invoker.Method(this, "ApplyListTemplate", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="listTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		/// <param name="continuePreviousList">optional object ContinuePreviousList</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ApplyListTemplate(NetOffice.WordApi.ListTemplate listTemplate, object continuePreviousList)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate, continuePreviousList);
			Invoker.Method(this, "ApplyListTemplate", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="listTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		/// <param name="continuePreviousList">optional object ContinuePreviousList</param>
		/// <param name="applyTo">optional object ApplyTo</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ApplyListTemplate(NetOffice.WordApi.ListTemplate listTemplate, object continuePreviousList, object applyTo)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate, continuePreviousList, applyTo);
			Invoker.Method(this, "ApplyListTemplate", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="listTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		/// <param name="continuePreviousList">optional object ContinuePreviousList</param>
		/// <param name="applyTo">optional object ApplyTo</param>
		/// <param name="defaultListBehavior">optional object DefaultListBehavior</param>
		/// <param name="applyLevel">optional object ApplyLevel</param>
		[SupportByVersionAttribute("Word", 12,14)]
		public void ApplyListTemplateWithLevel(NetOffice.WordApi.ListTemplate listTemplate, object continuePreviousList, object applyTo, object defaultListBehavior, object applyLevel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate, continuePreviousList, applyTo, defaultListBehavior, applyLevel);
			Invoker.Method(this, "ApplyListTemplateWithLevel", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="listTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public void ApplyListTemplateWithLevel(NetOffice.WordApi.ListTemplate listTemplate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate);
			Invoker.Method(this, "ApplyListTemplateWithLevel", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="listTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		/// <param name="continuePreviousList">optional object ContinuePreviousList</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public void ApplyListTemplateWithLevel(NetOffice.WordApi.ListTemplate listTemplate, object continuePreviousList)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate, continuePreviousList);
			Invoker.Method(this, "ApplyListTemplateWithLevel", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="listTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		/// <param name="continuePreviousList">optional object ContinuePreviousList</param>
		/// <param name="applyTo">optional object ApplyTo</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public void ApplyListTemplateWithLevel(NetOffice.WordApi.ListTemplate listTemplate, object continuePreviousList, object applyTo)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate, continuePreviousList, applyTo);
			Invoker.Method(this, "ApplyListTemplateWithLevel", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="listTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		/// <param name="continuePreviousList">optional object ContinuePreviousList</param>
		/// <param name="applyTo">optional object ApplyTo</param>
		/// <param name="defaultListBehavior">optional object DefaultListBehavior</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public void ApplyListTemplateWithLevel(NetOffice.WordApi.ListTemplate listTemplate, object continuePreviousList, object applyTo, object defaultListBehavior)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate, continuePreviousList, applyTo, defaultListBehavior);
			Invoker.Method(this, "ApplyListTemplateWithLevel", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}