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
    public partial class FormNotaJual : Form
    {
        public FormNotaJual()
        {
            InitializeComponent();
        }

        Tabel master = new Tabel("notaJual");
        Tabel detail = new Tabel("View_Detail_Jual");
        Tabel barang = new Tabel("barang");

        private void ikat()
        {
            txtNoNotaJual.DataBindings.Add("text", master.getBs(), "noNotaJual");
            TxtTanggal.DataBindings.Add("text", master.getBs(), "tanggal");
            DgvDetailJual.DataSource = detail.getBs();
        }

        private void tampil()
        {
            detail.getBs().Filter = "noNotaJual=" + txtNoNotaJual.Text;
            int total = 0;
            for (int baris = 0; baris < DgvDetailJual.Rows.Count; baris++)
            {
                total += int.Parse(DgvDetailJual.Rows[baris].Cells[6].Value.ToString());
            }
            TxtTotal.Text = total.ToString("#,###");
            
        }

        private void FormNotaJual_Load(object sender, EventArgs e)
        {
            ikat();
            tampil();
            modeSave();
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modeEdit()
        {
            DgvDetailJual.Height = 168;
            DgvDetailJual.Top = 162;
            txtNoNotaJual.Enabled = false;
            TxtTanggal.Enabled = true;
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
            DgvDetailJual.Height = 275;
            DgvDetailJual.Top = 65;
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
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            modeEdit();
            TxtKodeBarang.Focus();
            String strsql = "insert into notajual(tanggal) values ('" + DateTime.Now.ToString() + "')";
            String noNotaBaru = master.eksekusiSQL_getID(strsql);
            int posisi = master.getBs().Find("nonotajual", noNotaBaru);
            master.getBs().Position = posisi;
            tampil();
            modeEdit();
        }

        private void hapus()
        {
            //txtNoNotaJual.Clear();
            //TxtTanggal.Clear();
            TxtKodeBarang.Clear();
            txtQty.Text = "0";
            TxtHarga.Text = "0";
            TxtJumlah.Text = "0";
            TxtNamaBarang.Clear();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            modeEdit();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            modeSave();
            tampil();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult jawab;
            jawab = MessageBox.Show("Yakin mau hapus nota Jual nomer: " + txtNoNotaJual.Text + "?", "konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == System.Windows.Forms.DialogResult.Yes)
            {
                string strsql = "delete from notaJual where noNotaJual='{0}'";
                strsql = string.Format(strsql, txtNoNotaJual.Text);
                MessageBox.Show("Periksa dulu : " + strsql);
                master.eksekusiSQL(strsql);
                MessageBox.Show("Penghapusan selesai...");
            }
            else
            {
                MessageBox.Show("Penghapusan dibatalkan...");
            }
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            modeSave();
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
                    TxtHarga.Text = ((DataRowView)barang.getBs().Current).Row["hargaJual"].ToString();
                    txtQty.Focus();
                }
                else
                {
                    MessageBox.Show("Kode barang tidak ditemukan");
                    hapus();
                    TxtKodeBarang.Focus();
                }
            }

        }

        private void TxtKodeBarang_KeyUp(object sender, KeyEventArgs e)
        {
            
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

        private void DgvDetailJual_KeyDown(object sender, KeyEventArgs e)
        {
            int baris = DgvDetailJual.SelectedCells[0].RowIndex;
            if (e.KeyData == Keys.Back)
            {
                modeEdit();
                TxtKodeBarang.Text = DgvDetailJual.Rows[baris].Cells[2].Value.ToString();
                TxtNamaBarang.Text = DgvDetailJual.Rows[baris].Cells[3].Value.ToString();
                txtQty.Text = DgvDetailJual.Rows[baris].Cells[4].Value.ToString();
                TxtHarga.Text = DgvDetailJual.Rows[baris].Cells[5].Value.ToString();
                TxtJumlah.Text = DgvDetailJual.Rows[baris].Cells[6].Value.ToString();

                TxtKodeBarang.Focus();
            }
            if (e.KeyData == Keys.Back || e.KeyData == Keys.Delete)
            {
                String idnotabeli = DgvDetailJual.Rows[baris].Cells[0].Value.ToString();
                String strsql = "delete from itemNotaBeli where idNotaBeli=" + idnotabeli;
                detail.eksekusiSQL(strsql);
            }
            tampil();
        }

        private void TxtJumlah_KeyDown(object sender, KeyEventArgs e)
        {
            if (TxtJumlah.Text.Length > 0)
            {
                if (e.KeyData == Keys.Enter && int.Parse(TxtJumlah.Text) > 0 && TxtKodeBarang.Text.Length == 5)
                {
                    String strsql, noNotaJual, kodeBarang, qty, harga;
                    noNotaJual = txtNoNotaJual.Text;
                    kodeBarang = TxtKodeBarang.Text;
                    qty = txtQty.Text;
                    harga = TxtHarga.Text;
                    strsql = "insert into itemNotaJual(noNotaJual, kodeBarang, qty, harga) " +
                        "values('{0}','{1}','{2}','{3}')";
                    strsql = String.Format(strsql, noNotaJual, kodeBarang, qty, harga);
                    detail.eksekusiSQL(strsql);
                    hapus();
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

        private void TxtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            TxtJumlah.Focus();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtKodeBarang_Leave(object sender, EventArgs e)
        {
            if (TxtKodeBarang.Text.Length == 5)
            {
                txtQty.Focus();
            }
        }

        private void TxtKodeBarang_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (TxtKodeBarang.Text.Length == 5)
            {
                txtQty.Focus();
            }
        }

        private void TxtKodeBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 16)
            {
                FormCariBarang cari = new FormCariBarang();
                cari.ShowDialog();
                TxtKodeBarang.Text = cari.getKode();
            }
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            cmbNonota.Visible = true;
            master.getBs().MoveFirst();
            String nomer = "";
            cmbNonota.Items.Clear();
            for (int x = 0; x < master.getBs().Count; x++)
            {
                nomer = ((DataRowView)master.getBs().Current).Row["noNotaJual"].ToString();
                cmbNonota.Items.Add(nomer);
                master.getBs().MoveNext();
            }
        }

        private void cmbNonota_SelectedValueChanged(object sender, EventArgs e)
        {
            int baris = master.getBs().Find("noNotaJual", cmbNonota.Text);
            master.getBs().Position = baris;
            cmbNonota.Visible = false;
            tampil();
        }

        //btnSearch belom. btnprint dihapus aja. 
        //sudah beres

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            LapNotaJual lihat = new LapNotaJual();
            lihat.getBindingSource().Filter = "noNotaJual=" + txtNoNotaJual.Text;
            lihat.ShowDialog();
            lihat.Dispose();
        }

        private void btnPrintPerBarang_Click(object sender, EventArgs e)
        {
            SaringJualPerBarang lihat = new SaringJualPerBarang();
            lihat.ShowDialog();
            lihat.Dispose();
        }
    }
}
