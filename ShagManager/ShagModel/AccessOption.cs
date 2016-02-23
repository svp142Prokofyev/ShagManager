using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagModel
{
    public class AccessOption
    {
        [Key]
        public int id { get; set; }
        //менеджер
        //суперменеджер
        [Required]
        public string AccessName { get; set; }
    }
}
