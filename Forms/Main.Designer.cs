namespace TaskManagement
{
    partial class Main
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
            this.cbEmployees = new System.Windows.Forms.ComboBox();
            this.btnEmployeeView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbEmployees
            // 
            this.cbEmployees.FormattingEnabled = true;
            this.cbEmployees.Location = new System.Drawing.Point(76, 44);
            this.cbEmployees.Name = "cbEmployees";
            this.cbEmployees.Size = new System.Drawing.Size(121, 21);
            this.cbEmployees.TabIndex = 0;
            // 
            // btnEmployeeView
            // 
            this.btnEmployeeView.Location = new System.Drawing.Point(281, 44);
            this.btnEmployeeView.Name = "btnEmployeeView";
            this.btnEmployeeView.Size = new System.Drawing.Size(121, 23);
            this.btnEmployeeView.TabIndex = 2;
            this.btnEmployeeView.Text = "Enter employee view";
            this.btnEmployeeView.UseVisualStyleBackColor = true;
            this.btnEmployeeView.Click += new System.EventHandler(this.btnEmployeeView_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmployeeView);
            this.Controls.Add(this.cbEmployees);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEmployees;
        private System.Windows.Forms.Button btnEmployeeView;
    }
}

