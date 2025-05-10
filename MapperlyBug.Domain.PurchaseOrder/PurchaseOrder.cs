﻿namespace MapperlyBug.Domain.PurchaseOrder
{
    using System;
    using System.Collections.Generic;

    public class PurchaseOrder
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public IEnumerable<PurchaseOrderDetail> OrderDetails { get; set; }
    }
}
