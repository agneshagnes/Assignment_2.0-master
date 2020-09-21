using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Assignment.Enum;
using Assignment_1.AbstractClasses;
using Assignment_1.Classes;

namespace Assignment_1.Classes
{

    /// <summary>
    /// A class to represent a House
    /// Authors Agnes Hägnestrand and Andreas Holm
    /// </summary>
    class House : Estate
    {
        private string color;

        public House(string id, string color, LegalForms lf, Bitmap image, Address address, Category cat, TypeAll type)
        {
            this.Address = address;
            this.Id = id;

            // The unique attribute for this class
            this.color = color;
            this.LegalForm = lf;
            this.Image = image;
            this.Category = cat;
            this.TypeAll = type;
        }


        /// <summary>
        /// ToString method to help make a string of a House object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = $"-- {Id}  --------  {LegalForm}  -------------  {Category}  ---------  {TypeAll}  --------  {Address.Country}  -------  {Address.City}  --------  {Address.Street}  ------------  {Address.ZIPCode}  ------------ Color: {color}";
            return result;
        }
    }
}
