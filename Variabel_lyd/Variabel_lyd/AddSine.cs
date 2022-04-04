using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variabel_lyd
{
    public partial class AddSine : Form
    {
        
        public AddSine()
        {
            InitializeComponent();
        }
        public delegate void SineHandler(SineCalculator values);
        public event SineHandler ValuesEntered;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            SineCalculator values = new SineCalculator((int)numPeriods.Value, (float)numAmplitude.Value, (float)numOffset.Value);
            ValuesEntered(values);
            this.Close();
        }
    }
}
