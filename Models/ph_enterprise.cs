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
    
    public partial class ph_enterprise
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ph_enterprise()
        {
            this.ph_department = new HashSet<ph_department>();
        }
    
        public System.Guid ID { get; set; }
        public string EntName { get; set; }
        public string EntShortName { get; set; }
        public string EntAddress { get; set; }
        public string EntPhoneKod { get; set; }
        public int ParentGptn { get; set; }
        public Nullable<int> KAT { get; set; }
        public Nullable<int> LEV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ph_department> ph_department { get; set; }
    }
}
