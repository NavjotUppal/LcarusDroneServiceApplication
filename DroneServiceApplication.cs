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
        double cost=0.0;
        //6.2	Create a global List<T> of type Drone called “FinishedList”. 
        List<Drone> FinishedList = new List<Drone>();
        //6.3	Create a global Queue<T> of type Drone called “RegularService”.
        Queue<Drone> RegularService = new Queue<Drone>();
        //6.4	Create a global Queue<T> of type Drone called “ExpressService”.
        Queue<Drone> ExpressService = new Queue<Drone>();
        // 6.5	Create a button method called “AddNewItem” that will add a new service item to a Queue<> based on the priority.
        // Use TextBoxes for the Client Name, Drone Model, Service Problem and Service Cost.
        // Use a numeric up/down control for the Service Tag.
        // The new service item will be added to the appropriate Queue based on the Priority radio button.
        private void buttonAddNewItem_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(textBoxClientName.Text)))
            {
                Drone drone = new Drone();
                Double.TryParse(textBoxServiceCost.Text, out cost);
                drone.setClientName(textBoxClientName.Text);
                drone.setDroneModel(textBoxDroneModel.Text);
                
                drone.setServiceTag((int)numericUpDown.Value);
                drone.setServiceProblem(textAreaServiceProblem.Text);
                if (getServicePriority() == "Express")
                {
                    //6.6	Before a new service item is added to the Express Queue the service cost must be increased by 15%.
                    cost = cost + 0.15 * cost;
                    drone.setServiceCost(cost);
                    ExpressService.Enqueue(drone);
                    displayExpressServiceQueue();
                    toolStripStatusLabel.Text = "New drone is added to Express Service Queue";
                }
                else if (getServicePriority() == "Regular")
                {
                    drone.setServiceCost(cost);
                    RegularService.Enqueue(drone);
                    displayRegularServiceQueue();
                    toolStripStatusLabel.Text = "New drone is added to Regular Service Queue";
                }
                else
                {
                    MessageBox.Show("Please choose appropriate service priority");
                }
                //resetFields();

            }
        }
        //6.7	Create a custom method called “GetServicePriority” which returns the value of the priority radio group.
        //This method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        private string getServicePriority()
        {
            string rbValue = "";
            foreach (RadioButton rb in groupBoxServicePriority.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    rbValue = rb.Text;
                    break;
                }
                else
                {
                    rbValue = "Other";
                }
            }
            return rbValue;
        }
        //6.8	Create a custom method that will display all the elements in the RegularService queue.
        //The display must use a List View and with appropriate column headers.
        private void displayRegularServiceQueue()
        {
            listViewRegular.Items.Clear();
            foreach (Drone drone in RegularService)
            {
                ListViewItem lvi = new ListViewItem(drone.getClientName());
                lvi.SubItems.Add(drone.getDroneModel());
                lvi.SubItems.Add(drone.getServiceProblem());
                lvi.SubItems.Add(drone.getServiceTag());
                lvi.SubItems.Add("$ "+drone.getServiceCost());
                listViewRegular.Items.Add(lvi);
            }
        }
        //6.9	Create a custom method that will display all the elements in the ExpressService queue.
        //The display must use a List View and with appropriate column headers.
        private void displayExpressServiceQueue()
        {
            listViewExpress.Items.Clear();
            foreach (Drone drone in ExpressService)
            {
                ListViewItem lvi = new ListViewItem(drone.getClientName());
                lvi.SubItems.Add(drone.getDroneModel());
                lvi.SubItems.Add(drone.getServiceProblem());
                lvi.SubItems.Add(drone.getServiceTag());
                lvi.SubItems.Add("$ " + drone.getServiceCost());
                listViewExpress.Items.Add(lvi);
            }
        }


        //6.10	Create a custom keypress method to ensure the Service Cost textbox can only accept a double value with one decimal point.
        private void textBoxServiceCost_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
