﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkademikApp
{
    public partial class FrmEntryMahasiswa : Form
    {
        public delegate void CreateUpdateEventHandler(Mahasiswa mhs);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private bool isNewData = true;
        private Mahasiswa mhs;

        public FrmEntryMahasiswa()
        {
            InitializeComponent();
        }
        


        public FrmEntryMahasiswa(string title) : this()
        {
            this.Text = title;
        }
        public FrmEntryMahasiswa(string title, Mahasiswa obj): this()
        {
            this.Text = title;
            isNewData = false; 
            mhs = obj; 
            txtNpm.Text = mhs.Npm;
            txtNama.Text = mhs.Nama;
            txtAngkatan.Text = mhs.Angkatan;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isNewData) mhs = new Mahasiswa();
            mhs.Npm = txtNpm.Text;
            mhs.Nama = txtNama.Text;
            mhs.Angkatan = txtAngkatan.Text;
            if (isNewData) 
            {
                OnCreate(mhs); 
                txtNpm.Clear();
                txtNama.Clear();
                txtAngkatan.Clear();
                txtNpm.Focus();
            }
            else
            {
                OnUpdate(mhs); 
                this.Close();
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
