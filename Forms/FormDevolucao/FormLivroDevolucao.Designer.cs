
namespace estanteTech.Forms.FormDevolucao
{
    partial class FormLivroDevolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLivroDevolucao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tbPesquisar = new System.Windows.Forms.TextBox();
            this.dgvDevolucao = new System.Windows.Forms.DataGridView();
            this.fazDevolucao = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(737, 71);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(40, 29);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPesquisar.Location = new System.Drawing.Point(410, 71);
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.Size = new System.Drawing.Size(321, 29);
            this.tbPesquisar.TabIndex = 5;
            // 
            // dgvDevolucao
            // 
            this.dgvDevolucao.AllowUserToAddRows = false;
            this.dgvDevolucao.AllowUserToDeleteRows = false;
            this.dgvDevolucao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevolucao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDevolucao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevolucao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDevolucao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fazDevolucao});
            this.dgvDevolucao.Location = new System.Drawing.Point(12, 126);
            this.dgvDevolucao.MultiSelect = false;
            this.dgvDevolucao.Name = "dgvDevolucao";
            this.dgvDevolucao.ReadOnly = true;
            this.dgvDevolucao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevolucao.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDevolucao.RowHeadersVisible = false;
            this.dgvDevolucao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvDevolucao.RowTemplate.Height = 25;
            this.dgvDevolucao.Size = new System.Drawing.Size(1137, 570);
            this.dgvDevolucao.TabIndex = 7;
            this.dgvDevolucao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevolucao_CellContentClick);
            this.dgvDevolucao.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDevolucao_CellFormatting);
            this.dgvDevolucao.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDevolucao_DataBindingComplete);
            // 
            // fazDevolucao
            // 
            this.fazDevolucao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fazDevolucao.HeaderText = "";
            this.fazDevolucao.Image = ((System.Drawing.Image)(resources.GetObject("fazDevolucao.Image")));
            this.fazDevolucao.Name = "fazDevolucao";
            this.fazDevolucao.ReadOnly = true;
            this.fazDevolucao.Width = 40;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Location = new System.Drawing.Point(467, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(234, 32);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Tela de Devolução";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormLivroDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 708);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvDevolucao);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.tbPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLivroDevolucao";
            this.Text = "FormLivroDevolucao";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox tbPesquisar;
        private System.Windows.Forms.DataGridView dgvDevolucao;
        private System.Windows.Forms.DataGridViewImageColumn fazDevolucao;
        private System.Windows.Forms.Label lblTitulo;
    }
}