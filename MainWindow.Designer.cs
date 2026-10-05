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
            mainTabControl = new TabControl();
            customersTabPage = new TabPage();
            newCustomerBtn = new Button();
            mainTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainTabControl.Controls.Add(customersTabPage);
            mainTabControl.Location = new Point(12, 64);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(1141, 695);
            mainTabControl.TabIndex = 0;
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
            newCustomerBtn.Click += newCustomerBtn_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 771);
            Controls.Add(newCustomerBtn);
            Controls.Add(mainTabControl);
            Name = "MainWindow";
            Text = "Clientibus";
            mainTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainTabControl;
        private TabPage customersTabPage;
        private Button newCustomerBtn;
    }
}
