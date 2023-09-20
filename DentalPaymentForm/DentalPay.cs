using DentalPaymentForm;
using System.Globalization;

namespace DentalPayment
{
    public partial class DentalPay : Form
    {


        public DentalPay()
        {
            InitializeComponent();
        }

        private bool checkNull()
        {
            bool isOK = true;
            if (txtTenKhach.Text == "" || txtTenKhach.Text == null)
            {
                isOK = false;
            }
            if (ckbCaoVoi.Checked == false && ckbChupHinhRang.Checked == false && ckbTayTrang.Checked == false)
            {
                isOK = false;
            }
            return isOK;
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (checkNull() == false)
            {
                MessageBox.Show("Chua nhap du thong tin", "Thong bao");
            }
            else
            {
                txtTongTien.Text = TinhTien().ToString();
                ghiThongTin();
            }
        }

        public void ghiThongTin()
        {
            ListViewItem item = new ListViewItem(txtTenKhach.Text);
            item.SubItems.Add(TinhTien().ToString());
            lsvDanhSach.Items.Add(item);
        }

        public float TinhTien()
        {
            float tong = 0, tienCaoVoi = 0, tienTramRang = 0, tienChupHinh = 0, tienTayTrang = 0;
            if (ckbCaoVoi.Checked)
            {
                tienCaoVoi = float.Parse(lblGiaCaoVoi.Text.Replace(".", String.Empty));
            }
            if (ckbChupHinhRang.Checked)
            {
                tienChupHinh = float.Parse(lblGiaChupHinhRang.Text.Replace(".", String.Empty));
            }
            if (ckbTayTrang.Checked)
            {
                tienTayTrang = float.Parse(lblGiaTayTrang.Text.Replace(".", String.Empty));
            }
            if (nudTramRang.Value > 0)
            {
                float gia = float.Parse(lblGiaTramRang.Text.Replace(".", String.Empty).Replace("/cai", String.Empty));
                int soLuong = int.Parse(nudTramRang.Value.ToString());
                tienTramRang = soLuong * gia;
            }
            tong = tienCaoVoi + tienTayTrang + tienTramRang + tienChupHinh;
            return tong;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string FormatNumberWithCommas(double number)
        {
            CultureInfo cultureInfo = new CultureInfo("en-US");
            cultureInfo.NumberFormat.NumberGroupSeparator = ".";
            cultureInfo.NumberFormat.NumberDecimalSeparator = ",";

            string formattedNumber = number.ToString("#,##0", cultureInfo);

            return formattedNumber;
        }

        private void btnSuaGiaTien_Click(object sender, EventArgs e)
        {
            EditPrices form2 = new EditPrices();
            DialogResult result = form2.ShowDialog();

            if (result == DialogResult.OK)
            {
                FormData formData = form2.GetFormData();

                lblGiaCaoVoi.Text = FormatNumberWithCommas(formData.CaoVoi);
                lblGiaTayTrang.Text = FormatNumberWithCommas(formData.TayTrang);
                lblGiaChupHinhRang.Text = FormatNumberWithCommas(formData.Chuphinh);
                lblGiaTramRang.Text = FormatNumberWithCommas(formData.TramRang) + "/cai";

            }
        }
    }
}