using Assignment_1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interface
{
    interface IEstate
    {

        string Id { get; set; }
        Address Address { get; set; }
    }
}