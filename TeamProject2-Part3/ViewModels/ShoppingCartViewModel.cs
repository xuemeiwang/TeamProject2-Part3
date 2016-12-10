using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeamProject2_Part3.Models;

namespace TeamProject2_Part3.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}