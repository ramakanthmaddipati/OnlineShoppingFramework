using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingMvc.Models
{
    public class Category
    {
        [Required]
        public int Pid { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Picture { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Content { get; set; }

        public string Display()
        {
            string data = "";
            string[] cols = Content.Split(',');
            foreach (var col in cols)
            {
                string cName, cValue;
                string[] cNValue = col.Split(':');
                cName = cNValue[0];
                cValue = cNValue[1];
                data = data + cName + ": " + cValue + "<br/>";
            }
            return data;
        }
    }
}