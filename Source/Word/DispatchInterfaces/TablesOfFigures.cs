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
	/// DispatchInterface TablesOfFigures 
	/// SupportByVersion Word, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class TablesOfFigures : COMObject ,IEnumerable<NetOffice.WordApi.TableOfFigures>
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
                    _type = typeof(TablesOfFigures);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TablesOfFigures(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TablesOfFigures(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TablesOfFigures(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TablesOfFigures() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TablesOfFigures(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

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
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
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
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdTofFormat Format
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Format", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.WordApi.Enums.WdTofFormat)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Format", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.WordApi.TableOfFigures this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		/// <param name="useHeadingStyles">optional object UseHeadingStyles</param>
		/// <param name="upperHeadingLevel">optional object UpperHeadingLevel</param>
		/// <param name="lowerHeadingLevel">optional object LowerHeadingLevel</param>
		/// <param name="useFields">optional object UseFields</param>
		/// <param name="tableID">optional object TableID</param>
		/// <param name="rightAlignPageNumbers">optional object RightAlignPageNumbers</param>
		/// <param name="includePageNumbers">optional object IncludePageNumbers</param>
		/// <param name="addedStyles">optional object AddedStyles</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures AddOld(NetOffice.WordApi.Range range, object caption, object includeLabel, object useHeadingStyles, object upperHeadingLevel, object lowerHeadingLevel, object useFields, object tableID, object rightAlignPageNumbers, object includePageNumbers, object addedStyles)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles, upperHeadingLevel, lowerHeadingLevel, useFields, tableID, rightAlignPageNumbers, includePageNumbers, addedStyles);
			object returnItem = Invoker.MethodReturn(this, "AddOld", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures AddOld(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "AddOld", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures AddOld(NetOffice.WordApi.Range range, object caption)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption);
			object returnItem = Invoker.MethodReturn(this, "AddOld", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures AddOld(NetOffice.WordApi.Range range, object caption, object includeLabel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel);
			object returnItem = Invoker.MethodReturn(this, "AddOld", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		/// <param name="useHeadingStyles">optional object UseHeadingStyles</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures AddOld(NetOffice.WordApi.Range range, object caption, object includeLabel, object useHeadingStyles)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles);
			object returnItem = Invoker.MethodReturn(this, "AddOld", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		/// <param name="useHeadingStyles">optional object UseHeadingStyles</param>
		/// <param name="upperHeadingLevel">optional object UpperHeadingLevel</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures AddOld(NetOffice.WordApi.Range range, object caption, object includeLabel, object useHeadingStyles, object upperHeadingLevel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles, upperHeadingLevel);
			object returnItem = Invoker.MethodReturn(this, "AddOld", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		/// <param name="useHeadingStyles">optional object UseHeadingStyles</param>
		/// <param name="upperHeadingLevel">optional object UpperHeadingLevel</param>
		/// <param name="lowerHeadingLevel">optional object LowerHeadingLevel</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures AddOld(NetOffice.WordApi.Range range, object caption, object includeLabel, object useHeadingStyles, object upperHeadingLevel, object lowerHeadingLevel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles, upperHeadingLevel, lowerHeadingLevel);
			object returnItem = Invoker.MethodReturn(this, "AddOld", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		/// <param name="useHeadingStyles">optional object UseHeadingStyles</param>
		/// <param name="upperHeadingLevel">optional object UpperHeadingLevel</param>
		/// <param name="lowerHeadingLevel">optional object LowerHeadingLevel</param>
		/// <param name="useFields">optional object UseFields</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures AddOld(NetOffice.WordApi.Range range, object caption, object includeLabel, object useHeadingStyles, object upperHeadingLevel, object lowerHeadingLevel, object useFields)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles, upperHeadingLevel, lowerHeadingLevel, useFields);
			object returnItem = Invoker.MethodReturn(this, "AddOld", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		/// <param name="useHeadingStyles">optional object UseHeadingStyles</param>
		/// <param name="upperHeadingLevel">optional object UpperHeadingLevel</param>
		/// <param name="lowerHeadingLevel">optional object LowerHeadingLevel</param>
		/// <param name="useFields">optional object UseFields</param>
		/// <param name="tableID">optional object TableID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures AddOld(NetOffice.WordApi.Range range, object caption, object includeLabel, object useHeadingStyles, object upperHeadingLevel, object lowerHeadingLevel, object useFields, object tableID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles, upperHeadingLevel, lowerHeadingLevel, useFields, tableID);
			object returnItem = Invoker.MethodReturn(this, "AddOld", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		/// <param name="useHeadingStyles">optional object UseHeadingStyles</param>
		/// <param name="upperHeadingLevel">optional object UpperHeadingLevel</param>
		/// <param name="lowerHeadingLevel">optional object LowerHeadingLevel</param>
		/// <param name="useFields">optional object UseFields</param>
		/// <param name="tableID">optional object TableID</param>
		/// <param name="rightAlignPageNumbers">optional object RightAlignPageNumbers</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures AddOld(NetOffice.WordApi.Range range, object caption, object includeLabel, object useHeadingStyles, object upperHeadingLevel, object lowerHeadingLevel, object useFields, object tableID, object rightAlignPageNumbers)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles, upperHeadingLevel, lowerHeadingLevel, useFields, tableID, rightAlignPageNumbers);
			object returnItem = Invoker.MethodReturn(this, "AddOld", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		/// <param name="useHeadingStyles">optional object UseHeadingStyles</param>
		/// <param name="upperHeadingLevel">optional object UpperHeadingLevel</param>
		/// <param name="lowerHeadingLevel">optional object LowerHeadingLevel</param>
		/// <param name="useFields">optional object UseFields</param>
		/// <param name="tableID">optional object TableID</param>
		/// <param name="rightAlignPageNumbers">optional object RightAlignPageNumbers</param>
		/// <param name="includePageNumbers">optional object IncludePageNumbers</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures AddOld(NetOffice.WordApi.Range range, object caption, object includeLabel, object useHeadingStyles, object upperHeadingLevel, object lowerHeadingLevel, object useFields, object tableID, object rightAlignPageNumbers, object includePageNumbers)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles, upperHeadingLevel, lowerHeadingLevel, useFields, tableID, rightAlignPageNumbers, includePageNumbers);
			object returnItem = Invoker.MethodReturn(this, "AddOld", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="entry">optional object Entry</param>
		/// <param name="entryAutoText">optional object EntryAutoText</param>
		/// <param name="tableID">optional object TableID</param>
		/// <param name="level">optional object Level</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Field MarkEntry(NetOffice.WordApi.Range range, object entry, object entryAutoText, object tableID, object level)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, entry, entryAutoText, tableID, level);
			object returnItem = Invoker.MethodReturn(this, "MarkEntry", paramsArray);
			NetOffice.WordApi.Field newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Field.LateBindingApiWrapperType) as NetOffice.WordApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Field MarkEntry(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "MarkEntry", paramsArray);
			NetOffice.WordApi.Field newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Field.LateBindingApiWrapperType) as NetOffice.WordApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="entry">optional object Entry</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Field MarkEntry(NetOffice.WordApi.Range range, object entry)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, entry);
			object returnItem = Invoker.MethodReturn(this, "MarkEntry", paramsArray);
			NetOffice.WordApi.Field newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Field.LateBindingApiWrapperType) as NetOffice.WordApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="entry">optional object Entry</param>
		/// <param name="entryAutoText">optional object EntryAutoText</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Field MarkEntry(NetOffice.WordApi.Range range, object entry, object entryAutoText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, entry, entryAutoText);
			object returnItem = Invoker.MethodReturn(this, "MarkEntry", paramsArray);
			NetOffice.WordApi.Field newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Field.LateBindingApiWrapperType) as NetOffice.WordApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="entry">optional object Entry</param>
		/// <param name="entryAutoText">optional object EntryAutoText</param>
		/// <param name="tableID">optional object TableID</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Field MarkEntry(NetOffice.WordApi.Range range, object entry, object entryAutoText, object tableID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, entry, entryAutoText, tableID);
			object returnItem = Invoker.MethodReturn(this, "MarkEntry", paramsArray);
			NetOffice.WordApi.Field newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Field.LateBindingApiWrapperType) as NetOffice.WordApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		/// <param name="useHeadingStyles">optional object UseHeadingStyles</param>
		/// <param name="upperHeadingLevel">optional object UpperHeadingLevel</param>
		/// <param name="lowerHeadingLevel">optional object LowerHeadingLevel</param>
		/// <param name="useFields">optional object UseFields</param>
		/// <param name="tableID">optional object TableID</param>
		/// <param name="rightAlignPageNumbers">optional object RightAlignPageNumbers</param>
		/// <param name="includePageNumbers">optional object IncludePageNumbers</param>
		/// <param name="addedStyles">optional object AddedStyles</param>
		/// <param name="useHyperlinks">optional object UseHyperlinks</param>
		/// <param name="hidePageNumbersInWeb">optional object HidePageNumbersInWeb</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures Add(NetOffice.WordApi.Range range, object caption, object includeLabel, object useHeadingStyles, object upperHeadingLevel, object lowerHeadingLevel, object useFields, object tableID, object rightAlignPageNumbers, object includePageNumbers, object addedStyles, object useHyperlinks, object hidePageNumbersInWeb)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles, upperHeadingLevel, lowerHeadingLevel, useFields, tableID, rightAlignPageNumbers, includePageNumbers, addedStyles, useHyperlinks, hidePageNumbersInWeb);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures Add(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures Add(NetOffice.WordApi.Range range, object caption)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures Add(NetOffice.WordApi.Range range, object caption, object includeLabel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		/// <param name="useHeadingStyles">optional object UseHeadingStyles</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures Add(NetOffice.WordApi.Range range, object caption, object includeLabel, object useHeadingStyles)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		/// <param name="useHeadingStyles">optional object UseHeadingStyles</param>
		/// <param name="upperHeadingLevel">optional object UpperHeadingLevel</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures Add(NetOffice.WordApi.Range range, object caption, object includeLabel, object useHeadingStyles, object upperHeadingLevel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles, upperHeadingLevel);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		/// <param name="useHeadingStyles">optional object UseHeadingStyles</param>
		/// <param name="upperHeadingLevel">optional object UpperHeadingLevel</param>
		/// <param name="lowerHeadingLevel">optional object LowerHeadingLevel</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures Add(NetOffice.WordApi.Range range, object caption, object includeLabel, object useHeadingStyles, object upperHeadingLevel, object lowerHeadingLevel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles, upperHeadingLevel, lowerHeadingLevel);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		/// <param name="useHeadingStyles">optional object UseHeadingStyles</param>
		/// <param name="upperHeadingLevel">optional object UpperHeadingLevel</param>
		/// <param name="lowerHeadingLevel">optional object LowerHeadingLevel</param>
		/// <param name="useFields">optional object UseFields</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures Add(NetOffice.WordApi.Range range, object caption, object includeLabel, object useHeadingStyles, object upperHeadingLevel, object lowerHeadingLevel, object useFields)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles, upperHeadingLevel, lowerHeadingLevel, useFields);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		/// <param name="useHeadingStyles">optional object UseHeadingStyles</param>
		/// <param name="upperHeadingLevel">optional object UpperHeadingLevel</param>
		/// <param name="lowerHeadingLevel">optional object LowerHeadingLevel</param>
		/// <param name="useFields">optional object UseFields</param>
		/// <param name="tableID">optional object TableID</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures Add(NetOffice.WordApi.Range range, object caption, object includeLabel, object useHeadingStyles, object upperHeadingLevel, object lowerHeadingLevel, object useFields, object tableID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles, upperHeadingLevel, lowerHeadingLevel, useFields, tableID);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		/// <param name="useHeadingStyles">optional object UseHeadingStyles</param>
		/// <param name="upperHeadingLevel">optional object UpperHeadingLevel</param>
		/// <param name="lowerHeadingLevel">optional object LowerHeadingLevel</param>
		/// <param name="useFields">optional object UseFields</param>
		/// <param name="tableID">optional object TableID</param>
		/// <param name="rightAlignPageNumbers">optional object RightAlignPageNumbers</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures Add(NetOffice.WordApi.Range range, object caption, object includeLabel, object useHeadingStyles, object upperHeadingLevel, object lowerHeadingLevel, object useFields, object tableID, object rightAlignPageNumbers)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles, upperHeadingLevel, lowerHeadingLevel, useFields, tableID, rightAlignPageNumbers);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		/// <param name="useHeadingStyles">optional object UseHeadingStyles</param>
		/// <param name="upperHeadingLevel">optional object UpperHeadingLevel</param>
		/// <param name="lowerHeadingLevel">optional object LowerHeadingLevel</param>
		/// <param name="useFields">optional object UseFields</param>
		/// <param name="tableID">optional object TableID</param>
		/// <param name="rightAlignPageNumbers">optional object RightAlignPageNumbers</param>
		/// <param name="includePageNumbers">optional object IncludePageNumbers</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures Add(NetOffice.WordApi.Range range, object caption, object includeLabel, object useHeadingStyles, object upperHeadingLevel, object lowerHeadingLevel, object useFields, object tableID, object rightAlignPageNumbers, object includePageNumbers)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles, upperHeadingLevel, lowerHeadingLevel, useFields, tableID, rightAlignPageNumbers, includePageNumbers);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		/// <param name="useHeadingStyles">optional object UseHeadingStyles</param>
		/// <param name="upperHeadingLevel">optional object UpperHeadingLevel</param>
		/// <param name="lowerHeadingLevel">optional object LowerHeadingLevel</param>
		/// <param name="useFields">optional object UseFields</param>
		/// <param name="tableID">optional object TableID</param>
		/// <param name="rightAlignPageNumbers">optional object RightAlignPageNumbers</param>
		/// <param name="includePageNumbers">optional object IncludePageNumbers</param>
		/// <param name="addedStyles">optional object AddedStyles</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures Add(NetOffice.WordApi.Range range, object caption, object includeLabel, object useHeadingStyles, object upperHeadingLevel, object lowerHeadingLevel, object useFields, object tableID, object rightAlignPageNumbers, object includePageNumbers, object addedStyles)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles, upperHeadingLevel, lowerHeadingLevel, useFields, tableID, rightAlignPageNumbers, includePageNumbers, addedStyles);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		/// <param name="caption">optional object Caption</param>
		/// <param name="includeLabel">optional object IncludeLabel</param>
		/// <param name="useHeadingStyles">optional object UseHeadingStyles</param>
		/// <param name="upperHeadingLevel">optional object UpperHeadingLevel</param>
		/// <param name="lowerHeadingLevel">optional object LowerHeadingLevel</param>
		/// <param name="useFields">optional object UseFields</param>
		/// <param name="tableID">optional object TableID</param>
		/// <param name="rightAlignPageNumbers">optional object RightAlignPageNumbers</param>
		/// <param name="includePageNumbers">optional object IncludePageNumbers</param>
		/// <param name="addedStyles">optional object AddedStyles</param>
		/// <param name="useHyperlinks">optional object UseHyperlinks</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures Add(NetOffice.WordApi.Range range, object caption, object includeLabel, object useHeadingStyles, object upperHeadingLevel, object lowerHeadingLevel, object useFields, object tableID, object rightAlignPageNumbers, object includePageNumbers, object addedStyles, object useHyperlinks)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles, upperHeadingLevel, lowerHeadingLevel, useFields, tableID, rightAlignPageNumbers, includePageNumbers, addedStyles, useHyperlinks);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfFigures.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.WordApi.TableOfFigures> Member
        
        /// <summary>
		/// SupportByVersionAttribute Word, 9,10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
       public IEnumerator<NetOffice.WordApi.TableOfFigures> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.WordApi.TableOfFigures item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Word, 9,10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}