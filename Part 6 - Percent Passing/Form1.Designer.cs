namespace Part_6___Percent_Passing
{
    partial class frmGrades
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtGrades = new System.Windows.Forms.TextBox();
            this.lblGradesInstructions = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(80, 32);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtGrades
            // 
            this.txtGrades.Location = new System.Drawing.Point(116, 6);
            this.txtGrades.Name = "txtGrades";
            this.txtGrades.Size = new System.Drawing.Size(100, 20);
            this.txtGrades.TabIndex = 1;
            // 
            // lblGradesInstructions
            // 
            this.lblGradesInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblGradesInstructions.Name = "lblGradesInstructions";
            this.lblGradesInstructions.Size = new System.Drawing.Size(100, 55);
            this.lblGradesInstructions.TabIndex = 2;
            this.lblGradesInstructions.Text = "Enter Grades Here:\r\n65% = 65\r\n";
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(1, 79);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(227, 114);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(226, 170);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(80, 67);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 191);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblGradesInstructions);
            this.Controls.Add(this.txtGrades);
            this.Name = "frmGrades";
            this.Text = "Percentage Passing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtGrades;
        private System.Windows.Forms.Label lblGradesInstructions;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDone;
    }
}

