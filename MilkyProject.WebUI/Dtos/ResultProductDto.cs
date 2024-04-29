﻿namespace MilkyProject.WebUI.Dtos
{
    public class ResultProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal OlduPrice { get; set; }
        public decimal NewPrice { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
