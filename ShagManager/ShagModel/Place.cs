using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagModel
{
    //учебное заведение или компания
    public class Place
    {
        [Key]
        public int Id { get; set; }
        public string PlaceName { get; set; }
        public string Address { get; set; }
        public ContactInfo Info { get; set; }
        public virtual EmploymentType Type { get; set; }
    }
}
