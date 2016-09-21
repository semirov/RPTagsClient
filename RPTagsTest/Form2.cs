using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RPTagsTest
{

    public partial class Form2 : Form
    {
        int tabIndexCurr = 0;

        #region переменные формы
        // указатели необходимости обновления датагрида - когда идем по вкладкам назад перегружать не нужно
        bool Need_reload_PLC = true;
        bool Need_reload_Systema = true;
        bool Need_reload_Gruppa = true;
        bool Need_reload_Tag = true;
        // обработка выбора системы
        bool CheckGruppa = false;
        bool CheckTag = false;
        int TAG_ID;

        DataTable temp_Modifed_KorpusDataTable = new DataTable("temp_Modifed_KorpusDataTable");
        DataTable temp_Modifed_PLCDataTable = new DataTable("temp_Modifed_PLCDataTable");
        DataTable temp_Modifed_SystemaDataTable = new DataTable("temp_Modifed_SystemaDataTable");
        DataTable temp_Modifed_GruppaDataTable = new DataTable("temp_Modifed_GruppaDataTable");
        DataTable temp_Modifed_FilterDataTable = new DataTable("temp_Modifed_FilterDataTable");
        DataTable temp_Modifed_OPCDataTable = new DataTable("temp_Modifed_FilterDataTable");
        DataTable temp_Modifed_SystemTypeDataTable = new DataTable("temp_Modifed_SystemTypeDataTable");
        DataTable temp_Modifed_GrupTypeDataTable = new DataTable("temp_Modifed_GrupTypeDataTable");
        DataTable temp_Modifed_TagTypeDataTable = new DataTable("temp_Modifed_TagTypeDataTable");
        DataTable temp_Modifed_DeviceTagDataTable = new DataTable("temp_Modifed_DeviceTagDataTable");

        bool changed_Modifed_KorpusDataTable;
        bool changed_Modifed_PLCDataTable;
        bool changed_Modifed_SystemaDataTable;
        bool changed_Modifed_GruppaDataTable;
        bool changed_Modifed_FilterDataTable;
        bool changed_Modifed_OPCDataTable;
        bool changed_Modifed_SystemTypeDataTable;
        bool changed_Modifed_GrupTypeDataTable;
        bool changed_Modifed_TagTypeDataTable;
        bool changed_Modifed_DeviceTagDataTable;

        bool devicetaganalizebegin = false;

        string Name_Corpus, Name_PLC, Name_Systema, Name_Gryppa, Name_TagType, Name_Tag = "";

        #endregion переменные формы

        public Form2()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        #region основные таблицы

        //-----------------------------------------------------------------------------
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.TagUDM". При необходимости она может быть перемещена или удалена.
            //  this.tagUDMTableAdapter.Fill(this.rPTagsDataSet.TagUDM);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.TagHH". При необходимости она может быть перемещена или удалена.
            //   this.tagHHTableAdapter.Fill(this.rPTagsDataSet.TagHH);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.TagAWX". При необходимости она может быть перемещена или удалена.
            //  this.tagAWXTableAdapter.Fill(this.rPTagsDataSet.TagAWX);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.Device_Tag". При необходимости она может быть перемещена или удалена.
            this.device_TagTableAdapter.Fill(this.rPTagsDataSet.Device_Tag);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.Corpus". При необходимости она может быть перемещена или удалена.
            this.corpusTableAdapter.Fill(this.rPTagsDataSet.Corpus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.OPC". При необходимости она может быть перемещена или удалена.
            this.oPCTableAdapter.Fill(this.rPTagsDataSet.OPC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.Filtres". При необходимости она может быть перемещена или удалена.
            this.filtresTableAdapter.Fill(this.rPTagsDataSet.Filtres);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.TagType". При необходимости она может быть перемещена или удалена.
            this.tagTypeTableAdapter.Fill(this.rPTagsDataSet.TagType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.Tag". При необходимости она может быть перемещена или удалена.
            this.tagTableAdapter.Fill(this.rPTagsDataSet.Tag);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.Gruptype". При необходимости она может быть перемещена или удалена.
            this.gruptypeTableAdapter.Fill(this.rPTagsDataSet.Gruptype);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.Gruppa". При необходимости она может быть перемещена или удалена.
            this.gruppaTableAdapter.Fill(this.rPTagsDataSet.Gruppa);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.SystemType". При необходимости она может быть перемещена или удалена.
            this.systemTypeTableAdapter.Fill(this.rPTagsDataSet.SystemType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.PLC". При необходимости она может быть перемещена или удалена.
            this.systemaTableAdapter.Fill(this.rPTagsDataSet.Systema);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.PLC". При необходимости она может быть перемещена или удалена.
            this.pLCTableAdapter.Fill(this.rPTagsDataSet.PLC);
            this.tagTableAdapter.Fill(this.rpTagsDataSet1.Tag);



            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView4.AllowUserToAddRows = false;
            dataGridView5.AllowUserToAddRows = false;
            dataGridView6.AllowUserToAddRows = false;
            dataGridView7.AllowUserToAddRows = false;
            dataGridView8.AllowUserToAddRows = false;
            dataGridView9.AllowUserToAddRows = false;
            dataGridView10.AllowUserToAddRows = false;
            dataGridView11.AllowUserToAddRows = false;
            dataGridView12.AllowUserToAddRows = false;
            dataGridView13.AllowUserToAddRows = false;
            dataGridView14.AllowUserToAddRows = false;
            dataGridView15.AllowUserToAddRows = false;
            dataGridView16.AllowUserToAddRows = false;

            TagChange newForm = new TagChange();
            newForm.Owner = this;

            toolStripStatusLabel3.Text = tagTableAdapter.Connection.DataSource.ToString() +" ("+ tagTableAdapter.Connection.Database.ToString() + ")";

            prename = DateTime.Today.ToString(); //нужно для имени файла конфигурации
        }
        
        
        private void toolStripStatusLabel3_Click(object sender, EventArgs e) // настройка параметров подключения
        {
            // Application.Restart();
            SQLConnection form = new SQLConnection();
            form.Show();
        }

        public int Send_tag_id()
        {
            return TAG_ID;
        } // передаем id тега на форму тега
        public string tag_path()
        {
            return "ПЛК: " + Name_PLC + " Путь: " + Name_Corpus + "\\" + Name_Systema + "\\" + Name_Gryppa + "\\" + Name_TagType + "\\" + Name_Tag + "";
        } // формируем путь тега
        public string new_tag_path()
        {
            return "ПЛК: " + Name_PLC + " Путь: " + Name_Corpus + "\\" + Name_Systema + "\\" + Name_Gryppa + "\\_*NEW_TAG";
        } // путь тега для создания
        private void tag_path_changer()
        {
            toolStripStatusLabel1.Text = "ПЛК: " + Name_PLC + " Путь: " + Name_Corpus + "\\" + Name_Systema + "\\" + Name_Gryppa + "\\" + Name_TagType + "\\" + Name_Tag + "";
        } // путь тега для главной формы
        public void DGW_reloader()
        {
            try
            {
                tabIndexCurr = tabControl1.TabIndex;

                //----------------------------------------------------------------------------
                if (Need_reload_PLC) // поднят флаг
                {
                    if (dataGridView1.CurrentRow != null)
                    {
                        int index = Convert.ToInt16(dataGridView1.CurrentRow.Index);
                        int id = Convert.ToInt16(rPTagsDataSet.Corpus[index]["id"]);
                        Name_Corpus = Convert.ToString(rPTagsDataSet.Corpus[index]["Name"]);
                        this.pLCTableAdapter.FillByKorpus(this.rPTagsDataSet.PLC, id);
                    }
                    else
                    {
                        this.rPTagsDataSet.PLC.Clear();
                    }


                }
                if (Need_reload_Systema)
                {
                    if (dataGridView2.CurrentRow != null)
                    {
                        int index = Convert.ToInt16(dataGridView2.CurrentRow.Index);
                        Name_PLC = Convert.ToString(rPTagsDataSet.PLC[index]["Name"]);
                        int id = Convert.ToInt16(rPTagsDataSet.PLC[index]["id"]);
                        this.systemaTableAdapter.FillByPLC(this.rPTagsDataSet.Systema, id);
                    }
                    else
                    {
                        this.rPTagsDataSet.Systema.Clear();
                    }
                }

                if (Need_reload_Gruppa)
                {
                    if (dataGridView3.CurrentRow != null)
                    {

                        int index = Convert.ToInt16(dataGridView3.CurrentRow.Index);
                        int id = Convert.ToInt16(rPTagsDataSet.Systema[index]["id"]);
                        Name_Systema = Convert.ToString(rPTagsDataSet.Systema[index]["Name"]);
                        this.gruppaTableAdapter.FillBySystema(this.rPTagsDataSet.Gruppa, id);
                    }
                    else
                    {
                        this.rPTagsDataSet.Gruppa.Clear();

                    }

                }
                if (Need_reload_Tag)
                {
                    if (dataGridView4.CurrentRow != null)
                    {
                        int index = Convert.ToInt16(dataGridView4.CurrentRow.Index);
                        int id = Convert.ToInt16(rPTagsDataSet.Gruppa[index]["GrupType"]);
                        Name_Gryppa = Convert.ToString(rPTagsDataSet.Gruppa[index]["Name"]);
                        this.tagTableAdapter.FillByGrupType(this.rPTagsDataSet.Tag, id);
                        Name_Tag = Convert.ToString(rPTagsDataSet.Tag[0]["Name"]);
                        Name_TagType = Convert.ToString(rPTagsDataSet.Tag[0]["TType"]);
                    }
                    else
                    {
                        this.rPTagsDataSet.Tag.Clear();
                    }
                }

                // построим путь в строке состояния
                tag_path_changer();



            }

            catch (System.Exception ex)
            {
                toolStripStatusLabel2.Text = ex.Message.ToString();
            }
        } // метод обновления гридов
        private void tabControl1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }
        //-----------------------------------------------------------------------------

        //----------------Корпус---------------------------------------------------------------------------------------------------
        private void tabPage1_Enter(object sender, EventArgs e) // Корпус
        {
            try
            {
                // флаги необходимости перезагрузки гридин
                Need_reload_PLC = true;
                Need_reload_Systema = true;
                Need_reload_Gruppa = true;
                Need_reload_Tag = true;
                // перезальем гриды
                DGW_reloader();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void tabPage1_Leave(object sender, EventArgs e)
        {
            Corpus_changed();
            if(dataGridView1.AllowUserToAddRows)
            dataGridView1.AllowUserToAddRows = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Corpus_changed();
            if (dataGridView1.AllowUserToAddRows == false)
            {
                DGW_reloader();
            }

        } // обработка изменений
        private void Corpus_changed()
        {
            if (rPTagsDataSet.Corpus.GetChanges(DataRowState.Modified) != null)
            {

                temp_Modifed_KorpusDataTable.Merge(rPTagsDataSet.Corpus.GetChanges(DataRowState.Modified), true);
                tabPage1.Text = "*Корпус";
                changed_Modifed_KorpusDataTable = true;
            }
            if (rPTagsDataSet.Corpus.GetChanges(DataRowState.Added) != null)
            {
                temp_Modifed_KorpusDataTable.Merge(rPTagsDataSet.Corpus.GetChanges(DataRowState.Added), true);
                tabPage1.Text = "*Корпус";
                changed_Modifed_KorpusDataTable = true;
            }
            if (rPTagsDataSet.Corpus.GetChanges(DataRowState.Deleted) != null)
            {
                temp_Modifed_KorpusDataTable.Merge(rPTagsDataSet.Corpus.GetChanges(DataRowState.Deleted), true);
                tabPage1.Text = "*Корпус";
                changed_Modifed_KorpusDataTable = true;
            }


        } // ловим изменения
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e) // добавить
        {
            try
            {
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.CurrentCell = dataGridView1[0, dataGridView1.RowCount - 1];
            }
            catch (System.Exception ex)
            {

            }
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt16(dataGridView1.CurrentRow.Index);
                dataGridView1.Rows.RemoveAt(index);
            }
            catch
            {

            }
        } // удалить
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)// сохранить
        {
            if (changed_Modifed_KorpusDataTable)
            {
                rPTagsDataSet.Corpus.Merge(temp_Modifed_KorpusDataTable);
                corpusTableAdapter.Update(rPTagsDataSet.Corpus);
                tabPage1.Text = "Корпус";
                temp_Modifed_KorpusDataTable.Clear();
                dataGridView1.AllowUserToAddRows = false;

            }

        }

        //----------------ПЛК---------------------------------------------------------------------------------------------------
        private void tabPage2_Enter(object sender, EventArgs e) // ПЛК
        {
            try
            {
                // сбросим флаг необходимости перезагрузки датагрида
                Need_reload_PLC = false;
                // флаги необходимости перезагрузки датагрида
                Need_reload_Systema = true;
                Need_reload_Gruppa = true;
                Need_reload_Tag = true;
                // перезальем гриды
                DGW_reloader();
            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void tabPage2_Leave(object sender, EventArgs e)
        {
            PLC_changed();
            if(dataGridView2.AllowUserToAddRows)
                dataGridView2.AllowUserToAddRows = false;
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PLC_changed();
            if (dataGridView2.AllowUserToAddRows == false)
            {
                DGW_reloader();
            }

        }
        private void PLC_changed()
        {
            if (rPTagsDataSet.PLC.GetChanges(DataRowState.Modified) != null)
            {

                temp_Modifed_PLCDataTable.Merge(rPTagsDataSet.PLC.GetChanges(DataRowState.Modified));
                tabPage2.Text = "*ПЛК";
                changed_Modifed_PLCDataTable = true;
            }
            if (rPTagsDataSet.PLC.GetChanges(DataRowState.Added) != null)
            {
                temp_Modifed_PLCDataTable.Merge(rPTagsDataSet.PLC.GetChanges(DataRowState.Added));
                tabPage2.Text = "*ПЛК";
                changed_Modifed_PLCDataTable = true;
            }
            if (rPTagsDataSet.PLC.GetChanges(DataRowState.Deleted) != null)
            {
                temp_Modifed_PLCDataTable.Merge(rPTagsDataSet.PLC.GetChanges(DataRowState.Deleted));
                tabPage2.Text = "*ПЛК";
                changed_Modifed_PLCDataTable = true;
            }


        } // ловим изменения
        private void toolStripMenuItem1_Click(object sender, EventArgs e)// добавить
        {
            try
            {
                dataGridView2.AllowUserToAddRows = true;
                dataGridView2.CurrentCell = dataGridView2[0, dataGridView2.RowCount - 1];
            }
            catch (System.Exception ex)
            {

            }
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)// удалить
        {
            try
            {
                int index = Convert.ToInt16(dataGridView2.CurrentRow.Index);
                dataGridView2.Rows.RemoveAt(index);
            }
            catch
            {

            }
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)// сохранить
        {
            if (changed_Modifed_PLCDataTable)
            {
                rPTagsDataSet.PLC.Merge(temp_Modifed_PLCDataTable);
                pLCTableAdapter.Update(rPTagsDataSet.PLC);
                tabPage2.Text = "ПЛК";
                temp_Modifed_PLCDataTable.Clear();
                dataGridView2.AllowUserToAddRows = false;
            }
        }

        //----------------Система---------------------------------------------------------------------------------------------------
        private void tabPage3_Enter(object sender, EventArgs e) // СИСТЕМА
        {
            try
            {
                // сбросиим флаг необходимости перезагрузки датагрида
                Need_reload_Systema = false;
                // флаги необходимости перезагрузки датагрида
                Need_reload_Gruppa = true;
                Need_reload_Tag = true;
                // перезальем гриды
                DGW_reloader();
                // метка выбора для устройсва
                CheckGruppa = false;
                CheckTag = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView3_Leave(object sender, EventArgs e)
        {
            Systema_changed();
            if(dataGridView3.AllowUserToAddRows)
            dataGridView3.AllowUserToAddRows = false;
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Systema_changed();
            if (dataGridView3.AllowUserToAddRows == false)
            {
                DGW_reloader();
            }
        }
        private void Systema_changed()
        {
            if (rPTagsDataSet.Systema.GetChanges(DataRowState.Modified) != null)
            {

                temp_Modifed_SystemaDataTable.Merge(rPTagsDataSet.Systema.GetChanges(DataRowState.Modified));
                tabPage3.Text = "*Система";
                changed_Modifed_SystemaDataTable = true;
            }
            if (rPTagsDataSet.Systema.GetChanges(DataRowState.Added) != null)
            {
                temp_Modifed_SystemaDataTable.Merge(rPTagsDataSet.Systema.GetChanges(DataRowState.Added));
                tabPage3.Text = "*Система";
                changed_Modifed_SystemaDataTable = true;
            }
            if (rPTagsDataSet.Systema.GetChanges(DataRowState.Deleted) != null)
            {
                temp_Modifed_SystemaDataTable.Merge(rPTagsDataSet.Systema.GetChanges(DataRowState.Deleted));
                tabPage3.Text = "*Система";
                changed_Modifed_SystemaDataTable = true;
            }


        } // ловим изменения
        private void toolStripMenuItem4_Click(object sender, EventArgs e) // добавить
        {
            try
            {
                dataGridView3.AllowUserToAddRows = true;
                dataGridView3.CurrentCell = dataGridView3[0, dataGridView3.RowCount - 1];
            }
            catch (System.Exception ex)
            {

            }
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)// удалить
        {
            try
            {
                int index = Convert.ToInt16(dataGridView3.CurrentRow.Index);
                dataGridView3.Rows.RemoveAt(index);
            }
            catch
            {

            }
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)// сохранить
        {
            if (changed_Modifed_SystemaDataTable)
            {
                rPTagsDataSet.Systema.Merge(temp_Modifed_SystemaDataTable);
                systemaTableAdapter.Update(rPTagsDataSet.Systema);
                tabPage3.Text = "Система";
                temp_Modifed_SystemaDataTable.Clear();
                dataGridView3.AllowUserToAddRows = false;
            }
        }

        //----------------Группа---------------------------------------------------------------------------------------------------
        private void tabPage4_Enter(object sender, EventArgs e) // ГРУППА
        {
            try
            {
                //сбросим флаг
                Need_reload_Gruppa = false;
                //установим флаг
                Need_reload_Tag = true;

                //флаги выбора вкладки для устройства
                CheckGruppa = true;
                CheckTag = false;
                // перезальем гриды
                DGW_reloader();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void tabPage4_Leave(object sender, EventArgs e)
        {
            Gruppa_changed();
            if(dataGridView4.AllowUserToAddRows)
                dataGridView4.AllowUserToAddRows = false;
        }
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.AllowUserToAddRows == false)
            {
                DGW_reloader();
            }
            Gruppa_changed();

        }
        private void Gruppa_changed()
        {
            if (rPTagsDataSet.Gruppa.GetChanges(DataRowState.Modified) != null)
            {

                temp_Modifed_GruppaDataTable.Merge(rPTagsDataSet.Gruppa.GetChanges(DataRowState.Modified));
                tabPage4.Text = "*Группа";
                changed_Modifed_GruppaDataTable = true;
            }
            if (rPTagsDataSet.Gruppa.GetChanges(DataRowState.Added) != null)
            {
                temp_Modifed_GruppaDataTable.Merge(rPTagsDataSet.Gruppa.GetChanges(DataRowState.Added));
                tabPage4.Text = "*Группа";
                changed_Modifed_GruppaDataTable = true;
            }
            if (rPTagsDataSet.Gruppa.GetChanges(DataRowState.Deleted) != null)
            {
                temp_Modifed_GruppaDataTable.Merge(rPTagsDataSet.Gruppa.GetChanges(DataRowState.Deleted));
                tabPage4.Text = "*Группа";
                changed_Modifed_GruppaDataTable = true;
            }


        } // ловим изменения
        private void toolStripMenuItem7_Click(object sender, EventArgs e)//добавить
        {
            try
            {
                dataGridView4.AllowUserToAddRows = true;
                dataGridView4.CurrentCell = dataGridView4[0, dataGridView4.RowCount - 1];
            }
            catch (System.Exception ex)
            {

            }
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)// удалить
        {
            try
            {
                int index = Convert.ToInt16(dataGridView4.CurrentRow.Index);
                dataGridView4.Rows.RemoveAt(index);
            }
            catch
            {

            }
        }
        private void toolStripMenuItem9_Click(object sender, EventArgs e)// сохранить
        {
            if (changed_Modifed_GruppaDataTable)
            {
                rPTagsDataSet.Gruppa.Merge(temp_Modifed_GruppaDataTable);
                gruppaTableAdapter.Update(rPTagsDataSet.Gruppa);
                tabPage4.Text = "Группа";
                temp_Modifed_GruppaDataTable.Clear();
                dataGridView4.AllowUserToAddRows = false;
            }
        }

        //----------------Тег---------------------------------------------------------------------------------------------------
        private void tabPage6_Enter(object sender, EventArgs e) // ТЕГ
        {
            try
            {
                DGW_reloader();
                // сбросим флаг
                Need_reload_Tag = false;

                //флаги выбора вкладки для устройства
                CheckTag = true;
                // перезальем гриды



            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = Convert.ToInt16(dataGridView6.CurrentRow.Index);
            Name_Tag = Convert.ToString(rPTagsDataSet.Tag[index]["Name"]);
            Name_TagType = Convert.ToString(rPTagsDataSet.Tag[index]["TType"]);
            DGW_reloader();
            tag_path_changer();
        }
        private void tabPage6_Leave(object sender, EventArgs e)
        {

        }
        public void изменитьToolStripMenuItem_Click(object sender, EventArgs e) //изменить
        {



            if (dataGridView6.CurrentRow != null)
            {
                int index = Convert.ToInt16(dataGridView6.CurrentRow.Index);
                TAG_ID = Convert.ToInt16(rPTagsDataSet.Tag[index]["id"]);
            }

            TagChange newForm = new TagChange();
            newForm.Owner = this;
            newForm.Show();


        }
        private void tabPage6_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem10_Click(object sender, EventArgs e) //добавить
        {
            try
            {
                // dataGridView6.AllowUserToAddRows = true;
                TAG_ID = 0;
                TagChange newForm = new TagChange();
                newForm.Owner = this;
                newForm.Show();
            }
            catch (System.Exception ex)
            {

            }
        }
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt16(dataGridView6.CurrentRow.Index);
                dataGridView6.Rows.RemoveAt(index);
                tagTableAdapter.Update(rPTagsDataSet.Tag);
            }
            catch
            {

            }
        } // удалить


        //----------------Девайс---------------------------------------------------------------------------------------------------
        private void DefectDevice_tag()
        {
            try
            {
                int failrows = 0;
                int maximum = 0;
                rPTagsDataSet.SAIDNull.Clear();
                maximum = rPTagsDataSet.Device_Tag.Count;
                foreach (DataRow row in rPTagsDataSet.Device_Tag)
                {
                    int sys_id = Convert.ToInt16(row["Sys_id"]);
                    int gr_id = Convert.ToInt16(row["Gr_id"]);
                    int tag_id = Convert.ToInt16(row["Tag_id"]);
                    sAIDNullTableAdapter.FillBySysGrTagDefect(rPTagsDataSet.SAIDNull, gr_id, sys_id, tag_id);
                    if (rPTagsDataSet.SAIDNull.Rows.Count == 0)
                    {
                        failrows++;
                        row.Delete();
                        
                    }

                }
                // проведем анализ в потоке
                devicetaganalizebegin = false;
                DeviceTag_changed();

                if (failrows != 0)
                {
                    //toolStripStatusLabel2.Text = failrows.ToString();
                    MessageBox.Show("Из таблицы исключено: \n " + failrows + " ошибочных SAID", "Проверка путей", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Ошибочные строки отсутствуют", "Проверка путей", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Data.DeletedRowInaccessibleException)
            {
                toolStripStatusLabel2.Text = "Кто - то накосячил с DataSet";
            }
        }
    
        private void проверитьОшибкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!devicetaganalizebegin)
            {
            devicetaganalizebegin = true;
            // проведем анализ в потоке
            Thread thread = new Thread(DefectDevice_tag);
            //Запускаем поток
            thread.Start();
            }

        }
        private void tabPage7_Enter(object sender, EventArgs e) // устройство
        {
            try
            {

                if (CheckGruppa && CheckTag) // если выбрана система, группа, тег - покажем только по тегу
                {
                    // выбранная система
                    if (dataGridView3.CurrentRow != null || dataGridView4.CurrentRow != null || dataGridView6.CurrentRow != null)
                    {
                        int Systema_index = Convert.ToInt16(dataGridView3.CurrentRow.Index);
                        int Systema_id = Convert.ToInt16(rPTagsDataSet.Systema[Systema_index]["id"]);
                        // выбранная группа
                        int Gruppa_index = Convert.ToInt16(dataGridView4.CurrentRow.Index);
                        int Gruppa_id = Convert.ToInt16(rPTagsDataSet.Gruppa[Gruppa_index]["id"]);
                        // выбранный тег
                        int Tag_index = Convert.ToInt16(dataGridView6.CurrentRow.Index);
                        int Tag_id = Convert.ToInt16(rPTagsDataSet.Tag[Tag_index]["id"]);
                        // получим выборку по трем переменным
                        this.device_TagTableAdapter.FillByTagSysGr(this.rPTagsDataSet.Device_Tag, Systema_id, Gruppa_id, Tag_id);

                        // запросим наличие тегов без SAID
                        rPTagsDataSet.SAIDNull.Clear();
                        this.sAIDNullTableAdapter.FillBySysGrTag(this.rPTagsDataSet.SAIDNull, Gruppa_id, Systema_id,  Tag_id);
                        if (rPTagsDataSet.SAIDNull.Rows.Count != 0) // если есть хоть одна строка, предложим их добавить
                        {
                            // toolStripStatusLabel2.Text = "У нас там есть что добавить";
                            if (MessageBox.Show("Для Тега: \"" + Name_Corpus + "\\" + Name_Systema + "\\" + Name_Gryppa + "\\" + Name_TagType + "\\" + Name_Tag + "\"\nОтсутствует SAID!\n Добавить его?", "SAID", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {

                                foreach (DataRow row in rPTagsDataSet.SAIDNull)
                                {


                                    RPTagsDataSet.Device_TagRow newRow = rPTagsDataSet.Device_Tag.NewDevice_TagRow();
                                    newRow.SAID = Name_Systema;
                                    newRow.Sys_id = Convert.ToInt16(row["Sys_id"]);
                                    newRow.Gr_id = Convert.ToInt16(row["Gr_id"]);
                                    newRow.Tag_id = Convert.ToInt16(row["Tag_id"]);


                                    rPTagsDataSet.Device_Tag.AddDevice_TagRow(newRow);
                                }
                            }
                        }

                    }
                    else
                    {
                        this.rPTagsDataSet.Device_Tag.Clear();
                    }
                }
                else if (CheckGruppa && !CheckTag) // если выбрана система, группа,  - покажем только по группе
                {
                    if (dataGridView3.CurrentRow != null || dataGridView4.CurrentRow != null)
                    {
                        // выбранная группа
                        int Gruppa_index = Convert.ToInt16(dataGridView4.CurrentRow.Index);
                        int Gruppa_id = Convert.ToInt16(rPTagsDataSet.Gruppa[Gruppa_index]["id"]);
                        // выбранная система
                        int Systema_index = Convert.ToInt16(dataGridView3.CurrentRow.Index);
                        int Systema_id = Convert.ToInt16(rPTagsDataSet.Systema[Systema_index]["id"]);
                        //получим выборку по двум переменным
                        this.device_TagTableAdapter.FillBySystemaGryppa(this.rPTagsDataSet.Device_Tag, Systema_id, Gruppa_id);

                        // запросим наличие тегов без SAID
                        rPTagsDataSet.SAIDNull.Clear();
                        this.sAIDNullTableAdapter.FillBySustemGruppa(this.rPTagsDataSet.SAIDNull, Gruppa_id, Systema_id);
                        if (rPTagsDataSet.SAIDNull.Rows.Count != 0) // если есть хоть одна строка, предложим их добавить
                        {
                            // toolStripStatusLabel2.Text = "У нас там есть что добавить";
                            if (MessageBox.Show("Для Группы: \"" + Name_Corpus + "\\" + Name_Systema + "\\" + Name_Gryppa + "\"\nЕсть теги без SAID! Количество: " + rPTagsDataSet.SAIDNull.Rows.Count + "\n Добавить их?", "SAID", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {

                                foreach (DataRow row in rPTagsDataSet.SAIDNull)
                                {


                                    RPTagsDataSet.Device_TagRow newRow = rPTagsDataSet.Device_Tag.NewDevice_TagRow();
                                    newRow.SAID = Name_Systema;
                                    newRow.Sys_id = Convert.ToInt16(row["Sys_id"]);
                                    newRow.Gr_id = Convert.ToInt16(row["Gr_id"]);
                                    newRow.Tag_id = Convert.ToInt16(row["Tag_id"]);


                                    rPTagsDataSet.Device_Tag.AddDevice_TagRow(newRow);
                                }
                            }
                        }


                    }
                    else
                    {
                        this.rPTagsDataSet.Device_Tag.Clear();
                    }
                }
                else if (!CheckGruppa && !CheckTag) // если выбранна только система
                {
                    if (dataGridView3.CurrentRow != null)
                    {

                        // выбранная система
                        int Systema_index = Convert.ToInt16(dataGridView3.CurrentRow.Index);
                        int Systema_id = Convert.ToInt16(rPTagsDataSet.Systema[Systema_index]["id"]);


                        //получим выборку по двум переменным
                        this.device_TagTableAdapter.FillBySystema(this.rPTagsDataSet.Device_Tag, Systema_id);

                        // запросим наличие тегов без SAID
                        rPTagsDataSet.SAIDNull.Clear();
                        this.sAIDNullTableAdapter.FillBySystema(this.rPTagsDataSet.SAIDNull, Systema_id);
                        if (rPTagsDataSet.SAIDNull.Rows.Count != 0) // если есть хоть одна строка, предложим их добавить
                        {
                            // toolStripStatusLabel2.Text = "У нас там есть что добавить";
                            if (MessageBox.Show("Для Системы: \"" + Name_Corpus + "\\" + Name_Systema + "\"\nЕсть теги без SAID! Количество: " + rPTagsDataSet.SAIDNull.Rows.Count + "\n Добавить их?", "SAID", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {

                                foreach (DataRow row in rPTagsDataSet.SAIDNull)
                                {


                                    RPTagsDataSet.Device_TagRow newRow = rPTagsDataSet.Device_Tag.NewDevice_TagRow();
                                    newRow.SAID = Name_Systema;
                                    newRow.Sys_id = Convert.ToInt16(row["Sys_id"]);
                                    newRow.Gr_id = Convert.ToInt16(row["Gr_id"]);
                                    newRow.Tag_id = Convert.ToInt16(row["Tag_id"]);


                                    rPTagsDataSet.Device_Tag.AddDevice_TagRow(newRow);
                                }
                            }
                        }


                    }
                    else
                    {
                        this.rPTagsDataSet.Device_Tag.Clear();
                    }
                }
                // если были изменения укажем что они есть
                DeviceTag_changed();
            }




            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Исключение :-(");

            }
            
        }
        private void DeviceTag_changed()
        {
            if (rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Modified) != null)
            {

                temp_Modifed_DeviceTagDataTable.Merge(rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Modified));
                Invoke(new Action(() =>
                {
                    tabPage7.Text = "*Устройство";
                }));
                changed_Modifed_DeviceTagDataTable = true;
            }
            if (rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Added) != null)
            {
                temp_Modifed_DeviceTagDataTable.Merge(rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Added));
                Invoke(new Action(() =>
                {
                    tabPage7.Text = "*Устройство";
                }));
                changed_Modifed_DeviceTagDataTable = true;
            }
            if (rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Deleted) != null)
            {
                temp_Modifed_DeviceTagDataTable.Merge(rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Deleted));
                Invoke(new Action(() =>
                {
                    tabPage7.Text = "*Устройство";
                }));
                
                changed_Modifed_DeviceTagDataTable = true;
            }


        } // ловим изменения
        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DeviceTag_changed();
        }
        private void tabPage7_Leave(object sender, EventArgs e)
        {
            DeviceTag_changed();
        }
        private void toolStripMenuItem26_Click(object sender, EventArgs e) // удалить
        {
            try
            {
                int index = Convert.ToInt16(dataGridView7.CurrentRow.Index);
                dataGridView7.Rows.RemoveAt(index);
            }
            catch
            {

            }
        }
        private void toolStripMenuItem27_Click(object sender, EventArgs e) // сохранить
        {
            if (changed_Modifed_DeviceTagDataTable)
            {
                device_TagTableAdapter.Update(rPTagsDataSet.Device_Tag);
                tabPage7.Text = "Устройство";
                changed_Modifed_DeviceTagDataTable = false;
                temp_Modifed_DeviceTagDataTable.Clear();
            }
        }

        #endregion основные таблицы


        #region второстепенные таблицы

        //-------------------ФИЛЬТР-----------------------------------------------------------------------------------------------
        private void Filtres_changed()
        {
            if (rPTagsDataSet.Filtres.GetChanges(DataRowState.Modified) != null)
            {

                temp_Modifed_FilterDataTable.Merge(rPTagsDataSet.Filtres.GetChanges(DataRowState.Modified));
                tabPage14.Text = "*Фильтр";
                changed_Modifed_FilterDataTable = true;
            }
            if (rPTagsDataSet.Filtres.GetChanges(DataRowState.Added) != null)
            {
                temp_Modifed_FilterDataTable.Merge(rPTagsDataSet.Filtres.GetChanges(DataRowState.Added));
                tabPage14.Text = "*Фильтр";
                changed_Modifed_FilterDataTable = true;
            }
            if (rPTagsDataSet.Filtres.GetChanges(DataRowState.Deleted) != null)
            {
                temp_Modifed_FilterDataTable.Merge(rPTagsDataSet.Filtres.GetChanges(DataRowState.Deleted));
                tabPage14.Text = "*Фильтр";
                changed_Modifed_FilterDataTable = true;
            }
        }
        private void toolStripMenuItem13_Click(object sender, EventArgs e)// добавить
        {
            try
            {
                dataGridView5.AllowUserToAddRows = true;
                dataGridView5.CurrentCell = dataGridView5[0, dataGridView5.RowCount - 1];
                Filtres_changed();
            }
            catch (System.Exception ex)
            {

            }
        }
        private void toolStripMenuItem14_Click(object sender, EventArgs e)//удалить
        {
            try
            {
                int index = Convert.ToInt16(dataGridView5.CurrentRow.Index);
                dataGridView5.Rows.RemoveAt(index);
                Filtres_changed();
            }
            catch
            {

            }
        }
        private void toolStripMenuItem15_Click(object sender, EventArgs e)//сохранить
        {
            if (changed_Modifed_FilterDataTable)
            {
                rPTagsDataSet.Filtres.Merge(temp_Modifed_FilterDataTable);
                filtresTableAdapter.Update(rPTagsDataSet.Filtres);
                tabPage14.Text = "Фильтр";
                temp_Modifed_FilterDataTable.Clear();
                dataGridView5.AllowUserToAddRows = false;
            }
        }
        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Filtres_changed();
        }

        //--------------Тип системы---------------------------------------------------------------------------------------
        private void SystemType_changed()
        {
            if (rPTagsDataSet.SystemType.GetChanges(DataRowState.Modified) != null)
            {

                temp_Modifed_FilterDataTable.Merge(rPTagsDataSet.SystemType.GetChanges(DataRowState.Modified));
                tabPage15.Text = "*Тип системы";
                changed_Modifed_FilterDataTable = true;
            }
            if (rPTagsDataSet.SystemType.GetChanges(DataRowState.Added) != null)
            {
                temp_Modifed_FilterDataTable.Merge(rPTagsDataSet.SystemType.GetChanges(DataRowState.Added));
                tabPage15.Text = "*Тип системы";
                changed_Modifed_FilterDataTable = true;
            }
            if (rPTagsDataSet.SystemType.GetChanges(DataRowState.Deleted) != null)
            {
                temp_Modifed_FilterDataTable.Merge(rPTagsDataSet.SystemType.GetChanges(DataRowState.Deleted));
                tabPage15.Text = "*Тип системы";
                changed_Modifed_FilterDataTable = true;
            }
        }
        private void toolStripMenuItem16_Click(object sender, EventArgs e)// добавить
        {
            try
            {
                dataGridView13.AllowUserToAddRows = true;
                dataGridView13.CurrentCell = dataGridView13[0, dataGridView13.RowCount - 1];
                SystemType_changed();
            }
            catch (System.Exception ex)
            {

            }
        }
        private void toolStripMenuItem17_Click(object sender, EventArgs e)//удалить
        {
            try
            {
                int index = Convert.ToInt16(dataGridView13.CurrentRow.Index);
                dataGridView13.Rows.RemoveAt(index);
                SystemType_changed();
            }
            catch
            {

            }
        }
        private void toolStripMenuItem18_Click(object sender, EventArgs e)//сохранить
        {
            if (changed_Modifed_FilterDataTable)
            {
                rPTagsDataSet.SystemType.Merge(temp_Modifed_FilterDataTable);
                systemTypeTableAdapter.Update(rPTagsDataSet.SystemType);
                tabPage15.Text = "Тип системы";
                temp_Modifed_FilterDataTable.Clear();
                dataGridView13.AllowUserToAddRows = false;
            }
        }
        private void dataGridView13_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SystemType_changed();
        }


        //--------------Тип группы---------------------------------------------------------------------------------------
        private void GrupType_changed()
        {
            if (rPTagsDataSet.Gruptype.GetChanges(DataRowState.Modified) != null)
            {

                temp_Modifed_FilterDataTable.Merge(rPTagsDataSet.Gruptype.GetChanges(DataRowState.Modified));
                tabPage16.Text = "*Тип группы";
                changed_Modifed_FilterDataTable = true;
            }
            if (rPTagsDataSet.Gruptype.GetChanges(DataRowState.Added) != null)
            {
                temp_Modifed_FilterDataTable.Merge(rPTagsDataSet.Gruptype.GetChanges(DataRowState.Added));
                tabPage16.Text = "*Тип группы";
                changed_Modifed_FilterDataTable = true;
            }
            if (rPTagsDataSet.Gruptype.GetChanges(DataRowState.Deleted) != null)
            {
                temp_Modifed_FilterDataTable.Merge(rPTagsDataSet.Gruptype.GetChanges(DataRowState.Deleted));
                tabPage16.Text = "*Тип группы";
                changed_Modifed_FilterDataTable = true;
            }
        }
        private void toolStripMenuItem19_Click(object sender, EventArgs e)//добавить
        {
            try
            {
                dataGridView14.AllowUserToAddRows = true;
                dataGridView14.CurrentCell = dataGridView14[0, dataGridView14.RowCount - 1];
                GrupType_changed();
            }
            catch (System.Exception ex)
            {

            }
        }
        private void toolStripMenuItem20_Click(object sender, EventArgs e)// удалить
        {
            try
            {
                int index = Convert.ToInt16(dataGridView14.CurrentRow.Index);
                dataGridView14.Rows.RemoveAt(index);
                GrupType_changed();
            }
            catch
            {

            }
        }
        private void toolStripMenuItem21_Click(object sender, EventArgs e)//сохранить
        {
            if (changed_Modifed_FilterDataTable)
            {
                rPTagsDataSet.Gruptype.Merge(temp_Modifed_FilterDataTable);
                gruptypeTableAdapter.Update(rPTagsDataSet.Gruptype);
                tabPage16.Text = "Тип группы";
                temp_Modifed_FilterDataTable.Clear();
                dataGridView14.AllowUserToAddRows = false;
            }
        }
        private void dataGridView14_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GrupType_changed();
        }

        //--------------Тип тега---------------------------------------------------------------------------------------

        private void TagType_changed()
        {
            if (rPTagsDataSet.TagType.GetChanges(DataRowState.Modified) != null)
            {

                temp_Modifed_FilterDataTable.Merge(rPTagsDataSet.TagType.GetChanges(DataRowState.Modified));
                tabPage17.Text = "*Тип тега";
                changed_Modifed_FilterDataTable = true;
            }
            if (rPTagsDataSet.TagType.GetChanges(DataRowState.Added) != null)
            {
                temp_Modifed_FilterDataTable.Merge(rPTagsDataSet.TagType.GetChanges(DataRowState.Added));
                tabPage17.Text = "*Тип тега";
                changed_Modifed_FilterDataTable = true;
            }
            if (rPTagsDataSet.TagType.GetChanges(DataRowState.Deleted) != null)
            {
                temp_Modifed_FilterDataTable.Merge(rPTagsDataSet.TagType.GetChanges(DataRowState.Deleted));
                tabPage17.Text = "*Тип тега";
                changed_Modifed_FilterDataTable = true;
            }
        }
        private void toolStripMenuItem22_Click(object sender, EventArgs e)// добавить
        {
            try
            {
                dataGridView15.AllowUserToAddRows = true;
                dataGridView15.CurrentCell = dataGridView15[0, dataGridView15.RowCount - 1];
                TagType_changed();
            }
            catch (System.Exception ex)
            {

            }
        }
        private void toolStripMenuItem23_Click(object sender, EventArgs e)//удалить
        {
            try
            {
                int index = Convert.ToInt16(dataGridView15.CurrentRow.Index);
                dataGridView15.Rows.RemoveAt(index);
                TagType_changed();
            }
            catch
            {

            }
        }
        private void toolStripMenuItem24_Click(object sender, EventArgs e) // сохранить
        {
            if (changed_Modifed_FilterDataTable)
            {
                rPTagsDataSet.TagType.Merge(temp_Modifed_FilterDataTable);
                tagTypeTableAdapter.Update(rPTagsDataSet.TagType);
                tabPage17.Text = "Тип тега";
                temp_Modifed_FilterDataTable.Clear();
                dataGridView15.AllowUserToAddRows = false;
            }
        }
        private void dataGridView15_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TagType_changed();
            
        }

        





        //--------------OPC---------------------------------------------------------------------------------------
        private void OPC_changed()
        {
            if (rPTagsDataSet.OPC.GetChanges(DataRowState.Modified) != null)
            {

                temp_Modifed_FilterDataTable.Merge(rPTagsDataSet.OPC.GetChanges(DataRowState.Modified));
                tabPage18.Text = "*OPC";
                changed_Modifed_FilterDataTable = true;
            }
            if (rPTagsDataSet.OPC.GetChanges(DataRowState.Added) != null)
            {
                temp_Modifed_FilterDataTable.Merge(rPTagsDataSet.OPC.GetChanges(DataRowState.Added));
                tabPage18.Text = "*OPC";
                changed_Modifed_FilterDataTable = true;
            }
            if (rPTagsDataSet.OPC.GetChanges(DataRowState.Deleted) != null)
            {
                temp_Modifed_FilterDataTable.Merge(rPTagsDataSet.OPC.GetChanges(DataRowState.Deleted));
                tabPage18.Text = "*OPC";
                changed_Modifed_FilterDataTable = true;
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void toolStripMenuItem12_Click(object sender, EventArgs e)// добавить
        {
            try
            {
                dataGridView16.AllowUserToAddRows = true;
                dataGridView16.CurrentCell = dataGridView16[0, dataGridView16.RowCount - 1];
                OPC_changed();
            }
            catch (System.Exception ex)
            {

            }
        }
        private void toolStripMenuItem25_Click(object sender, EventArgs e)//удалить
        {
            try
            {
                int index = Convert.ToInt16(dataGridView16.CurrentRow.Index);
                dataGridView16.Rows.RemoveAt(index);
                OPC_changed();
            }
            catch
            {

            }

        }
        private void toolStripMenuItem28_Click(object sender, EventArgs e)//сохранить
        {
            if (changed_Modifed_FilterDataTable)
            {
                rPTagsDataSet.OPC.Merge(temp_Modifed_FilterDataTable);
                oPCTableAdapter.Update(rPTagsDataSet.OPC);
                tabPage18.Text = "OPC";
                temp_Modifed_FilterDataTable.Clear();
                dataGridView16.AllowUserToAddRows = false;
            }
        }

       

        private void dataGridView16_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OPC_changed();
        }

        #endregion второстепенные таблицы
        //----------------------------------------------------------------------------------------------------

        private void dataGridView6_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            toolStripStatusLabel2.Text = "     Какие то проблемы с датагридом";
           
        } // обработчик ошибок






        //-----------------генератор конфигураций-------------------------------------------------------------------
        #region конфигурации

        string prename;
       
        
        //------------------areaAWX---------------------------------------------
        private void AreaAWXdgvGen_Click(object sender, EventArgs e)
        {

            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
                toolStripStatusLabel1.Text = "Загрузка конфигурации AreaAWX...";
            }

          
            
        }
        // зальемся ассинхронно
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            
            this.areaAWXTableAdapter.Fill(this.rPTagsDataSet.AreaAWX, textBox2.Text);
           


        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // возможно сюда засунем прогресс, если сможем его отыскать
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Загрузка конфигурации AreaAWX завершена!";
            dataGridView8.DataSource = rPTagsDataSet.AreaAWX;

        }


        #endregion конфигурации


        /*   private void fillToolStripButton_Click(object sender, EventArgs e)
           {
               try
               {
                   this.areaAWXTableAdapter.Fill(this.rPTagsDataSet.AreaAWX, confNAMEToolStripTextBox.Text);
               }
               catch (System.Exception ex)
               {
                   System.Windows.Forms.MessageBox.Show(ex.Message);
               }

           }

           private void fillToolStripButton1_Click(object sender, EventArgs e)
           {
               try
               {
                   this.tagAWXTableAdapter.Fill(this.rPTagsDataSet.TagAWX);
               }
               catch (System.Exception ex)
               {
                   System.Windows.Forms.MessageBox.Show(ex.Message);
               }

           }

           private void fillToolStripButton2_Click(object sender, EventArgs e)
           {
               try
               {
                   this.tagHHTableAdapter.Fill(this.rPTagsDataSet.TagHH);
               }
               catch (System.Exception ex)
               {
                   System.Windows.Forms.MessageBox.Show(ex.Message);
               }

           }

           private void fillToolStripButton3_Click(object sender, EventArgs e)
           {
               try
               {
                   this.tagUDMTableAdapter.Fill(this.rPTagsDataSet.TagUDM);
               }
               catch (System.Exception ex)
               {
                   System.Windows.Forms.MessageBox.Show(ex.Message);
               }

           }

           private void fillToolStripButton4_Click(object sender, EventArgs e)
           {
               try
               {
                   this.tagOPCTableAdapter.Fill(this.rPTagsDataSet.TagOPC, pLCToolStripTextBox.Text, on_ofToolStripTextBox.Text, fT1_FT10ToolStripTextBox.Text);
               }
               catch (System.Exception ex)
               {
                   System.Windows.Forms.MessageBox.Show(ex.Message);
               }

           }
           */

    }
}

