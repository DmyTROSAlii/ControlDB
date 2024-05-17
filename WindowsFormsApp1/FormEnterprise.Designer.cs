
namespace WindowsFormsApp1
{
    partial class FormEnterprise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnterprise));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.panelDesktopMenu = new System.Windows.Forms.Panel();
            this.panel_Find = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFind = new System.Windows.Forms.Label();
            this.textBox_Find = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panelDesktop.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.panelDesktopMenu.SuspendLayout();
            this.panel_Find.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panelDataGridView);
            this.panelDesktop.Controls.Add(this.panelDesktopMenu);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(566, 366);
            this.panelDesktop.TabIndex = 7;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridViewTable);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(0, 122);
            this.panelDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(566, 244);
            this.panelDataGridView.TabIndex = 1;
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AllowUserToAddRows = false;
            this.dataGridViewTable.AllowUserToDeleteRows = false;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTable.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTable.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.ReadOnly = true;
            this.dataGridViewTable.RowHeadersWidth = 51;
            this.dataGridViewTable.RowTemplate.Height = 24;
            this.dataGridViewTable.Size = new System.Drawing.Size(566, 244);
            this.dataGridViewTable.TabIndex = 0;
            // 
            // panelDesktopMenu
            // 
            this.panelDesktopMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelDesktopMenu.Controls.Add(this.panel_Find);
            this.panelDesktopMenu.Controls.Add(this.panelMenu);
            this.panelDesktopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDesktopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktopMenu.Name = "panelDesktopMenu";
            this.panelDesktopMenu.Size = new System.Drawing.Size(566, 122);
            this.panelDesktopMenu.TabIndex = 0;
            // 
            // panel_Find
            // 
            this.panel_Find.Controls.Add(this.tableLayoutPanel1);
            this.panel_Find.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Find.Location = new System.Drawing.Point(188, 0);
            this.panel_Find.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Find.Name = "panel_Find";
            this.panel_Find.Size = new System.Drawing.Size(378, 57);
            this.panel_Find.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.lblFind, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Find, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Find, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblFind
            // 
            this.lblFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFind.ForeColor = System.Drawing.Color.White;
            this.lblFind.Location = new System.Drawing.Point(58, 0);
            this.lblFind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFind.Name = "lblFind";
            this.lblFind.Padding = new System.Windows.Forms.Padding(4);
            this.lblFind.Size = new System.Drawing.Size(53, 21);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "Пошук";
            // 
            // textBox_Find
            // 
            this.textBox_Find.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Find.Location = new System.Drawing.Point(115, 2);
            this.textBox_Find.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Find.Name = "textBox_Find";
            this.textBox_Find.Size = new System.Drawing.Size(261, 20);
            this.textBox_Find.TabIndex = 1;
            // 
            // btn_Find
            // 
            this.btn_Find.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Find.ForeColor = System.Drawing.Color.White;
            this.btn_Find.Location = new System.Drawing.Point(115, 26);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(261, 31);
            this.btn_Find.TabIndex = 2;
            this.btn_Find.Text = "Пошук";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnDelete);
            this.panelMenu.Controls.Add(this.btnInsert);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(188, 122);
            this.panelMenu.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(188, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "   Змінити";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(0, 40);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(188, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "   Видалити";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnInsert.Size = new System.Drawing.Size(188, 40);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "   Вставити";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // FormEnterprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 366);
            this.Controls.Add(this.panelDesktop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEnterprise";
            this.Text = "Enterprise";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGoods_KeyDown);
            this.panelDesktop.ResumeLayout(false);
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.panelDesktopMenu.ResumeLayout(false);
            this.panel_Find.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Panel panelDesktopMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel_Find;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.TextBox textBox_Find;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button button1;
    }
}