using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
// 6.1	Create a separate class file to hold the data items of the Drone.
// Use separate getter and setter methods, ensure the attributes are private and the accessor methods are public.
// Add a display method that returns a string for Client Name and Service Cost.
// Add suitable code to the Client Name and Service Problem accessor methods so the data is formatted as Title case or Sentence case.
// Save the class as “Drone.cs”.
namespace LcarusDroneServiceApplication
{
    internal class Drone
    {
        private string clientName;
       private  string droneModel;
        private double serviceCost;
        private string serviceProblem;
        private int serviceTag;
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
         public void setClientName(string clientName)
        {
            this.clientName = clientName;
        }
        public string getClientName()
        {
            return textInfo.ToTitleCase(clientName);
        }
        public void setDroneModel(string model)
        {
            droneModel = model;
        }
        public string getDroneModel()
        {
            return droneModel;
        }
        public void setServiceProblem(string problem)
        {serviceProblem=problem;
        }
        public string getServiceProblem()
        {
            return textInfo.ToTitleCase(serviceProblem);
        }
        public void setServiceCost(double cost)
        {
            serviceCost=cost;
        }
        public string getServiceCost()
        {
            return serviceCost.ToString();
        }
        public void setServiceTag(int tag)
        {
             serviceTag=tag;
        }
        public int getServiceTag()
        {
            return (int)serviceTag;
        }
    }
}
