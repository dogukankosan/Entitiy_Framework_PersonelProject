using DevExpress.XtraEditors;
using FormStudent.EF_DB;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FormStudent.EFClass
{
    internal class CRUD
    {
        internal static void List(DataGridView data)
        {
            data.DataSource = (from x in Connection.db.tbl_User
                               select new
                               {
                                   x.ID,
                                   x.TC,
                                   ADSOYAD = x.NAME_SURNAME,
                                   TELEFON = x.PHONE,
                                   ADRES = x.ADRESS,
                                   x.E_MAIL
                               }).OrderBy(x => x.ID).ToList();
        }
        internal static bool Control(TextEdit Tc, TextEdit NameSurname, MaskedTextBox Phone, TextEdit E_Mail, RichTextBox Adress)
        {
            #region TCCONTROL
            // IS NULL OR EMPTY
            if (string.IsNullOrEmpty(Tc.Text))
            {
                XtraMessageBox.Show("TC KISMI BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Tc.Focus();
                return false;
            }
            // TC LENGTH
            if (Tc.Text.Length < 11)
            {
                XtraMessageBox.Show("TC METİN KUTUSU 11 HANEDEN KÜÇÜK OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Tc.Text = string.Empty;
                Tc.Focus();
                return false;
            }
            //IS NUMBER CONTROL
            for (byte i = 0; i < Tc.Text.Length; i++)
            {
                if (!char.IsNumber(Tc.Text[i]))
                {
                    XtraMessageBox.Show("TC KISMINA SADECE RAKAM GİRİŞİ YAPINIZ !!", "HATALI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    Tc.Text = string.Empty;
                    Tc.Focus();
                    return false;
                }
            }
            #endregion
            #region NAMESURNAMECONTROL
            // IS NULL OR EMPTY
            if (string.IsNullOrEmpty(NameSurname.Text))
            {
                XtraMessageBox.Show("AD SOYAD KISMI BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                NameSurname.Focus();
                return false;
            }
            //IS NUMBER CONTROL
            for (byte i = 0; i < NameSurname.Text.Length; i++)
            {
                if (char.IsNumber(NameSurname.Text[i]))
                {
                    XtraMessageBox.Show("AD SOYAD KISMINA SADECE HARF GİRİŞİ YAPINIZ !!", "HATALI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    NameSurname.Text = string.Empty;
                    NameSurname.Focus();
                    return false;
                }
            }
            if (NameSurname.Text.Length < 5)
            {
                XtraMessageBox.Show("AD SOYAD ALANI ÇOK KISA AD SOYADI DOĞRU YAZINIZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameSurname.Text = string.Empty;
                NameSurname.Focus();
                return false;
            }
            #endregion
            #region PHONE
            if (Phone.Text.Length < 13)
            {
                XtraMessageBox.Show("TELEFONU TAMAMEN DOLDURUNUZ", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Phone.Focus();
                return false;
            }
            #endregion
            #region EMAILCONTNROL
            // IS NULL OR EMPTY
            if (string.IsNullOrEmpty(E_Mail.Text))
            {
                XtraMessageBox.Show("E-MAİL KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                E_Mail.Focus();
                return false;
            }

            if (!E_Mail.Text.Contains("@"))
            {
                XtraMessageBox.Show("MAİL FORMATI GEÇERSİZ TEKRAR GİRİŞİ YAPINIZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                E_Mail.Focus();
                E_Mail.Text = string.Empty;
                return false;
            }
            // MAIL LENGTH 
            if (E_Mail.Text.Length < 5)
            {
                XtraMessageBox.Show("E-MAİL KUTUSU GİRİLEN MAİL ÇOK KISA LÜTFEN TEKRAR GİRİNİZ !!", "HATALI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                E_Mail.Focus();
                return false;
            }
            #endregion
            #region ADRESCONTROL
            // IS NULL OR EMPTY
            if (string.IsNullOrEmpty(Adress.Text))
            {
                XtraMessageBox.Show("ADRES METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Adress.Focus();
                return false;
            }
            // LENGTH CONTROL
            if (Adress.Text.Length < 8)
            {
                XtraMessageBox.Show("ADRES METİN KUTUSU GİRİLEN ADRES ÇOK KISA LÜTFEN TEKRAR GİRİNİZ !!", "HATALI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Adress.Focus();
                return false;
            }
            #endregion
            return true;
        }
        internal static bool Add(TextEdit Tc, TextEdit NameSurname, MaskedTextBox Phone, TextEdit E_Mail, RichTextBox Adress)
        {
            if (DialogResult.Yes == XtraMessageBox.Show("EKLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "EKLEME İŞLEMİ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                tbl_User dTblUser = new();
                try
                {
                    dTblUser.TC = Tc.Text;
                    dTblUser.NAME_SURNAME = NameSurname.Text;
                    dTblUser.PHONE = Phone.Text;
                    dTblUser.E_MAIL = E_Mail.Text;
                    dTblUser.ADRESS = Adress.Text;
                    Connection.db.tbl_User.Add(dTblUser);
                    Connection.db.SaveChanges();
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show(e.Message, "BAŞARISIZ", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return false;
                }
                XtraMessageBox.Show("EKLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        internal static bool Update(TextEdit Tc, TextEdit NameSurname, MaskedTextBox Phone, TextEdit E_Mail, RichTextBox Adress, byte? ID)
        {
            if (ID is null)
                return false;
            if (DialogResult.Yes == XtraMessageBox.Show("SEÇİLİ KAYDI GÜNCELLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "GÜNCELLEME İŞLEMİ", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question))
            {
                tbl_User dTblUser = Connection.db.tbl_User.Find(ID);
                try
                {
                    dTblUser.TC = Tc.Text;
                    dTblUser.NAME_SURNAME = NameSurname.Text;
                    dTblUser.PHONE = Phone.Text;
                    dTblUser.E_MAIL = E_Mail.Text;
                    dTblUser.ADRESS = Adress.Text;
                    Connection.db.SaveChanges();
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show(e.Message, "BAŞARISIZ", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return false;
                }
                XtraMessageBox.Show("GÜNCELLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        internal static bool Delete(byte? ID)
        {
            if (ID is null)
                return false;
            if (DialogResult.Yes == XtraMessageBox.Show("SEÇİLİ KAYDI SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "SİLME İŞLEMİ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                tbl_User dTblUser = Connection.db.tbl_User.Find(ID);
                try
                {
                    Connection.db.tbl_User.Remove(dTblUser);
                    Connection.db.SaveChanges();
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show(e.Message, "BAŞARISIZ", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return false;
                }
                XtraMessageBox.Show("SİLME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}