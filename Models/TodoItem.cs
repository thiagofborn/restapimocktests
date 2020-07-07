using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; } //Id will be used as the unique key in a relational DB
        public long Shop_Id { get; set; }
        public long Transaction_Id { get; set; }
        public string Card_Id { get; set; }
        public long Product_Id { get; set; }
        public double Product_Price { get; set; }
    }
}
