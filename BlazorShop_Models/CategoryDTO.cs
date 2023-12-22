using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop_Models
{
    public class CategoryDTO
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Please enter correct Name")]
        public string Name { get; set; }
    }
}
