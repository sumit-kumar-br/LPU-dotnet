namespace WinSerializeDemo
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
            this.EmpID = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.Label();
            this.btnBinSerialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.btnXMLSerialize = new System.Windows.Forms.Button();
            this.btnXMLDeserialize = new System.Windows.Forms.Button();
            this.btnSOAPSerialize = new System.Windows.Forms.Button();
            this.btnSOAPDeserialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmpID
            // 
            this.EmpID.AutoSize = true;
            this.EmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpID.Location = new System.Drawing.Point(218, 93);
            this.EmpID.Name = "EmpID";
            this.EmpID.Size = new System.Drawing.Size(123, 25);
            this.EmpID.TabIndex = 0;
            this.EmpID.Text = "Employee ID";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(364, 90);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(127, 30);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(364, 150);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 30);
            this.txtName.TabIndex = 3;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(218, 153);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(64, 25);
            this.Name.TabIndex = 2;
            this.Name.Text = "Name";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(364, 207);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(127, 30);
            this.txtSalary.TabIndex = 5;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.Location = new System.Drawing.Point(218, 210);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(68, 25);
            this.Salary.TabIndex = 4;
            this.Salary.Text = "Salary";
            // 
            // btnBinSerialize
            // 
            this.btnBinSerialize.AutoSize = true;
            this.btnBinSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinSerialize.Location = new System.Drawing.Point(133, 285);
            this.btnBinSerialize.Name = "btnBinSerialize";
            this.btnBinSerialize.Size = new System.Drawing.Size(151, 35);
            this.btnBinSerialize.TabIndex = 6;
            this.btnBinSerialize.Text = "Bin Serialize";
            this.btnBinSerialize.UseVisualStyleBackColor = true;
            this.btnBinSerialize.Click += new System.EventHandler(this.btnBinSerialize_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.AutoSize = true;
            this.btnDeserialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeserialize.Location = new System.Drawing.Point(133, 352);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(151, 35);
            this.btnDeserialize.TabIndex = 7;
            this.btnDeserialize.Text = "Bin Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // btnXMLSerialize
            // 
            this.btnXMLSerialize.AutoSize = true;
            this.btnXMLSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXMLSerialize.Location = new System.Drawing.Point(336, 285);
            this.btnXMLSerialize.Name = "btnXMLSerialize";
            this.btnXMLSerialize.Size = new System.Drawing.Size(165, 35);
            this.btnXMLSerialize.TabIndex = 8;
            this.btnXMLSerialize.Text = "XML Serialize";
            this.btnXMLSerialize.UseVisualStyleBackColor = true;
            this.btnXMLSerialize.Click += new System.EventHandler(this.btnXMLSerialize_Click);
            // 
            // btnXMLDeserialize
            // 
            this.btnXMLDeserialize.AutoSize = true;
            this.btnXMLDeserialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXMLDeserialize.Location = new System.Drawing.Point(336, 352);
            this.btnXMLDeserialize.Name = "btnXMLDeserialize";
            this.btnXMLDeserialize.Size = new System.Drawing.Size(165, 35);
            this.btnXMLDeserialize.TabIndex = 9;
            this.btnXMLDeserialize.Text = "XML Deserialize";
            this.btnXMLDeserialize.UseVisualStyleBackColor = true;
            this.btnXMLDeserialize.Click += new System.EventHandler(this.btnXMLDeserialize_Click);
            // 
            // btnSOAPSerialize
            // 
            this.btnSOAPSerialize.AutoSize = true;
            this.btnSOAPSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSOAPSerialize.Location = new System.Drawing.Point(540, 285);
            this.btnSOAPSerialize.Name = "btnSOAPSerialize";
            this.btnSOAPSerialize.Size = new System.Drawing.Size(170, 35);
            this.btnSOAPSerialize.TabIndex = 10;
            this.btnSOAPSerialize.Text = "Soap Serialize";
            this.btnSOAPSerialize.UseVisualStyleBackColor = true;
            this.btnSOAPSerialize.Click += new System.EventHandler(this.btnSoapSerialize_Click);
            // 
            // btnSOAPDeserialize
            // 
            this.btnSOAPDeserialize.AutoSize = true;
            this.btnSOAPDeserialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSOAPDeserialize.Location = new System.Drawing.Point(540, 352);
            this.btnSOAPDeserialize.Name = "btnSOAPDeserialize";
            this.btnSOAPDeserialize.Size = new System.Drawing.Size(170, 35);
            this.btnSOAPDeserialize.TabIndex = 11;
            this.btnSOAPDeserialize.Text = "Soap Deserialize";
            this.btnSOAPDeserialize.UseVisualStyleBackColor = true;
            this.btnSOAPDeserialize.Click += new System.EventHandler(this.btnSOAPDeserialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSOAPDeserialize);
            this.Controls.Add(this.btnSOAPSerialize);
            this.Controls.Add(this.btnXMLDeserialize);
            this.Controls.Add(this.btnXMLSerialize);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnBinSerialize);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.EmpID);
            //this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmpID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Button btnBinSerialize;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Button btnXMLSerialize;
        private System.Windows.Forms.Button btnXMLDeserialize;
        private System.Windows.Forms.Button btnSOAPSerialize;
        private System.Windows.Forms.Button btnSOAPDeserialize;
    }
}

