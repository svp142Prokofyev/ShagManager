using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagData
{
    public class Parent
    {
        public Parent()
        {
            Students = new HashSet<Student>();
        }
        [Key]
        public int Id { get; set; }       
        public Person Person { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
