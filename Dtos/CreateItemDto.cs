using System.ComponentModel.DataAnnotations;

namespace Warehouse.Dtos
{

    public record CreateItemDto
    {
        [Required]
        public string Name { get; init; }
        [Required]
        [Range(1, 1000)]
        public int Quantity { get; init; }
        [Required]
        public string Type { get; init; }
        [Required]
        public string Image { get; init; }
    }

}