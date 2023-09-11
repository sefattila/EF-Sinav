using EF_Sinav.Utilities;
using Microsoft.VisualBasic.ApplicationServices;
using Sinav.BLL.KullaniciService;
using Sinav.BLL.Utilities;
using Sinav.Core.Entities;
using Sinav.Repository.Concretes;
using Sinav.Repository.Contexts;
using Sinav.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Sinav
{
    public partial class RegisterPage : Form
    {
        private AppDbContext _context;
        private IKullaniciRepo _kullaniciRepo;
        private IKullaniciService _kullaniciService;
        private Kullanici _kullanici;
        public RegisterPage()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _kullaniciRepo = new KullaniciRepo(_context);
            _kullaniciService = new KullaniciService(_kullaniciRepo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                Helper.Clear(this.Controls);
                MessageBox.Show("Kayıt Başarılı Adminin Hesabı Onaylamasını Bekleyiniz");
                //_user = null;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _kullanici = new Kullanici();
            try
            {
                if(txtPassword.Text!=txtPasswordControl.Text)
                {
                    throw new Exception("Şifreler Uyuşmuyor");
                }
                if(!ServiceHelper.PasswordControl(txtPassword.Text))
                {
                    throw new Exception("Şifre formatlara uymuyor");
                }
                _kullanici.FirstName = txtFirstName.Text;
                _kullanici.LastName = txtLastName.Text;
                _kullanici.UserName= txtUserName.Text;
                _kullanici.Password= txtPassword.Text;

                _kullaniciService.Create(_kullanici);
                Helper.Clear(this.Controls);
                MessageBox.Show("Kayıt Başarılı");
                _kullanici = null;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Helper.Clear(this.Controls);
            }
        }
    }
}
