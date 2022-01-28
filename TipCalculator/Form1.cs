﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            var billAmount = Convert.ToDecimal(txtBillAmount.Text);

            var tipPercent = 0.2m;

            var tipAmount = billAmount * tipPercent;
            txtTipAmount.Text = tipAmount.ToString("c");

            var totalBill = billAmount + tipAmount;
            txtTotalBill.Text = totalBill.ToString("c");


        }
    }
}
