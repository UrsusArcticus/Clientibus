namespace Clientibus {
    partial class CustomerDataControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            labelLastName = new Label();
            textBoxEmail = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            labelAddress = new Label();
            textBox5 = new TextBox();
            labelCity = new Label();
            labelZip = new Label();
            textBox6 = new TextBox();
            checkBoxActive = new CheckBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(382, 31);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 18);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(161, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(382, 31);
            textBox2.TabIndex = 2;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(45, 77);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(95, 25);
            labelLastName.TabIndex = 3;
            labelLastName.Text = "Last Name";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(161, 140);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(382, 31);
            textBoxEmail.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(161, 198);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(382, 31);
            textBox3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 146);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 6;
            label2.Text = "E-Mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 201);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 7;
            label3.Text = "Telephone";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(161, 261);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(382, 31);
            textBox4.TabIndex = 8;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(63, 261);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(77, 25);
            labelAddress.TabIndex = 9;
            labelAddress.Text = "Address";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(161, 332);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(233, 31);
            textBox5.TabIndex = 10;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(89, 332);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(42, 25);
            labelCity.TabIndex = 11;
            labelCity.Text = "City";
            // 
            // labelZip
            // 
            labelZip.AutoSize = true;
            labelZip.Location = new Point(400, 335);
            labelZip.Name = "labelZip";
            labelZip.Size = new Size(37, 25);
            labelZip.TabIndex = 12;
            labelZip.Text = "Zip";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(443, 329);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 31);
            textBox6.TabIndex = 13;
            // 
            // checkBoxActive
            // 
            checkBoxActive.AutoSize = true;
            checkBoxActive.Checked = true;
            checkBoxActive.CheckState = CheckState.Checked;
            checkBoxActive.Location = new Point(161, 387);
            checkBoxActive.Name = "checkBoxActive";
            checkBoxActive.Size = new Size(101, 29);
            checkBoxActive.TabIndex = 14;
            checkBoxActive.Text = "Is active";
            checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(161, 458);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(382, 260);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // CustomerControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(richTextBox1);
            Controls.Add(checkBoxActive);
            Controls.Add(textBox6);
            Controls.Add(labelZip);
            Controls.Add(labelCity);
            Controls.Add(textBox5);
            Controls.Add(labelAddress);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBoxEmail);
            Controls.Add(labelLastName);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "CustomerControl";
            Size = new Size(624, 808);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label labelLastName;
        private TextBox textBoxEmail;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private Label labelAddress;
        private TextBox textBox5;
        private Label labelCity;
        private Label labelZip;
        private TextBox textBox6;
        private CheckBox checkBoxActive;
        private RichTextBox richTextBox1;
    }
}
