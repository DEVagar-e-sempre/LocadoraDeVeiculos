﻿namespace LocadoraDeVeiculos.WinApp.ModuloCliente
{
    partial class TelaClienteForm
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
            txb_nome = new TextBox();
            txb_email = new TextBox();
            txb_cnpj = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            rdbGroup = new GroupBox();
            rdb_cnpj = new RadioButton();
            rdb_cpf = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txb_estado = new TextBox();
            txb_cidade = new TextBox();
            txb_logradouro = new TextBox();
            txb_bairro = new TextBox();
            txb_numero = new TextBox();
            label10 = new Label();
            label11 = new Label();
            BtnCancelar = new Button();
            BtnSalvar = new Button();
            mtxb_telefone = new MaskedTextBox();
            mtxb_cpf = new MaskedTextBox();
            mtxb_cep = new MaskedTextBox();
            txb_comp = new TextBox();
            label12 = new Label();
            rdbGroup.SuspendLayout();
            SuspendLayout();
            // 
            // txb_nome
            // 
            txb_nome.Location = new Point(89, 16);
            txb_nome.Margin = new Padding(3, 4, 3, 4);
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(303, 27);
            txb_nome.TabIndex = 0;
            // 
            // txb_email
            // 
            txb_email.Location = new Point(89, 80);
            txb_email.Margin = new Padding(3, 4, 3, 4);
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(303, 27);
            txb_email.TabIndex = 1;
            // 
            // txb_cnpj
            // 
            txb_cnpj.Location = new Point(279, 292);
            txb_cnpj.Margin = new Padding(3, 4, 3, 4);
            txb_cnpj.Name = "txb_cnpj";
            txb_cnpj.Size = new Size(114, 27);
            txb_cnpj.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 20);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 5;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 148);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 6;
            label2.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 85);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 7;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 297);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 8;
            label4.Text = "CPF:";
            // 
            // rdbGroup
            // 
            rdbGroup.Controls.Add(rdb_cnpj);
            rdbGroup.Controls.Add(rdb_cpf);
            rdbGroup.Location = new Point(75, 185);
            rdbGroup.Margin = new Padding(3, 4, 3, 4);
            rdbGroup.Name = "rdbGroup";
            rdbGroup.Padding = new Padding(3, 4, 3, 4);
            rdbGroup.Size = new Size(318, 93);
            rdbGroup.TabIndex = 9;
            rdbGroup.TabStop = false;
            rdbGroup.Text = "Tipo de Cliente";
            rdbGroup.Enter += groupBox1_Enter;
            // 
            // rdb_cnpj
            // 
            rdb_cnpj.AutoSize = true;
            rdb_cnpj.Location = new Point(173, 39);
            rdb_cnpj.Margin = new Padding(3, 4, 3, 4);
            rdb_cnpj.Name = "rdb_cnpj";
            rdb_cnpj.Size = new Size(128, 24);
            rdb_cnpj.TabIndex = 4;
            rdb_cnpj.TabStop = true;
            rdb_cnpj.Text = "Pessoa Jurídica";
            rdb_cnpj.UseVisualStyleBackColor = true;
            // 
            // rdb_cpf
            // 
            rdb_cpf.AutoSize = true;
            rdb_cpf.Location = new Point(25, 39);
            rdb_cpf.Margin = new Padding(3, 4, 3, 4);
            rdb_cpf.Name = "rdb_cpf";
            rdb_cpf.Size = new Size(114, 24);
            rdb_cpf.TabIndex = 3;
            rdb_cpf.TabStop = true;
            rdb_cpf.Text = "Pessoa Física";
            rdb_cpf.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(217, 296);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 10;
            label5.Text = "CNPJ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 353);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 11;
            label6.Text = "Estado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(206, 353);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 12;
            label7.Text = "Cidade:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 397);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 13;
            label8.Text = "Bairro:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 444);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 14;
            label9.Text = "Logradouro:";
            // 
            // txb_estado
            // 
            txb_estado.Location = new Point(89, 349);
            txb_estado.Margin = new Padding(3, 4, 3, 4);
            txb_estado.Name = "txb_estado";
            txb_estado.Size = new Size(100, 27);
            txb_estado.TabIndex = 7;
            // 
            // txb_cidade
            // 
            txb_cidade.Location = new Point(279, 343);
            txb_cidade.Margin = new Padding(3, 4, 3, 4);
            txb_cidade.Name = "txb_cidade";
            txb_cidade.Size = new Size(114, 27);
            txb_cidade.TabIndex = 8;
            // 
            // txb_logradouro
            // 
            txb_logradouro.Location = new Point(89, 440);
            txb_logradouro.Margin = new Padding(3, 4, 3, 4);
            txb_logradouro.Name = "txb_logradouro";
            txb_logradouro.Size = new Size(303, 27);
            txb_logradouro.TabIndex = 11;
            // 
            // txb_bairro
            // 
            txb_bairro.Location = new Point(89, 393);
            txb_bairro.Margin = new Padding(3, 4, 3, 4);
            txb_bairro.Name = "txb_bairro";
            txb_bairro.Size = new Size(170, 27);
            txb_bairro.TabIndex = 9;
            // 
            // txb_numero
            // 
            txb_numero.Location = new Point(89, 485);
            txb_numero.Margin = new Padding(3, 4, 3, 4);
            txb_numero.Name = "txb_numero";
            txb_numero.Size = new Size(76, 27);
            txb_numero.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 489);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 20;
            label10.Text = "Número:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(266, 397);
            label11.Name = "label11";
            label11.Size = new Size(37, 20);
            label11.TabIndex = 21;
            label11.Text = "CEP:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancelar.DialogResult = DialogResult.Cancel;
            BtnCancelar.Location = new Point(319, 552);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(94, 41);
            BtnCancelar.TabIndex = 15;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSalvar.DialogResult = DialogResult.OK;
            BtnSalvar.Location = new Point(202, 552);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(94, 41);
            BtnSalvar.TabIndex = 14;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // mtxb_telefone
            // 
            mtxb_telefone.Location = new Point(89, 147);
            mtxb_telefone.Margin = new Padding(3, 4, 3, 4);
            mtxb_telefone.Mask = "(##) #####-####";
            mtxb_telefone.Name = "mtxb_telefone";
            mtxb_telefone.Size = new Size(100, 27);
            mtxb_telefone.TabIndex = 2;
            // 
            // mtxb_cpf
            // 
            mtxb_cpf.Location = new Point(89, 296);
            mtxb_cpf.Margin = new Padding(3, 4, 3, 4);
            mtxb_cpf.Mask = "###.###.###-##";
            mtxb_cpf.Name = "mtxb_cpf";
            mtxb_cpf.Size = new Size(100, 27);
            mtxb_cpf.TabIndex = 5;
            // 
            // mtxb_cep
            // 
            mtxb_cep.Location = new Point(306, 393);
            mtxb_cep.Margin = new Padding(3, 4, 3, 4);
            mtxb_cep.Mask = "#####-###";
            mtxb_cep.Name = "mtxb_cep";
            mtxb_cep.Size = new Size(86, 27);
            mtxb_cep.TabIndex = 10;
            // 
            // txb_comp
            // 
            txb_comp.Location = new Point(283, 485);
            txb_comp.Margin = new Padding(3, 4, 3, 4);
            txb_comp.Name = "txb_comp";
            txb_comp.Size = new Size(109, 27);
            txb_comp.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(177, 489);
            label12.Name = "label12";
            label12.Size = new Size(107, 20);
            label12.TabIndex = 29;
            label12.Text = "Complemento:";
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 615);
            Controls.Add(label12);
            Controls.Add(txb_comp);
            Controls.Add(mtxb_cep);
            Controls.Add(mtxb_cpf);
            Controls.Add(mtxb_telefone);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalvar);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txb_numero);
            Controls.Add(txb_bairro);
            Controls.Add(txb_logradouro);
            Controls.Add(txb_cidade);
            Controls.Add(txb_estado);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(rdbGroup);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txb_cnpj);
            Controls.Add(txb_email);
            Controls.Add(txb_nome);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaClienteForm";
            Text = "TelaClienteForm";
            rdbGroup.ResumeLayout(false);
            rdbGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_nome;
        private TextBox txb_email;
        private TextBox txb_cnpj;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox rdbGroup;
        private RadioButton rdb_cnpj;
        private RadioButton rdb_cpf;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txb_estado;
        private TextBox txb_cidade;
        private TextBox txb_logradouro;
        private TextBox txb_bairro;
        private TextBox txb_numero;
        private Label label10;
        private Label label11;
        private TextBox txb_cep;
        private Button BtnCancelar;
        private Button BtnSalvar;
        private MaskedTextBox mtxb_telefone;
        private MaskedTextBox mtxb_cpf;
        private MaskedTextBox mtxb_cep;
        private TextBox txb_comp;
        private Label label12;
    }
}