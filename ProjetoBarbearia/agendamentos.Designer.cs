﻿namespace ProjetoBarbearia
{
    partial class agendamentos
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
            this.label1 = new System.Windows.Forms.Label();
            this.nomehorario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listaagenda = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.remover = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome / Horário :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomehorario
            // 
            this.nomehorario.Location = new System.Drawing.Point(191, 17);
            this.nomehorario.Multiline = true;
            this.nomehorario.Name = "nomehorario";
            this.nomehorario.Size = new System.Drawing.Size(127, 19);
            this.nomehorario.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaagenda
            // 
            this.listaagenda.FormattingEnabled = true;
            this.listaagenda.Location = new System.Drawing.Point(324, 12);
            this.listaagenda.Name = "listaagenda";
            this.listaagenda.Size = new System.Drawing.Size(461, 420);
            this.listaagenda.TabIndex = 4;
            this.listaagenda.Visible = false;
            this.listaagenda.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Barbeiro :";
            // 
            // remover
            // 
            this.remover.Location = new System.Drawing.Point(688, 373);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(97, 59);
            this.remover.TabIndex = 7;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = true;
            this.remover.Visible = false;
            this.remover.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Visualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "José",
            "Marcelo",
            "Adão"});
            this.comboBox1.Location = new System.Drawing.Point(191, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // agendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.remover);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaagenda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nomehorario);
            this.Controls.Add(this.label1);
            this.Name = "agendamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agendamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomehorario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listaagenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button remover;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}