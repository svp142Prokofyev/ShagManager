using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagModel
{
    public class DayTaskStatus
    {
        [Key]
        public int Id { get; set; }
        //открытая, закрытая, просроченная
        public string Name { get; set; }
    }
}
