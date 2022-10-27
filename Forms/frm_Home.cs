using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using CRUD = FormStudent.EFClass.CRUD;

namespace FormStudent.Forms
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }
        void Clear()
        {
            foreach (Control item in Controls)
            {
                if (item is TextEdit || item is MaskedTextBox || item is RichTextBox)
                {
                    item.Text = string.Empty;
                    Txt_Tc.Focus();
                }
            }
        }
        private void Txt_Tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void Txt_NameSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                                                  && !char.IsSeparator(e.KeyChar);
        }
        private void frm_Home_Load(object sender, EventArgs e)
        {
            CRUD.List(dataGridView1);
        }
        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells["ID"].Value as string))
            {
                CRUD.Delete((byte)dataGridView1.CurrentRow.Cells["ID"].Value);
                CRUD.List(dataGridView1);
                Clear();
            }
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (EFClass.CRUD.Control(Txt_Tc, Txt_NameSurname, Msk_Phone, Txt_Email, Rch_Adress))
            {
                if (CRUD.Add(Txt_Tc, Txt_NameSurname, Msk_Phone, Txt_Email, Rch_Adress))
                {
                    Clear();
                    CRUD.List(dataGridView1);
                }
            }
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (EFClass.CRUD.Control(Txt_Tc, Txt_NameSurname, Msk_Phone, Txt_Email, Rch_Adress))
            {
                if (string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value as string))
                {
                    if (CRUD.Update(Txt_Tc, Txt_NameSurname, Msk_Phone, Txt_Email, Rch_Adress,
                        (byte)dataGridView1.CurrentRow.Cells["ID"].Value))
                    {
                        Clear();
                        CRUD.List(dataGridView1);
                    }
                }
            }
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Txt_Tc.Text = dataGridView1.CurrentRow.Cells["TC"].Value as string;
            Txt_NameSurname.Text = dataGridView1.CurrentRow.Cells["ADSOYAD"].Value as string;
            Msk_Phone.Text = dataGridView1.CurrentRow.Cells["TELEFON"].Value as string;
            Rch_Adress.Text = dataGridView1.CurrentRow.Cells["ADRES"].Value as string;
            Txt_Email.Text = dataGridView1.CurrentRow.Cells["E_MAIL"].Value as string;
        }
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}