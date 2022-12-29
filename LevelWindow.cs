using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace chemaths
{

    public partial class LevelWindow : Form
    {
        int index;
        XmlDocument doc = new XmlDocument();
        XmlNodeList tasks, tasksR;
        XmlNode[] taskArray, taskArrayR;

        public void Start()
        {
            doc.Load("Levels.xml");
            tasks = doc.SelectNodes($"/root/level[@number='{(int)numericUpDown1.Value}']/task");
            tasksR = doc.SelectNodes($"/root/level[@number='results{(int)numericUpDown1.Value}']/task");
            taskArray = tasks.OfType<XmlNode>().ToArray();
            taskArrayR = tasksR.OfType<XmlNode>().ToArray();
        }
        public LevelWindow()
        {
            InitializeComponent();
        }

        private void active_panel_MouseDown(object sender, MouseEventArgs e)
        {
            active_panel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LevelWindow_Load(object sender, EventArgs e)
        {

        }
        /*public void Fisher_Yates(XmlNode[] taskArray, XmlNode[] taskArrayR)
        {
            Random rnd = new Random();
            for (int i = taskArray.Length - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                XmlNode temp1 = taskArray[j];
                XmlNode temp2 = taskArrayR[j];
                taskArray[j] = taskArray[i]; taskArrayR[j] = taskArrayR[i];
                taskArray[i] = temp1; taskArrayR[i] = temp2;
            }
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            Start();
            
            label2.Text = numericUpDown1.Value.ToString();
            label4.Text = "";
            label5.Text = "TAP TO START!";
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            Start();
            label5.Text = "Equation: " + (index + 1).ToString();
            if (index == 0) { label4.Text = " "; }
            else if (input_box.Text == taskArrayR[index - 1].InnerText)
            {
                label4.Text = input_box.Text + " IS RIGHT ANSWER!";
            }
            else label4.Text = input_box.Text + " IS WRONG ANSWER!";
            output_box.Text = taskArray[index].InnerText;
            index++;
        }
    }
}
