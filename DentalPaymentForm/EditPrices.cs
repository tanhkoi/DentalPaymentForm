using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentalPayment;
using static System.Windows.Forms.DataFormats;

namespace DentalPaymentForm

{

    public partial class EditPrices : Form
    {
        public EditPrices()
        {
            InitializeComponent();
        }

        public FormData GetFormData()
        {
            FormData formData = new FormData();
            formData.CaoVoi = Double.Parse(txtSuaCaoVoi.Text);
            formData.TayTrang = Double.Parse(txtSuaTayTrang.Text);
            formData.Chuphinh = Double.Parse(txtSuaChupHinh.Text);
            formData.TramRang = Double.Parse(txtSuaTramRang.Text);
            return formData;
        }

        private void handleOnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public bool checkNull()
        {
            if (txtSuaCaoVoi.Text == "" || txtSuaTayTrang.Text == "" || txtSuaChupHinh.Text == "" || txtSuaTramRang.Text == "")
            {
                return true;
            }
            return false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                MessageBox.Show("Vui long dien day du", "Thong bao");
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void txtSuaCaoVoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            handleOnlyNumber(sender, e);
        }

        private void txtSuaTayTrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            handleOnlyNumber(sender, e);
        }

        private void txtSuaChupHinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            handleOnlyNumber(sender, e);
        }

        private void txtSuaTramRang_KeyPress(object sender, KeyPressEventArgs e)
        {
            handleOnlyNumber(sender, e);
        }
    }
}
