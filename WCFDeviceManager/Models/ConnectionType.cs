//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFDeviceManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConnectionType
    {
        public ConnectionType()
        {
            this.Connections = new HashSet<Connection>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Connection> Connections { get; set; }
    }
}
