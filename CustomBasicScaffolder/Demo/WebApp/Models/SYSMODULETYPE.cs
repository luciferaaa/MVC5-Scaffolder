namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSMODULETYPE")]
    public partial class SYSMODULETYPE
    {
        [Key]
        public decimal MODULETYPEID { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }
    }
}