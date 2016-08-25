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
            this.Layout = new System.Windows.Forms.TableLayoutPanel();
            this.Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(3, 3);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(353, 292);
            this.Canvas.TabIndex = 0;
            this.Canvas.Resize += new System.EventHandler(this.Canvas_Resize);
            // 
            // btnNextPhase
            // 
            this.btnNextPhase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextPhase.Location = new System.Drawing.Point(3, 301);
            this.btnNextPhase.Name = "btnNextPhase";
            this.btnNextPhase.Size = new System.Drawing.Size(353, 29);
            this.btnNextPhase.TabIndex = 1;
            this.btnNextPhase.Text = "Next Phase";
            this.btnNextPhase.UseVisualStyleBackColor = true;
            this.btnNextPhase.Click += new System.EventHandler(this.btnNextPhase_Click);
            // 
            // Layout
            // 
            this.Layout.ColumnCount = 1;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout.Controls.Add(this.Canvas, 0, 0);
            this.Layout.Controls.Add(this.btnNextPhase, 0, 1);
            this.Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout.Location = new System.Drawing.Point(0, 0);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 2;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.Layout.Size = new System.Drawing.Size(359, 333);
            this.Layout.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 333);
            this.Controls.Add(this.Layout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(50, 50);
            this.Name = "Main";
            this.Text = "Zulrah Rotation Assitant";
            this.TopMost = true;
            this.Layout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Button btnNextPhase;
        private System.Windows.Forms.TableLayoutPanel Layout;
    }
}