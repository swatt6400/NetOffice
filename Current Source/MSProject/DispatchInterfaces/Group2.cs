using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.MSProjectApi
{
	///<summary>
	/// DispatchInterface Group2 
	/// SupportByVersion MSProject, 14
	///</summary>
	[SupportByVersionAttribute("MSProject", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Group2 : COMObject
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
                    _type = typeof(Group2);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Group2(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Group2(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Group2(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Group2() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Group2(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

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

		/// <summary>
		/// SupportByVersion MSProject 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSProject", 14)]
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
		/// SupportByVersion MSProject 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 14)]
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
		/// SupportByVersion MSProject 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.Project Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				NetOffice.MSProjectApi.Project newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Project.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Project;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.GroupCriteria2 GroupCriteria
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GroupCriteria", paramsArray);
				NetOffice.MSProjectApi.GroupCriteria2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.GroupCriteria2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.GroupCriteria2;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "GroupCriteria", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSProject", 14)]
		public bool ShowSummary
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowSummary", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowSummary", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSProject", 14)]
		public bool GroupAssignments
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GroupAssignments", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "GroupAssignments", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSProject", 14)]
		public bool MaintainHierarchy
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MaintainHierarchy", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MaintainHierarchy", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		[SupportByVersionAttribute("MSProject", 14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}