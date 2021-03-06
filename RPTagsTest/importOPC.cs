﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPTagsTest
{
   
    public partial class importOPC : Form
    {

        DataTable dt = new DataTable("PLC");
        string filepath;
        public importOPC()
        {
            InitializeComponent();
            backgroundWorker2.WorkerReportsProgress = true;
            backgroundWorker2.WorkerSupportsCancellation = true;
        }
        private void importOPC_Load(object sender, EventArgs e)
        {
            DataColumn TagName;
            TagName = new DataColumn("Tag Name", typeof(String));

            DataColumn Address;
            Address = new DataColumn("Address", typeof(String));

            DataColumn DataType;
            DataType = new DataColumn("Data Type", typeof(String));

            DataColumn RespectDataType;
            RespectDataType = new DataColumn("Respect Data Type", typeof(String));

            DataColumn ClientAccess;
            ClientAccess = new DataColumn("Client Access", typeof(String));

            DataColumn ScanRate;
            ScanRate = new DataColumn("Scan Rate", typeof(String));

            DataColumn Scaling;
            Scaling = new DataColumn("Scaling", typeof(String));

            DataColumn RawLow;
            RawLow = new DataColumn("Raw Low", typeof(String));

            DataColumn RawHigh;
            RawHigh = new DataColumn("Raw High", typeof(String));

            DataColumn ScaledLow;
            ScaledLow = new DataColumn("Scaled Low", typeof(String));

            DataColumn ScaledHigh;
            ScaledHigh = new DataColumn("Scaled High", typeof(String));

            DataColumn ScaledDataType;
            ScaledDataType = new DataColumn("Scaled Data Type", typeof(String));

            DataColumn ClampLow;
            ClampLow = new DataColumn("Clamp Low", typeof(String));

            DataColumn ClampHigh;
            ClampHigh = new DataColumn("Clamp High", typeof(String));

            DataColumn EngUnits;
            EngUnits = new DataColumn("Eng Units", typeof(String));

            DataColumn Description;
            Description = new DataColumn("Description", typeof(String));

            DataColumn NegateValue;
            NegateValue = new DataColumn("Negate Value", typeof(String));
            // добавим столбцы
            dt.Columns.AddRange(new DataColumn[] { TagName, Address, DataType, RespectDataType,
                ClientAccess, ScanRate, Scaling, RawLow, RawHigh,  ScaledLow, ScaledHigh,
                ScaledDataType, ClampLow, ClampHigh, EngUnits, Description, NegateValue});


            label5.Text = "";
            label4.Text = "";
            label6.Text = "";
            label3.Text = "";
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Clear();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Выберите файл импорта из OPC";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
                textBox1.Text = filepath;
                if (backgroundWorker2.IsBusy != true)
                {
                    backgroundWorker2.RunWorkerAsync();
                }
            }
            
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            // обьявим воркера
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.WorkerReportsProgress = true;
            // объявим парсер
            var parser = new CsvParser();
            int linecount = 0; // счетчик линий в файле
            foreach (var line in parser.Parse(filepath, Encoding.Default))
            {
                if(line[0].ToString() != "Tag Name")
                {
                    DataRow dr = null;
                    dr = dt.NewRow();
                    dr["Tag Name"] = line[0];
                    dr["Address"] = line[1];
                    dr["Data Type"] = line[2];
                    dr["Respect Data Type"] = line[3];
                    dr["Client Access"] = line[4];
                    dr["Scan Rate"] = line[5];
                    dr["Scaling"] = line[6];
                    dr["Raw Low"] = line[7];
                    dr["Raw High"] = line[8];
                    dr["Scaled Low"] = line[9];
                    dr["Scaled High"] = line[10];
                    dr["Scaled Data Type"] = line[11];
                    dr["Clamp Low"] = line[12];
                    dr["Clamp High"] = line[13];
                    dr["Eng Units"] = line[14];
                    dr["Description"] = line[15];
                    dr["Negate Value"] = line[16];

                    //добавляем строку в таблицу
                    dt.Rows.Add(dr);
                    linecount += 1;
                    // передадим на форму состояние
                    worker.ReportProgress(linecount);
                }
                
            }


        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label2.Text = "Строк обработано:" + e.ProgressPercentage.ToString();
        }
        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridView1.DataSource = dt;
            dataGridView1.Update();
            
            label2.Text = "Парсинг завершен!";
        }

        private void button2_Click(object sender, EventArgs e) // импорт в базу
        {
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
        string tagpath;
        string tagadr;
        int countErrStr = 0;
        int countFindStr = 0;
        int countUpdStr = 0;
        int countAllStr = 0;
        //string test;
        int sys_id, gr_id, tag_id;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // обьявим воркера
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.WorkerReportsProgress = true;
            // нужна темповая таблица
            countErrStr = 0;
            countFindStr = 0;
            countUpdStr = 0;
            countAllStr = 0;
            foreach (DataGridViewRow dgdr in dataGridView1.Rows)
            {
          
                tagpath = dgdr.Cells[0].Value.ToString();
                tagadr = dgdr.Cells[1].Value.ToString();
                getDevTagFromFullPathTableAdapter.Fill(rpTagsDataSet1.GetDevTagFromFullPath, tagpath);
                if(rpTagsDataSet1.GetDevTagFromFullPath.Rows.Count == 0)
                {
                    dgdr.DefaultCellStyle.BackColor = Color.Red; // таких строк не найдено
                    countErrStr += 1;
                } 
                else
                {
                    if(rpTagsDataSet1.GetDevTagFromFullPath[0]["AdrPLC"].ToString() == tagadr)
                    {
                        dgdr.DefaultCellStyle.BackColor = Color.Green; // тег уже есть в базе и он совпадает
                        countFindStr += 1;

                    }
                    else
                    {
                        sys_id = Convert.ToInt16(rpTagsDataSet1.GetDevTagFromFullPath[0]["Sys_id"]);
                        gr_id = Convert.ToInt16(rpTagsDataSet1.GetDevTagFromFullPath[0]["Gr_id"]);
                        tag_id = Convert.ToInt16(rpTagsDataSet1.GetDevTagFromFullPath[0]["Tag_id"]);
                        rpTagsDataSet1.GetDevTagFromFullPath[0]["AdrPLC"] = tagadr;
                        getDevTagFromFullPathTableAdapter.Update(rpTagsDataSet1.GetDevTagFromFullPath);
                        dgdr.DefaultCellStyle.BackColor = Color.Yellow;
                        countUpdStr += 1;
                    }
                }

                countAllStr += 1; // отметим пройдеую строку, передадим её в progchanged
                
                worker.ReportProgress(countAllStr);
               // dgdr.DefaultCellStyle.BackColor = Color.Red;           ----- цвет фона
            }

        }

        

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label3.Text = "Строк обработано: "+ e.ProgressPercentage.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label5.Text = "ОТСУТСТВУЮТ В БД: "+ countErrStr + " (помечены красным)";
            label4.Text = "Не потребовали обновления: "+ countFindStr + " (помечены зеленым)";
            label6.Text = "Добавлены/Обновлены: "+ countUpdStr + " (помечены желтым)";
            label3.Text = "Обработка завершена.";
        }

        private void importOPC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker1.IsBusy == true)
            {
                backgroundWorker1.CancelAsync();
            }

        }
    }

    public class CsvParser
    {
        public char separator = ',';
        public char quote = '"';

        public IEnumerable<string> ReadLines(string fileName, Encoding enc)
        {
            using (StreamReader sr = new StreamReader(fileName, enc))
                while (sr.Peek() >= 0)
                    yield return sr.ReadLine();
        }

        public static char AutoDetectSeparator(string fileName, Encoding enc)
        {
            fileName = fileName.Split(';')[0];
            using (StreamReader sr = new StreamReader(fileName, enc))
                while (sr.Peek() >= 0)
                {
                    var s = sr.ReadLine();
                    //если есть табуляции - скорее всего это и есть разделитель
                    if (s.Contains("\t")) return '\t';
                    //считаем число запятых и точек с запятыми
                    int semicolonCount = 0;
                    int commaCount = 0;
                    foreach (char c in s)
                        if (c == ';') semicolonCount++;
                        else
                            if (c == ',') commaCount++;
                    //точек с запятыми больше чем запятых
                    if (semicolonCount > commaCount) return ';';
                    return ',';
                }

            return ',';
        }

        public IEnumerable<List<string>> Parse(string fileName, Encoding enc)
        {
            foreach (var line in Parse(ReadLines(fileName, enc)))
                yield return line;
        }

        public IEnumerable<List<string>> Parse(IEnumerable<string> lines)
        {
            var e = lines.GetEnumerator();
            while (e.MoveNext())
                yield return ParseLine(e);
        }

        private List<string> ParseLine(IEnumerator<string> e)
        {
            var items = new List<string>();
            foreach (string token in GetToken(e))
                items.Add(token);
            return items;
        }

        private IEnumerable<string> GetToken(IEnumerator<string> e)
        {
            string token = "";
            State state = State.outQuote;

            again:
            foreach (char c in e.Current)
                switch (state)
                {
                    case State.outQuote:
                        if (c == separator)
                        {
                            yield return token;
                            token = "";
                        }
                        else
                            if (c == quote)
                            state = State.inQuote;
                        else
                            token += c;
                        break;
                    case State.inQuote:
                        if (c == quote)
                            state = State.mayBeOutQuote;
                        else
                            token += c;
                        break;
                    case State.mayBeOutQuote:
                        if (c == quote)
                        {
                            //кавычки внутри кавычек
                            state = State.inQuote;
                            token += c;
                        }
                        else
                        {
                            state = State.outQuote;
                            goto case State.outQuote;
                        }
                        break;
                }

            //разрыв строки внутри кавычек
            if (state == State.inQuote && e.MoveNext())
            {
                token += Environment.NewLine;
                goto again;
            }

            yield return token;
        }

        enum State { outQuote, inQuote, mayBeOutQuote }
    }
}
