using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagData
{
    //специальность
    public class Specialisation
    {
        public int Id { get; set; }
        //разработка программного обеспечения и тому подобное....
        public string Name { get; set; }
        //профессиональная или малая акедемия/летний лагерь
        public string AcademyType { get; set; }
        //срок обучения
        //можно изменить на года или месяцы
        public int Weeks { get; set; }
    }
}
