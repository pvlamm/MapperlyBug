﻿namespace MapperlyBug.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Invoice
{
    public int Id { get; set; }
    public string Title { get; set; }

    public IEnumerable<InvoiceDetail> InvoiceDetails { get; set; }
}
