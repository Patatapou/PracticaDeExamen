namespace PracticaDeExamen
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
            NOM = new TextBox();
            CURP = new TextBox();
            label2 = new Label();
            BUSCADOR = new TextBox();
            label3 = new Label();
            dgv = new DataGridView();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            NOMBRE = new DataGridViewTextBoxColumn();
            EDAD = new DataGridViewTextBoxColumn();
            ESTADO = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // NOM
            // 
            NOM.Location = new Point(3, 23);
            NOM.Name = "NOM";
            NOM.Size = new Size(272, 27);
            NOM.TabIndex = 1;
            // 
            // CURP
            // 
            CURP.Location = new Point(330, 23);
            CURP.Name = "CURP";
            CURP.Size = new Size(272, 27);
            CURP.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 2;
            label2.Text = "CURP";
            // 
            // BUSCADOR
            // 
            BUSCADOR.Location = new Point(3, 112);
            BUSCADOR.Name = "BUSCADOR";
            BUSCADOR.Size = new Size(272, 27);
            BUSCADOR.TabIndex = 5;
            BUSCADOR.TextChanged += BUSCADOR_TextChanged;
            BUSCADOR.Validated += BUSCADOR_Validated;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 84);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "BUSCAR";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { NOMBRE, EDAD, ESTADO });
            dgv.Location = new Point(12, 160);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(776, 278);
            dgv.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(657, 23);
            button1.Name = "button1";
            button1.Size = new Size(94, 28);
            button1.TabIndex = 7;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(BUSCADOR, 0, 3);
            tableLayoutPanel1.Controls.Add(NOM, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(CURP, 1, 1);
            tableLayoutPanel1.Controls.Add(button1, 2, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(776, 142);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Width = 250;
            // 
            // EDAD
            // 
            EDAD.HeaderText = "EDAD";
            EDAD.MinimumWidth = 6;
            EDAD.Name = "EDAD";
            EDAD.Width = 200;
            // 
            // ESTADO
            // 
            ESTADO.HeaderText = "ESTADO";
            ESTADO.MinimumWidth = 6;
            ESTADO.Name = "ESTADO";
            ESTADO.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox NOM;
        private TextBox CURP;
        private Label label2;
        private TextBox BUSCADOR;
        private Label label3;
        private DataGridView dgv;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn EDAD;
        private DataGridViewTextBoxColumn ESTADO;
    }
}
