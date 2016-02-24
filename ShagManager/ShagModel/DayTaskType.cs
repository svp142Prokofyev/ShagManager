using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagModel
{
    public class DayTaskType
    {
        //создается задача
        //заполняются данные
        //закрывается задача
        //после закрытия, автоматически создается задача следующего типа
        [Key]
        public int Id { get; set; }
        //знакомство
        //регистрация
        //оформление договора, если несовершеннолетний, то указать родителей
        [MaxLength(256)]
        public string Name { get; set; }

    }
}
