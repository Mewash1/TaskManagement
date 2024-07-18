namespace TaskManagement.Forms
{
    partial class DeleteTask
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
            this.cbTaskID = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTaskID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTaskID
            // 
            this.cbTaskID.FormattingEnabled = true;
            this.cbTaskID.Location = new System.Drawing.Point(171, 112);
            this.cbTaskID.Name = "cbTaskID";
            this.cbTaskID.Size = new System.Drawing.Size(121, 21);
            this.cbTaskID.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(364, 83);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(179, 76);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTaskID
            // 
            this.lblTaskID.AutoSize = true;
            this.lblTaskID.Location = new System.Drawing.Point(46, 115);
            this.lblTaskID.Name = "lblTaskID";
            this.lblTaskID.Size = new System.Drawing.Size(74, 13);
            this.lblTaskID.TabIndex = 2;
            this.lblTaskID.Text = "Select task ID";
            // 
            // DeleteTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 276);
            this.Controls.Add(this.lblTaskID);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbTaskID);
            this.Name = "DeleteTask";
            this.Text = "DeleteTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTaskID;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTaskID;
    }
}