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
    public partial class TagChange : Form
    {
        int TAG_ID = 0;
        DataTable temp_dt = new DataTable("temp_dt");
        public TagChange()
        {
            InitializeComponent();
        }


        private void TagChange_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.Filtres". При необходимости она может быть перемещена или удалена.
            this.filtresTableAdapter.Fill(this.rPTagsDataSet.Filtres);
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet1.Gruptype". При необходимости она может быть перемещена или удалена.
                this.gruptypeTableAdapter.Fill(this.rPTagsDataSet1.Gruptype);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet1.TagType". При необходимости она может быть перемещена или удалена.
            this.tagTypeTableAdapter.Fill(this.rPTagsDataSet1.TagType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rPTagsDataSet.Tag". При необходимости она может быть перемещена или удалена.
            //   this.tagTableAdapter.Fill(this.rPTagsDataSet.Tag);


            Form2 main = this.Owner as Form2;
                if (main != null)
                {
                    TAG_ID = main.Send_tag_id();
                    this.Text = main.tag_path();
                }
                if (TAG_ID == 0)
                {
                    rPTagsDataSet.Tag.Clear();
                    this.Text = main.new_tag_path();
                }
                else
                {
                    this.tagTableAdapter.FillById(this.rPTagsDataSet.Tag, TAG_ID);
                }
                
                // установим checkBox

                if (rPTagsDataSet.Tag[0]["HH"].ToString() == "R")
                {
                    checkBox1.Checked = true;
                }
                if (rPTagsDataSet.Tag[0]["UDM_Input"].ToString() == "R")
                {
                    checkBox2.Checked = true;
                }
                if (rPTagsDataSet.Tag[0]["UDM_Output"].ToString() == "W")
                {
                    checkBox3.Checked = true;
                }

                //разрешение для алармов

                if (rPTagsDataSet.Tag[0]["TagType"].ToString() != "3")
                {
                    baseTextTextBox.ReadOnly = true;
                    alarmMSGTextBox.ReadOnly = true;
                    normalMSGTextBox.ReadOnly = true;
                    tLA_MSGTextBox.ReadOnly = true;
                    relatedValue1TextBox.ReadOnly = true;
                    relatedValue3TextBox.ReadOnly = true;
                    relatedValue2TextBox.ReadOnly = true;
                    relatedValue4TextBox.ReadOnly = true;
                    relatedValue5TextBox.ReadOnly = true;

                

                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // чекбокс хайпера
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox2.Enabled = false;
                checkBox3.Checked = false;
                checkBox3.Enabled = false;
                
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                


            }
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
                
            }
            else
            {
                
            }
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
                
            }
            else
            {
                
                
            }
            if (!checkBox2.Checked && !checkBox3.Checked)
            {
                checkBox1.Enabled = true;
            }

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            // для state по умолчанию напрявляем в хайпер
            if (comboBox1.SelectedValue.ToString() == "1")
            {
                checkBox1.Checked = true;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            //для сетов по умолчанию считаем 
            if (comboBox1.SelectedValue.ToString() == "2")
            {
                checkBox1.Checked = false;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
            }
            
            // для алармов по умолчанию считаем
            if (comboBox1.SelectedValue.ToString() == "3")
            {
                checkBox1.Checked = false;
                checkBox2.Checked = true;
                checkBox3.Checked = false;

                baseTextTextBox.ReadOnly = false;
                alarmMSGTextBox.ReadOnly = false;
                normalMSGTextBox.ReadOnly = false;
                relatedValue1TextBox.ReadOnly = false;
                relatedValue3TextBox.ReadOnly = false;
                relatedValue2TextBox.ReadOnly = false;
                relatedValue4TextBox.ReadOnly = false;
                relatedValue5TextBox.ReadOnly = false;
                tLA_MSGTextBox.ReadOnly = false;

            } else
            {
                baseTextTextBox.ReadOnly = true;
                alarmMSGTextBox.ReadOnly = true;
                normalMSGTextBox.ReadOnly = true;
                relatedValue1TextBox.ReadOnly = true;
                relatedValue3TextBox.ReadOnly = true;
                relatedValue2TextBox.ReadOnly = true;
                relatedValue4TextBox.ReadOnly = true;
                relatedValue5TextBox.ReadOnly = true;
                tLA_MSGTextBox.ReadOnly = true;
            }
            // для ACK по умолчанию считаем
            if (comboBox1.SelectedValue.ToString() == "4")
            {
                checkBox1.Checked = false;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
            } 
            
        }

        private void button1_Click(object sender, EventArgs e) // сохранить
        {
            if (TAG_ID != 0) // если изменяем уже существующий тег
            {
                rPTagsDataSet.Tag[0].BeginEdit();
                if (checkBox1.Checked)
                    rPTagsDataSet.Tag[0].HH = "R";
                else rPTagsDataSet.Tag[0].HH = "";
                if (checkBox2.Checked)
                    rPTagsDataSet.Tag[0].UDM_Input = "R";
                else rPTagsDataSet.Tag[0].UDM_Input = "";
                if (checkBox3.Checked)
                    rPTagsDataSet.Tag[0].UDM_Output = "W";
                else rPTagsDataSet.Tag[0].UDM_Output = "";

                rPTagsDataSet.Tag[0].GrupType = Convert.ToInt16(comboBox2.SelectedValue);
                rPTagsDataSet.Tag[0].TagType = Convert.ToInt16(comboBox1.SelectedValue);
                rPTagsDataSet.Tag[0].Filter = Convert.ToInt16(comboBox3.SelectedValue);
                rPTagsDataSet.Tag[0].Name = textBox1.Text.ToString();
                rPTagsDataSet.Tag[0].Description = textBox2.Text.ToString();
                rPTagsDataSet.Tag[0].TType = comboBox1.SelectedText.ToString();
                rPTagsDataSet.Tag[0].BaseText = baseTextTextBox.Text.ToString();
                rPTagsDataSet.Tag[0].AlarmMSG = alarmMSGTextBox.Text.ToString();
                rPTagsDataSet.Tag[0].NormalMSG = normalMSGTextBox.Text.ToString();
                rPTagsDataSet.Tag[0].RelatedValue1 = relatedValue1TextBox.Text.ToString();
                rPTagsDataSet.Tag[0].RelatedValue2 = relatedValue2TextBox.Text.ToString();
                rPTagsDataSet.Tag[0].RelatedValue3 = relatedValue3TextBox.Text.ToString();
                rPTagsDataSet.Tag[0].RelatedValue4 = relatedValue4TextBox.Text.ToString();
                rPTagsDataSet.Tag[0].RelatedValue5 = relatedValue5TextBox.Text.ToString();
                rPTagsDataSet.Tag[0].TLA_MSG = tLA_MSGTextBox.Text.ToString();

                rPTagsDataSet.Tag[0].EndEdit();
                

                tagTableAdapter.Update(rPTagsDataSet.Tag);

                rPTagsDataSet.Tag[0].AcceptChanges();

                if (rPTagsDataSet.Tag.GetChanges() == null)
                {
                    this.Close();
                }


            }
            else
            {
                RPTagsDataSet.TagRow newRow = rPTagsDataSet.Tag.NewTagRow();
                //получим поля
                newRow.GrupType = Convert.ToInt16(comboBox2.SelectedValue);
                newRow.TagType =  Convert.ToInt16(comboBox1.SelectedValue);
                newRow.Filter = Convert.ToInt16(comboBox3.SelectedValue);

                if (checkBox1.Checked)
                    newRow.HH = "R";
                if (checkBox2.Checked)
                    newRow.UDM_Input = "R";
                if (checkBox3.Checked)
                    newRow.UDM_Output = "W";

                newRow.Name = textBox1.Text.ToString();
                newRow.Description = textBox2.Text.ToString();
                newRow.TType = comboBox1.SelectedText.ToString();
                newRow.BaseText = baseTextTextBox.Text.ToString();
                newRow.AlarmMSG = alarmMSGTextBox.Text.ToString();
                newRow.NormalMSG = normalMSGTextBox.Text.ToString();
                newRow.RelatedValue1 = relatedValue1TextBox.Text.ToString();
                newRow.RelatedValue2 = relatedValue2TextBox.Text.ToString();
                newRow.RelatedValue3 = relatedValue3TextBox.Text.ToString();
                newRow.RelatedValue4 = relatedValue4TextBox.Text.ToString();
                newRow.RelatedValue5 = relatedValue5TextBox.Text.ToString();
                newRow.TLA_MSG = tLA_MSGTextBox.Text.ToString();

                // нужно проверить обязательные поля
                if (newRow.Name == "" || newRow.GrupType == 0 || newRow.TagType ==0 || newRow.Filter == 0)
                {
                    string msg = "";
                    if (newRow.Name == "")
                        msg += "Name ";
                    if (newRow.GrupType == 0)
                        msg += "\nGrupType ";
                    if (newRow.TagType == 0)
                        msg += "\nTagType ";
                    if (newRow.Filter == 0)
                        msg += "\nFilter ";
                    MessageBox.Show("Не все обязательные поля заполнены:\n" + msg, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                } else
                {
                    //добавим строку в датасет
                    rPTagsDataSet.Tag.AddTagRow(newRow);
                    // обновим базу
                    tagTableAdapter.Update(rPTagsDataSet.Tag);
                    this.Close();
                }
                
                
                

                /* забытое
                 *
 newRow.GMPT
  newRow.GMPHm
  newRow.GMPCAV
  newRow.GMPVAV
  newRow.GMPDP
  newRow.TLA_MSG
  newRow.Filter
  newRow.GMPW

*/
            }

            
        }

        private void button2_Click(object sender, EventArgs e) // отмена
        {
            
                this.Close();
            

        }
        // подсказки!
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Имя тега, является обязательным параметров фигурирует во всех файлах конфигурации.";
        }

        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Тип тега, является обязательным параметров. Alarm - аварийный параметр, " +
                "State - значение, Set - уставка параметра, ACK - тег квитирования аварии (не применим отдельно от тега Alarm).";
        }

        private void comboBox2_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Тип группы. Определяет принадлежность тега к тому или иному набору.";
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Примечание. Должен содержать краткое описание тега.";
        }

        private void baseTextTextBox_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Базовый текст. Только для Alarm. Содержит описание параметра или устройства для которого возникло аварийное событие.";
        }

        private void alarmMSGTextBox_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Аварийное сообщение. Только для Alarm. Сообщение возникающее при аварии. Дополняет базовый текст.";
        }

        private void normalMSGTextBox_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Сообщение при возвращении параметра в норму. Только для Alarm. Дополняет базовый текст.";
        }

        private void tLA_MSGTextBox_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Только для Alarm. При наличии текста в поле будет сформирован тег контроля изменения уставки для соответствующего аварийнго параметра."+
                " Включенная опция UDM_input формирует TLA событие совместное с Alarm. Отключеная опция формирует отдельный TLA Alarm тег.";
        }

        private void relatedValue1TextBox_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Применяется для описания предельных аварийных событий, например: \"Верхний аварийный предел\".";
        }

        private void relatedValue3TextBox_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Применяется для описание устройства в котором произошла авария.";
        }

        private void comboBox3_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Применяется для тегов с опцией HH.";
        }

        private void checkBox1_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Опция определяет попадание тега в Hyper Historian";
        }

        private void checkBox2_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Опция определяет попадание тега в UDM, и формирование входного тега";
        }

        private void checkBox3_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Опция определяет попадание тега в UDM, и формирование выходного тега";
        }
    }
}
