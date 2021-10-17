namespace OdafHesapProgrami.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ODAF")]
    public partial class ODAF
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ODAF()
        {
            ProjeGenel = new HashSet<ProjeGenel>();
        }

        public int OdafID { get; set; }

        public int? RootID { get; set; }

        [StringLength(50)]
        public string S1 { get; set; }

        [StringLength(50)]
        public string S2 { get; set; }

        [StringLength(50)]
        public string S3 { get; set; }

        public int? Revizyon_No { get; set; }

        public virtual DBRoot DBRoot { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjeGenel> ProjeGenel { get; set; }
    }
}
