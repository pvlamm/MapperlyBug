namespace MapperlyBug.Application.Models;
using System.Collections.Generic;

public class InvoiceDto
{
    public int Id { get; set; }
    public string Title { get; set; }

    public IEnumerable<InvoiceDetailDto> InvoiceDetails { get; set; }
}
