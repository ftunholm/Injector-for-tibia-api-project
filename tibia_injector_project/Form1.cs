using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TibiaAPI_Project.Player;


namespace tibia_injector_project
{
    public partial class Form1 : Form
    {
        Injector inj;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inject_btn_Click(object sender, EventArgs e)
        {
            inj = new Injector();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inj.test();
        }
    }
}
