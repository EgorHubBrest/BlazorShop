using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop_DataAccess
{
    public class ProductPrice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PriceId { get; set; }
        [ForeignKey("PriceId")]
        public Product Product { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
    }
}
