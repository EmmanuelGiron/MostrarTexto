namespace WinFormsApp1
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
            btntexto = new Button();
            txt1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btntexto
            // 
            btntexto.Location = new Point(446, 121);
            btntexto.Name = "btntexto";
            btntexto.Size = new Size(94, 29);
            btntexto.TabIndex = 0;
            btntexto.Text = "Enviar";
            btntexto.UseVisualStyleBackColor = true;
            btntexto.Click += btntexto_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(258, 121);
            txt1.Name = "txt1";
            txt1.Size = new Size(125, 27);
            txt1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 209);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txt1);
            Controls.Add(btntexto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btntexto;
        private TextBox txt1;
        private Label label1;
    }
}