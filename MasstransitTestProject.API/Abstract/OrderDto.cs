﻿namespace MasstransitTestProject.API.Abstract
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
