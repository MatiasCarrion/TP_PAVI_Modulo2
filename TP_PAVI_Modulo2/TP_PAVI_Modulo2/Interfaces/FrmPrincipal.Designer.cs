
namespace TP_PAVI_Modulo2.Interfaces
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pbUsers = new System.Windows.Forms.PictureBox();
            this.lblUsuarioLogueado = new System.Windows.Forms.Label();
            this.btnAvanceCurso = new System.Windows.Forms.Button();
            this.btnObjCurso = new System.Windows.Forms.Button();
            this.btnObjetivos = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitleMain = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMenu.Controls.Add(this.pnlInfo);
            this.pnlMenu.Controls.Add(this.btnAvanceCurso);
            this.pnlMenu.Controls.Add(this.btnObjCurso);
            this.pnlMenu.Controls.Add(this.btnObjetivos);
            this.pnlMenu.Controls.Add(this.btnCategorias);
            this.pnlMenu.Controls.Add(this.btnCursos);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(147, 531);
            this.pnlMenu.TabIndex = 5;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.pbUsers);
            this.pnlInfo.Controls.Add(this.lblUsuarioLogueado);
            this.pnlInfo.Location = new System.Drawing.Point(11, 368);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(120, 151);
            this.pnlInfo.TabIndex = 8;
            // 
            // pbUsers
            // 
            this.pbUsers.Image = ((System.Drawing.Image)(resources.GetObject("pbUsers.Image")));
            this.pbUsers.Location = new System.Drawing.Point(13, 12);
            this.pbUsers.Name = "pbUsers";
            this.pbUsers.Size = new System.Drawing.Size(94, 77);
            this.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsers.TabIndex = 0;
            this.pbUsers.TabStop = false;
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.AutoSize = true;
            this.lblUsuarioLogueado.Location = new System.Drawing.Point(13, 92);
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(0, 15);
            this.lblUsuarioLogueado.TabIndex = 7;
            // 
            // btnAvanceCurso
            // 
            this.btnAvanceCurso.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAvanceCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvanceCurso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAvanceCurso.Location = new System.Drawing.Point(13, 281);
            this.btnAvanceCurso.Name = "btnAvanceCurso";
            this.btnAvanceCurso.Size = new System.Drawing.Size(118, 77);
            this.btnAvanceCurso.TabIndex = 10;
            this.btnAvanceCurso.Text = "Actualizar avances usuarios";
            this.btnAvanceCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvanceCurso.UseVisualStyleBackColor = true;
            // 
            // btnObjCurso
            // 
            this.btnObjCurso.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnObjCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObjCurso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnObjCurso.Location = new System.Drawing.Point(11, 208);
            this.btnObjCurso.Name = "btnObjCurso";
            this.btnObjCurso.Size = new System.Drawing.Size(119, 67);
            this.btnObjCurso.TabIndex = 9;
            this.btnObjCurso.Text = "Actualizar objetivos curso";
            this.btnObjCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObjCurso.UseVisualStyleBackColor = true;
            // 
            // btnObjetivos
            // 
            this.btnObjetivos.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnObjetivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObjetivos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnObjetivos.Location = new System.Drawing.Point(13, 171);
            this.btnObjetivos.Name = "btnObjetivos";
            this.btnObjetivos.Size = new System.Drawing.Size(118, 31);
            this.btnObjetivos.TabIndex = 9;
            this.btnObjetivos.Text = "Objetivos";
            this.btnObjetivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObjetivos.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            this.btnCategorias.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCategorias.Location = new System.Drawing.Point(13, 133);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(118, 31);
            this.btnCategorias.TabIndex = 8;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.UseVisualStyleBackColor = true;
            // 
            // btnCursos
            // 
            this.btnCursos.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCursos.Location = new System.Drawing.Point(12, 96);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(119, 31);
            this.btnCursos.TabIndex = 7;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUsuarios.Location = new System.Drawing.Point(12, 59);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(119, 31);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitleMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(147, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1099, 59);
            this.panel2.TabIndex = 6;
            // 
            // lblTitleMain
            // 
            this.lblTitleMain.AutoSize = true;
            this.lblTitleMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleMain.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleMain.Location = new System.Drawing.Point(0, 0);
            this.lblTitleMain.Name = "lblTitleMain";
            this.lblTitleMain.Size = new System.Drawing.Size(414, 41);
            this.lblTitleMain.TabIndex = 0;
            this.lblTitleMain.Text = "Gestión de cursos por usuario";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1246, 531);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.pnlMenu.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnObjetivos;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitleMain;
        private System.Windows.Forms.PictureBox pbUsers;
        private System.Windows.Forms.Label lblUsuarioLogueado;
        private System.Windows.Forms.Button btnAvanceCurso;
        private System.Windows.Forms.Button btnObjCurso;
        private System.Windows.Forms.Panel pnlInfo;
    }
}