using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.DAOApi
{
	///<summary>
	/// DispatchInterface _Relation 
	/// SupportByVersion DAO, 5,12
	///</summary>
	[SupportByVersionAttribute("DAO", 5,12)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Relation : _DAO
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
                    _type = typeof(_Relation);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Relation(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Relation(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Relation(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Relation() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Relation(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion DAO 5, 12
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("DAO", 5,12)]
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
		/// SupportByVersion DAO 5, 12
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("DAO", 5,12)]
		public string Table
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Table", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Table", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion DAO 5, 12
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("DAO", 5,12)]
		public string ForeignTable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ForeignTable", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ForeignTable", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion DAO 5, 12
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("DAO", 5,12)]
		public Int32 Attributes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Attributes", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Attributes", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion DAO 5, 12
		/// Get
		/// </summary>
		[SupportByVersionAttribute("DAO", 5,12)]
		public NetOffice.DAOApi.Fields Fields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fields", paramsArray);
				NetOffice.DAOApi.Fields newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.DAOApi.Fields.LateBindingApiWrapperType) as NetOffice.DAOApi.Fields;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion DAO 5, 12
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("DAO", 5,12)]
		public bool PartialReplica
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PartialReplica", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PartialReplica", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion DAO 5, 12
		/// </summary>
		/// <param name="name">optional object Name</param>
		/// <param name="type">optional object Type</param>
		/// <param name="size">optional object Size</param>
		[SupportByVersionAttribute("DAO", 5,12)]
		public NetOffice.DAOApi.Field CreateField(object name, object type, object size)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, size);
			object returnItem = Invoker.MethodReturn(this, "CreateField", paramsArray);
			NetOffice.DAOApi.Field newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Field.LateBindingApiWrapperType) as NetOffice.DAOApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion DAO 5, 12
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("DAO", 5,12)]
		public NetOffice.DAOApi.Field CreateField()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateField", paramsArray);
			NetOffice.DAOApi.Field newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Field.LateBindingApiWrapperType) as NetOffice.DAOApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion DAO 5, 12
		/// </summary>
		/// <param name="name">optional object Name</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("DAO", 5,12)]
		public NetOffice.DAOApi.Field CreateField(object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "CreateField", paramsArray);
			NetOffice.DAOApi.Field newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Field.LateBindingApiWrapperType) as NetOffice.DAOApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion DAO 5, 12
		/// </summary>
		/// <param name="name">optional object Name</param>
		/// <param name="type">optional object Type</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("DAO", 5,12)]
		public NetOffice.DAOApi.Field CreateField(object name, object type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type);
			object returnItem = Invoker.MethodReturn(this, "CreateField", paramsArray);
			NetOffice.DAOApi.Field newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Field.LateBindingApiWrapperType) as NetOffice.DAOApi.Field;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}