//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeManagement.Database.Models.Model
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public partial class USAState
    {
        public USAState()
        {
            this.Employees = new HashSet<Employee>();
        }
        
        public int usa_state_id { get; set; }

        public string State { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}