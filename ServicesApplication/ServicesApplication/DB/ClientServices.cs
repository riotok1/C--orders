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
    
    public partial class ClientServices
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceTiiming { get; set; }
        public System.DateTime ServiceDate { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    
        public virtual Clients Clients { get; set; }
    }
}