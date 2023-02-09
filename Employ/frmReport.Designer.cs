namespace Employ
{
    partial class frmReport
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
            this.p_card = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_photo = new System.Windows.Forms.PictureBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_position = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gt_emp = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btA_act = new System.Windows.Forms.Button();
            this.btprint = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_serach_id = new System.Windows.Forms.TextBox();
            this.p_card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gt_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // p_card
            // 
            this.p_card.Controls.Add(this.panel3);
            this.p_card.Controls.Add(this.panel1);
            this.p_card.Controls.Add(this.lbl_position);
            this.p_card.Controls.Add(this.lbl_sex);
            this.p_card.Controls.Add(this.lbl_name);
            this.p_card.Controls.Add(this.lbl_id);
            this.p_card.Controls.Add(this.pic_photo);
            this.p_card.Location = new System.Drawing.Point(13, 48);
            this.p_card.Name = "p_card";
            this.p_card.Size = new System.Drawing.Size(199, 262);
            this.p_card.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Print Card";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Location = new System.Drawing.Point(12, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 3);
            this.panel2.TabIndex = 4;
            // 
            // pic_photo
            // 
            this.pic_photo.Location = new System.Drawing.Point(50, 31);
            this.pic_photo.Name = "pic_photo";
            this.pic_photo.Size = new System.Drawing.Size(100, 50);
            this.pic_photo.TabIndex = 0;
            this.pic_photo.TabStop = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(17, 106);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "ID ";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(17, 131);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name";
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Location = new System.Drawing.Point(17, 159);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(25, 13);
            this.lbl_sex.TabIndex = 3;
            this.lbl_sex.Text = "Sex";
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Location = new System.Drawing.Point(17, 185);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(44, 13);
            this.lbl_position.TabIndex = 4;
            this.lbl_position.Text = "Position";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 21);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 20);
            this.panel3.TabIndex = 6;
            // 
            // gt_emp
            // 
            this.gt_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gt_emp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.gt_emp.Location = new System.Drawing.Point(218, 48);
            this.gt_emp.Name = "gt_emp";
            this.gt_emp.Size = new System.Drawing.Size(518, 262);
            this.gt_emp.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sex";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Position";
            this.Column4.Name = "Column4";
            // 
            // btA_act
            // 
            this.btA_act.Location = new System.Drawing.Point(12, 317);
            this.btA_act.Name = "btA_act";
            this.btA_act.Size = new System.Drawing.Size(75, 23);
            this.btA_act.TabIndex = 7;
            this.btA_act.Text = "Attact";
            this.btA_act.UseVisualStyleBackColor = true;
            // 
            // btprint
            // 
            this.btprint.Location = new System.Drawing.Point(137, 317);
            this.btprint.Name = "btprint";
            this.btprint.Size = new System.Drawing.Size(75, 23);
            this.btprint.TabIndex = 8;
            this.btprint.Text = "Print";
            this.btprint.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Filter by ID";
            // 
            // txt_serach_id
            // 
            this.txt_serach_id.Location = new System.Drawing.Point(306, 22);
            this.txt_serach_id.Name = "txt_serach_id";
            this.txt_serach_id.Size = new System.Drawing.Size(201, 20);
            this.txt_serach_id.TabIndex = 10;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 368);
            this.Controls.Add(this.txt_serach_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btprint);
            this.Controls.Add(this.btA_act);
            this.Controls.Add(this.gt_emp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.p_card);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.p_card.ResumeLayout(false);
            this.p_card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gt_emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_card;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_photo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.DataGridView gt_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btA_act;
        private System.Windows.Forms.Button btprint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_serach_id;
    }
}