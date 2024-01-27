namespace Traffic_Light_Project
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
            this.ucTrafficLight4 = new Traffic_Light_Project.ucTrafficLight();
            this.ucTrafficLight3 = new Traffic_Light_Project.ucTrafficLight();
            this.ucTrafficLight2 = new Traffic_Light_Project.ucTrafficLight();
            this.ucTrafficLight1 = new Traffic_Light_Project.ucTrafficLight();
            this.SuspendLayout();
            // 
            // ucTrafficLight4
            // 
            this.ucTrafficLight4.BackColor = System.Drawing.Color.Transparent;
            this.ucTrafficLight4.CurrentLight = Traffic_Light_Project.ucTrafficLight.enTrafficLight.Red;
            this.ucTrafficLight4.GreenTime = 5;
            this.ucTrafficLight4.Location = new System.Drawing.Point(805, 246);
            this.ucTrafficLight4.Name = "ucTrafficLight4";
            this.ucTrafficLight4.OrangeTime = 3;
            this.ucTrafficLight4.RedTime = 5;
            this.ucTrafficLight4.Size = new System.Drawing.Size(180, 226);
            this.ucTrafficLight4.TabIndex = 3;
            this.ucTrafficLight4.RedLightOn += new System.EventHandler<Traffic_Light_Project.ucTrafficLight.TrafficLightEventHandler>(this.ucTrafficLight4_RedLightOn);
            this.ucTrafficLight4.GreenLightOff += new System.EventHandler<Traffic_Light_Project.ucTrafficLight.TrafficLightEventHandler>(this.ucTrafficLight4_GreenLightOff);
            // 
            // ucTrafficLight3
            // 
            this.ucTrafficLight3.BackColor = System.Drawing.Color.Transparent;
            this.ucTrafficLight3.CurrentLight = Traffic_Light_Project.ucTrafficLight.enTrafficLight.Red;
            this.ucTrafficLight3.GreenTime = 5;
            this.ucTrafficLight3.Location = new System.Drawing.Point(603, 239);
            this.ucTrafficLight3.Name = "ucTrafficLight3";
            this.ucTrafficLight3.OrangeTime = 3;
            this.ucTrafficLight3.RedTime = 5;
            this.ucTrafficLight3.Size = new System.Drawing.Size(180, 210);
            this.ucTrafficLight3.TabIndex = 2;
            this.ucTrafficLight3.RedLightOn += new System.EventHandler<Traffic_Light_Project.ucTrafficLight.TrafficLightEventHandler>(this.ucTrafficLight3_RedLightOn);
            this.ucTrafficLight3.GreenLightOff += new System.EventHandler<Traffic_Light_Project.ucTrafficLight.TrafficLightEventHandler>(this.ucTrafficLight3_GreenLightOff);
            // 
            // ucTrafficLight2
            // 
            this.ucTrafficLight2.BackColor = System.Drawing.Color.Transparent;
            this.ucTrafficLight2.CurrentLight = Traffic_Light_Project.ucTrafficLight.enTrafficLight.Red;
            this.ucTrafficLight2.GreenTime = 5;
            this.ucTrafficLight2.Location = new System.Drawing.Point(217, 196);
            this.ucTrafficLight2.Name = "ucTrafficLight2";
            this.ucTrafficLight2.OrangeTime = 3;
            this.ucTrafficLight2.RedTime = 5;
            this.ucTrafficLight2.Size = new System.Drawing.Size(180, 300);
            this.ucTrafficLight2.TabIndex = 1;
            this.ucTrafficLight2.RedLightOn += new System.EventHandler<Traffic_Light_Project.ucTrafficLight.TrafficLightEventHandler>(this.ucTrafficLight2_RedLightOn);
            this.ucTrafficLight2.GreenLightOff += new System.EventHandler<Traffic_Light_Project.ucTrafficLight.TrafficLightEventHandler>(this.ucTrafficLight2_GreenLightOff);
            // 
            // ucTrafficLight1
            // 
            this.ucTrafficLight1.BackColor = System.Drawing.Color.Transparent;
            this.ucTrafficLight1.CurrentLight = Traffic_Light_Project.ucTrafficLight.enTrafficLight.Red;
            this.ucTrafficLight1.GreenTime = 5;
            this.ucTrafficLight1.Location = new System.Drawing.Point(12, 254);
            this.ucTrafficLight1.Name = "ucTrafficLight1";
            this.ucTrafficLight1.OrangeTime = 3;
            this.ucTrafficLight1.RedTime = 5;
            this.ucTrafficLight1.Size = new System.Drawing.Size(180, 210);
            this.ucTrafficLight1.TabIndex = 0;
            this.ucTrafficLight1.RedLightOn += new System.EventHandler<Traffic_Light_Project.ucTrafficLight.TrafficLightEventHandler>(this.ucTrafficLight1_RedLightOn);
            this.ucTrafficLight1.GreenLightOff += new System.EventHandler<Traffic_Light_Project.ucTrafficLight.TrafficLightEventHandler>(this.ucTrafficLight1_GreenLightOff);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Traffic_Light_Project.Properties.Resources.streets_crossing_in_modern_vector_20665053;
            this.ClientSize = new System.Drawing.Size(972, 776);
            this.Controls.Add(this.ucTrafficLight4);
            this.Controls.Add(this.ucTrafficLight3);
            this.Controls.Add(this.ucTrafficLight2);
            this.Controls.Add(this.ucTrafficLight1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Traffic Light";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucTrafficLight ucTrafficLight1;
        private ucTrafficLight ucTrafficLight2;
        private ucTrafficLight ucTrafficLight3;
        private ucTrafficLight ucTrafficLight4;
    }
}

