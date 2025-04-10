using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Hunt_Shayla
{
    internal class Car
    {
        // Private field to store the model of thhe Car
        private string model;

        // The getter and setter for the Model property
        public string Model { get { return model; } set { model = value; } }

        // A property used to store the make of the Car
        public string Make { get; set; }

    }
}
