//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wordlearn.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblLearning
    {
        public int learnID { get; set; }
        public int trID { get; set; }
        public int engID { get; set; }
        public bool yesterday { get; set; }
        public bool lastWeek { get; set; }
        public bool lastMonth { get; set; }
        public bool sixMonthsLater { get; set; }
        public bool learned { get; set; }
    
        public virtual tblengWord tblengWord { get; set; }
        public virtual tbltrWord tbltrWord { get; set; }
    }
}
