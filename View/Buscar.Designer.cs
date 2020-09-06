namespace ProjectMurataConsul.View
{
    partial class BuscarFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarFRM));
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.BtnMostrarTodos = new System.Windows.Forms.Button();
            this.ListBoxCadastros = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(74, 27);
            this.TxtBuscar.MaxLength = 30;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(359, 25);
            this.TxtBuscar.TabIndex = 0;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(442, 27);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 25);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(523, 27);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 25);
            this.BtnFiltrar.TabIndex = 2;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            // 
            // BtnMostrarTodos
            // 
            this.BtnMostrarTodos.Location = new System.Drawing.Point(604, 27);
            this.BtnMostrarTodos.Name = "BtnMostrarTodos";
            this.BtnMostrarTodos.Size = new System.Drawing.Size(84, 25);
            this.BtnMostrarTodos.TabIndex = 3;
            this.BtnMostrarTodos.Text = "Mostrar Todos";
            this.BtnMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // ListBoxCadastros
            // 
            this.ListBoxCadastros.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ListBoxCadastros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBoxCadastros.ForeColor = System.Drawing.Color.Black;
            this.ListBoxCadastros.FormattingEnabled = true;
            this.ListBoxCadastros.Location = new System.Drawing.Point(12, 71);
            this.ListBoxCadastros.Name = "ListBoxCadastros";
            this.ListBoxCadastros.Size = new System.Drawing.Size(676, 325);
            this.ListBoxCadastros.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Busca";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuscarFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxCadastros);
            this.Controls.Add(this.BtnMostrarTodos);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consulta de Cadastros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BuscarFRM_FormClosed);
            this.Load += new System.EventHandler(this.BuscarFRM_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BuscarFRM_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Button BtnMostrarTodos;
        private System.Windows.Forms.ListBox ListBoxCadastros;
        private System.Windows.Forms.Label label1;
    }
}