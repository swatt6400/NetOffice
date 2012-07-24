using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface FileTypes 
	/// SupportByVersion Office, 10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Office", 10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class FileTypes : _IMsoDispObj ,IEnumerable<NetOffice.OfficeApi.Enums.MsoFileType>
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
                    _type = typeof(FileTypes);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileTypes(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileTypes(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileTypes(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileTypes() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileTypes(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Office", 10,11,12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.Enums.MsoFileType this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
			return (NetOffice.OfficeApi.Enums.MsoFileType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14,15)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="fileType">NetOffice.OfficeApi.Enums.MsoFileType FileType</param>
		[SupportByVersionAttribute("Office", 10,11,12,14,15)]
		public void Add(NetOffice.OfficeApi.Enums.MsoFileType fileType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileType);
			Invoker.Method(this, "Add", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Office", 10,11,12,14,15)]
		public void Remove(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Remove", paramsArray);
		}

		#endregion

       #region IEnumerable<NetOffice.OfficeApi.Enums.MsoFileType> Member
        
        /// <summary>
		/// SupportByVersionAttribute Office, 10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14,15)]
       public IEnumerator<NetOffice.OfficeApi.Enums.MsoFileType> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.OfficeApi.Enums.MsoFileType item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Office, 10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}