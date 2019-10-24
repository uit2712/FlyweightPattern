namespace DrawingImages
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
            this.pnlDrawingArea = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlDrawingArea
            // 
            this.pnlDrawingArea.AutoScroll = true;
            this.pnlDrawingArea.BackColor = System.Drawing.Color.White;
            this.pnlDrawingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDrawingArea.Location = new System.Drawing.Point(0, 0);
            this.pnlDrawingArea.Name = "pnlDrawingArea";
            this.pnlDrawingArea.Size = new System.Drawing.Size(527, 393);
            this.pnlDrawingArea.TabIndex = 0;
            this.pnlDrawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawingArea_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 393);
            this.Controls.Add(this.pnlDrawingArea);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawingArea;
    }
}

