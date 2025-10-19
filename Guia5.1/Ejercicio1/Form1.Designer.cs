namespace Ejercicio1
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
            tbList = new TextBox();
            rbString = new RadioButton();
            rbRegex = new RadioButton();
            btnProcesar = new Button();
            SuspendLayout();
            // 
            // tbList
            // 
            tbList.Location = new Point(33, 33);
            tbList.Multiline = true;
            tbList.Name = "tbList";
            tbList.ScrollBars = ScrollBars.Vertical;
            tbList.Size = new Size(376, 146);
            tbList.TabIndex = 0;
            // 
            // rbString
            // 
            rbString.AutoSize = true;
            rbString.Location = new Point(446, 33);
            rbString.Name = "rbString";
            rbString.Size = new Size(56, 19);
            rbString.TabIndex = 1;
            rbString.TabStop = true;
            rbString.Text = "String";
            rbString.UseVisualStyleBackColor = true;
            // 
            // rbRegex
            // 
            rbRegex.AutoSize = true;
            rbRegex.Location = new Point(446, 58);
            rbRegex.Name = "rbRegex";
            rbRegex.Size = new Size(56, 19);
            rbRegex.TabIndex = 2;
            rbRegex.TabStop = true;
            rbRegex.Text = "Regex";
            rbRegex.UseVisualStyleBackColor = true;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(446, 115);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(94, 64);
            btnProcesar.TabIndex = 3;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 243);
            Controls.Add(btnProcesar);
            Controls.Add(rbRegex);
            Controls.Add(rbString);
            Controls.Add(tbList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox tbList;
        private RadioButton rbString;
        private RadioButton rbRegex;
        private Button btnProcesar;
    }
}
