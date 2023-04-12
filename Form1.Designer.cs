namespace app_Cs_firstStep
{
    partial class Form1
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
            this.buttonClickHere = new System.Windows.Forms.Button();
            this.labelResultClickHEre = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonClickHere
            // 
            this.buttonClickHere.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonClickHere.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClickHere.Location = new System.Drawing.Point(12, 386);
            this.buttonClickHere.Name = "buttonClickHere";
            this.buttonClickHere.Size = new System.Drawing.Size(776, 52);
            this.buttonClickHere.TabIndex = 0;
            this.buttonClickHere.Text = "Click Here!";
            this.buttonClickHere.UseVisualStyleBackColor = false;
            this.buttonClickHere.Click += new System.EventHandler(this.buttonClickHere_Click);
            // 
            // labelResultClickHEre
            // 
            this.labelResultClickHEre.AutoSize = true;
            this.labelResultClickHEre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResultClickHEre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelResultClickHEre.Location = new System.Drawing.Point(298, 61);
            this.labelResultClickHEre.Name = "labelResultClickHEre";
            this.labelResultClickHEre.Size = new System.Drawing.Size(58, 25);
            this.labelResultClickHEre.TabIndex = 1;
            this.labelResultClickHEre.Text = "None";
            this.labelResultClickHEre.Click += new System.EventHandler(this.labelResultClickHEre_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Ok",
            "NonOk",
            "Repass",
            "Try"});
            this.checkedListBox1.Location = new System.Drawing.Point(31, 77);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(161, 202);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResultClickHEre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.buttonClickHere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClickHere;
        private System.Windows.Forms.Label labelResultClickHEre;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

