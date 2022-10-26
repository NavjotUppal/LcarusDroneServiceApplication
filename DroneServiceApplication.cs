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
        List<Drone> FinishedList=new List<Drone>();
        Queue<Drone> RegularService=new Queue<Drone>();
        Queue<Drone> ExpressService =new Queue<Drone>();

    }
}
