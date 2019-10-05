namespace MegaDesk_Tinker
{
    partial class AddQuote
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
            this.backToMainMenuButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.materialDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.depthBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.drawerBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rushDaysDropDown = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.getQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backToMainMenuButton
            // 
            this.backToMainMenuButton.Location = new System.Drawing.Point(140, 239);
            this.backToMainMenuButton.Name = "backToMainMenuButton";
            this.backToMainMenuButton.Size = new System.Drawing.Size(115, 35);
            this.backToMainMenuButton.TabIndex = 1;
            this.backToMainMenuButton.Text = "Back to Main Menu";
            this.backToMainMenuButton.UseVisualStyleBackColor = true;
            this.backToMainMenuButton.Click += new System.EventHandler(this.backToMainMenuButton_Click);
            // 
            // materialDropDown
            // 
            this.materialDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialDropDown.FormattingEnabled = true;
            this.materialDropDown.Location = new System.Drawing.Point(140, 24);
            this.materialDropDown.Name = "materialDropDown";
            this.materialDropDown.Size = new System.Drawing.Size(99, 21);
            this.materialDropDown.TabIndex = 3;
            this.materialDropDown.SelectedIndexChanged += new System.EventHandler(this.materialDropDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width";
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(12, 180);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 5;
            this.widthBox.TextChanged += new System.EventHandler(this.widthBox_TextChanged);
            this.widthBox.Validating += new System.ComponentModel.CancelEventHandler(this.widthBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Material";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(12, 63);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 7;
            this.heightBox.Validating += new System.ComponentModel.CancelEventHandler(this.heightBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Height";
            // 
            // depthBox
            // 
            this.depthBox.Location = new System.Drawing.Point(12, 102);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(100, 20);
            this.depthBox.TabIndex = 9;
            this.depthBox.Validating += new System.ComponentModel.CancelEventHandler(this.depthBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Depth";
            // 
            // drawerBox
            // 
            this.drawerBox.Location = new System.Drawing.Point(12, 141);
            this.drawerBox.Name = "drawerBox";
            this.drawerBox.Size = new System.Drawing.Size(100, 20);
            this.drawerBox.TabIndex = 11;
            this.drawerBox.Validating += new System.ComponentModel.CancelEventHandler(this.drawerBox_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Drawers";
            // 
            // rushDaysDropDown
            // 
            this.rushDaysDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rushDaysDropDown.FormattingEnabled = true;
            this.rushDaysDropDown.Items.AddRange(new object[] {
            "0",
            "3",
            "5",
            "7"});
            this.rushDaysDropDown.Location = new System.Drawing.Point(140, 73);
            this.rushDaysDropDown.Name = "rushDaysDropDown";
            this.rushDaysDropDown.Size = new System.Drawing.Size(99, 21);
            this.rushDaysDropDown.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rush Days";
            // 
            // customerNameBox
            // 
            this.customerNameBox.Location = new System.Drawing.Point(12, 24);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(100, 20);
            this.customerNameBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Customer Name";
            // 
            // getQuote
            // 
            this.getQuote.Location = new System.Drawing.Point(12, 239);
            this.getQuote.Name = "getQuote";
            this.getQuote.Size = new System.Drawing.Size(115, 35);
            this.getQuote.TabIndex = 17;
            this.getQuote.Text = "Get Quote";
            this.getQuote.UseVisualStyleBackColor = true;
            this.getQuote.Click += new System.EventHandler(this.getQuote_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 291);
            this.Controls.Add(this.getQuote);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rushDaysDropDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.drawerBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depthBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialDropDown);
            this.Controls.Add(this.backToMainMenuButton);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToMainMenuButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox materialDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox depthBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox drawerBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox rushDaysDropDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button getQuote;
    }
}