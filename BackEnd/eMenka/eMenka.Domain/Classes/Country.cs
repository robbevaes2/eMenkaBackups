using System;
using System.Collections.Generic;
using System.Text;

namespace eMenka.Domain.Classes
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Nationality { get; set; }
        public bool POD { get; set; }
        public bool IsActive { get; set; }

    }
}
