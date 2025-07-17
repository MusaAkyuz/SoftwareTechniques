namespace AdminRightsSetupDemo
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
            btn_openCmd = new Button();
            SuspendLayout();
            // 
            // btn_openCmd
            // 
            btn_openCmd.Location = new Point(12, 12);
            btn_openCmd.Name = "btn_openCmd";
            btn_openCmd.Size = new Size(75, 23);
            btn_openCmd.TabIndex = 0;
            btn_openCmd.Text = "OpenCmd";
            btn_openCmd.UseVisualStyleBackColor = true;
            btn_openCmd.Click += btn_openCmd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_openCmd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_openCmd;
    }
}
