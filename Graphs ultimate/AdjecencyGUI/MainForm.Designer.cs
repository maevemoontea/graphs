namespace AdjecencyGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSetN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAutoGraph = new System.Windows.Forms.Button();
            this.btnManualGraph = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowDegreesForm = new System.Windows.Forms.Button();
            this.btnViewIsolatedVertices = new System.Windows.Forms.Button();
            this.btnViewEndVertices = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.btnFindTheWay = new System.Windows.Forms.Button();
            this.btnAutoGraphSymm = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBackupWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Кількість вершин:";
            // 
            // textBoxSetN
            // 
            this.textBoxSetN.Location = new System.Drawing.Point(115, 6);
            this.textBoxSetN.Name = "textBoxSetN";
            this.textBoxSetN.Size = new System.Drawing.Size(100, 20);
            this.textBoxSetN.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Матриця суміжності:";
            // 
            // btnAutoGraph
            // 
            this.btnAutoGraph.Location = new System.Drawing.Point(359, 6);
            this.btnAutoGraph.Name = "btnAutoGraph";
            this.btnAutoGraph.Size = new System.Drawing.Size(92, 23);
            this.btnAutoGraph.TabIndex = 1;
            this.btnAutoGraph.Text = "Згенерувати";
            this.btnAutoGraph.UseVisualStyleBackColor = true;
            this.btnAutoGraph.Click += new System.EventHandler(this.BtnAutoGraph_Click);
            // 
            // btnManualGraph
            // 
            this.btnManualGraph.Location = new System.Drawing.Point(656, 6);
            this.btnManualGraph.Name = "btnManualGraph";
            this.btnManualGraph.Size = new System.Drawing.Size(121, 23);
            this.btnManualGraph.TabIndex = 3;
            this.btnManualGraph.Text = "Заповнити вручну";
            this.btnManualGraph.UseVisualStyleBackColor = true;
            this.btnManualGraph.Click += new System.EventHandler(this.BtnManualGraph_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(921, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Скасувати";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Дії з графом";
            // 
            // btnShowDegreesForm
            // 
            this.btnShowDegreesForm.Location = new System.Drawing.Point(20, 439);
            this.btnShowDegreesForm.Name = "btnShowDegreesForm";
            this.btnShowDegreesForm.Size = new System.Drawing.Size(246, 23);
            this.btnShowDegreesForm.TabIndex = 6;
            this.btnShowDegreesForm.Text = "Перелік ступенів вершин";
            this.btnShowDegreesForm.UseVisualStyleBackColor = true;
            this.btnShowDegreesForm.Click += new System.EventHandler(this.BtnShowDegreesForm_Click);
            // 
            // btnViewIsolatedVertices
            // 
            this.btnViewIsolatedVertices.Location = new System.Drawing.Point(20, 469);
            this.btnViewIsolatedVertices.Name = "btnViewIsolatedVertices";
            this.btnViewIsolatedVertices.Size = new System.Drawing.Size(120, 23);
            this.btnViewIsolatedVertices.TabIndex = 4;
            this.btnViewIsolatedVertices.Text = "Ізольовані вершини";
            this.btnViewIsolatedVertices.UseVisualStyleBackColor = true;
            this.btnViewIsolatedVertices.Click += new System.EventHandler(this.BtnViewIsolatedVertices_Click);
            // 
            // btnViewEndVertices
            // 
            this.btnViewEndVertices.Location = new System.Drawing.Point(146, 469);
            this.btnViewEndVertices.Name = "btnViewEndVertices";
            this.btnViewEndVertices.Size = new System.Drawing.Size(120, 23);
            this.btnViewEndVertices.TabIndex = 5;
            this.btnViewEndVertices.Text = "Кінцеві вершини";
            this.btnViewEndVertices.UseVisualStyleBackColor = true;
            this.btnViewEndVertices.Click += new System.EventHandler(this.BtnViewEndVertices_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Легенда:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 566);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Вершини";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 566);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Ізольовані вершини";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 544);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Ребра";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(866, 566);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Кінцеві вершини";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Матриця суміжності:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Граф:";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxNotes.Location = new System.Drawing.Point(20, 498);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(246, 53);
            this.textBoxNotes.TabIndex = 7;
            // 
            // btnFindTheWay
            // 
            this.btnFindTheWay.Location = new System.Drawing.Point(20, 577);
            this.btnFindTheWay.Name = "btnFindTheWay";
            this.btnFindTheWay.Size = new System.Drawing.Size(120, 23);
            this.btnFindTheWay.TabIndex = 8;
            this.btnFindTheWay.Text = "Пошук маршруту";
            this.btnFindTheWay.UseVisualStyleBackColor = true;
            this.btnFindTheWay.Click += new System.EventHandler(this.BtnFindTheWay_Click);
            // 
            // btnAutoGraphSymm
            // 
            this.btnAutoGraphSymm.Location = new System.Drawing.Point(457, 6);
            this.btnAutoGraphSymm.Name = "btnAutoGraphSymm";
            this.btnAutoGraphSymm.Size = new System.Drawing.Size(193, 23);
            this.btnAutoGraphSymm.TabIndex = 2;
            this.btnAutoGraphSymm.Text = "Згенерувати симетричну матрицю";
            this.btnAutoGraphSymm.UseVisualStyleBackColor = true;
            this.btnAutoGraphSymm.Click += new System.EventHandler(this.BtnAutoGraphSymm_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Лаб. 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 559);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Лаб. 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(180, 559);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Лаб. 3";
            // 
            // btnBackupWindow
            // 
            this.btnBackupWindow.Location = new System.Drawing.Point(179, 577);
            this.btnBackupWindow.Name = "btnBackupWindow";
            this.btnBackupWindow.Size = new System.Drawing.Size(195, 23);
            this.btnBackupWindow.TabIndex = 9;
            this.btnBackupWindow.Text = "Задача пошуку бекап-множин";
            this.btnBackupWindow.UseVisualStyleBackColor = true;
            this.btnBackupWindow.Click += new System.EventHandler(this.BtnBackupWindow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 612);
            this.Controls.Add(this.btnBackupWindow);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAutoGraphSymm);
            this.Controls.Add(this.btnFindTheWay);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnViewEndVertices);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnViewIsolatedVertices);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnShowDegreesForm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnManualGraph);
            this.Controls.Add(this.btnAutoGraph);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSetN);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MainForm";
            this.Text = "Задання графу матрицею суміжності";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSetN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAutoGraph;
        private System.Windows.Forms.Button btnManualGraph;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowDegreesForm;
        private System.Windows.Forms.Button btnViewIsolatedVertices;
        private System.Windows.Forms.Button btnViewEndVertices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Button btnFindTheWay;
        private System.Windows.Forms.Button btnAutoGraphSymm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBackupWindow;
    }
}

