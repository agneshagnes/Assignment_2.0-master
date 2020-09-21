using Assignment.Enum;
using Assignment_1.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Classes
{
    class Shop : Estate
    {

        private string typeOfShop;

        public Shop(string id, string typeOfShop, LegalForms lf, Bitmap image, Address address, Category cat, TypeAll type)
        {
            this.Address = address;
            this.Id = id;

            // The unique attribute for this class
            this.typeOfShop = typeOfShop;
            this.LegalForm = lf;
            this.Image = image;
            this.Category = cat;
            this.TypeAll = type;
        }


        /// <summary>
        /// ToString method to help make a string of a Shop object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = $"-- {Id}  --------  {LegalForm}  -----------  {Category}  ---------  {TypeAll}  --------  {Address.Country}  -------  {Address.City}  --------  {Address.Street}  ------------  {Address.ZIPCode}  ---------- TypeOfShop: {typeOfShop}";
            return result;
        }
    }
}
