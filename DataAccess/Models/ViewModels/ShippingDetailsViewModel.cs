﻿using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.ViewModels
{
    public class ShippingDetailsViewModel
    {
        public List<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();
    }
}
