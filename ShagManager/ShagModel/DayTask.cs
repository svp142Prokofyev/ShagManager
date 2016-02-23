using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagModel
{

    public class DayTask
    {
        [Key]
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        //тип примечание
        [Required, Column("Detail", TypeName = "ntext")]
        public string Detail { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime DateFinish { get; set; }
        public virtual DayTaskStatus Status { get; set; }
    }
}
