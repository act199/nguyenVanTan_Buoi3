namespace nguyenVanTan_Buoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            HinhChuNhat hinhChuNhat = new HinhChuNhat();
            hinhChuNhat.setCd(int.Parse(txtcd.Text));
            hinhChuNhat.setCr(int.Parse(txtcr.Text));

            MessageBox.Show("Chiều dài:" + hinhChuNhat.getCd() + "\n Chiều rộng:" + hinhChuNhat.getCr());
        }

        private void btnnhap2_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtmasv.Text;
            string tenSinhVien = txthoten.Text;
            DateTime ngaySinh = dtpngaysinh.Value;
            string sodienthoat = txtsdt.Text;
            string gioitinh = txtgioitinh.Text;
        }
        
    }
}
