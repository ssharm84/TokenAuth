﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TokenAuthantication.Models
{
    public partial class TblBook
    {
        public int BookId { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public int? PublishedYear { get; set; }
        public decimal? Price { get; set; }
    }
}
