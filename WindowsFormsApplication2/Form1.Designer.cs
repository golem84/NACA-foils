namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textProfile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textChord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAngle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.textNPoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtz = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textProfile
            // 
            this.textProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textProfile.Location = new System.Drawing.Point(13, 13);
            this.textProfile.Margin = new System.Windows.Forms.Padding(4);
            this.textProfile.MaxLength = 4;
            this.textProfile.Name = "textProfile";
            this.textProfile.Size = new System.Drawing.Size(91, 24);
            this.textProfile.TabIndex = 0;
            this.textProfile.Text = "0012";
            this.textProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(126, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер профиля, ХХХХ";
            // 
            // textChord
            // 
            this.textChord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textChord.Location = new System.Drawing.Point(13, 45);
            this.textChord.Margin = new System.Windows.Forms.Padding(4);
            this.textChord.MaxLength = 6;
            this.textChord.Name = "textChord";
            this.textChord.Size = new System.Drawing.Size(91, 24);
            this.textChord.TabIndex = 1;
            this.textChord.Text = "25.4";
            this.textChord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(126, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Длина хорды, мм";
            // 
            // textAngle
            // 
            this.textAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAngle.Location = new System.Drawing.Point(13, 109);
            this.textAngle.Margin = new System.Windows.Forms.Padding(4);
            this.textAngle.MaxLength = 6;
            this.textAngle.Name = "textAngle";
            this.textAngle.Size = new System.Drawing.Size(91, 24);
            this.textAngle.TabIndex = 3;
            this.textAngle.Text = "3.5";
            this.textAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(126, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Угол атаки, град";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 179);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 53);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(186, 179);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(110, 53);
            this.btnOutput.TabIndex = 7;
            this.btnOutput.Text = "Вывести в файл";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(357, 48);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(56, 53);
            this.btnGraph.TabIndex = 7;
            this.btnGraph.UseVisualStyleBackColor = true;
            // 
            // textNPoint
            // 
            this.textNPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textNPoint.Location = new System.Drawing.Point(13, 141);
            this.textNPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textNPoint.MaxLength = 4;
            this.textNPoint.Name = "textNPoint";
            this.textNPoint.Size = new System.Drawing.Size(91, 24);
            this.textNPoint.TabIndex = 4;
            this.textNPoint.Text = "50";
            this.textNPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(126, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Количество точек";
            // 
            // txtz
            // 
            this.txtz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtz.Location = new System.Drawing.Point(13, 77);
            this.txtz.Margin = new System.Windows.Forms.Padding(4);
            this.txtz.MaxLength = 6;
            this.txtz.Name = "txtz";
            this.txtz.Size = new System.Drawing.Size(91, 24);
            this.txtz.TabIndex = 2;
            this.txtz.Text = "20";
            this.txtz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(126, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Положение по оси Z, мм";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(443, 247);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNPoint);
            this.Controls.Add(this.textAngle);
            this.Controls.Add(this.txtz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textChord);
            this.Controls.Add(this.textProfile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "NACA 4-digit foil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textChord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.TextBox textNPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtz;
        private System.Windows.Forms.Label label5;


    }
}

