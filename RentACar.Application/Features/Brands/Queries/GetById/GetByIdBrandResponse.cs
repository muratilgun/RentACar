
namespace RentACar.Application.Features.Brands.Queries.GetById;
public class GetByIdBrandResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt  { get; set; }
}
