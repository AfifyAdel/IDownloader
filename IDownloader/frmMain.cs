using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace IDownloader
{
    public partial class frmMain : MaterialForm
    {
        private YoutubeClient Youtube;
        private IReadOnlyList<YoutubeExplode.Videos.Video> PlaylistVideosInfo;
        private MaterialSkinManager materialSkinManager;
        private string extractPath;
        private bool downloading;
        MaterialSkinManager.Themes materialSkin;

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                extractPath = string.Empty;
                downloading = false;
            }
            catch (Exception ex)
            {
            }
        }

        private void searchtxtBox_Enter(object sender, EventArgs e)
        {
            try
            {
                if (searchtxtBox.Text == "Paste Playlist URL...")
                {
                    searchtxtBox.Text = "";
                    searchtxtBox.ForeColor = Color.SteelBlue;
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void searchtxtBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (searchtxtBox.Text == "")
                {
                    searchtxtBox.Text = "Paste Playlist URL...";
                    searchtxtBox.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //this.Hide();
                //e.Cancel = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (downloading) return;
                if (downloadBtn.Text == " Get Playlist")
                    FillGridViewAsync();
                else
                {
                    if (string.IsNullOrEmpty(extractPath))
                        MessageBox.Show("Please select extract folder");
                    else
                        DownloadVideosAsync();
                }
            }
            catch (Exception ex)
            {
            }
        }
        private async Task FillGridViewAsync()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchtxtBox.Text) || searchtxtBox.Text == "Paste Playlist URL...")
                {
                    MessageBox.Show("Please paste playlist url");
                    return;
                }
                gvVideos.Rows.Clear();
                Youtube = new YoutubeClient();
                var  Videos = Youtube.Playlists.GetVideosAsync(searchtxtBox.Text);

                PlaylistVideosInfo = await Videos.BufferAsync(1000);
                int count = 1;
                foreach (var video in PlaylistVideosInfo)
                {
                    gvVideos.Rows.Add(count ,true ,video.Title, "Waiting...");
                    count++;
                }
                GetVideosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task GetVideosAsync()
        {
            try
            {
                List<string> quality = new List<string>();
                StreamManifest streamManifest = await Youtube.Videos.Streams.GetManifestAsync(PlaylistVideosInfo[0].Id);
                List<MuxedStreamInfo> streamInfos = streamManifest.GetMuxed().ToList();
                for (int i = 0; i < streamInfos.Count(); i++) 
                {
                    quality.Add(streamInfos[i].VideoQualityLabel);
                }
                qualityComboBox.DataSource = quality;
                downloadBtn.Text = "  Download";
            }
            catch (Exception ex)
            {
            }
        }
        private async Task DownloadVideosAsync()
        {
            try
            {
                downloading = true;
                int count = 0, selectedVideos = 0;
                for (int i = 0; i < gvVideos.RowCount; i++) 
                {
                    if (Convert.ToBoolean(gvVideos.Rows[i].Cells[1].Value) == true) selectedVideos++;
                }
                progressBar1.Maximum = selectedVideos;
                
                foreach (var videoInfo in PlaylistVideosInfo)
                {
                    if (Convert.ToBoolean(gvVideos.Rows[count].Cells[1].Value) == false) { count++; continue; }
                    StreamManifest streamManifest = await Youtube.Videos.Streams.GetManifestAsync(videoInfo.Id);

                    gvVideos.Rows[count].Cells[3].Value = "Downloading";
                    var streamInfo = streamManifest.GetMuxed().FirstOrDefault(x => x.VideoQualityLabel == qualityComboBox.Text);
                    gvVideos.Rows[count].Cells[4].Value = streamInfo.Size.ToString();
                    if (streamInfo != null)
                    {
                        var stream = await Youtube.Videos.Streams.GetAsync(streamInfo);
                        await Youtube.Videos.Streams.DownloadAsync(streamInfo, Path.Combine(extractPath, videoInfo.Title + '.' + streamInfo.Container));
                    }
                    gvVideos.Rows[count].Cells[3].Value = "Done";
                    count++;
                    progressBar1.PerformStep();
                }
                MessageBox.Show("Download complete successfully");
                downloadBtn.Text = " Get Playlist";
                downloading = false;
            }
            catch (Exception ex)
            {
            }
        }
        private void browseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (downloading) return;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    extractPath = folderBrowserDialog1.SelectedPath;
                }
            }
            catch (Exception)
            {
            }
        }

    }
}
