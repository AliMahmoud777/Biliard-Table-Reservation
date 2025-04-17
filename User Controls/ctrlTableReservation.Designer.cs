namespace BiliardTableReservation
{
    partial class ctrlTableReservation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.nudHourlyPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.TableTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourlyPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::BiliardTableReservation.Properties.Resources.Table;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.BackColor = System.Drawing.SystemColors.Control;
            this.lblTableName.Font = new System.Drawing.Font("Tahoma", 17F);
            this.lblTableName.Location = new System.Drawing.Point(92, 12);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(87, 28);
            this.lblTableName.TabIndex = 1;
            this.lblTableName.Text = "Table 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Owner:";
            // 
            // txtOwner
            // 
            this.txtOwner.BackColor = System.Drawing.SystemColors.Control;
            this.txtOwner.Location = new System.Drawing.Point(97, 73);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(152, 20);
            this.txtOwner.TabIndex = 3;
            // 
            // nudHourlyPrice
            // 
            this.nudHourlyPrice.Location = new System.Drawing.Point(106, 154);
            this.nudHourlyPrice.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHourlyPrice.Name = "nudHourlyPrice";
            this.nudHourlyPrice.Size = new System.Drawing.Size(120, 20);
            this.nudHourlyPrice.TabIndex = 4;
            this.nudHourlyPrice.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hourly Price :";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(20, 229);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 30);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Brown;
            this.btnEnd.Enabled = false;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(153, 229);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(96, 30);
            this.btnEnd.TabIndex = 8;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // TableTimer
            // 
            this.TableTimer.Interval = 1000;
            this.TableTimer.Tick += new System.EventHandler(this.TableTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(232, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "$";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.SystemColors.Control;
            this.lblMin.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.Black;
            this.lblMin.Location = new System.Drawing.Point(117, 192);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(36, 24);
            this.lblMin.TabIndex = 10;
            this.lblMin.Text = "00";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.BackColor = System.Drawing.SystemColors.Control;
            this.lblHour.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.Color.Black;
            this.lblHour.Location = new System.Drawing.Point(64, 192);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(36, 24);
            this.lblHour.TabIndex = 11;
            this.lblHour.Text = "00";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.BackColor = System.Drawing.SystemColors.Control;
            this.lblSec.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.ForeColor = System.Drawing.Color.Black;
            this.lblSec.Location = new System.Drawing.Point(163, 192);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(36, 24);
            this.lblSec.TabIndex = 12;
            this.lblSec.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(149, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(100, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = ":";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(83, 270);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 30);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ctrlTableReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudHourlyPrice);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ctrlTableReservation";
            this.Size = new System.Drawing.Size(270, 308);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourlyPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.NumericUpDown nudHourlyPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Timer TableTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReset;
    }
}
