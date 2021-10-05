using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Entities
{
   
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [StringLength(10)]
        public string State { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }

        public string Name { get; set; }
        public int Order { get; set; }
    }
}
