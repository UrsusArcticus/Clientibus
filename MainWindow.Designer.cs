namespace Clientibus
{
    partial class MainWindow
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
        private void InitializeComponent() {
            tabControl1 = new TabControl();
            customersTabPage = new TabPage();
            newCustomerBtn = new Button();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(customersTabPage);
            tabControl1.Location = new Point(12, 64);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1141, 695);
            tabControl1.TabIndex = 0;
            // 
            // customersTabPage
            // 
            customersTabPage.Location = new Point(4, 34);
            customersTabPage.Name = "customersTabPage";
            customersTabPage.Padding = new Padding(3);
            customersTabPage.Size = new Size(1133, 657);
            customersTabPage.TabIndex = 0;
            customersTabPage.Text = "Customers";
            customersTabPage.UseVisualStyleBackColor = true;
            // 
            // newCustomerBtn
            // 
            newCustomerBtn.Location = new Point(12, 12);
            newCustomerBtn.Name = "newCustomerBtn";
            newCustomerBtn.Size = new Size(168, 34);
            newCustomerBtn.TabIndex = 1;
            newCustomerBtn.Text = "New Customer";
            newCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 771);
            Controls.Add(newCustomerBtn);
            Controls.Add(tabControl1);
            Name = "MainWindow";
            Text = "Clientibus";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage customersTabPage;
        private Button newCustomerBtn;
    }
}
