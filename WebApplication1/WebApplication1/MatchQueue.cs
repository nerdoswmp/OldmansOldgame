//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class MatchQueue
    {
        public int id { get; set; }
        public Nullable<int> playerId { get; set; }
        public Nullable<int> QueueState { get; set; }
        public Nullable<int> GameMode { get; set; }
    
        public virtual Usr Usr { get; set; }
    }
}
