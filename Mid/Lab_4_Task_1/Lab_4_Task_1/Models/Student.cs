using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_4_Task_1.Models
{
    public class Student
    {
        [Required, RegularExpression(@"^([0-9]{2}-[0-9]{5}-[1-3]{1})+$", ErrorMessage = "ID format is not allowed")]
        public string Id { get; set; }

        [Required, RegularExpression(@"^([a-zA-Z\\s]+)$", ErrorMessage = "Name format is not allowed")]
        public string Name { get; set; }

        [Required]
        public DateTime Dob { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, RegularExpression(@"^((male)|(female)|(other))+$")]
        public string Gender { get; set; }

        [Required, RegularExpression(@"^((cs)|(eee))+$")]
        public string Dept { get; set; }
    }
}