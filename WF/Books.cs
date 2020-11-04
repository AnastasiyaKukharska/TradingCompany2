using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using System.Windows.Forms;

namespace WF
{
    public partial class Books : Form
    {
        protected readonly IAuthManager _manager;
        private readonly ICustomer _customer;
        public Books( IAuthManager manager,ICustomer customer)
        {
            InitializeComponent();
            _manager = manager;
             _customer= customer;
            Global.CID = _manager.CD(category.Text);
            Global.BID = _manager.BD(find.Text);
        }

        private void Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.projectDataSet.Books);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.booksTableAdapter.FillBy1(this.projectDataSet.Books);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void ok_Click(object sender, EventArgs e)
        {
            _customer.FindBook(find.Text, category.Text);
        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.booksTableAdapter.FillBy2(this.projectDataSet.Books);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
