using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMenka.API.Models.SupplierModels.ReturnModels
{
    public class SupplierReturnModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string[] Types { get; set; }
        public bool Active { get; set; }
        public bool Internal { get; set; }
    }
}
