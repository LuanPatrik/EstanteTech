
namespace estanteTech.Forms.Formleitor
{
    partial class FormAddEditLeitor
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbNumRA = new System.Windows.Forms.TextBox();
            this.lblNumRA = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.dtpData_nasc = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Silver;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(98, 335);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 36);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbTelefone.Location = new System.Drawing.Point(34, 225);
            this.mtbTelefone.Mask = "(99) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(244, 26);
            this.mtbTelefone.TabIndex = 3;
            this.mtbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(35, 284);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(243, 26);
            this.tbEmail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Email:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.Location = new System.Drawing.Point(35, 203);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(63, 19);
            this.lblTelefone.TabIndex = 17;
            this.lblTelefone.Text = "Telefone:";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNome.Location = new System.Drawing.Point(35, 54);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(243, 26);
            this.tbNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(35, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 19);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome:";
            // 
            // tbNumRA
            // 
            this.tbNumRA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNumRA.Location = new System.Drawing.Point(34, 170);
            this.tbNumRA.Name = "tbNumRA";
            this.tbNumRA.Size = new System.Drawing.Size(244, 26);
            this.tbNumRA.TabIndex = 2;
            // 
            // lblNumRA
            // 
            this.lblNumRA.AutoSize = true;
            this.lblNumRA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumRA.Location = new System.Drawing.Point(35, 148);
            this.lblNumRA.Name = "lblNumRA";
            this.lblNumRA.Size = new System.Drawing.Size(87, 19);
            this.lblNumRA.TabIndex = 22;
            this.lblNumRA.Text = "Número RA:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataNasc.Location = new System.Drawing.Point(35, 91);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(136, 19);
            this.lblDataNasc.TabIndex = 21;
            this.lblDataNasc.Text = "Data de Nascimento:";
            // 
            // dtpData_nasc
            // 
            this.dtpData_nasc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpData_nasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData_nasc.Location = new System.Drawing.Point(35, 119);
            this.dtpData_nasc.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dtpData_nasc.Name = "dtpData_nasc";
            this.dtpData_nasc.Size = new System.Drawing.Size(123, 26);
            this.dtpData_nasc.TabIndex = 1;
            // 
            // FormAddEditLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 381);
            this.Controls.Add(this.dtpData_nasc);
            this.Controls.Add(this.tbNumRA);
            this.Controls.Add(this.lblNumRA);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FormAddEditLeitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Edição de Leitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddEditLeitor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbNumRA;
        private System.Windows.Forms.Label lblNumRA;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.DateTimePicker dtpData_nasc;
    }
}