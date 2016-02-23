using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagData
{
    public class Manager
    {
        public Manager()
        {
            Contracts = new HashSet<Contract>();
        }
        [Key]
        public int Id { get; set; }        
        public Person Person { get; set; }
        public virtual Credential Credential { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
