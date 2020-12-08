using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm
{
    public partial class Calculator : Form
    {
        public delegate void CreateUpdateEventHandler(rumus rms);
        public event CreateUpdateEventHandler OnCreate;
        private rumus rms;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            rms = new rumus();
            rms.Pilihan = this.cmbOperasi.Text.ToLower();
            rms.Operasi = string.Empty;
            rms.Hasil = 0;
            rms.Nilai_A = double.Parse(this.txtNilaiA.Text);
            rms.Nilai_B = double.Parse(this.txtNilaiB.Text);
             if (this.cmbOperasi.SelectedIndex == 0)
            {
                rms.Hasil = rms.Nilai_A + rms.Nilai_B;
                rms.Pilihan = "+";
            }
            else if (this.cmbOperasi.SelectedIndex == 1)
            {
                rms.Hasil = rms.Nilai_A - rms.Nilai_B;
                rms.Pilihan = "-";
            }
            else if (this.cmbOperasi.SelectedIndex == 2)
            {
                rms.Hasil = rms.Nilai_A * rms.Nilai_B;
                rms.Pilihan = "*";
            }

            if (this.cmbOperasi.SelectedIndex == 3)
            {
                rms.Hasil = rms.Nilai_A / rms.Nilai_B;
                rms.Pilihan = "/";
            }
            this.OnCreate(rms);
        }
    }
}
