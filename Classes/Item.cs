﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savichev19pr.Classes
{
    public class Item
    {
        public string name { get; set; }
        public int price { get; set; } 
        public string src { get; set; }
        public Item(string name, int price, string src)
        {
            this.name = name;
            this.price = price;
            this.src = src;
        }
    }
}
