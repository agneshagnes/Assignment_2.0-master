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

    /// <summary>
    /// A class to represent a Villa
    /// Authors Agnes Hägnestrand and Andreas Holm
    /// </summary>
    class Villa : Estate
    {

        private string lawnSize;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="address"></param>
        /// <param name="id"></param>
        /// <param name="lawnSize"></param>
        /// <param name="squareMeters"></param>
        /// <param name="lf"></param>
        /// <param name="image"></param>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="c"></param>
        /// <param name="ZipCode"></param>
        public Villa(string id, string lawnSize, LegalForms lf, Bitmap image, Address address, Category cat, TypeAll type)
        {
            this.Address = address;
            this.Id = id;

            // The unique attribute for this class
            this.lawnSize = lawnSize;
            this.LegalForm = lf;
            this.Image = image;
            this.Category = cat;
            this.TypeAll = type;
        }

        /// <summary>
        /// ToString method to help make a string that represents this an Villa object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = $"-- {Id}  --------  {LegalForm}  -----------  {Category}  ---------  {TypeAll}  --------  {Address.Country}  -------  {Address.City}  --------  {Address.Street}  ------------  {Address.ZIPCode}  ---------- LawnSize: {lawnSize}";
            return result;
        }
        public override string UniqueText()
        {
            return lawnSize;
        }
    }
}
