﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BeerMVC5.Models
{
    public class Stock
    {
        [Key]
        public int StockID { get; set; }

        [ForeignKey("Beer")]
        public int BeerID { get; set; }

        public Beer Beers { get; set; }

        [ForeignKey("Shop")]
        public int ShopID { get; set; }
        [Required(ErrorMessage = "Invalid Shop Name")]
        public Shop Shop { get; set; }
        [Required(ErrorMessage = "Wrong quantity")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Price is incorrect!")]
        public double Price { get; set; }


        public override string ToString()
        {
            return "Stock ID: " + StockID + "Beer ID: " + BeerID + "\nShop ID " + ShopID + "\nQuantity: " + Quantity + "\nPrice: " + Price;
        }
    }
}