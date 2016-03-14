namespace CreateCoverLetter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.companyBox = new System.Windows.Forms.TextBox();
            this.positionBox = new System.Windows.Forms.TextBox();
            this.reqID = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.experienceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(47, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Position Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(47, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "ReqID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(52, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location";
            // 
            // companyBox
            // 
            this.companyBox.Location = new System.Drawing.Point(409, 47);
            this.companyBox.Name = "companyBox";
            this.companyBox.Size = new System.Drawing.Size(454, 31);
            this.companyBox.TabIndex = 4;
            // 
            // positionBox
            // 
            this.positionBox.Location = new System.Drawing.Point(409, 118);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(454, 31);
            this.positionBox.TabIndex = 5;
            // 
            // reqID
            // 
            this.reqID.Location = new System.Drawing.Point(409, 188);
            this.reqID.Name = "reqID";
            this.reqID.Size = new System.Drawing.Size(454, 31);
            this.reqID.TabIndex = 6;
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(409, 256);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(454, 31);
            this.location.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(409, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Get Cover Letter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // experienceBox
            // 
            this.experienceBox.Location = new System.Drawing.Point(409, 327);
            this.experienceBox.Name = "experienceBox";
            this.experienceBox.Size = new System.Drawing.Size(454, 31);
            this.experienceBox.TabIndex = 9;
            this.experienceBox.Text = "C#/ASP.NET/Java/JavaScript/SQL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(52, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Experience";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 497);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.experienceBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.location);
            this.Controls.Add(this.reqID);
            this.Controls.Add(this.positionBox);
            this.Controls.Add(this.companyBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox companyBox;
        private System.Windows.Forms.TextBox positionBox;
        private System.Windows.Forms.TextBox reqID;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox experienceBox;
        private System.Windows.Forms.Label label5;
    }
}

