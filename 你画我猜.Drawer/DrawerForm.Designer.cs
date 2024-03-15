namespace 你画我猜.Drawer
{
    partial class DrawerForm
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
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.NextButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.PencilPictureBox = new System.Windows.Forms.PictureBox();
            this.EraserPictureBox = new System.Windows.Forms.PictureBox();
            this.Canvas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FruitLabel = new System.Windows.Forms.Label();
            this.ToolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PencilPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EraserPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolPanel
            // 
            this.ToolPanel.Controls.Add(this.NextButton);
            this.ToolPanel.Controls.Add(this.clearButton);
            this.ToolPanel.Controls.Add(this.PencilPictureBox);
            this.ToolPanel.Controls.Add(this.EraserPictureBox);
            this.ToolPanel.Location = new System.Drawing.Point(12, 125);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(150, 313);
            this.ToolPanel.TabIndex = 0;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.White;
            this.NextButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(0, 237);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(150, 38);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "下一个";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(0, 275);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 38);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // PencilPictureBox
            // 
            this.PencilPictureBox.Image = global::你画我猜.Drawer.Properties.Resources.pencil;
            this.PencilPictureBox.Location = new System.Drawing.Point(-322, 19);
            this.PencilPictureBox.Name = "PencilPictureBox";
            this.PencilPictureBox.Size = new System.Drawing.Size(451, 99);
            this.PencilPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PencilPictureBox.TabIndex = 2;
            this.PencilPictureBox.TabStop = false;
            this.PencilPictureBox.Click += new System.EventHandler(this.PencilPictureBox_Click);
            // 
            // EraserPictureBox
            // 
            this.EraserPictureBox.Image = global::你画我猜.Drawer.Properties.Resources.eraser;
            this.EraserPictureBox.Location = new System.Drawing.Point(-324, 124);
            this.EraserPictureBox.Name = "EraserPictureBox";
            this.EraserPictureBox.Size = new System.Drawing.Size(453, 107);
            this.EraserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EraserPictureBox.TabIndex = 1;
            this.EraserPictureBox.TabStop = false;
            this.EraserPictureBox.Click += new System.EventHandler(this.EraserPictureBox_Click);
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Location = new System.Drawing.Point(186, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(509, 426);
            this.Canvas.TabIndex = 1;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "猜水果：";
            // 
            // FruitLabel
            // 
            this.FruitLabel.AutoSize = true;
            this.FruitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FruitLabel.Location = new System.Drawing.Point(12, 62);
            this.FruitLabel.Name = "FruitLabel";
            this.FruitLabel.Size = new System.Drawing.Size(0, 37);
            this.FruitLabel.TabIndex = 3;
            // 
            // DrawerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.FruitLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.ToolPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DrawerForm";
            this.Text = "你画我猜 - Drawer";
            this.ToolPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PencilPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EraserPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.PictureBox EraserPictureBox;
        private System.Windows.Forms.PictureBox PencilPictureBox;
        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label FruitLabel;
    }
}

