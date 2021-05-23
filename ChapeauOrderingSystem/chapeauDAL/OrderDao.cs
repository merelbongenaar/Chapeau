using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ChapeauModel;

namespace ChapeauDAL
{
    class OrderDao : BaseDao
    {
        public Order GetOrderByTableNr(int tableNr)
        {
            string query = "select OrderItem.orderID, employeeID, tableID, startTime, endTime, isPaid, Items.itemID, [count], [state], orderTime, comment, itemName, stock, price, itemType, itemSubType FROM[Order] JOIN OrderItem ON[Order].orderID = OrderItem.orderID JOIN Items ON[Items].itemID = OrderItem.itemID WHERE tableID = 1";
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order();
                OrderItem orderItem = new OrderItem();
                Item item = new Item();

                item.ItemID = (int)(dr["itemID"]);
                item.ItemName = (string)(dr["itemName"]);
                item.Stock = (int)(dr["stock"]);
                item.Price = (double)(dr["price"]);
                item.Category = (Category)(dr["itemType"]);
                item.SubCategory = (SubCategory)(dr["itemSubType"]);


                orderItem.OrderID = (int)(dr["orderID"]);
                orderItem.Quantity = (int)(dr["count"]);
                orderItem.Comment = (string)(dr["comment"]);
                orderItem.OrderTime = (DateTime)(dr["orderTime"]);
                orderItem.State = (State)(dr["state"]);
                orderItem.Item = item;


                order.OrderNr = (int)(dr["orderID"]);
                order.EmployeeID = (int)(dr["employeeID"]);
                order.TableID = (int)(dr["tableID"]);
                order.StartTime = (DateTime)(dr["startTime"]);
                order.EndTime = (DateTime)(dr["endTime"]);
                order.orderedItems.Add(orderItem);

                orders.Add(order);
            }

            return orders;
        }
    }
}
