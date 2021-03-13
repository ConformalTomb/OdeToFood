using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Core
{
    public class Restaurant
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Location { get; set; }
        public CusineType Cusine { get; set; }
    }

}
