using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrudApp.Data
{
    public class EmployeeInfo
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public string Gender { get; set; }
        [Required]

        public string Department { get; set; }
        [Required]
        public string City { get; set; }



    }
}
