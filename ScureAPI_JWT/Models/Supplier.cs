using System.ComponentModel.DataAnnotations;

namespace ScureAPI_JWT.Models
{
    public class Supplier
    {
        [Required]
        public Guid Id { get; set; }

        [Required,MaxLength(50)]
        public string SupplierName { get; set; }
        [Required,MaxLength(200)]
        public string SupplierAddress { get; set; }

    }
}
