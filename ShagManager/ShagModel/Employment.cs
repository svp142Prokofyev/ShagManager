using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagModel
{
    //занятость
    public partial class Employment
    {
        [Key]
        public int id { get; set; }
        public virtual Place Place { set; get; }
        //если тип занятости учеба, то список place должен фильтроваться,
        //и указывать лишь список доступных
        public virtual EmploymentType EmploymentType { set; get; }
        public virtual Student Student { get; set; }
    }
}
