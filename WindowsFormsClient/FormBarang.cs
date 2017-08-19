using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class FormBarang : Form
    {
        public FormBarang()
        {
            InitializeComponent();
        }
        private bool baru = false;
        private string kodeLama;
        private Tabel barang = new Tabel("barang");

        private void setkodeLama(string kodelama)
        {
            kodeLama = kodelama;
        }
        private string getkodeLama()
        {
            return this.kodeLama;
        }

        private void modeEdit()
        {
            TxtkodeBarang.Enabled = true;
            TxtnamaBarang.Enabled = true;
            TxthargaBeli.Enabled = true;
            TxthargaJual.Enabled = true;
            Txtstok.Enabled = true;
            Cmbsatuan.Enabled = true;
            BtnTop.Enabled = false;
            BtnBack.Enabled = false;
            BtnNext.Enabled = false;
            BtnEnd.Enabled = false;
            BtnPrint.Enabled = false;
            BtnFind.Enabled = false;
            BtnNew.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSave.Visible = true; //<-- visible-nya
            BtnUndo.Visible = true; //<-- visible-nya
            BtnSave.Enabled = true;
            BtnUndo.Enabled = true;
            BtnDel.Enabled = false;
            BtnClose.Enabled = false;
            TxtkodeBarang.Focus();
            lepas();
        }

        private void modeSave()
        {
            TxtkodeBarang.Enabled = false;
            TxtnamaBarang.Enabled = false;
            TxthargaBeli.Enabled = false;
            TxthargaJual.Enabled = false;
            Txtstok.Enabled = false;
            Cmbsatuan.Enabled = false;
            BtnTop.Enabled = true;
            BtnBack.Enabled = true;
            BtnNext.Enabled = true;
            BtnEnd.Enabled = true;
            BtnPrint.Enabled = true;
            BtnFind.Enabled = true;
            BtnNew.Enabled = true;
            BtnEdit.Enabled = true;
            BtnSave.Visible = false; //<-- visible-nya
            BtnUndo.Visible = false; //<-- visible-nya
            BtnSave.Enabled = false;
            BtnUndo.Enabled = false;
            BtnDel.Enabled = true;
            BtnClose.Enabled = true;
            ikat();
        }

        private void ikat()
        {
            TxtkodeBarang.DataBindings.Add("Text", barang.getBs(), "kodeBarang");
            TxtnamaBarang.DataBindings.Add("Text", barang.getBs(), "namaBarang");
            TxthargaBeli.DataBindings.Add("Text", barang.getBs(), "hargaBeli");
            TxthargaJual.DataBindings.Add("Text", barang.getBs(), "hargaJual");
            Txtstok.DataBindings.Add("Text", barang.getBs(), "stok");
            Cmbsatuan.DataBindings.Add("Text", barang.getBs(), "satuan");
        }

        private void lepas()
        {
            TxtkodeBarang.DataBindings.Clear();
            TxtnamaBarang.DataBindings.Clear();
            TxthargaBeli.DataBindings.Clear();
            TxthargaJual.DataBindings.Clear();
            Txtstok.DataBindings.Clear();
            Cmbsatuan.DataBindings.Clear();
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            DgvBarang.DataSource = this.barang.getBs();
            modeSave();
        }

        private void BtnTop_Click(object sender, EventArgs e)
        {
            this.barang.getBs().MoveFirst();            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.barang.getBs().MovePrevious();            
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.barang.getBs().MoveNext();            
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            this.barang.getBs().MoveLast();            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string stringSQL, kode, nama, beli, jual, stok, satuan;
            kode = TxtkodeBarang.Text;
            nama = TxtnamaBarang.Text;
            beli = TxthargaBeli.Text;
            jual = TxthargaJual.Text;
            stok = Txtstok.Text;
            satuan = Cmbsatuan.Text;

            if (baru)
            {
                stringSQL = "INSERT INTO barang VALUES('{0}','{1}','{2}','{3}',";
                stringSQL += "'{4}','{5}')";
                stringSQL = String.Format(stringSQL, kode, nama, beli, jual,
                    stok, satuan);
            }
            else
            {
                stringSQL = "UPDATE barang SET kodeBarang='{0}', namaBarang='{1}', ";
                stringSQL += "hargaBeli='{2}', hargaJual='{3}', stok='{4}', ";
                stringSQL += "satuan='{5}' WHERE kodeBarang='{6}'";
                stringSQL = String.Format(stringSQL, kode, nama, beli, jual, stok,
                    satuan, getkodeLama());
            }
            MessageBox.Show("Periksa dulu : " + stringSQL);
            this.barang.eksekusiSQL(stringSQL);
            modeSave();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult jawab;
            jawab = MessageBox.Show("Apakah Anda yakin menghapus data ini?", "konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == System.Windows.Forms.DialogResult.Yes)
            {
                string stringSQL = "DELETE FROM barang WHERE kodeBarang='{0}'";
                stringSQL = string.Format(stringSQL, TxtkodeBarang.Text);
                MessageBox.Show("Periksa dulu : " + stringSQL);
                this.barang.eksekusiSQL(stringSQL);
                MessageBox.Show("Penghapusan selesai dilaksanakan..."); //<-- feedback
            }
            else
            {
                MessageBox.Show("Penghapusan dibatalkan..."); //<-- feedback
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getkodeLama());
            baru = true;
            modeEdit();
            hapus();
            //String strsql, kode, nama, hbeli, hjual, stok, satuan;
            //kode = TxtkodeBarang.Text;
            //nama = TxtnamaBarang.Text;
            //hbeli = TxthargaBeli.Text;
            //hjual = TxthargaJual.Text;
            //stok = Txtstok.Text;
            //satuan = Cmbsatuan.Text;
            //strsql = "insert into barang (kodeBarang, namaBarang, hargaBeli, hargaJual, stok, satuan) " +
            //    "values('{0}','{1}','{2}','{3}','{4}','{5}')";
            //strsql = String.Format(strsql, kode, nama, hbeli, hjual, stok, satuan);
            //barang.eksekusiSQL(strsql);
            
        }

        //sampai delete tapi stuck karena ada foreign key noNota di tabel itemNotaBeli sedangkan yg dihapus
        //ada di notabeli
        //sudah diatasi dengan cascade.

        private void hapus()
        {
            TxthargaBeli.Text = "";
            TxthargaJual.Text = "";
            TxtkodeBarang.Text = "";
            TxtnamaBarang.Text = "";
            Txtstok.Text = "";
            Cmbsatuan.Text = "";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            modeSave();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            FormCariBarang cari = new FormCariBarang();
            cari.caribarang = true;
            cari.ShowDialog();
            //barang.getBs().Position = cari.index();
            //barang.get
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            setkodeLama(TxtkodeBarang.Text);
            modeEdit();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            LaporanStok cetak = new LaporanStok();
            cetak.ShowDialog();
            cetak.Dispose();
        }

        //kurang nampilin stok waktu btnFind. Mungkin bisa pake form baru atau pengaturan column di 
        //formcaribarang diganti2 ini lagi nyari caranya.
        //sudah bisa.
    }
}
