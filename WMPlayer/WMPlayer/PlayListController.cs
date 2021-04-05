using SQLiteORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMPlayer
{
    public class PlayListController
    {
        private SQLiteDBEngine _sQLiteDBEngine;
        private SQLiteTable _playlist;
        private SQLiteTable _mediaRecords;

        private SortedList<string, List<MediaRecord>> _allMediaRecords;
        
        public long getIdPlaylist(string playlist)
        {
            foreach (var row in _playlist.BodyRows)
            {
               if( playlist.Equals(row.Value[0])) {
                    return row.Key;
               }
            }
            return -1;
        }

        public void AddOneMediaRecord(MediaRecord mediaRecord)
        {
            List<string> tmp = new List<string>();
            tmp.Add(mediaRecord.Playlist_Id.ToString());
            tmp.Add(mediaRecord.Path);
            //List {"2","d://c#/lesson31/sabadon.mp4" }
            _mediaRecords.AddOneRow(tmp);
        }


        // my 
        public void DeleteOneMediaRecord(MediaRecord mediaRecord)
        {
            //   MediaRecord mediaRecord = new MediaRecord(playlist_id, filePath);
            List<KeyValuePair<string, string>> searchPattern = new List<KeyValuePair<string, string>>();
            searchPattern.Add(new KeyValuePair<string, string>("playlist_id", mediaRecord.Playlist_Id.ToString()));//
            searchPattern.Add(new KeyValuePair<string, string>("path", mediaRecord.Path));
            KeyValuePair<long, List<string>> ? mediaRecordInDb = _mediaRecords.GetOneRow(searchPattern);

            //int ? x = 10;
            //int y = x.Value;

            if (mediaRecordInDb != null)
            {
                List<string> v = mediaRecordInDb.Value.Value;
                _mediaRecords.DeleteOneRow(mediaRecordInDb.Value.Key);
            }
            //SaveSync();
        }


        public void SaveSync()
        {
            _sQLiteDBEngine.Async();
        }
        
        public PlayListController(string pathToDBfile)
        {
            _sQLiteDBEngine = new SQLiteDBEngine(pathToDBfile, SQLIteMode.EXISTS);
            _playlist = _sQLiteDBEngine["playlists"];  // таблица playlists - объект класса SQLiteTable
            _mediaRecords = _sQLiteDBEngine["mediarecords"]; // таблица mediarecords - объект класса SQLiteTable
            _allMediaRecords = new SortedList<string, List<MediaRecord>>();


            foreach (var onePlayList in _playlist.BodyRows)
            {
                List<MediaRecord> list = new List<MediaRecord>();//MediaRecord?
                foreach (List<string> row in _mediaRecords.BodyRows.Values)
                {
                    long playlistId = Convert.ToInt64(row[0]); // 
                    if (onePlayList.Key == playlistId)
                    {
                        MediaRecord mediaRecord = new MediaRecord(playlistId, row[1]); // row[1] - полный путь к файлу, mediaRecord - это трек
                        list.Add(mediaRecord);
                    }
                }
                _allMediaRecords.Add(onePlayList.Value[0], list); // onePlayList.Value[0] - название плейлиста (первый второй третий), list - список треков(MediaRecord)
            }
        }
        public List<string> PlayListNames
        {
            get
            {
                List<string> tmp = new List<string>();
                foreach (List<string> row in _playlist.BodyRows.Values)
                {
                    tmp.Add(row[0]);
                }
                return tmp;
            }
        }
        public SortedList<string, List<MediaRecord>> AllMediaRecords
        {
            get
            {
                return _allMediaRecords;
            }
        }
    }
}
