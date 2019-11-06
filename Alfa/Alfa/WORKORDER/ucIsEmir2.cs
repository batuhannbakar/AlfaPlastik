using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Alfa.BusinessLayer;
using Alfa.DataAccessLayer.EntityFramework;
using Alfa.Entities.Models;

namespace Alfa.WORKORDER
{
    public partial class ucIsEmir2 : UserControl
    {
        ManagerWRKORD managerWRKORD = new ManagerWRKORD();
        ManagerWL_PLAN managerWL_PLAN = new ManagerWL_PLAN();
        ManagerOPERATION managerOPERATION = new ManagerOPERATION();
        ManagerUser managerUser = new ManagerUser();
        ManagerWL_PROCESS managerWL_PROCESS = new ManagerWL_PROCESS();
        ucIsEmir uc1 = new ucIsEmir();
        Ucisemir2Dal dal2 =new Ucisemir2Dal();
        Block ns = new Block();
        UcEmirGor emirGor = new UcEmirGor();
        Alfa.OPERATION.ucOperasyonGor uco = new OPERATION.ucOperasyonGor();
        public ucIsEmir2()
        {
            InitializeComponent();
        }
        #region PLANLAMA AŞAMASI LOAD KISMI
        private void ucIsEmir2_Load(object sender, EventArgs e)
        {
            this.oPERATIONTableAdapter.Fill(this.alfaPlastikDataSet.OPERATION);
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";



            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            comboBox_BakımPersonel.DataSource = managerUser.List();
            comboBox_BakımPersonel.DisplayMember = "NAME";
            comboBox_BakımPersonel.ValueMember = "USERS_ID";
            comboBox_BakımPersonel.Text = null;
            ToolTip tool = new ToolTip();
           
            tool.SetToolTip(button_OK, "KAYDET");
        }
        #endregion
        
      
        #region PLAN TABLOSUNU GÜNCELLEME KISMI
        private void button_OK_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dateTimePicker1.Text) && !string.IsNullOrEmpty(comboBox_BakımPersonel.Text) && !string.IsNullOrEmpty(textBox_saat.Text) && !string.IsNullOrEmpty(richTextBoxYapılacaklarNot.Text))
            {
                if (IsEmriEkle.id != null)

                {
                    WRKORD w = managerWRKORD.Find(x => x.WRKORD_ID == IsEmriEkle.id);//
                    WL_PLAN wL2 = managerWL_PLAN.Find(x => x.WRKID == IsEmriEkle.id);
                    WL_PROCESS wl3 = managerWL_PROCESS.Find(y => y.WRKID == IsEmriEkle.id);
                    
                    wL2.ESTIMATED_START_DATE = dateTimePicker1.Value;
                    wL2.MAINTAIN_PERSON = (int)comboBox_BakımPersonel.SelectedValue;
                    wL2.MAINTAIN_PERSON_NAME = comboBox_BakımPersonel.Text;
                    wL2.PLANNED_TİME = Convert.ToInt16(textBox_saat.Text);
                    wL2.TO_DO_NOTE = richTextBoxYapılacaklarNot.Text;
                    if (checkBox2.Checked == true)
                    {
                        IsEmriEkle.Instance.ucIsEmir31.textBox1.Visible = true;
                        IsEmriEkle.Instance.ucIsEmir31.checkBox2.Visible = true;
                        wl3.OPE1_ID = (int)comboBox1.SelectedValue;
                      
                    }
                    if (checkBox3.Checked == true)
                    {
                        IsEmriEkle.Instance.ucIsEmir31.checkBox3.Visible = true;
                        IsEmriEkle.Instance.ucIsEmir31.textBox2.Visible = true;
                        wl3.OPE2_ID = (int)comboBox2.SelectedValue;
                    }
                    if (checkBox4.Checked == true)
                    {
                        IsEmriEkle.Instance.ucIsEmir31.checkBox4.Visible = true;
                        IsEmriEkle.Instance.ucIsEmir31.textBox3.Visible = true;
                        wl3.OPE3_ID = (int)comboBox3.SelectedValue;
                    }
                    if (checkBox5.Checked == true)
                    {
                        IsEmriEkle.Instance.ucIsEmir31.checkBox5.Visible = true;
                        IsEmriEkle.Instance.ucIsEmir31.textBox4.Visible = true;
                        wl3.OPE4_ID = (int)comboBox4.SelectedValue;
                    }
                    if (checkBox6.Checked == true)
                    {
                        IsEmriEkle.Instance.ucIsEmir31.checkBox6.Visible = true;
                        IsEmriEkle.Instance.ucIsEmir31.textBox5.Visible = true;
                        wl3.OPE5_ID = (int)comboBox5.SelectedValue;
                    }
                    if (checkBox7.Checked == true)
                    {
                        IsEmriEkle.Instance.ucIsEmir31.checkBox7.Visible = true;
                        IsEmriEkle.Instance.ucIsEmir31.textBox6.Visible = true;
                        wl3.OPE6_ID = (int)comboBox6.SelectedValue;
                    }
                    if (checkBox8.Checked == true)
                    {
                        IsEmriEkle.Instance.ucIsEmir31.checkBox8.Visible = true;
                        IsEmriEkle.Instance.ucIsEmir31.textBox7.Visible = true;
                        wl3.OPE7_ID = (int)comboBox7.SelectedValue;
                    }
                    if (checkBox9.Checked == true)
                    {
                        IsEmriEkle.Instance.ucIsEmir31.checkBox9.Visible = true;
                        IsEmriEkle.Instance.ucIsEmir31.textBox8.Visible = true;

                        wl3.OPE8_ID = (int)comboBox8.SelectedValue;
                    }
                  
                    int sonuc = managerWL_PLAN.Update(wL2);
                    managerWL_PROCESS.Update(wl3);
                    managerWRKORD.Update(w);
                    if (sonuc > 0)
                    {
                      
                        MessageBox.Show("Kayıt Eklendi");
                        emirGor.Listele();
                        IsEmriEkle.Instance.button_PROSES.BackColor = Color.Gold;
                        IsEmriEkle.Instance.button_PROSES.Enabled = true;

                        IsEmriEkle.Instance.ucIsEmir31.richTextBox_yapilacak.Text = richTextBoxYapılacaklarNot.Text;

                    }
                    else
                        MessageBox.Show("Hata Meydana Geldi");

                }
                else

                    MessageBox.Show("Boş Alan Bırakılamaz");
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            }
            #endregion
        }

        private void comboBox_BakımPersonel_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.IntOrStringNo(e);
        }

        private void textBox_saat_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.StringNo(e);
        }

       
    }
}


