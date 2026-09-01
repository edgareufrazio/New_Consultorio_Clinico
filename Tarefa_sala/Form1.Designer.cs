namespace tarefa_sala
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
            btn_conexao = new Button();
            SuspendLayout();
            // 
            // btn_conexao
            // 
            btn_conexao.Location = new Point(633, 12);
            btn_conexao.Name = "btn_conexao";
            btn_conexao.Size = new Size(155, 23);
            btn_conexao.TabIndex = 0;
            btn_conexao.Text = "Teste conexão";
            btn_conexao.UseVisualStyleBackColor = true;
            btn_conexao.Click += btn_conexao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_conexao);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_conexao;
    }
}
