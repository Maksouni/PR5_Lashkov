//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR5_Lashkov.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hardware_Workshop
    {
        public int id { get; set; }
        public int hardware_id { get; set; }
        public int workshop_id { get; set; }
        public int amount { get; set; }
    
        public virtual Hardware Hardware { get; set; }
        public virtual Workshop Workshop { get; set; }
    }
}