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
            NOMBRE = new DataGridViewTextBoxColumn();
            EDAD = new DataGridViewTextBoxColumn();
            ESTADO = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // NOM
            // 
            NOM.Location = new Point(12, 32);
            NOM.Name = "NOM";
            NOM.Size = new Size(272, 27);
            NOM.TabIndex = 1;
            // 
            // CURP
            // 
            CURP.Location = new Point(335, 32);
            CURP.Name = "CURP";
            CURP.Size = new Size(272, 27);
            CURP.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 9);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 2;
            label2.Text = "CURP";
            // 
            // BUSCADOR
            // 
            BUSCADOR.Location = new Point(12, 112);
            BUSCADOR.Name = "BUSCADOR";
            BUSCADOR.Size = new Size(272, 27);
            BUSCADOR.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "BUSCAR";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { NOMBRE, EDAD, ESTADO });
            dgv.Location = new Point(3, 145);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(795, 293);
            dgv.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(650, 30);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NOMBRE
            // 
            NOMBRE.Frozen = true;
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            NOMBRE.ReadOnly = true;
            NOMBRE.Width = 300;
            // 
            // EDAD
            // 
            EDAD.Frozen = true;
            EDAD.HeaderText = "EDAD";
            EDAD.MinimumWidth = 6;
            EDAD.Name = "EDAD";
            EDAD.ReadOnly = true;
            EDAD.Width = 250;
            // 
            // ESTADO
            // 
            ESTADO.Frozen = true;
            ESTADO.HeaderText = "ESTADO";
            ESTADO.MinimumWidth = 6;
            ESTADO.Name = "ESTADO";
            ESTADO.ReadOnly = true;
            ESTADO.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dgv);
            Controls.Add(BUSCADOR);
            Controls.Add(label3);
            Controls.Add(CURP);
            Controls.Add(label2);
            Controls.Add(NOM);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn EDAD;
        private DataGridViewTextBoxColumn ESTADO;
    }
}
