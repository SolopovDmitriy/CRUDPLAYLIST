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
    public partial class PlayListForm : Form
    {
        private MainForm _parentForm;
        public PlayListForm(MainForm parentForm)
        {
            this._parentForm = parentForm;
            InitializeComponent();
        }
        private void PlayListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        private void PlayListForm_Load(object sender, EventArgs e)
        {
            foreach (string item in _parentForm.PlayListController.PlayListNames)
            {
                playlistsToolStripMenuItem.DropDownItems.Add(item);
            }

            foreach (ToolStripMenuItem item in playlistsToolStripMenuItem.DropDownItems)
            {
                item.Click += Item_Click;
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in playlistsToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
            }
            ((ToolStripMenuItem)sender).Checked = true;

            if (_parentForm.PlayListController.AllMediaRecords.ContainsKey(((ToolStripMenuItem)sender).ToString()))
            {
                listBox_Playlists.Items.Clear();
                foreach (var item in _parentForm.PlayListController.AllMediaRecords[((ToolStripMenuItem)sender).ToString()])
                {
                    listBox_Playlists.Items.Add(item); //boxing
                }
            }
        }

        private void listBox_Playlists_DoubleClick(object sender, EventArgs e)// sender - тот кто вызвал событие; listBox_Playlists_DoubleClick - метод, который вызывается при двойном щелчке по listBox_Playlists
        {
            if(listBox_Playlists.SelectedItem != null)// listBox_Playlists - 
            {
                MediaRecord currentRecord = (MediaRecord)listBox_Playlists.SelectedItem;//MediaRecord - track = playlist_id + path
                if (File.Exists(currentRecord.Path))
                {
                    _parentForm.MediaPlayer.URL = currentRecord.Path;//_parentForm.MediaPlayer.URL, путь к файлу, который хотим воспроизвести
                }
                else
                {
                    MessageBox.Show( "Указанный файл не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw new FileNotFoundException("Указанный файл не существует");
                }
            }
        }

        private void button_Add_Treck_Click(object sender, EventArgs e)//
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP4 Video files (*.mp4, *m4v, *mp4v, *.3p2, *.3gp2, *.3gp, *.3gpp)|*.mp4|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Assembly.GetExecutingAssembly().Location;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
             
                foreach (ToolStripMenuItem item in playlistsToolStripMenuItem.DropDownItems)//playlistsToolStripMenuItem - (первый, второй, третий); playlistsToolStripMenuItem.DropDownItems = playlistsToolStripMenuItem.Items
                {
                    if (item.Checked == true)
                    {
                        long selIndex = _parentForm.PlayListController.getIdPlaylist(item.Text);//получаем id выбранного плейлиста, который checked
                        if (selIndex != -1)
                        {
                            MediaRecord mediaRecord = new MediaRecord(selIndex, filePath);
                            _parentForm.PlayListController.AddOneMediaRecord(mediaRecord);
                            listBox_Playlists.Items.Add(mediaRecord); //  listBox1.Items.Add("track1");
                        }
                    }
                }
            }
        }


        // my 
        private void button_Del_Treck_Click(object sender, EventArgs e)
        {
            if (listBox_Playlists.SelectedItem != null)
            {
                foreach (ToolStripMenuItem playlistItem in playlistsToolStripMenuItem.DropDownItems)
                {
                    if (playlistItem.Checked == true)
                    {
                        MediaRecord currentRecord = (MediaRecord)listBox_Playlists.SelectedItem;
                        listBox_Playlists.Items.Remove(currentRecord);// удаляем из listBox_Playlists, который находится на форме PlayListForm
                        string nameOfPlaylist = playlistItem.Text;                      
                        _parentForm.PlayListController.AllMediaRecords[nameOfPlaylist].Remove(currentRecord);//удаляем из private SortedList<string, List<MediaRecord>> _allMediaRecords, который находится в PlayListController      
                        _parentForm.PlayListController.DeleteOneMediaRecord(currentRecord);//удаляем из базы данных
                    }
                }    
            }
        }



        // my 
        private void button_AddTrecks_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();//на какую кнопку нажали ок или отмена
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))//fbd.SelectedPath - папка, которую мы выбрали, !string.IsNullOrWhiteSpace(fbd.SelectedPath)) - не пустой fbd.SelectedPath, fbd - FolderBrowserDialog
                {
                    string[] filePathes = Directory.GetFiles(fbd.SelectedPath);// filePathes - массив путей к файлам внутри папки fbd.SelectedPath
                    foreach (string filePath in filePathes)
                    {
                        foreach (ToolStripMenuItem item in playlistsToolStripMenuItem.DropDownItems)
                        {
                            if (item.Checked == true)
                            {
                                long selIndex = _parentForm.PlayListController.getIdPlaylist(item.Text);
                                if (selIndex != -1)
                                {
                                    MediaRecord mediaRecord = new MediaRecord(selIndex, filePath);
                                    _parentForm.PlayListController.AddOneMediaRecord(mediaRecord);
                                    listBox_Playlists.Items.Add(mediaRecord);
                                }
                            }
                        }
                    }
                }
            }


        }
    }
}
//1. Mediarecord - _playlist_id -> long 
//2. Удаление элемента из плейлиста
// Запись с таким ключом уже существует. 