using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JMoviesApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSuscribedToNewsLetter { get; set; }
        public MembershipType MembershipTypes { get; set; }

        public byte MembershipTypeId { get; set; }
    }
}
