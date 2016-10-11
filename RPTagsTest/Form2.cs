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



        #region переменные формы
        // указатели необходимости обновления датагрида - когда идем по вкладкам назад перегружать не нужно

        // обработка выбора системы

        public bool passtrue; // пароль введен
        public bool deleteEnable; // разрешено удаление
        public bool diagnosticEnable; // разрешен показ админской вкладки

        DataTable temp_Modifed_FilterDataTable = new DataTable("temp_Modifed_FilterDataTable");
        DataTable temp_Modifed_OPCDataTable = new DataTable("temp_Modifed_FilterDataTable");
        DataTable temp_Modifed_SystemTypeDataTable = new DataTable("temp_Modifed_SystemTypeDataTable");
        DataTable temp_Modifed_GrupTypeDataTable = new DataTable("temp_Modifed_GrupTypeDataTable");
        DataTable temp_Modifed_TagTypeDataTable = new DataTable("temp_Modifed_TagTypeDataTable");
        RPTagsDataSet.Device_TagDataTable DeviceTag_temp_DT = new RPTagsDataSet.Device_TagDataTable();


        bool changed_Modifed_FilterDataTable;
        bool changed_Modifed_OPCDataTable;
        bool changed_Modifed_SystemTypeDataTable;
        bool changed_Modifed_GrupTypeDataTable;
        bool changed_Modifed_TagTypeDataTable;





        string Get_corpus = "ALL";

        #endregion переменные формы
        #region основные таблицы
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

            backgroundWorker6.WorkerReportsProgress = true;
            backgroundWorker6.WorkerSupportsCancellation = true;

            backgroundWorker7.WorkerReportsProgress = true;
            backgroundWorker7.WorkerSupportsCancellation = true;

            dataGridView7.CellEndEdit += DataGridView7_CellEndEdit;

            toolStripMenuAdd.Click += ToolStripMenuAdd_Click;
            toolStripMenuEdit.Click += ToolStripMenuEdit_Click;
            toolStripMenuDelete.Click += ToolStripMenuDelete_Click;
            


        }

       



        //-----------------------------------------------------------------------------

        private void Form2_Load(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnectionStringBuilder connect = new SqlConnectionStringBuilder();
                connect.ConnectionString = Properties.Settings.Default["RPTagsConnectionString"].ToString();

                SqlConnection connection = new SqlConnection(connect.ConnectionString);

                // Открываем подключение

                connection.Open();


                toolStripStatusLabel2.Text = "Тест подключения: OK";
                connection.Close();

            }
            catch (SqlException ex)
            {
                if (MessageBox.Show("Отсутствует связь с базой данных \n " + tagTableAdapter.Connection.DataSource.ToString() + " (" + tagTableAdapter.Connection.Database.ToString() + ") \n Приложение будет закрыто!", "Ошибка связи", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    this.Close();
            }



            this.corpusTableAdapter.Fill(this.rPTagsDataSet.Corpus);
            this.oPCTableAdapter.Fill(this.rPTagsDataSet.OPC);
            this.filtresTableAdapter.Fill(this.rPTagsDataSet.Filtres);
            this.tagTypeTableAdapter.Fill(this.rPTagsDataSet.TagType);
            this.gruptypeTableAdapter.Fill(this.rPTagsDataSet.Gruptype);
            this.systemTypeTableAdapter.Fill(this.rPTagsDataSet.SystemType);

            tagIdTagTypeIDTableAdapter.Fill(rPTagsDataSet.TagIdTagTypeID);
            tagTableAdapter.Fill(this.rPTagsDataSet.Tag);


            dataGridView5.AllowUserToAddRows = false;
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



            passtrue = false; // пароль введен
            deleteEnable = false; // разрешено удаление
            diagnosticEnable = false;




            TagChange newForm = new TagChange();
            newForm.Owner = this;

            toolStripStatusLabel3.Text = tagTableAdapter.Connection.DataSource.ToString() + " (" + tagTableAdapter.Connection.Database.ToString() + ")";

            prename = DateTime.Today.Day.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString(); //нужно для имени файла конфигурации
                                                                                                                        //toolStripStatusLabel3.Text = prename;

            // инициализатор дерева
            foreach (RPTagsDataSet.CorpusRow row_corpus in rPTagsDataSet.Corpus)
            {
                TreeNode node_corpus = new TreeNode(row_corpus.Name);
                node_corpus.Text = row_corpus.Name;
                node_corpus.Tag = row_corpus.id;

                treeView1.Nodes.Add(node_corpus);
            }

        }

        private void tag_path_changer(TreeNode node)
        {
            toolStripStatusLabel1.Text = node.FullPath;
            tabPage1.Text = node.FullPath;
        } // путь тега для главной формы

        private void tabControl1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
            deleteenable(deleteEnable);
        }

        bool notsaved = false;
        bool canceledit = false;
        //----------------Девайс---------------------------------------------------------------------------------------------------
        private void change_device_tag()
        {
            bool needaccept = false;
            canceledit = true;
            if (rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Added) != null)
            {
                DeviceTag_temp_DT.Merge(rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Added));

                //tabPage7.Text = "+Устройство";
                if (tabPage7.Text[0].ToString() == "У")
                    tabPage7.Text = tabPage7.Text.Insert(0, "+");
                notsaved = true;
                needaccept = true;
            }
            if (rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Deleted) != null)
            {
                DeviceTag_temp_DT.Merge(rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Deleted));
                if (tabPage7.Text[0].ToString() == "У")
                    tabPage7.Text = tabPage7.Text.Insert(0, "-");
                notsaved = true;
                needaccept = true;
            }

            if (rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Modified) != null)
            {
                DeviceTag_temp_DT.Merge(rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Modified));
                if (tabPage7.Text[0].ToString() == "У")
                    tabPage7.Text = tabPage7.Text.Insert(0, "*");
                DataGridView dtw = dataGridView7;

                notsaved = true;
                needaccept = true;
            }
            if (needaccept)
            {
                rPTagsDataSet.Device_Tag.AcceptChanges();
                needaccept = false;
            }

        }
        private void fiilDevice_tag(int systema)
        {
            if (systema != 0) // по одному
            {
                this.device_TagTableAdapter.FillBySystema(this.rPTagsDataSet.Device_Tag, systema);
            }
        }
        private void fiilDevice_tag(int systema, int gruppa)
        {
            if (systema != 0 && gruppa != 0) // по двум
            {
                this.device_TagTableAdapter.FillBySystemaGryppa(this.rPTagsDataSet.Device_Tag, systema, gruppa);
            }
        }
        private void fiilDevice_tag(int systema, int gruppa, int tag)
        {
            if (systema != 0 && gruppa != 0 && tag != 0) // по трем параметрам
            {
                this.device_TagTableAdapter.FillByTagSysGr(this.rPTagsDataSet.Device_Tag, systema, gruppa, tag);
            }
            
            
        }
        private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                int sys_id = Convert.ToInt16(rPTagsDataSet.Device_Tag[0]["Sys_id"]);
                sAIDNullTableAdapter.FillBySystemaDefect(rPTagsDataSet.SAIDNull, sys_id);
                DataView dw = new DataView(rPTagsDataSet.SAIDNull);
                int failrows = 0;
                int maximum = 0;


                maximum = rPTagsDataSet.Device_Tag.Count;
                foreach (DataRow row in rPTagsDataSet.Device_Tag.Select())
                {
                    sys_id = Convert.ToInt16(row["Sys_id"]);
                    int gr_id = Convert.ToInt16(row["Gr_id"]);
                    int tag_id = Convert.ToInt16(row["Tag_id"]);
                    string expression = "Sys_id = " + sys_id + "AND Gr_id = " + gr_id + "AND tag_id = " + tag_id;
                    dw.RowFilter = string.Empty;
                    dw.RowFilter = expression;


                    if (dw.Count == 0)
                    {
                        failrows++;
                        row.Delete();


                    }

                }
                if (failrows != 0)
                {
                    MessageBox.Show("Из таблицы исключено: \n " + failrows + " ошибочных SAID", "Проверка путей", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ошибочные строки отсутствуют", "Проверка путей", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Data.DeletedRowInaccessibleException)
            {
                toolStripStatusLabel2.Text = "Кто - то накосячил с DataSet";
            }
        }
        private void backgroundWorker6_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripStatusLabel4.Text = "";
            change_device_tag();
        }   
        private void DataGridView7_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (rPTagsDataSet.Device_Tag.GetChanges(DataRowState.Modified) != null)
            {
                if (tabPage7.Text[0].ToString() == "У")
                    tabPage7.Text = tabPage7.Text.Insert(0, "*");
                canceledit = true;
            }
        }
        private void tabPage7_Leave(object sender, EventArgs e)
        {
            if (canceledit)
            {
                DataGridView dtw = dataGridView7;
                Validate();
                dtw.Update();
                dtw.EndEdit();
                change_device_tag();
            }
            toolStripStatusLabel4.Text = "";

        }
        private void toolStripMenuItem26_Click(object sender, EventArgs e) // удалить
        {
            try
            {
                int index = Convert.ToInt16(dataGridView7.CurrentRow.Index);
                dataGridView7.Rows.RemoveAt(index);
                change_device_tag();
            }
            catch
            {

            }
        }
        private void toolStripMenuItem27_Click(object sender, EventArgs e) // сохранить
        {
            try
            {
                DataGridView dtw = dataGridView7;
                Validate();
                dtw.Update();
                dtw.EndEdit();
                change_device_tag();
                device_TagTableAdapter.Update(DeviceTag_temp_DT);
                notsaved = false;
                if (tabPage7.Text[0].ToString() != "У")
                    tabPage7.Text = tabPage7.Text.Remove(0, 1);
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
            // затычка для работы при смене груптайпов

            tagIdTagTypeIDTableAdapter.Fill(rPTagsDataSet.TagIdTagTypeID);
            tagTableAdapter.Fill(this.rPTagsDataSet.Tag);


            if (backgroundWorker6.IsBusy != true)
            {

                backgroundWorker6.RunWorkerAsync();
                toolStripStatusLabel4.Text = "Идет проверка ошибок в таблице Устройства...";
            }

        }
        private void отменитьИзменнеияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceTag_temp_DT.Clear();
            tabPage7.Text = "Устройство";
            notsaved = false;
            canceledit = true;

        }
        private void button15_Click(object sender, EventArgs e) // импорт тегов из csv
        {
            importOPC newForm = new importOPC();
            newForm.Owner = this;
            newForm.Show();
        }
        private void backgroundWorker7_DoWork(object sender, DoWorkEventArgs e)
        {
            //toolStripStatusLabel4.Text = "Добавляем отсутствующие записи...";
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.WorkerReportsProgress = true;
            int countstr = 0;
            foreach (DataRow row in rPTagsDataSet.SAIDNull)
            {


                RPTagsDataSet.Device_TagRow newRow = rPTagsDataSet.Device_Tag.NewDevice_TagRow();
                //newRow.SAID = Name_Systema;
                newRow.Sys_id = Convert.ToInt16(row["Sys_id"]);
                newRow.Gr_id = Convert.ToInt16(row["Gr_id"]);
                newRow.Tag_id = Convert.ToInt16(row["Tag_id"]);


                rPTagsDataSet.Device_Tag.AddDevice_TagRow(newRow);
                countstr += 1;
                worker.ReportProgress(countstr);
            }
        } // добавка тегов
        private void backgroundWorker7_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripStatusLabel4.Text = "Записей добавлено: " + e.ProgressPercentage.ToString();
        }// добавка тегов
        private void backgroundWorker7_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            toolStripStatusLabel4.Text = "Все записи добавлены!";
            change_device_tag();
            tabControl1.Enabled = true;
        }// добавка тегов
        int countcut;
        int devtagstrsum;
        int devtagstrcount;
        private void исключитьТегиБезАдресаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            devtagstrsum = dataGridView7.Rows.Count;
            if (backgroundWorker8.IsBusy != true)
            {
                notsaved = true;
                backgroundWorker8.RunWorkerAsync();
                dataGridView7.ReadOnly = true;
            }

        }
        private void backgroundWorker8_DoWork(object sender, DoWorkEventArgs e)
        {
            countcut = 0;

            BackgroundWorker worker = sender as BackgroundWorker;
            worker.WorkerReportsProgress = true;

            devtagstrcount = 0;
            foreach (RPTagsDataSet.Device_TagRow row in rPTagsDataSet.Device_Tag.Rows)
            {
                if (row.IsAdrPLCNull())
                {
                    row.Cut = 1;
                    countcut++;

                }
                else
                {
                    row.Cut = 0;
                }


                devtagstrcount++;
                worker.ReportProgress(devtagstrcount);

            }

        }
        private void backgroundWorker8_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripStatusLabel4.Text = "Обработано строк : " + e.ProgressPercentage.ToString() + " из " + devtagstrsum;
        }
        private void backgroundWorker8_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridView7.Update();
            toolStripStatusLabel4.Text = "Готово! Исключено записей: " + countcut + " (поставлен чек бокс Cut)";
            change_device_tag();
            tabControl1.Enabled = true;
            dataGridView7.ReadOnly = false;
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
            catch (System.Exception)
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
            catch (System.Exception)
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
        bool beginedit;
        private void GrupType_changed()
        {
            if (rPTagsDataSet.Gruptype.GetChanges(DataRowState.Modified) != null)
            {

                temp_Modifed_GrupTypeDataTable.Merge(rPTagsDataSet.Gruptype.GetChanges(DataRowState.Modified), false);
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
            catch (System.Exception)
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
                if (dataGridView14.CurrentRow != null || beginedit)
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
        private void dataGridView14_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            beginedit = true;
        }
        private void dataGridView14_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            beginedit = false;
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
            catch (System.Exception)
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
            catch (System.Exception)
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
        #region конфигурации

        string prename;
        string corpus_name = "";

        private bool SaveDGVToCSVfile(string filename, string patch, DataGridView table, bool addStb, string stable)
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
                        if (y < col_n.Count - 1)
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
                MessageBox.Show("Конфигурация " + filename + " сохранена!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            if (check)
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
                corpus_name = "_" + Get_corpus;
            }
            else
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
            toolStripStatusLabel4.Text = param.PLC + " " + param.SetParam;
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




        #endregion
        #region системные
        private void deleteenable(bool enable)
        {
            if (!enable)
            {




                toolStripMenuItem26.Enabled = false;
                toolStripMenuItem14.Enabled = false;
                toolStripMenuItem17.Enabled = false;
                toolStripMenuItem20.Enabled = false;
                toolStripMenuItem23.Enabled = false;
                toolStripMenuItem25.Enabled = false;
            }
            else
            {



                toolStripMenuItem26.Enabled = true;
                toolStripMenuItem14.Enabled = true;
                toolStripMenuItem17.Enabled = true;
                toolStripMenuItem20.Enabled = true;
                toolStripMenuItem23.Enabled = true;
                toolStripMenuItem25.Enabled = true;
            }
        }
        private void dataGridView6_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            toolStripStatusLabel2.Text = "     Какие то проблемы с датагридом";

        } // обработчик ошибок
        #endregion


        #region дерево
        int systema_id;
        int gruppa_id;
        int tag_id;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            fiilnode(e.Node); // 
            if (current_node != e.Node && current_node != null) // если при выборе нода изменилась, то отменим редактирование
            {
                selectcontrol(current_node.Level, false);
            }


            if (e.Node.Level == 2)
            {
                tag_id = 0;
                gruppa_id = 0;
                systema_id = Convert.ToInt16(e.Node.Tag); // родитель на уровне системы
            }
            else
            {
                if (e.Node.Level == 3)
                {
                    tag_id = 0;
                    gruppa_id = Convert.ToInt16(e.Node.Tag); // родитель на уровне группы
                    systema_id = Convert.ToInt16(e.Node.Parent.Tag); // родитель на уровне системы
                }
                else
                {
                    if (e.Node.Level == 5)
                    {
                        tag_id = Convert.ToInt16(e.Node.Tag); // уровень тега
                        gruppa_id = Convert.ToInt16(e.Node.Parent.Parent.Tag); // родитель на уровне группы
                        systema_id = Convert.ToInt16(e.Node.Parent.Parent.Parent.Tag); // родитель на уровне системы
                    }
                    else
                    {
                        tag_id = 0;
                        gruppa_id = 0;
                        systema_id = 0; 
                    }
                }
            }
            try
            {
                if (notsaved)
                {
                    MessageBox.Show("Данные не могут быть обновлены\n пока не будут сохранены изменения", "Данные не обновлены", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                if (!notsaved)
                {


                    if (systema_id != 0 && gruppa_id != 0 && tag_id != 0) // если выбрана система, группа, тег - покажем только по тегу
                    {

                        // зальем таблицу
                        fiilDevice_tag(systema_id, gruppa_id, tag_id);
                        if (tabControl1.SelectedTab == tabPage7)
                        {
                            // запросим наличие тегов без SAID
                            this.sAIDNullTableAdapter.FillBySysGrTag(this.rPTagsDataSet.SAIDNull, gruppa_id, systema_id, tag_id);
                            if (rPTagsDataSet.SAIDNull.Rows.Count != 0) // если есть хоть одна строка, предложим их добавить
                            {
                                if (MessageBox.Show("Для Тега: \"" + tabPage1.Text + "\"\nОтсутствует SAID!\n Добавить его?", "SAID", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                {
                                    if (backgroundWorker7.IsBusy != true)
                                    {

                                        backgroundWorker7.RunWorkerAsync();
                                        toolStripStatusLabel4.Text = "Добавление записей...";
                                        tabControl1.Enabled = false;
                                    }
                                }
                            }
                        }
                    }
                    else if (systema_id != 0 && gruppa_id != 0 && tag_id == 0) // если выбрана система, группа,  - покажем только по группе
                    {
                        //получим выборку по двум переменным
                        fiilDevice_tag(systema_id, gruppa_id);

                        // запросим наличие тегов без SAID
                        if (tabControl1.SelectedTab == tabPage7)
                        {
                            this.sAIDNullTableAdapter.FillBySustemGruppa(this.rPTagsDataSet.SAIDNull, gruppa_id, systema_id);
                            if (rPTagsDataSet.SAIDNull.Rows.Count != 0) // если есть хоть одна строка, предложим их добавить
                            {
                                if (MessageBox.Show("Для Группы: \"" + tabPage1.Text + "\"\nЕсть теги без SAID! Количество: " + rPTagsDataSet.SAIDNull.Rows.Count + "\n Добавить их?", "SAID", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                {
                                    if (backgroundWorker7.IsBusy != true)
                                    {

                                        backgroundWorker7.RunWorkerAsync();
                                        toolStripStatusLabel4.Text = "Добавление записей...";
                                        tabControl1.Enabled = false;
                                    }
                                }
                            }
                        }

                    }
                    else if (systema_id != 0 && gruppa_id == 0 && tag_id == 0) // если выбранна только система
                    {
                        //получим выборку по системе
                        fiilDevice_tag(systema_id);
                        // запросим наличие тегов без SAID
                        if (tabControl1.SelectedTab == tabPage7)
                        {
                            this.sAIDNullTableAdapter.FillBySystema(this.rPTagsDataSet.SAIDNull, systema_id);
                            if (rPTagsDataSet.SAIDNull.Rows.Count != 0) // если есть хоть одна строка, предложим их добавить
                            {
                                // toolStripStatusLabel2.Text = "У нас там есть что добавить";
                                if (MessageBox.Show("Для Системы: \"" + tabPage1.Text + "\"\nЕсть теги без SAID! Количество: " + rPTagsDataSet.SAIDNull.Rows.Count + "\n Добавить их?", "SAID", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                {

                                    if (backgroundWorker7.IsBusy != true)
                                    {

                                        backgroundWorker7.RunWorkerAsync();
                                        toolStripStatusLabel4.Text = "Добавление записей...";
                                        tabControl1.Enabled = false;
                                    }
                                }



                            }

                        }
                    }
                }
            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Исключение :-(");

            }
        }

        private void fiilnode(TreeNode node)
        {
            tag_path_changer(node);
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
                    tabControl1.SelectedTab = tabPage1;
                    foreach (RPTagsDataSet.PLCRow row_PLC in rPTagsDataSet.PLC)
                    {
                        TreeNode plc_node = new TreeNode(row_PLC.Name);
                        plc_node.Text = row_PLC.Name;
                        plc_node.Tag = row_PLC.id;
                        node.Nodes.Add(plc_node);
                    }
                    this.corpusTableAdapter1.FillById(this.rPTags_questiondata.Corpus, id); // зальем выбранный корпус
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
                    this.pLCTableAdapter1.FillById(this.rPTags_questiondata.PLC, id);
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
                    this.systemaTableAdapter1.FillById(this.rPTags_questiondata.Systema, id);
                    break;

                case 3: //выделена группа
                    node.Nodes.Clear();

                    this.tagTypeTableAdapter.Fill(this.rPTagsDataSet.TagType);

                    foreach (RPTagsDataSet.TagTypeRow row_TagType in rPTagsDataSet.TagType)
                    {
                        TreeNode tagType_node = new TreeNode(row_TagType.Name);
                        tagType_node.Text = row_TagType.Name;
                        tagType_node.Tag = row_TagType.id;
                        

                        // получим теги в подкаталоги
                        this.tagTableAdapter.FillByGruppaTagType(this.rPTagsDataSet.Tag, id, row_TagType.id);
                        foreach (RPTagsDataSet.TagRow row_Tag in rPTagsDataSet.Tag)
                        {
                            TreeNode Tag_node = new TreeNode(row_Tag.Name);
                            Tag_node.Text = row_Tag.Name;
                            Tag_node.Tag = row_Tag.id;
                            tagType_node.Nodes.Add(Tag_node);
                        }
                        node.Nodes.Add(tagType_node);
                    }
                    this.gruppaTableAdapter1.FillById(this.rPTags_questiondata.Gruppa,id);
                    break;

                case 4: //выделен груптайп
                    

                   
                    break;

                case 5: //выделен тег
                        this.tagTableAdapter1.FillById(this.rPTags_questiondata.Tag,id);
                    break;

                    
            }
            selectcontrol(level);

        }

        private void selectcontrol(int level)
        {
            // отключим видимость всех панелей, и включим только нужные


            switch (level)
            {
                case 0: //выделен корпус
                    panel_corpus.Visible = true;
                    panel_PLC.Visible = false;
                    panel_Systema.Visible = false;
                    panel_gruppa.Visible = false;
                    panel_tag.Visible = false;
                    break;
                case 1: //выделен ПЛК
                    panel_corpus.Visible = false;
                    panel_PLC.Visible = true;
                    panel_Systema.Visible = false;
                    panel_gruppa.Visible = false;
                    panel_tag.Visible = false;
                    break;

                case 2: //выделена система
                    panel_corpus.Visible = false;
                    panel_PLC.Visible = false;
                    panel_Systema.Visible = true;
                    panel_gruppa.Visible = false;
                    panel_tag.Visible = false;


                    // обработка чекбокса enabled
                    if (!rPTags_questiondata.Systema[0].IsEnablNull())
                    {
                        if (rPTags_questiondata.Systema[0].Enabl == 1)
                        {
                            checkBoxSystemaEnabled.Checked = true;
                        }
                        else
                        {
                            checkBoxSystemaEnabled.Checked = false;
                        }
                    }
                    else
                    {
                        checkBoxSystemaEnabled.Checked = false;
                    }
                    
                    break;

                case 3: //выделена группа
                    panel_corpus.Visible = false;
                    panel_PLC.Visible = false;
                    panel_Systema.Visible = false;
                    panel_gruppa.Visible = true;
                    panel_tag.Visible = false;
                    // обработка чекбокса enabled
                    if (treeView1.SelectedNode.Parent.Text == "THVC")
                    {
                        checkBoxGrupEnabled.Visible = true;
                        if (!rPTags_questiondata.Gruppa[0].IsEnablNull())
                        {
                            if (rPTags_questiondata.Gruppa[0].Enabl == 1)
                            {
                                checkBoxGrupEnabled.Checked = true;
                            }
                            else
                            {
                                checkBoxGrupEnabled.Checked = false;
                            }
                        }
                        else
                        {
                            checkBoxGrupEnabled.Checked = false;
                        }
                    }
                    else
                    {
                        checkBoxGrupEnabled.Visible = false;
                    }
                    break;

                case 4: //выделен груптайп

                    break;

                case 5: //выделен тег
                    panel_corpus.Visible = false;
                    panel_PLC.Visible = false;
                    panel_Systema.Visible = false;
                    panel_gruppa.Visible = false;
                    panel_tag.Visible = true;
                    break;
                
            }
        }
        private void selectcontrol(int level, bool edit) // управление контролом при редактировании
        {
            selectcontrol(level); // вызовем неперегруженный метод

            switch (level)
            {
                case 0: //выделен корпус
                    if (edit)
                    {
                        buttonCorpCancel.Visible = true;
                        buttonCorpSave.Visible = true;
                    } else
                    {
                        buttonCorpCancel.Visible = false;
                        buttonCorpSave.Visible = false;
                    }
                    break;
                case 1: //выделен ПЛК
                   
                    break;
                case 2: //выделена система
                    
                    break;
                case 3: //выделена группа
                    
                    break;
                case 4: //выделен груптайп

                    break;
                case 5: //выделен тег
                    
                    break;

            }
        }

        private void ToolStripMenuDelete_Click(object sender, EventArgs e)
        {

        }
        TreeNode current_node = null;
        private void ToolStripMenuEdit_Click(object sender, EventArgs e)
        {
            current_node = treeView1.SelectedNode;
            selectcontrol(treeView1.SelectedNode.Level,true);
        }

        private void ToolStripMenuAdd_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

    }
}


