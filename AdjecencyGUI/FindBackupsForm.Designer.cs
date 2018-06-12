namespace AdjecencyGUI
{
    partial class FindBackupsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindBackupsForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxMaxConnections = new System.Windows.Forms.TextBox();
            this.btnFindBackups = new System.Windows.Forms.Button();
            this.textBoxConfiguration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(25, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(424, 51);
            this.textBox1.TabIndex = 50;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(25, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Характеристики пристроїв";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Дистанція взаємодії:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Потрібна кількість бекап-пристроїв:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Максимальне навантаження на пристрій:";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(28, 142);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(100, 20);
            this.textBoxDistance.TabIndex = 0;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(29, 192);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 1;
            // 
            // textBoxMaxConnections
            // 
            this.textBoxMaxConnections.Location = new System.Drawing.Point(29, 244);
            this.textBoxMaxConnections.Name = "textBoxMaxConnections";
            this.textBoxMaxConnections.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxConnections.TabIndex = 2;
            // 
            // btnFindBackups
            // 
            this.btnFindBackups.Location = new System.Drawing.Point(29, 298);
            this.btnFindBackups.Name = "btnFindBackups";
            this.btnFindBackups.Size = new System.Drawing.Size(110, 23);
            this.btnFindBackups.TabIndex = 10;
            this.btnFindBackups.Text = "Розрахувати >>";
            this.btnFindBackups.UseVisualStyleBackColor = true;
            this.btnFindBackups.Click += new System.EventHandler(this.BtnFindBackups_Click);
            // 
            // textBoxConfiguration
            // 
            this.textBoxConfiguration.Location = new System.Drawing.Point(301, 126);
            this.textBoxConfiguration.Multiline = true;
            this.textBoxConfiguration.Name = "textBoxConfiguration";
            this.textBoxConfiguration.ReadOnly = true;
            this.textBoxConfiguration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConfiguration.Size = new System.Drawing.Size(315, 229);
            this.textBoxConfiguration.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Конфігурація мережі:";
            // 
            // FindBackupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 388);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxConfiguration);
            this.Controls.Add(this.btnFindBackups);
            this.Controls.Add(this.textBoxMaxConnections);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FindBackupsForm";
            this.Text = "Пошук бекап-приладів";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxMaxConnections;
        private System.Windows.Forms.Button btnFindBackups;
        private System.Windows.Forms.TextBox textBoxConfiguration;
        private System.Windows.Forms.Label label5;
    }
}