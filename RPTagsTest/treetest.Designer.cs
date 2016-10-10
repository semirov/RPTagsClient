namespace RPTagsTest
{
    partial class treetest
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rPTagsDataSet = new RPTagsTest.RPTagsDataSet();
            this.pLCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLCTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.PLCTableAdapter();
            this.corpusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corpusTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.CorpusTableAdapter();
            this.systemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemaTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.SystemaTableAdapter();
            this.gruptypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruptypeTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.GruptypeTableAdapter();
            this.gruppaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruppaTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.GruppaTableAdapter();
            this.tagTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagTypeTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.TagTypeTableAdapter();
            this.tagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.TagTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTagsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruptypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(306, 393);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.rPTagsDataSet;
            this.bindingSource1.Position = 0;
            // 
            // rPTagsDataSet
            // 
            this.rPTagsDataSet.DataSetName = "RPTagsDataSet";
            this.rPTagsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pLCBindingSource
            // 
            this.pLCBindingSource.DataMember = "PLC";
            this.pLCBindingSource.DataSource = this.rPTagsDataSet;
            // 
            // pLCTableAdapter
            // 
            this.pLCTableAdapter.ClearBeforeFill = true;
            // 
            // corpusBindingSource
            // 
            this.corpusBindingSource.DataMember = "Corpus";
            this.corpusBindingSource.DataSource = this.rPTagsDataSet;
            // 
            // corpusTableAdapter
            // 
            this.corpusTableAdapter.ClearBeforeFill = true;
            // 
            // systemaBindingSource
            // 
            this.systemaBindingSource.DataMember = "Systema";
            this.systemaBindingSource.DataSource = this.rPTagsDataSet;
            // 
            // systemaTableAdapter
            // 
            this.systemaTableAdapter.ClearBeforeFill = true;
            // 
            // gruptypeBindingSource
            // 
            this.gruptypeBindingSource.DataMember = "Gruptype";
            this.gruptypeBindingSource.DataSource = this.rPTagsDataSet;
            // 
            // gruptypeTableAdapter
            // 
            this.gruptypeTableAdapter.ClearBeforeFill = true;
            // 
            // gruppaBindingSource
            // 
            this.gruppaBindingSource.DataMember = "Gruppa";
            this.gruppaBindingSource.DataSource = this.rPTagsDataSet;
            // 
            // gruppaTableAdapter
            // 
            this.gruppaTableAdapter.ClearBeforeFill = true;
            // 
            // tagTypeBindingSource
            // 
            this.tagTypeBindingSource.DataMember = "TagType";
            this.tagTypeBindingSource.DataSource = this.rPTagsDataSet;
            // 
            // tagTypeTableAdapter
            // 
            this.tagTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tagBindingSource
            // 
            this.tagBindingSource.DataMember = "Tag";
            this.tagBindingSource.DataSource = this.rPTagsDataSet;
            // 
            // tagTableAdapter
            // 
            this.tagTableAdapter.ClearBeforeFill = true;
            // 
            // treetest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 728);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "treetest";
            this.Text = "treetest";
            this.Load += new System.EventHandler(this.treetest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTagsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruptypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private RPTagsDataSet rPTagsDataSet;
        private System.Windows.Forms.BindingSource pLCBindingSource;
        private RPTagsDataSetTableAdapters.PLCTableAdapter pLCTableAdapter;
        private System.Windows.Forms.BindingSource corpusBindingSource;
        private RPTagsDataSetTableAdapters.CorpusTableAdapter corpusTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource systemaBindingSource;
        private RPTagsDataSetTableAdapters.SystemaTableAdapter systemaTableAdapter;
        private System.Windows.Forms.BindingSource gruptypeBindingSource;
        private RPTagsDataSetTableAdapters.GruptypeTableAdapter gruptypeTableAdapter;
        private System.Windows.Forms.BindingSource gruppaBindingSource;
        private RPTagsDataSetTableAdapters.GruppaTableAdapter gruppaTableAdapter;
        private System.Windows.Forms.BindingSource tagTypeBindingSource;
        private RPTagsDataSetTableAdapters.TagTypeTableAdapter tagTypeTableAdapter;
        private System.Windows.Forms.BindingSource tagBindingSource;
        private RPTagsDataSetTableAdapters.TagTableAdapter tagTableAdapter;
    }
}