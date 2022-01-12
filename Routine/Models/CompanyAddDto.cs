using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Routine.Models
{
    public class CompanyAddDto
    {
        [Display(Name = "公司名")]
        [Required(ErrorMessage = "{0}是必填的")]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(500)]
        [Display(Name = "简介")]
        public string Introduction { get; set; }
        public ICollection<EmployeeAddDto> Employees { get; set; } = new List<EmployeeAddDto>();
    }
}
