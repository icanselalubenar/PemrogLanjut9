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
    public partial class Form2 : Form
    {
        public delegate void CreateUpdateEventHandler(Number nmbr);
        public event CreateUpdateEventHandler OnCreate;
        private bool isNewData = true;
        private Number nmbr;
        string[] items = { "Penjumlahan", "Pengurangan", "Perkalian", "Pembagian" };
            

        public Form2()
        {
            InitializeComponent();
            cmbOperasi.Items.AddRange(items);
        }

        public Form2(string title) : this()
        {
            this.Text = title;
        }
        public Form2(string title, Number obj) : this()
        {
            this.Text = title;
            isNewData = false;
            nmbr = obj;
            cmbOperasi.Text = nmbr.Operasi;
            txtNilaiA.Text = nmbr.NilaiA;
            txtNilaiB.Text = nmbr.NilaiB;

        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (isNewData) nmbr = new Number();
            nmbr.Operasi = cmbOperasi.SelectedItem.ToString();
            nmbr.NilaiA = txtNilaiA.Text;
            nmbr.NilaiB = txtNilaiB.Text;

            if (isNewData)
            {
                OnCreate(nmbr);
                txtNilaiA.Clear();
                txtNilaiB.Clear();
                txtNilaiA.Focus();
            }
        }

        private void cmbOperasi_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
