namespace Warehouse.Dtos
{

    public record UpdateItemDto
    {
        public string Name { get; init; }
        public int Quantity { get; init; }
        public string Image { get; init; }
    }

}