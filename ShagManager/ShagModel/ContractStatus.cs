using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagModel
{
    public class ContractStatus
    {
        [Key]
        public int Id { get; set; }
        //статус заморожен 
        //активен
        //закончен
        public string Name { get; set; }
        //если заморожен, указать причину: академический, не оплачен
        public string Reason { get; set; }
    }
}
