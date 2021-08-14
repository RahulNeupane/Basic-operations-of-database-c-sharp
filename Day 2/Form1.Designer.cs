namespace Day_2
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
            this.std_name = new System.Windows.Forms.TextBox();
            this.std_address = new System.Windows.Forms.TextBox();
            this.Std_list = new System.Windows.Forms.DataGridView();
            this.stdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.photo = new System.Windows.Forms.PictureBox();
            this.Selectphoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Std_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // std_name
            // 
            this.std_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_name.Location = new System.Drawing.Point(9, 36);
            this.std_name.Name = "std_name";
            this.std_name.Size = new System.Drawing.Size(204, 26);
            this.std_name.TabIndex = 1;
            // 
            // std_address
            // 
            this.std_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_address.Location = new System.Drawing.Point(10, 94);
            this.std_address.Name = "std_address";
            this.std_address.Size = new System.Drawing.Size(204, 26);
            this.std_address.TabIndex = 2;
            // 
            // Std_list
            // 
            this.Std_list.AllowUserToAddRows = false;
            this.Std_list.AllowUserToDeleteRows = false;
            this.Std_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Std_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdID,
            this.SN,
            this.Student_name,
            this.Address,
            this.FilePath,
            this.Action});
            this.Std_list.Location = new System.Drawing.Point(239, 16);
            this.Std_list.Name = "Std_list";
            this.Std_list.ReadOnly = true;
            this.Std_list.Size = new System.Drawing.Size(590, 388);
            this.Std_list.TabIndex = 2;
            this.Std_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Std_list_CellClick);
            // 
            // stdID
            // 
            this.stdID.HeaderText = "ID";
            this.stdID.Name = "stdID";
            this.stdID.ReadOnly = true;
            this.stdID.Visible = false;
            // 
            // SN
            // 
            this.SN.HeaderText = "SN";
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            this.SN.Width = 40;
            // 
            // Student_name
            // 
            this.Student_name.HeaderText = "Name";
            this.Student_name.Name = "Student_name";
            this.Student_name.ReadOnly = true;
            this.Student_name.Width = 180;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 150;
            // 
            // FilePath
            // 
            this.FilePath.HeaderText = "FilePath";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 300);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 40);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(140, 300);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 40);
            this.Remove.TabIndex = 4;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(12, 356);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 40);
            this.Update.TabIndex = 6;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(140, 356);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 40);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_click);
            // 
            // photo
            // 
            this.photo.Location = new System.Drawing.Point(5, 126);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(228, 137);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo.TabIndex = 8;
            this.photo.TabStop = false;
            // 
            // Selectphoto
            // 
            this.Selectphoto.Location = new System.Drawing.Point(78, 269);
            this.Selectphoto.Name = "Selectphoto";
            this.Selectphoto.Size = new System.Drawing.Size(75, 23);
            this.Selectphoto.TabIndex = 9;
            this.Selectphoto.Text = "Select photo";
            this.Selectphoto.UseVisualStyleBackColor = true;
            this.Selectphoto.Click += new System.EventHandler(this.Selectphoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 408);
            this.Controls.Add(this.Selectphoto);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Std_list);
            this.Controls.Add(this.std_address);
            this.Controls.Add(this.std_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Std_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox std_name;
        private System.Windows.Forms.TextBox std_address;
        private System.Windows.Forms.DataGridView Std_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private new System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Button Selectphoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
    }
}

