using SQLiteORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMPlayer
{
    public partial class MainForm : Form
    {
        private string _pathToDBfile;
        private PlayListForm _playListForm;
        private PlayListController _playListController;
        public MainForm()
        {
            InitializeComponent();
            aboutUsToolStripMenuItem.Click += AboutUsToolStripMenuItem_Click;
            // _pathToDBfile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\playlistsDB.db";
            _pathToDBfile = @"D:\c#\lesson28\WMPlayer\WMPlayer\bin\Debug\playlistsDB.db";
            if (!File.Exists(_pathToDBfile))
            {
                throw new FileNotFoundException("Отсутсвует файл базы данных");
            }
            _playListController = new PlayListController(_pathToDBfile);
        }
        public PlayListController PlayListController
        {
            get
            {
                return _playListController;
            }
        }
        public AxWMPLib.AxWindowsMediaPlayer MediaPlayer
        {
            get
            {
                return axWindowsMediaPlayer;
            }
        }

        private void AboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUsForm aboutUsForm = new AboutUsForm();
            // aboutUsForm.Show();  - немодальное окно
            aboutUsForm.ShowDialog(); // - модальное окно
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //string mediaPath = Assembly.GetExecutingAssembly().Location;
            //mediaPath = Path.GetDirectoryName(mediaPath) + "\\Sabaton.mp4";

            //axWindowsMediaPlayer.URL = mediaPath;
            //toolStripStatusLabel_Info.Text = Path.GetFileName(mediaPath);
            //toolStripStatusLabel_Info.ForeColor = Color.Red;
        }

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_playListForm == null)
            {
                _playListForm = new PlayListForm(this);
                _playListForm.Location = 
                        new Point(this.Location.X + this.Size.Width - 14, this.Location.Y);
                _playListForm.Size = new Size(_playListForm.Width, this.Height);
            }
            _playListForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _playListController.SaveSync();
        }
    }
}
