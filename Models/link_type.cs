//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TV.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class link_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public link_type()
        {
            this.link_parts = new HashSet<link_parts>();
        }
    
        public System.Guid ID { get; set; }
        public string TypeName { get; set; }
        public string TypeImg { get; set; }
        public int Sort { get; set; }
        public byte[] msrepl_synctran_ts { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<link_parts> link_parts { get; set; }
    }
}