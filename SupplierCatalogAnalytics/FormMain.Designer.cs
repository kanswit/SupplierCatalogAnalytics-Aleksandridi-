namespace SupplierCatalogAnalytics
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCatalog = new System.Windows.Forms.DataGridView();
            this.btnExcept = new System.Windows.Forms.Button();
            this.btnConcatDistinct = new System.Windows.Forms.Button();
            this.btnUnionSorted = new System.Windows.Forms.Button();
            this.rdbAsc = new System.Windows.Forms.RadioButton();
            this.rdbDesc = new System.Windows.Forms.RadioButton();
            this.btnIntersect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCatalog
            // 
            this.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalog.Location = new System.Drawing.Point(12, 73);
            this.dgvCatalog.Name = "dgvCatalog";
            this.dgvCatalog.Size = new System.Drawing.Size(776, 352);
            this.dgvCatalog.TabIndex = 0;
            this.dgvCatalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalog_CellContentClick);
            // 
            // btnExcept
            // 
            this.btnExcept.Location = new System.Drawing.Point(12, 12);
            this.btnExcept.Name = "btnExcept";
            this.btnExcept.Size = new System.Drawing.Size(75, 23);
            this.btnExcept.TabIndex = 1;
            this.btnExcept.Text = "button1";
            this.btnExcept.UseVisualStyleBackColor = true;
            this.btnExcept.Click += new System.EventHandler(this.btnExcept_Click);
            // 
            // btnConcatDistinct
            // 
            this.btnConcatDistinct.Location = new System.Drawing.Point(93, 12);
            this.btnConcatDistinct.Name = "btnConcatDistinct";
            this.btnConcatDistinct.Size = new System.Drawing.Size(75, 23);
            this.btnConcatDistinct.TabIndex = 2;
            this.btnConcatDistinct.Text = "button1";
            this.btnConcatDistinct.UseVisualStyleBackColor = true;
            this.btnConcatDistinct.Click += new System.EventHandler(this.btnConcatDistinct_Click);
            // 
            // btnUnionSorted
            // 
            this.btnUnionSorted.Location = new System.Drawing.Point(174, 12);
            this.btnUnionSorted.Name = "btnUnionSorted";
            this.btnUnionSorted.Size = new System.Drawing.Size(75, 23);
            this.btnUnionSorted.TabIndex = 3;
            this.btnUnionSorted.Text = "button1";
            this.btnUnionSorted.UseVisualStyleBackColor = true;
            this.btnUnionSorted.Click += new System.EventHandler(this.btnUnionSorted_Click);
            // 
            // rdbAsc
            // 
            this.rdbAsc.AutoSize = true;
            this.rdbAsc.Location = new System.Drawing.Point(12, 50);
            this.rdbAsc.Name = "rdbAsc";
            this.rdbAsc.Size = new System.Drawing.Size(85, 17);
            this.rdbAsc.TabIndex = 4;
            this.rdbAsc.TabStop = true;
            this.rdbAsc.Text = "radioButton1";
            this.rdbAsc.UseVisualStyleBackColor = true;
            this.rdbAsc.CheckedChanged += new System.EventHandler(this.rdbAsc_CheckedChanged);
            // 
            // rdbDesc
            // 
            this.rdbDesc.AutoSize = true;
            this.rdbDesc.Location = new System.Drawing.Point(132, 50);
            this.rdbDesc.Name = "rdbDesc";
            this.rdbDesc.Size = new System.Drawing.Size(85, 17);
            this.rdbDesc.TabIndex = 5;
            this.rdbDesc.TabStop = true;
            this.rdbDesc.Text = "radioButton1";
            this.rdbDesc.UseVisualStyleBackColor = true;
            this.rdbDesc.CheckedChanged += new System.EventHandler(this.rdbDesc_CheckedChanged);
            // 
            // btnIntersect
            // 
            this.btnIntersect.Location = new System.Drawing.Point(255, 12);
            this.btnIntersect.Name = "btnIntersect";
            this.btnIntersect.Size = new System.Drawing.Size(75, 23);
            this.btnIntersect.TabIndex = 6;
            this.btnIntersect.Text = "button1";
            this.btnIntersect.UseVisualStyleBackColor = true;
            this.btnIntersect.Click += new System.EventHandler(this.btnApplySort_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(571, 428);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "label1";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnIntersect);
            this.Controls.Add(this.rdbDesc);
            this.Controls.Add(this.rdbAsc);
            this.Controls.Add(this.btnUnionSorted);
            this.Controls.Add(this.btnConcatDistinct);
            this.Controls.Add(this.btnExcept);
            this.Controls.Add(this.dgvCatalog);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCatalog;
        private System.Windows.Forms.Button btnExcept;
        private System.Windows.Forms.Button btnConcatDistinct;
        private System.Windows.Forms.Button btnUnionSorted;
        private System.Windows.Forms.RadioButton rdbAsc;
        private System.Windows.Forms.RadioButton rdbDesc;
        private System.Windows.Forms.Button btnIntersect;
        private System.Windows.Forms.Label lblStatus;
    }
}

