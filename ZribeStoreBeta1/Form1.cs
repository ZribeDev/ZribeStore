using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZribeStoreBeta1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem.ToString() == "Open-Source")
                {
                    SetCatagory("opensource");
                }
                if (listBox1.SelectedItem.ToString() == "Malware")
                {
                    SetCatagory("malware");
                }
            } catch
            {
                // ss
            }
            
        }




        public void SetCatagory(string CA)
        {
            try
            {
                listBox2.Items.Clear();

                if (CA == "opensource")
                {
                    listBox2.Items.Add("Notepad++");
                    listBox2.Items.Add("7-ZIP");
                    listBox2.Items.Add("VLC MediaPlayer");
                    listBox2.Items.Add("Krita");
                    listBox2.Items.Add("ZribeStore");
                }

                if (CA == "malware")
                {
                    listBox2.Items.Add("MalwareWatch");
                    
                }



            }
            catch
            {
                // ss
            }




        }

        public void SetITEM(string item)
        {
            try
            {


                if (item == "notepad++")
                {
                    label1.Text = "Name: Notepad++";
                    label2.Text = "Description: Amazing Open-Source Replacment For Windows Notepad!";
                    label3.Text = "Release Date: UNKNOWN";
                }

                if (item == "vlcmp")
                {
                    label1.Text = "Name: VLC MediaPlayer";
                    label2.Text = "Description: Great Open-Source MediaPlayer!";
                    label3.Text = "Release Date: UNKNOWN";
                }

                if (item == "7zip")
                {
                    label1.Text = "Name: 7-ZIP";
                    label2.Text = "Description: Open-Source Archive Application.";
                    label3.Text = "Release Date: UNKNOWN";
                }
                if (item == "krita")
                {
                    label1.Text = "Name: Krita";
                    label2.Text = "Description: Open-Source Art Application.";
                    label3.Text = "Release Date: UNKNOWN";
                }


                if (item == "MalwareWatch")
                {
                    label1.Text = "Name: MalwareWatch";
                    label2.Text = "Description: Malware And Application Database.";
                    label3.Text = "Release Date: ?/?/2017";
                    label6.Text = "Owner: Enderman - ON MALWAREWATCH / GITHUB";
                }
                if (item == "ZribeStore")
                {
                    label1.Text = "Name: ZribeStore";
                    label2.Text = "Description: OpenSource Application Store.";
                    label3.Text = "Release Date: 16/08/2021";
                    label6.Text = "Owner: ZribeDev";
                }



            }
            catch
            {
                // ss
            }
            



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.SelectedItem.ToString() == "Notepad++")
                {
                    SetITEM("notepad++");
                }
                if (listBox2.SelectedItem.ToString() == "VLC MediaPlayer")
                {
                    SetITEM("vlcmp");
                }
                if (listBox2.SelectedItem.ToString() == "7-ZIP")
                {
                    SetITEM("7zip");
                }
                if (listBox2.SelectedItem.ToString() == "Krita")
                {
                    SetITEM("krita");
                }
                if (listBox2.SelectedItem.ToString() == "MalwareWatch")
                {
                    SetITEM("MalwareWatch");
                }

                if (listBox2.SelectedItem.ToString() == "ZribeStore")
                {
                    SetITEM("ZribeStore");
                }
            }
            catch
            {
                // ss
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.SelectedItem.ToString() == "Notepad++")
                {
                    Process.Start("https://notepad-plus-plus.org/");
                }

                if (listBox2.SelectedItem.ToString() == "7-ZIP")
                {
                    Process.Start("https://www.7-zip.org/");
                }

                if (listBox2.SelectedItem.ToString() == "VLC MediaPlayer")
                {
                    Process.Start("https://www.videolan.org/vlc/index.html");
                }
                if (listBox2.SelectedItem.ToString() == "Krita")
                {
                    Process.Start("https://krita.org/");
                }

                if (listBox2.SelectedItem.ToString() == "MalwareWatch")
                {
                    Process.Start("https://malwarewatch.org/");
                }
                if (listBox2.SelectedItem.ToString() == "ZribeStore")
                {
                    Process.Start("https://github.com/ZribeDev/ZribeStore/releases");
                }
            }
            catch
            {
                // ss
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.SelectedItem.ToString() == "Notepad++")
                {
                    Process.Start("https://github.com/notepad-plus-plus/notepad-plus-plus");
                }

                if (listBox2.SelectedItem.ToString() == "7-ZIP")
                {
                    Process.Start("https://github.com/kornelski/7z");
                }

                if (listBox2.SelectedItem.ToString() == "VLC MediaPlayer")
                {
                    Process.Start("https://github.com/videolan/vlc");
                }
                if (listBox2.SelectedItem.ToString() == "Krita")
                {
                    Process.Start("https://github.com/KDE/krita");
                }
                if (listBox2.SelectedItem.ToString() == "MalwareWatch")
                {
                    Process.Start("https://github.com/Endermanch/MalwareDatabase");
                }
                if (listBox2.SelectedItem.ToString() == "ZribeStore")
                {
                    Process.Start("https://github.com/ZribeDev/ZribeStoreBeta1");
                }
            }
            catch
            {
                // ss
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
