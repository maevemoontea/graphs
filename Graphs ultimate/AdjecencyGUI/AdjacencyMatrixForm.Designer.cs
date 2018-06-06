namespace AdjecencyGUI
{
    partial class AdjacencyMatrixForm
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
            this.btnUseAdjacencyMatrix = new System.Windows.Forms.Button();
            this.textBoxAdjacencyMatrix = new System.Windows.Forms.TextBox();
            this.textBoxAdjacencyDescr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUseAdjacencyMatrix
            // 
            this.btnUseAdjacencyMatrix.Location = new System.Drawing.Point(116, 271);
            this.btnUseAdjacencyMatrix.Name = "btnUseAdjacencyMatrix";
            this.btnUseAdjacencyMatrix.Size = new System.Drawing.Size(75, 23);
            this.btnUseAdjacencyMatrix.TabIndex = 2;
            this.btnUseAdjacencyMatrix.Text = "Готово";
            this.btnUseAdjacencyMatrix.UseVisualStyleBackColor = true;
            this.btnUseAdjacencyMatrix.Click += new System.EventHandler(this.BtnUseAdjacencyMatrix_Click);
            // 
            // textBoxAdjacencyMatrix
            // 
            this.textBoxAdjacencyMatrix.Location = new System.Drawing.Point(38, 118);
            this.textBoxAdjacencyMatrix.MaxLength = 0;
            this.textBoxAdjacencyMatrix.Multiline = true;
            this.textBoxAdjacencyMatrix.Name = "textBoxAdjacencyMatrix";
            this.textBoxAdjacencyMatrix.Size = new System.Drawing.Size(249, 103);
            this.textBoxAdjacencyMatrix.TabIndex = 3;
            // 
            // textBoxAdjacencyDescr
            // 
            this.textBoxAdjacencyDescr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAdjacencyDescr.Location = new System.Drawing.Point(38, 30);
            this.textBoxAdjacencyDescr.Multiline = true;
            this.textBoxAdjacencyDescr.Name = "textBoxAdjacencyDescr";
            this.textBoxAdjacencyDescr.ReadOnly = true;
            this.textBoxAdjacencyDescr.Size = new System.Drawing.Size(249, 61);
            this.textBoxAdjacencyDescr.TabIndex = 4;
            // 
            // AdjacencyMatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 329);
            this.Controls.Add(this.textBoxAdjacencyDescr);
            this.Controls.Add(this.textBoxAdjacencyMatrix);
            this.Controls.Add(this.btnUseAdjacencyMatrix);
            this.Name = "AdjacencyMatrixForm";
            this.Text = "Заповнення матриці суміжності";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUseAdjacencyMatrix;
        private System.Windows.Forms.TextBox textBoxAdjacencyMatrix;
        private System.Windows.Forms.TextBox textBoxAdjacencyDescr;
    }
}