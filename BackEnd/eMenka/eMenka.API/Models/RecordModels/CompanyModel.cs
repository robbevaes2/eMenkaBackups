using System.ComponentModel.DataAnnotations;

namespace eMenka.API.Models.RecordModels
{
    public class CompanyModel : IModelBase
    {
        [Required] public string Name { get; set; }

        public string Description { get; set; }
        public string Reference { get; set; }
        public bool? IsInternal { get; set; }
        public bool? IsActive { get; set; }
        public string NonActiveRemark { get; set; }
        public string VAT { get; set; }
        public string AccountNumber { get; set; }
        public int Id { get; set; }
    }
}