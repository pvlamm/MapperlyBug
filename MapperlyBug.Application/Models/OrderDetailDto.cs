namespace MapperlyBug.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OrderDetailDto
{
    public int Id { get; set; }
    public int ParentId { get; set; }
    public string Title { get; set; }
    public int Amount { get; set; }
}
