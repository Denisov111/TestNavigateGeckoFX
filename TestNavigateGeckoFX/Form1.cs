using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;
using System.Collections.Specialized;

namespace TestNavigateGeckoFX
{
    public partial class Form1 : Form
    {
        GeckoWebBrowser geckoWebBrowser;

        public Form1()
        {
            InitializeComponent();

            Xpcom.Initialize(Application.StartupPath + "\\Firefox\\");
            this.InitializeComponent();
            geckoWebBrowser = new GeckoWebBrowser
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom,
                Width = this.Width,
                Height = this.Height
            };
            Controls.Add(geckoWebBrowser);
            geckoWebBrowser.Navigate("www.google.com");
            GoTest();
        }

        async private void GoTest()
        {
            for (int i=0; i <300;i++)
            {
                geckoWebBrowser.Navigate("www.google.com");
                await Task.Delay(5000);
                geckoWebBrowser.Navigate("www.facebok.com");
                await Task.Delay(5000);
                geckoWebBrowser.Navigate("youtube.com");
                await Task.Delay(5000);
                geckoWebBrowser.Navigate("baidu.com");
                await Task.Delay(5000);
                geckoWebBrowser.Navigate("live.com");
                await Task.Delay(5000);
                geckoWebBrowser.Navigate("amazon.com");
            }

            /*
            StringCollection sc = new StringCollection();
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("groups.txt");
            while ((line = file.ReadLine()) != null)
            {
                sc.Add(line);
            }
            file.Close();
            
            foreach(string id in sc)
            {
                try
                {
                    geckoWebBrowser.Navigate("https://vk.com/club" + id);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                await Task.Delay(5000);
            }
            */
            geckoWebBrowser.Navigate("about:memory");
            await Task.Delay(999999000);
        }
    }
}
