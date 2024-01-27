namespace Traffic_Light_Project
{
    partial class ucTrafficLight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTrafficTimeInSeconed = new System.Windows.Forms.Label();
            this.pbTrafficImage = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrafficTimeInSeconed
            // 
            this.lblTrafficTimeInSeconed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrafficTimeInSeconed.AutoSize = true;
            this.lblTrafficTimeInSeconed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrafficTimeInSeconed.ForeColor = System.Drawing.Color.Red;
            this.lblTrafficTimeInSeconed.Location = new System.Drawing.Point(77, 208);
            this.lblTrafficTimeInSeconed.Name = "lblTrafficTimeInSeconed";
            this.lblTrafficTimeInSeconed.Size = new System.Drawing.Size(24, 21);
            this.lblTrafficTimeInSeconed.TabIndex = 1;
            this.lblTrafficTimeInSeconed.Text = "??";
            this.lblTrafficTimeInSeconed.Visible = false;
            // 
            // pbTrafficImage
            // 
            this.pbTrafficImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbTrafficImage.Image = global::Traffic_Light_Project.Properties.Resources.Red;
            this.pbTrafficImage.Location = new System.Drawing.Point(11, 3);
            this.pbTrafficImage.Name = "pbTrafficImage";
            this.pbTrafficImage.Size = new System.Drawing.Size(159, 202);
            this.pbTrafficImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrafficImage.TabIndex = 0;
            this.pbTrafficImage.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTrafficTimeInSeconed);
            this.Controls.Add(this.pbTrafficImage);
            this.Name = "ucTrafficLight";
            this.Size = new System.Drawing.Size(180, 250);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrafficImage;
        private System.Windows.Forms.Label lblTrafficTimeInSeconed;
        private System.Windows.Forms.Timer timer1;
    }
}
