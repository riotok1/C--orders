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
    
    public partial class PaintingCompetition
    {
        public int ID { get; set; }
        public Nullable<int> WorkID { get; set; }
        public Nullable<int> NominationID { get; set; }
        public string Result { get; set; }
        public int TeacherID { get; set; }
    
        public virtual Nominations Nominations { get; set; }
        public virtual StudentsWorks StudentsWorks { get; set; }
        public virtual Teachers Teachers { get; set; }
    }
}
