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
        double cost = 0.0;
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
            if ((!string.IsNullOrEmpty(textBoxClientName.Text))&&(!string.IsNullOrEmpty(textBoxDroneModel.Text))&&(!string.IsNullOrEmpty(textAreaServiceProblem.Text))&& (!string.IsNullOrEmpty(textBoxServiceCost.Text))&&(!string.IsNullOrEmpty(getServicePriority())))
            {
                Drone drone = new Drone();
                Double.TryParse(textBoxServiceCost.Text, out cost);
                drone.setClientName(textBoxClientName.Text);
                drone.setDroneModel(textBoxDroneModel.Text);

                drone.setServiceTag((int)numericUpDown.Value);
                drone.setServiceProblem(textAreaServiceProblem.Text);
                incrementServiceTag();
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
                clearFields();

            }
            else
            {
                MessageBox.Show("Please fill in all the information properly.");
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
                lvi.SubItems.Add("$ " + drone.getServiceCost());
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            //allows only one decimal place after (.)
            if (e.KeyChar == '.' && textBoxServiceCost.Text.Contains(".") == false)
            {
                textBoxServiceCost.MaxLength = textBoxServiceCost.TextLength + 2;
            }

        }
        // 6.11	Create a custom method to increment the service tag control,
        // this method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        private void incrementServiceTag()
        {
            numericUpDown.Value += 10;
        }
        // 6.12	Create a mouse click method for the regular service
        // ListView that will display the Client Name and Service Problem in the related textboxes.

        private void listViewRegular_Click(object sender, EventArgs e)
        {
            int pos = listViewRegular.SelectedIndices[0];
            displayFromRegularServiceQueue(pos);
        }
      
        private void displayFromRegularServiceQueue(int pos)
        {
            disableControls();
            textBoxClientName.Text = RegularService.ElementAt(pos).getClientName();
            textBoxDroneModel.Text = RegularService.ElementAt(pos).getDroneModel();
            textBoxServiceCost.Text = RegularService.ElementAt(pos).getServiceCost();
            textAreaServiceProblem.Text = RegularService.ElementAt(pos).getServiceProblem();
            numericUpDown.Text = RegularService.ElementAt(pos).getServiceTag();
            rbRegular.Checked = true;
        }
        //6.13	Create a mouse click method for the express service
        //ListView that will display the Client Name and Service Problem in the related textboxes.
        private void listViewExpress_Click(object sender, EventArgs e)
        {

            int pos = listViewExpress.SelectedIndices[0];
            displayFromExpressServiceQueue(pos);
        }
        private void displayFromExpressServiceQueue(int pos)
        {
            disableControls();
            textBoxClientName.Text = ExpressService.ElementAt(pos).getClientName();
            textBoxDroneModel.Text = ExpressService.ElementAt(pos).getDroneModel();
            textBoxServiceCost.Text = ExpressService.ElementAt(pos).getServiceCost();
            textAreaServiceProblem.Text = ExpressService.ElementAt(pos).getServiceProblem();
            numericUpDown.Text = ExpressService.ElementAt(pos).getServiceTag();
            rbExpress.Checked = true;
        }
        // 6.14	Create a button click method that will remove a service item from the regular ListView and dequeue the regular service Queue<T> data structure.
        // The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.
        private void buttonRemoveRegular_Click(object sender, EventArgs e)
        {
            if (RegularService.Count > 0)
            {
                FinishedList.Add(RegularService.Dequeue());
                displayRegularServiceQueue();
                displayFinishedList();
            }
        }

        // 6.15	Create a button click method that will remove a service item from the express ListView and dequeue the express service Queue<T> data structure.
        // The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.
        private void buttonRemoveExpress_Click(object sender, EventArgs e)
        {
            if (ExpressService.Count > 0)
            {
                FinishedList.Add(ExpressService.Dequeue());
                displayExpressServiceQueue();
                displayFinishedList();
            }
        }
        private void displayFinishedList()
        {
            listBoxFinishedService.Items.Clear();
            foreach (var items in FinishedList)
            {
                listBoxFinishedService.Items.Add(items.getClientName() + "          $" + items.getServiceCost());
            }
        }
        // 6.16	Create a double mouse click method that will delete a service item from the finished listbox
        // and remove the same item from the List<T>.
        private void listBoxFinishedService_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FinishedList.Count > 0 && listBoxFinishedService.SelectedIndex >= 0)
            {
                FinishedList.Remove(FinishedList[0]);
                displayFinishedList();
            }
        }
        // 6.17	Create a custom method that will clear all the textboxes after each service item has been added.
        private void clearFields()
        {
            textBoxClientName.Clear();
            textBoxDroneModel.Clear();
            textAreaServiceProblem.Clear();
            textBoxServiceCost.Clear();
            rbRegular.Checked= false;
            rbExpress.Checked= false;
            textBoxClientName.Focus();
        }
        private void disableControls()
        {
            textBoxClientName.Enabled = false;
            textBoxDroneModel.Enabled = false;
            textBoxServiceCost.Enabled = false;
            textAreaServiceProblem.Enabled = false;
            groupBoxServicePriority.Enabled = false;
            buttonAddNewItem.Enabled = false;
        }

        private void textBoxClientName_DoubleClick(object sender, EventArgs e)
        {
            clearFields();
            toolStripStatusLabel.Text = "All the text boxes are cleared.";
        }

        private void textBoxClientName_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip.SetToolTip(textBoxClientName, "Double Click on the text box to clear the text boxes.");
        }

        private void listViewRegular_MouseHover(object sender, EventArgs e)
        {
            if(listViewRegular.Items.Count > 0)
            {
                toolTip.SetToolTip(listViewRegular, "Click to add the drone to Finished List when service is done. ");
            }
        }

        private void listViewExpress_MouseHover(object sender, EventArgs e)
        {
            if (listViewExpress.Items.Count>0)
            {
                toolTip.SetToolTip(listViewExpress, "Click to add the drone to Finished List when service is done. ");
            }
        }

        private void listBoxFinishedService_MouseHover(object sender, EventArgs e)
        {
            if (listBoxFinishedService.Items.Count>0)
            {
                toolTip.SetToolTip(listBoxFinishedService, "Click to remove the drone, when the payment is done. ");
            }
        }
    }
}

