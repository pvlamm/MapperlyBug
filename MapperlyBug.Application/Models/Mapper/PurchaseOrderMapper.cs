namespace MapperlyBug.Application.Models.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MapperlyBug.Domain;
using MapperlyBug.Domain.PurchaseOrder;

using Riok.Mapperly.Abstractions;

[Mapper]
public static partial class PurchaseOrderMapper
{
    public static partial PurchaseOrderDto ToPurchaseOrderDto(this PurchaseOrder purchaseOrder);

    [UserMapping]
    public static IEnumerable<PurchaseOrderDetailDto> ToOrderDetailDto(this IEnumerable<PurchaseOrderDetail> purchaseOrderDetail)
    {
        return purchaseOrderDetail.Select(x => new PurchaseOrderDetailDto
        {
            Id = x.Id,
            Title = x.Title,
            Amount = x.Amount
        });
    }
}
