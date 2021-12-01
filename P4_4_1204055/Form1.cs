using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P4_4_1204055
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).Any(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
            }
        }

        private void txtNomor_Leave(object sender, EventArgs e)
        {
            if(txtNomor.Text.Length > 12)
            {
                epWarning.SetError(txtNomor, "");
                epWrong.SetError(txtNomor, "No telfon tidak boleh lebih dari 12 digit ya!");
                epCorrect.SetError(txtNomor, "");
            }
            else if (txtNomor.Text == "")
            {
                epWarning.SetError(txtNomor, "Textbox Angka tidak boleh kosong!");
                epWrong.SetError(txtNomor, "");
                epCorrect.SetError(txtNomor, "");
            }
            else
            {
                if ((txtNomor.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtNomor, "Betul!");
                    epWarning.SetError(txtNomor, "");
                    epWrong.SetError(txtNomor, "");

                }
                else
                {

                    epWarning.SetError(txtNomor, "");
                    epCorrect.SetError(txtNomor, "");
                    epWrong.SetError(txtNomor, "Inputan hanya boleh huruf!");
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Textbox Email tidak boleh kosong!");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "Betul!");

                }
                else
                {
                    epWarning.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "Format email salah!\nContoh: a@b.c");
                }
            }
        }



        private void txtAplikasi_Leave(object sender, EventArgs e)
        {
            if (txtAplikasi.Text == "")
            {
                epWarning.SetError(txtAplikasi, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtAplikasi, "");
                epCorrect.SetError(txtAplikasi, "");
            }
            else
            {
                if (txtAplikasi.Text != txtAplikasi.Text.ToLower())
                {
                    epWarning.SetError(txtAplikasi, "");
                    epWrong.SetError(txtAplikasi, "Nama Aplikasi diharapkan menggunakan huruf kecil ya!");
                    epCorrect.SetError(txtAplikasi, "");
                }
                else if ((txtAplikasi.Text).Any(Char.IsLetter))
                {
                    epWarning.SetError(txtAplikasi, "");
                    epWrong.SetError(txtAplikasi, "");
                    epCorrect.SetError(txtAplikasi, "Betul!");
                }

                else
                {
                    epWrong.SetError(txtAplikasi, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtAplikasi, "");
                    epCorrect.SetError(txtAplikasi, "");
                }
            }
        }



        private void txtKota_Leave(object sender, EventArgs e)
        {
            if (txtKota.Text == "")
            {
                epWarning.SetError(txtKota, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtKota, "");
                epCorrect.SetError(txtKota, "");
            }
            else
            {
                if (txtKota.Text != txtKota.Text.ToUpper())
                {
                    epWarning.SetError(txtKota, "");
                    epWrong.SetError(txtKota, "Nama Aplikasi diharapkan menggunakan huruf kapital ya!");
                    epCorrect.SetError(txtKota, "");
                }
                else if ((txtKota.Text).Any(Char.IsLetter))
                {
                    epWarning.SetError(txtKota, "");
                    epWrong.SetError(txtKota, "");
                    epCorrect.SetError(txtKota, "Betul!");
                }

                else
                {
                    epWrong.SetError(txtKota, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtKota, "");
                    epCorrect.SetError(txtKota, "");
                }
            }
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                   ("Nama : " + txtHuruf.Text +
                   "\nNomor Handphone    : " + txtNomor.Text +
                   "\nEmail    : " + txtEmail.Text +
                   "\nNama Aplikasi: " + txtAplikasi.Text +
                   "\nTujuan Aplikasi: " + txtKota.Text,
                   "Informasi Pendaftaran",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
    }

