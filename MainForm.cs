using OdrabiamyD;
namespace OdrabiamyDownloaderForms
{
    public partial class MainForm : Form
    {
        private OdrabiamyDownloader _downloader = new OdrabiamyDownloader();
        private OdrabiamyD.Models.Book? _book;
        private CancellationTokenSource _cts = new CancellationTokenSource();
        private CancellationToken _ctoken;
        public MainForm()
        {
            InitializeComponent();
            _ctoken = _cts.Token;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _downloader.DownloadStatus += (message) =>
            {
                textBox_DownloadStatus.Text += $"{message}{Environment.NewLine}";
            };
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _cts.Cancel();
            button_Download.Enabled = true;
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            _cts.Cancel();
            _cts = new CancellationTokenSource();
            button_Download.Enabled = true;
        }

        private void numericUpDown_Start_ValueChanged(object sender, EventArgs e)
        {
            var ob = sender as NumericUpDown;
            if(ob?.Value > numericUpDown_End.Value)
                ob.Value = numericUpDown_End.Value;
        }

        private void numericUpDown_End_ValueChanged(object sender, EventArgs e)
        {
            var ob = sender as NumericUpDown;
            if (ob?.Value < numericUpDown_Start.Value)
                ob.Value = numericUpDown_Start.Value;
        }

        private void textBox_Login_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var ob = sender as TextBox;
            if (ob?.Text.Length == 0)
                errorProvider_Login.SetError(textBox_Login, "Pole nie mo¿e byæ puste");
            else
                errorProvider_Login.Clear();
        }

        private void textBox_Password_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var ob = sender as TextBox;
            if (ob?.Text.Length == 0)
                errorProvider_Password.SetError(textBox_Password, "Pole nie mo¿e byæ puste");
            else
                errorProvider_Login.Clear();
        }

        private void textBox_ID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var ob = sender as TextBox;
            if (ob?.Text.Length == 0)
                errorProvider_ID.SetError(textBox_ID, "Pole nie mo¿e byæ puste!");
            else if (!int.TryParse(ob?.Text, out int id))
                errorProvider_ID.SetError(textBox_ID, "ID Musi byæ liczb¹!");
            else
                errorProvider_ID.Clear();
        }
        private async void button_Download_Click(object sender, EventArgs e)
        {
            ButtonLock(false);
            _downloader.ChangeHeaders(Headers.NonPremium);
            string? token;
            int startpage;
            int lastpage;
            int bookid;
            try
            {
                token = await _downloader.GetTokenAsync(textBox_Login.Text, textBox_Password.Text, 
                    _ctoken);
                startpage = (int)numericUpDown_Start.Value;
                lastpage = (int)numericUpDown_End.Value;
                bookid = int.Parse(textBox_ID.Text);
                button_Download.Enabled = false;
                if (checkBox_Premium.Checked)
                    await Premium(token ?? "", startpage, lastpage, bookid, _ctoken);
                else
                    await NonPremium(token ?? "", startpage, lastpage, bookid, _ctoken);
                ButtonLock(true);
                button_Download.Enabled = true;
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.Message, "B³¹d", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "B³¹d", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private async Task NonPremium(string token, int startpage, int lastpage, int bookid,
            CancellationToken ctoken = default)
        {
            _book = await _downloader.DownloadBookAsync(token, startpage, lastpage, bookid);
        }
        private async Task Premium(string token, int startpage, int lastpage, int bookid, 
            CancellationToken ctoken = default)
        {
            _downloader.ChangeHeaders(Headers.Premium);
            _book = await _downloader.DownloadBookPremiumAsync(token, startpage, lastpage, bookid);
        }

        private async void button_SaveHTML_Click(object sender, EventArgs e)
        {
            if (_book is null)
                return;
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                await _downloader.SaveBookAsHTMLAsync(_book, folderBrowserDialog.SelectedPath,
                    _ctoken);
                textBox_DownloadStatus.Text += $"Zapisano cionszke!{Environment.NewLine}";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "B³¹d", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }
        private void ButtonLock(bool enabled)
        {
            if (enabled)
            {
                button_SaveHTML.Enabled = true;
            }
            else
            {
                button_SaveHTML.Enabled = false;
            }
        }

        private async void button_SaveImages_Click(object sender, EventArgs e)
        {
            if (_book is null)
                return;
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                await _downloader.SaveAllBookImagesAsync(_book, folderBrowserDialog.SelectedPath,
                    _ctoken);
                textBox_DownloadStatus.Text += $"Zapisano cionszke!{Environment.NewLine}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "B³¹d", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }
            
        }

        private void sAMPLETEXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", 
                "https://raw.githubusercontent.com/JakubCygaro/OdrabiamyDownloaderForms/master/LICENSE");
        }

        private void windowsFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer",
                "https://github.com/JakubCygaro/OdrabiamyDownloaderForms");
        }

        private void consoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer",
                "https://github.com/JakubCygaro/OdrabiamyDownloaderConsole");
        }

        private void bibliotekaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer",
                "https://github.com/JakubCygaro/OdrabiamyDownloader");
        }
    }
}