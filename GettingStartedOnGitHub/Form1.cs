using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GettingStartedOnGitHub
{
    public partial class Form1 : Form
    {
        int upper_sentence_to_be_displayed = 1;
        int lower_sentence_to_be_displayed = 1;

        public Form1()
        {
            InitializeComponent();
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Config","config.ini"));
            string useFullScreenStr = data["last_displayed_sentence_numbers"]["upper"];
            upper_sentence_to_be_displayed = int.Parse(useFullScreenStr);
            useFullScreenStr = data["last_displayed_sentence_numbers"]["lower"];
            lower_sentence_to_be_displayed = int.Parse(useFullScreenStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(upper_sentence_to_be_displayed.ToString());
        }
    }
}
