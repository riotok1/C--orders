//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicesApplication.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Services
    {
        public int ID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceTiming { get; set; }
        public Nullable<System.DateTime> ServiceDate { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}