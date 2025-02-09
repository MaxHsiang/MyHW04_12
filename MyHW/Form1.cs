﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.productPhotoBindingNavigator.BindingSource = this.photoTableBindingSource;
        }

        private void photoTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photoTableBindingSource.EndEdit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'northwindDataSet.PhotoNW' 資料表。您可以視需要進行移動或移除。
            this.photoNWTableAdapter.Fill(this.northwindDataSet.PhotoNW);
            // TODO: 這行程式碼會將資料載入 'databasePhotoDataSet.PhotoTable' 資料表。您可以視需要進行移動或移除。

        }

        private void btn新增照片_Click(object sender, EventArgs e)
        {
 
            DialogResult result = this.openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("OK " + this.openFileDialog1.FileName);

                this.photoPictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Cancel");
            }
        }



        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photoTableBindingSource.EndEdit();
        }
    }
    
}
