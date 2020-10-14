namespace PromotionEngineUI
{
    partial class PromEngineUI
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.numericA = new System.Windows.Forms.NumericUpDown();
            this.numericB = new System.Windows.Forms.NumericUpDown();
            this.numericC = new System.Windows.Forms.NumericUpDown();
            this.numericD = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(114, 80);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 17);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(114, 118);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 17);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(114, 156);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(17, 17);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "C";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(114, 193);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(18, 17);
            this.lblD.TabIndex = 3;
            this.lblD.Text = "D";
            // 
            // numericA
            // 
            this.numericA.Location = new System.Drawing.Point(165, 80);
            this.numericA.Name = "numericA";
            this.numericA.Size = new System.Drawing.Size(120, 22);
            this.numericA.TabIndex = 4;
            // 
            // numericB
            // 
            this.numericB.Location = new System.Drawing.Point(165, 118);
            this.numericB.Name = "numericB";
            this.numericB.Size = new System.Drawing.Size(120, 22);
            this.numericB.TabIndex = 5;
            // 
            // numericC
            // 
            this.numericC.Location = new System.Drawing.Point(165, 156);
            this.numericC.Name = "numericC";
            this.numericC.Size = new System.Drawing.Size(120, 22);
            this.numericC.TabIndex = 6;
            // 
            // numericD
            // 
            this.numericD.Location = new System.Drawing.Point(165, 193);
            this.numericD.Name = "numericD";
            this.numericD.Size = new System.Drawing.Size(120, 22);
            this.numericD.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(165, 254);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 28);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Click to Run";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 9;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(1, 315);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(158, 17);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "The Total Order Value :";
            // 
            // PromEngineUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.numericD);
            this.Controls.Add(this.numericC);
            this.Controls.Add(this.numericB);
            this.Controls.Add(this.numericA);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "PromEngineUI";
            this.Text = "Promotion Engine";
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.NumericUpDown numericA;
        private System.Windows.Forms.NumericUpDown numericB;
        private System.Windows.Forms.NumericUpDown numericC;
        private System.Windows.Forms.NumericUpDown numericD;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessage;
    }
}

