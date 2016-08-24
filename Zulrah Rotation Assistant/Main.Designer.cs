namespace Zulrah_Rotation_Assistant {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Canvas = new System.Windows.Forms.Panel();
            this.btnNextPhase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.Canvas.Location = new System.Drawing.Point(10, 8);
            this.Canvas.Margin = new System.Windows.Forms.Padding(10);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(337, 277);
            this.Canvas.TabIndex = 0;
            this.Canvas.Resize += new System.EventHandler(this.Canvas_Resize);
            // 
            // btnNextPhase
            // 
            this.btnNextPhase.Location = new System.Drawing.Point(272, 298);
            this.btnNextPhase.Name = "btnNextPhase";
            this.btnNextPhase.Size = new System.Drawing.Size(75, 23);
            this.btnNextPhase.TabIndex = 1;
            this.btnNextPhase.Text = "Next Phase";
            this.btnNextPhase.UseVisualStyleBackColor = true;
            this.btnNextPhase.Click += new System.EventHandler(this.btnNextPhase_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 333);
            this.Controls.Add(this.btnNextPhase);
            this.Controls.Add(this.Canvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(50, 50);
            this.Name = "Main";
            this.Text = "Zulrah Rotation Assitant";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Button btnNextPhase;
    }
}