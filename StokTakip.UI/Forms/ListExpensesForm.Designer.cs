namespace StokTakip.UI.Forms
{
    partial class ListExpensesForm
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
            System.Windows.Forms.Panel FooterPanel;
            this.ExpenseListControl = new StokTakip.UI.Controls.ExpenseListControl();
            this.StatusTextLabel = new System.Windows.Forms.Label();
            this.StatusPictureBox = new System.Windows.Forms.PictureBox();
            FooterPanel = new System.Windows.Forms.Panel();
            FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpenseListControl
            // 
            this.ExpenseListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpenseListControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExpenseListControl.Location = new System.Drawing.Point(0, 0);
            this.ExpenseListControl.Name = "ExpenseListControl";
            this.ExpenseListControl.Size = new System.Drawing.Size(855, 446);
            this.ExpenseListControl.TabIndex = 0;
            // 
            // FooterPanel
            // 
            FooterPanel.Controls.Add(this.StatusTextLabel);
            FooterPanel.Controls.Add(this.StatusPictureBox);
            FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            FooterPanel.Location = new System.Drawing.Point(0, 446);
            FooterPanel.Name = "FooterPanel";
            FooterPanel.Size = new System.Drawing.Size(855, 24);
            FooterPanel.TabIndex = 4;
            // 
            // StatusTextLabel
            // 
            this.StatusTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusTextLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusTextLabel.Location = new System.Drawing.Point(24, 0);
            this.StatusTextLabel.Name = "StatusTextLabel";
            this.StatusTextLabel.Size = new System.Drawing.Size(831, 24);
            this.StatusTextLabel.TabIndex = 0;
            this.StatusTextLabel.Text = "Hazır";
            this.StatusTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusPictureBox
            // 
            this.StatusPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.StatusPictureBox.Location = new System.Drawing.Point(0, 0);
            this.StatusPictureBox.Name = "StatusPictureBox";
            this.StatusPictureBox.Size = new System.Drawing.Size(24, 24);
            this.StatusPictureBox.TabIndex = 0;
            this.StatusPictureBox.TabStop = false;
            // 
            // ListExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 470);
            this.Controls.Add(this.ExpenseListControl);
            this.Controls.Add(FooterPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ListExpensesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tüm Giderler Listesi";
            FooterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ExpenseListControl ExpenseListControl;
        private System.Windows.Forms.Label StatusTextLabel;
        private System.Windows.Forms.PictureBox StatusPictureBox;
    }
}