using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Address { get; set; }
        [StringLength(250)]
        public string City { get; set; }
        [StringLength(250)]
        public string Email { get; set; }
        [StringLength(250)]
        public string Phone { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
