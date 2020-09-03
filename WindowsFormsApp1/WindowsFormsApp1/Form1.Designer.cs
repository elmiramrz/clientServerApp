namespace WindowsFormsApp1
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
            this.lmsg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tmsgtoserver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lans = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lmsg
            // 
            this.lmsg.AutoSize = true;
            this.lmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmsg.Location = new System.Drawing.Point(86, 50);
            this.lmsg.MaximumSize = new System.Drawing.Size(300, 100);
            this.lmsg.MinimumSize = new System.Drawing.Size(300, 100);
            this.lmsg.Name = "lmsg";
            this.lmsg.Size = new System.Drawing.Size(300, 100);
            this.lmsg.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 336);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(164, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send To Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmsgtoserver
            // 
            this.tmsgtoserver.Location = new System.Drawing.Point(72, 245);
            this.tmsgtoserver.MaximumSize = new System.Drawing.Size(700, 60);
            this.tmsgtoserver.MinimumSize = new System.Drawing.Size(700, 60);
            this.tmsgtoserver.Name = "tmsgtoserver";
            this.tmsgtoserver.Size = new System.Drawing.Size(700, 22);
            this.tmsgtoserver.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Write The message to Server : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lans
            // 
            this.lans.AutoSize = true;
            this.lans.Location = new System.Drawing.Point(352, 180);
            this.lans.Name = "lans";
            this.lans.Size = new System.Drawing.Size(0, 17);
            this.lans.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tmsgtoserver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lmsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lmsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tmsgtoserver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lans;
    }
}

