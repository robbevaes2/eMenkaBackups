using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.Domain.Enums;

namespace eMenka.API.Models.SupplierModels
{
    public class SupplierModel : IModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SupplierType[] Types { get; set; }
        public bool Active { get; set; }
        public bool Internal { get; set; }
    }
}
