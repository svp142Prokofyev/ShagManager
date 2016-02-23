using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShagData
{
   public class StudyForm
    {
       [Key]
       public int Id { get; set; }
       //Утренний стационар или утренний полустационар
       //Вечерний стационар или вечерний полустационар
       [Required, MaxLength(256)]
       public string Name { get; set; }
    }
}
