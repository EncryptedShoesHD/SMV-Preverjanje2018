namespace Naloga01
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonNaredi = new System.Windows.Forms.Button();
            this.dodajOption = new System.Windows.Forms.RadioButton();
            this.brisiOption = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonNaredi
            // 
            this.buttonNaredi.Location = new System.Drawing.Point(167, 12);
            this.buttonNaredi.Name = "buttonNaredi";
            this.buttonNaredi.Size = new System.Drawing.Size(75, 23);
            this.buttonNaredi.TabIndex = 2;
            this.buttonNaredi.Text = "&Naredi";
            this.buttonNaredi.UseVisualStyleBackColor = true;
            this.buttonNaredi.Click += new System.EventHandler(this.buttonNaredi_Click);
            // 
            // dodajOption
            // 
            this.dodajOption.AutoSize = true;
            this.dodajOption.Checked = true;
            this.dodajOption.Location = new System.Drawing.Point(6, 19);
            this.dodajOption.Name = "dodajOption";
            this.dodajOption.Size = new System.Drawing.Size(53, 17);
            this.dodajOption.TabIndex = 3;
            this.dodajOption.TabStop = true;
            this.dodajOption.Text = "Dodaj";
            this.dodajOption.UseVisualStyleBackColor = true;
            // 
            // brisiOption
            // 
            this.brisiOption.AutoSize = true;
            this.brisiOption.Location = new System.Drawing.Point(6, 42);
            this.brisiOption.Name = "brisiOption";
            this.brisiOption.Size = new System.Drawing.Size(44, 17);
            this.brisiOption.TabIndex = 4;
            this.brisiOption.Text = "Briši";
            this.brisiOption.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dodajOption);
            this.groupBox1.Controls.Add(this.brisiOption);
            this.groupBox1.Location = new System.Drawing.Point(9, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 75);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonNaredi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNaredi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.formShown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonNaredi;
        private System.Windows.Forms.RadioButton dodajOption;
        private System.Windows.Forms.RadioButton brisiOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

