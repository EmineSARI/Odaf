namespace OdafHesapProgrami.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HesapSonuc")]
    public partial class HesapSonuc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SonucID { get; set; }

        public int? ProjeID { get; set; }

        [StringLength(50)]
        public string PozIlk { get; set; }

        [StringLength(50)]
        public string PozOrta { get; set; }

        [StringLength(50)]
        public string PozSon { get; set; }

        [StringLength(50)]
        public string CekirdekAgirligi { get; set; }

        [StringLength(50)]
        public string UW { get; set; }

        public virtual ProjeGenel ProjeGenel { get; set; }
    }
}
