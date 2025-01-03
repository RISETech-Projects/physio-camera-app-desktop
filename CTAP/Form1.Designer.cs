namespace CTAP
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStream = new System.Windows.Forms.Button();
            this.picBoxOne = new System.Windows.Forms.PictureBox();
            this.btnStopStream = new System.Windows.Forms.Button();
            this.picBoxTwo = new System.Windows.Forms.PictureBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.picBox4 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnStream, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.picBoxOne, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStopStream, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.picBoxTwo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.picBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.picBox4, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1139, 639);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnStream
            // 
            this.btnStream.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStream.Image = global::CTAP.Properties.Resources._191274_play_youtube_icon;
            this.btnStream.Location = new System.Drawing.Point(3, 569);
            this.btnStream.Name = "btnStream";
            this.btnStream.Size = new System.Drawing.Size(563, 67);
            this.btnStream.TabIndex = 0;
            this.btnStream.Text = "Stream";
            this.btnStream.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStream.UseVisualStyleBackColor = true;
            this.btnStream.Click += new System.EventHandler(this.btnStream_Click);
            // 
            // picBoxOne
            // 
            this.picBoxOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxOne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBoxOne.Location = new System.Drawing.Point(3, 3);
            this.picBoxOne.Name = "picBoxOne";
            this.picBoxOne.Size = new System.Drawing.Size(563, 277);
            this.picBoxOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxOne.TabIndex = 2;
            this.picBoxOne.TabStop = false;
            // 
            // btnStopStream
            // 
            this.btnStopStream.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopStream.Image = global::CTAP.Properties.Resources._48794_player_stop_icon;
            this.btnStopStream.Location = new System.Drawing.Point(572, 569);
            this.btnStopStream.Name = "btnStopStream";
            this.btnStopStream.Size = new System.Drawing.Size(564, 67);
            this.btnStopStream.TabIndex = 1;
            this.btnStopStream.Text = "Stop";
            this.btnStopStream.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStopStream.UseVisualStyleBackColor = true;
            this.btnStopStream.Click += new System.EventHandler(this.btnStopStream_Click);
            // 
            // picBoxTwo
            // 
            this.picBoxTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxTwo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBoxTwo.Location = new System.Drawing.Point(572, 3);
            this.picBoxTwo.Name = "picBoxTwo";
            this.picBoxTwo.Size = new System.Drawing.Size(564, 277);
            this.picBoxTwo.TabIndex = 3;
            this.picBoxTwo.TabStop = false;
            // 
            // picBox3
            // 
            this.picBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBox3.Location = new System.Drawing.Point(3, 286);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(563, 277);
            this.picBox3.TabIndex = 4;
            this.picBox3.TabStop = false;
            // 
            // picBox4
            // 
            this.picBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBox4.Location = new System.Drawing.Point(572, 286);
            this.picBox4.Name = "picBox4";
            this.picBox4.Size = new System.Drawing.Size(564, 277);
            this.picBox4.TabIndex = 5;
            this.picBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 641);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Chiropractic Training & Assessment Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStream;
        private System.Windows.Forms.Button btnStopStream;
        private System.Windows.Forms.PictureBox picBoxOne;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picBoxTwo;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.PictureBox picBox4;
    }
}

