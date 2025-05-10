namespace MapperlyBug.Application.Models.Mapper;

using MapperlyBug.Domain;

using Riok.Mapperly.Abstractions;

[Mapper]
public static partial class OrderMapper
{
    public static partial OrderDto ToOrderDto(this Order order);

    [UserMapping]
    public static IEnumerable<OrderDetailDto> ToOrderDetailDto(this IEnumerable<OrderDetail> orderDetails)
    {
        return orderDetails.Select(x => new OrderDetailDto
        {
            Id = x.Id,
            Title = x.Title,
            Amount = x.Amount
        });
    }
}
