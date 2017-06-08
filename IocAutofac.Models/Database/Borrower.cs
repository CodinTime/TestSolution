namespace IocAutofac.Models.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Borrower")]
    public partial class Borrower
    {
        [Column(TypeName = "numeric")]
        public decimal Id { get; set; }

        [StringLength(20)]
        public string Forename { get; set; }

        [StringLength(20)]
        public string Surname { get; set; }
    }
}
