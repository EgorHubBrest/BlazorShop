using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop_Models.AnyPage_Models
{
    public class Demo_Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public float Price { get; set; }

        public List<Demo_ProductProp>? MyProp { get; set; }
    }
}
