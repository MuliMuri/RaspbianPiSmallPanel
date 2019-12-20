using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteFileTransfer
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            UpdateTime.Start();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UpdateTime_Tick(object sender, EventArgs e)
        {
            string Time = DateTime.Now.ToLongTimeString().ToString();
            TimeLable.Text = Time;
        }
    }
}
