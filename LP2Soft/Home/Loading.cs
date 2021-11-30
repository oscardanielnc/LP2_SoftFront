using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Home
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            /*imgLoading.Load("Spinner-1s-200px.gif");*/
            imgLoading.Location = new Point(this.Width / 2 - imgLoading.Width / 2, this.Height / 2 - imgLoading.Height / 2);
        }
        public void run()
        {
            imgLoading.Load("Spinner-1s-200px.gif");
        }
    }
}
