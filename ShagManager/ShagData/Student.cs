using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//using System.Net.Mime.MediaTypeNames;

namespace ShagData
{
    public class Student
    {
        public Student()
        {
            
        }
        [Key]
        public int Id { get; set; }
        public Person Person { get; set; }
        public DateTime RegisterDay { get; set; }
        public System.Net.Mime.MediaTypeNames.Image Photo { get; set; } 
        //уточнить детали связывания контракта со студентом
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<Parent> Parents { get; set; }
    }
}
