namespace OdafHesapProgrami.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cekirdek")]
    public partial class Cekirdek
    {
        public int CekirdekID { get; set; }

        public int? ProjeID { get; set; }

        [StringLength(50)]
        public string DS { get; set; }

        [StringLength(50)]
        public string QS { get; set; }

        [StringLength(50)]
        public string B1 { get; set; }

        [Required]
        [StringLength(50)]
        public string B2 { get; set; }

        [StringLength(50)]
        public string CekirdekTipi { get; set; }

        [StringLength(50)]
        public string Dcek { get; set; }

        [StringLength(50)]
        public string CekirdekAgirligi { get; set; }

        [StringLength(50)]
        public string GurultuDusurucuOnlem { get; set; }

        public virtual ProjeGenel ProjeGenel { get; set; }
    }
}
