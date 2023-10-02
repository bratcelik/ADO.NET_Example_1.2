using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            try
            {
                string nonListSql = "SELECT COUNT(*) FROM Production.Product WHERE ListPrice = 0";
                string listSql = "SELECT COUNT(*) FROM Production.Product WHERE ListPrice > 0";

                lblListeDisiUrunToplam.Text = ProductDAL.GetProductCountProcess(nonListSql).ToString();
                lblListeUrunToplam.Text = ProductDAL.GetProductCountProcess(listSql).ToString();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
