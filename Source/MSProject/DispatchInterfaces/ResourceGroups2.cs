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
	/// DispatchInterface ResourceGroups2 
	/// SupportByVersion MSProject, 14
	///</summary>
	[SupportByVersionAttribute("MSProject", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ResourceGroups2 : COMObject ,IEnumerable<NetOffice.MSProjectApi.Group2>
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
                    _type = typeof(ResourceGroups2);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ResourceGroups2(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ResourceGroups2(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ResourceGroups2(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ResourceGroups2() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ResourceGroups2(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSProject 14
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("MSProject", 14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.MSProjectApi.Group2 this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.MSProjectApi.Group2 newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Group2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Group2;
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
				NetOffice.MSProjectApi.Application newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSProjectApi.Application.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Application;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="fieldName">string FieldName</param>
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.Group2 Add(string name, string fieldName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, fieldName);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.Group2 newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.Group2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Group2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="newName">string NewName</param>
		[SupportByVersionAttribute("MSProject", 14)]
		public NetOffice.MSProjectApi.Group2 Copy(string name, string newName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, newName);
			object returnItem = Invoker.MethodReturn(this, "Copy", paramsArray);
			NetOffice.MSProjectApi.Group2 newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.Group2.LateBindingApiWrapperType) as NetOffice.MSProjectApi.Group2;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.MSProjectApi.Group2> Member
        
        /// <summary>
		/// SupportByVersionAttribute MSProject, 14
		/// </summary>
		[SupportByVersionAttribute("MSProject", 14)]
       public IEnumerator<NetOffice.MSProjectApi.Group2> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.MSProjectApi.Group2 item in innerEnumerator)
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
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}