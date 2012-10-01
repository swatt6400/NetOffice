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
	/// DispatchInterface PictureEffects 
	/// SupportByVersion Office, 14,15
	///</summary>
	[SupportByVersionAttribute("Office", 14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PictureEffects : _IMsoDispObj ,IEnumerable<NetOffice.OfficeApi.PictureEffect>
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
                    _type = typeof(PictureEffects);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PictureEffects(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PictureEffects(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PictureEffects(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PictureEffects() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PictureEffects(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 14, 15
		/// Get
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Office", 14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.PictureEffect this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.PictureEffect newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.PictureEffect.LateBindingApiWrapperType) as NetOffice.OfficeApi.PictureEffect;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 14,15)]
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
		/// SupportByVersion Office 14, 15
		/// </summary>
		/// <param name="effectType">NetOffice.OfficeApi.Enums.MsoPictureEffectType EffectType</param>
		/// <param name="position">optional Int32 Position = -1</param>
		[SupportByVersionAttribute("Office", 14,15)]
		public NetOffice.OfficeApi.PictureEffect Insert(NetOffice.OfficeApi.Enums.MsoPictureEffectType effectType, object position)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(effectType, position);
			object returnItem = Invoker.MethodReturn(this, "Insert", paramsArray);
			NetOffice.OfficeApi.PictureEffect newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.PictureEffect.LateBindingApiWrapperType) as NetOffice.OfficeApi.PictureEffect;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 14, 15
		/// </summary>
		/// <param name="effectType">NetOffice.OfficeApi.Enums.MsoPictureEffectType EffectType</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 14,15)]
		public NetOffice.OfficeApi.PictureEffect Insert(NetOffice.OfficeApi.Enums.MsoPictureEffectType effectType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(effectType);
			object returnItem = Invoker.MethodReturn(this, "Insert", paramsArray);
			NetOffice.OfficeApi.PictureEffect newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.PictureEffect.LateBindingApiWrapperType) as NetOffice.OfficeApi.PictureEffect;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 14, 15
		/// </summary>
		/// <param name="index">optional Int32 Index = -1</param>
		[SupportByVersionAttribute("Office", 14,15)]
		public void Delete(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 14, 15
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 14,15)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion

       #region IEnumerable<NetOffice.OfficeApi.PictureEffect> Member
        
        /// <summary>
		/// SupportByVersionAttribute Office, 14,15
		/// </summary>
		[SupportByVersionAttribute("Office", 14,15)]
       public IEnumerator<NetOffice.OfficeApi.PictureEffect> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.OfficeApi.PictureEffect item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Office, 14,15
		/// </summary>
		[SupportByVersionAttribute("Office", 14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}