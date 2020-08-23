using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiPaises.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public int PeopleId { get; set; }
        public People People { get; set; }
    }
}
