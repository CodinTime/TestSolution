namespace IocAutofac.Models.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Accession")]
    public partial class Accession
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accession()
        {
            Loan = new HashSet<Loan>();
        }

        [Key]
        [Column("Accession")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Accession1 { get; set; }

        public int? ISBN { get; set; }

        public virtual Book Book { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loan> Loan { get; set; }
    }
}
