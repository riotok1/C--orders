//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School_Application.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentsWorks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentsWorks()
        {
            this.PaintingCompetition = new HashSet<PaintingCompetition>();
        }
    
        public int ID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public string WorkName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaintingCompetition> PaintingCompetition { get; set; }
        public virtual Students Students { get; set; }
    }
}
