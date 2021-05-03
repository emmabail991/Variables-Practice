
namespace buttons
{
    partial class textBox
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
            this.hockey = new System.Windows.Forms.Button();
            this.area = new System.Windows.Forms.Button();
            this.carpet = new System.Windows.Forms.Button();
            this.bill = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hockey
            // 
            this.hockey.Location = new System.Drawing.Point(12, 15);
            this.hockey.Name = "hockey";
            this.hockey.Size = new System.Drawing.Size(75, 35);
            this.hockey.TabIndex = 1;
            this.hockey.Text = "Hockey";
            this.hockey.UseVisualStyleBackColor = true;
            this.hockey.Click += new System.EventHandler(this.hockey_Click);
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(12, 90);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(75, 35);
            this.area.TabIndex = 2;
            this.area.Text = "Area";
            this.area.UseVisualStyleBackColor = true;
            this.area.Click += new System.EventHandler(this.area_Click);
            // 
            // carpet
            // 
            this.carpet.Location = new System.Drawing.Point(12, 165);
            this.carpet.Name = "carpet";
            this.carpet.Size = new System.Drawing.Size(75, 35);
            this.carpet.TabIndex = 3;
            this.carpet.Text = "Carpet";
            this.carpet.UseVisualStyleBackColor = true;
            this.carpet.Click += new System.EventHandler(this.carpet_Click);
            // 
            // bill
            // 
            this.bill.Location = new System.Drawing.Point(12, 240);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(75, 35);
            this.bill.TabIndex = 4;
            this.bill.Text = "Bill";
            this.bill.UseVisualStyleBackColor = true;
            this.bill.Click += new System.EventHandler(this.bill_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.outputLabel.Location = new System.Drawing.Point(107, 15);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(305, 260);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = " ";
            // 
            // textBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(424, 322);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.carpet);
            this.Controls.Add(this.area);
            this.Controls.Add(this.hockey);
            this.Name = "textBox";
            this.Text = "Variables Practice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hockey;
        private System.Windows.Forms.Button area;
        private System.Windows.Forms.Button carpet;
        private System.Windows.Forms.Button bill;
        private System.Windows.Forms.Label outputLabel;
    }
}

