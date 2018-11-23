using System.IO;
using System.Windows;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;
using Kraut.Lib.Math;
using System.ComponentModel;

namespace Kraut.Prog.FileHasher
{
    public partial class MainWindow : Window
    {
        private BackgroundWorker bgWorker;
        private string file;
        private string hash;
        private HashType alg;
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.Title = "File Hasher";
            this.radMD5.IsChecked = true;

            this.bgWorker = new BackgroundWorker();
            this.bgWorker.DoWork += BgWorker_DoWork;
            this.bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
        }

        private void BtnFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                this.file = openFileDialog.FileName;
            txtFilePath.Text = this.file;
        }

        private void TxtFilePath_Changed(object sender, RoutedEventArgs e)
        {
            this.file = txtFilePath.Text;
        }

        private void BtnHash_Click(object sender, RoutedEventArgs e)
        {
            txtFileHash.Text = "";
            if (File.Exists(this.file))
            {
                btnHash.IsEnabled = false;
                progBar.IsIndeterminate = true;
                this.alg = getAlgorithem();
                this.bgWorker.RunWorkerAsync();
            }
            else
            {
                string msg = "Can not fin file\n" + this.file;
                MessageBox.Show(msg, "File not found!", MessageBoxButton.OK);
            }
        }

        private HashType getAlgorithem()
        {
            if (radMD5.IsChecked == true)
                return HashType.MD5;
            else if (radSHA1.IsChecked == true)
                return HashType.SHA1;
            else
                return HashType.SHA512;
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.hash = Hasher.HashFile(this.file, this.alg).ToUpper();
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtFileHash.Text = this.hash;
            progBar.IsIndeterminate = false;
            btnHash.IsEnabled = true;
        }
    }
}

