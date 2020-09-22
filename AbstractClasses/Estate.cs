using Assignment.Enum;
using Assignment.Interface;
using Assignment_1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.AbstractClasses
{

    abstract class  Estate : IEstate
    {
        private string id;
        private Address address;
        private LegalForms legForm;
        private Category cat;
        private Bitmap image;
        private TypeAll typeAll;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public LegalForms LegalForm
        {
            get { return legForm; }
            set
            {legForm = value;}
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// Get and set for the category propery
        /// </summary>
        public Category Category
        {
            get { return cat; }
            set { cat = value; }
        }

        public Bitmap Image { get => image; set => image = value; }

        public TypeAll TypeAll {
            get { return typeAll; }
            set { typeAll = value; }
         }

        /// <summary>
        /// Abstract toString method to be overridden in the extending classes
        /// </summary>
        /// <returns></returns>
        public abstract string ToString();
        public abstract string UniqueText();
    }
}