//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emp
    {
        public int Id { get; set; }
        public string Ename { get; set; }
        public string Address { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public string Gender { get; set; }
        public Nullable<int> DepID { get; set; }
    
        public virtual Dept Dept { get; set; }
    }
}
