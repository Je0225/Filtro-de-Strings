namespace Filtro_de_Strings
{
    partial class FormPrincipal
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.bntAdd = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnlLists = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lvFiltro = new System.Windows.Forms.ListView();
            this.lvNomes = new System.Windows.Forms.ListView();
            this.clmNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFiltro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlHeader.SuspendLayout();
            this.pnlLists.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.bntAdd);
            this.pnlHeader.Controls.Add(this.tbNome);
            this.pnlHeader.Controls.Add(this.lblNome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(538, 68);
            this.pnlHeader.TabIndex = 0;
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(359, 28);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(103, 23);
            this.bntAdd.TabIndex = 2;
            this.bntAdd.Text = "Adicionar";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(87, 28);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(246, 20);
            this.tbNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(46, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // pnlLists
            // 
            this.pnlLists.Controls.Add(this.btnFiltrar);
            this.pnlLists.Controls.Add(this.tbFiltro);
            this.pnlLists.Controls.Add(this.lblFiltro);
            this.pnlLists.Controls.Add(this.lvFiltro);
            this.pnlLists.Controls.Add(this.lvNomes);
            this.pnlLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLists.Location = new System.Drawing.Point(0, 68);
            this.pnlLists.Name = "pnlLists";
            this.pnlLists.Size = new System.Drawing.Size(538, 601);
            this.pnlLists.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(359, 280);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(103, 23);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(87, 284);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(246, 20);
            this.tbFiltro.TabIndex = 4;
            // 
            // lblFiltro
            // 
            this.lblFiltro.Location = new System.Drawing.Point(46, 285);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(35, 13);
            this.lblFiltro.TabIndex = 3;
            this.lblFiltro.Text = "Filtro";
            // 
            // lvFiltro
            // 
            this.lvFiltro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFiltro});
            this.lvFiltro.HideSelection = false;
            this.lvFiltro.Location = new System.Drawing.Point(49, 335);
            this.lvFiltro.Name = "lvFiltro";
            this.lvFiltro.Size = new System.Drawing.Size(413, 235);
            this.lvFiltro.TabIndex = 1;
            this.lvFiltro.UseCompatibleStateImageBehavior = false;
            this.lvFiltro.View = System.Windows.Forms.View.Details;
            // 
            // lvNomes
            // 
            this.lvNomes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNome});
            this.lvNomes.HideSelection = false;
            this.lvNomes.Location = new System.Drawing.Point(49, 12);
            this.lvNomes.Name = "lvNomes";
            this.lvNomes.Size = new System.Drawing.Size(413, 239);
            this.lvNomes.TabIndex = 0;
            this.lvNomes.UseCompatibleStateImageBehavior = false;
            this.lvNomes.View = System.Windows.Forms.View.Details;
            // 
            // clmNome
            // 
            this.clmNome.Text = "Nome";
            this.clmNome.Width = 396;
            // 
            // clmFiltro
            // 
            this.clmFiltro.Text = "Filtro";
            this.clmFiltro.Width = 392;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 669);
            this.Controls.Add(this.pnlLists);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Filtro de Strings";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLists.ResumeLayout(false);
            this.pnlLists.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlLists;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ListView lvFiltro;
        private System.Windows.Forms.ListView lvNomes;
        private System.Windows.Forms.ColumnHeader clmFiltro;
        private System.Windows.Forms.ColumnHeader clmNome;
    }
}

