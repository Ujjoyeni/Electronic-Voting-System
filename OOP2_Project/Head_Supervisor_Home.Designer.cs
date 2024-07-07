﻿
namespace OOP2_Project
{
    partial class Head_Supervisor_Home
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
            this.id_label = new System.Windows.Forms.Label();
            this.userName_label = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.search_field = new System.Windows.Forms.TextBox();
            this.party_b_btn = new System.Windows.Forms.Button();
            this.gridView_label = new System.Windows.Forms.Label();
            this.db_gridview = new System.Windows.Forms.DataGridView();
            this.party_a_btn = new System.Windows.Forms.Button();
            this.search_b_btn = new System.Windows.Forms.Button();
            this.search_c_btn = new System.Windows.Forms.Button();
            this.party_c_btn = new System.Windows.Forms.Button();
            this.search_a_btn = new System.Windows.Forms.Button();
            this.admin_info_btn = new System.Windows.Forms.Button();
            this.delete_search = new System.Windows.Forms.TextBox();
            this.delete_application_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.db_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // id_label
            // 
            this.id_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.Location = new System.Drawing.Point(939, 31);
            this.id_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(95, 23);
            this.id_label.TabIndex = 77;
            this.id_label.Text = "000";
            // 
            // userName_label
            // 
            this.userName_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_label.ForeColor = System.Drawing.Color.White;
            this.userName_label.Location = new System.Drawing.Point(851, 30);
            this.userName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(95, 23);
            this.userName_label.TabIndex = 76;
            this.userName_label.Text = "H.S ID:";
            // 
            // logout_btn
            // 
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Location = new System.Drawing.Point(743, 28);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(100, 28);
            this.logout_btn.TabIndex = 75;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // search_field
            // 
            this.search_field.Location = new System.Drawing.Point(631, 148);
            this.search_field.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search_field.Name = "search_field";
            this.search_field.Size = new System.Drawing.Size(204, 22);
            this.search_field.TabIndex = 88;
            // 
            // party_b_btn
            // 
            this.party_b_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.party_b_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.party_b_btn.Location = new System.Drawing.Point(213, 81);
            this.party_b_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.party_b_btn.Name = "party_b_btn";
            this.party_b_btn.Size = new System.Drawing.Size(129, 28);
            this.party_b_btn.TabIndex = 87;
            this.party_b_btn.Text = "Party B";
            this.party_b_btn.UseVisualStyleBackColor = true;
            this.party_b_btn.Click += new System.EventHandler(this.party_b_btn_Click);
            // 
            // gridView_label
            // 
            this.gridView_label.AutoSize = true;
            this.gridView_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView_label.ForeColor = System.Drawing.Color.White;
            this.gridView_label.Location = new System.Drawing.Point(65, 148);
            this.gridView_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gridView_label.Name = "gridView_label";
            this.gridView_label.Size = new System.Drawing.Size(139, 34);
            this.gridView_label.TabIndex = 86;
            this.gridView_label.Text = "Data View";
            // 
            // db_gridview
            // 
            this.db_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_gridview.Location = new System.Drawing.Point(72, 185);
            this.db_gridview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.db_gridview.Name = "db_gridview";
            this.db_gridview.RowHeadersWidth = 51;
            this.db_gridview.Size = new System.Drawing.Size(929, 288);
            this.db_gridview.TabIndex = 85;
            // 
            // party_a_btn
            // 
            this.party_a_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.party_a_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.party_a_btn.Location = new System.Drawing.Point(72, 81);
            this.party_a_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.party_a_btn.Name = "party_a_btn";
            this.party_a_btn.Size = new System.Drawing.Size(129, 28);
            this.party_a_btn.TabIndex = 84;
            this.party_a_btn.Text = "Party A";
            this.party_a_btn.UseVisualStyleBackColor = true;
            this.party_a_btn.Click += new System.EventHandler(this.party_a_btn_Click);
            // 
            // search_b_btn
            // 
            this.search_b_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_b_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_b_btn.Location = new System.Drawing.Point(872, 144);
            this.search_b_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search_b_btn.Name = "search_b_btn";
            this.search_b_btn.Size = new System.Drawing.Size(129, 28);
            this.search_b_btn.TabIndex = 89;
            this.search_b_btn.Text = "Search";
            this.search_b_btn.UseVisualStyleBackColor = true;
            // 
            // search_c_btn
            // 
            this.search_c_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_c_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_c_btn.Location = new System.Drawing.Point(872, 144);
            this.search_c_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search_c_btn.Name = "search_c_btn";
            this.search_c_btn.Size = new System.Drawing.Size(129, 28);
            this.search_c_btn.TabIndex = 90;
            this.search_c_btn.Text = "Search";
            this.search_c_btn.UseVisualStyleBackColor = true;
            // 
            // party_c_btn
            // 
            this.party_c_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.party_c_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.party_c_btn.Location = new System.Drawing.Point(351, 81);
            this.party_c_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.party_c_btn.Name = "party_c_btn";
            this.party_c_btn.Size = new System.Drawing.Size(129, 28);
            this.party_c_btn.TabIndex = 91;
            this.party_c_btn.Text = "Party C";
            this.party_c_btn.UseVisualStyleBackColor = true;
            this.party_c_btn.Click += new System.EventHandler(this.party_c_btn_Click);
            // 
            // search_a_btn
            // 
            this.search_a_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_a_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_a_btn.Location = new System.Drawing.Point(872, 144);
            this.search_a_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search_a_btn.Name = "search_a_btn";
            this.search_a_btn.Size = new System.Drawing.Size(129, 28);
            this.search_a_btn.TabIndex = 92;
            this.search_a_btn.Text = "Search";
            this.search_a_btn.UseVisualStyleBackColor = true;
            // 
            // admin_info_btn
            // 
            this.admin_info_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_info_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_info_btn.Location = new System.Drawing.Point(71, 491);
            this.admin_info_btn.Margin = new System.Windows.Forms.Padding(4);
            this.admin_info_btn.Name = "admin_info_btn";
            this.admin_info_btn.Size = new System.Drawing.Size(129, 28);
            this.admin_info_btn.TabIndex = 93;
            this.admin_info_btn.Text = "Admin Info";
            this.admin_info_btn.UseVisualStyleBackColor = true;
            this.admin_info_btn.Click += new System.EventHandler(this.admin_info_btn_Click);
            // 
            // delete_search
            // 
            this.delete_search.Location = new System.Drawing.Point(218, 493);
            this.delete_search.Margin = new System.Windows.Forms.Padding(4);
            this.delete_search.Name = "delete_search";
            this.delete_search.Size = new System.Drawing.Size(204, 22);
            this.delete_search.TabIndex = 94;
            // 
            // delete_application_btn
            // 
            this.delete_application_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_application_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_application_btn.Location = new System.Drawing.Point(437, 491);
            this.delete_application_btn.Margin = new System.Windows.Forms.Padding(4);
            this.delete_application_btn.Name = "delete_application_btn";
            this.delete_application_btn.Size = new System.Drawing.Size(152, 28);
            this.delete_application_btn.TabIndex = 95;
            this.delete_application_btn.Text = "Delete Admin";
            this.delete_application_btn.UseVisualStyleBackColor = true;
            this.delete_application_btn.Click += new System.EventHandler(this.delete_application_btn_Click);
            // 
            // Head_Supervisor_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.delete_search);
            this.Controls.Add(this.delete_application_btn);
            this.Controls.Add(this.admin_info_btn);
            this.Controls.Add(this.search_a_btn);
            this.Controls.Add(this.party_c_btn);
            this.Controls.Add(this.search_field);
            this.Controls.Add(this.party_b_btn);
            this.Controls.Add(this.gridView_label);
            this.Controls.Add(this.db_gridview);
            this.Controls.Add(this.party_a_btn);
            this.Controls.Add(this.search_b_btn);
            this.Controls.Add(this.search_c_btn);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.userName_label);
            this.Controls.Add(this.logout_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Head_Supervisor_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Head_Supervisor_Home";
            this.Load += new System.EventHandler(this.Head_Supervisor_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.TextBox search_field;
        private System.Windows.Forms.Button party_b_btn;
        private System.Windows.Forms.Label gridView_label;
        private System.Windows.Forms.DataGridView db_gridview;
        private System.Windows.Forms.Button party_a_btn;
        private System.Windows.Forms.Button search_b_btn;
        private System.Windows.Forms.Button search_c_btn;
        private System.Windows.Forms.Button party_c_btn;
        private System.Windows.Forms.Button search_a_btn;
        private System.Windows.Forms.Button admin_info_btn;
        private System.Windows.Forms.TextBox delete_search;
        private System.Windows.Forms.Button delete_application_btn;
    }
}