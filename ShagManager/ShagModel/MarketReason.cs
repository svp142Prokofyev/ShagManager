using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagModel
{
    public class MarketReason
    {
        [Key]
        public int Id { get; set; }
        //автобусная реклама
        //от друзей
        //интернет и так далее
        public string Name { get; set; }
    }
}
