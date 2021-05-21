namespace maze_solver
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
            this.startProgram = new System.Windows.Forms.Button();
            this.mazeLayoutX = new System.Windows.Forms.NumericUpDown();
            this.mazeLayoutY = new System.Windows.Forms.NumericUpDown();
            this.labelLayoutX = new System.Windows.Forms.Label();
            this.labelLayoutY = new System.Windows.Forms.Label();
            this.uploadMaze = new System.Windows.Forms.Button();
            this.exportMaze = new System.Windows.Forms.Button();
            this.solveMaze = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mazeLayoutX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazeLayoutY)).BeginInit();
            this.SuspendLayout();
            // 
            // startProgram
            // 
            this.startProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startProgram.Location = new System.Drawing.Point(3, 103);
            this.startProgram.Name = "startProgram";
            this.startProgram.Size = new System.Drawing.Size(380, 33);
            this.startProgram.TabIndex = 0;
            this.startProgram.Text = "START";
            this.startProgram.UseVisualStyleBackColor = true;
            this.startProgram.Click += new System.EventHandler(this.startProgram_Click);
            // 
            // mazeLayoutX
            // 
            this.mazeLayoutX.Location = new System.Drawing.Point(24, 12);
            this.mazeLayoutX.Name = "mazeLayoutX";
            this.mazeLayoutX.Size = new System.Drawing.Size(56, 20);
            this.mazeLayoutX.TabIndex = 1;
            this.mazeLayoutX.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // mazeLayoutY
            // 
            this.mazeLayoutY.Location = new System.Drawing.Point(24, 38);
            this.mazeLayoutY.Name = "mazeLayoutY";
            this.mazeLayoutY.Size = new System.Drawing.Size(56, 20);
            this.mazeLayoutY.TabIndex = 2;
            this.mazeLayoutY.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // labelLayoutX
            // 
            this.labelLayoutX.AutoSize = true;
            this.labelLayoutX.Location = new System.Drawing.Point(1, 14);
            this.labelLayoutX.Name = "labelLayoutX";
            this.labelLayoutX.Size = new System.Drawing.Size(17, 13);
            this.labelLayoutX.TabIndex = 3;
            this.labelLayoutX.Text = "X:";
            // 
            // labelLayoutY
            // 
            this.labelLayoutY.AutoSize = true;
            this.labelLayoutY.Location = new System.Drawing.Point(1, 40);
            this.labelLayoutY.Name = "labelLayoutY";
            this.labelLayoutY.Size = new System.Drawing.Size(17, 13);
            this.labelLayoutY.TabIndex = 4;
            this.labelLayoutY.Text = "Y:";
            // 
            // uploadMaze
            // 
            this.uploadMaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadMaze.Location = new System.Drawing.Point(291, 6);
            this.uploadMaze.Name = "uploadMaze";
            this.uploadMaze.Size = new System.Drawing.Size(92, 28);
            this.uploadMaze.TabIndex = 5;
            this.uploadMaze.Text = "Upload Maze";
            this.uploadMaze.UseVisualStyleBackColor = true;
            this.uploadMaze.Click += new System.EventHandler(this.uploadMaze_Click);
            // 
            // exportMaze
            // 
            this.exportMaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportMaze.Location = new System.Drawing.Point(3, 6);
            this.exportMaze.Name = "exportMaze";
            this.exportMaze.Size = new System.Drawing.Size(77, 26);
            this.exportMaze.TabIndex = 6;
            this.exportMaze.Text = "Export Maze";
            this.exportMaze.UseVisualStyleBackColor = true;
            this.exportMaze.Visible = false;
            this.exportMaze.Click += new System.EventHandler(this.exportMaze_Click);
            // 
            // solveMaze
            // 
            this.solveMaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solveMaze.Location = new System.Drawing.Point(86, 6);
            this.solveMaze.Name = "solveMaze";
            this.solveMaze.Size = new System.Drawing.Size(77, 26);
            this.solveMaze.TabIndex = 7;
            this.solveMaze.Text = "Solve Maze";
            this.solveMaze.UseVisualStyleBackColor = true;
            this.solveMaze.Visible = false;
            this.solveMaze.Click += new System.EventHandler(this.solveMaze_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 148);
            this.Controls.Add(this.solveMaze);
            this.Controls.Add(this.exportMaze);
            this.Controls.Add(this.uploadMaze);
            this.Controls.Add(this.labelLayoutY);
            this.Controls.Add(this.labelLayoutX);
            this.Controls.Add(this.mazeLayoutY);
            this.Controls.Add(this.mazeLayoutX);
            this.Controls.Add(this.startProgram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mazeLayoutX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazeLayoutY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startProgram;
        private System.Windows.Forms.NumericUpDown mazeLayoutX;
        private System.Windows.Forms.NumericUpDown mazeLayoutY;
        private System.Windows.Forms.Label labelLayoutX;
        private System.Windows.Forms.Label labelLayoutY;
        private System.Windows.Forms.Button uploadMaze;
        private System.Windows.Forms.Button exportMaze;
        private System.Windows.Forms.Button solveMaze;
    }
}

