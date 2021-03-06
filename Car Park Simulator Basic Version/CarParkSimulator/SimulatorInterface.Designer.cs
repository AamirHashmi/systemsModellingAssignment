﻿namespace CarParkSimulator
{
    partial class SimulatorInterface
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTicketMachine = new System.Windows.Forms.Label();
            this.btnCarEntersCarPark = new System.Windows.Forms.Button();
            this.btnDriverPressesForTicket = new System.Windows.Forms.Button();
            this.btnCarArrivesAtEntrance = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTicketValidator = new System.Windows.Forms.Label();
            this.btnCarExitsCarPark = new System.Windows.Forms.Button();
            this.btnDriverEntersTicket = new System.Windows.Forms.Button();
            this.btnCarArrivesAtExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lstActiveTickets = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblExitBarrier = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblExitSensor = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEntryBarrier = new System.Windows.Forms.Label();
            this.lblEntrySensor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSpaces = new System.Windows.Forms.Label();
            this.lblFullSign = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTicketMachine);
            this.groupBox1.Controls.Add(this.btnCarEntersCarPark);
            this.groupBox1.Controls.Add(this.btnDriverPressesForTicket);
            this.groupBox1.Controls.Add(this.btnCarArrivesAtEntrance);
            this.groupBox1.Location = new System.Drawing.Point(18, 228);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(300, 366);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrance simulator";
            // 
            // lblTicketMachine
            // 
            this.lblTicketMachine.BackColor = System.Drawing.Color.DimGray;
            this.lblTicketMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTicketMachine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTicketMachine.Location = new System.Drawing.Point(9, 31);
            this.lblTicketMachine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicketMachine.Name = "lblTicketMachine";
            this.lblTicketMachine.Size = new System.Drawing.Size(281, 47);
            this.lblTicketMachine.TabIndex = 1;
            this.lblTicketMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCarEntersCarPark
            // 
            this.btnCarEntersCarPark.Location = new System.Drawing.Point(9, 272);
            this.btnCarEntersCarPark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCarEntersCarPark.Name = "btnCarEntersCarPark";
            this.btnCarEntersCarPark.Size = new System.Drawing.Size(282, 83);
            this.btnCarEntersCarPark.TabIndex = 3;
            this.btnCarEntersCarPark.Text = "Car enters car park";
            this.btnCarEntersCarPark.UseVisualStyleBackColor = true;
            this.btnCarEntersCarPark.Visible = false;
            this.btnCarEntersCarPark.Click += new System.EventHandler(this.CarEntersCarPark);
            // 
            // btnDriverPressesForTicket
            // 
            this.btnDriverPressesForTicket.Location = new System.Drawing.Point(9, 180);
            this.btnDriverPressesForTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDriverPressesForTicket.Name = "btnDriverPressesForTicket";
            this.btnDriverPressesForTicket.Size = new System.Drawing.Size(282, 83);
            this.btnDriverPressesForTicket.TabIndex = 1;
            this.btnDriverPressesForTicket.Text = "Driver presses for ticket";
            this.btnDriverPressesForTicket.UseVisualStyleBackColor = true;
            this.btnDriverPressesForTicket.Visible = false;
            this.btnDriverPressesForTicket.Click += new System.EventHandler(this.DriverPressesForTicket);
            // 
            // btnCarArrivesAtEntrance
            // 
            this.btnCarArrivesAtEntrance.Location = new System.Drawing.Point(9, 88);
            this.btnCarArrivesAtEntrance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCarArrivesAtEntrance.Name = "btnCarArrivesAtEntrance";
            this.btnCarArrivesAtEntrance.Size = new System.Drawing.Size(282, 83);
            this.btnCarArrivesAtEntrance.TabIndex = 0;
            this.btnCarArrivesAtEntrance.Text = "Car arrives at entrance";
            this.btnCarArrivesAtEntrance.UseVisualStyleBackColor = true;
            this.btnCarArrivesAtEntrance.Visible = false;
            this.btnCarArrivesAtEntrance.Click += new System.EventHandler(this.CarArrivesAtEntrance);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTicketValidator);
            this.groupBox2.Controls.Add(this.btnCarExitsCarPark);
            this.groupBox2.Controls.Add(this.btnDriverEntersTicket);
            this.groupBox2.Controls.Add(this.btnCarArrivesAtExit);
            this.groupBox2.Location = new System.Drawing.Point(339, 228);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(300, 366);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exit simulator";
            // 
            // lblTicketValidator
            // 
            this.lblTicketValidator.BackColor = System.Drawing.Color.DimGray;
            this.lblTicketValidator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTicketValidator.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTicketValidator.Location = new System.Drawing.Point(9, 31);
            this.lblTicketValidator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicketValidator.Name = "lblTicketValidator";
            this.lblTicketValidator.Size = new System.Drawing.Size(281, 47);
            this.lblTicketValidator.TabIndex = 1;
            this.lblTicketValidator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCarExitsCarPark
            // 
            this.btnCarExitsCarPark.Location = new System.Drawing.Point(9, 272);
            this.btnCarExitsCarPark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCarExitsCarPark.Name = "btnCarExitsCarPark";
            this.btnCarExitsCarPark.Size = new System.Drawing.Size(282, 83);
            this.btnCarExitsCarPark.TabIndex = 2;
            this.btnCarExitsCarPark.Text = "Car exits car park";
            this.btnCarExitsCarPark.UseVisualStyleBackColor = true;
            this.btnCarExitsCarPark.Visible = false;
            this.btnCarExitsCarPark.Click += new System.EventHandler(this.CarExitsCarPark);
            // 
            // btnDriverEntersTicket
            // 
            this.btnDriverEntersTicket.Location = new System.Drawing.Point(9, 180);
            this.btnDriverEntersTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDriverEntersTicket.Name = "btnDriverEntersTicket";
            this.btnDriverEntersTicket.Size = new System.Drawing.Size(282, 83);
            this.btnDriverEntersTicket.TabIndex = 1;
            this.btnDriverEntersTicket.Text = "Driver enters ticket";
            this.btnDriverEntersTicket.UseVisualStyleBackColor = true;
            this.btnDriverEntersTicket.Visible = false;
            this.btnDriverEntersTicket.Click += new System.EventHandler(this.DriverEntersTicket);
            // 
            // btnCarArrivesAtExit
            // 
            this.btnCarArrivesAtExit.Location = new System.Drawing.Point(9, 88);
            this.btnCarArrivesAtExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCarArrivesAtExit.Name = "btnCarArrivesAtExit";
            this.btnCarArrivesAtExit.Size = new System.Drawing.Size(282, 83);
            this.btnCarArrivesAtExit.TabIndex = 0;
            this.btnCarArrivesAtExit.Text = "Car arrives at exit";
            this.btnCarArrivesAtExit.UseVisualStyleBackColor = true;
            this.btnCarArrivesAtExit.Visible = false;
            this.btnCarArrivesAtExit.Click += new System.EventHandler(this.CarArrivesAtExit);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(609, 78);
            this.label3.TabIndex = 4;
            this.label3.Text = "Car Park Simulator";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(27, 128);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(603, 83);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.ResetSystem);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblSpaces);
            this.groupBox3.Controls.Add(this.lblFullSign);
            this.groupBox3.Location = new System.Drawing.Point(660, 228);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(492, 366);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Internal data";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lstActiveTickets);
            this.groupBox6.Location = new System.Drawing.Point(256, 31);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(216, 325);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Active Tickets";
            // 
            // lstActiveTickets
            // 
            this.lstActiveTickets.FormattingEnabled = true;
            this.lstActiveTickets.ItemHeight = 20;
            this.lstActiveTickets.Location = new System.Drawing.Point(9, 29);
            this.lstActiveTickets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstActiveTickets.Name = "lstActiveTickets";
            this.lstActiveTickets.Size = new System.Drawing.Size(196, 284);
            this.lstActiveTickets.TabIndex = 0;
            this.lstActiveTickets.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.lblExitBarrier);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.lblExitSensor);
            this.groupBox5.Location = new System.Drawing.Point(16, 142);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(212, 103);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Exit";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sensor";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExitBarrier
            // 
            this.lblExitBarrier.BackColor = System.Drawing.Color.White;
            this.lblExitBarrier.Location = new System.Drawing.Point(90, 63);
            this.lblExitBarrier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExitBarrier.Name = "lblExitBarrier";
            this.lblExitBarrier.Size = new System.Drawing.Size(105, 31);
            this.lblExitBarrier.TabIndex = 0;
            this.lblExitBarrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(9, 63);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 31);
            this.label13.TabIndex = 0;
            this.label13.Text = "Barrier";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExitSensor
            // 
            this.lblExitSensor.BackColor = System.Drawing.Color.White;
            this.lblExitSensor.Location = new System.Drawing.Point(90, 25);
            this.lblExitSensor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExitSensor.Name = "lblExitSensor";
            this.lblExitSensor.Size = new System.Drawing.Size(105, 31);
            this.lblExitSensor.TabIndex = 0;
            this.lblExitSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lblEntryBarrier);
            this.groupBox4.Controls.Add(this.lblEntrySensor);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(16, 29);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(212, 103);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Entry";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sensor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEntryBarrier
            // 
            this.lblEntryBarrier.BackColor = System.Drawing.Color.White;
            this.lblEntryBarrier.Location = new System.Drawing.Point(90, 63);
            this.lblEntryBarrier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntryBarrier.Name = "lblEntryBarrier";
            this.lblEntryBarrier.Size = new System.Drawing.Size(105, 31);
            this.lblEntryBarrier.TabIndex = 0;
            this.lblEntryBarrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntrySensor
            // 
            this.lblEntrySensor.BackColor = System.Drawing.Color.White;
            this.lblEntrySensor.Location = new System.Drawing.Point(90, 25);
            this.lblEntrySensor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntrySensor.Name = "lblEntrySensor";
            this.lblEntrySensor.Size = new System.Drawing.Size(105, 31);
            this.lblEntrySensor.TabIndex = 0;
            this.lblEntrySensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Barrier";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 315);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "Spaces";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(16, 265);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Full Sign";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSpaces
            // 
            this.lblSpaces.BackColor = System.Drawing.Color.White;
            this.lblSpaces.Location = new System.Drawing.Point(106, 315);
            this.lblSpaces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpaces.Name = "lblSpaces";
            this.lblSpaces.Size = new System.Drawing.Size(105, 31);
            this.lblSpaces.TabIndex = 0;
            this.lblSpaces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullSign
            // 
            this.lblFullSign.BackColor = System.Drawing.Color.White;
            this.lblFullSign.Location = new System.Drawing.Point(106, 265);
            this.lblFullSign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullSign.Name = "lblFullSign";
            this.lblFullSign.Size = new System.Drawing.Size(105, 31);
            this.lblFullSign.TabIndex = 0;
            this.lblFullSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimulatorInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 614);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimulatorInterface";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Park Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTicketMachine;
        private System.Windows.Forms.Button btnCarEntersCarPark;
        private System.Windows.Forms.Button btnDriverPressesForTicket;
        private System.Windows.Forms.Button btnCarArrivesAtEntrance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTicketValidator;
        private System.Windows.Forms.Button btnCarExitsCarPark;
        private System.Windows.Forms.Button btnDriverEntersTicket;
        private System.Windows.Forms.Button btnCarArrivesAtExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEntrySensor;
        private System.Windows.Forms.Label lblFullSign;
        private System.Windows.Forms.Label lblExitSensor;
        private System.Windows.Forms.Label lblSpaces;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEntryBarrier;
        private System.Windows.Forms.Label lblExitBarrier;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lstActiveTickets;
    }
}

