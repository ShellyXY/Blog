using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ChineseBudFood.Models
{
    public class OrderInformation
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public DateTime MealDate { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }

        public string Time { get; set; }

        public string Number { get; set; }






    }
}