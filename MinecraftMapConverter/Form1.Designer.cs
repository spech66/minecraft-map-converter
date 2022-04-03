namespace MinecraftMapConverter
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelMinecraftPath = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxInput = new System.Windows.Forms.ComboBox();
            this.comboBoxOutput = new System.Windows.Forms.ComboBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelMinecraftPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxOutput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonConvert, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minecraft folder";
            // 
            // linkLabelMinecraftPath
            // 
            this.linkLabelMinecraftPath.AutoSize = true;
            this.linkLabelMinecraftPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabelMinecraftPath.Location = new System.Drawing.Point(223, 0);
            this.linkLabelMinecraftPath.Name = "linkLabelMinecraftPath";
            this.linkLabelMinecraftPath.Size = new System.Drawing.Size(574, 28);
            this.linkLabelMinecraftPath.TabIndex = 1;
            this.linkLabelMinecraftPath.TabStop = true;
            this.linkLabelMinecraftPath.Text = "linkLabelMinecraftPath";
            this.linkLabelMinecraftPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input waypoints (voxelmap for now)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output waypoints (Xaero for now)";
            // 
            // comboBoxInput
            // 
            this.comboBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInput.FormattingEnabled = true;
            this.comboBoxInput.Location = new System.Drawing.Point(223, 31);
            this.comboBoxInput.Name = "comboBoxInput";
            this.comboBoxInput.Size = new System.Drawing.Size(574, 23);
            this.comboBoxInput.TabIndex = 4;
            this.comboBoxInput.SelectedIndexChanged += new System.EventHandler(this.comboBoxInput_SelectedIndexChanged);
            // 
            // comboBoxOutput
            // 
            this.comboBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutput.FormattingEnabled = true;
            this.comboBoxOutput.Location = new System.Drawing.Point(223, 59);
            this.comboBoxOutput.Name = "comboBoxOutput";
            this.comboBoxOutput.Size = new System.Drawing.Size(574, 23);
            this.comboBoxOutput.TabIndex = 5;
            this.comboBoxOutput.SelectedIndexChanged += new System.EventHandler(this.comboBoxOutput_SelectedIndexChanged);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(223, 87);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 6;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Minecraft Map Converter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private LinkLabel linkLabelMinecraftPath;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxInput;
        private ComboBox comboBoxOutput;
        private Button buttonConvert;
    }
}