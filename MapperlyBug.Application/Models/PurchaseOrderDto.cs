namespace MapperlyBug.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MapperlyBug.Domain.PurchaseOrder;

public class PurchaseOrderDto
{
    public int Id { get; set; }
    public string Title { get; set; }

    public IEnumerable<PurchaseOrderDetailDto> OrderDetails { get; set; }
}
