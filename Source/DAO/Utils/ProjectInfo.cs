﻿using System;
using System.Reflection;
using System.ComponentModel;
using System.Collections.Generic;
using NetOffice;

namespace DAOApi.Utils
{
	#pragma warning disable
    /// <summary>
    /// necessary factory info, used from NetOffice.Factory while Initialize()
    /// </summary>
    public class ProjectInfo : IFactoryInfo
    {
        #region Fields

        private string   _namespace     = "NetOffice.DAOApi";
        private Guid[] _componentGuid = new Guid[] { new Guid("00025E01-0000-0000-C000-000000000046"), new Guid("4AC9E1DA-5BAD-4AC7-86E3-24F4CDCECA28") };
        private Assembly _assembly;
		private Type[]	 _exportedTypes;
		private string[] _dependents;
		
        #endregion

        #region Construction

        public ProjectInfo()
        {
            _assembly = Assembly.GetExecutingAssembly();
        }

        #endregion

        #region IFactoryInfo Members

		public bool Contains(string className)
		{
			if(null == _exportedTypes)
				_exportedTypes = Assembly.GetExportedTypes();
			
			foreach (Type item in _exportedTypes)
            {
				if (item.Name.EndsWith(className, StringComparison.InvariantCultureIgnoreCase))
					return true;
            }
				
			return false;			
		}
		
        public string AssemblyNamespace
        {
            get
            {
                return _namespace;
            }
        }

        public Guid[] ComponentGuid
        {
            get
            {
                return _componentGuid;
            }
        }

        public Assembly Assembly
        {
            get
            {
                return _assembly;
            }
        }

        public string[] Dependencies
        {
            get
            {
				if(null == _dependents)
					_dependents = new string[0];
                return _dependents;
            }
        }
        
        #endregion
    }
    #pragma warning restore
}
