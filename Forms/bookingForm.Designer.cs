namespace RoomBookingSystem
{
    partial class bookingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbForename = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMembers = new System.Windows.Forms.ComboBox();
            this.cbRoomOption = new System.Windows.Forms.ComboBox();
            this.cbEndTime = new System.Windows.Forms.ComboBox();
            this.cbStartTime = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.reset = new System.Windows.Forms.Button();
            this.makeABooking = new System.Windows.Forms.Button();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbSurname);
            this.panel1.Controls.Add(this.tbForename);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbMembers);
            this.panel1.Controls.Add(this.cbRoomOption);
            this.panel1.Controls.Add(this.cbEndTime);
            this.panel1.Controls.Add(this.cbStartTime);
            this.panel1.Controls.Add(this.rtbDescription);
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.makeABooking);
            this.panel1.Location = new System.Drawing.Point(434, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 612);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(196, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Surname";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(200, 307);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(128, 20);
            this.tbSurname.TabIndex = 15;
            // 
            // tbForename
            // 
            this.tbForename.Location = new System.Drawing.Point(7, 307);
            this.tbForename.Name = "tbForename";
            this.tbForename.Size = new System.Drawing.Size(127, 20);
            this.tbForename.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Description (Max 150 Chars.)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Forename";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Room Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total Members";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "End Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Start Time";
            // 
            // cbMembers
            // 
            this.cbMembers.FormattingEnabled = true;
            this.cbMembers.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbMembers.Location = new System.Drawing.Point(34, 158);
            this.cbMembers.Name = "cbMembers";
            this.cbMembers.Size = new System.Drawing.Size(266, 21);
            this.cbMembers.TabIndex = 6;
            // 
            // cbRoomOption
            // 
            this.cbRoomOption.FormattingEnabled = true;
            this.cbRoomOption.Items.AddRange(new object[] {
            "Meeting Room #1",
            "Meeting Room #2",
            "Meeting Room #3",
            "Meeting Room #4",
            "Meeting Room #5"});
            this.cbRoomOption.Location = new System.Drawing.Point(34, 228);
            this.cbRoomOption.Name = "cbRoomOption";
            this.cbRoomOption.Size = new System.Drawing.Size(266, 21);
            this.cbRoomOption.TabIndex = 5;
            // 
            // cbEndTime
            // 
            this.cbEndTime.FormattingEnabled = true;
            this.cbEndTime.Items.AddRange(new object[] {
            "8:00AM",
            "8:30AM",
            "9:00AM",
            "9:30AM",
            "10:00AM",
            "10:30AM",
            "11:00AM",
            "11:30AM",
            "12:00AM",
            "12:30PM",
            "1:00PM",
            "1:30PM",
            "2:00PM",
            "2:30PM",
            "3:00PM",
            "3:30PM",
            "4:00PM",
            "4:30PM",
            "5:00PM"});
            this.cbEndTime.Location = new System.Drawing.Point(188, 71);
            this.cbEndTime.Name = "cbEndTime";
            this.cbEndTime.Size = new System.Drawing.Size(140, 21);
            this.cbEndTime.TabIndex = 4;
            // 
            // cbStartTime
            // 
            this.cbStartTime.FormattingEnabled = true;
            this.cbStartTime.Items.AddRange(new object[] {
            "8:00AM",
            "8:30AM",
            "9:00AM",
            "9:30AM",
            "10:00AM",
            "10:30AM",
            "11:00AM",
            "11:30AM",
            "12:00AM",
            "12:30PM",
            "1:00PM",
            "1:30PM",
            "2:00PM",
            "2:30PM",
            "3:00PM",
            "3:30PM",
            "4:00PM",
            "4:30PM",
            "5:00PM",
            ""});
            this.cbStartTime.Location = new System.Drawing.Point(3, 71);
            this.cbStartTime.Name = "cbStartTime";
            this.cbStartTime.Size = new System.Drawing.Size(140, 21);
            this.cbStartTime.TabIndex = 3;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(34, 372);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(267, 105);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(91, 561);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(153, 46);
            this.reset.TabIndex = 1;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // makeABooking
            // 
            this.makeABooking.Location = new System.Drawing.Point(91, 503);
            this.makeABooking.Name = "makeABooking";
            this.makeABooking.Size = new System.Drawing.Size(153, 46);
            this.makeABooking.TabIndex = 0;
            this.makeABooking.Text = "Make a Booking";
            this.makeABooking.UseVisualStyleBackColor = true;
            this.makeABooking.Click += new System.EventHandler(this.makeABooking_Click);
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Location = new System.Drawing.Point(12, 59);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBookingDate.TabIndex = 3;
            // 
            // bookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 635);
            this.Controls.Add(this.dtpBookingDate);
            this.Controls.Add(this.panel1);
            this.Name = "bookingForm";
            this.Text = "bookingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bookingForm_FormClosing);
            this.Load += new System.EventHandler(this.bookingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMembers;
        private System.Windows.Forms.ComboBox cbRoomOption;
        private System.Windows.Forms.ComboBox cbEndTime;
        private System.Windows.Forms.ComboBox cbStartTime;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button makeABooking;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbForename;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
    }
}