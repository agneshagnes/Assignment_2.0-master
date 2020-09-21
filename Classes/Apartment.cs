using Assignment.Enum;
using Assignment_1.AbstractClasses;
using Assignment_1.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Classes
{

    /// <summary>
    /// 
    /// </summary>
    class Apartment : Estate
    {

        private string floorNumber;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="address"></param>
        /// <param name="id"></param>
        /// <param name="floorNumber"></param>
        /// <param name="squareMeters"></param>
        /// <param name="lf"></param>
        /// <param name="image"></param>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="c"></param>
        /// <param name="ZipCode"></param>
        public Apartment(string id, string floorNumber, LegalForms lf, Bitmap image, Address address, Category cat, TypeAll type)
        {
            this.Id = id;
            this.Address = address;
            // The unique attribute for this class
            this.floorNumber = floorNumber;
            this.LegalForm = lf;
            this.Image = image;
            this.Category = cat;
            this.TypeAll= type;
        }

        /// <summary>
        /// ToString method to help make a string that represents this an Apartment object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
           
            string result = $"-- {Id}  --------  {LegalForm}  -----------  {Category}  ---------  {TypeAll}  --------  {Address.Country}  -------  {Address.City}  --------  {Address.Street}  ------------  {Address.ZIPCode}  ---------- Floor number: {floorNumber}";
            return result;
        } 
    }
}
