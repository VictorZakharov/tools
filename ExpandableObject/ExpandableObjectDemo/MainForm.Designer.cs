namespace ExpandableObjectDemo
{
  partial class MainForm
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
            System.Windows.Forms.TableLayoutPanel pnlLayout;
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.btnListOfEmployee = new System.Windows.Forms.Button();
            pnlLayout = new System.Windows.Forms.TableLayoutPanel();
            pnlLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLayout
            // 
            pnlLayout.ColumnCount = 3;
            pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            pnlLayout.Controls.Add(this.btnDepartment, 2, 1);
            pnlLayout.Controls.Add(this.btnEmployee, 0, 1);
            pnlLayout.Controls.Add(this.propertyGrid1, 0, 0);
            pnlLayout.Controls.Add(this.btnListOfEmployee, 1, 1);
            pnlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlLayout.Location = new System.Drawing.Point(0, 0);
            pnlLayout.Name = "pnlLayout";
            pnlLayout.RowCount = 2;
            pnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            pnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            pnlLayout.Size = new System.Drawing.Size(621, 430);
            pnlLayout.TabIndex = 3;
            // 
            // btnDepartment
            // 
            this.btnDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDepartment.Location = new System.Drawing.Point(416, 393);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(202, 34);
            this.btnDepartment.TabIndex = 3;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmployee.Location = new System.Drawing.Point(3, 393);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(200, 34);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // propertyGrid1
            // 
            pnlLayout.SetColumnSpan(this.propertyGrid1, 3);
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(615, 384);
            this.propertyGrid1.TabIndex = 0;
            // 
            // btnListOfEmployee
            // 
            this.btnListOfEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListOfEmployee.Location = new System.Drawing.Point(209, 393);
            this.btnListOfEmployee.Name = "btnListOfEmployee";
            this.btnListOfEmployee.Size = new System.Drawing.Size(201, 34);
            this.btnListOfEmployee.TabIndex = 2;
            this.btnListOfEmployee.Text = "List<Employee>";
            this.btnListOfEmployee.UseVisualStyleBackColor = true;
            this.btnListOfEmployee.Click += new System.EventHandler(this.btnListOfEmployee_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 430);
            this.Controls.Add(pnlLayout);
            this.Name = "MainForm";
            this.Text = "Expandable Object Demo";
            pnlLayout.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PropertyGrid propertyGrid1;
    private System.Windows.Forms.Button btnDepartment;
    private System.Windows.Forms.Button btnEmployee;
    private System.Windows.Forms.Button btnListOfEmployee;
  }
}

