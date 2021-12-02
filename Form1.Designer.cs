
namespace Laba4_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarC = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).BeginInit();
            this.SuspendLayout();
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(48, 213);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(175, 26);
            this.tbA.TabIndex = 0;
            this.tbA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbA_KeyDown);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(299, 213);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(175, 26);
            this.tbB.TabIndex = 1;
            this.tbB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbB_KeyDown);
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(570, 213);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(175, 26);
            this.tbC.TabIndex = 2;
            this.tbC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbC_KeyDown);
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(48, 267);
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(175, 26);
            this.numericUpDownA.TabIndex = 3;
            this.numericUpDownA.ValueChanged += new System.EventHandler(this.numericUpDownA_ValueChanged);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(299, 267);
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(175, 26);
            this.numericUpDownB.TabIndex = 4;
            this.numericUpDownB.ValueChanged += new System.EventHandler(this.numericUpDownB_ValueChanged);
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.Location = new System.Drawing.Point(570, 267);
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(175, 26);
            this.numericUpDownC.TabIndex = 5;
            this.numericUpDownC.ValueChanged += new System.EventHandler(this.numericUpDownC_ValueChanged);
            // 
            // trackBarA
            // 
            this.trackBarA.LargeChange = 100;
            this.trackBarA.Location = new System.Drawing.Point(48, 321);
            this.trackBarA.Maximum = 100;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(175, 69);
            this.trackBarA.TabIndex = 6;
            this.trackBarA.Scroll += new System.EventHandler(this.trackBarA_Scroll);
            // 
            // trackBarB
            // 
            this.trackBarB.LargeChange = 100;
            this.trackBarB.Location = new System.Drawing.Point(299, 321);
            this.trackBarB.Maximum = 100;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(175, 69);
            this.trackBarB.TabIndex = 7;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // trackBarC
            // 
            this.trackBarC.Location = new System.Drawing.Point(570, 321);
            this.trackBarC.Maximum = 100;
            this.trackBarC.Name = "trackBarC";
            this.trackBarC.Size = new System.Drawing.Size(175, 69);
            this.trackBarC.TabIndex = 8;
            this.trackBarC.Scroll += new System.EventHandler(this.trackBarC_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(75, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 124);
            this.label1.TabIndex = 9;
            this.label1.Text = "A <= B <= C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarC);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarA);
            this.Controls.Add(this.numericUpDownC);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.numericUpDownA);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.NumericUpDown numericUpDownC;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarC;
        private System.Windows.Forms.Label label1;
    }
}

