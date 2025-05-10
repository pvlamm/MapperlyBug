using System;
using System.Collections;
using System.Collections.Generic;

namespace MapperlyBug.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
