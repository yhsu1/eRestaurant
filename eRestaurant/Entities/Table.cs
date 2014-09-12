﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class Table
    {
        // By convention, if we use a property with the same name at the class, but
        // with a suffix of ID, then Entity Framework will recognize that property
        // as mapping to the database table's Primary key column.
        public int TableID { get; set; }
        public byte TableNumber { get; set; }
        public bool Smoking { get; set; }
        public int Capacity { get; set; }
        public bool Available { get; set; }
    }
}
