using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagData
{
    //учебное заведение или компания
    public class Place
    {
        public int Id { get; set; }
        public string PlaceName { get; set; }
        public string Address { get; set; } 
        public ContactInfo Info {get;set;}
        public virtual EmploymentType Type { get; set; }
    }
}
