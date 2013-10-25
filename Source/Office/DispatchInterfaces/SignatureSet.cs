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
	/// DispatchInterface SignatureSet 
	/// SupportByVersion Office, 10,11,12,14,15
	///</summary>
	///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff861798.aspx </remarks>
	[SupportByVersionAttribute("Office", 10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SignatureSet : _IMsoDispObj ,IEnumerable<NetOffice.OfficeApi.Signature>
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
                    _type = typeof(SignatureSet);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public SignatureSet(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SignatureSet(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SignatureSet(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SignatureSet(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SignatureSet(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SignatureSet() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SignatureSet(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff862205.aspx </remarks>
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

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="iSig">Int32 iSig</param>
		[SupportByVersionAttribute("Office", 10,11,12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.Signature this[Int32 iSig]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(iSig);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.Signature newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.Signature.LateBindingApiWrapperType) as NetOffice.OfficeApi.Signature;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff862853.aspx </remarks>
		[SupportByVersionAttribute("Office", 10,11,12,14,15)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// Get
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff865204.aspx </remarks>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public bool CanAddSignatureLine
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CanAddSignatureLine", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff860322.aspx </remarks>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoSignatureSubset Subset
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Subset", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoSignatureSubset)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Subset", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// Get/Set
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff860584.aspx </remarks>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public bool ShowSignaturesPane
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowSignaturesPane", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowSignaturesPane", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14,15)]
		public NetOffice.OfficeApi.Signature Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.Signature newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Signature.LateBindingApiWrapperType) as NetOffice.OfficeApi.Signature;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14,15)]
		public void Commit()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Commit", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="varSigProv">optional object varSigProv</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff865505.aspx </remarks>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.Signature AddNonVisibleSignature(object varSigProv)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varSigProv);
			object returnItem = Invoker.MethodReturn(this, "AddNonVisibleSignature", paramsArray);
			NetOffice.OfficeApi.Signature newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Signature.LateBindingApiWrapperType) as NetOffice.OfficeApi.Signature;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff865505.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.Signature AddNonVisibleSignature()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddNonVisibleSignature", paramsArray);
			NetOffice.OfficeApi.Signature newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Signature.LateBindingApiWrapperType) as NetOffice.OfficeApi.Signature;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="varSigProv">optional object varSigProv</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff865238.aspx </remarks>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.Signature AddSignatureLine(object varSigProv)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varSigProv);
			object returnItem = Invoker.MethodReturn(this, "AddSignatureLine", paramsArray);
			NetOffice.OfficeApi.Signature newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Signature.LateBindingApiWrapperType) as NetOffice.OfficeApi.Signature;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff865238.aspx </remarks>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.Signature AddSignatureLine()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddSignatureLine", paramsArray);
			NetOffice.OfficeApi.Signature newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Signature.LateBindingApiWrapperType) as NetOffice.OfficeApi.Signature;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.OfficeApi.Signature> Member
        
        /// <summary>
		/// SupportByVersionAttribute Office, 10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14,15)]
       public IEnumerator<NetOffice.OfficeApi.Signature> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.OfficeApi.Signature item in innerEnumerator)
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