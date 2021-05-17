using System;
using ChapeauModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChapeauUI
{
    public partial class TableOverview : Form
    {
        private Employee employee;

        public TableOverview(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            lblEmployeeInfo.Text = "this should be employee nr and name iguess";
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            //get order table 1
            //new orderservice 
            //Order order = orderservice.GetOrderByTablenr

            //foreach Orderitem item in order.ordereditems
            //listviewitem li = new listviewitem(item.Name);
            //li.SubItems.Add(item.Quantity.ToString());

            

        }
    }
}
