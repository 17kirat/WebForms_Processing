using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MyToDoList.Models
{
    public class RegisterDetails
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Address { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime? DoB { get; set; }      
        
        
    }
}
