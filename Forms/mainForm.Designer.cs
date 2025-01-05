namespace RoomBookingSystem
{
    partial class mainForm
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
            this.makeBooking = new System.Windows.Forms.Button();
            this.cancelBooking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // makeBooking
            // 
            this.makeBooking.Location = new System.Drawing.Point(245, 203);
            this.makeBooking.Name = "makeBooking";
            this.makeBooking.Size = new System.Drawing.Size(101, 66);
            this.makeBooking.TabIndex = 0;
            this.makeBooking.Text = "Make a Booking";
            this.makeBooking.UseVisualStyleBackColor = true;
            this.makeBooking.Click += new System.EventHandler(this.makeBooking_Click);
            // 
            // cancelBooking
            // 
            this.cancelBooking.Location = new System.Drawing.Point(470, 203);
            this.cancelBooking.Name = "cancelBooking";
            this.cancelBooking.Size = new System.Drawing.Size(101, 66);
            this.cancelBooking.TabIndex = 1;
            this.cancelBooking.Text = "Cancel a Booking";
            this.cancelBooking.UseVisualStyleBackColor = true;
            this.cancelBooking.Click += new System.EventHandler(this.cancelBooking_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 496);
            this.Controls.Add(this.cancelBooking);
            this.Controls.Add(this.makeBooking);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button makeBooking;
        private System.Windows.Forms.Button cancelBooking;
    }
}

