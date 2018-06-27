namespace WindowsFormsApplication2
{
    partial class customerSignIn
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerEmail = new System.Windows.Forms.TextBox();
            this.customerPassword = new System.Windows.Forms.TextBox();
            this.custSignInButt = new System.Windows.Forms.Button();
            this.customerTable = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new WindowsFormsApplication2.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieRentalDataSet = new WindowsFormsApplication2.MovieRentalDataSet();
            this.movieRentalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Mail";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // customerEmail
            // 
            this.customerEmail.Location = new System.Drawing.Point(64, 107);
            this.customerEmail.Name = "customerEmail";
            this.customerEmail.Size = new System.Drawing.Size(131, 22);
            this.customerEmail.TabIndex = 2;
            // 
            // customerPassword
            // 
            this.customerPassword.Location = new System.Drawing.Point(64, 180);
            this.customerPassword.Name = "customerPassword";
            this.customerPassword.Size = new System.Drawing.Size(131, 22);
            this.customerPassword.TabIndex = 3;
            // 
            // custSignInButt
            // 
            this.custSignInButt.Location = new System.Drawing.Point(181, 278);
            this.custSignInButt.Name = "custSignInButt";
            this.custSignInButt.Size = new System.Drawing.Size(75, 23);
            this.custSignInButt.TabIndex = 4;
            this.custSignInButt.Text = "SignIn";
            this.custSignInButt.UseVisualStyleBackColor = true;
            this.custSignInButt.Click += new System.EventHandler(this.custSignInButt_Click);
            // 
            // customerTable
            // 
            this.customerTable.AutoGenerateColumns = false;
            this.customerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerTable.DataSource = this.movieRentalDataSetBindingSource;
            this.customerTable.Location = new System.Drawing.Point(16, -7);
            this.customerTable.Name = "customerTable";
            this.customerTable.RowTemplate.Height = 24;
            this.customerTable.Size = new System.Drawing.Size(240, 150);
            this.customerTable.TabIndex = 5;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // movieRentalDataSet
            // 
            this.movieRentalDataSet.DataSetName = "MovieRentalDataSet";
            this.movieRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieRentalDataSetBindingSource
            // 
            this.movieRentalDataSetBindingSource.DataSource = this.movieRentalDataSet;
            this.movieRentalDataSetBindingSource.Position = 0;
            // 
            // customerSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 345);
            this.Controls.Add(this.customerTable);
            this.Controls.Add(this.custSignInButt);
            this.Controls.Add(this.customerPassword);
            this.Controls.Add(this.customerEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "customerSignIn";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerEmail;
        private System.Windows.Forms.TextBox customerPassword;
        private System.Windows.Forms.Button custSignInButt;
        private System.Windows.Forms.DataGridView customerTable;
        private System.Windows.Forms.BindingSource movieRentalDataSetBindingSource;
        private MovieRentalDataSet movieRentalDataSet;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
    }
}