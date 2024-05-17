
namespace WindowsFormsApp1
{
    partial class FormUpdateEnterprise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateEnterprise));
            this.panelDeskTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanelDeskTop = new System.Windows.Forms.TableLayoutPanel();
            this.nameText = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.Label();
            this.idNumeric = new System.Windows.Forms.NumericUpDown();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.panelDeskTop.SuspendLayout();
            this.tableLayoutPanelDeskTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDeskTop
            // 
            this.panelDeskTop.Controls.Add(this.tableLayoutPanelDeskTop);
            this.panelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskTop.Location = new System.Drawing.Point(0, 0);
            this.panelDeskTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDeskTop.Name = "panelDeskTop";
            this.panelDeskTop.Size = new System.Drawing.Size(602, 163);
            this.panelDeskTop.TabIndex = 1;
            // 
            // tableLayoutPanelDeskTop
            // 
            this.tableLayoutPanelDeskTop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanelDeskTop.ColumnCount = 2;
            this.tableLayoutPanelDeskTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelDeskTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelDeskTop.Controls.Add(this.nameText, 0, 1);
            this.tableLayoutPanelDeskTop.Controls.Add(this.btnUpdate, 1, 10);
            this.tableLayoutPanelDeskTop.Controls.Add(this.idText, 0, 0);
            this.tableLayoutPanelDeskTop.Controls.Add(this.idNumeric, 1, 0);
            this.tableLayoutPanelDeskTop.Controls.Add(this.nameBox, 1, 1);
            this.tableLayoutPanelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDeskTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDeskTop.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelDeskTop.Name = "tableLayoutPanelDeskTop";
            this.tableLayoutPanelDeskTop.RowCount = 12;
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.63636F));
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.36364F));
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.Size = new System.Drawing.Size(602, 163);
            this.tableLayoutPanelDeskTop.TabIndex = 0;
            // 
            // nameText
            // 
            this.nameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameText.AutoSize = true;
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameText.ForeColor = System.Drawing.Color.White;
            this.nameText.Location = new System.Drawing.Point(131, 26);
            this.nameText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameText.Name = "nameText";
            this.nameText.Padding = new System.Windows.Forms.Padding(4);
            this.nameText.Size = new System.Drawing.Size(47, 21);
            this.nameText.TabIndex = 10;
            this.nameText.Text = "Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(182, 80);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(418, 80);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Змінити товар";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // idText
            // 
            this.idText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idText.AutoSize = true;
            this.idText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idText.ForeColor = System.Drawing.Color.White;
            this.idText.Location = new System.Drawing.Point(150, 0);
            this.idText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idText.Name = "idText";
            this.idText.Padding = new System.Windows.Forms.Padding(4);
            this.idText.Size = new System.Drawing.Size(28, 21);
            this.idText.TabIndex = 8;
            this.idText.Text = "ID";
            // 
            // idNumeric
            // 
            this.idNumeric.Location = new System.Drawing.Point(183, 3);
            this.idNumeric.Name = "idNumeric";
            this.idNumeric.Size = new System.Drawing.Size(416, 20);
            this.idNumeric.TabIndex = 11;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(183, 29);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(416, 20);
            this.nameBox.TabIndex = 12;
            // 
            // FormUpdateEnterprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 163);
            this.Controls.Add(this.panelDeskTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(618, 411);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(618, 111);
            this.Name = "FormUpdateEnterprise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit";
            this.panelDeskTop.ResumeLayout(false);
            this.tableLayoutPanelDeskTop.ResumeLayout(false);
            this.tableLayoutPanelDeskTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDeskTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDeskTop;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label idText;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.NumericUpDown idNumeric;
        private System.Windows.Forms.TextBox nameBox;
    }
}