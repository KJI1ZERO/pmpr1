//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rabotnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rabotnik()
        {
            this.Zapis_ = new HashSet<Zapis_>();
        }
    
        public int id_rabotnica { get; set; }
        public string Name_rab { get; set; }
        public int id_doljnosti { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zapis_> Zapis_ { get; set; }
        public virtual Doljnost Doljnost { get; set; }
    }
}
