using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HelloRegex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            a7Message.SetShowBox(richTextBox1);
        }
        a7IFC _IFC;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = @"C:\Users\user\Desktop\theBuilding.ifc";

            _IFC = new a7IFC(textBox1.Text);



            //StreamReader reader = new StreamReader(textBox1.Text);
            //MatchCollection getMatches = Regex.Matches(reader.ReadToEnd(), "#.*?;");//Wow 威猛
            //richTextBox1.Text = "Count : " + getMatches.Count + "\n";
            //reader.Close();


            //StringBuilder build = new StringBuilder("");
            //for (int i = 0; i < getMatches.Count; i++)
            //    build.Append(getMatches[i] + "\n");


            //StreamWriter writer = new StreamWriter(textBox1.Text + ".test");
            //writer.Write(build);
            //writer.Close();
        }
    }
}
