namespace MapperlyBug.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OrderDetail
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
    }
}
