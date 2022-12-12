using System;
using System.Collections.Generic;

namespace Market.Models
{
    public partial class TransactStatus
    {
        public int TransactStatusId { get; set; }
        public string? Status { get; set; }
        public string? Description { get; set; }
    }
}
