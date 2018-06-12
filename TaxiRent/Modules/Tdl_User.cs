using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiRent.Modules;

namespace TaxiRent.Modules
{
    public enum Gender { m = 0, f}
    public class Tdl_User
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public int Department { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirsday { get; set; }
        public Gender Gender { get; set; }

        public List<Tdl_Roles> Roles { get; set; }
    }
}
