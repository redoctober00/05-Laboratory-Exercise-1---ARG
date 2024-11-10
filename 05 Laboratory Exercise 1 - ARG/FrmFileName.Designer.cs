namespace _05_Laboratory_Exercise_1___ARG
{
    partial class FrmFileName
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
            txtFileName = new TextBox();
            btnOkay = new Button();
            SuspendLayout();
            // 
            // txtFileName
            // 
            txtFileName.Font = new Font("Segoe UI", 20F);
            txtFileName.Location = new Point(62, 79);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(273, 52);
            txtFileName.TabIndex = 0;
            // 
            // btnOkay
            // 
            btnOkay.Location = new Point(124, 172);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(138, 46);
            btnOkay.TabIndex = 1;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnOkay_Click;
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 302);
            Controls.Add(btnOkay);
            Controls.Add(txtFileName);
            Name = "FrmFileName";
            Text = "FrmFileName";
            Load += FrmFileName_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFileName;
        private Button btnOkay;
    }
}