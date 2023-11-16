using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Delegate_dan_Event
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form2_OnCreate(Number nmbr)
        {
            
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            Form2 frmEntry = new Form2("Calculator");
            frmEntry.OnCreate += Form2_OnCreate;
            frmEntry.ShowDialog();
        }
    }
}
