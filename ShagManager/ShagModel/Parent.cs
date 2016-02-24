using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagModel
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
        //юридическое лицо, физическое лицо
        public bool isIndividual { get; set; }
    }
}
