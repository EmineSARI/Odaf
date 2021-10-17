namespace OdafHesapProgrami.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AkimGerilim")]
    public partial class AkimGerilim
    {
        public int AkimGerilimID { get; set; }

        public int? ProjeID { get; set; }

        [StringLength(20)]
        public string SargıPozisyonNumarasi { get; set; }

        [StringLength(20)]
        public string SargiNominalKademe { get; set; }

        [StringLength(20)]
        public string SargiTeorikGerilimDegeri { get; set; }

        [StringLength(20)]
        public string SargiGuc { get; set; }

        [StringLength(20)]
        public string KademeDegisitiriciOnSecici { get; set; }

        [StringLength(20)]
        public string FazIsimlendirmesi { get; set; }

        [StringLength(20)]
        public string KademeSarimSayisi { get; set; }

        [StringLength(20)]
        public string KademeDegistiriciTanimi { get; set; }

        [StringLength(20)]
        public string KademeDegistiricKumandaUnitesi { get; set; }

        public virtual ProjeGenel ProjeGenel { get; set; }
    }
}
