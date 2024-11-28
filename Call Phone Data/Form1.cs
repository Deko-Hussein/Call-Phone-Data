using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Call_Phone_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void getPhonedata(CellPhone cell)
        {
            decimal price;
            cell.brand = textBox1.Text;
            cell.model = textBox2.Text;

            if (decimal.TryParse(textBox3.Text, out price))
            {
                cell.price = price;
            }
            else
            {
                MessageBox.Show("Invalid Price");
            }
        }

        private void CreatObj_Click(object sender, EventArgs e)
        {
            CellPhone myphone = new CellPhone();
            getPhonedata(myphone);
            brandl.Text = myphone.brand;
            modelLbl.Text = myphone.model;
            pricelbl.Text = myphone.price.ToString();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

    class CellPhone
    {
        //Fields
        private string _brand;  // the phone's brand
        private string _model;  // The phone's model
        private decimal _price; // Retail price

        // Constructor
        public CellPhone()
        {
            _brand = "";
            _model = "";
            _price = 0m;  // Initialize with decimal value
        }

        public string brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string model
        {
            get { return _model; }
            set { _model = value; }
        }

        public decimal price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
