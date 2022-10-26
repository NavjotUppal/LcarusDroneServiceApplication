using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LcarusDroneServiceApplication
{
    public partial class DroneServiceApplication : Form
    {
        public DroneServiceApplication()
        {
            InitializeComponent();
        }
        //6.2	Create a global List<T> of type Drone called “FinishedList”. 
        List<Drone> FinishedList=new List<Drone>();
        //6.3	Create a global Queue<T> of type Drone called “RegularService”.
        Queue<Drone> RegularService=new Queue<Drone>();
        //6.4	Create a global Queue<T> of type Drone called “ExpressService”.
        Queue<Drone> ExpressService =new Queue<Drone>();

    }
}
