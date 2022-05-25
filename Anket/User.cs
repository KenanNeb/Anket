using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string DateOfBirth { get; set; }
        public bool Male { get; set; }
        public bool Female { get; set; }

        public override string ToString() => $@"
           Name       : {Name}
           Surname    :{Surname}
           Patronymic :{Patronymic}
           Country    :{Country}
           City       :{City}
           Phone number : {PhoneNumber}
           Date of bitrh : {DateOfBirth}
           Male       : {Male}
           Female     :{Female}";
    }
}
