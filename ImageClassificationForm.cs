using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageClassificationDecider
{
    public partial class ImageClassificationForm : Form
    {
        List<string> files;
        Dictionary<char, string> hotkeyToFolderName = new Dictionary<char, string>();
        public ImageClassificationForm()
        {
            InitializeComponent();
        }
      

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (files == null || files.Count == 0) return;

            if (hotkeyToFolderName.ContainsKey(e.KeyChar))
            {
                string targetFolder = hotkeyToFolderName[e.KeyChar];
                MoveCurrentPictureToSubfolder(targetFolder);
                LoadNextPicture();
            }        
        }

        private void MoveCurrentPictureToSubfolder(string subFolderName)
        {
            string currentFile = files[0];
            FileInfo fi = new FileInfo(currentFile);
            string targetDir = $"{fi.DirectoryName}\\{subFolderName}";
            if (!Directory.Exists(targetDir)) Directory.CreateDirectory(targetDir);
            string destFilePath = targetDir + "\\" + fi.Name;
            fi.MoveTo(destFilePath);
            files.Remove(currentFile);
            lblActionInfo.Text = $"{currentFile} moved to folder '{subFolderName}'";
        }
       
        private void LoadNextPicture()
        {
            if (files.Count > 0)
            {
                var currentFile = files[0];
                    var imgBytes = File.ReadAllBytes(currentFile);
                    MemoryStream mem = new MemoryStream(imgBytes);
                    pictureBox1.Image = Image.FromStream(mem);
            }
            lblProgressInfo.Text = "Files left: " + files.Count;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            diag.ShowNewFolderButton = true;
       var diagResult =     diag.ShowDialog();
            if (diagResult == DialogResult.OK)
            {
              bool hasSubfolders =  FillHotkeyInfo(diag.SelectedPath);
                if (hasSubfolders)
                {
                    howToPanel.Visible = false;
                    files = Directory.GetFiles(diag.SelectedPath).ToList();
                    LoadNextPicture();

                    var firstHotkeyPair = hotkeyToFolderName.First();
                    lblActionInfo.Text = $"For example, press {firstHotkeyPair.Key} on your keyboard to move the shown image to the '{firstHotkeyPair.Value}' folder" ;
                    lblProgressInfo.Text = "";

                }
            }
        }

        private bool FillHotkeyInfo(string selectedPath)
        {
           DirectoryInfo dirInfo = new DirectoryInfo(selectedPath);
            hotkeyToFolderName.Clear();
            var subfolders = dirInfo.GetDirectories();
            if(subfolders.Length < 2)
            {
                MessageBox.Show($"There need to be at least 2 subfolders in '{selectedPath}'");
                return false;
            }
            int hotKeyNumber = 1;            
            List<string> hotkeyInfoList = new List<string>();
            foreach(var subfolder in subfolders)
            {
                hotkeyToFolderName.Add(hotKeyNumber.ToString()[0], subfolder.Name);
                hotkeyInfoList.Add(hotKeyNumber.ToString() + "=" + subfolder.Name);
                hotKeyNumber++;
            }

            lblHotkeyInfo.Text = "Hotkeys: " + String.Join(", ", hotkeyInfoList);
            return true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
