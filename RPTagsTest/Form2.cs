using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;


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
        RPTagsDataSet.Device_TagDataTable DeviceTag_temp_DT = new RPTagsDataSet.Device_TagDataTable();

        bool changed_Modifed_KorpusDataTable;
        bool changed_Modifed_PLCDataTable;
        bool changed_Modifed_SystemaDataTable;
        bool changed_Modifed_GruppaDataTable;
        bool changed_Modifed_FilterDataTable;
        bool changed_Modifed_OPCDataTable;
        bool changed_Modifed_SystemTypeDataTable;
        bool changed_Modifed_GrupTypeDataTable;
        bool changed_Modifed_TagTypeDataTable;

        bool devicetaganalizebegin = false;

        string Name_Corpus, Name_PLC, Name_Systema, Name_Gryppa, Name_TagType, Name_Tag = "";

        string Get_corpus = "ALL";

        #endregion переменные формы

        public Form2()
        {
            InitializeComponent();
            
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            backgroundWorker2.WorkerReportsProgress = true;
            backgroundWorker2.WorkerSupportsCancellation = true;

            backgroundWorker3.WorkerReportsProgress = true;
            backgroundWorker3.WorkerSupportsCancellation = true;

            backgroundWorker4.WorkerReportsProgress = true;
            backgroundWorker4.WorkerSupportsCancellation = true;

            backgroundWorker5.WorkerReportsProgress = true;
            backgroundWorker5.WorkerSupportsCancellation = true;

           
            
            
            
            dataGridView7.CellEndEdit += DataGridView7_CellEndEdit;
            dataGridView7.CellLeave += DataGridView7_CellEndEdit;
            //dataGridView7.
            dataGridView7.RowsRemoved += DataGridView7_RowsRemoved;
            dataGridView7.RowsAdded += DataGridView7_RowsAdded;
        }

        #region основные таблицы

        //-----------------------------------------------------------------------------
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.TagIdTagTypeID". При необходимости она может быть перемещена или удалена.
            this.tagIdTagTypeIDTableAdapter.Fill(this.rPTagsDataSet.TagIdTagTypeID);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.TagUDM". При необходимости она может быть перемещена или удалена.
            //  this.tagUDMTableAdapter.Fill(this.rPTagsDataSet.TagUDM);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.TagHH". При необходимости она может быть перемещена или удалена.
            //   this.tagHHTableAdapter.Fill(this.rPTagsDataSet.TagHH);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.TagAWX". При необходимости она может быть перемещена или удалена.
            //  this.tagAWXTableAdapter.Fill(this.rPTagsDataSet.TagAWX);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.Device_Tag". При необходимости она может быть перемещена или удалена.
            //this.tagAWXTableAdapter.Adapter.SelectCommand.CommandTimeout = 300;
           // this.device_TagTableAdapter.Fill(this.rPTagsDataSet.Device_Tag);
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

            prename = DateTime.Today.Day.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString(); //нужно для имени файла конфигурации
                                                                                                                        //toolStripStatusLabel3.Text = prename;
            tooltiptext();



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
            // костыль, но нужно кратковременно перекинуть форкус чтобы применить изменения при сохранении
            // !! обязательно подписака на событие datagridwiev.cellleave методом события cellClick
            DataGridView dtw = dataGridView1;
            if (dtw.Rows.Count > 1)
            {
                int x = dtw.CurrentCell.RowIndex;
                int y = dtw.CurrentCell.ColumnIndex;
                if (x > 0)
                {
                    x--;
                    dtw.CurrentCell = dtw[y, x];
                    x++;
                    dtw.CurrentCell = dtw[y, x];

                }
                else
                {
                    x++;
                    dtw.CurrentCell = dtw[y, x];
                    x--;
                    dtw.CurrentCell = dtw[y, x];
                }
            }
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
            // костыль, но нужно кратковременно перекинуть форкус чтобы применить изменения при сохранении
            // !! обязательно подписака на событие datagridwiev.cellleave методом события cellClick
            DataGridView dtw = dataGridView2;
            if (dtw.Rows.Count > 1)
            {
                int x = dtw.CurrentCell.RowIndex;
                int y = dtw.CurrentCell.ColumnIndex;
                if (x > 0)
                {
                    x--;
                    dtw.CurrentCell = dtw[y, x];
                    x++;
                    dtw.CurrentCell = dtw[y, x];

                }
                else
                {
                    x++;
                    dtw.CurrentCell = dtw[y, x];
                    x--;
                    dtw.CurrentCell = dtw[y, x];
                }
            }
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
            // костыль, но нужно кратковременно перекинуть форкус чтобы применить изменения при сохранении
            // !! обязательно подписака на событие datagridwiev.cellleave методом события cellClick
            DataGridView dtw = dataGridView3;
            if (dtw.Rows.Count > 1)
            {
                int x = dtw.CurrentCell.RowIndex;
                int y = dtw.CurrentCell.ColumnIndex;
                if (x > 0)
                {
                    x--;
                    dtw.CurrentCell = dtw[y, x];
                    x++;
                    dtw.CurrentCell = dtw[y, x];

                }
                else
                {
                    x++;
                    dtw.CurrentCell = dtw[y, x];
                    x--;
                    dtw.CurrentCell = dtw[y, x];
                }
            }
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
            // костыль, но нужно кратковременно перекинуть форкус чтобы применить изменения при сохранении
            // !! обязательно подписака на событие datagridwiev.cellleave методом события cellClick
            DataGridView dtw = dataGridView4;
            if (dtw.Rows.Count > 1)
            {
                int x = dtw.CurrentCell.RowIndex;
                int y = dtw.CurrentCell.ColumnIndex;
                if (x > 0)
                {
                    x--;
                    dtw.CurrentCell = dtw[y, x];
                    x++;
                    dtw.CurrentCell = dtw[y, x];

                }
                else
                {
                    x++;
                    dtw.CurrentCell = dtw[y, x];
                    x--;
                    dtw.CurrentCell = dtw[y, x];
                }
            }
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
            // костыль, но нужно кратковременно перекинуть форкус чтобы применить изменения при сохранении
            // !! обязательно подписака на событие datagridwiev.cellleave методом события cellClick
            DataGridView dtw = dataGridView6;
            int x = dtw.CurrentCell.RowIndex;
            int y = dtw.CurrentCell.ColumnIndex;
            if (x > 0)
            {
                x--;
                dtw.CurrentCell = dtw[y, x];
                x++;
                dtw.CurrentCell = dtw[y, x];

            }
            else
            {
                x++;
                dtw.CurrentCell = dtw[y, x];
                x--;
                dtw.CurrentCell = dtw[y, x];
            }
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

                int sys_id = Convert.ToInt16(rPTagsDataSet.Device_Tag[0]["Sys_id"]);
                sAIDNullTableAdapter.f(rPTagsDataSet.SAIDNull, sys_id);
                DataView dw = new DataView(rPTagsDataSet.SAIDNull);
                int failrows = 0;
                int maximum = 0;
                
               
                maximum = rPTagsDataSet.Device_Tag.Count;
                foreach (DataRow row in rPTagsDataSet.Device_Tag.Select())
                {
                        sys_id = Convert.ToInt16(row["Sys_id"]);
                    int gr_id = Convert.ToInt16(row["Gr_id"]);
                    int tag_id = Convert.ToInt16(row["Tag_id"]);
                    string expression = "Sys_id = " + sys_id + " Gr_id = " + gr_id + " tag_id = " + tag_id;
                    dw.RowFilter = string.Empty;
                    dw.RowFilter = expression;


                    if (dw.Count == 0)
                    {
                        failrows++;
                        row.Delete();
                       
                        
                    }

                }
                // проведем анализ в потоке
                devicetaganalizebegin = false;
                //DeviceTag_changed();

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
       
        private void tabPage7_Enter(object sender, EventArgs e) // устройство
        {
            try
            {

                if (CheckGruppa && CheckTag) // если выбрана система, группа, тег - покажем только по тегу
                {
                    
                    if (dataGridView3.CurrentRow != null || dataGridView4.CurrentRow != null || dataGridView6.CurrentRow != null)
                    {
                        // выбранная система
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
                                   // device_TagTableAdapter.Update(rPTagsDataSet.Device_Tag);
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
                                  //  device_TagTableAdapter.Update(rPTagsDataSet.Device_Tag);
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


                        //получим выборку по системе
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
                                  //  device_TagTableAdapter.Update(rPTagsDataSet.Device_Tag);
                                }
                            }
                        }


                    }
                    else
                    {
                        this.rPTagsDataSet.Device_Tag.Clear();
                    }
                }
                
               
               
            }




            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Исключение :-(");

            }
            
        }
        private void DataGridView7_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Added) != null)
            {
                DeviceTag_temp_DT.Merge(rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Added));
                rPTagsDataSet.Device_Tag.AcceptChanges();
                tabPage7.Text = "+Устройство";
            }
        }
              
        private void DataGridView7_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
           
            if (rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Deleted) != null)
            {
                DeviceTag_temp_DT.Merge(rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Deleted));
                rPTagsDataSet.Device_Tag.AcceptChanges();
                tabPage7.Text = "-Устройство";
            }
        }
        private void DataGridView7_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dtw = dataGridView7;
            int x = dtw.CurrentCell.RowIndex;
            int y = dtw.CurrentCell.ColumnIndex;
            Validate();
            dtw.Update();
            dtw.EndEdit();
            if (rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Modified) != null)
            {
                DeviceTag_temp_DT.Merge(rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Modified));
                rPTagsDataSet.Device_Tag.AcceptChanges();
                tabPage7.Text = "*Устройство";




                dtw.CurrentCell = dtw[y, x];

            }
        }

            
        private void tabPage7_Leave(object sender, EventArgs e)
        {

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
            try
            {
                

                // костыль, но нужно кратковременно перекинуть форкус чтобы применить изменения при сохранении
                // !! обязательно подписака на событие datagridwiev.cellleave методом события cellClick

                DataGridView dtw = dataGridView7;
                
                if (dtw.Rows.Count > 1)
                {
                    int x = dtw.CurrentCell.RowIndex;
                    int y = dtw.CurrentCell.ColumnIndex;
                    if (x > 0)
                    {
                        x--;
                        
                        x++;
                        dtw.CurrentCell = dtw[y, x];

                    }
                    else
                    {
                        
                        
                        dtw.CurrentCell = dtw[y, x];
                    }
                }



                device_TagTableAdapter.Update(DeviceTag_temp_DT);
                tabPage7.Text = "Устройство";
                dtw.DataSource = null;
                dtw.DataSource = rPTagsDataSet.Device_Tag;
            }
            catch (DBConcurrencyException)
            {
                toolStripStatusLabel2.Text = "Что - то пошло не так";
                
            }
        }
        private void проверитьОшибкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPTagsDataSet.TagIdTagTypeID.Clear();
            tagIdTagTypeIDTableAdapter.Fill(rPTagsDataSet.TagIdTagTypeID);


            if (!devicetaganalizebegin)
            {
                devicetaganalizebegin = true;
                // проведем анализ в потоке
                DefectDevice_tag();
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
            // костыль, но нужно кратковременно перекинуть форкус чтобы применить изменения при сохранении
            // !! обязательно подписака на событие datagridwiev.cellleave методом события cellClick
            DataGridView dtw = dataGridView5;
            if (dtw.Rows.Count > 1)
            {
                int x = dtw.CurrentCell.RowIndex;
                int y = dtw.CurrentCell.ColumnIndex;
                if (x > 0)
                {
                    x--;
                    dtw.CurrentCell = dtw[y, x];
                    x++;
                    dtw.CurrentCell = dtw[y, x];

                }
                else
                {
                    x++;
                    dtw.CurrentCell = dtw[y, x];
                    x--;
                    dtw.CurrentCell = dtw[y, x];
                }
            }
            if (changed_Modifed_FilterDataTable)
            {
                changed_Modifed_FilterDataTable = false;
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
                changed_Modifed_SystemTypeDataTable = true;
            }
            if (rPTagsDataSet.SystemType.GetChanges(DataRowState.Added) != null)
            {
                temp_Modifed_FilterDataTable.Merge(rPTagsDataSet.SystemType.GetChanges(DataRowState.Added));
                tabPage15.Text = "*Тип системы";
                changed_Modifed_SystemTypeDataTable = true;
            }
            if (rPTagsDataSet.SystemType.GetChanges(DataRowState.Deleted) != null)
            {
                temp_Modifed_FilterDataTable.Merge(rPTagsDataSet.SystemType.GetChanges(DataRowState.Deleted));
                tabPage15.Text = "*Тип системы";
                changed_Modifed_SystemTypeDataTable = true;
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
            // костыль, но нужно кратковременно перекинуть форкус чтобы применить изменения при сохранении
            // !! обязательно подписака на событие datagridwiev.cellleave методом события cellClick
            DataGridView dtw = dataGridView13;
            if (dtw.Rows.Count > 1)
            {
                int x = dtw.CurrentCell.RowIndex;
                int y = dtw.CurrentCell.ColumnIndex;
                if (x > 0)
                {
                    x--;
                    dtw.CurrentCell = dtw[y, x];
                    x++;
                    dtw.CurrentCell = dtw[y, x];

                }
                else
                {
                    x++;
                    dtw.CurrentCell = dtw[y, x];
                    x--;
                    dtw.CurrentCell = dtw[y, x];
                }
            }
            if (changed_Modifed_SystemTypeDataTable)
            {
                rPTagsDataSet.SystemType.Merge(temp_Modifed_FilterDataTable);
                systemTypeTableAdapter.Update(rPTagsDataSet.SystemType);
                tabPage15.Text = "Тип системы";
                temp_Modifed_FilterDataTable.Clear();
                dataGridView13.AllowUserToAddRows = false;
                changed_Modifed_SystemTypeDataTable = false;
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

                temp_Modifed_GrupTypeDataTable.Merge(rPTagsDataSet.Gruptype.GetChanges(DataRowState.Modified),false);
                tabPage16.Text = "*Тип группы";
                changed_Modifed_GrupTypeDataTable = true;
            }
            if (rPTagsDataSet.Gruptype.GetChanges(DataRowState.Added) != null)
            {
                temp_Modifed_GrupTypeDataTable.Merge(rPTagsDataSet.Gruptype.GetChanges(DataRowState.Added), false);
                tabPage16.Text = "*Тип группы";
                changed_Modifed_GrupTypeDataTable = true;
            }
            if (rPTagsDataSet.Gruptype.GetChanges(DataRowState.Deleted) != null)
            {
                temp_Modifed_GrupTypeDataTable.Merge(rPTagsDataSet.Gruptype.GetChanges(DataRowState.Deleted), false);
                tabPage16.Text = "*Тип группы";
                changed_Modifed_GrupTypeDataTable = true;
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
            // костыль, но нужно кратковременно перекинуть форкус чтобы применить изменения при сохранении
            // !! обязательно подписака на событие datagridwiev.cellleave методом события cellClick
            DataGridView dtw = dataGridView14;
            if (dtw.Rows.Count > 1)
            {
                int x = dtw.CurrentCell.RowIndex;
                int y = dtw.CurrentCell.ColumnIndex;
                if (x > 0)
                {
                    x--;
                    dtw.CurrentCell = dtw[y, x];
                    x++;
                    dtw.CurrentCell = dtw[y, x];

                }
                else
                {
                    x++;
                    dtw.CurrentCell = dtw[y, x];
                    x--;
                    dtw.CurrentCell = dtw[y, x];
                }
            }
            if (changed_Modifed_GrupTypeDataTable)
            {
                rPTagsDataSet.Gruptype.Merge(temp_Modifed_GrupTypeDataTable);
                gruptypeTableAdapter.Update(rPTagsDataSet.Gruptype);
                tabPage16.Text = "Тип группы";
                temp_Modifed_GrupTypeDataTable.Clear();
                dataGridView14.AllowUserToAddRows = false;
                changed_Modifed_GrupTypeDataTable = false;
            }
        }
        private void dataGridView14_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if (dataGridView14.CurrentRow != null)
                {
                    int index = Convert.ToInt16(dataGridView14.CurrentRow.Index);
                    int id = Convert.ToInt16(rPTagsDataSet.Gruptype[index]["id"]);

                    this.tagTableAdapter.FillByGrupType(this.rPTagsDataSet.Tag, id);
                }
                else
                {
                   
                }
                GrupType_changed();
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //--------------Тип тега---------------------------------------------------------------------------------------

        private void TagType_changed()
        {
            if (rPTagsDataSet.TagType.GetChanges(DataRowState.Modified) != null)
            {

                temp_Modifed_TagTypeDataTable.Merge(rPTagsDataSet.TagType.GetChanges(DataRowState.Modified));
                tabPage17.Text = "*Тип тега";
                changed_Modifed_TagTypeDataTable = true;
            }
            if (rPTagsDataSet.TagType.GetChanges(DataRowState.Added) != null)
            {
                temp_Modifed_TagTypeDataTable.Merge(rPTagsDataSet.TagType.GetChanges(DataRowState.Added));
                tabPage17.Text = "*Тип тега";
                changed_Modifed_TagTypeDataTable = true;
            }
            if (rPTagsDataSet.TagType.GetChanges(DataRowState.Deleted) != null)
            {
                temp_Modifed_TagTypeDataTable.Merge(rPTagsDataSet.TagType.GetChanges(DataRowState.Deleted));
                tabPage17.Text = "*Тип тега";
                changed_Modifed_TagTypeDataTable = true;
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
            // костыль, но нужно кратковременно перекинуть форкус чтобы применить изменения при сохранении
            // !! обязательно подписака на событие datagridwiev.cellleave методом события cellClick
            DataGridView dtw = dataGridView15;
            if (dtw.Rows.Count > 1)
            {
                int x = dtw.CurrentCell.RowIndex;
                int y = dtw.CurrentCell.ColumnIndex;
                if (x > 0)
                {
                    x--;
                    dtw.CurrentCell = dtw[y, x];
                    x++;
                    dtw.CurrentCell = dtw[y, x];

                }
                else
                {
                    x++;
                    dtw.CurrentCell = dtw[y, x];
                    x--;
                    dtw.CurrentCell = dtw[y, x];
                }
            }
            if (changed_Modifed_TagTypeDataTable)
            {
                rPTagsDataSet.TagType.Merge(temp_Modifed_TagTypeDataTable);
                tagTypeTableAdapter.Update(rPTagsDataSet.TagType);
                tabPage17.Text = "Тип тега";
                temp_Modifed_TagTypeDataTable.Clear();
                dataGridView15.AllowUserToAddRows = false;
                changed_Modifed_TagTypeDataTable = false;
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

                temp_Modifed_OPCDataTable.Merge(rPTagsDataSet.OPC.GetChanges(DataRowState.Modified));
                tabPage18.Text = "*OPC";
                changed_Modifed_OPCDataTable = true;
            }
            if (rPTagsDataSet.OPC.GetChanges(DataRowState.Added) != null)
            {
                temp_Modifed_OPCDataTable.Merge(rPTagsDataSet.OPC.GetChanges(DataRowState.Added));
                tabPage18.Text = "*OPC";
                changed_Modifed_OPCDataTable = true;
            }
            if (rPTagsDataSet.OPC.GetChanges(DataRowState.Deleted) != null)
            {
                temp_Modifed_OPCDataTable.Merge(rPTagsDataSet.OPC.GetChanges(DataRowState.Deleted));
                tabPage18.Text = "*OPC";
                changed_Modifed_OPCDataTable = true;
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
            // костыль, но нужно кратковременно перекинуть форкус чтобы применить изменения при сохранении
            // !! обязательно подписака на событие datagridwiev.cellleave методом события cellClick
            DataGridView dtw = dataGridView16;
            if (dtw.Rows.Count > 1)
            {
                int x = dtw.CurrentCell.RowIndex;
                int y = dtw.CurrentCell.ColumnIndex;
                if (x > 0)
                {
                    x--;
                    dtw.CurrentCell = dtw[y, x];
                    x++;
                    dtw.CurrentCell = dtw[y, x];

                }
                else
                {
                    x++;
                    dtw.CurrentCell = dtw[y, x];
                    x--;
                    dtw.CurrentCell = dtw[y, x];
                }
            }
            if (changed_Modifed_OPCDataTable)
            {
                rPTagsDataSet.OPC.Merge(temp_Modifed_OPCDataTable);
                oPCTableAdapter.Update(rPTagsDataSet.OPC);
                tabPage18.Text = "OPC";
                temp_Modifed_OPCDataTable.Clear();
                dataGridView16.AllowUserToAddRows = false;
                changed_Modifed_OPCDataTable = false;
            }
        }    
        private void dataGridView16_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OPC_changed();
        }

        #endregion второстепенные таблицы
        //----------------------------------------------------------------------------------------------------

       
       
      
        #region конфигурации

        string prename;
        string corpus_name = "";

        private bool SaveDGVToCSVfile(string filename, string patch, DataGridView table,bool addStb, string stable)
        {
            try
            {
                   
                   filename += ".csv";
                string fullfilepatch = patch + "\\" + filename;
                Directory.CreateDirectory(patch);
                StreamWriter sw = new StreamWriter(fullfilepatch, false, Encoding.UTF8);

                List<int> col_n = new List<int>();
                foreach (DataGridViewColumn col in table.Columns)
                    if (col.Visible)
                    {
                        //sw.Write(col.HeaderText + "\t");
                        col_n.Add(col.Index);
                    }
                int x = table.RowCount;
                if (table.AllowUserToAddRows) x--;

                for (int i = 0; i < x; i++)
                {
                    int y = 0;
                    for (y = 0; y < col_n.Count; y++)
                    {

                        sw.Write(table[col_n[y], i].Value);
                        if (y < col_n.Count-1)
                        {
                            sw.Write(",");
                        }
                    }
                                
                    sw.Write("\r\n");
                }
                if (addStb)
                {
                    StreamReader fs = new StreamReader(stable);
                    sw.Write("\r\n");
                    

                    while (true)
                    {
                        // Читаем строку из файла во временную переменную.
                        string temp = fs.ReadLine();

                        // Если достигнут конец файла, прерываем считывание.
                        if (temp == null) break;
                        sw.Write(temp);
                        sw.Write("\r\n"); 
                        
                       
                    }
                }

                sw.Close();
                MessageBox.Show("Конфигурация " + filename + " сохранена!","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            
            return true;
        }
        private string FileDialog()
        {
            string s = "C:\\";
        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                s = folderBrowserDialog1.SelectedPath + "\\config_" + prename;
            }
            textBox1.Text = s;
            textBox5.Text = s;
            textBox7.Text = s;
            textBox9.Text = s;
            textBox11.Text = s;
            return s;
           
        }
        private void checkallcheckbox(bool check)
        {
            if(check)
            {
                checkBox4.Checked = true;
                checkBox5.Checked = true;
                checkBox6.Checked = true;
                checkBox7.Checked = true;
                // если грузим конфиги по корпусу нужно заблокировать 
                //stable конфигурации (хотя возможно позже их можно будет разделить по корпусам)
                checkBox1.Checked = true;
                checkBox1.Enabled = true;
                checkBox2.Checked = true;
                checkBox2.Enabled = true;
                checkBox3.Checked = true;
                checkBox3.Enabled = true;

            }
            else
            {
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;

                // если грузим конфиги по корпусу нужно заблокировать 
                //stable конфигурации (хотя возможно позже их можно будет разделить по корпусам)
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
                checkBox2.Checked = false;
                checkBox2.Enabled = false;
                checkBox3.Checked = false;
                checkBox3.Enabled = false;


            }
        }


        //------------------areaAWX---------------------------------------------
        private void AreaAWXdgvGen_Click(object sender, EventArgs e)// пуск генератора
        {
            if (dataGridView8.RowCount != 0)
            {
                dataGridView8.DataSource = null;             
            }
            
            if (!checkBox4.Checked)
            {   
                Get_corpus = comboBox2.SelectedValue.ToString();
                corpus_name = "_"+ Get_corpus;
            } else
                corpus_name = "";
            textBox3.Text = "AreaAWX" + corpus_name;
            if (backgroundWorker1.IsBusy != true)
            {
                
                backgroundWorker1.RunWorkerAsync();
                toolStripStatusLabel4.Text = "Идет загрузка конфигрураци...";
            }        
        }
                // зальемся ассинхронно
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            
            this.areaAWXTableAdapter.Fill(this.rPTagsDataSet.AreaAWX, textBox2.Text, Get_corpus);
           
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // возможно сюда засунем прогресс, если сможем его отыскать
        }     
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Загрузка конфигурации AreaAWX завершена!");
            toolStripStatusLabel4.Text = "";
            dataGridView8.DataSource = rPTagsDataSet.AreaAWX;
            
        }
        private void button1_Click(object sender, EventArgs e) // выбор пути к файлу
        {
          FileDialog();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) // добавка stable
        {
            if (checkBox1.Checked)
            {
                textBox12.ReadOnly = false;
            }
            else textBox12.ReadOnly = true;
        }
        private void button3_Click(object sender, EventArgs e) // сохранить файл
        {
            SaveDGVToCSVfile(textBox3.Text, textBox1.Text, dataGridView8, checkBox1.Checked, textBox12.Text);
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e) // выбор всех корпусов
        {
           
            if (!checkBox4.Checked)
            {
                comboBox2.Enabled = true;
                checkallcheckbox(false);
            }
            else
            {
                comboBox2.Enabled = false;
                Get_corpus = "ALL";
                checkallcheckbox(true);
            }
        }
       

        //----------------tagAWX----------------------------------------------
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            
            BackgroundWorker worker = sender as BackgroundWorker;
            
            this.tagAWXTableAdapter.Fill(this.rPTagsDataSet.TagAWX, Get_corpus);
        }
        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Загрузка конфигурации TagAWX завершена!");
            toolStripStatusLabel4.Text = "";
            dataGridView9.DataSource = rPTagsDataSet.TagAWX;
        } 
        private void button4_Click(object sender, EventArgs e) // сгенерировать
        {
            if (dataGridView9.RowCount != 0)
            {
                dataGridView9.DataSource = null;
            }
            if (!checkBox5.Checked)
            {
                Get_corpus = comboBox4.SelectedValue.ToString();
                corpus_name = "_" + Get_corpus;
            }
            else
                corpus_name = "";
            textBox4.Text = "TagAWX" + corpus_name;
            if (backgroundWorker2.IsBusy != true)
            {
                backgroundWorker2.RunWorkerAsync();
                toolStripStatusLabel4.Text = "Идет загрузка конфигрураци...";
            }
        }
        private void button5_Click(object sender, EventArgs e) // путь сохранения
        {
            FileDialog();
        }     
        private void button2_Click(object sender, EventArgs e) // сохранить файл
        {
            SaveDGVToCSVfile(textBox4.Text, textBox5.Text, dataGridView9, false, "");
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            
               
            if (!checkBox5.Checked)
            {
                comboBox4.Enabled = true;
                checkallcheckbox(false);
            }
            else
            {
                comboBox4.Enabled = false;
                Get_corpus = "ALL";
                checkallcheckbox(true);
            }
            
        }
      
        

        //----------------tagHH----------------------------------------------
        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
           
            BackgroundWorker worker = sender as BackgroundWorker;

            this.tagHHTableAdapter.Fill(this.rPTagsDataSet.TagHH, Get_corpus);
        }
        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Загрузка конфигурации TagHH завершена!");
            toolStripStatusLabel4.Text = "";
            dataGridView10.DataSource = rPTagsDataSet.TagHH;
        }    
        private void button7_Click(object sender, EventArgs e) // generate
        {
            if (dataGridView10.RowCount != 0)
            {
                dataGridView10.DataSource = null;
            }
            if (!checkBox6.Checked)
            {
                Get_corpus = comboBox5.SelectedValue.ToString();
                corpus_name = "_" + Get_corpus;
            }
            else
                corpus_name = "";
            textBox6.Text = "TagHH" + corpus_name;
            if (backgroundWorker3.IsBusy != true)
            {
                backgroundWorker3.RunWorkerAsync();
                toolStripStatusLabel4.Text = "Идет загрузка конфигрураци...";
            }
        }
        private void button8_Click(object sender, EventArgs e) // filepath
        {
            FileDialog();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox13.ReadOnly = false;
            }
            else textBox13.ReadOnly = true;
        }
        private void button6_Click(object sender, EventArgs e) // save file
        {
            SaveDGVToCSVfile(textBox6.Text, textBox7.Text, dataGridView10, checkBox2.Checked, textBox13.Text);
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox6.Checked)
            {
                comboBox5.Enabled = true;
                checkallcheckbox(false);

            }
            else
            {
                comboBox5.Enabled = false;
                Get_corpus = "ALL";
                checkallcheckbox(true);
            }
        }
      

        //----------------tagUDM----------------------------------------------
        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
           
            BackgroundWorker worker = sender as BackgroundWorker;

            this.tagUDMTableAdapter.Fill(this.rPTagsDataSet.TagUDM, Get_corpus);
        }
        private void backgroundWorker4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Загрузка конфигурации TagUDM завершена!");
            toolStripStatusLabel4.Text = "";
            dataGridView11.DataSource = rPTagsDataSet.TagUDM;
        }      
        private void button10_Click(object sender, EventArgs e) // generate
        {
            if (dataGridView11.RowCount != 0)
            {
                dataGridView11.DataSource = null;
            }
            if (!checkBox7.Checked)
            {
                Get_corpus = comboBox6.SelectedValue.ToString();
                corpus_name = "_" + Get_corpus;
            }
            else
                corpus_name = "";
            textBox8.Text = "TagUDM" + corpus_name;
            if (backgroundWorker4.IsBusy != true)
            {
                backgroundWorker4.RunWorkerAsync();
                toolStripStatusLabel4.Text = "Идет загрузка конфигрураци...";
            }
        }
        private void button11_Click(object sender, EventArgs e) // fileparth
        {
            FileDialog();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox14.ReadOnly = false;
            }
            else textBox14.ReadOnly = true;
        }
        private void button9_Click(object sender, EventArgs e) //savefile
        {
            SaveDGVToCSVfile(textBox8.Text, textBox9.Text, dataGridView11, checkBox3.Checked, textBox14.Text);
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox7.Checked)
            {
                comboBox6.Enabled = true;
                checkallcheckbox(false);

            }
            else
            {
                comboBox6.Enabled = false;
                Get_corpus = "ALL";
                checkallcheckbox(true);
            }
        }
       
        //----------------tagOPC----------------------------------------------
        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            
            BackgroundWorker worker = sender as BackgroundWorker;

            var param = (TagOPCparam)e.Argument; // принимаем параметры в воркер
            this.rPTagsDataSet.TagOPC.Clear();
            this.tagOPCTableAdapter.Fill(this.rPTagsDataSet.TagOPC, param.PLC, param.SetParam);
        }       
        private void backgroundWorker5_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Загрузка конфигурации TagOPC завершена!");
            toolStripStatusLabel4.Text = "";
            
           
            dataGridView12.DataSource = rPTagsDataSet.TagOPC;
           
        }
        struct TagOPCparam // нужно передать параметры в поток
        {
           public string PLC;
           public string SetParam;

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e) // generate
        {
            if (dataGridView12.RowCount != 0)
            {
                dataGridView12.DataSource = null;
            }

            var param = new TagOPCparam(); // экземпляр структуры
            param.PLC = comboBox1.SelectedValue.ToString();
            param.SetParam = comboBox3.SelectedItem.ToString();
            textBox10.Text = param.PLC;
            toolStripStatusLabel4.Text = param.PLC + " "+ param.SetParam;
            if (backgroundWorker5.IsBusy != true)
            {
                backgroundWorker5.RunWorkerAsync(param); // передаем параметры при запуске воркера
               // toolStripStatusLabel4.Text ="Параметры: "+ param.PLC + " " + param.SetParam;
                toolStripStatusLabel4.Text = "Идет загрузка конфигрураци...";
                
            }
            
        }

        private void fillByGrupTypeToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void button14_Click(object sender, EventArgs e) // setfile path
        {
            FileDialog();
        }
        private void button12_Click(object sender, EventArgs e) // save file
        {
            SaveDGVToCSVfile(textBox10.Text, textBox11.Text, dataGridView12, false, "");
        }

        #endregion конфигурации

        #region подсказки

        void tooltiptext()
        {
            dataGridView1.Columns[0].ToolTipText = "Имя корпуса / строения";
        }


        #endregion

        private void Form2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (toolStripMenuItem11.Enabled)
            {
                toolStripMenuItem11.Enabled = false;
                удалитьToolStripMenuItem.Enabled = false;
                toolStripMenuItem2.Enabled = false;
                toolStripMenuItem5.Enabled = false;
                toolStripMenuItem8.Enabled = false;
                toolStripMenuItem26.Enabled = false;
                toolStripMenuItem14.Enabled = false;
                toolStripMenuItem17.Enabled = false;
                toolStripMenuItem20.Enabled = false;
                toolStripMenuItem23.Enabled = false;
                toolStripMenuItem25.Enabled = false;
            }
            else
            {
                toolStripMenuItem11.Enabled = true;
                удалитьToolStripMenuItem.Enabled = true;
                toolStripMenuItem2.Enabled = true;
                toolStripMenuItem5.Enabled = true;
                toolStripMenuItem8.Enabled = true;
                toolStripMenuItem26.Enabled = true;
                toolStripMenuItem14.Enabled = true;
                toolStripMenuItem17.Enabled = true;
                toolStripMenuItem20.Enabled = true;
                toolStripMenuItem23.Enabled = true;
                toolStripMenuItem25.Enabled = true;
            }


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView6_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            toolStripStatusLabel2.Text = "     Какие то проблемы с датагридом";

        } // обработчик ошибок

    }
}

