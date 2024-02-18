using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class Inventory : Form

    {
        DataTable inventory = new DataTable();
        public Inventory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            skutextBox4.Text = "";
            nametextBox.Text = "";
            priceBox.Text = "";
            descriptionBox.Text = "";
            QuantityBox.Text = "";
            catagorycomboBox.SelectedIndex = -1;
                
        }

        private void inventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inventoryGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                skutextBox4.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
                nametextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
                priceBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[3].ToString();
                descriptionBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[4].ToString();
                QuantityBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[5].ToString();

                string itemToLookFor = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
                catagorycomboBox.SelectedIndex = catagorycomboBox.Items.IndexOf(itemToLookFor);
            }
            catch (Exception err)
            {
                Console.WriteLine("There has been an error:" + err);
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("sku");
            inventory.Columns.Add("name");
            inventory.Columns.Add("catagory");
            inventory.Columns.Add("price");
            inventory.Columns.Add("description");
            inventory.Columns.Add("Quantity");

            inventoryGridView.DataSource = inventory;
        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            string sku = skutextBox4.Text;
            string name =nametextBox.Text;
            string price = priceBox.Text;   
            string description = descriptionBox.Text;
            string Quantity = QuantityBox.Text;
            string catagory = (string)catagorycomboBox.SelectedItem ;

            inventory.Rows.Add(sku, name, catagory, price, description, Quantity);
            button1_Click(sender, e);




        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.Rows[inventoryGridView.CurrentCell.RowIndex].Delete(); 
            }
            catch(Exception err)
            {
                Console.WriteLine("error:" + err);
            }

        }
    }
}
