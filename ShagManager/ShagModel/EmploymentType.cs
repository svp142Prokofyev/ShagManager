using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagModel
{
    //тип занятости
    public class EmploymentType
    {
        [Key]
        public int Id { get; set; }
        //работа
        //учеба
        public string Name { get; set; }
    }
}
