using Assignment.Enum;
using Assignment_1.AbstractClasses;
using Assignment_2._0.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1.Classes
{
    class EstateHandler
    {

        // To handle all the estates
        private ArrayList estates = new ArrayList();

        // A set to make sure all the ids are unique
        private HashSet<string> ids = new HashSet<string>();

        private RichTextBox richTxtBx;
        private ComboBox comboBoxLegalForm;
        private ComboBox comboBoxCountry;
        private ComboBox comboBocCategory;
        private ComboBox comboBoxType;
        private TextBox textId;
        private TextBox textcity;
        private TextBox textzip;
        private TextBox textStreet;
        private TextBox textUnique;
        private TextBox textchange;
        private PictureBox pictureBoxImage;
        //private String changebtn;



        /// <summary>
        /// Validates that all the information is filled in correctly and then creates an estate object
        /// and puts it into the estates list.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="legalForm"></param>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="zipCode"></param>
        /// <param name="street"></param>
        /// <param name="category"></param>
        /// <param name="type"></param>
        /// <param name="text"></param>
        /// <param name="image"></param>
        public void createEstate(string id, LegalForms legalForm, Countries country, string city, string zipCode, string street, Category category, object type, string text, Bitmap image, RichTextBox richTxtBx, TypeAll typeAll)
        {
            if(!isIdValid(id) || !uniqueId(id) || !hasChosenImage(image) || !allFieldsFilled(city, zipCode, street, text))
            {
                return;
            }

            Address address = new Address(street, zipCode, city, country);
            this.richTxtBx = richTxtBx;

            switch (type)
            {
                case TypeCom.Shop:
                    Shop shop = new Shop(id, text, legalForm, image, address, category, typeAll);
                    estates.Add(shop);
                    ids.Add(id);
                    break;
                case TypeCom.Warehouse:
                    Estate warehouse = new Warehouse(id, text, legalForm, image, address, category, typeAll);
                    estates.Add(warehouse);
                    ids.Add(id);
                    break;
                case TypeRes.Apartment:
                    Estate apartment = new Apartment(id, text, legalForm, image, address, category, typeAll);
                    estates.Add(apartment);
                    ids.Add(id);
                    break;
                case TypeRes.House:
                    Estate house = new House(id, text, legalForm, image, address, category, typeAll);
                    estates.Add(house);
                    ids.Add(id);
                    break;
                case TypeRes.Townhouse:
                    Estate townhouse = new Townhouse(id, text, legalForm, image, address, category, typeAll);
                    estates.Add(townhouse);
                    ids.Add(id);
                    break;
                case TypeRes.Villa:
                    Estate villa = new Villa(id, text, legalForm, image, address, category, typeAll);
                    estates.Add(villa);
                    ids.Add(id);
                    break;
                default:
                    break;
            }

            MessageBox.Show("För debug \n, ids count: " + ids.Count + " estate i ArrayList count: " + estates.Count);

            MessageBox.Show("Estate successfully created, to browse the esates go to the Search/Delete tab");

            updateTxtWindow();

            MessageBox.Show("Richtextbox succesfully updated!");

         // skriv ut i search 
        }


        /// <summary>
        /// Checks if the user has filled in all the fields
        /// </summary>
        /// <param name="city"></param>
        /// <param name="zipCode"></param>
        /// <param name="street"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private bool allFieldsFilled(string city, string zipCode, string street, string text)
        {
            if(city.Equals("") || zipCode.Equals("") ||street.Equals("") || text.Equals(""))
            {
                MessageBox.Show("Please fill in all the fields");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if the user has chosen an image
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private bool hasChosenImage(Bitmap image)
        {
            if(image == null)
            {
                MessageBox.Show("Please choose a picture");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if the given id is unique
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool uniqueId(string id)
        {
            if(ids.Contains(id))
            {
                MessageBox.Show("The Id is already in our register, please choose an unique Id, to se all the Ids browse to the Search/Delete tab");
            }

            return !ids.Contains(id);
        }

        /// <summary>
        /// Validate that the Id follows the preapproved format, four numbers
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool isIdValid(string id)
        {
            int correctIdLenght = 4;
            if(id.Length != correctIdLenght)
            {
                MessageBox.Show("The Id you chose is not a valid Id, it should consist of four numbers, eg 1234");
                return false;
            }

            if (!id.All(char.IsDigit)){
                MessageBox.Show("The id must consist of all numbers!");
                return false;
            }

            return true;
        }


        /// <summary>
        /// Add an estate to the list
        /// </summary>
        /// <param name="estate"></param>
        public void AddEstate(Estate estate)
        {
            ids.Add(estate.Id);
            estates.Add(estate);
        }


        /// <summary>
        /// Deletes the Estate object with the given id, if the Estate is not present, 
        /// return null and print out a message to the user.
        /// </summary>
        /// <param name="id"></param>
        public void DeleteEstate(string id)
        {

            // Check to se if the given id is present in the ids set
            if (!ids.Contains(id))
            {
                MessageBox.Show($"There is no Estate object in the hashSet that has the id {id}");
                return;
            }

            // Removes the estate with the given id
            foreach (Estate e in estates)
            {
                if (e.Id == id)
                {
                    estates.Remove(e);
                    ids.Remove(id);
                    break;
                }
            } updateTxtWindow();
        }


        /// <summary>
        /// Updates the list of estates is the RichTextBox window in the Search/Delete tab
        /// </summary>
        private void updateTxtWindow()
        {

            // richTxtBx.Text = richTxtBx.Text + "\n" + estates[0];

            string estatesList = "";

            foreach(Estate e in estates)
            {
                estatesList += e.ToString() + "\n";
            }

            richTxtBx.Text = estatesList;
        }


        /// <summary>
        /// Helper method to get the Estate with the given id, if the Estate is not present, 
        /// return null and print out a message to the user.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Estate GetEstate(string id)
        {

            // Check to se if the given id is present in the ids set
            if (!ids.Contains(id))
            {
                MessageBox.Show($"There is no Estate object in the hashSet that has the id {id}");
                return null;
            }

            foreach (Estate e in estates)
            {
                if (e.Id == id)
                {
                    return e;
                }
            }

            return null;
        }
        public Estate SearchEstate(TypeAll type, string city)
        {


            string estatesList = "";
            foreach (Estate e in estates)
            {
                if (e.TypeAll == type && e.Address.City == city)
                {
                    estatesList += e.ToString() + "\n";

                }
                richTxtBx.Text = estatesList;
                
            }

            return null;
        }

        public Estate ChangeEstate(ComboBox comboBoxLegalForm, ComboBox comboBoxCountry, ComboBox comboBocCategory, ComboBox comboBoxType, TextBox textchange, TextBox textcity, TextBox textzip, TextBox textStreet, TextBox textUnique, string changebtn, TextBox textId, PictureBox pictureBoxImage)
        {
            //.ChangeEstate(id, legalForm, country, city, zipCode, street, category, text, image, typeAll, comboBoxLegalForm, comboBoxCountry, comboBox3, comboBox4, textBoxChangeEstate, textBoxCity, textBoxZipCode, textBoxStreet, textBox6);
            this.comboBoxLegalForm = comboBoxLegalForm;
            this.comboBocCategory = comboBocCategory;
            this.comboBoxCountry = comboBoxCountry;
            this.comboBoxType = comboBoxType;
            this.textchange = textchange;
            this.textcity = textcity;
            this.textzip = textzip;
            this.textStreet = textStreet;
            this.textUnique = textUnique;
            this.textId = textId;
            this.pictureBoxImage = pictureBoxImage;

            foreach (Estate e in estates)
            {
                if (e.Id == changebtn)
                {
                    
                    comboBoxLegalForm.SelectedItem = e.LegalForm;
                    comboBoxCountry.SelectedItem = e.Address.Country;
                    comboBocCategory.SelectedItem = e.Category;
                    comboBoxType.SelectedItem = e.TypeAll;
                    textId.Text = changebtn;
                    textcity.Text = e.Address.City.ToString();
                    textzip.Text = e.Address.ZIPCode.ToString();
                    textStreet.Text = e.Address.Street.ToString();
                    textUnique.Text = e.UniqueText();
                    pictureBoxImage.Image = e.Image;
                    return e;
                }
                
                    MessageBox.Show($"There is no Estate object in the hashSet that has the id {changebtn}");
                
            }
            return null;
            }
            

           
      
     }
}
