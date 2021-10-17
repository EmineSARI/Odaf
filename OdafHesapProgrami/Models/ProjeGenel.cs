namespace OdafHesapProgrami.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProjeGenel")]
    public partial class ProjeGenel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProjeGenel()
        {
            AkimGerilim = new HashSet<AkimGerilim>();
            Cekirdek = new HashSet<Cekirdek>();
            HesapSonuc = new HashSet<HesapSonuc>();
            Mesafe = new HashSet<Mesafe>();
            Sargi1 = new HashSet<Sargi>();
        }

        [Key]
        public int ProjeID { get; set; }

        public int? RootID { get; set; }

        [StringLength(50)]
        public string Task_ID { get; set; }

        [StringLength(50)]
        public string TasarimBelgesiNo { get; set; }

        [StringLength(50)]
        public string TrafoTanimKodu { get; set; }

        [StringLength(50)]
        public string TrafoNo { get; set; }

        [StringLength(50)]
        public string ProjeAdi { get; set; }

        [StringLength(50)]
        public string F { get; set; }

        [StringLength(50)]
        public string SogutmaSekli { get; set; }

        [StringLength(50)]
        public string BaglantiGrubu { get; set; }

        [StringLength(50)]
        public string SargıSayisi { get; set; }

        [StringLength(50)]
        public string ImalatNormu { get; set; }

        [Column("Teta Müh")]
        [StringLength(50)]
        public string Teta_Müh { get; set; }

        [StringLength(50)]
        public string Sargi { get; set; }

        [StringLength(50)]
        public string Yag { get; set; }

        [StringLength(50)]
        public string CalismaYeriYuksekligi { get; set; }

        [StringLength(50)]
        public string MaxKDSuresi { get; set; }

        [StringLength(50)]
        public string SargiGerilimi { get; set; }

        [StringLength(50)]
        public string ToplamBakirAgirligi { get; set; }

        [StringLength(50)]
        public string SargiOlculeri { get; set; }

        public string Aciklama { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AkimGerilim> AkimGerilim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cekirdek> Cekirdek { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HesapSonuc> HesapSonuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mesafe> Mesafe { get; set; }

        public virtual ODAF ODAF { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sargi> Sargi1 { get; set; }
    }
}
