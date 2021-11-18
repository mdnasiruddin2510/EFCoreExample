using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExample.EntityModels
{
   public class Category
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Brand> Brands { get; set; }
    }
}
