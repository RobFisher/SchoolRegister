namespace Register
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.am = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.interventions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddChildButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.PresentButton = new System.Windows.Forms.Button();
            this.timeOfDayBox = new System.Windows.Forms.ListBox();
            this.AbsentButton = new System.Windows.Forms.Button();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.reg,
            this.am,
            this.pm,
            this.interventions});
            this.dataGridView1.Location = new System.Drawing.Point(13, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1424, 500);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 9;
            this.name.Name = "name";
            this.name.Width = 175;
            // 
            // reg
            // 
            this.reg.HeaderText = "Reg";
            this.reg.MinimumWidth = 9;
            this.reg.Name = "reg";
            this.reg.Width = 175;
            // 
            // am
            // 
            this.am.HeaderText = "AM";
            this.am.MinimumWidth = 9;
            this.am.Name = "am";
            this.am.Width = 175;
            // 
            // pm
            // 
            this.pm.HeaderText = "PM";
            this.pm.MinimumWidth = 9;
            this.pm.Name = "pm";
            this.pm.Width = 175;
            // 
            // interventions
            // 
            this.interventions.HeaderText = "Interventions";
            this.interventions.MinimumWidth = 9;
            this.interventions.Name = "interventions";
            this.interventions.Width = 175;
            // 
            // AddChildButton
            // 
            this.AddChildButton.Location = new System.Drawing.Point(13, 13);
            this.AddChildButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddChildButton.Name = "AddChildButton";
            this.AddChildButton.Size = new System.Drawing.Size(211, 41);
            this.AddChildButton.TabIndex = 1;
            this.AddChildButton.Text = "Add child...";
            this.AddChildButton.UseVisualStyleBackColor = true;
            this.AddChildButton.Click += new System.EventHandler(this.AddChildButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(233, 11);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(6);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(138, 42);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(381, 11);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(119, 42);
            this.LoadButton.TabIndex = 3;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // PresentButton
            // 
            this.PresentButton.Location = new System.Drawing.Point(507, 13);
            this.PresentButton.Name = "PresentButton";
            this.PresentButton.Size = new System.Drawing.Size(141, 39);
            this.PresentButton.TabIndex = 4;
            this.PresentButton.Text = "&Present";
            this.PresentButton.UseVisualStyleBackColor = true;
            this.PresentButton.Click += new System.EventHandler(this.PresentButton_Click);
            // 
            // timeOfDayBox
            // 
            this.timeOfDayBox.AllowDrop = true;
            this.timeOfDayBox.FormattingEnabled = true;
            this.timeOfDayBox.ItemHeight = 24;
            this.timeOfDayBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.timeOfDayBox.Location = new System.Drawing.Point(868, 13);
            this.timeOfDayBox.Name = "timeOfDayBox";
            this.timeOfDayBox.Size = new System.Drawing.Size(256, 52);
            this.timeOfDayBox.TabIndex = 5;
            // 
            // AbsentButton
            // 
            this.AbsentButton.Location = new System.Drawing.Point(655, 13);
            this.AbsentButton.Name = "AbsentButton";
            this.AbsentButton.Size = new System.Drawing.Size(153, 39);
            this.AbsentButton.TabIndex = 6;
            this.AbsentButton.Text = "&Absent";
            this.AbsentButton.UseVisualStyleBackColor = true;
            this.AbsentButton.Click += new System.EventHandler(this.AbsentButton_Click);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(Register.Program);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 805);
            this.Controls.Add(this.AbsentButton);
            this.Controls.Add(this.timeOfDayBox);
            this.Controls.Add(this.PresentButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddChildButton);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg;
        private System.Windows.Forms.DataGridViewCheckBoxColumn am;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pm;
        private System.Windows.Forms.DataGridViewTextBoxColumn interventions;
        private System.Windows.Forms.Button AddChildButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Button PresentButton;
        private System.Windows.Forms.ListBox timeOfDayBox;
        private System.Windows.Forms.Button AbsentButton;
    }
}

