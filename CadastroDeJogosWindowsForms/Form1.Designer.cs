namespace CadastroDeJogosWindowsForms
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.Descricao = new System.Windows.Forms.TextBox();
            this.ValorLocacao = new System.Windows.Forms.TextBox();
            this.CategoriaId = new System.Windows.Forms.TextBox();
            this.DataAquisicao = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Locação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Aquisição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria Id:";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(105, 31);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 20);
            this.Id.TabIndex = 5;
            // 
            // Descricao
            // 
            this.Descricao.Location = new System.Drawing.Point(105, 60);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(100, 20);
            this.Descricao.TabIndex = 6;
            // 
            // ValorLocacao
            // 
            this.ValorLocacao.Location = new System.Drawing.Point(105, 92);
            this.ValorLocacao.Name = "ValorLocacao";
            this.ValorLocacao.Size = new System.Drawing.Size(100, 20);
            this.ValorLocacao.TabIndex = 7;
            // 
            // CategoriaId
            // 
            this.CategoriaId.Location = new System.Drawing.Point(371, 68);
            this.CategoriaId.Name = "CategoriaId";
            this.CategoriaId.Size = new System.Drawing.Size(100, 20);
            this.CategoriaId.TabIndex = 8;
            // 
            // DataAquisicao
            // 
            this.DataAquisicao.Location = new System.Drawing.Point(371, 39);
            this.DataAquisicao.Mask = "00/00/0000";
            this.DataAquisicao.Name = "DataAquisicao";
            this.DataAquisicao.Size = new System.Drawing.Size(100, 20);
            this.DataAquisicao.TabIndex = 9;
            this.DataAquisicao.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 64);
            this.button1.TabIndex = 10;
            this.button1.Text = "Post";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 64);
            this.button2.TabIndex = 11;
            this.button2.Text = "Put";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(437, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 64);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataAquisicao);
            this.Controls.Add(this.CategoriaId);
            this.Controls.Add(this.ValorLocacao);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox Descricao;
        private System.Windows.Forms.TextBox ValorLocacao;
        private System.Windows.Forms.TextBox CategoriaId;
        private System.Windows.Forms.MaskedTextBox DataAquisicao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

