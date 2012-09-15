using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.MSProjectApi
{
	///<summary>
	/// DispatchInterface Calendar 
	/// SupportByVersion MSProject, 11,12,14
	///</summary>
	[SupportByVersionAttribute("MSProject", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Calendar : COMObject
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
                    _type = typeof(Calendar);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Calendar(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Calendar(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Calendar(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Calendar() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Calendar(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14)]
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
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14)]
		public NetOffice.MSProjectApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.MSProjectApi.Application newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Application.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14)]
		public NetOffice.MSProjectApi.Years Years
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Years", paramsArray);
				NetOffice.MSProjectApi.Years newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Years.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Years;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14)]
		public NetOffice.MSProjectApi.WeekDays WeekDays
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WeekDays", paramsArray);
				NetOffice.MSProjectApi.WeekDays newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.WeekDays.LateBindingApiWrapperType) as NetOffice.MSProjectApi.WeekDays;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14)]
		public NetOffice.MSProjectApi.Calendar BaseCalendar
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BaseCalendar", paramsArray);
				NetOffice.MSProjectApi.Calendar newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Calendar.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Calendar;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14)]
		public Int32 Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14)]
		public object Enterprise
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Enterprise", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14)]
		public string Guid
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Guid", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14)]
		public string ResourceGuid
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ResourceGuid", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14)]
		public NetOffice.MSProjectApi.Exceptions Exceptions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Exceptions", paramsArray);
				NetOffice.MSProjectApi.Exceptions newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Exceptions.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Exceptions;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14)]
		public NetOffice.MSProjectApi.WorkWeeks WorkWeeks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WorkWeeks", paramsArray);
				NetOffice.MSProjectApi.WorkWeeks newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.WorkWeeks.LateBindingApiWrapperType) as NetOffice.MSProjectApi.WorkWeeks;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// </summary>
		/// <param name="start">object Start</param>
		/// <param name="finish">optional object Finish</param>
		[SupportByVersionAttribute("MSProject", 11,12,14)]
		public NetOffice.MSProjectApi.Period Period(object start, object finish)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, finish);
			object returnItem = Invoker.MethodReturn(this, "Period", paramsArray);
			NetOffice.MSProjectApi.Period newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.Period.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Period;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// </summary>
		/// <param name="start">object Start</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 11,12,14)]
		public NetOffice.MSProjectApi.Period Period(object start)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start);
			object returnItem = Invoker.MethodReturn(this, "Period", paramsArray);
			NetOffice.MSProjectApi.Period newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.Period.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Period;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14)]
		public void Reset()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Reset", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}