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
        public int Id { get; set; }

        public int? Borrower { get; set; }

        public int? Accession { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOut { get; set; }

        public bool? DueBack { get; set; }

        public bool? Returned { get; set; }

        public virtual Accession Accession1 { get; set; }

        public virtual Borrower Borrower1 { get; set; }
    }
}
