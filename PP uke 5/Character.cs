﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_uke_5
{
    internal class Character
    {
       public string Name { get; set; }
       public string House { get; set; }

       public List<String> Inventory { get; set; } 

        //public string wand { get; set; }
        //public string pet { get; set; }

        public Character (string name, string house)
        {
            Name = name;
            House = house;

            Inventory = new List<String>();
      
        }
    }
}
