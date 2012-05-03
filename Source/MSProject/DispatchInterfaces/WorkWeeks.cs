using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.MSProjectApi
{
	///<summary>
	/// DispatchInterface WorkWeeks 
	/// SupportByVersion MSProject, 12,14
	///</summary>
	[SupportByVersionAttribute("MSProject", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class WorkWeeks : COMObject ,IEnumerable<NetOffice.MSProjectApi.WorkWeek>
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
                    _type = typeof(WorkWeeks);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public WorkWeeks(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public WorkWeeks(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public WorkWeeks(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public WorkWeeks() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public WorkWeeks(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 12,14)]
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
		/// SupportByVersion MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.Calendar Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				NetOffice.MSProjectApi.Calendar newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Calendar.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Calendar;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 12,14)]
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
		/// SupportByVersion MSProject 12, 14
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("MSProject", 12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.MSProjectApi.WorkWeek this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.MSProjectApi.WorkWeek newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.WorkWeek.LateBindingApiWrapperType) as NetOffice.MSProjectApi.WorkWeek;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSProject 12, 14
		/// </summary>
		/// <param name="start">object Start</param>
		/// <param name="finish">optional object Finish</param>
		/// <param name="name">optional object Name</param>
		[SupportByVersionAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.WorkWeek Add(object start, object finish, object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, finish, name);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.WorkWeek newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.WorkWeek.LateBindingApiWrapperType) as NetOffice.MSProjectApi.WorkWeek;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 12, 14
		/// </summary>
		/// <param name="start">object Start</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.WorkWeek Add(object start)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.WorkWeek newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.WorkWeek.LateBindingApiWrapperType) as NetOffice.MSProjectApi.WorkWeek;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 12, 14
		/// </summary>
		/// <param name="start">object Start</param>
		/// <param name="finish">optional object Finish</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 12,14)]
		public NetOffice.MSProjectApi.WorkWeek Add(object start, object finish)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, finish);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.WorkWeek newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.WorkWeek.LateBindingApiWrapperType) as NetOffice.MSProjectApi.WorkWeek;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.MSProjectApi.WorkWeek> Member
        
        /// <summary>
		/// SupportByVersionAttribute MSProject, 12,14
		/// </summary>
		[SupportByVersionAttribute("MSProject", 12,14)]
       public IEnumerator<NetOffice.MSProjectApi.WorkWeek> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.MSProjectApi.WorkWeek item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute MSProject, 12,14
		/// </summary>
		[SupportByVersionAttribute("MSProject", 12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}