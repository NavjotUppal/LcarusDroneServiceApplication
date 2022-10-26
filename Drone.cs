using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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
        
              
        

        public void getClientName(string clientName)
        {
            this.clientName = clientName;
        }
        public string setClientName()
        {
            return textInfo.ToTitleCase(clientName);
        }
        public void getDroneModel(string model)
        {
            droneModel = model;
        }
        public string setDroneModel()
        {
            return droneModel;
        }
        public void getServiceProblem(string problem)
        {serviceProblem=problem;
        }
        public string setServiceProblem()
        {
            return textInfo.ToTitleCase(serviceProblem);
        }
        public void getServiceCost(double cost)
        {
            serviceCost=cost;
        }
        public string setServiceCost()
        {
            return serviceCost.ToString();
        }
        public void getServiceTag(int tag)
        {
             serviceTag=tag;
        }
        public int setServiceTag()
        {
            return (int)serviceTag;
        }
    }
}
