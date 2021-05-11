using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    //Class OrderItem can contain a MenuItem instead of (int) MenuItemId
    public enum MenuItem
    { }

    public enum Catogory
    { Lunch, Dinner, Drinks }

    public class OrderItem
    {
        public int ItemID { get; set; }

        public string Name { get; set; }
        public int OrderID { get; set; }

        public int Quantity { get; set; }
    }
}
