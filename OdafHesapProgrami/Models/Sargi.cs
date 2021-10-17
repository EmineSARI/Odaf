namespace OdafHesapProgrami.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sargi")]
    public partial class Sargi
    {
        public int SargiID { get; set; }

        public int? ProjeID { get; set; }

        [StringLength(50)]
        public string Sargi_Adi { get; set; }

        [Required]
        [StringLength(50)]
        public string Sarim_Sayisi { get; set; }

        [StringLength(50)]
        public string Sargi_Tipi { get; set; }

        [StringLength(50)]
        public string Kat_Sayisi { get; set; }

        [StringLength(50)]
        public string Iletken_Cinsi { get; set; }

        [StringLength(50)]
        public string Iletken_Tipi { get; set; }

        [StringLength(50)]
        public string Um { get; set; }

        [Column("BIL-N")]
        [StringLength(50)]
        public string BIL_N { get; set; }

        [Column("AC-N")]
        [StringLength(50)]
        public string AC_N { get; set; }

        [Column("SI-N")]
        [StringLength(50)]
        public string SI_N { get; set; }

        [Column("CW-N")]
        [StringLength(50)]
        public string CW_N { get; set; }

        [StringLength(50)]
        public string Un { get; set; }

        [StringLength(50)]
        public string AyarSahasi { get; set; }

        [Required]
        [StringLength(50)]
        public string In_Nom { get; set; }

        [StringLength(50)]
        public string In_Max { get; set; }

        [StringLength(50)]
        public string Snom { get; set; }

        [StringLength(50)]
        public string Smax { get; set; }

        [StringLength(50)]
        public string Ikd { get; set; }

        public virtual ProjeGenel ProjeGenel { get; set; }
    }
}
