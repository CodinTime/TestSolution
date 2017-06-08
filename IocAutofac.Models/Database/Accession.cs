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
        [Key]
        [Column("Accession", TypeName = "numeric")]
        public decimal Accession1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ISBN { get; set; }

        public virtual Book Book { get; set; }
    }
}
