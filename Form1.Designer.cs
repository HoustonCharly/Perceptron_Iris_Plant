namespace Prac4Perceptron
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Problema = new System.Windows.Forms.ComboBox();
            this.Gridtabla = new System.Windows.Forms.DataGridView();
            this.Bt1 = new System.Windows.Forms.Button();
            this.lBDatosiris = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.lBsalida = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Gridtabla)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Problema
            // 
            this.Problema.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Problema.FormattingEnabled = true;
            this.Problema.Items.AddRange(new object[] {
            "SETOSA_VERSICOLOR",
            "SETOSA_VIRGINICA",
            "VERSICOLOR_VIRGINICA"});
            this.Problema.Location = new System.Drawing.Point(250, 17);
            this.Problema.Name = "Problema";
            this.Problema.Size = new System.Drawing.Size(199, 24);
            this.Problema.TabIndex = 0;
            // 
            // Gridtabla
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gridtabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Gridtabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gridtabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Gridtabla.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Gridtabla.Location = new System.Drawing.Point(218, 62);
            this.Gridtabla.Name = "Gridtabla";
            this.Gridtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Gridtabla.Size = new System.Drawing.Size(498, 322);
            this.Gridtabla.TabIndex = 2;
            // 
            // Bt1
            // 
            this.Bt1.BackColor = System.Drawing.Color.Red;
            this.Bt1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt1.ForeColor = System.Drawing.SystemColors.Control;
            this.Bt1.Location = new System.Drawing.Point(481, 10);
            this.Bt1.Name = "Bt1";
            this.Bt1.Size = new System.Drawing.Size(93, 39);
            this.Bt1.TabIndex = 3;
            this.Bt1.Text = "Solución";
            this.Bt1.UseVisualStyleBackColor = false;
            this.Bt1.Click += new System.EventHandler(this.Bt1_Click);
            // 
            // lBDatosiris
            // 
            this.lBDatosiris.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBDatosiris.FormattingEnabled = true;
            this.lBDatosiris.ItemHeight = 16;
            this.lBDatosiris.Items.AddRange(new object[] {
            " "});
            this.lBDatosiris.Location = new System.Drawing.Point(0, 28);
            this.lBDatosiris.Name = "lBDatosiris";
            this.lBDatosiris.Size = new System.Drawing.Size(212, 356);
            this.lBDatosiris.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(591, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lBsalida
            // 
            this.lBsalida.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBsalida.FormattingEnabled = true;
            this.lBsalida.ItemHeight = 16;
            this.lBsalida.Items.AddRange(new object[] {
            " "});
            this.lBsalida.Location = new System.Drawing.Point(722, 28);
            this.lBsalida.Name = "lBsalida";
            this.lBsalida.Size = new System.Drawing.Size(212, 356);
            this.lBsalida.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(941, 388);
            this.Controls.Add(this.lBsalida);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lBDatosiris);
            this.Controls.Add(this.Bt1);
            this.Controls.Add(this.Gridtabla);
            this.Controls.Add(this.Problema);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PERCEPTRÓN";
            ((System.ComponentModel.ISupportInitialize)(this.Gridtabla)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Problema;
        private System.Windows.Forms.DataGridView Gridtabla;
        private System.Windows.Forms.Button Bt1;
        private System.Windows.Forms.ListBox lBDatosiris;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lBsalida;
    }
}

