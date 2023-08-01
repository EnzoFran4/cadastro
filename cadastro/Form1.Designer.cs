namespace cadastro
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
            label1 = new Label();
            label2 = new Label();
            tx_codigo = new TextBox();
            label3 = new Label();
            tx_descricao = new TextBox();
            tx_preco = new TextBox();
            label4 = new Label();
            label5 = new Label();
            tx_valor = new MaskedTextBox();
            label6 = new Label();
            tx_lucro = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(193, 31);
            label1.Name = "label1";
            label1.Size = new Size(362, 47);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 113);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Código";
            // 
            // tx_codigo
            // 
            tx_codigo.Location = new Point(208, 110);
            tx_codigo.Name = "tx_codigo";
            tx_codigo.Size = new Size(100, 23);
            tx_codigo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 115);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 3;
            label3.Text = "Descrição";
            // 
            // tx_descricao
            // 
            tx_descricao.Location = new Point(396, 110);
            tx_descricao.Name = "tx_descricao";
            tx_descricao.Size = new Size(100, 23);
            tx_descricao.TabIndex = 4;
            // 
            // tx_preco
            // 
            tx_preco.Location = new Point(208, 155);
            tx_preco.Name = "tx_preco";
            tx_preco.Size = new Size(100, 23);
            tx_preco.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 158);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 6;
            label4.Text = "Preço de aquisição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 195);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 7;
            label5.Text = "Valor do produto";
            // 
            // tx_valor
            // 
            tx_valor.Location = new Point(208, 192);
            tx_valor.Name = "tx_valor";
            tx_valor.Size = new Size(100, 23);
            tx_valor.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(340, 155);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 9;
            label6.Text = "Lucro %";
            // 
            // tx_lucro
            // 
            tx_lucro.Location = new Point(396, 150);
            tx_lucro.Name = "tx_lucro";
            tx_lucro.Size = new Size(100, 23);
            tx_lucro.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(101, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(528, 153);
            dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(370, 208);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Novo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(464, 208);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(545, 208);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 14;
            button3.Text = "Cadastrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(tx_lucro);
            Controls.Add(label6);
            Controls.Add(tx_valor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tx_preco);
            Controls.Add(tx_descricao);
            Controls.Add(label3);
            Controls.Add(tx_codigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tx_codigo;
        private Label label3;
        private TextBox tx_descricao;
        private TextBox tx_preco;
        private Label label4;
        private Label label5;
        private MaskedTextBox tx_valor;
        private Label label6;
        private TextBox tx_lucro;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}