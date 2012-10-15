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
	/// DispatchInterface TaskGroups 
	/// SupportByVersion MSProject, 11,12,14,15
	///</summary>
	[SupportByVersionAttribute("MSProject", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class TaskGroups : COMObject ,IEnumerable<NetOffice.MSProjectApi.Group>
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
                    _type = typeof(TaskGroups);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TaskGroups(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TaskGroups(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TaskGroups(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TaskGroups() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TaskGroups(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("MSProject", 11,12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.MSProjectApi.Group this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.MSProjectApi.Group newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Group.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Group;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14,15)]
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
		/// SupportByVersion MSProject 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14,15)]
		public NetOffice.MSProjectApi.Project Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				NetOffice.MSProjectApi.Project newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Project.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Project;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14,15)]
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

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14, 15
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="fieldName">string FieldName</param>
		[SupportByVersionAttribute("MSProject", 11,12,14,15)]
		public NetOffice.MSProjectApi.Group Add(string name, string fieldName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, fieldName);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.Group newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.Group.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Group;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14, 15
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="newName">string NewName</param>
		[SupportByVersionAttribute("MSProject", 11,12,14,15)]
		public NetOffice.MSProjectApi.Group Copy(string name, string newName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, newName);
			object returnItem = Invoker.MethodReturn(this, "Copy", paramsArray);
			NetOffice.MSProjectApi.Group newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.Group.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Group;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.MSProjectApi.Group> Member
        
        /// <summary>
		/// SupportByVersionAttribute MSProject, 11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14,15)]
       public IEnumerator<NetOffice.MSProjectApi.Group> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.MSProjectApi.Group item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute MSProject, 11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("MSProject", 11,12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}