namespace IocAutofac.Models.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Loan")]
    public partial class Loan
    {
        [Column(TypeName = "numeric")]
        public decimal Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Borrower { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Accession { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOut { get; set; }

        public bool? DueBack { get; set; }

        public bool? Returned { get; set; }

        public virtual Accession Accession1 { get; set; }

        public virtual Borrower Borrower1 { get; set; }
    }
}
