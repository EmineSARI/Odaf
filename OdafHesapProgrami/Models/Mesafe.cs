namespace OdafHesapProgrami.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mesafe")]
    public partial class Mesafe
    {
        public int MesafeID { get; set; }

        public int? ProjeID { get; set; }

        [StringLength(50)]
        public string AG_YG_Mesafe { get; set; }

        [StringLength(50)]
        public string HF_AG_Mesafe { get; set; }

        [StringLength(50)]
        public string HF_YG_Mesafe { get; set; }

        public virtual ProjeGenel ProjeGenel { get; set; }
    }
}
