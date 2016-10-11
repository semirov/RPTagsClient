namespace RPTagsTest
{
    partial class Form2
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
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label descriptionLabel1;
            System.Windows.Forms.Label iPAddrLabel;
            System.Windows.Forms.Label nameLabel2;
            System.Windows.Forms.Label rNameLabel;
            System.Windows.Forms.Label descriptionLabel2;
            System.Windows.Forms.Label nameLabel3;
            System.Windows.Forms.Label rNameLabel1;
            System.Windows.Forms.Label descriptionLabel3;
            System.Windows.Forms.Label areaLabel;
            System.Windows.Forms.Label filterLabel;
            System.Windows.Forms.Label relatedValue5Label;
            System.Windows.Forms.Label tLA_MSGLabel;
            System.Windows.Forms.Label relatedValue4Label;
            System.Windows.Forms.Label relatedValue3Label;
            System.Windows.Forms.Label relatedValue2Label;
            System.Windows.Forms.Label relatedValue1Label;
            System.Windows.Forms.Label normalMSGLabel;
            System.Windows.Forms.Label alarmMSGLabel;
            System.Windows.Forms.Label baseTextLabel;
            System.Windows.Forms.Label systemtypeLabel;
            System.Windows.Forms.Label pLCLabel;
            System.Windows.Forms.Label corpusLabel;
            System.Windows.Forms.Label nodeLabel;
            System.Windows.Forms.Label grupTypeLabel;
            System.Windows.Forms.Label systemaLabel;
            this.corpusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPTagsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPTagsDataSet = new RPTagsTest.RPTagsDataSet();
            this.oPCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruptypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruppaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filtresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagIdTagTypeIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceTagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaAWXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAIDNullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagAWXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagHHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagUDMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagOPCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corpusTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.CorpusTableAdapter();
            this.pLCTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.PLCTableAdapter();
            this.systemaTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.SystemaTableAdapter();
            this.systemTypeTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.SystemTypeTableAdapter();
            this.gruppaTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.GruppaTableAdapter();
            this.gruptypeTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.GruptypeTableAdapter();
            this.tagTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.TagTableAdapter();
            this.tagTypeTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.TagTypeTableAdapter();
            this.filtresTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.FiltresTableAdapter();
            this.oPCTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.OPCTableAdapter();
            this.device_TagTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.Device_TagTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.административныеПараметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaAWXTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.AreaAWXTableAdapter();
            this.tagAWXTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.TagAWXTableAdapter();
            this.tagHHTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.TagHHTableAdapter();
            this.tagUDMTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.TagUDMTableAdapter();
            this.tagOPCTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.TagOPCTableAdapter();
            this.sysidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tagidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Sys_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAIDNullTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.SAIDNullTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.tagIdTagTypeIDTableAdapter = new RPTagsTest.RPTagsDataSetTableAdapters.TagIdTagTypeIDTableAdapter();
            this.corpusBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker6 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker7 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker8 = new System.ComponentModel.BackgroundWorker();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.aDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaAWXdgvGen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView9 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView10 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridView11 = new System.Windows.Forms.DataGridView();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.dataGridView12 = new System.Windows.Forms.DataGridView();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.menuStrip6 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.dataGridView13 = new System.Windows.Forms.DataGridView();
            this.menuStrip7 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.dataGridView17 = new System.Windows.Forms.DataGridView();
            this.dataGridView14 = new System.Windows.Forms.DataGridView();
            this.menuStrip8 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.dataGridView15 = new System.Windows.Forms.DataGridView();
            this.menuStrip9 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.dataGridView16 = new System.Windows.Forms.DataGridView();
            this.menuStrip11 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.sysidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gridDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Tag_id1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tagidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GMP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AdrPLC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Tag_id2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.menuStrip10 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаОшибокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исключитьТегиБезАдресаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel_Systema = new System.Windows.Forms.Panel();
            this.checkBoxSystemaEnabled = new System.Windows.Forms.CheckBox();
            this.buttonSystemaCancel = new System.Windows.Forms.Button();
            this.buttonSystemaSave = new System.Windows.Forms.Button();
            this.pLCComboBox = new System.Windows.Forms.ComboBox();
            this.systemaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rPTags_questiondata = new RPTagsTest.RPTags_questiondata();
            this.systemtypeComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox2 = new System.Windows.Forms.TextBox();
            this.rNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel_PLC = new System.Windows.Forms.Panel();
            this.buttonPLCCalcel = new System.Windows.Forms.Button();
            this.buttonPLCSave = new System.Windows.Forms.Button();
            this.nodeComboBox = new System.Windows.Forms.ComboBox();
            this.pLCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.corpusComboBox = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.iPAddrTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.panel_gruppa = new System.Windows.Forms.Panel();
            this.buttonGruppaCancel = new System.Windows.Forms.Button();
            this.buttonGruppaSave = new System.Windows.Forms.Button();
            this.systemaComboBox = new System.Windows.Forms.ComboBox();
            this.gruppaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grupTypeComboBox = new System.Windows.Forms.ComboBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox3 = new System.Windows.Forms.TextBox();
            this.rNameTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox3 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.panel_tag = new System.Windows.Forms.Panel();
            this.buttonTagCancel = new System.Windows.Forms.Button();
            this.buttonTagSave = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.tagBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.relatedValue5TextBox = new System.Windows.Forms.TextBox();
            this.tLA_MSGTextBox = new System.Windows.Forms.TextBox();
            this.relatedValue4TextBox = new System.Windows.Forms.TextBox();
            this.relatedValue3TextBox = new System.Windows.Forms.TextBox();
            this.relatedValue2TextBox = new System.Windows.Forms.TextBox();
            this.relatedValue1TextBox = new System.Windows.Forms.TextBox();
            this.normalMSGTextBox = new System.Windows.Forms.TextBox();
            this.alarmMSGTextBox = new System.Windows.Forms.TextBox();
            this.baseTextTextBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.panel_corpus = new System.Windows.Forms.Panel();
            this.buttonCorpCancel = new System.Windows.Forms.Button();
            this.buttonCorpSave = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.corpusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.corpusTableAdapter1 = new RPTagsTest.RPTags_questiondataTableAdapters.CorpusTableAdapter();
            this.tableAdapterManager = new RPTagsTest.RPTags_questiondataTableAdapters.TableAdapterManager();
            this.pLCTableAdapter1 = new RPTagsTest.RPTags_questiondataTableAdapters.PLCTableAdapter();
            this.systemaTableAdapter1 = new RPTagsTest.RPTags_questiondataTableAdapters.SystemaTableAdapter();
            this.gruppaTableAdapter1 = new RPTagsTest.RPTags_questiondataTableAdapters.GruppaTableAdapter();
            this.tagTableAdapter1 = new RPTagsTest.RPTags_questiondataTableAdapters.TagTableAdapter();
            this.checkBoxGrupEnabled = new System.Windows.Forms.CheckBox();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            descriptionLabel1 = new System.Windows.Forms.Label();
            iPAddrLabel = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            rNameLabel = new System.Windows.Forms.Label();
            descriptionLabel2 = new System.Windows.Forms.Label();
            nameLabel3 = new System.Windows.Forms.Label();
            rNameLabel1 = new System.Windows.Forms.Label();
            descriptionLabel3 = new System.Windows.Forms.Label();
            areaLabel = new System.Windows.Forms.Label();
            filterLabel = new System.Windows.Forms.Label();
            relatedValue5Label = new System.Windows.Forms.Label();
            tLA_MSGLabel = new System.Windows.Forms.Label();
            relatedValue4Label = new System.Windows.Forms.Label();
            relatedValue3Label = new System.Windows.Forms.Label();
            relatedValue2Label = new System.Windows.Forms.Label();
            relatedValue1Label = new System.Windows.Forms.Label();
            normalMSGLabel = new System.Windows.Forms.Label();
            alarmMSGLabel = new System.Windows.Forms.Label();
            baseTextLabel = new System.Windows.Forms.Label();
            systemtypeLabel = new System.Windows.Forms.Label();
            pLCLabel = new System.Windows.Forms.Label();
            corpusLabel = new System.Windows.Forms.Label();
            nodeLabel = new System.Windows.Forms.Label();
            grupTypeLabel = new System.Windows.Forms.Label();
            systemaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.corpusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTagsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTagsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruptypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagIdTagTypeIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaAWXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAIDNullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagAWXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagHHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagUDMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagOPCBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corpusBindingSource2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage13.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.menuStrip6.SuspendLayout();
            this.tabPage15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView13)).BeginInit();
            this.menuStrip7.SuspendLayout();
            this.tabPage16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView14)).BeginInit();
            this.menuStrip8.SuspendLayout();
            this.tabPage17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView15)).BeginInit();
            this.menuStrip9.SuspendLayout();
            this.tabPage18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView16)).BeginInit();
            this.menuStrip11.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.menuStrip10.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel_Systema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTags_questiondata)).BeginInit();
            this.panel_PLC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLCBindingSource1)).BeginInit();
            this.panel_gruppa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gruppaBindingSource1)).BeginInit();
            this.panel_tag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource1)).BeginInit();
            this.panel_corpus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corpusBindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            resources.ApplyResources(nameLabel, "nameLabel");
            nameLabel.Name = "nameLabel";
            // 
            // descriptionLabel
            // 
            resources.ApplyResources(descriptionLabel, "descriptionLabel");
            descriptionLabel.Name = "descriptionLabel";
            // 
            // nameLabel1
            // 
            resources.ApplyResources(nameLabel1, "nameLabel1");
            nameLabel1.Name = "nameLabel1";
            // 
            // descriptionLabel1
            // 
            resources.ApplyResources(descriptionLabel1, "descriptionLabel1");
            descriptionLabel1.Name = "descriptionLabel1";
            // 
            // iPAddrLabel
            // 
            resources.ApplyResources(iPAddrLabel, "iPAddrLabel");
            iPAddrLabel.Name = "iPAddrLabel";
            // 
            // nameLabel2
            // 
            resources.ApplyResources(nameLabel2, "nameLabel2");
            nameLabel2.Name = "nameLabel2";
            // 
            // rNameLabel
            // 
            resources.ApplyResources(rNameLabel, "rNameLabel");
            rNameLabel.Name = "rNameLabel";
            // 
            // descriptionLabel2
            // 
            resources.ApplyResources(descriptionLabel2, "descriptionLabel2");
            descriptionLabel2.Name = "descriptionLabel2";
            // 
            // nameLabel3
            // 
            resources.ApplyResources(nameLabel3, "nameLabel3");
            nameLabel3.Name = "nameLabel3";
            // 
            // rNameLabel1
            // 
            resources.ApplyResources(rNameLabel1, "rNameLabel1");
            rNameLabel1.Name = "rNameLabel1";
            // 
            // descriptionLabel3
            // 
            resources.ApplyResources(descriptionLabel3, "descriptionLabel3");
            descriptionLabel3.Name = "descriptionLabel3";
            // 
            // areaLabel
            // 
            resources.ApplyResources(areaLabel, "areaLabel");
            areaLabel.Name = "areaLabel";
            // 
            // filterLabel
            // 
            resources.ApplyResources(filterLabel, "filterLabel");
            filterLabel.Name = "filterLabel";
            // 
            // relatedValue5Label
            // 
            resources.ApplyResources(relatedValue5Label, "relatedValue5Label");
            relatedValue5Label.Name = "relatedValue5Label";
            // 
            // tLA_MSGLabel
            // 
            resources.ApplyResources(tLA_MSGLabel, "tLA_MSGLabel");
            tLA_MSGLabel.Name = "tLA_MSGLabel";
            // 
            // relatedValue4Label
            // 
            resources.ApplyResources(relatedValue4Label, "relatedValue4Label");
            relatedValue4Label.Name = "relatedValue4Label";
            // 
            // relatedValue3Label
            // 
            resources.ApplyResources(relatedValue3Label, "relatedValue3Label");
            relatedValue3Label.Name = "relatedValue3Label";
            // 
            // relatedValue2Label
            // 
            resources.ApplyResources(relatedValue2Label, "relatedValue2Label");
            relatedValue2Label.Name = "relatedValue2Label";
            // 
            // relatedValue1Label
            // 
            resources.ApplyResources(relatedValue1Label, "relatedValue1Label");
            relatedValue1Label.Name = "relatedValue1Label";
            // 
            // normalMSGLabel
            // 
            resources.ApplyResources(normalMSGLabel, "normalMSGLabel");
            normalMSGLabel.Name = "normalMSGLabel";
            // 
            // alarmMSGLabel
            // 
            resources.ApplyResources(alarmMSGLabel, "alarmMSGLabel");
            alarmMSGLabel.Name = "alarmMSGLabel";
            // 
            // baseTextLabel
            // 
            resources.ApplyResources(baseTextLabel, "baseTextLabel");
            baseTextLabel.Name = "baseTextLabel";
            // 
            // systemtypeLabel
            // 
            resources.ApplyResources(systemtypeLabel, "systemtypeLabel");
            systemtypeLabel.Name = "systemtypeLabel";
            // 
            // pLCLabel
            // 
            resources.ApplyResources(pLCLabel, "pLCLabel");
            pLCLabel.Name = "pLCLabel";
            // 
            // corpusLabel
            // 
            resources.ApplyResources(corpusLabel, "corpusLabel");
            corpusLabel.Name = "corpusLabel";
            // 
            // nodeLabel
            // 
            resources.ApplyResources(nodeLabel, "nodeLabel");
            nodeLabel.Name = "nodeLabel";
            // 
            // grupTypeLabel
            // 
            resources.ApplyResources(grupTypeLabel, "grupTypeLabel");
            grupTypeLabel.Name = "grupTypeLabel";
            // 
            // systemaLabel
            // 
            resources.ApplyResources(systemaLabel, "systemaLabel");
            systemaLabel.Name = "systemaLabel";
            // 
            // corpusBindingSource
            // 
            this.corpusBindingSource.DataMember = "Corpus";
            this.corpusBindingSource.DataSource = this.rPTagsDataSetBindingSource;
            // 
            // rPTagsDataSetBindingSource
            // 
            this.rPTagsDataSetBindingSource.DataSource = this.rPTagsDataSet;
            this.rPTagsDataSetBindingSource.Position = 0;
            // 
            // rPTagsDataSet
            // 
            this.rPTagsDataSet.DataSetName = "RPTagsDataSet";
            this.rPTagsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oPCBindingSource
            // 
            this.oPCBindingSource.DataMember = "OPC";
            this.oPCBindingSource.DataSource = this.rPTagsDataSetBindingSource;
            // 
            // pLCBindingSource
            // 
            this.pLCBindingSource.DataMember = "PLC";
            this.pLCBindingSource.DataSource = this.rPTagsDataSetBindingSource;
            // 
            // systemTypeBindingSource
            // 
            this.systemTypeBindingSource.DataMember = "SystemType";
            this.systemTypeBindingSource.DataSource = this.rPTagsDataSetBindingSource;
            // 
            // systemaBindingSource
            // 
            this.systemaBindingSource.DataMember = "Systema";
            this.systemaBindingSource.DataSource = this.rPTagsDataSetBindingSource;
            // 
            // gruptypeBindingSource
            // 
            this.gruptypeBindingSource.DataMember = "Gruptype";
            this.gruptypeBindingSource.DataSource = this.rPTagsDataSetBindingSource;
            // 
            // gruppaBindingSource
            // 
            this.gruppaBindingSource.DataMember = "Gruppa";
            this.gruppaBindingSource.DataSource = this.rPTagsDataSetBindingSource;
            // 
            // tagTypeBindingSource
            // 
            this.tagTypeBindingSource.DataMember = "TagType";
            this.tagTypeBindingSource.DataSource = this.rPTagsDataSetBindingSource;
            // 
            // filtresBindingSource
            // 
            this.filtresBindingSource.DataMember = "Filtres";
            this.filtresBindingSource.DataSource = this.rPTagsDataSetBindingSource;
            // 
            // tagBindingSource
            // 
            this.tagBindingSource.DataMember = "Tag";
            this.tagBindingSource.DataSource = this.rPTagsDataSetBindingSource;
            // 
            // tagIdTagTypeIDBindingSource
            // 
            this.tagIdTagTypeIDBindingSource.DataMember = "TagIdTagTypeID";
            this.tagIdTagTypeIDBindingSource.DataSource = this.rPTagsDataSetBindingSource;
            // 
            // deviceTagBindingSource
            // 
            this.deviceTagBindingSource.DataMember = "Device_Tag";
            this.deviceTagBindingSource.DataSource = this.rPTagsDataSetBindingSource;
            // 
            // areaAWXBindingSource
            // 
            this.areaAWXBindingSource.DataMember = "AreaAWX";
            this.areaAWXBindingSource.DataSource = this.rPTagsDataSetBindingSource;
            // 
            // sAIDNullBindingSource
            // 
            this.sAIDNullBindingSource.DataMember = "SAIDNull";
            this.sAIDNullBindingSource.DataSource = this.rPTagsDataSetBindingSource;
            // 
            // tagAWXBindingSource
            // 
            this.tagAWXBindingSource.DataMember = "TagAWX";
            this.tagAWXBindingSource.DataSource = this.rPTagsDataSetBindingSource;
            // 
            // tagHHBindingSource
            // 
            this.tagHHBindingSource.DataMember = "TagHH";
            this.tagHHBindingSource.DataSource = this.rPTagsDataSetBindingSource;
            // 
            // tagUDMBindingSource
            // 
            this.tagUDMBindingSource.DataMember = "TagUDM";
            this.tagUDMBindingSource.DataSource = this.rPTagsDataSetBindingSource;
            // 
            // tagOPCBindingSource
            // 
            this.tagOPCBindingSource.DataMember = "TagOPC";
            this.tagOPCBindingSource.DataSource = this.rPTagsDataSetBindingSource;
            // 
            // corpusTableAdapter
            // 
            this.corpusTableAdapter.ClearBeforeFill = true;
            // 
            // pLCTableAdapter
            // 
            this.pLCTableAdapter.ClearBeforeFill = true;
            // 
            // systemaTableAdapter
            // 
            this.systemaTableAdapter.ClearBeforeFill = true;
            // 
            // systemTypeTableAdapter
            // 
            this.systemTypeTableAdapter.ClearBeforeFill = true;
            // 
            // gruppaTableAdapter
            // 
            this.gruppaTableAdapter.ClearBeforeFill = true;
            // 
            // gruptypeTableAdapter
            // 
            this.gruptypeTableAdapter.ClearBeforeFill = true;
            // 
            // tagTableAdapter
            // 
            this.tagTableAdapter.ClearBeforeFill = true;
            // 
            // tagTypeTableAdapter
            // 
            this.tagTypeTableAdapter.ClearBeforeFill = true;
            // 
            // filtresTableAdapter
            // 
            this.filtresTableAdapter.ClearBeforeFill = true;
            // 
            // oPCTableAdapter
            // 
            this.oPCTableAdapter.ClearBeforeFill = true;
            // 
            // device_TagTableAdapter
            // 
            this.device_TagTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel2,
            this.toolStripSplitButton1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            resources.ApplyResources(this.toolStripStatusLabel4, "toolStripStatusLabel4");
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.административныеПараметрыToolStripMenuItem});
            resources.ApplyResources(this.toolStripSplitButton1, "toolStripSplitButton1");
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            // 
            // административныеПараметрыToolStripMenuItem
            // 
            this.административныеПараметрыToolStripMenuItem.Name = "административныеПараметрыToolStripMenuItem";
            resources.ApplyResources(this.административныеПараметрыToolStripMenuItem, "административныеПараметрыToolStripMenuItem");
            // 
            // areaAWXTableAdapter
            // 
            this.areaAWXTableAdapter.ClearBeforeFill = true;
            // 
            // tagAWXTableAdapter
            // 
            this.tagAWXTableAdapter.ClearBeforeFill = true;
            // 
            // tagHHTableAdapter
            // 
            this.tagHHTableAdapter.ClearBeforeFill = true;
            // 
            // tagUDMTableAdapter
            // 
            this.tagUDMTableAdapter.ClearBeforeFill = true;
            // 
            // tagOPCTableAdapter
            // 
            this.tagOPCTableAdapter.ClearBeforeFill = true;
            // 
            // sysidDataGridViewTextBoxColumn
            // 
            this.sysidDataGridViewTextBoxColumn.AutoComplete = false;
            this.sysidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sysidDataGridViewTextBoxColumn.DataPropertyName = "Sys_id";
            this.sysidDataGridViewTextBoxColumn.DataSource = this.systemaBindingSource;
            this.sysidDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.sysidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.sysidDataGridViewTextBoxColumn, "sysidDataGridViewTextBoxColumn");
            this.sysidDataGridViewTextBoxColumn.Name = "sysidDataGridViewTextBoxColumn";
            this.sysidDataGridViewTextBoxColumn.ReadOnly = true;
            this.sysidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sysidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sysidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // gridDataGridViewTextBoxColumn
            // 
            this.gridDataGridViewTextBoxColumn.AutoComplete = false;
            this.gridDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gridDataGridViewTextBoxColumn.DataPropertyName = "Gr_id";
            this.gridDataGridViewTextBoxColumn.DataSource = this.gruppaBindingSource;
            this.gridDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.gridDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.gridDataGridViewTextBoxColumn, "gridDataGridViewTextBoxColumn");
            this.gridDataGridViewTextBoxColumn.Name = "gridDataGridViewTextBoxColumn";
            this.gridDataGridViewTextBoxColumn.ReadOnly = true;
            this.gridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gridDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // tagidDataGridViewTextBoxColumn
            // 
            this.tagidDataGridViewTextBoxColumn.AutoComplete = false;
            this.tagidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tagidDataGridViewTextBoxColumn.DataPropertyName = "Tag_id";
            this.tagidDataGridViewTextBoxColumn.DataSource = this.tagBindingSource;
            this.tagidDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.tagidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.tagidDataGridViewTextBoxColumn, "tagidDataGridViewTextBoxColumn");
            this.tagidDataGridViewTextBoxColumn.Name = "tagidDataGridViewTextBoxColumn";
            this.tagidDataGridViewTextBoxColumn.ReadOnly = true;
            this.tagidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tagidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tagidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // sAIDDataGridViewTextBoxColumn
            // 
            this.sAIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sAIDDataGridViewTextBoxColumn.DataPropertyName = "SAID";
            resources.ApplyResources(this.sAIDDataGridViewTextBoxColumn, "sAIDDataGridViewTextBoxColumn");
            this.sAIDDataGridViewTextBoxColumn.Name = "sAIDDataGridViewTextBoxColumn";
            // 
            // cutDataGridViewTextBoxColumn
            // 
            this.cutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cutDataGridViewTextBoxColumn.DataPropertyName = "Cut";
            this.cutDataGridViewTextBoxColumn.FalseValue = "0";
            resources.ApplyResources(this.cutDataGridViewTextBoxColumn, "cutDataGridViewTextBoxColumn");
            this.cutDataGridViewTextBoxColumn.Name = "cutDataGridViewTextBoxColumn";
            this.cutDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cutDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cutDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // Sys_id
            // 
            this.Sys_id.DataPropertyName = "Sys_id";
            resources.ApplyResources(this.Sys_id, "Sys_id");
            this.Sys_id.Name = "Sys_id";
            // 
            // Gr_id
            // 
            this.Gr_id.DataPropertyName = "Gr_id";
            resources.ApplyResources(this.Gr_id, "Gr_id");
            this.Gr_id.Name = "Gr_id";
            // 
            // sAIDNullTableAdapter
            // 
            this.sAIDNullTableAdapter.ClearBeforeFill = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            this.backgroundWorker3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker3_RunWorkerCompleted);
            // 
            // backgroundWorker4
            // 
            this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);
            this.backgroundWorker4.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker4_RunWorkerCompleted);
            // 
            // backgroundWorker5
            // 
            this.backgroundWorker5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker5_DoWork);
            this.backgroundWorker5.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker5_RunWorkerCompleted);
            // 
            // tagIdTagTypeIDTableAdapter
            // 
            this.tagIdTagTypeIDTableAdapter.ClearBeforeFill = true;
            // 
            // corpusBindingSource2
            // 
            this.corpusBindingSource2.DataMember = "Corpus";
            this.corpusBindingSource2.DataSource = this.rPTagsDataSet;
            // 
            // backgroundWorker6
            // 
            this.backgroundWorker6.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker6_DoWork);
            this.backgroundWorker6.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker6_RunWorkerCompleted);
            // 
            // backgroundWorker7
            // 
            this.backgroundWorker7.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker7_DoWork);
            this.backgroundWorker7.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker7_ProgressChanged);
            this.backgroundWorker7.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker7_RunWorkerCompleted);
            // 
            // backgroundWorker8
            // 
            this.backgroundWorker8.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker8_DoWork);
            this.backgroundWorker8.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker8_ProgressChanged);
            this.backgroundWorker8.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker8_RunWorkerCompleted);
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.treeView1, "treeView1");
            this.treeView1.Name = "treeView1";
            
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuEdit,
            this.toolStripMenuAdd,
            this.toolStripMenuDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // toolStripMenuEdit
            // 
            this.toolStripMenuEdit.Name = "toolStripMenuEdit";
            resources.ApplyResources(this.toolStripMenuEdit, "toolStripMenuEdit");
            // 
            // toolStripMenuAdd
            // 
            this.toolStripMenuAdd.Name = "toolStripMenuAdd";
            resources.ApplyResources(this.toolStripMenuAdd, "toolStripMenuAdd");
            // 
            // toolStripMenuDelete
            // 
            this.toolStripMenuDelete.Name = "toolStripMenuDelete";
            resources.ApplyResources(this.toolStripMenuDelete, "toolStripMenuDelete");
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.tabControl2);
            resources.ApplyResources(this.tabPage8, "tabPage8");
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Controls.Add(this.tabPage10);
            this.tabControl2.Controls.Add(this.tabPage11);
            this.tabControl2.Controls.Add(this.tabPage12);
            this.tabControl2.Controls.Add(this.tabPage13);
            resources.ApplyResources(this.tabControl2, "tabControl2");
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.groupBox6);
            this.tabPage9.Controls.Add(this.label3);
            this.tabPage9.Controls.Add(this.textBox3);
            this.tabPage9.Controls.Add(this.button3);
            this.tabPage9.Controls.Add(this.dataGridView8);
            this.tabPage9.Controls.Add(this.AreaAWXdgvGen);
            this.tabPage9.Controls.Add(this.button1);
            this.tabPage9.Controls.Add(this.textBox1);
            this.tabPage9.Controls.Add(this.label1);
            this.tabPage9.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPage9, "tabPage9");
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox12);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.checkBox1);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // textBox12
            // 
            resources.ApplyResources(this.textBox12, "textBox12");
            this.textBox12.Name = "textBox12";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView8
            // 
            this.dataGridView8.AllowUserToAddRows = false;
            this.dataGridView8.AllowUserToDeleteRows = false;
            this.dataGridView8.AutoGenerateColumns = false;
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.dDataGridViewTextBoxColumn,
            this.eDataGridViewTextBoxColumn});
            this.dataGridView8.DataSource = this.areaAWXBindingSource;
            resources.ApplyResources(this.dataGridView8, "dataGridView8");
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.ReadOnly = true;
            this.dataGridView8.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView6_DataError);
            // 
            // aDataGridViewTextBoxColumn
            // 
            this.aDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aDataGridViewTextBoxColumn.DataPropertyName = "A";
            resources.ApplyResources(this.aDataGridViewTextBoxColumn, "aDataGridViewTextBoxColumn");
            this.aDataGridViewTextBoxColumn.Name = "aDataGridViewTextBoxColumn";
            this.aDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bDataGridViewTextBoxColumn.DataPropertyName = "B";
            resources.ApplyResources(this.bDataGridViewTextBoxColumn, "bDataGridViewTextBoxColumn");
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            this.bDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            resources.ApplyResources(this.cDataGridViewTextBoxColumn, "cDataGridViewTextBoxColumn");
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dDataGridViewTextBoxColumn
            // 
            this.dDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dDataGridViewTextBoxColumn.DataPropertyName = "D";
            resources.ApplyResources(this.dDataGridViewTextBoxColumn, "dDataGridViewTextBoxColumn");
            this.dDataGridViewTextBoxColumn.Name = "dDataGridViewTextBoxColumn";
            this.dDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eDataGridViewTextBoxColumn
            // 
            this.eDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.eDataGridViewTextBoxColumn.DataPropertyName = "E";
            resources.ApplyResources(this.eDataGridViewTextBoxColumn, "eDataGridViewTextBoxColumn");
            this.eDataGridViewTextBoxColumn.Name = "eDataGridViewTextBoxColumn";
            this.eDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AreaAWXdgvGen
            // 
            resources.ApplyResources(this.AreaAWXdgvGen, "AreaAWXdgvGen");
            this.AreaAWXdgvGen.Name = "AreaAWXdgvGen";
            this.AreaAWXdgvGen.UseVisualStyleBackColor = true;
            this.AreaAWXdgvGen.Click += new System.EventHandler(this.AreaAWXdgvGen_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "Name";
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.ValueMember = "Name";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // checkBox4
            // 
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.label4);
            this.tabPage10.Controls.Add(this.textBox4);
            this.tabPage10.Controls.Add(this.button2);
            this.tabPage10.Controls.Add(this.dataGridView9);
            this.tabPage10.Controls.Add(this.button4);
            this.tabPage10.Controls.Add(this.button5);
            this.tabPage10.Controls.Add(this.textBox5);
            this.tabPage10.Controls.Add(this.label5);
            this.tabPage10.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabPage10, "tabPage10");
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView9
            // 
            this.dataGridView9.AllowUserToAddRows = false;
            this.dataGridView9.AllowUserToDeleteRows = false;
            this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView9, "dataGridView9");
            this.dataGridView9.Name = "dataGridView9";
            this.dataGridView9.ReadOnly = true;
            this.dataGridView9.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView6_DataError);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.checkBox5);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // comboBox4
            // 
            this.comboBox4.DisplayMember = "Name";
            resources.ApplyResources(this.comboBox4, "comboBox4");
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.ValueMember = "Name";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // checkBox5
            // 
            resources.ApplyResources(this.checkBox5, "checkBox5");
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.groupBox7);
            this.tabPage11.Controls.Add(this.label6);
            this.tabPage11.Controls.Add(this.textBox6);
            this.tabPage11.Controls.Add(this.button6);
            this.tabPage11.Controls.Add(this.dataGridView10);
            this.tabPage11.Controls.Add(this.button7);
            this.tabPage11.Controls.Add(this.button8);
            this.tabPage11.Controls.Add(this.textBox7);
            this.tabPage11.Controls.Add(this.label7);
            this.tabPage11.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.tabPage11, "tabPage11");
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox13);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.checkBox2);
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // textBox13
            // 
            resources.ApplyResources(this.textBox13, "textBox13");
            this.textBox13.Name = "textBox13";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView10
            // 
            this.dataGridView10.AllowUserToAddRows = false;
            this.dataGridView10.AllowUserToDeleteRows = false;
            this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView10, "dataGridView10");
            this.dataGridView10.Name = "dataGridView10";
            this.dataGridView10.ReadOnly = true;
            this.dataGridView10.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView6_DataError);
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox7
            // 
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox5);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.checkBox6);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // comboBox5
            // 
            this.comboBox5.DisplayMember = "Name";
            resources.ApplyResources(this.comboBox5, "comboBox5");
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.ValueMember = "Name";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // checkBox6
            // 
            resources.ApplyResources(this.checkBox6, "checkBox6");
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.groupBox8);
            this.tabPage12.Controls.Add(this.label8);
            this.tabPage12.Controls.Add(this.textBox8);
            this.tabPage12.Controls.Add(this.button9);
            this.tabPage12.Controls.Add(this.dataGridView11);
            this.tabPage12.Controls.Add(this.button10);
            this.tabPage12.Controls.Add(this.button11);
            this.tabPage12.Controls.Add(this.textBox9);
            this.tabPage12.Controls.Add(this.label9);
            this.tabPage12.Controls.Add(this.groupBox4);
            resources.ApplyResources(this.tabPage12, "tabPage12");
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBox14);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.checkBox3);
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            // 
            // textBox14
            // 
            resources.ApplyResources(this.textBox14, "textBox14");
            this.textBox14.Name = "textBox14";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            // 
            // button9
            // 
            resources.ApplyResources(this.button9, "button9");
            this.button9.Name = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dataGridView11
            // 
            this.dataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView11, "dataGridView11");
            this.dataGridView11.Name = "dataGridView11";
            this.dataGridView11.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView6_DataError);
            // 
            // button10
            // 
            resources.ApplyResources(this.button10, "button10");
            this.button10.Name = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            resources.ApplyResources(this.button11, "button11");
            this.button11.Name = "button11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // textBox9
            // 
            resources.ApplyResources(this.textBox9, "textBox9");
            this.textBox9.Name = "textBox9";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox6);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.checkBox7);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // comboBox6
            // 
            this.comboBox6.DisplayMember = "Name";
            resources.ApplyResources(this.comboBox6, "comboBox6");
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.ValueMember = "Name";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // checkBox7
            // 
            resources.ApplyResources(this.checkBox7, "checkBox7");
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.groupBox9);
            this.tabPage13.Controls.Add(this.label10);
            this.tabPage13.Controls.Add(this.textBox10);
            this.tabPage13.Controls.Add(this.button12);
            this.tabPage13.Controls.Add(this.dataGridView12);
            this.tabPage13.Controls.Add(this.button13);
            this.tabPage13.Controls.Add(this.button14);
            this.tabPage13.Controls.Add(this.textBox11);
            this.tabPage13.Controls.Add(this.label11);
            this.tabPage13.Controls.Add(this.groupBox5);
            resources.ApplyResources(this.tabPage13, "tabPage13");
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button15);
            resources.ApplyResources(this.groupBox9, "groupBox9");
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.TabStop = false;
            // 
            // button15
            // 
            resources.ApplyResources(this.button15, "button15");
            this.button15.Name = "button15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // textBox10
            // 
            resources.ApplyResources(this.textBox10, "textBox10");
            this.textBox10.Name = "textBox10";
            // 
            // button12
            // 
            resources.ApplyResources(this.button12, "button12");
            this.button12.Name = "button12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // dataGridView12
            // 
            this.dataGridView12.AllowUserToAddRows = false;
            this.dataGridView12.AllowUserToDeleteRows = false;
            this.dataGridView12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView12, "dataGridView12");
            this.dataGridView12.Name = "dataGridView12";
            this.dataGridView12.ReadOnly = true;
            this.dataGridView12.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView6_DataError);
            // 
            // button13
            // 
            resources.ApplyResources(this.button13, "button13");
            this.button13.Name = "button13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            resources.ApplyResources(this.button14, "button14");
            this.button14.Name = "button14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // textBox11
            // 
            resources.ApplyResources(this.textBox11, "textBox11");
            this.textBox11.Name = "textBox11";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox3);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // comboBox3
            // 
            this.comboBox3.DisplayMember = "1";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            resources.GetString("comboBox3.Items"),
            resources.GetString("comboBox3.Items1")});
            resources.ApplyResources(this.comboBox3, "comboBox3");
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.ValueMember = "1";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pLCBindingSource, "Name", true));
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.ValueMember = "Name";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tabControl3);
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage14);
            this.tabControl3.Controls.Add(this.tabPage15);
            this.tabControl3.Controls.Add(this.tabPage16);
            this.tabControl3.Controls.Add(this.tabPage17);
            this.tabControl3.Controls.Add(this.tabPage18);
            resources.ApplyResources(this.tabControl3, "tabControl3");
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.dataGridView5);
            this.tabPage14.Controls.Add(this.menuStrip6);
            resources.ApplyResources(this.tabPage14, "tabPage14");
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToOrderColumns = true;
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.dataGridView5, "dataGridView5");
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.StandardTab = true;
            this.dataGridView5.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellClick);
            this.dataGridView5.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellClick);
            this.dataGridView5.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellClick);
            // 
            // menuStrip6
            // 
            this.menuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15});
            resources.ApplyResources(this.menuStrip6, "menuStrip6");
            this.menuStrip6.Name = "menuStrip6";
            // 
            // toolStripMenuItem13
            // 
            resources.ApplyResources(this.toolStripMenuItem13, "toolStripMenuItem13");
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // toolStripMenuItem14
            // 
            resources.ApplyResources(this.toolStripMenuItem14, "toolStripMenuItem14");
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // toolStripMenuItem15
            // 
            resources.ApplyResources(this.toolStripMenuItem15, "toolStripMenuItem15");
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.toolStripMenuItem15_Click);
            // 
            // tabPage15
            // 
            this.tabPage15.Controls.Add(this.dataGridView13);
            this.tabPage15.Controls.Add(this.menuStrip7);
            resources.ApplyResources(this.tabPage15, "tabPage15");
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // dataGridView13
            // 
            this.dataGridView13.AllowUserToOrderColumns = true;
            this.dataGridView13.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView13.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView13.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.dataGridView13, "dataGridView13");
            this.dataGridView13.Name = "dataGridView13";
            this.dataGridView13.StandardTab = true;
            this.dataGridView13.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView13_CellContentClick);
            this.dataGridView13.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView13_CellContentClick);
            // 
            // menuStrip7
            // 
            this.menuStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem16,
            this.toolStripMenuItem17,
            this.toolStripMenuItem18});
            resources.ApplyResources(this.menuStrip7, "menuStrip7");
            this.menuStrip7.Name = "menuStrip7";
            // 
            // toolStripMenuItem16
            // 
            resources.ApplyResources(this.toolStripMenuItem16, "toolStripMenuItem16");
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.toolStripMenuItem16_Click);
            // 
            // toolStripMenuItem17
            // 
            resources.ApplyResources(this.toolStripMenuItem17, "toolStripMenuItem17");
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.toolStripMenuItem17_Click);
            // 
            // toolStripMenuItem18
            // 
            resources.ApplyResources(this.toolStripMenuItem18, "toolStripMenuItem18");
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Click += new System.EventHandler(this.toolStripMenuItem18_Click);
            // 
            // tabPage16
            // 
            this.tabPage16.Controls.Add(this.dataGridView17);
            this.tabPage16.Controls.Add(this.dataGridView14);
            this.tabPage16.Controls.Add(this.menuStrip8);
            resources.ApplyResources(this.tabPage16, "tabPage16");
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // dataGridView17
            // 
            this.dataGridView17.AllowUserToAddRows = false;
            this.dataGridView17.AllowUserToDeleteRows = false;
            this.dataGridView17.AllowUserToOrderColumns = true;
            this.dataGridView17.AllowUserToResizeRows = false;
            this.dataGridView17.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView17.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView17.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.dataGridView17, "dataGridView17");
            this.dataGridView17.Name = "dataGridView17";
            this.dataGridView17.ReadOnly = true;
            this.dataGridView17.StandardTab = true;
            this.dataGridView17.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView6_DataError);
            // 
            // dataGridView14
            // 
            this.dataGridView14.AllowUserToOrderColumns = true;
            this.dataGridView14.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView14.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView14.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.dataGridView14, "dataGridView14");
            this.dataGridView14.Name = "dataGridView14";
            this.dataGridView14.StandardTab = true;
            this.dataGridView14.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView14_CellBeginEdit);
            this.dataGridView14.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView14_CellClick);
            this.dataGridView14.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView14_CellEndEdit);
            this.dataGridView14.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView14_CellClick);
            // 
            // menuStrip8
            // 
            this.menuStrip8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem19,
            this.toolStripMenuItem20,
            this.toolStripMenuItem21});
            resources.ApplyResources(this.menuStrip8, "menuStrip8");
            this.menuStrip8.Name = "menuStrip8";
            // 
            // toolStripMenuItem19
            // 
            resources.ApplyResources(this.toolStripMenuItem19, "toolStripMenuItem19");
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Click += new System.EventHandler(this.toolStripMenuItem19_Click);
            // 
            // toolStripMenuItem20
            // 
            resources.ApplyResources(this.toolStripMenuItem20, "toolStripMenuItem20");
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Click += new System.EventHandler(this.toolStripMenuItem20_Click);
            // 
            // toolStripMenuItem21
            // 
            resources.ApplyResources(this.toolStripMenuItem21, "toolStripMenuItem21");
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Click += new System.EventHandler(this.toolStripMenuItem21_Click);
            // 
            // tabPage17
            // 
            this.tabPage17.Controls.Add(this.dataGridView15);
            this.tabPage17.Controls.Add(this.menuStrip9);
            resources.ApplyResources(this.tabPage17, "tabPage17");
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // dataGridView15
            // 
            this.dataGridView15.AllowUserToOrderColumns = true;
            this.dataGridView15.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView15.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView15.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.dataGridView15, "dataGridView15");
            this.dataGridView15.Name = "dataGridView15";
            this.dataGridView15.StandardTab = true;
            this.dataGridView15.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView15_CellContentClick);
            this.dataGridView15.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView15_CellContentClick);
            // 
            // menuStrip9
            // 
            this.menuStrip9.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem22,
            this.toolStripMenuItem23,
            this.toolStripMenuItem24});
            resources.ApplyResources(this.menuStrip9, "menuStrip9");
            this.menuStrip9.Name = "menuStrip9";
            // 
            // toolStripMenuItem22
            // 
            resources.ApplyResources(this.toolStripMenuItem22, "toolStripMenuItem22");
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Click += new System.EventHandler(this.toolStripMenuItem22_Click);
            // 
            // toolStripMenuItem23
            // 
            resources.ApplyResources(this.toolStripMenuItem23, "toolStripMenuItem23");
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Click += new System.EventHandler(this.toolStripMenuItem23_Click);
            // 
            // toolStripMenuItem24
            // 
            resources.ApplyResources(this.toolStripMenuItem24, "toolStripMenuItem24");
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.Click += new System.EventHandler(this.toolStripMenuItem24_Click);
            // 
            // tabPage18
            // 
            this.tabPage18.Controls.Add(this.dataGridView16);
            this.tabPage18.Controls.Add(this.menuStrip11);
            resources.ApplyResources(this.tabPage18, "tabPage18");
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.UseVisualStyleBackColor = true;
            // 
            // dataGridView16
            // 
            this.dataGridView16.AllowUserToOrderColumns = true;
            this.dataGridView16.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView16.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView16.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.dataGridView16, "dataGridView16");
            this.dataGridView16.Name = "dataGridView16";
            this.dataGridView16.StandardTab = true;
            this.dataGridView16.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView16_CellClick);
            this.dataGridView16.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView16_CellClick);
            // 
            // menuStrip11
            // 
            this.menuStrip11.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12,
            this.toolStripMenuItem25,
            this.toolStripMenuItem28});
            resources.ApplyResources(this.menuStrip11, "menuStrip11");
            this.menuStrip11.Name = "menuStrip11";
            // 
            // toolStripMenuItem12
            // 
            resources.ApplyResources(this.toolStripMenuItem12, "toolStripMenuItem12");
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // toolStripMenuItem25
            // 
            resources.ApplyResources(this.toolStripMenuItem25, "toolStripMenuItem25");
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Click += new System.EventHandler(this.toolStripMenuItem25_Click);
            // 
            // toolStripMenuItem28
            // 
            resources.ApplyResources(this.toolStripMenuItem28, "toolStripMenuItem28");
            this.toolStripMenuItem28.Name = "toolStripMenuItem28";
            this.toolStripMenuItem28.Click += new System.EventHandler(this.toolStripMenuItem28_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.Transparent;
            this.tabPage7.Controls.Add(this.dataGridView7);
            this.tabPage7.Controls.Add(this.menuStrip10);
            resources.ApplyResources(this.tabPage7, "tabPage7");
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Leave += new System.EventHandler(this.tabPage7_Leave);
            // 
            // dataGridView7
            // 
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sysidDataGridViewTextBoxColumn1,
            this.gridDataGridViewTextBoxColumn1,
            this.Tag_id1,
            this.tagidDataGridViewTextBoxColumn1,
            this.GMP,
            this.AdrPLC,
            this.sAIDDataGridViewTextBoxColumn1,
            this.cutDataGridViewTextBoxColumn1,
            this.Tag_id2});
            this.dataGridView7.DataSource = this.deviceTagBindingSource;
            resources.ApplyResources(this.dataGridView7, "dataGridView7");
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView7_CellEndEdit);
            this.dataGridView7.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView6_DataError);
            // 
            // sysidDataGridViewTextBoxColumn1
            // 
            this.sysidDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sysidDataGridViewTextBoxColumn1.DataPropertyName = "Sys_id";
            this.sysidDataGridViewTextBoxColumn1.DataSource = this.systemaBindingSource;
            this.sysidDataGridViewTextBoxColumn1.DisplayMember = "Name";
            this.sysidDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.sysidDataGridViewTextBoxColumn1, "sysidDataGridViewTextBoxColumn1");
            this.sysidDataGridViewTextBoxColumn1.Name = "sysidDataGridViewTextBoxColumn1";
            this.sysidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sysidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sysidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sysidDataGridViewTextBoxColumn1.ValueMember = "id";
            // 
            // gridDataGridViewTextBoxColumn1
            // 
            this.gridDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gridDataGridViewTextBoxColumn1.DataPropertyName = "Gr_id";
            this.gridDataGridViewTextBoxColumn1.DataSource = this.gruppaBindingSource;
            this.gridDataGridViewTextBoxColumn1.DisplayMember = "Name";
            this.gridDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.gridDataGridViewTextBoxColumn1, "gridDataGridViewTextBoxColumn1");
            this.gridDataGridViewTextBoxColumn1.Name = "gridDataGridViewTextBoxColumn1";
            this.gridDataGridViewTextBoxColumn1.ReadOnly = true;
            this.gridDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gridDataGridViewTextBoxColumn1.ValueMember = "id";
            // 
            // Tag_id1
            // 
            this.Tag_id1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tag_id1.DataPropertyName = "Tag_id";
            this.Tag_id1.DataSource = this.tagIdTagTypeIDBindingSource;
            this.Tag_id1.DisplayMember = "Name";
            this.Tag_id1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.Tag_id1, "Tag_id1");
            this.Tag_id1.Name = "Tag_id1";
            this.Tag_id1.ReadOnly = true;
            this.Tag_id1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tag_id1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Tag_id1.ValueMember = "id";
            // 
            // tagidDataGridViewTextBoxColumn1
            // 
            this.tagidDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tagidDataGridViewTextBoxColumn1.DataPropertyName = "Tag_id";
            this.tagidDataGridViewTextBoxColumn1.DataSource = this.tagBindingSource;
            this.tagidDataGridViewTextBoxColumn1.DisplayMember = "Name";
            this.tagidDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.tagidDataGridViewTextBoxColumn1, "tagidDataGridViewTextBoxColumn1");
            this.tagidDataGridViewTextBoxColumn1.Name = "tagidDataGridViewTextBoxColumn1";
            this.tagidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tagidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tagidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tagidDataGridViewTextBoxColumn1.ValueMember = "id";
            // 
            // GMP
            // 
            this.GMP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GMP.DataPropertyName = "GMP";
            resources.ApplyResources(this.GMP, "GMP");
            this.GMP.Name = "GMP";
            this.GMP.TrueValue = "1";
            // 
            // AdrPLC
            // 
            this.AdrPLC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AdrPLC.DataPropertyName = "AdrPLC";
            resources.ApplyResources(this.AdrPLC, "AdrPLC");
            this.AdrPLC.Name = "AdrPLC";
            // 
            // sAIDDataGridViewTextBoxColumn1
            // 
            this.sAIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sAIDDataGridViewTextBoxColumn1.DataPropertyName = "SAID";
            resources.ApplyResources(this.sAIDDataGridViewTextBoxColumn1, "sAIDDataGridViewTextBoxColumn1");
            this.sAIDDataGridViewTextBoxColumn1.Name = "sAIDDataGridViewTextBoxColumn1";
            // 
            // cutDataGridViewTextBoxColumn1
            // 
            this.cutDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cutDataGridViewTextBoxColumn1.DataPropertyName = "Cut";
            resources.ApplyResources(this.cutDataGridViewTextBoxColumn1, "cutDataGridViewTextBoxColumn1");
            this.cutDataGridViewTextBoxColumn1.Name = "cutDataGridViewTextBoxColumn1";
            this.cutDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cutDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cutDataGridViewTextBoxColumn1.TrueValue = "1";
            // 
            // Tag_id2
            // 
            this.Tag_id2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tag_id2.DataPropertyName = "Tag_id";
            this.Tag_id2.DataSource = this.tagIdTagTypeIDBindingSource;
            this.Tag_id2.DisplayMember = "Description";
            this.Tag_id2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            resources.ApplyResources(this.Tag_id2, "Tag_id2");
            this.Tag_id2.Name = "Tag_id2";
            this.Tag_id2.ReadOnly = true;
            this.Tag_id2.ValueMember = "id";
            // 
            // menuStrip10
            // 
            this.menuStrip10.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem26,
            this.toolStripMenuItem27,
            this.действияToolStripMenuItem});
            resources.ApplyResources(this.menuStrip10, "menuStrip10");
            this.menuStrip10.Name = "menuStrip10";
            // 
            // toolStripMenuItem26
            // 
            resources.ApplyResources(this.toolStripMenuItem26, "toolStripMenuItem26");
            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
            this.toolStripMenuItem26.Click += new System.EventHandler(this.toolStripMenuItem26_Click);
            // 
            // toolStripMenuItem27
            // 
            resources.ApplyResources(this.toolStripMenuItem27, "toolStripMenuItem27");
            this.toolStripMenuItem27.Name = "toolStripMenuItem27";
            this.toolStripMenuItem27.Click += new System.EventHandler(this.toolStripMenuItem27_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проверкаОшибокToolStripMenuItem,
            this.отменитьИзмененияToolStripMenuItem,
            this.исключитьТегиБезАдресаToolStripMenuItem});
            resources.ApplyResources(this.действияToolStripMenuItem, "действияToolStripMenuItem");
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            // 
            // проверкаОшибокToolStripMenuItem
            // 
            resources.ApplyResources(this.проверкаОшибокToolStripMenuItem, "проверкаОшибокToolStripMenuItem");
            this.проверкаОшибокToolStripMenuItem.Name = "проверкаОшибокToolStripMenuItem";
            this.проверкаОшибокToolStripMenuItem.Click += new System.EventHandler(this.проверитьОшибкиToolStripMenuItem_Click);
            // 
            // отменитьИзмененияToolStripMenuItem
            // 
            resources.ApplyResources(this.отменитьИзмененияToolStripMenuItem, "отменитьИзмененияToolStripMenuItem");
            this.отменитьИзмененияToolStripMenuItem.Name = "отменитьИзмененияToolStripMenuItem";
            this.отменитьИзмененияToolStripMenuItem.Click += new System.EventHandler(this.отменитьИзменнеияToolStripMenuItem_Click);
            // 
            // исключитьТегиБезАдресаToolStripMenuItem
            // 
            resources.ApplyResources(this.исключитьТегиБезАдресаToolStripMenuItem, "исключитьТегиБезАдресаToolStripMenuItem");
            this.исключитьТегиБезАдресаToolStripMenuItem.Name = "исключитьТегиБезАдресаToolStripMenuItem";
            this.исключитьТегиБезАдресаToolStripMenuItem.Click += new System.EventHandler(this.исключитьТегиБезАдресаToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel_gruppa);
            this.tabPage1.Controls.Add(this.panel_tag);
            this.tabPage1.Controls.Add(this.panel_corpus);
            this.tabPage1.Controls.Add(this.panel_Systema);
            this.tabPage1.Controls.Add(this.panel_PLC);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel_Systema
            // 
            this.panel_Systema.Controls.Add(this.checkBoxSystemaEnabled);
            this.panel_Systema.Controls.Add(this.buttonSystemaCancel);
            this.panel_Systema.Controls.Add(this.buttonSystemaSave);
            this.panel_Systema.Controls.Add(pLCLabel);
            this.panel_Systema.Controls.Add(this.pLCComboBox);
            this.panel_Systema.Controls.Add(systemtypeLabel);
            this.panel_Systema.Controls.Add(this.systemtypeComboBox);
            this.panel_Systema.Controls.Add(descriptionLabel2);
            this.panel_Systema.Controls.Add(this.descriptionTextBox2);
            this.panel_Systema.Controls.Add(rNameLabel);
            this.panel_Systema.Controls.Add(this.rNameTextBox);
            this.panel_Systema.Controls.Add(nameLabel2);
            this.panel_Systema.Controls.Add(this.nameTextBox2);
            this.panel_Systema.Controls.Add(this.label23);
            resources.ApplyResources(this.panel_Systema, "panel_Systema");
            this.panel_Systema.Name = "panel_Systema";
            // 
            // checkBoxSystemaEnabled
            // 
            resources.ApplyResources(this.checkBoxSystemaEnabled, "checkBoxSystemaEnabled");
            this.checkBoxSystemaEnabled.Name = "checkBoxSystemaEnabled";
            this.checkBoxSystemaEnabled.UseVisualStyleBackColor = true;
            // 
            // buttonSystemaCancel
            // 
            resources.ApplyResources(this.buttonSystemaCancel, "buttonSystemaCancel");
            this.buttonSystemaCancel.Name = "buttonSystemaCancel";
            this.buttonSystemaCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSystemaSave
            // 
            resources.ApplyResources(this.buttonSystemaSave, "buttonSystemaSave");
            this.buttonSystemaSave.Name = "buttonSystemaSave";
            this.buttonSystemaSave.UseVisualStyleBackColor = true;
            // 
            // pLCComboBox
            // 
            this.pLCComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.systemaBindingSource1, "PLC", true));
            this.pLCComboBox.DataSource = this.pLCBindingSource;
            this.pLCComboBox.DisplayMember = "Name";
            this.pLCComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.pLCComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.pLCComboBox, "pLCComboBox");
            this.pLCComboBox.Name = "pLCComboBox";
            this.pLCComboBox.ValueMember = "id";
            // 
            // systemaBindingSource1
            // 
            this.systemaBindingSource1.DataMember = "Systema";
            this.systemaBindingSource1.DataSource = this.rPTags_questiondata;
            // 
            // rPTags_questiondata
            // 
            this.rPTags_questiondata.DataSetName = "RPTags_questiondata";
            this.rPTags_questiondata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // systemtypeComboBox
            // 
            this.systemtypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.systemaBindingSource1, "Systemtype", true));
            this.systemtypeComboBox.DataSource = this.systemTypeBindingSource;
            this.systemtypeComboBox.DisplayMember = "Name";
            this.systemtypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.systemtypeComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.systemtypeComboBox, "systemtypeComboBox");
            this.systemtypeComboBox.Name = "systemtypeComboBox";
            this.systemtypeComboBox.ValueMember = "id";
            // 
            // descriptionTextBox2
            // 
            this.descriptionTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemaBindingSource1, "Description", true));
            resources.ApplyResources(this.descriptionTextBox2, "descriptionTextBox2");
            this.descriptionTextBox2.Name = "descriptionTextBox2";
            // 
            // rNameTextBox
            // 
            this.rNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemaBindingSource1, "RName", true));
            resources.ApplyResources(this.rNameTextBox, "rNameTextBox");
            this.rNameTextBox.Name = "rNameTextBox";
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemaBindingSource1, "Name", true));
            resources.ApplyResources(this.nameTextBox2, "nameTextBox2");
            this.nameTextBox2.Name = "nameTextBox2";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // panel_PLC
            // 
            this.panel_PLC.Controls.Add(this.buttonPLCCalcel);
            this.panel_PLC.Controls.Add(this.buttonPLCSave);
            this.panel_PLC.Controls.Add(nodeLabel);
            this.panel_PLC.Controls.Add(this.nodeComboBox);
            this.panel_PLC.Controls.Add(corpusLabel);
            this.panel_PLC.Controls.Add(this.corpusComboBox);
            this.panel_PLC.Controls.Add(this.label21);
            this.panel_PLC.Controls.Add(iPAddrLabel);
            this.panel_PLC.Controls.Add(this.iPAddrTextBox);
            this.panel_PLC.Controls.Add(descriptionLabel1);
            this.panel_PLC.Controls.Add(this.descriptionTextBox1);
            this.panel_PLC.Controls.Add(nameLabel1);
            this.panel_PLC.Controls.Add(this.nameTextBox1);
            resources.ApplyResources(this.panel_PLC, "panel_PLC");
            this.panel_PLC.Name = "panel_PLC";
            // 
            // buttonPLCCalcel
            // 
            resources.ApplyResources(this.buttonPLCCalcel, "buttonPLCCalcel");
            this.buttonPLCCalcel.Name = "buttonPLCCalcel";
            this.buttonPLCCalcel.UseVisualStyleBackColor = true;
            // 
            // buttonPLCSave
            // 
            resources.ApplyResources(this.buttonPLCSave, "buttonPLCSave");
            this.buttonPLCSave.Name = "buttonPLCSave";
            this.buttonPLCSave.UseVisualStyleBackColor = true;
            // 
            // nodeComboBox
            // 
            this.nodeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pLCBindingSource1, "Node", true));
            this.nodeComboBox.DataSource = this.oPCBindingSource;
            this.nodeComboBox.DisplayMember = "Name";
            this.nodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.nodeComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.nodeComboBox, "nodeComboBox");
            this.nodeComboBox.Name = "nodeComboBox";
            this.nodeComboBox.ValueMember = "id";
            // 
            // pLCBindingSource1
            // 
            this.pLCBindingSource1.DataMember = "PLC";
            this.pLCBindingSource1.DataSource = this.rPTags_questiondata;
            // 
            // corpusComboBox
            // 
            this.corpusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pLCBindingSource1, "Corpus", true));
            this.corpusComboBox.DataSource = this.corpusBindingSource;
            this.corpusComboBox.DisplayMember = "Name";
            this.corpusComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.corpusComboBox, "corpusComboBox");
            this.corpusComboBox.Name = "corpusComboBox";
            this.corpusComboBox.ValueMember = "id";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // iPAddrTextBox
            // 
            this.iPAddrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pLCBindingSource1, "IPAddr", true));
            resources.ApplyResources(this.iPAddrTextBox, "iPAddrTextBox");
            this.iPAddrTextBox.Name = "iPAddrTextBox";
            // 
            // descriptionTextBox1
            // 
            this.descriptionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pLCBindingSource1, "Description", true));
            resources.ApplyResources(this.descriptionTextBox1, "descriptionTextBox1");
            this.descriptionTextBox1.Name = "descriptionTextBox1";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pLCBindingSource1, "Name", true));
            resources.ApplyResources(this.nameTextBox1, "nameTextBox1");
            this.nameTextBox1.Name = "nameTextBox1";
            // 
            // panel_gruppa
            // 
            this.panel_gruppa.Controls.Add(this.checkBoxGrupEnabled);
            this.panel_gruppa.Controls.Add(this.buttonGruppaCancel);
            this.panel_gruppa.Controls.Add(this.buttonGruppaSave);
            this.panel_gruppa.Controls.Add(systemaLabel);
            this.panel_gruppa.Controls.Add(this.systemaComboBox);
            this.panel_gruppa.Controls.Add(grupTypeLabel);
            this.panel_gruppa.Controls.Add(this.grupTypeComboBox);
            this.panel_gruppa.Controls.Add(areaLabel);
            this.panel_gruppa.Controls.Add(this.areaTextBox);
            this.panel_gruppa.Controls.Add(descriptionLabel3);
            this.panel_gruppa.Controls.Add(this.descriptionTextBox3);
            this.panel_gruppa.Controls.Add(rNameLabel1);
            this.panel_gruppa.Controls.Add(this.rNameTextBox1);
            this.panel_gruppa.Controls.Add(nameLabel3);
            this.panel_gruppa.Controls.Add(this.nameTextBox3);
            this.panel_gruppa.Controls.Add(this.label24);
            resources.ApplyResources(this.panel_gruppa, "panel_gruppa");
            this.panel_gruppa.Name = "panel_gruppa";
            // 
            // buttonGruppaCancel
            // 
            resources.ApplyResources(this.buttonGruppaCancel, "buttonGruppaCancel");
            this.buttonGruppaCancel.Name = "buttonGruppaCancel";
            this.buttonGruppaCancel.UseVisualStyleBackColor = true;
            // 
            // buttonGruppaSave
            // 
            resources.ApplyResources(this.buttonGruppaSave, "buttonGruppaSave");
            this.buttonGruppaSave.Name = "buttonGruppaSave";
            this.buttonGruppaSave.UseVisualStyleBackColor = true;
            // 
            // systemaComboBox
            // 
            this.systemaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gruppaBindingSource1, "Systema", true));
            this.systemaComboBox.DataSource = this.systemaBindingSource;
            this.systemaComboBox.DisplayMember = "Name";
            this.systemaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.systemaComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.systemaComboBox, "systemaComboBox");
            this.systemaComboBox.Name = "systemaComboBox";
            this.systemaComboBox.ValueMember = "id";
            // 
            // gruppaBindingSource1
            // 
            this.gruppaBindingSource1.DataMember = "Gruppa";
            this.gruppaBindingSource1.DataSource = this.rPTags_questiondata;
            // 
            // grupTypeComboBox
            // 
            this.grupTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gruppaBindingSource1, "GrupType", true));
            this.grupTypeComboBox.DataSource = this.gruptypeBindingSource;
            this.grupTypeComboBox.DisplayMember = "Name";
            this.grupTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.grupTypeComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.grupTypeComboBox, "grupTypeComboBox");
            this.grupTypeComboBox.Name = "grupTypeComboBox";
            this.grupTypeComboBox.ValueMember = "id";
            // 
            // areaTextBox
            // 
            this.areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruppaBindingSource1, "Area", true));
            resources.ApplyResources(this.areaTextBox, "areaTextBox");
            this.areaTextBox.Name = "areaTextBox";
            // 
            // descriptionTextBox3
            // 
            this.descriptionTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruppaBindingSource1, "Description", true));
            resources.ApplyResources(this.descriptionTextBox3, "descriptionTextBox3");
            this.descriptionTextBox3.Name = "descriptionTextBox3";
            // 
            // rNameTextBox1
            // 
            this.rNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruppaBindingSource1, "RName", true));
            resources.ApplyResources(this.rNameTextBox1, "rNameTextBox1");
            this.rNameTextBox1.Name = "rNameTextBox1";
            // 
            // nameTextBox3
            // 
            this.nameTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruppaBindingSource1, "Name", true));
            resources.ApplyResources(this.nameTextBox3, "nameTextBox3");
            this.nameTextBox3.Name = "nameTextBox3";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // panel_tag
            // 
            this.panel_tag.Controls.Add(this.buttonTagCancel);
            this.panel_tag.Controls.Add(this.buttonTagSave);
            this.panel_tag.Controls.Add(this.richTextBox1);
            this.panel_tag.Controls.Add(this.comboBox7);
            this.panel_tag.Controls.Add(filterLabel);
            this.panel_tag.Controls.Add(relatedValue5Label);
            this.panel_tag.Controls.Add(this.relatedValue5TextBox);
            this.panel_tag.Controls.Add(tLA_MSGLabel);
            this.panel_tag.Controls.Add(this.tLA_MSGTextBox);
            this.panel_tag.Controls.Add(relatedValue4Label);
            this.panel_tag.Controls.Add(this.relatedValue4TextBox);
            this.panel_tag.Controls.Add(relatedValue3Label);
            this.panel_tag.Controls.Add(this.relatedValue3TextBox);
            this.panel_tag.Controls.Add(relatedValue2Label);
            this.panel_tag.Controls.Add(this.relatedValue2TextBox);
            this.panel_tag.Controls.Add(relatedValue1Label);
            this.panel_tag.Controls.Add(this.relatedValue1TextBox);
            this.panel_tag.Controls.Add(normalMSGLabel);
            this.panel_tag.Controls.Add(this.normalMSGTextBox);
            this.panel_tag.Controls.Add(alarmMSGLabel);
            this.panel_tag.Controls.Add(this.alarmMSGTextBox);
            this.panel_tag.Controls.Add(baseTextLabel);
            this.panel_tag.Controls.Add(this.baseTextTextBox);
            this.panel_tag.Controls.Add(this.label26);
            this.panel_tag.Controls.Add(this.textBox15);
            this.panel_tag.Controls.Add(this.checkBox8);
            this.panel_tag.Controls.Add(this.checkBox9);
            this.panel_tag.Controls.Add(this.checkBox10);
            this.panel_tag.Controls.Add(this.comboBox8);
            this.panel_tag.Controls.Add(this.label27);
            this.panel_tag.Controls.Add(this.comboBox9);
            this.panel_tag.Controls.Add(this.label28);
            this.panel_tag.Controls.Add(this.label29);
            this.panel_tag.Controls.Add(this.textBox16);
            this.panel_tag.Controls.Add(this.label25);
            resources.ApplyResources(this.panel_tag, "panel_tag");
            this.panel_tag.Name = "panel_tag";
            // 
            // buttonTagCancel
            // 
            resources.ApplyResources(this.buttonTagCancel, "buttonTagCancel");
            this.buttonTagCancel.Name = "buttonTagCancel";
            this.buttonTagCancel.UseVisualStyleBackColor = true;
            // 
            // buttonTagSave
            // 
            resources.ApplyResources(this.buttonTagSave, "buttonTagSave");
            this.buttonTagSave.Name = "buttonTagSave";
            this.buttonTagSave.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // comboBox7
            // 
            this.comboBox7.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tagBindingSource1, "Filter", true));
            this.comboBox7.DataSource = this.filtresBindingSource;
            this.comboBox7.DisplayMember = "Description";
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox7.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox7, "comboBox7");
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.ValueMember = "id";
            // 
            // tagBindingSource1
            // 
            this.tagBindingSource1.DataMember = "Tag";
            this.tagBindingSource1.DataSource = this.rPTags_questiondata;
            // 
            // relatedValue5TextBox
            // 
            this.relatedValue5TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagBindingSource1, "RelatedValue5", true));
            resources.ApplyResources(this.relatedValue5TextBox, "relatedValue5TextBox");
            this.relatedValue5TextBox.Name = "relatedValue5TextBox";
            // 
            // tLA_MSGTextBox
            // 
            this.tLA_MSGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagBindingSource1, "TLA_MSG", true));
            resources.ApplyResources(this.tLA_MSGTextBox, "tLA_MSGTextBox");
            this.tLA_MSGTextBox.Name = "tLA_MSGTextBox";
            // 
            // relatedValue4TextBox
            // 
            this.relatedValue4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagBindingSource1, "RelatedValue4", true));
            resources.ApplyResources(this.relatedValue4TextBox, "relatedValue4TextBox");
            this.relatedValue4TextBox.Name = "relatedValue4TextBox";
            // 
            // relatedValue3TextBox
            // 
            this.relatedValue3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagBindingSource1, "RelatedValue3", true));
            resources.ApplyResources(this.relatedValue3TextBox, "relatedValue3TextBox");
            this.relatedValue3TextBox.Name = "relatedValue3TextBox";
            // 
            // relatedValue2TextBox
            // 
            this.relatedValue2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagBindingSource1, "RelatedValue2", true));
            resources.ApplyResources(this.relatedValue2TextBox, "relatedValue2TextBox");
            this.relatedValue2TextBox.Name = "relatedValue2TextBox";
            // 
            // relatedValue1TextBox
            // 
            this.relatedValue1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagBindingSource1, "RelatedValue1", true));
            resources.ApplyResources(this.relatedValue1TextBox, "relatedValue1TextBox");
            this.relatedValue1TextBox.Name = "relatedValue1TextBox";
            // 
            // normalMSGTextBox
            // 
            this.normalMSGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagBindingSource1, "NormalMSG", true));
            resources.ApplyResources(this.normalMSGTextBox, "normalMSGTextBox");
            this.normalMSGTextBox.Name = "normalMSGTextBox";
            // 
            // alarmMSGTextBox
            // 
            this.alarmMSGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagBindingSource1, "AlarmMSG", true));
            resources.ApplyResources(this.alarmMSGTextBox, "alarmMSGTextBox");
            this.alarmMSGTextBox.Name = "alarmMSGTextBox";
            // 
            // baseTextTextBox
            // 
            this.baseTextTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagBindingSource1, "BaseText", true));
            resources.ApplyResources(this.baseTextTextBox, "baseTextTextBox");
            this.baseTextTextBox.Name = "baseTextTextBox";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // textBox15
            // 
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagBindingSource1, "Description", true));
            resources.ApplyResources(this.textBox15, "textBox15");
            this.textBox15.Name = "textBox15";
            // 
            // checkBox8
            // 
            resources.ApplyResources(this.checkBox8, "checkBox8");
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            resources.ApplyResources(this.checkBox9, "checkBox9");
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            resources.ApplyResources(this.checkBox10, "checkBox10");
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // comboBox8
            // 
            this.comboBox8.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tagBindingSource1, "GrupType", true));
            this.comboBox8.DataSource = this.gruptypeBindingSource;
            this.comboBox8.DisplayMember = "Name";
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox8.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox8, "comboBox8");
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.ValueMember = "id";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // comboBox9
            // 
            this.comboBox9.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tagBindingSource1, "TagType", true));
            this.comboBox9.DataSource = this.tagTypeBindingSource;
            this.comboBox9.DisplayMember = "Name";
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox9.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox9, "comboBox9");
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.ValueMember = "id";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagBindingSource1, "Name", true));
            resources.ApplyResources(this.textBox16, "textBox16");
            this.textBox16.Name = "textBox16";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // panel_corpus
            // 
            this.panel_corpus.Controls.Add(this.buttonCorpCancel);
            this.panel_corpus.Controls.Add(this.buttonCorpSave);
            this.panel_corpus.Controls.Add(this.label22);
            this.panel_corpus.Controls.Add(descriptionLabel);
            this.panel_corpus.Controls.Add(this.descriptionTextBox);
            this.panel_corpus.Controls.Add(nameLabel);
            this.panel_corpus.Controls.Add(this.nameTextBox);
            resources.ApplyResources(this.panel_corpus, "panel_corpus");
            this.panel_corpus.Name = "panel_corpus";
            // 
            // buttonCorpCancel
            // 
            resources.ApplyResources(this.buttonCorpCancel, "buttonCorpCancel");
            this.buttonCorpCancel.Name = "buttonCorpCancel";
            this.buttonCorpCancel.UseVisualStyleBackColor = true;
            // 
            // buttonCorpSave
            // 
            resources.ApplyResources(this.buttonCorpSave, "buttonCorpSave");
            this.buttonCorpSave.Name = "buttonCorpSave";
            this.buttonCorpSave.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corpusBindingSource1, "Description", true));
            resources.ApplyResources(this.descriptionTextBox, "descriptionTextBox");
            this.descriptionTextBox.Name = "descriptionTextBox";
            // 
            // corpusBindingSource1
            // 
            this.corpusBindingSource1.DataMember = "Corpus";
            this.corpusBindingSource1.DataSource = this.rPTags_questiondata;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corpusBindingSource1, "Name", true));
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.Name = "nameTextBox";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage8);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // corpusTableAdapter1
            // 
            this.corpusTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CorpusTableAdapter = this.corpusTableAdapter1;
            this.tableAdapterManager.Device_Tag_tempTableAdapter = null;
            this.tableAdapterManager.Device_Tag1TableAdapter = null;
            this.tableAdapterManager.Device_TagTableAdapter = null;
            this.tableAdapterManager.FiltresTableAdapter = null;
            this.tableAdapterManager.GruppaTableAdapter = null;
            this.tableAdapterManager.GruptypeTableAdapter = null;
            this.tableAdapterManager.OPCTableAdapter = null;
            this.tableAdapterManager.PLCTableAdapter = null;
            this.tableAdapterManager.SystemaTableAdapter = null;
            this.tableAdapterManager.SystemTypeTableAdapter = null;
            this.tableAdapterManager.TagTableAdapter = null;
            this.tableAdapterManager.TagTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RPTagsTest.RPTags_questiondataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pLCTableAdapter1
            // 
            this.pLCTableAdapter1.ClearBeforeFill = true;
            // 
            // systemaTableAdapter1
            // 
            this.systemaTableAdapter1.ClearBeforeFill = true;
            // 
            // gruppaTableAdapter1
            // 
            this.gruppaTableAdapter1.ClearBeforeFill = true;
            // 
            // tagTableAdapter1
            // 
            this.tagTableAdapter1.ClearBeforeFill = true;
            // 
            // checkBoxGrupEnabled
            // 
            resources.ApplyResources(this.checkBoxGrupEnabled, "checkBoxGrupEnabled");
            this.checkBoxGrupEnabled.Name = "checkBoxGrupEnabled";
            this.checkBoxGrupEnabled.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.corpusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTagsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTagsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruptypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagIdTagTypeIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaAWXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAIDNullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagAWXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagHHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagUDMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagOPCBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corpusBindingSource2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage12.ResumeLayout(false);
            this.tabPage12.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage13.ResumeLayout(false);
            this.tabPage13.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage14.ResumeLayout(false);
            this.tabPage14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.menuStrip6.ResumeLayout(false);
            this.menuStrip6.PerformLayout();
            this.tabPage15.ResumeLayout(false);
            this.tabPage15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView13)).EndInit();
            this.menuStrip7.ResumeLayout(false);
            this.menuStrip7.PerformLayout();
            this.tabPage16.ResumeLayout(false);
            this.tabPage16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView14)).EndInit();
            this.menuStrip8.ResumeLayout(false);
            this.menuStrip8.PerformLayout();
            this.tabPage17.ResumeLayout(false);
            this.tabPage17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView15)).EndInit();
            this.menuStrip9.ResumeLayout(false);
            this.menuStrip9.PerformLayout();
            this.tabPage18.ResumeLayout(false);
            this.tabPage18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView16)).EndInit();
            this.menuStrip11.ResumeLayout(false);
            this.menuStrip11.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.menuStrip10.ResumeLayout(false);
            this.menuStrip10.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel_Systema.ResumeLayout(false);
            this.panel_Systema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTags_questiondata)).EndInit();
            this.panel_PLC.ResumeLayout(false);
            this.panel_PLC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLCBindingSource1)).EndInit();
            this.panel_gruppa.ResumeLayout(false);
            this.panel_gruppa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gruppaBindingSource1)).EndInit();
            this.panel_tag.ResumeLayout(false);
            this.panel_tag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource1)).EndInit();
            this.panel_corpus.ResumeLayout(false);
            this.panel_corpus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corpusBindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource rPTagsDataSetBindingSource;
        private RPTagsDataSet rPTagsDataSet;
        private System.Windows.Forms.BindingSource corpusBindingSource;
        private RPTagsDataSetTableAdapters.CorpusTableAdapter corpusTableAdapter;
        private System.Windows.Forms.BindingSource pLCBindingSource;
        private RPTagsDataSetTableAdapters.PLCTableAdapter pLCTableAdapter;
        private System.Windows.Forms.BindingSource systemaBindingSource;
        private RPTagsDataSetTableAdapters.SystemaTableAdapter systemaTableAdapter;
        private System.Windows.Forms.BindingSource systemTypeBindingSource;
        private RPTagsDataSetTableAdapters.SystemTypeTableAdapter systemTypeTableAdapter;
        private System.Windows.Forms.BindingSource gruppaBindingSource;
        private RPTagsDataSetTableAdapters.GruppaTableAdapter gruppaTableAdapter;
        private System.Windows.Forms.BindingSource gruptypeBindingSource;
        private RPTagsDataSetTableAdapters.GruptypeTableAdapter gruptypeTableAdapter;
        private System.Windows.Forms.BindingSource tagBindingSource;
        private RPTagsDataSetTableAdapters.TagTableAdapter tagTableAdapter;
        private System.Windows.Forms.BindingSource tagTypeBindingSource;
        private RPTagsDataSetTableAdapters.TagTypeTableAdapter tagTypeTableAdapter;
        private System.Windows.Forms.BindingSource filtresBindingSource;
        private RPTagsDataSetTableAdapters.FiltresTableAdapter filtresTableAdapter;
        private System.Windows.Forms.BindingSource oPCBindingSource;
        private RPTagsDataSetTableAdapters.OPCTableAdapter oPCTableAdapter;
        private System.Windows.Forms.BindingSource deviceTagBindingSource;
        private RPTagsDataSetTableAdapters.Device_TagTableAdapter device_TagTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.BindingSource areaAWXBindingSource;
        private RPTagsDataSetTableAdapters.AreaAWXTableAdapter areaAWXTableAdapter;
        private System.Windows.Forms.BindingSource tagAWXBindingSource;
        private RPTagsDataSetTableAdapters.TagAWXTableAdapter tagAWXTableAdapter;
        private System.Windows.Forms.BindingSource tagHHBindingSource;
        private RPTagsDataSetTableAdapters.TagHHTableAdapter tagHHTableAdapter;
        private System.Windows.Forms.BindingSource tagUDMBindingSource;
        private RPTagsDataSetTableAdapters.TagUDMTableAdapter tagUDMTableAdapter;
        private System.Windows.Forms.BindingSource tagOPCBindingSource;
        private RPTagsDataSetTableAdapters.TagOPCTableAdapter tagOPCTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn sysidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn gridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tagidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sys_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gr_id;
        private System.Windows.Forms.BindingSource sAIDNullBindingSource;
        private RPTagsDataSetTableAdapters.SAIDNullTableAdapter sAIDNullTableAdapter;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.BindingSource tagIdTagTypeIDBindingSource;
        private RPTagsDataSetTableAdapters.TagIdTagTypeIDTableAdapter tagIdTagTypeIDTableAdapter;
        private System.Windows.Forms.BindingSource corpusBindingSource2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker6;
        private System.ComponentModel.BackgroundWorker backgroundWorker7;
        private System.ComponentModel.BackgroundWorker backgroundWorker8;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem административныеПараметрыToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AreaAWXdgvGen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridView11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.DataGridView dataGridView12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.MenuStrip menuStrip6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.TabPage tabPage15;
        private System.Windows.Forms.DataGridView dataGridView13;
        private System.Windows.Forms.MenuStrip menuStrip7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.TabPage tabPage16;
        private System.Windows.Forms.DataGridView dataGridView17;
        private System.Windows.Forms.DataGridView dataGridView14;
        private System.Windows.Forms.MenuStrip menuStrip8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.TabPage tabPage17;
        private System.Windows.Forms.DataGridView dataGridView15;
        private System.Windows.Forms.MenuStrip menuStrip9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem24;
        private System.Windows.Forms.TabPage tabPage18;
        private System.Windows.Forms.DataGridView dataGridView16;
        private System.Windows.Forms.MenuStrip menuStrip11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem25;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem28;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.MenuStrip menuStrip10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem26;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem27;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаОшибокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исключитьТегиБезАдресаToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel_corpus;
        private RPTags_questiondata rPTags_questiondata;
        private System.Windows.Forms.BindingSource corpusBindingSource1;
        private RPTags_questiondataTableAdapters.CorpusTableAdapter corpusTableAdapter1;
        private RPTags_questiondataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel panel_PLC;
        private System.Windows.Forms.BindingSource pLCBindingSource1;
        private RPTags_questiondataTableAdapters.PLCTableAdapter pLCTableAdapter1;
        private System.Windows.Forms.TextBox iPAddrTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.Panel panel_Systema;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.BindingSource systemaBindingSource1;
        private RPTags_questiondataTableAdapters.SystemaTableAdapter systemaTableAdapter1;
        private System.Windows.Forms.TextBox descriptionTextBox2;
        private System.Windows.Forms.TextBox rNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox2;
        private System.Windows.Forms.Panel panel_gruppa;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel_tag;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.BindingSource gruppaBindingSource1;
        private RPTags_questiondataTableAdapters.GruppaTableAdapter gruppaTableAdapter1;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox3;
        private System.Windows.Forms.TextBox rNameTextBox1;
        private System.Windows.Forms.TextBox nameTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.TextBox relatedValue5TextBox;
        private System.Windows.Forms.TextBox tLA_MSGTextBox;
        private System.Windows.Forms.TextBox relatedValue4TextBox;
        private System.Windows.Forms.TextBox relatedValue3TextBox;
        private System.Windows.Forms.TextBox relatedValue2TextBox;
        private System.Windows.Forms.TextBox relatedValue1TextBox;
        private System.Windows.Forms.TextBox normalMSGTextBox;
        private System.Windows.Forms.TextBox alarmMSGTextBox;
        private System.Windows.Forms.TextBox baseTextTextBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.BindingSource tagBindingSource1;
        private RPTags_questiondataTableAdapters.TagTableAdapter tagTableAdapter1;
        private System.Windows.Forms.ComboBox pLCComboBox;
        private System.Windows.Forms.ComboBox systemtypeComboBox;
        private System.Windows.Forms.ComboBox nodeComboBox;
        private System.Windows.Forms.ComboBox corpusComboBox;
        private System.Windows.Forms.ComboBox systemaComboBox;
        private System.Windows.Forms.ComboBox grupTypeComboBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn sysidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn gridDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tag_id1;
        private System.Windows.Forms.DataGridViewComboBoxColumn tagidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdrPLC;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cutDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tag_id2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDelete;
        private System.Windows.Forms.Button buttonTagCancel;
        private System.Windows.Forms.Button buttonTagSave;
        private System.Windows.Forms.Button buttonCorpCancel;
        private System.Windows.Forms.Button buttonCorpSave;
        private System.Windows.Forms.Button buttonSystemaCancel;
        private System.Windows.Forms.Button buttonSystemaSave;
        private System.Windows.Forms.Button buttonPLCCalcel;
        private System.Windows.Forms.Button buttonPLCSave;
        private System.Windows.Forms.Button buttonGruppaCancel;
        private System.Windows.Forms.Button buttonGruppaSave;
        private System.Windows.Forms.CheckBox checkBoxSystemaEnabled;
        private System.Windows.Forms.CheckBox checkBoxGrupEnabled;
    }
}