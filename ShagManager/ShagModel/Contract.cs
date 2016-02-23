using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagModel
{
    public class Contract
    {
        [Key]
        public int Id { get; set; }
        //номер приказа
        public string ContractDetail { get; set; }
        public virtual Student Student { get; set; }
        public virtual Specialisation Specialisation { get; set; }
        public virtual StudyForm StudyForm { get; set; }
        public virtual ContractStatus Status { get; set; }
        //дата начала контракта
        public DateTime DataStart { get; set; }
        //дата окончания контракта
        public DateTime DataExpired { get; set; }
        public virtual Manager Manager { get; set; }
    }
}
