namespace Estoque.Formularios
{
    partial class FrmFrmQuantidadeValor
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
            lblProduto = new Label();
            nudQuantidade = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            BtnOK = new Button();
            BtnCancelar = new Button();
            TxtTotal = new TextBox();
            nudValor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            SuspendLayout();
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(12, 9);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(38, 15);
            lblProduto.TabIndex = 0;
            lblProduto.Text = "label1";
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(12, 48);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(120, 23);
            nudQuantidade.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 30);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 3;
            label2.Text = "Preço Unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 30);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Quantidade";
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(12, 77);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(120, 40);
            BtnOK.TabIndex = 5;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(282, 77);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(120, 40);
            BtnCancelar.TabIndex = 6;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // TxtTotal
            // 
            TxtTotal.Enabled = false;
            TxtTotal.Location = new Point(282, 47);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.Size = new Size(120, 23);
            TxtTotal.TabIndex = 7;
            // 
            // nudValor
            // 
            nudValor.Location = new Point(138, 48);
            nudValor.Name = "nudValor";
            nudValor.Size = new Size(138, 23);
            nudValor.TabIndex = 8;
            // 
            // FrmFrmQuantidadeValor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 125);
            Controls.Add(nudValor);
            Controls.Add(TxtTotal);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnOK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nudQuantidade);
            Controls.Add(lblProduto);
            Name = "FrmFrmQuantidadeValor";
            Text = "Quantidade e Valor";
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduto;
        private NumericUpDown nudQuantidade;
        private Label label2;
        private Label label3;
        private Button BtnOK;
        private Button BtnCancelar;
        private TextBox TxtTotal;
        private TextBox nudValor;
    }
}