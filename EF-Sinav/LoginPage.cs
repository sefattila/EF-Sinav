using EF_Sinav.Utilities;
using Sinav.BLL.KullaniciService;
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
    public partial class LoginPage : Form
    {
        private AppDbContext _context;
        private IKullaniciRepo _kullaniciRepo;
        private IKullaniciService _kullaniciService;
        private Kullanici _kullanici;
        public LoginPage()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _kullaniciRepo = new KullaniciRepo(_context);
            _kullaniciService = new KullaniciService(_kullaniciRepo);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                _kullanici = new Kullanici();
                _kullanici = _kullaniciService.GirisKontrol(txtUserName.Text, txtPassword.Text);
                this.Hide();
                UserPanel userPanel = new UserPanel();
                userPanel.ShowDialog();
                this.Close();
                _kullanici = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Helper.Clear(this.Controls);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterPage registerPage = new RegisterPage();
            registerPage.ShowDialog();
            this.Show();
        }

        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            try
            {
                _kullanici = new Kullanici();
                _kullanici = _kullaniciService.GirisKontrol(txtUserName.Text, txtPassword.Text);
                this.Hide();
                UserPanel userPanel = new UserPanel();
                userPanel.ShowDialog();
                this.Close();
                _kullanici = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Helper.Clear(this.Controls);
            }
        }
    }
}
