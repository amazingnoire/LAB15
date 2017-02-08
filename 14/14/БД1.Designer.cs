namespace _14
{
    partial class БД1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.бДDataSet = new _14.БДDataSet();
            this.владельцыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.владельцыTableAdapter = new _14.БДDataSetTableAdapters.ВладельцыTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодулицыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номердомаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дробнаячастьномераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.владельцыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.кодулицыDataGridViewTextBoxColumn,
            this.номердомаDataGridViewTextBoxColumn,
            this.дробнаячастьномераDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.владельцыBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // бДDataSet
            // 
            this.бДDataSet.DataSetName = "БДDataSet";
            this.бДDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // владельцыBindingSource
            // 
            this.владельцыBindingSource.DataMember = "Владельцы";
            this.владельцыBindingSource.DataSource = this.бДDataSet;
            // 
            // владельцыTableAdapter
            // 
            this.владельцыTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // кодулицыDataGridViewTextBoxColumn
            // 
            this.кодулицыDataGridViewTextBoxColumn.DataPropertyName = "Код_улицы";
            this.кодулицыDataGridViewTextBoxColumn.HeaderText = "Код_улицы";
            this.кодулицыDataGridViewTextBoxColumn.Name = "кодулицыDataGridViewTextBoxColumn";
            // 
            // номердомаDataGridViewTextBoxColumn
            // 
            this.номердомаDataGridViewTextBoxColumn.DataPropertyName = "Номер_дома";
            this.номердомаDataGridViewTextBoxColumn.HeaderText = "Номер_дома";
            this.номердомаDataGridViewTextBoxColumn.Name = "номердомаDataGridViewTextBoxColumn";
            // 
            // дробнаячастьномераDataGridViewTextBoxColumn
            // 
            this.дробнаячастьномераDataGridViewTextBoxColumn.DataPropertyName = "Дробная_часть_номера";
            this.дробнаячастьномераDataGridViewTextBoxColumn.HeaderText = "Дробная_часть_номера";
            this.дробнаячастьномераDataGridViewTextBoxColumn.Name = "дробнаячастьномераDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // БД1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 411);
            this.Controls.Add(this.dataGridView1);
            this.Name = "БД1";
            this.Text = "БД1";
            this.Load += new System.EventHandler(this.БД1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.владельцыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private БДDataSet бДDataSet;
        private System.Windows.Forms.BindingSource владельцыBindingSource;
        private БДDataSetTableAdapters.ВладельцыTableAdapter владельцыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодулицыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номердомаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дробнаячастьномераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
    }
}