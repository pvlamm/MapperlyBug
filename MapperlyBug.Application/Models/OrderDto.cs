namespace MapperlyBug.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OrderDto
{
    public int Id { get; set; }
    public string Title { get; set; }

    public IEnumerable<OrderDetailDto> OrderDetails { get; set; }
}
