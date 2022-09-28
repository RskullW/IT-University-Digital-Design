namespace DigitalDesign
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HelpMessage = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.InputN = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HelpMessage);
            this.panel1.Controls.Add(this.CreateButton);
            this.panel1.Controls.Add(this.InputN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // HelpMessage
            // 
            this.HelpMessage.BackColor = System.Drawing.SystemColors.MenuBar;
            this.HelpMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HelpMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpMessage.Location = new System.Drawing.Point(199, 76);
            this.HelpMessage.Multiline = true;
            this.HelpMessage.Name = "HelpMessage";
            this.HelpMessage.Size = new System.Drawing.Size(521, 23);
            this.HelpMessage.TabIndex = 2;
            this.HelpMessage.Text = "Введите число N (количество линий до 10)";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(298, 157);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(223, 42);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "Создать сейф";
            this.CreateButton.UseVisualStyleBackColor = true;
            // 
            // InputN
            // 
            this.InputN.Location = new System.Drawing.Point(342, 105);
            this.InputN.Name = "InputN";
            this.InputN.Size = new System.Drawing.Size(133, 22);
            this.InputN.TabIndex = 0;
            this.InputN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputN_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox HelpMessage;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TextBox InputN;
        private System.Windows.Forms.Button CreateButton;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}