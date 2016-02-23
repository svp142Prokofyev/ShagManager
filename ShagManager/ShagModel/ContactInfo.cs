using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagModel
{
    //комплексный тип
    [ComplexType]
    public class ContactInfo
    {
        //КОНТАКТЫ
        [MaxLength(12)]
        public string Phone1 { get; set; }
        [MaxLength(12)]
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsResident { get; set; }
        public string Country { get; set; }
    }
}
