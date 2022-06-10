﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheCarHub.Data
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("FK_CarMake")]
        public int? CarMakeId { get; set; }
        public string VIN { get; set; }
        public int Year { get; set; }
        public string Trim { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double PurchasePrice { get; set; }
        public string Repairs { get; set; }
        public double RepairCost { get; set; }
        public DateTime LotDate { get; set; }
        public double SellingPrice { get; set; }
        public DateTime SaleDate { get; set; }
        public string Description { get; set; }
        public int Milleage { get; set; }
        public string Color { get; set; }
    }
}
