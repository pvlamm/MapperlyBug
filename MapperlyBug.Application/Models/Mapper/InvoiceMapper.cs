namespace MapperlyBug.Application.Models.Mapper;

using MapperlyBug.Application.Entities;

using Riok.Mapperly.Abstractions;

[Mapper]
public static partial class InvoiceMapper
{
    public static partial InvoiceDto ToInvoiceDto(this Invoice invoice);

    [UserMapping]
    public static IEnumerable<InvoiceDetailDto> ToInvoiceDetailDto(this IEnumerable<InvoiceDetail> invoiceDetails)
    {
        return invoiceDetails.Select(x => new InvoiceDetailDto
        {
            Id = x.Id,
            Title = x.Title,
            Amount = x.Amount
        });
    }
}
