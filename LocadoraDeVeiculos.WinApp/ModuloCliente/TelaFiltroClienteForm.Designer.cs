﻿namespace LocadoraDeVeiculos.WinApp.ModuloCliente
{
    partial class TelaFiltroClienteForm
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
            btnCancelar = new Button();
            btn_aplicar = new Button();
            rdbGroup = new GroupBox();
            rdb_todos = new RadioButton();
            rdb_filtroCnpj = new RadioButton();
            rdb_filtroCpf = new RadioButton();
            rdbGroup.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(196, 167);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 32);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btn_aplicar
            // 
            btn_aplicar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_aplicar.DialogResult = DialogResult.OK;
            btn_aplicar.Location = new Point(96, 167);
            btn_aplicar.Margin = new Padding(3, 2, 3, 2);
            btn_aplicar.Name = "btn_aplicar";
            btn_aplicar.Size = new Size(82, 32);
            btn_aplicar.TabIndex = 12;
            btn_aplicar.Text = "Aplicar";
            btn_aplicar.UseVisualStyleBackColor = true;
            // 
            // rdbGroup
            // 
            rdbGroup.Controls.Add(rdb_todos);
            rdbGroup.Controls.Add(rdb_filtroCnpj);
            rdbGroup.Controls.Add(rdb_filtroCpf);
            rdbGroup.Location = new Point(12, 12);
            rdbGroup.Name = "rdbGroup";
            rdbGroup.Size = new Size(265, 146);
            rdbGroup.TabIndex = 14;
            rdbGroup.TabStop = false;
            rdbGroup.Text = "Tipo de Filtro";
            rdbGroup.Enter += groupBox1_Enter;
            // 
            // rdb_todos
            // 
            rdb_todos.AutoSize = true;
            rdb_todos.Location = new Point(17, 41);
            rdb_todos.Name = "rdb_todos";
            rdb_todos.Size = new Size(89, 19);
            rdb_todos.TabIndex = 2;
            rdb_todos.TabStop = true;
            rdb_todos.Text = "Filtrar Todos";
            rdb_todos.UseVisualStyleBackColor = true;
            // 
            // rdb_filtroCnpj
            // 
            rdb_filtroCnpj.AutoSize = true;
            rdb_filtroCnpj.Location = new Point(17, 109);
            rdb_filtroCnpj.Name = "rdb_filtroCnpj";
            rdb_filtroCnpj.Size = new Size(122, 19);
            rdb_filtroCnpj.TabIndex = 1;
            rdb_filtroCnpj.TabStop = true;
            rdb_filtroCnpj.Text = "Filtragem por cnpj";
            rdb_filtroCnpj.UseVisualStyleBackColor = true;
            // 
            // rdb_filtroCpf
            // 
            rdb_filtroCpf.AutoSize = true;
            rdb_filtroCpf.Location = new Point(17, 75);
            rdb_filtroCpf.Name = "rdb_filtroCpf";
            rdb_filtroCpf.Size = new Size(116, 19);
            rdb_filtroCpf.TabIndex = 0;
            rdb_filtroCpf.TabStop = true;
            rdb_filtroCpf.Text = "Filtragem por cpf";
            rdb_filtroCpf.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 210);
            Controls.Add(rdbGroup);
            Controls.Add(btnCancelar);
            Controls.Add(btn_aplicar);
            Name = "TelaFiltroClienteForm";
            Text = "TelaFiltroClienteForm";
            rdbGroup.ResumeLayout(false);
            rdbGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancelar;
        private Button btn_aplicar;
        private GroupBox rdbGroup;
        private RadioButton rdb_filtroCnpj;
        private RadioButton rdb_filtroCpf;
        private RadioButton rdb_todos;
    }
}