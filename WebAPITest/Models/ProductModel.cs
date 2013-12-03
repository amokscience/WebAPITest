using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPITest.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public ProductModel()
        {
        }

        public ProductModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}