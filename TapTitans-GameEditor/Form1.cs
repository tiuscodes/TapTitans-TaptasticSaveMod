using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TapTitans_GameEditor
{
    public partial class Form1 : Form
    {
        private static string _FilePath;
        private static string _SaveData;
        public string SaveData
        {
            get { return CleanSaveData(_SaveData); }
            set { _SaveData = value; }
        }

        /// <summary>
        /// Takes a substring of the savefile in order to display only relevant information in the main form.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string CleanSaveData(string s)
        {

            int start = s.IndexOf("{\\\"playerID\\\"");
            int end = s.IndexOf("\",\"lastUsedTexture");
            int len = end - start;
            var temp = s.Substring(start, len);
            return temp;
        }

        private void SaveFile()
        {
            var file = OverwriteSaveData(_SaveData, this.txtGameSave.Text);
            var sfd = new SaveFileDialog();
            sfd.FileName = _FilePath;
            if((sfd.ShowDialog() == DialogResult.OK))
            {
                File.WriteAllText(sfd.FileName, file, Encoding.Default);
                MessageBox.Show("Done!");
            }
        }

        /// <summary>
        /// Will run some string manipulation on the gamesave file to persist any user modifications.
        /// </summary>
        /// <param name="savedata">The original save data</param>
        /// <param name="data">The modified save data</param>
        /// <returns></returns>
        private string OverwriteSaveData(string savedata, string data)
        {
            //Sizes must be equal
            //Assumed that savedata has contains the below strings
            //Working with TapTitans V3.2.2
            int start = savedata.IndexOf("{\\\"playerID\\\"");
            int end = savedata.IndexOf("\",\"lastUsedTexture");
            int len = end - start;
            var temp = savedata.Substring(start, len);
            var output = savedata.Replace(temp, data);
            output = SetLastTexture(output);
            return output;
        }

        private string SetLastTexture(string savedata)
        {
            //Expects encrypted value to be populated which depends on a correctly generated hash value
            int end = savedata.LastIndexOf("\"");
            int start = end - 40;
            int len = end - start;

            var temp = savedata.Substring(start, len);
            var output = savedata.Replace(temp, this.txtOutput.Text);
            return output;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtInput.Text))
            {
                this.txtOutput.Text = Encrypt(this.txtInput.Text);
            }
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtGameSave.Text))
            {
                var unescaped = txtGameSave.Text.Replace("\\\"", "\"");//Unescape escaped quotes
                unescaped = unescaped.Replace("\\\\", "\\");//Was required as my username had unicode escape characters
                HashAlgorithm algorithm = SHA1.Create();
                byte[] hashBytes = algorithm.ComputeHash(Encoding.ASCII.GetBytes(unescaped));
                StringBuilder sb = new StringBuilder();
                foreach(byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                this.txtInput.Text = sb.ToString();
            }
        }

        private string Encrypt(string input)
        {
            //Credits to cynosure for the production of the script available at
            //http://nonsensecreativity.com/mobile/android/modding-tap-titans-save-file/ 
            byte[] key = new byte[] {7,3,2,5,4,2,5,5,3};
            byte[] bytes = Encoding.ASCII.GetBytes(input);
            byte[] output = new byte[bytes.Length];
            for (int i = 0; i < bytes.Length; i++)
            {
                byte data = bytes[i];                
                output[i] = (byte)(data + key[i % 9]);
            }
            return Encoding.ASCII.GetString(output);
        }

        private void txtGameSave_TextChanged(object sender, EventArgs e)
        {
            this.lblCurrentLen.Text = this.txtGameSave.Text.Length.ToString();
            if(this.lblInitialLen.Text != "0")
            {
                int i = int.Parse(this.lblInitialLen.Text);//
                int j = int.Parse(this.lblCurrentLen.Text);//
                this.lblDifference.Text = (i - j).ToString();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "TapTitan Save (*.adat)|*.adat|All files (*.*)|*.*";
            if ((ofd.ShowDialog() == DialogResult.OK))
            {
                _FilePath = ofd.FileName;
                try
                {
                    SaveData = File.ReadAllText(ofd.FileName, Encoding.Default);
                    txtGameSave.Text = SaveData;
                    this.lblInitialLen.Text = this.txtGameSave.Text.Length.ToString();//set initial length on label

                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnSaveModifications_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
    }
}
