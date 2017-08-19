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
    public partial class FormNotaBeli : Form
    {
        Tabel master = new Tabel("masterbeli");
        Tabel detail = new Tabel("detailbeli");
        Tabel barang = new Tabel("barang");

        public FormNotaBeli()
        {
            InitializeComponent();
        }

        private void tampil()
        {
            detail.getBs().Filter = "noNotaBeli=" + TxtNoNotaBeli.Text;
            int total = 0, baris;
            for (baris = 0; baris < DgvDetailBeli.Rows.Count; baris++)
            {
                total += int.Parse(DgvDetailBeli.Rows[baris].Cells[6].Value.ToString());
            }
            TxtTotal.Text = total.ToString("#,###");
        }

        private void ikat()
        {
            TxtNoNotaBeli.DataBindings.Add("Text", master.getBs(), "noNotaBeli");
            TxtTanggal.DataBindings.Add("Text", master.getBs(), "tanggal");
            TxtKodeSupplier.DataBindings.Add("Text", master.getBs(), "kodeSupplier");
            TxtNamaSupplier.DataBindings.Add("Text", master.getBs(), "namaSupplier");
            TxtAlamat.DataBindings.Add("Text", master.getBs(), "alamat");
            TxtTelpon.DataBindings.Add("Text", master.getBs(), "telpon");
            TxtKota.DataBindings.Add("Text", master.getBs(), "kota");
            DgvDetailBeli.DataSource = detail.getBs();
            tampil();
        }

        private void modeEdit()
        {
            DgvDetailBeli.Height = 124;
            DgvDetailBeli.Top = 196;
            TxtKodeSupplier.Focus();
            TxtKodeSupplier.Enabled = true;
            BtnTop.Enabled = false;
            BtnBack.Enabled = false;
            BtnNext.Enabled = false;
            BtnEnd.Enabled = false;
            //BtnPrint.Enabled = false;
            BtnFind.Enabled = false;
            BtnNew.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSave.Visible = true; //<-- visible-nya
            BtnUndo.Visible = true; //<-- visible-nya
            BtnDel.Enabled = false;
            BtnClose.Enabled = false;
        }

        private void modeSave()
        {
            DgvDetailBeli.Height = 199;
            DgvDetailBeli.Top = 121;
            BtnTop.Enabled = true;
            BtnBack.Enabled = true;
            BtnNext.Enabled = true;
            BtnEnd.Enabled = true;
            //BtnPrint.Enabled = true;
            BtnFind.Enabled = true;
            BtnNew.Enabled = true;
            BtnEdit.Enabled = true;
            BtnSave.Visible = false; //<-- visible-nya
            BtnUndo.Visible = false; //<-- visible-nya
            BtnDel.Enabled = true;
            BtnClose.Enabled = true;
            TxtKodeSupplier.Enabled = false;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            modeEdit();
            String strsql = "insert into notabeli(tanggal) values ('" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            String noNotaBaru = master.eksekusiSQL_getID(strsql);
            int posisi = master.getBs().Find("nonotabeli", noNotaBaru);
            master.getBs().Position = posisi;
            tampil();
            modeEdit();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            modeSave();
            tampil();
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            modeSave();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            modeEdit();
        }

        private void FormNotaBeli_Load(object sender, EventArgs e)
        {
            ikat();
        }

        private void BtnTop_Click(object sender, EventArgs e)
        {
            master.getBs().MoveFirst();
            tampil();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            master.getBs().MovePrevious();
            tampil();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            master.getBs().MoveNext();
            tampil();
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            master.getBs().MoveLast();
            tampil();
        }

        private void hapus()
        {
            TxtKodeBarang.Text = "";
            TxtNamaBarang.Text = "";
            txtQty.Text = "0";
            TxtHarga.Text = "0";
            TxtJumlah.Text = "0";
            TxtKodeBarang.Focus();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtKodeBarang_Validated(object sender, EventArgs e)
        {
            if (TxtKodeBarang.Text.Length > 0)
            {
                int baris = barang.getBs().Find("kodeBarang", TxtKodeBarang.Text);
                if (baris >= 0)
                {
                    barang.getBs().Position = baris;
                    TxtNamaBarang.Text = ((DataRowView)barang.getBs().Current).Row["namaBarang"].ToString();
                    TxtHarga.Text = ((DataRowView)barang.getBs().Current).Row["hargaBeli"].ToString();
                    txtQty.Focus();
                }
                else
                {
                    MessageBox.Show("Kode barang tidak ditemukan");
                    hapus();
                }
            }
        }

        private void TxtKodeSupplier_Validated(object sender, EventArgs e)
        {
            Tabel supplier = new Tabel("supplier");
            String strsql;
            String noMulaMula = TxtNoNotaBeli.Text;
            int barisketemu = supplier.getBs().Find("kodeSupplier", TxtKodeSupplier.Text);
            if (barisketemu >= 0)
            {
                strsql = "update notaBeli set kodeSupplier='{0}' where noNotaBeli='{1}'";
                strsql = String.Format(strsql, TxtKodeSupplier.Text, noMulaMula);
                TxtKodeBarang.Focus();
            }
            else
            {
                MessageBox.Show("Kode: " + TxtKodeSupplier.Text + " tidak ditemukan");
                TxtKodeSupplier.Text = "";
                strsql = "update notabeli set kodesupllier=NULL where nonotabeli='{1}'";
                strsql = String.Format(strsql, noMulaMula);
                TxtKodeSupplier.Focus();
            }
            master.eksekusiSQL(strsql);
            int baris = master.getBs().Find("nonotabeli", noMulaMula);
            master.getBs().Position = baris;
        }
        private void TxtKodeBarang_KeyUp(object sender, KeyEventArgs e)
        {
            if (TxtKodeBarang.Text.Length == 5)
            {
                txtQty.Focus();
            }
        }

        private void TxtKodeBarang_Leave(object sender, EventArgs e)
        {
            if (TxtKodeBarang.Text.Length == 5)
            {
                txtQty.Focus();
            }
        }

        private void txtQty_Validated(object sender, EventArgs e)
        {
            TxtJumlah.Text = (int.Parse(txtQty.Text) * int.Parse(TxtHarga.Text)).ToString();
            TxtHarga.Focus();
        }

        private void TxtHarga_Validated(object sender, EventArgs e)
        {
            TxtJumlah.Text = (int.Parse(txtQty.Text) * int.Parse(TxtHarga.Text)).ToString();
            TxtJumlah.Focus();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void TxtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            TxtJumlah.Focus();
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtQty.Text.Length > 0)
            {
                if (e.KeyData == Keys.Enter && int.Parse(txtQty.Text) > 0)
                {
                    TxtHarga.Focus();
                }
            }
        }

        private void TxtHarga_KeyDown(object sender, KeyEventArgs e)
        {
            if (TxtHarga.Text.Length > 0)
            {
                if (e.KeyData == Keys.Enter && int.Parse(TxtHarga.Text) > 0)
                {
                    TxtHarga.Focus();
                    TxtJumlah.Focus();
                }
            }
        }

        private void TxtJumlah_KeyDown(object sender, KeyEventArgs e)
        {
            if (TxtJumlah.Text.Length > 0)
            {
                if (e.KeyData == Keys.Enter && int.Parse(TxtJumlah.Text) > 0 && TxtKodeBarang.Text.Length == 5)
                {
                    String strsql, noNotaBeli, kodeBarang, qty, harga;
                    noNotaBeli = TxtNoNotaBeli.Text;
                    kodeBarang = TxtKodeBarang.Text;
                    qty = txtQty.Text;
                    harga = TxtHarga.Text;
                    strsql = "insert into itemNotaBeli(noNotaBeli, kodeBarang, qty, harga) " +
                        "values('{0}','{1}','{2}','{3}')";
                    strsql = String.Format(strsql, noNotaBeli, kodeBarang, qty, harga);
                    detail.eksekusiSQL(strsql);
                    hapus();
                }
                tampil();
            }
        }

        private void DgvDetailBeli_KeyDown(object sender, KeyEventArgs e)
        {
            int baris = DgvDetailBeli.SelectedCells[0].RowIndex;
            if (e.KeyData == Keys.Back)
            {
                modeEdit();
                TxtKodeBarang.Text = DgvDetailBeli.Rows[baris].Cells[2].Value.ToString();
                TxtNamaBarang.Text = DgvDetailBeli.Rows[baris].Cells[3].Value.ToString();
                txtQty.Text = DgvDetailBeli.Rows[baris].Cells[4].Value.ToString();
                TxtHarga.Text = DgvDetailBeli.Rows[baris].Cells[5].Value.ToString();
                TxtJumlah.Text = DgvDetailBeli.Rows[baris].Cells[6].Value.ToString();
                
                TxtKodeBarang.Focus();
            }
            if (e.KeyData == Keys.Back || e.KeyData == Keys.Delete)
            {
                String idnotabeli = DgvDetailBeli.Rows[baris].Cells[0].Value.ToString();
                String strsql = "delete from itemNotaBeli where idNotaBeli=" + idnotabeli;
                detail.eksekusiSQL(strsql);
            }
            tampil();
        }

        private void TxtKodeSupplier_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || TxtKodeSupplier.Text.Length == 3)
            {
                TxtKodeBarang.Focus();
            }
            
        }

        private void TxtKodeSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 16)
            {
                FormCariSupplier cari = new FormCariSupplier();
                cari.ShowDialog();
                string a = cari.getKode();
                TxtKodeSupplier.Text = a;
                TxtKodeBarang.Focus();
            }
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            cmbNonota.Visible = true;
            master.getBs().MoveFirst();
            String nomor = "";
            cmbNonota.Items.Clear();
            for (int x = 0; x < master.getBs().Count; x++)
            {
                nomor = ((DataRowView)master.getBs().Current).Row["noNotaBeli"].ToString();
                cmbNonota.Items.Add(nomor);
                master.getBs().MoveNext();
            }
            //cmbNonota.Text = nomor;
            
        }


        private void cmbNonota_SelectedValueChanged(object sender, EventArgs e)
        {
            int brs = master.getBs().Find("nonotabeli", cmbNonota.Text);
            master.getBs().Position = brs;
            cmbNonota.Visible = false;
            tampil();
            
        }

        private void TxtKodeBarang_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyValue == 16)
                {
                    FormCariBarang cari = new FormCariBarang();
                    cari.ShowDialog();
                    TxtKodeBarang.Text = cari.getKode().ToString();
                }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult jawab;
            jawab = MessageBox.Show("Yakin mau hapus nota beli nomer: " + TxtNoNotaBeli.Text + "?", "konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == System.Windows.Forms.DialogResult.Yes)
            {
                string strsql = "delete from notaBeli where noNotaBeli='{0}'";
                strsql = string.Format(strsql, TxtNoNotaBeli.Text);
                MessageBox.Show("Periksa dulu : " + strsql);
                master.eksekusiSQL(strsql);
                MessageBox.Show("Penghapusan selesai...");
            }
            else
            {
                MessageBox.Show("Penghapusan dibatalkan...");
            }
        }

        //sudah selesai

        //21 Nov 2016
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            LapNotaBeli lihat = new LapNotaBeli();
            lihat.getBindingSource().Filter = "noNotaBeli=" + TxtNoNotaBeli.Text;
            lihat.ShowDialog();
            lihat.Dispose();
        }

        private void btnPrintPerBarang_Click(object sender, EventArgs e)
        {
            FormSaringBeliPerBarang lihat = new FormSaringBeliPerBarang();
            lihat.ShowDialog();
            lihat.Dispose();
        }
       


    }
}
