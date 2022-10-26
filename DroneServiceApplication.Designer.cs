namespace LcarusDroneServiceApplication
{
    partial class DroneServiceApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxServicePriority = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.textBoxDroneModel = new System.Windows.Forms.TextBox();
            this.textAreaServiceProblem = new System.Windows.Forms.TextBox();
            this.textBoxServiceCost = new System.Windows.Forms.TextBox();
            this.buttonAddNewItem = new System.Windows.Forms.Button();
            this.listViewRegular = new System.Windows.Forms.ListView();
            this.ClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DroneModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServiceProblem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServiceTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServiceCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewExpress = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxFinishedService = new System.Windows.Forms.ListBox();
            this.buttonRemoveRegular = new System.Windows.Forms.Button();
            this.buttonRemoveExpress = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxServicePriority.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drone Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Service Problem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Service Cost";
            // 
            // groupBoxServicePriority
            // 
            this.groupBoxServicePriority.Controls.Add(this.radioButton2);
            this.groupBoxServicePriority.Controls.Add(this.radioButton1);
            this.groupBoxServicePriority.Location = new System.Drawing.Point(493, 90);
            this.groupBoxServicePriority.Name = "groupBoxServicePriority";
            this.groupBoxServicePriority.Size = new System.Drawing.Size(200, 55);
            this.groupBoxServicePriority.TabIndex = 4;
            this.groupBoxServicePriority.TabStop = false;
            this.groupBoxServicePriority.Text = "Service Priority";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(103, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Express";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Regular";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Service Tag";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(130, 18);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(122, 22);
            this.textBoxClientName.TabIndex = 6;
            // 
            // textBoxDroneModel
            // 
            this.textBoxDroneModel.Location = new System.Drawing.Point(130, 56);
            this.textBoxDroneModel.Name = "textBoxDroneModel";
            this.textBoxDroneModel.Size = new System.Drawing.Size(122, 22);
            this.textBoxDroneModel.TabIndex = 7;
            // 
            // textAreaServiceProblem
            // 
            this.textAreaServiceProblem.Location = new System.Drawing.Point(130, 96);
            this.textAreaServiceProblem.Multiline = true;
            this.textAreaServiceProblem.Name = "textAreaServiceProblem";
            this.textAreaServiceProblem.Size = new System.Drawing.Size(122, 88);
            this.textAreaServiceProblem.TabIndex = 8;
            // 
            // textBoxServiceCost
            // 
            this.textBoxServiceCost.Location = new System.Drawing.Point(616, 18);
            this.textBoxServiceCost.Name = "textBoxServiceCost";
            this.textBoxServiceCost.Size = new System.Drawing.Size(120, 22);
            this.textBoxServiceCost.TabIndex = 9;
            this.textBoxServiceCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxServiceCost_KeyPress);
            // 
            // buttonAddNewItem
            // 
            this.buttonAddNewItem.Location = new System.Drawing.Point(727, 161);
            this.buttonAddNewItem.Name = "buttonAddNewItem";
            this.buttonAddNewItem.Size = new System.Drawing.Size(101, 23);
            this.buttonAddNewItem.TabIndex = 11;
            this.buttonAddNewItem.Text = "AddNewItem";
            this.buttonAddNewItem.UseVisualStyleBackColor = true;
            this.buttonAddNewItem.Click += new System.EventHandler(this.buttonAddNewItem_Click);
            // 
            // listViewRegular
            // 
            this.listViewRegular.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientName,
            this.DroneModel,
            this.ServiceProblem,
            this.ServiceTag,
            this.ServiceCost});
            this.listViewRegular.HideSelection = false;
            this.listViewRegular.Location = new System.Drawing.Point(13, 226);
            this.listViewRegular.Name = "listViewRegular";
            this.listViewRegular.Size = new System.Drawing.Size(542, 144);
            this.listViewRegular.TabIndex = 12;
            this.listViewRegular.UseCompatibleStateImageBehavior = false;
            this.listViewRegular.View = System.Windows.Forms.View.Details;
            // 
            // ClientName
            // 
            this.ClientName.Text = "ClientName";
            this.ClientName.Width = 89;
            // 
            // DroneModel
            // 
            this.DroneModel.Text = "DroneModel";
            this.DroneModel.Width = 88;
            // 
            // ServiceProblem
            // 
            this.ServiceProblem.Text = "Problem";
            this.ServiceProblem.Width = 90;
            // 
            // ServiceTag
            // 
            this.ServiceTag.Text = "Tag";
            this.ServiceTag.Width = 56;
            // 
            // ServiceCost
            // 
            this.ServiceCost.Text = "Cost";
            this.ServiceCost.Width = 88;
            // 
            // listViewExpress
            // 
            this.listViewExpress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewExpress.HideSelection = false;
            this.listViewExpress.Location = new System.Drawing.Point(12, 414);
            this.listViewExpress.Name = "listViewExpress";
            this.listViewExpress.Size = new System.Drawing.Size(543, 144);
            this.listViewExpress.TabIndex = 13;
            this.listViewExpress.UseCompatibleStateImageBehavior = false;
            this.listViewExpress.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ClientName";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DroneModel";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Problem";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tag";
            this.columnHeader4.Width = 59;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cost";
            this.columnHeader5.Width = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Regular Service";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Express Service";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(636, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Finished Service";
            // 
            // listBoxFinishedService
            // 
            this.listBoxFinishedService.FormattingEnabled = true;
            this.listBoxFinishedService.ItemHeight = 16;
            this.listBoxFinishedService.Location = new System.Drawing.Point(639, 226);
            this.listBoxFinishedService.Name = "listBoxFinishedService";
            this.listBoxFinishedService.Size = new System.Drawing.Size(242, 324);
            this.listBoxFinishedService.TabIndex = 17;
            // 
            // buttonRemoveRegular
            // 
            this.buttonRemoveRegular.Location = new System.Drawing.Point(386, 376);
            this.buttonRemoveRegular.Name = "buttonRemoveRegular";
            this.buttonRemoveRegular.Size = new System.Drawing.Size(150, 23);
            this.buttonRemoveRegular.TabIndex = 18;
            this.buttonRemoveRegular.Text = "RemoveItemRegular";
            this.buttonRemoveRegular.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveExpress
            // 
            this.buttonRemoveExpress.Location = new System.Drawing.Point(386, 568);
            this.buttonRemoveExpress.Name = "buttonRemoveExpress";
            this.buttonRemoveExpress.Size = new System.Drawing.Size(150, 23);
            this.buttonRemoveExpress.TabIndex = 19;
            this.buttonRemoveExpress.Text = "RemoveItemExpress";
            this.buttonRemoveExpress.UseVisualStyleBackColor = true;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown.Location = new System.Drawing.Point(616, 55);
            this.numericUpDown.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown.TabIndex = 20;
            this.numericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 653);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(966, 26);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(143, 20);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // DroneServiceApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 679);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.buttonRemoveExpress);
            this.Controls.Add(this.buttonRemoveRegular);
            this.Controls.Add(this.listBoxFinishedService);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listViewExpress);
            this.Controls.Add(this.listViewRegular);
            this.Controls.Add(this.buttonAddNewItem);
            this.Controls.Add(this.textBoxServiceCost);
            this.Controls.Add(this.textAreaServiceProblem);
            this.Controls.Add(this.textBoxDroneModel);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBoxServicePriority);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DroneServiceApplication";
            this.Text = "Drone Service Application";
            this.groupBoxServicePriority.ResumeLayout(false);
            this.groupBoxServicePriority.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxServicePriority;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.TextBox textBoxDroneModel;
        private System.Windows.Forms.TextBox textAreaServiceProblem;
        private System.Windows.Forms.TextBox textBoxServiceCost;
        private System.Windows.Forms.Button buttonAddNewItem;
        private System.Windows.Forms.ListView listViewRegular;
        private System.Windows.Forms.ColumnHeader ClientName;
        private System.Windows.Forms.ColumnHeader DroneModel;
        private System.Windows.Forms.ColumnHeader ServiceProblem;
        private System.Windows.Forms.ColumnHeader ServiceTag;
        private System.Windows.Forms.ColumnHeader ServiceCost;
        private System.Windows.Forms.ListView listViewExpress;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxFinishedService;
        private System.Windows.Forms.Button buttonRemoveRegular;
        private System.Windows.Forms.Button buttonRemoveExpress;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

