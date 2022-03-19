using ReaLTaiizor.Forms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class PasswordGeneratorForm : LostForm
    {
        /*                  CONFIG                  */
        private void SaveHAB_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UCHAS = UCHACB.Checked;
            Properties.Settings.Default.LCHAS = LCHACB.Checked;
            Properties.Settings.Default.DHAS = DHACB.Checked;
            Properties.Settings.Default.SHAS = SHACB.Checked;
            Properties.Settings.Default.BHAS = BHACB.Checked;
            Properties.Settings.Default.LHAS = (int)LHAL.Value;
            Properties.Settings.Default.NHAS = (int)NHAL.Value;
            Properties.Settings.Default.Save();
        }

        private void lostButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UCHAS = false;
            Properties.Settings.Default.LCHAS = false;
            Properties.Settings.Default.DHAS = false;
            Properties.Settings.Default.SHAS = false;
            Properties.Settings.Default.BHAS = false;
            Properties.Settings.Default.LHAS = 10;
            Properties.Settings.Default.NHAS = 10;
            Properties.Settings.Default.Save();
            LoadConfig();
        }
        private void LoadConfig()
        {
            UCHACB.Checked = Properties.Settings.Default.UCHAS;
            LCHACB.Checked = Properties.Settings.Default.LCHAS;
            DHACB.Checked = Properties.Settings.Default.DHAS;
            SHACB.Checked = Properties.Settings.Default.SHAS;
            BHACB.Checked = Properties.Settings.Default.BHAS;
            LHAL.Value = Properties.Settings.Default.LHAS;
            NHAL.Value = Properties.Settings.Default.NHAS;

            if (UCHACB.Checked == true)
                Config.chars += Config.uc;
            else
                Config.chars = Config.chars.Replace(Config.uc, string.Empty);
            
            if (LCHACB.Checked == true)
                Config.chars += Config.lc;
            else
                Config.chars = Config.chars.Replace(Config.lc, string.Empty);
            
            if (DHACB.Checked == true)
                Config.chars += Config.d;
            else
                Config.chars = Config.chars.Replace(Config.d, string.Empty);
            
            if (SHACB.Checked == true)
                Config.chars += Config.s;
            else
                Config.chars = Config.chars.Replace(Config.s, string.Empty);
            
            if (BHACB.Checked == true)
                Config.chars += Config.b;
            else
                Config.chars = Config.chars.Replace(Config.b, string.Empty);
        }
        /*                  CONFIG                  */

        /*                  CheckBox                  */
        private void UCHACB_Click(object sender, EventArgs e)
        {
            if (UCHACB.Checked == false)
                Config.chars += Config.uc;
            else
                Config.chars = Config.chars.Replace(Config.uc, string.Empty);
        }

        private void LCHACB_Click(object sender, EventArgs e)
        {
            if (LCHACB.Checked == false)
                Config.chars += Config.lc;
            else
                Config.chars = Config.chars.Replace(Config.lc, string.Empty);
        }

        private void DHACB_Click(object sender, EventArgs e)
        {
            if (DHACB.Checked == false)
                Config.chars += Config.d;
            else
                Config.chars = Config.chars.Replace(Config.d, string.Empty);
        }

        private void SHACB_Click(object sender, EventArgs e)
        {
            if (SHACB.Checked == false)
                Config.chars += Config.s;
            else
                Config.chars = Config.chars.Replace(Config.s, string.Empty);
        }

        private void BHACB_Click(object sender, EventArgs e)
        {
            if (BHACB.Checked == false)
                Config.chars += Config.b;
            else
                Config.chars = Config.chars.Replace(Config.b, string.Empty);
        }
        /*                  CheckBox                  */

        public PasswordGeneratorForm()
        {
            InitializeComponent();
            this.Load += PasswordGeneratorForm_Load;
        }

        private void PasswordGeneratorForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            LoadConfig();
        }

        private void GHAB_Click(object sender, EventArgs e)
        {
            if(!UCHACB.Checked && !LCHACB.Checked && !DHACB.Checked && !SHACB.Checked && !BHACB.Checked)
            {
                MessageBox.Show("Select atleast one option !");
            } else
            {
                if (NHAL.Value >= 1000)
                    MessageBox.Show("Wait a bit it'll take more time !");
                new Thread(() => {
                    PLHARTB.Clear();
                    /*Avoid Windows To Be Untouchable So You Can Move It*/
                    HAOptionsPanel.Enabled = false;
                    HAResultPanel.Enabled = false;
                    /*Avoid Windows To Be Untouchable So You Can Move It*/
                    //this.Enabled = false;
                    for (int i = 0; i < NHAL.Value; i++)
                    {
                        PLHARTB.Text += String.Format("{0}\n", Utils.RandomPassword((int)LHAL.Value, Config.chars));
                    }
                    /*Avoid Windows To Be Untouchable So You Can Move It*/
                    HAOptionsPanel.Enabled = true;
                    HAResultPanel.Enabled = true;
                    /*Avoid Windows To Be Untouchable So You Can Move It*/
                    //this.Enabled = true;
                }).Start();
            }
        }

        private void GSPHAB_Click(object sender, EventArgs e)
        {
            if (!UCHACB.Checked && !LCHACB.Checked && !DHACB.Checked && !SHACB.Checked && !BHACB.Checked)
            {
                MessageBox.Show("Select atleast one option !");
            }
            else
            {
                if (NHAL.Value >= 1000)
                    MessageBox.Show("Wait a bit it'll take more time !");
                new Thread(() => {
                    PLHARTB.Clear();
                    /*Avoid Windows To Be Untouchable So You Can Move It*/
                    HAOptionsPanel.Enabled = false;
                    HAResultPanel.Enabled = false;
                    /*Avoid Windows To Be Untouchable So You Can Move It*/
                    //this.Enabled = false;
                    for (int i = 0; i < NHAL.Value; i++)
                    {
                        PLHARTB.Text += String.Format("{0}\n", Utils.RandomPassword((int)LHAL.Value, Config.chars.S3CUR3()));
                    }
                    /*Avoid Windows To Be Untouchable So You Can Move It*/
                    HAOptionsPanel.Enabled = true;
                    HAResultPanel.Enabled = true;
                    /*Avoid Windows To Be Untouchable So You Can Move It*/
                    //this.Enabled = true;
                }).Start();
            }
        }

    }
}
