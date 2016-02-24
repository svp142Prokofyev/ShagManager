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
        //открытая, закрытая, просроченная, отменен
        public string Name { get; set; }
        //если статус отменен, обязательно указать причину
        public string Reason { get; set; }
    }
}
