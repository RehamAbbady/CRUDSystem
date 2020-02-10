using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace CRUDSystem.Models
{
    class Detail
    {

        [Key]
        public int ID { set; get; }
        public string Fname { set; get; }
        public string Lname { set; get; }
        public int Age { set; get; }
        public string Adress { set; get; }
        public DateTime DOB { set; get; }

    }
}
