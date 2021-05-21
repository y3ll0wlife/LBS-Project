namespace drawing_app
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
            this.drawingCanvas = new System.Windows.Forms.Panel();
            this.colorPicker = new System.Windows.Forms.Button();
            this.color2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.color1 = new System.Windows.Forms.Panel();
            this.color2Selected = new System.Windows.Forms.Button();
            this.color1Selected = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.penWidthSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.penWidthSize)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingCanvas
            // 
            this.drawingCanvas.BackColor = System.Drawing.Color.White;
            this.drawingCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingCanvas.Location = new System.Drawing.Point(12, 95);
            this.drawingCanvas.Name = "drawingCanvas";
            this.drawingCanvas.Size = new System.Drawing.Size(742, 466);
            this.drawingCanvas.TabIndex = 0;
            this.drawingCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingCanvas_MouseDown);
            this.drawingCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingCanvas_MouseMove);
            // 
            // colorPicker
            // 
            this.colorPicker.Location = new System.Drawing.Point(626, 12);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(128, 77);
            this.colorPicker.TabIndex = 0;
            this.colorPicker.Text = "Change Color";
            this.colorPicker.UseVisualStyleBackColor = true;
            this.colorPicker.Click += new System.EventHandler(this.colorPicker_Click);
            // 
            // color2
            // 
            this.color2.BackColor = System.Drawing.Color.White;
            this.color2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color2.Location = new System.Drawing.Point(563, 26);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(43, 36);
            this.color2.TabIndex = 1;
            this.color2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color2_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(566, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Färg 2";
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.Black;
            this.color1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color1.Location = new System.Drawing.Point(479, 26);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(43, 36);
            this.color1.TabIndex = 5;
            this.color1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color1_MouseClick);
            // 
            // color2Selected
            // 
            this.color2Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.color2Selected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.color2Selected.Location = new System.Drawing.Point(546, 12);
            this.color2Selected.Name = "color2Selected";
            this.color2Selected.Size = new System.Drawing.Size(75, 77);
            this.color2Selected.TabIndex = 0;
            this.color2Selected.UseVisualStyleBackColor = false;
            this.color2Selected.Visible = false;
            // 
            // color1Selected
            // 
            this.color1Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.color1Selected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.color1Selected.Location = new System.Drawing.Point(461, 12);
            this.color1Selected.Name = "color1Selected";
            this.color1Selected.Size = new System.Drawing.Size(75, 77);
            this.color1Selected.TabIndex = 6;
            this.color1Selected.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(482, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Färg 1";
            // 
            // penWidthSize
            // 
            this.penWidthSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penWidthSize.Location = new System.Drawing.Point(335, 40);
            this.penWidthSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.penWidthSize.Name = "penWidthSize";
            this.penWidthSize.Size = new System.Drawing.Size(120, 26);
            this.penWidthSize.TabIndex = 9;
            this.penWidthSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Storlek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 573);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.penWidthSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.color1Selected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.colorPicker);
            this.Controls.Add(this.drawingCanvas);
            this.Controls.Add(this.color2Selected);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Pain 2: the prodigal son";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.penWidthSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drawingCanvas;
        private System.Windows.Forms.Button colorPicker;
        private System.Windows.Forms.Panel color2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel color1;
        private System.Windows.Forms.Button color2Selected;
        private System.Windows.Forms.Button color1Selected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown penWidthSize;
        private System.Windows.Forms.Label label3;
    }
}

