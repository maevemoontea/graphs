namespace AdjecencyGUI
{
    partial class DegreesListForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.textBoxDegreesList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(104, 168);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Готово";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // textBoxDegreesList
            // 
            this.textBoxDegreesList.Location = new System.Drawing.Point(34, 71);
            this.textBoxDegreesList.Multiline = true;
            this.textBoxDegreesList.Name = "textBoxDegreesList";
            this.textBoxDegreesList.ReadOnly = true;
            this.textBoxDegreesList.Size = new System.Drawing.Size(227, 82);
            this.textBoxDegreesList.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Усі ступені вершин графу по порядку:";
            // 
            // DegreesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 221);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDegreesList);
            this.Controls.Add(this.btnOk);
            this.Name = "DegreesListForm";
            this.Text = "Ступені вершин графу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox textBoxDegreesList;
        private System.Windows.Forms.Label label1;
    }
}