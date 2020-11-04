using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace WF
{
    public partial class Menu : Form
    {
        public static UnityContainer Container2;
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Run(Container2.Resolve<Books>());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Run(Container2.Resolve<Basket>());
        }
    }
}
