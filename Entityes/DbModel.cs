using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityes
{
    public class DbModel
    {
        [Key]
        public int emp_Id { get; set; }
        public string emp_Name { get; set; }
        public int emp_Age { get; set; }
        public string emp_Dept { get; set; }
        public int? salary { get; set; }
    }

    public class PostDbModel
    {
        [Key]
        public string emp_Name { get; set; }    
        public int emp_Age { get; set; }
        public string emp_Dept { get; set; }
        public int salary { get; set; }
    }
}
