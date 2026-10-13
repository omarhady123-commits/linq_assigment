using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_assigment
{
    public class Customer { 
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public DateTime RegisteredAt { get; set; }
        public List<Order> Orders { get; set; } = new();
        public List<Review> Reviews { get; set; } = new();
    }
}
