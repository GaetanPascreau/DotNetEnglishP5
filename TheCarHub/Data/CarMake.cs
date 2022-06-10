﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCarHub.Data
{
    public class CarMake
    {

        [Key]
        public int Id { get; set; }
        public string MakeName { get; set; }
        public List<Car> Cars { get; set; }
        public List<CarModel> CarModels { get; set; }
    }
}
