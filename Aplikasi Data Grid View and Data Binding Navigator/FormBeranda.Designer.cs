
namespace Aplikasi_Data_Grid_View_and_Data_Binding_Navigator
{
    partial class FormBeranda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_Logout = new System.Windows.Forms.PictureBox();
            this.pictureDataBinding = new System.Windows.Forms.PictureBox();
            this.pictureDataGridView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDataBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(299, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(218, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Grid View";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(436, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Binding View Navigation";
            // 
            // pictureBox_Logout
            // 
            this.pictureBox_Logout.Image = global::Aplikasi_Data_Grid_View_and_Data_Binding_Navigator.Properties.Resources.logout;
            this.pictureBox_Logout.Location = new System.Drawing.Point(744, 403);
            this.pictureBox_Logout.Name = "pictureBox_Logout";
            this.pictureBox_Logout.Size = new System.Drawing.Size(35, 35);
            this.pictureBox_Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Logout.TabIndex = 5;
            this.pictureBox_Logout.TabStop = false;
            this.pictureBox_Logout.Click += new System.EventHandler(this.pictureBox_Exit_Click);
            // 
            // pictureDataBinding
            // 
            this.pictureDataBinding.Image = global::Aplikasi_Data_Grid_View_and_Data_Binding_Navigator.Properties.Resources.document;
            this.pictureDataBinding.Location = new System.Drawing.Point(457, 171);
            this.pictureDataBinding.Name = "pictureDataBinding";
            this.pictureDataBinding.Size = new System.Drawing.Size(150, 130);
            this.pictureDataBinding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDataBinding.TabIndex = 4;
            this.pictureDataBinding.TabStop = false;
            this.pictureDataBinding.Click += new System.EventHandler(this.pictureDataBinding_Click);
            // 
            // pictureDataGridView
            // 
            this.pictureDataGridView.Image = global::Aplikasi_Data_Grid_View_and_Data_Binding_Navigator.Properties.Resources.table;
            this.pictureDataGridView.Location = new System.Drawing.Point(207, 171);
            this.pictureDataGridView.Name = "pictureDataGridView";
            this.pictureDataGridView.Size = new System.Drawing.Size(150, 130);
            this.pictureDataGridView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDataGridView.TabIndex = 3;
            this.pictureDataGridView.TabStop = false;
            this.pictureDataGridView.Click += new System.EventHandler(this.pictureDataGridView_Click);
            // 
            // FormBeranda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox_Logout);
            this.Controls.Add(this.pictureDataBinding);
            this.Controls.Add(this.pictureDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBeranda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.FormBeranda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDataBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureDataGridView;
        private System.Windows.Forms.PictureBox pictureDataBinding;
        private System.Windows.Forms.PictureBox pictureBox_Logout;
    }
}