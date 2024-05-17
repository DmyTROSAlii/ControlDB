
namespace WindowsFormsApp1
{
    partial class FormInsertProductType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInsertProductType));
            this.panelDeskTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanelDeskTop = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.categoryNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.panelDeskTop.SuspendLayout();
            this.tableLayoutPanelDeskTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDeskTop
            // 
            this.panelDeskTop.Controls.Add(this.tableLayoutPanelDeskTop);
            this.panelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskTop.Location = new System.Drawing.Point(0, 0);
            this.panelDeskTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDeskTop.Name = "panelDeskTop";
            this.panelDeskTop.Size = new System.Drawing.Size(588, 157);
            this.panelDeskTop.TabIndex = 0;
            // 
            // tableLayoutPanelDeskTop
            // 
            this.tableLayoutPanelDeskTop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanelDeskTop.ColumnCount = 2;
            this.tableLayoutPanelDeskTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelDeskTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelDeskTop.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelDeskTop.Controls.Add(this.btnInsert, 1, 3);
            this.tableLayoutPanelDeskTop.Controls.Add(this.categoryNumeric, 1, 1);
            this.tableLayoutPanelDeskTop.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanelDeskTop.Controls.Add(this.nameBox, 1, 0);
            this.tableLayoutPanelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDeskTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDeskTop.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelDeskTop.Name = "tableLayoutPanelDeskTop";
            this.tableLayoutPanelDeskTop.RowCount = 3;
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.08609F));
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.91391F));
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanelDeskTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelDeskTop.Size = new System.Drawing.Size(588, 157);
            this.tableLayoutPanelDeskTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва";
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(178, 63);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(408, 92);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Додати товар";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // categoryNumeric
            // 
            this.categoryNumeric.Location = new System.Drawing.Point(179, 29);
            this.categoryNumeric.Name = "categoryNumeric";
            this.categoryNumeric.Size = new System.Drawing.Size(406, 20);
            this.categoryNumeric.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4);
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Категорія продукту№";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(179, 3);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(406, 20);
            this.nameBox.TabIndex = 19;
            // 
            // FormInsertProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(588, 157);
            this.Controls.Add(this.panelDeskTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(604, 414);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(604, 114);
            this.Name = "FormInsertProductType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insert";
            this.panelDeskTop.ResumeLayout(false);
            this.tableLayoutPanelDeskTop.ResumeLayout(false);
            this.tableLayoutPanelDeskTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDeskTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDeskTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.NumericUpDown categoryNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
    }
}