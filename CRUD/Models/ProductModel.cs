using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public enum ProductStatus
    {
        Available,
        OutOfStock,
        Pending
    }

    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30,MinimumLength =3)]
        public string Name { get; set; }=string.Empty;

        [Required]
        [StringLength(300,MinimumLength =5)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [StringLength(25,MinimumLength =3)]
        public string Type { get; set; }=string.Empty;

        [Required]
        public ProductStatus Status { get; set; } = ProductStatus.Available;

        [Required]
        public decimal Price { get; set; }

    }
}
