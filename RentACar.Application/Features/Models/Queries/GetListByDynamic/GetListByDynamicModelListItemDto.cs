namespace RentACar.Application.Features.Models.Queries.GetListByDynamic;
public class GetListByDynamicModelListItemDto
{
    public Guid Id { get; set; }
    public string BrandName { get; set; } = default!;
    public string FuelName { get; set; } = default!;
    public string TransmissionName { get; set; } = default!;
    public string Name { get; set; } = default!;
    public decimal DailyPrice { get; set; }
    public string ImageUrl { get; set; } = default!;
}