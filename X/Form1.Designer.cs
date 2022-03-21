namespace CaroGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelChessBoard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelChessBoard
            // 
            this.panelChessBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChessBoard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelChessBoard.Location = new System.Drawing.Point(10, 1);
            this.panelChessBoard.Name = "panelChessBoard";
            this.panelChessBoard.Size = new System.Drawing.Size(412, 411);
            this.panelChessBoard.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.panelChessBoard);
            this.Name = "Form1";
            this.Text = "X";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelChessBoard;
    }
}