using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonOfCodSeafood.Models
{
    [Table("Newsletters")]
    public class Newsletter
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Reason { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
