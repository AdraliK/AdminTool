using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminTool2.Properties;
using System.Security.Cryptography;
using System.IO;
using System.Drawing.Drawing2D;
using AdminTool2.MyControls;

namespace AdminTool2.Windows
{
    public partial class LoginWindow : Form
    {

        private const string key = "b20d9daa3cd722f1523e9b79382593f41c4b54d81f10428e69729e7f4397ddfa";
        private const int KeySize = 256;
        private const int BlockSize = 128;
        private const int Iterations = 1000;
        private const string Salt = "82cb9f9d9a2583d67a6bdcfc71a97075";

        public LoginWindow()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            if (Settings.Default["username"].ToString() != "")
            {
                usernameTextBox.Texts = Settings.Default["username"].ToString();
                passwordTextBox.Texts = Decrypt(Settings.Default["password"].ToString(), key);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            HttpConnection httpConnection = new HttpConnection();

            labelStatus.Visible = false;

            if (httpConnection.Login(usernameTextBox.Texts, passwordTextBox.Texts))
            {
                Settings.Default["username"] = usernameTextBox.Texts;
                Settings.Default["password"] = Encrypt(passwordTextBox.Texts, key);
                Settings.Default.Save();

                MainWindow mw = new MainWindow(httpConnection, this);
                Hide();
                mw.Show();
            }
            else
            {
                labelStatus.Visible = true;
                labelStatus.Text = "Неверный логин или пароль";
            }
        }

        public static string Encrypt(string plainText, string password)
        {
            var saltBytes = Encoding.UTF8.GetBytes(Salt);

            using (var passwordDeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, Iterations))
            {
                var keyBytes = passwordDeriveBytes.GetBytes(KeySize / 8);

                using (var aes = new AesCryptoServiceProvider())
                {
                    aes.KeySize = KeySize;
                    aes.BlockSize = BlockSize;
                    aes.Key = keyBytes;
                    aes.GenerateIV();

                    var ivBytes = aes.IV;

                    using (var encryptor = aes.CreateEncryptor())
                    {
                        var plainTextBytes = Encoding.UTF8.GetBytes(plainText);

                        var cipherTextBytes = encryptor.TransformFinalBlock(plainTextBytes, 0, plainTextBytes.Length);

                        var cipherText = Convert.ToBase64String(cipherTextBytes);
                        var iv = Convert.ToBase64String(ivBytes);

                        return $"{cipherText}:{iv}";
                    }
                }
            }
        }

        public static string Decrypt(string cipherText, string password)
        {
            var saltBytes = Encoding.UTF8.GetBytes(Salt);

            var parts = cipherText.Split(':');

            var cipherTextBytes = Convert.FromBase64String(parts[0]);
            var ivBytes = Convert.FromBase64String(parts[1]);

            using (var passwordDeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, Iterations))
            {
                var keyBytes = passwordDeriveBytes.GetBytes(KeySize / 8);

                using (var aes = new AesCryptoServiceProvider())
                {
                    aes.KeySize = KeySize;
                    aes.BlockSize = BlockSize;
                    aes.Key = keyBytes;
                    aes.IV = ivBytes;

                    using (var decryptor = aes.CreateDecryptor())
                    {
                        var plainTextBytes = decryptor.TransformFinalBlock(cipherTextBytes, 0, cipherTextBytes.Length);

                        var plainText = Encoding.UTF8.GetString(plainTextBytes);

                        return plainText;
                    }
                }
            }
        }

        private void customBTN1_MouseEnter(object sender, EventArgs e)
        {
            customBTN1.TextColor = Color.White;
        }

        private void customBTN1_MouseLeave(object sender, EventArgs e)
        {
            customBTN1.TextColor = Color.FromArgb(35, 39, 53);
        }

        private void textBox_MouseEnter(object sender, EventArgs e)
        {
            ((RoundTB)sender).BackColor = Color.FromArgb(242, 242, 242);
        }

        private void textBox_MouseLeave(object sender, EventArgs e)
        {
            ((RoundTB)sender).BackColor = Color.White;

        }
    }
}

