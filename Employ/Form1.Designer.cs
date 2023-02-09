namespace Employ
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
            this.pNavigation = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pContainer = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btback = new System.Windows.Forms.Button();
            this.pNavigation.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 3);
            this.panel1.TabIndex = 0;
            // 
            // pNavigation
            // 
            this.pNavigation.BackColor = System.Drawing.Color.Turquoise;
            this.pNavigation.Controls.Add(this.button3);
            this.pNavigation.Controls.Add(this.button2);
            this.pNavigation.Controls.Add(this.button1);
            this.pNavigation.Controls.Add(this.panel2);
            this.pNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pNavigation.Location = new System.Drawing.Point(0, 3);
            this.pNavigation.Name = "pNavigation";
            this.pNavigation.Size = new System.Drawing.Size(150, 475);
            this.pNavigation.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.btback);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 475);
            this.panel2.TabIndex = 0;
            // 
            // pContainer
            // 
            this.pContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(150, 3);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(721, 475);
            this.pContainer.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Employ.Properties.Resources.Add;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(44, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Report";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Employ.Properties.Resources.Add;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(44, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "View Emp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Employ.Properties.Resources.Add;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(44, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADD EMP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btback
            // 
            this.btback.FlatAppearance.BorderSize = 0;
            this.btback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btback.Image = global::Employ.Properties.Resources.back;
            this.btback.Location = new System.Drawing.Point(0, 154);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(45, 30);
            this.btback.TabIndex = 0;
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 478);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.pNavigation);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pNavigation.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pNavigation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

