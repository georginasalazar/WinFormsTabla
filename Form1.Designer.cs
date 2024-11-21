namespace WinFormsTabla
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
            panelprincipal = new Panel();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            labeltitulo = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = Color.FromArgb(255, 224, 192);
            panelprincipal.Controls.Add(richTextBoxresultados);
            panelprincipal.Controls.Add(buttonver);
            panelprincipal.Controls.Add(textBoxnum);
            panelprincipal.Controls.Add(labelnumero);
            panelprincipal.Controls.Add(labeltitulo);
            panelprincipal.Location = new Point(15, 14);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(773, 424);
            panelprincipal.TabIndex = 0;
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxresultados.Location = new Point(322, 80);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(205, 242);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.BackColor = Color.White;
            buttonver.Location = new Point(95, 201);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(94, 29);
            buttonver.TabIndex = 3;
            buttonver.Text = "ver tabla";
            buttonver.UseVisualStyleBackColor = false;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(95, 142);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(125, 27);
            textBoxnum.TabIndex = 2;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelnumero.Location = new Point(86, 102);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(172, 26);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "¿Cual tabla quieres?";
            labelnumero.UseMnemonic = false;
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Location = new Point(80, 38);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(140, 20);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "Tabla de Multiplicar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private TextBox textBoxnum;
        private Label labelnumero;
        private Label labeltitulo;
        private RichTextBox richTextBoxresultados;
        private Button buttonver;
    }
}
