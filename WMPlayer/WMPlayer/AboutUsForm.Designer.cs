namespace WMPlayer
{
    partial class AboutUsForm
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
            this.button_OK = new System.Windows.Forms.Button();
            this.label_Header = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.Location = new System.Drawing.Point(13, 389);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(234, 49);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "Ознакомлен";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_Header
            // 
            this.label_Header.AutoSize = true;
            this.label_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Header.Location = new System.Drawing.Point(37, 9);
            this.label_Header.Name = "label_Header";
            this.label_Header.Size = new System.Drawing.Size(180, 31);
            this.label_Header.TabIndex = 1;
            this.label_Header.Text = "О программе";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(40, 265);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(175, 13);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Супер Пупер Медиа Плеер v1.0.2";
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 450);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.label_Header);
            this.Controls.Add(this.button_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutUsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutUsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_Header;
        private System.Windows.Forms.Label label_Title;
    }
}