//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InstallManager.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class InstallationItem
    {
        public long ID { get; set; }
        public long InstallationID { get; set; }
        public string Version { get; set; }
        public string CopyTo { get; set; }
        public string CommandText { get; set; }
    
        public virtual Installation Installation { get; set; }
    }
}
