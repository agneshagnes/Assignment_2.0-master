using Assignment.Enum;
using Assignment_1.Classes;
using Assignment_2._0.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2._0
{
    public partial class tabCreateChange : Form
    {

        // The image the user will choose for an estate
        private Bitmap image = null;
        private EstateHandler estateHandler;

        public tabCreateChange()

        {
            InitializeComponent();
            estateHandler = new EstateHandler();
            comboBoxCountry.DataSource = Countries.GetValues(typeof(Countries));
            comboBoxLegalForm.DataSource = LegalForms.GetValues(typeof(LegalForms));
            comboBox3.DataSource = Category.GetValues(typeof(Category));
            comboBoxLegalForm.DataSource = LegalForms.GetValues(typeof(LegalForms));
            comboBox5.DataSource = TypeAll.GetValues(typeof(TypeAll));
            lblDynamicTxt1.Text = "---------";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        // change-knappen
        private void button3_Click(object sender, EventArgs e)
        {
            string id = textId.Text;
            LegalForms legalForm = (LegalForms)comboBoxLegalForm.SelectedItem;
            Countries country = (Countries)comboBoxCountry.SelectedItem;
            string city = textBoxCity.Text;
            string zipCode = textBoxZipCode.Text;
            string street = textBoxStreet.Text;
            Category category = (Category)comboBox3.SelectedItem;
            var type = comboBox4.SelectedItem;
            string text = textBox6.Text;
            TypeAll typeAll = (TypeAll)comboBox4.SelectedItem;

            estateHandler.ChangeEstate(id, legalForm, country, city, zipCode, street, category, type, text, image, typeAll);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image = new Bitmap(openFileDialog.FileName);
                pictureBoxImage.Image = image;
            }
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCreateEstate_Click(object sender, EventArgs e)
        {
            string id = textId.Text;
            LegalForms legalForm = (LegalForms) comboBoxLegalForm.SelectedItem;
            Countries country = (Countries)comboBoxCountry.SelectedItem;
            string city = textBoxCity.Text;
            string zipCode = textBoxZipCode.Text;
            string street = textBoxStreet.Text;
            Category category = (Category)comboBox3.SelectedItem;
            var type = comboBox4.SelectedItem;
            string text = textBox6.Text;
            TypeAll typeAll = (TypeAll)comboBox4.SelectedItem;
 
           estateHandler.createEstate(id, legalForm, country, city, zipCode, street, category, type, text, image, richTextBoxEstates, typeAll);
        }

        private void comboBoxLegalForm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox3.SelectedItem.Equals(Category.Residential))
            {
                comboBox4.DataSource = TypeRes.GetValues(typeof(TypeRes));
            }
            else
            {
                comboBox4.DataSource = TypeCom.GetValues(typeof(TypeCom));
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedItem)
            {
                case TypeRes.Villa:
                    lblDynamicTxt1.Text = "Lawn size:";
                break;

                case TypeRes.Apartment:
                    lblDynamicTxt1.Text = "Floor number:";
                break;

                case TypeRes.Townhouse:
                    lblDynamicTxt1.Text = "Height:";
                break;

                case TypeRes.House:
                    lblDynamicTxt1.Text = "Color:";
                break;

                case TypeCom.Shop:
                    lblDynamicTxt1.Text = "Type of Shop:";
                break;

                case TypeCom.Warehouse:
                    lblDynamicTxt1.Text = "Capacity (m3):";
                break;
            }
        }

        private void lblSearchEstates_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TypeAll typeAll = (TypeAll)comboBox5.SelectedItem;
            string city = textBox9.Text;
           


            estateHandler.SearchEstate(typeAll, city);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string text = textBox8.Text;
            estateHandler.DeleteEstate(text);
        }
    }
}
