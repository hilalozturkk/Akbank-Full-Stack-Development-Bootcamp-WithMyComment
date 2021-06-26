using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleResponsibilityPrinciple
{ 
    public partial class Form1 : Form
    {
        public Form1()// get data ,  show data 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            //task -> show result

            string productName = textBoxName.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);

            ProductBusiness productBusiness = new ProductBusiness();
            int result =  productBusiness.AddProduct(productName,price);
            string message = result > 0 ? "Success" : "Failed";
            MessageBox.Show(message);

        }

    }
}
