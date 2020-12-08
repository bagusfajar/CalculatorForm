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
    public partial class hslHitung : Form
    {
        rumus rms = new rumus();
        public hslHitung()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            Calculator Cal = new Calculator();
            Cal.OnCreate += Cal_OnCreate;
            Cal.ShowDialog();
        }
        private void Cal_OnCreate(rumus rms)
        {
            listHasil.Items.Add("Hasil " + rms.Nilai_A +" "  + rms.Pilihan +" " + rms.Operasi + " " + rms.Nilai_B + " " + "=" + " " + rms.Hasil);
        }
    }
}
