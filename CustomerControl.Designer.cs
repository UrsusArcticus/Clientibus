namespace Clientibus {
    partial class CustomerControl {
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
            textBoxFirstName = new TextBox();
            label1 = new Label();
            textBoxLastName = new TextBox();
            labelLastName = new Label();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxAddress = new TextBox();
            labelAddress = new Label();
            textBoxCity = new TextBox();
            labelCity = new Label();
            labelZip = new Label();
            textBoxZip = new TextBox();
            checkBoxActive = new CheckBox();
            richTextBoxDescription = new RichTextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(161, 18);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(382, 31);
            textBoxFirstName.TabIndex = 0;
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
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(161, 77);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(382, 31);
            textBoxLastName.TabIndex = 2;
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
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(161, 198);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(382, 31);
            textBoxPhone.TabIndex = 5;
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
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(161, 261);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(382, 31);
            textBoxAddress.TabIndex = 8;
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
            // textBoxCity
            // 
            textBoxCity.Location = new Point(161, 332);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(233, 31);
            textBoxCity.TabIndex = 10;
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
            // textBoxZip
            // 
            textBoxZip.Location = new Point(443, 329);
            textBoxZip.Name = "textBoxZip";
            textBoxZip.Size = new Size(100, 31);
            textBoxZip.TabIndex = 13;
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
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(161, 458);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(382, 260);
            richTextBoxDescription.TabIndex = 15;
            richTextBoxDescription.Text = "";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1294, 899);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += this.btnSave_Click;
            // 
            // CustomerControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSave);
            Controls.Add(richTextBoxDescription);
            Controls.Add(checkBoxActive);
            Controls.Add(textBoxZip);
            Controls.Add(labelZip);
            Controls.Add(labelCity);
            Controls.Add(textBoxCity);
            Controls.Add(labelAddress);
            Controls.Add(textBoxAddress);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(labelLastName);
            Controls.Add(textBoxLastName);
            Controls.Add(label1);
            Controls.Add(textBoxFirstName);
            Name = "CustomerControl";
            Size = new Size(1426, 952);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirstName;
        private Label label1;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private Label label2;
        private Label label3;
        private TextBox textBoxAddress;
        private Label labelAddress;
        private TextBox textBoxCity;
        private Label labelCity;
        private Label labelZip;
        private TextBox textBoxZip;
        private CheckBox checkBoxActive;
        private RichTextBox richTextBoxDescription;
        private Button btnSave;
    }
}
