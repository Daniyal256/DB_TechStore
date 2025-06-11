namespace WinFormsApp1
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            tbID = new TextBox();
            tbEmail = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 51);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Choose your role: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 103);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter UserID: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 163);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Enter email: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Customer", "Employee", "Manager" });
            comboBox1.Location = new Point(257, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // tbID
            // 
            tbID.Location = new Point(257, 103);
            tbID.Name = "tbID";
            tbID.Size = new Size(100, 23);
            tbID.TabIndex = 4;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(257, 163);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(100, 23);
            tbEmail.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(216, 260);
            button1.Name = "button1";
            button1.Size = new Size(98, 45);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(tbEmail);
            Controls.Add(tbID);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox tbID;
        private TextBox tbEmail;
        private Button button1;
    }
}