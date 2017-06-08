namespace IocAutofac.Models.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            Accession = new HashSet<Accession>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal ISBN { get; set; }

        [StringLength(20)]
        public string Title { get; set; }

        [StringLength(30)]
        public string Author { get; set; }

        [StringLength(30)]
        public string Publisher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accession> Accession { get; set; }
    }
}
