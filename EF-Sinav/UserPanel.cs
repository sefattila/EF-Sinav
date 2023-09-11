using Sinav.BLL.AlbumService;
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
using static System.Net.Mime.MediaTypeNames;

namespace EF_Sinav
{
    public partial class UserPanel : Form
    {
        private AppDbContext _context;
        private IAlbumRepo _albumRepo;
        private IAlbumService _albumService;
        private Album _album;
        public UserPanel()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _albumRepo = new AlbumRepo(_context);
            _albumService = new AlbumService(_albumRepo);
        }


        private void ButtonSettings(bool set)
        {
            btnAdd.Enabled = set;
            btnUpdate.Enabled = !set;
            btnDelete.Enabled = !set;
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            ButtonSettings(true);
            dataGridView1.DataSource=_albumRepo.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _album = new Album();
            try
            {
                _album.AlbumAdi = txtAlbumAdi.Text;
                _album.CikisTarihi=dateTimePicker1.Value;
                _album.Fiyat = Convert.ToDouble(textBox2.Text);
                _album.IndirimOrani = Convert.ToDouble(textBox3.Text);
                if(rbAktif.Checked)
                {
                    _album.SatisDurum = true;
                }
                else
                {
                    _album.SatisDurum = false;
                }
                _album.SanatciId = Convert.ToInt32(textBox5.Text);

                _albumService.Create(_album);
                dataGridView1.DataSource = _albumRepo.GetAll();
                _album = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserPanel_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _albumRepo.GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                _album = _albumService.GetDefaultById(id);

                _album.AlbumAdi = txtAlbumAdi.Text;
                _album.CikisTarihi = dateTimePicker1.Value;
                _album.Fiyat = Convert.ToDouble(textBox2.Text);
                _album.IndirimOrani = Convert.ToDouble(textBox3.Text);
                if (rbAktif.Checked)
                {
                    _album.SatisDurum = true;
                }
                else
                {
                    _album.SatisDurum = false;
                }
                _album.SanatciId = Convert.ToInt32(textBox5.Text);

                _albumService.Update(_album);
                _album = null;
                dataGridView1.DataSource = _albumRepo.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                _album = _albumService.GetDefaultById(id);

                _albumService.Delete(_album);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvTexts.Items.Clear();
            IList<Album> albums = _albumService.SatistaOlanlar();
            foreach (var item in albums)
            {
                ListViewItem listViewItem = new ListViewItem(item.AlbumAdi);
                listViewItem.SubItems.Add(item.Sanatci.FirstName + " " + item.Sanatci.LastName);

                lvTexts.Items.Add(listViewItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lvTexts.Items.Clear();
            IList<Album> albums = _albumService.SatistaOlmayanlar();
            foreach (var item in albums)
            {
                ListViewItem listViewItem = new ListViewItem(item.AlbumAdi);
                listViewItem.SubItems.Add(item.Sanatci.FirstName + " " + item.Sanatci.LastName);

                lvTexts.Items.Add(listViewItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lvTexts.Items.Clear();
            IList<Album> albums = _albumService.SonOnAlbum();
            foreach (var item in albums)
            {
                ListViewItem listViewItem = new ListViewItem(item.AlbumAdi);
                listViewItem.SubItems.Add(item.Sanatci.FirstName + " " + item.Sanatci.LastName);

                lvTexts.Items.Add(listViewItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lvTexts.Items.Clear();
            IList<Album> albums = _albumService.OrderByDesc(x=>x.IndirimOrani);
            foreach (var item in albums)
            {
                ListViewItem listViewItem = new ListViewItem(item.AlbumAdi);
                listViewItem.SubItems.Add(item.Sanatci.FirstName + " " + item.Sanatci.LastName);

                lvTexts.Items.Add(listViewItem);
            }
        }

        //private void FillList(IList<Album> albums)
        //{
        //    lvTexts.Items.Clear();
        //    foreach (var item in albums)
        //    {
        //        ListViewItem listViewItem = new ListViewItem();
        //        listViewItem.Text = item.Id.ToString();
        //        listViewItem.SubItems.Add(item.AlbumAdi);
        //        listViewItem.SubItems.Add(item.CikisTarihi);

        //        lvTexts.Items.Add(listViewItem);
        //    }
        //}
    }
}
