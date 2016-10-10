using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPTagsTest
{
    public partial class treetest : Form
    {
        public treetest()
        {
            InitializeComponent();
        }

        private void treetest_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.Tag". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.TagType". При необходимости она может быть перемещена или удалена.

            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.Gruppa". При необходимости она может быть перемещена или удалена.

            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.Gruptype". При необходимости она может быть перемещена или удалена.
            // this.gruptypeTableAdapter.Fill(this.rPTagsDataSet.Gruptype);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.Systema". При необходимости она может быть перемещена или удалена.

            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.Corpus". При необходимости она может быть перемещена или удалена.
            this.corpusTableAdapter.Fill(this.rPTagsDataSet.Corpus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.PLC". При необходимости она может быть перемещена или удалена.
            //this.pLCTableAdapter.Fill(this.rPTagsDataSet.PLC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.PLC". При необходимости она может быть перемещена или удалена.




            
            foreach (RPTagsDataSet.CorpusRow row_corpus in rPTagsDataSet.Corpus)
            {
                
                TreeNode node_corpus = new TreeNode(row_corpus.Name);
                node_corpus.Text = row_corpus.Name;
                node_corpus.Tag = row_corpus.id;
                
                treeView1.Nodes.Add(node_corpus);
            }
        }
        
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
           
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label1.Text = e.Node.Level.ToString();
            
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            fiilnode(e.Node);
        }

        private void fiilnode(TreeNode node)
        {
            int index = node.Index;
            int level = node.Level;
            int id = Convert.ToInt16(node.Tag);
            int parent_id = 0;
            if (level > 0)
                parent_id = Convert.ToInt16(node.Parent.Tag);
            
            
            switch (level) // выделенный объект
            {
                case 0: //выделен корпус
                    node.Nodes.Clear();
                    this.pLCTableAdapter.FillByKorpus(this.rPTagsDataSet.PLC, id);
                    foreach (RPTagsDataSet.PLCRow row_PLC in rPTagsDataSet.PLC)
                    {
                        TreeNode plc_node = new TreeNode(row_PLC.Name);
                        plc_node.Text = row_PLC.Name;
                        plc_node.Tag = row_PLC.id;
                        node.Nodes.Add(plc_node);
                    }
                    break; 

                case 1: //выделен ПЛК
                    node.Nodes.Clear();
                    this.systemaTableAdapter.FillByPLC(this.rPTagsDataSet.Systema, id);
                    foreach (RPTagsDataSet.SystemaRow row_Systema in rPTagsDataSet.Systema)
                    {
                        TreeNode systema_node = new TreeNode(row_Systema.Name);
                        systema_node.Text = row_Systema.Name;
                        systema_node.Tag = row_Systema.id;
                        node.Nodes.Add(systema_node);
                    }
                    break;

                case 2: //выделена система
                    node.Nodes.Clear();
                    this.gruppaTableAdapter.FillBySystema(this.rPTagsDataSet.Gruppa, id);
                    foreach (RPTagsDataSet.GruppaRow row_Gruppa in rPTagsDataSet.Gruppa)
                    {
                        TreeNode gruppa_node = new TreeNode(row_Gruppa.Name);
                        gruppa_node.Text = row_Gruppa.Name;
                        gruppa_node.Tag = row_Gruppa.id;
                        node.Nodes.Add(gruppa_node);
                    }
                    break;

                case 3: //выделена группа
                    node.Nodes.Clear();
                    
                    this.tagTypeTableAdapter.Fill(this.rPTagsDataSet.TagType);
                    foreach (RPTagsDataSet.TagTypeRow row_TagType in rPTagsDataSet.TagType)
                    {
                        TreeNode tagType_node = new TreeNode(row_TagType.Name);
                        tagType_node.Text = row_TagType.Name;
                        tagType_node.Tag = row_TagType.id;
                        node.Nodes.Add(tagType_node);
                    }
                    break;

                case 4: //выделен груптайп
                    node.Nodes.Clear();
                    this.tagTableAdapter.FillByGruppaTagType(this.rPTagsDataSet.Tag, parent_id, id );
                    foreach (RPTagsDataSet.TagRow row_Tag in rPTagsDataSet.Tag)
                    {
                        TreeNode Tag_node = new TreeNode(row_Tag.Name);
                        Tag_node.Text = row_Tag.Name;
                        Tag_node.Tag = row_Tag.id;
                        node.Nodes.Add(Tag_node);
                    }
                    break;

                case 5: //выделен тег
                    
                    break;
                   

            }
        }
    }
}
