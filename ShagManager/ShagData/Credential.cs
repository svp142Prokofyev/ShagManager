using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagData
{
    public class Credential
    {
        [Key]
        public int id { get; set; }
        [Required, MaxLength(50)]
        public string Login { get; set; }
        [Required, MaxLength(50)]
        public string Password { get; set; }
        [Required]
        public virtual AccessOption AccessList { set; get; }
    }
}
