//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Children.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Journal
    {
        public int ID { get; set; }
        public System.DateTime Datelesson { get; set; }
        public int IdGroup { get; set; }
        public int IdActivity { get; set; }
        public int IdMark { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual Group Group { get; set; }
        public virtual Mark Mark { get; set; }
    }
}
