
namespace estanteTech.Forms.FormEmprestimo
{
    partial class FormEmprestimo
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
            this.lblLeitor = new System.Windows.Forms.Label();
            this.cbxLeitor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDataEmprestimo = new System.Windows.Forms.Label();
            this.lblDataDevolucao = new System.Windows.Forms.Label();
            this.dtpDataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.dtpDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLeitor
            // 
            this.lblLeitor.AutoSize = true;
            this.lblLeitor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLeitor.Location = new System.Drawing.Point(29, 18);
            this.lblLeitor.Name = "lblLeitor";
            this.lblLeitor.Size = new System.Drawing.Size(48, 19);
            this.lblLeitor.TabIndex = 3;
            this.lblLeitor.Text = "Leitor:";
            // 
            // cbxLeitor
            // 
            this.cbxLeitor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxLeitor.FormattingEnabled = true;
            this.cbxLeitor.Location = new System.Drawing.Point(25, 46);
            this.cbxLeitor.Name = "cbxLeitor";
            this.cbxLeitor.Size = new System.Drawing.Size(259, 27);
            this.cbxLeitor.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(300, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDataEmprestimo
            // 
            this.lblDataEmprestimo.AutoSize = true;
            this.lblDataEmprestimo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataEmprestimo.Location = new System.Drawing.Point(50, 88);
            this.lblDataEmprestimo.Name = "lblDataEmprestimo";
            this.lblDataEmprestimo.Size = new System.Drawing.Size(117, 19);
            this.lblDataEmprestimo.TabIndex = 6;
            this.lblDataEmprestimo.Text = "Data Emprestimo:";
            // 
            // lblDataDevolucao
            // 
            this.lblDataDevolucao.AutoSize = true;
            this.lblDataDevolucao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataDevolucao.Location = new System.Drawing.Point(228, 88);
            this.lblDataDevolucao.Name = "lblDataDevolucao";
            this.lblDataDevolucao.Size = new System.Drawing.Size(110, 19);
            this.lblDataDevolucao.TabIndex = 7;
            this.lblDataDevolucao.Text = "Data Devolução:";
            // 
            // dtpDataEmprestimo
            // 
            this.dtpDataEmprestimo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDataEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEmprestimo.Location = new System.Drawing.Point(46, 110);
            this.dtpDataEmprestimo.MaxDate = new System.DateTime(2070, 12, 31, 0, 0, 0, 0);
            this.dtpDataEmprestimo.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpDataEmprestimo.Name = "dtpDataEmprestimo";
            this.dtpDataEmprestimo.Size = new System.Drawing.Size(138, 29);
            this.dtpDataEmprestimo.TabIndex = 8;
            // 
            // dtpDataDevolucao
            // 
            this.dtpDataDevolucao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDataDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDevolucao.Location = new System.Drawing.Point(224, 110);
            this.dtpDataDevolucao.Name = "dtpDataDevolucao";
            this.dtpDataDevolucao.Size = new System.Drawing.Size(138, 29);
            this.dtpDataDevolucao.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Gray;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Location = new System.Drawing.Point(138, 198);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(118, 38);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FormEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 261);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpDataDevolucao);
            this.Controls.Add(this.dtpDataEmprestimo);
            this.Controls.Add(this.lblDataDevolucao);
            this.Controls.Add(this.lblDataEmprestimo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxLeitor);
            this.Controls.Add(this.lblLeitor);
            this.Name = "FormEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Emprestimo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmprestimo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLeitor;
        private System.Windows.Forms.ComboBox cbxLeitor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDataEmprestimo;
        private System.Windows.Forms.Label lblDataDevolucao;
        private System.Windows.Forms.DateTimePicker dtpDataEmprestimo;
        private System.Windows.Forms.DateTimePicker dtpDataDevolucao;
        private System.Windows.Forms.Button btnRegistrar;
    }
}