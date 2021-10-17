namespace OdafHesapProgrami.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DBRoot")]
    public partial class DBRoot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DBRoot()
        {
            ODAF = new HashSet<ODAF>();
        }

        [Key]
        public int RootID { get; set; }

        public int? Task_ID { get; set; }

        public int? SiparisNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ODAF> ODAF { get; set; }
    }
}
