namespace VUMTS
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelDistance = new Label();
            textBoxDistance = new TextBox();
            buttonUltrasonic = new Button();
            SuspendLayout();
            // 
            // labelDistance
            // 
            labelDistance.AutoSize = true;
            labelDistance.Location = new Point(12, 9);
            labelDistance.Name = "labelDistance";
            labelDistance.Size = new Size(146, 15);
            labelDistance.TabIndex = 0;
            labelDistance.Text = "Ultrasonic Distance Sensor";
            labelDistance.UseMnemonic = false;
            // 
            // textBoxDistance
            // 
            textBoxDistance.Location = new Point(12, 27);
            textBoxDistance.Name = "textBoxDistance";
            textBoxDistance.ReadOnly = true;
            textBoxDistance.Size = new Size(260, 23);
            textBoxDistance.TabIndex = 1;
            // 
            // buttonStartUltrasonic
            // 
            buttonUltrasonic.Location = new Point(12, 56);
            buttonUltrasonic.Name = "buttonStartUltrasonic";
            buttonUltrasonic.Size = new Size(260, 23);
            buttonUltrasonic.TabIndex = 2;
            buttonUltrasonic.Text = "Start Measurements";
            buttonUltrasonic.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 96);
            Controls.Add(buttonUltrasonic);
            Controls.Add(textBoxDistance);
            Controls.Add(labelDistance);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            Text = "Ultibot Maintenance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDistance;
        private TextBox textBoxDistance;
        private Button buttonUltrasonic;
    }
}
