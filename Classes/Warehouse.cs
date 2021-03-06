﻿using Assignment.Enum;
using Assignment_1.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Classes
{
    class Warehouse : Estate
    {

        private string cubicMeterCapacity;

        public Warehouse(string id, string cubicMeterCapacity, LegalForms lf, Bitmap image, Address address, Category cat, TypeAll type)
        {
            this.Address = address;
            this.Id = id;

            // The unique attribute for this class
            this.cubicMeterCapacity = cubicMeterCapacity;
            this.LegalForm = lf;
            this.Image = image;
            this.Category = cat;
            this.TypeAll = type;
        }

        /// <summary>
        /// ToString method to help make a string of a Warehouse object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = $"-- {Id}  --------  {LegalForm}  -----------  {Category}  ---------  {TypeAll}  --------  {Address.Country}  -------  {Address.City}  --------  {Address.Street}  ------------  {Address.ZIPCode}  ---------- Capacity: {cubicMeterCapacity}";
            return result;
        }
    }
}
