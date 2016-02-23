using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagData
{
    public class DayTaskType
    {
        [Key]
        public int Id { get; set; }
        //знакомство
        //регистрация
        //оформление договора, если несовершеннолетний, то указать родителей
        [MaxLength(256)]
        public string Name { get; set; }       

    }
}
