
namespace View1
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.GridEmp = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.DapperBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // GridEmp
            // 
            this.GridEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmp.Location = new System.Drawing.Point(13, 13);
            this.GridEmp.Name = "GridEmp";
            this.GridEmp.RowTemplate.Height = 25;
            this.GridEmp.Size = new System.Drawing.Size(775, 371);
            this.GridEmp.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(13, 390);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(166, 47);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(357, 391);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(166, 47);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Edit";
            this.Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Edit.UseVisualStyleBackColor = true;
            //this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(185, 391);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(166, 47);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DapperBtn
            // 
            this.DapperBtn.Location = new System.Drawing.Point(622, 391);
            this.DapperBtn.Name = "DapperBtn";
            this.DapperBtn.Size = new System.Drawing.Size(166, 47);
            this.DapperBtn.TabIndex = 4;
            this.DapperBtn.Text = "Dapper";
            this.DapperBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DapperBtn.UseVisualStyleBackColor = true;
            //this.DapperBtn.Click += new System.EventHandler(this.DapperBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DapperBtn);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.GridEmp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView GridEmp;
        public System.Windows.Forms.Button Add;
        public System.Windows.Forms.Button Edit;
        public System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Button DapperBtn;
    }
}

