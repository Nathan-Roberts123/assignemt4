
namespace APP_deve_practical_project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WeightsRadio = new System.Windows.Forms.RadioButton();
            this.GymnasiumRadio = new System.Windows.Forms.RadioButton();
            this.SwimmingPoolRadio = new System.Windows.Forms.RadioButton();
            this.SquashCourtRadio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Radio2hour = new System.Windows.Forms.RadioButton();
            this.Radio90min = new System.Windows.Forms.RadioButton();
            this.Radio1hour = new System.Windows.Forms.RadioButton();
            this.Radio30min = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PublicRadio = new System.Windows.Forms.RadioButton();
            this.StaffRadio = new System.Windows.Forms.RadioButton();
            this.StudentRadio = new System.Windows.Forms.RadioButton();
            this.Calculate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.weekend = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MembershipNumber = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WeightsRadio);
            this.groupBox1.Controls.Add(this.GymnasiumRadio);
            this.groupBox1.Controls.Add(this.SwimmingPoolRadio);
            this.groupBox1.Controls.Add(this.SquashCourtRadio);
            this.groupBox1.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facility";
            // 
            // WeightsRadio
            // 
            this.WeightsRadio.AutoSize = true;
            this.WeightsRadio.Location = new System.Drawing.Point(6, 127);
            this.WeightsRadio.Name = "WeightsRadio";
            this.WeightsRadio.Size = new System.Drawing.Size(79, 23);
            this.WeightsRadio.TabIndex = 0;
            this.WeightsRadio.TabStop = true;
            this.WeightsRadio.Text = "Weights";
            this.WeightsRadio.UseVisualStyleBackColor = true;
            // 
            // GymnasiumRadio
            // 
            this.GymnasiumRadio.AutoSize = true;
            this.GymnasiumRadio.Location = new System.Drawing.Point(6, 95);
            this.GymnasiumRadio.Name = "GymnasiumRadio";
            this.GymnasiumRadio.Size = new System.Drawing.Size(104, 23);
            this.GymnasiumRadio.TabIndex = 0;
            this.GymnasiumRadio.TabStop = true;
            this.GymnasiumRadio.Text = "Gymnasium";
            this.GymnasiumRadio.UseVisualStyleBackColor = true;
            // 
            // SwimmingPoolRadio
            // 
            this.SwimmingPoolRadio.AutoSize = true;
            this.SwimmingPoolRadio.Location = new System.Drawing.Point(6, 62);
            this.SwimmingPoolRadio.Name = "SwimmingPoolRadio";
            this.SwimmingPoolRadio.Size = new System.Drawing.Size(128, 23);
            this.SwimmingPoolRadio.TabIndex = 0;
            this.SwimmingPoolRadio.TabStop = true;
            this.SwimmingPoolRadio.Text = "Swimming Pool";
            this.SwimmingPoolRadio.UseVisualStyleBackColor = true;
            this.SwimmingPoolRadio.CheckedChanged += new System.EventHandler(this.SwimmingPoolRadio_CheckedChanged);
            // 
            // SquashCourtRadio
            // 
            this.SquashCourtRadio.AutoSize = true;
            this.SquashCourtRadio.Location = new System.Drawing.Point(6, 28);
            this.SquashCourtRadio.Name = "SquashCourtRadio";
            this.SquashCourtRadio.Size = new System.Drawing.Size(109, 23);
            this.SquashCourtRadio.TabIndex = 0;
            this.SquashCourtRadio.TabStop = true;
            this.SquashCourtRadio.Text = "Squash Court";
            this.SquashCourtRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Radio2hour);
            this.groupBox2.Controls.Add(this.Radio90min);
            this.groupBox2.Controls.Add(this.Radio1hour);
            this.groupBox2.Controls.Add(this.Radio30min);
            this.groupBox2.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(209, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 173);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duration";
            // 
            // Radio2hour
            // 
            this.Radio2hour.AutoSize = true;
            this.Radio2hour.Location = new System.Drawing.Point(6, 127);
            this.Radio2hour.Name = "Radio2hour";
            this.Radio2hour.Size = new System.Drawing.Size(74, 23);
            this.Radio2hour.TabIndex = 0;
            this.Radio2hour.TabStop = true;
            this.Radio2hour.Text = "2 hours";
            this.Radio2hour.UseVisualStyleBackColor = true;
            // 
            // Radio90min
            // 
            this.Radio90min.AutoSize = true;
            this.Radio90min.Location = new System.Drawing.Point(6, 95);
            this.Radio90min.Name = "Radio90min";
            this.Radio90min.Size = new System.Drawing.Size(75, 23);
            this.Radio90min.TabIndex = 0;
            this.Radio90min.TabStop = true;
            this.Radio90min.Text = "90 min";
            this.Radio90min.UseVisualStyleBackColor = true;
            // 
            // Radio1hour
            // 
            this.Radio1hour.AutoSize = true;
            this.Radio1hour.Location = new System.Drawing.Point(6, 62);
            this.Radio1hour.Name = "Radio1hour";
            this.Radio1hour.Size = new System.Drawing.Size(67, 23);
            this.Radio1hour.TabIndex = 0;
            this.Radio1hour.TabStop = true;
            this.Radio1hour.Text = "1 hour";
            this.Radio1hour.UseVisualStyleBackColor = true;
            this.Radio1hour.CheckedChanged += new System.EventHandler(this.SwimmingPoolRadio_CheckedChanged);
            // 
            // Radio30min
            // 
            this.Radio30min.AutoSize = true;
            this.Radio30min.Location = new System.Drawing.Point(6, 28);
            this.Radio30min.Name = "Radio30min";
            this.Radio30min.Size = new System.Drawing.Size(74, 23);
            this.Radio30min.TabIndex = 0;
            this.Radio30min.TabStop = true;
            this.Radio30min.Text = "30 min";
            this.Radio30min.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PublicRadio);
            this.groupBox3.Controls.Add(this.StaffRadio);
            this.groupBox3.Controls.Add(this.StudentRadio);
            this.groupBox3.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(393, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 130);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Membership Type";
            // 
            // PublicRadio
            // 
            this.PublicRadio.AutoSize = true;
            this.PublicRadio.Location = new System.Drawing.Point(6, 95);
            this.PublicRadio.Name = "PublicRadio";
            this.PublicRadio.Size = new System.Drawing.Size(65, 23);
            this.PublicRadio.TabIndex = 0;
            this.PublicRadio.TabStop = true;
            this.PublicRadio.Text = "Public";
            this.PublicRadio.UseVisualStyleBackColor = true;
            // 
            // StaffRadio
            // 
            this.StaffRadio.AutoSize = true;
            this.StaffRadio.Location = new System.Drawing.Point(6, 62);
            this.StaffRadio.Name = "StaffRadio";
            this.StaffRadio.Size = new System.Drawing.Size(55, 23);
            this.StaffRadio.TabIndex = 0;
            this.StaffRadio.TabStop = true;
            this.StaffRadio.Text = "Staff";
            this.StaffRadio.UseVisualStyleBackColor = true;
            this.StaffRadio.CheckedChanged += new System.EventHandler(this.SwimmingPoolRadio_CheckedChanged);
            // 
            // StudentRadio
            // 
            this.StudentRadio.AutoSize = true;
            this.StudentRadio.Location = new System.Drawing.Point(6, 28);
            this.StudentRadio.Name = "StudentRadio";
            this.StudentRadio.Size = new System.Drawing.Size(75, 23);
            this.StudentRadio.TabIndex = 0;
            this.StudentRadio.TabStop = true;
            this.StudentRadio.Text = "Student";
            this.StudentRadio.UseVisualStyleBackColor = true;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(405, 273);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(145, 23);
            this.Calculate.TabIndex = 1;
            this.Calculate.Text = "  Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(405, 302);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(145, 22);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // weekend
            // 
            this.weekend.AutoSize = true;
            this.weekend.Location = new System.Drawing.Point(443, 248);
            this.weekend.Name = "weekend";
            this.weekend.Size = new System.Drawing.Size(73, 17);
            this.weekend.TabIndex = 2;
            this.weekend.Text = "Weekend";
            this.weekend.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 96);
            this.label1.TabIndex = 3;
            this.label1.Text = "Finess Centre - Bookings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // message
            // 
            this.message.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.message.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(20, 349);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(539, 86);
            this.message.TabIndex = 3;
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Membership Number:";
            // 
            // MembershipNumber
            // 
            this.MembershipNumber.Location = new System.Drawing.Point(163, 121);
            this.MembershipNumber.Name = "MembershipNumber";
            this.MembershipNumber.Size = new System.Drawing.Size(137, 20);
            this.MembershipNumber.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 76);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 458);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MembershipNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.message);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weekend);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton WeightsRadio;
        private System.Windows.Forms.RadioButton GymnasiumRadio;
        private System.Windows.Forms.RadioButton SwimmingPoolRadio;
        private System.Windows.Forms.RadioButton SquashCourtRadio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Radio2hour;
        private System.Windows.Forms.RadioButton Radio90min;
        private System.Windows.Forms.RadioButton Radio1hour;
        private System.Windows.Forms.RadioButton Radio30min;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton PublicRadio;
        private System.Windows.Forms.RadioButton StaffRadio;
        private System.Windows.Forms.RadioButton StudentRadio;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.CheckBox weekend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MembershipNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

