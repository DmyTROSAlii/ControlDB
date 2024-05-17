
namespace WindowsFormsApp1
{
    partial class FormUpdateArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateArea));
            this.panelDeskTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanelDeskTop = new System.Windows.Forms.TableLayoutPanel();
            this.nameText = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.Label();
            this.idNumeric = new System.Windows.Forms.NumericUpDown();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.workshopNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.bossNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDeskTop.SuspendLayout();
            this.tableLayoutPanelDeskTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDeskTop
            // 
            this.panelDeskTop.Controls.Add(this.tableLayoutPanelDeskTop);
            this.panelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskTop.Location = new System.Drawing.Point(0, 0);
            this.panelDeskTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDeskTop.Name = "panelDeskTop";
            this.panelDeskTop.Size = new System.Drawing.Size(602, 196);
            this.panelDeskTop.TabIndex = 1;
            // 
            // tableLayoutPanelDeskTop
            // 
            this.tableLayoutPanelDeskTop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanelDeskTop.ColumnCount = 2;
            this.tableLayoutPanelDeskTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelDeskTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelDeskTop.Controls.Add(this.nameText, 0, 1);
            this.tableLayoutPanelDeskTop.Controls.Add(this.btnUpdate, 1, 11);
            this.tableLayoutPanelDeskTop.Controls.Add(this.idText, 0, 0);
            this.tableLayoutPanelDeskTop.Controls.Add(this.idNumeric, 1, 0);
            this.tableLayoutPanelDeskTop.Controls.Add(this.nameBox, 1, 1);
            this.tableLayoutPanelDeskTop.Controls.Add(this.workshopNumeric, 1, 3);
            this.tableLayoutPanelDeskTop.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanelDeskTop.Controls.Add(this.bossNumeric, 1, 10);
            this.tableLayoutPanelDeskTop.Controls.Add(this.label1, 0, 10);
            this.tableLayoutPanelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDeskTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDeskTop.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelDeskTop.Name = "tableLayoutPanelDeskTop";
            this.tableLayoutPanelDeskTop.RowCount = 5;
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.29914F));
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.70086F));
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.Size = new System.Drawing.Size(602, 196);
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
            this.btnUpdate.Location = new System.Drawing.Point(182, 109);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(418, 85);
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
            // workshopNumeric
            // 
            this.workshopNumeric.Location = new System.Drawing.Point(183, 55);
            this.workshopNumeric.Name = "workshopNumeric";
            this.workshopNumeric.Size = new System.Drawing.Size(416, 20);
            this.workshopNumeric.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Workshop№";
            // 
            // bossNumeric
            // 
            this.bossNumeric.Location = new System.Drawing.Point(183, 80);
            this.bossNumeric.Name = "bossNumeric";
            this.bossNumeric.Size = new System.Drawing.Size(416, 20);
            this.bossNumeric.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Boss№";
            // 
            // FormUpdateArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 196);
            this.Controls.Add(this.panelDeskTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(618, 411);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(618, 111);
            this.Name = "FormUpdateArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit";
            this.panelDeskTop.ResumeLayout(false);
            this.tableLayoutPanelDeskTop.ResumeLayout(false);
            this.tableLayoutPanelDeskTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossNumeric)).EndInit();
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
        private System.Windows.Forms.NumericUpDown workshopNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown bossNumeric;
        private System.Windows.Forms.Label label1;
    }
}