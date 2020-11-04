using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace WF
{
    public partial class Basket : Form
    {
        private readonly ICustomer _customer;
        public Basket(ICustomer customer)
        {
            _customer = customer;
            InitializeComponent();

        }
        private void Basket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet.Basket' table. You can move, or remove it, as needed.
            this.basketTableAdapter.Fill(this.projectDataSet.Basket);
        }

        private void buy_Click(object sender, EventArgs e)
        {
            _customer.UpdateStatus(Global.ID, 1);
        }
        private void shipment_Click(object sender, EventArgs e)
        {
            _customer.UpdateStatus(Global.ID, 2);
        }
        private void add_Click(object sender, EventArgs e)
        {
            _customer.AddBook(textBox1.Text, Global.ID);
        }
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.basketTableAdapter.FillBy(this.projectDataSet.Basket);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.basketTableAdapter.FillBy(this.projectDataSet.Basket);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
