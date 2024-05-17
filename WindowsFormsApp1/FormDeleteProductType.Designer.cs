
namespace WindowsFormsApp1
{
    partial class FormDeleteProductType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeleteProductType));
            this.panelDeskTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanelDeskTop = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.numericID = new System.Windows.Forms.NumericUpDown();
            this.id = new System.Windows.Forms.Label();
            this.panelDeskTop.SuspendLayout();
            this.tableLayoutPanelDeskTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDeskTop
            // 
            this.panelDeskTop.Controls.Add(this.tableLayoutPanelDeskTop);
            this.panelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskTop.Location = new System.Drawing.Point(0, 0);
            this.panelDeskTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDeskTop.Name = "panelDeskTop";
            this.panelDeskTop.Size = new System.Drawing.Size(602, 122);
            this.panelDeskTop.TabIndex = 1;
            // 
            // tableLayoutPanelDeskTop
            // 
            this.tableLayoutPanelDeskTop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanelDeskTop.ColumnCount = 2;
            this.tableLayoutPanelDeskTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelDeskTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelDeskTop.Controls.Add(this.btn_Delete, 1, 2);
            this.tableLayoutPanelDeskTop.Controls.Add(this.numericID, 1, 0);
            this.tableLayoutPanelDeskTop.Controls.Add(this.id, 0, 0);
            this.tableLayoutPanelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDeskTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDeskTop.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelDeskTop.Name = "tableLayoutPanelDeskTop";
            this.tableLayoutPanelDeskTop.RowCount = 3;
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanelDeskTop.Size = new System.Drawing.Size(602, 122);
            this.tableLayoutPanelDeskTop.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(182, 28);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(418, 92);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Видалення товару";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // numericID
            // 
            this.numericID.Location = new System.Drawing.Point(183, 3);
            this.numericID.Name = "numericID";
            this.numericID.Size = new System.Drawing.Size(416, 20);
            this.numericID.TabIndex = 8;
            // 
            // id
            // 
            this.id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.Location = new System.Drawing.Point(148, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(29, 25);
            this.id.TabIndex = 9;
            this.id.Text = "id";
            // 
            // FormDeleteProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 122);
            this.Controls.Add(this.panelDeskTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(618, 411);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(618, 111);
            this.Name = "FormDeleteProductType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete";
            this.panelDeskTop.ResumeLayout(false);
            this.tableLayoutPanelDeskTop.ResumeLayout(false);
            this.tableLayoutPanelDeskTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDeskTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDeskTop;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.NumericUpDown numericID;
        private System.Windows.Forms.Label id;
    }
}