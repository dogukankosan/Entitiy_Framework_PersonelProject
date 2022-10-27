
namespace FormStudent.Forms
{
    partial class frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Txt_Tc = new DevExpress.XtraEditors.TextEdit();
            this.Txt_NameSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Msk_Phone = new System.Windows.Forms.MaskedTextBox();
            this.Rch_Adress = new System.Windows.Forms.RichTextBox();
            this.Txt_Email = new DevExpress.XtraEditors.TextEdit();
            this.Btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Tc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NameSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Email.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(429, 249);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Txt_Tc
            // 
            this.Txt_Tc.Location = new System.Drawing.Point(81, 12);
            this.Txt_Tc.Name = "Txt_Tc";
            this.Txt_Tc.Properties.MaxLength = 11;
            this.Txt_Tc.Size = new System.Drawing.Size(145, 20);
            this.Txt_Tc.TabIndex = 0;
            this.Txt_Tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Tc_KeyPress);
            // 
            // Txt_NameSurname
            // 
            this.Txt_NameSurname.Location = new System.Drawing.Point(81, 40);
            this.Txt_NameSurname.Name = "Txt_NameSurname";
            this.Txt_NameSurname.Properties.MaxLength = 50;
            this.Txt_NameSurname.Size = new System.Drawing.Size(145, 20);
            this.Txt_NameSurname.TabIndex = 1;
            this.Txt_NameSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NameSurname_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(13, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "TC";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "AD SOYAD";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 69);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "TELEFON";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 123);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "ADRES";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 96);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "E-MAİL";
            // 
            // Msk_Phone
            // 
            this.Msk_Phone.Location = new System.Drawing.Point(81, 68);
            this.Msk_Phone.Mask = "(999)000-0000";
            this.Msk_Phone.Name = "Msk_Phone";
            this.Msk_Phone.Size = new System.Drawing.Size(145, 20);
            this.Msk_Phone.TabIndex = 2;
            // 
            // Rch_Adress
            // 
            this.Rch_Adress.Location = new System.Drawing.Point(81, 124);
            this.Rch_Adress.MaxLength = 50;
            this.Rch_Adress.Name = "Rch_Adress";
            this.Rch_Adress.Size = new System.Drawing.Size(145, 54);
            this.Rch_Adress.TabIndex = 4;
            this.Rch_Adress.Text = "";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(81, 96);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Properties.MaxLength = 50;
            this.Txt_Email.Size = new System.Drawing.Size(145, 20);
            this.Txt_Email.TabIndex = 3;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Appearance.BackColor = System.Drawing.Color.Green;
            this.Btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Btn_Save.Appearance.Options.UseBackColor = true;
            this.Btn_Save.Appearance.Options.UseFont = true;
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Save.Location = new System.Drawing.Point(368, 0);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(61, 186);
            this.Btn_Save.TabIndex = 6;
            this.Btn_Save.Text = "EKLE";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Appearance.BackColor = System.Drawing.Color.Blue;
            this.Btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Btn_Update.Appearance.Options.UseBackColor = true;
            this.Btn_Update.Appearance.Options.UseFont = true;
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Update.Location = new System.Drawing.Point(295, 0);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(73, 186);
            this.Btn_Update.TabIndex = 5;
            this.Btn_Update.Text = "GÜNCELLE";
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sİLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(90, 26);
            // 
            // sİLToolStripMenuItem
            // 
            this.sİLToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sİLToolStripMenuItem.Image")));
            this.sİLToolStripMenuItem.Name = "sİLToolStripMenuItem";
            this.sİLToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.sİLToolStripMenuItem.Text = "SİL";
            this.sİLToolStripMenuItem.Click += new System.EventHandler(this.sİLToolStripMenuItem_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.Btn_Clear.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Btn_Clear.Appearance.Options.UseBackColor = true;
            this.Btn_Clear.Appearance.Options.UseFont = true;
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Clear.Location = new System.Drawing.Point(232, 0);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(63, 186);
            this.Btn_Clear.TabIndex = 13;
            this.Btn_Clear.Text = "TEMİZLE";
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(429, 435);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Rch_Adress);
            this.Controls.Add(this.Msk_Phone);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Txt_NameSurname);
            this.Controls.Add(this.Txt_Tc);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Tc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NameSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Email.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.TextEdit Txt_Tc;
        private DevExpress.XtraEditors.TextEdit Txt_NameSurname;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.MaskedTextBox Msk_Phone;
        private System.Windows.Forms.RichTextBox Rch_Adress;
        private DevExpress.XtraEditors.TextEdit Txt_Email;
        private DevExpress.XtraEditors.SimpleButton Btn_Save;
        private DevExpress.XtraEditors.SimpleButton Btn_Update;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sİLToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton Btn_Clear;
    }
}