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
            for(int i=0; i <10;i++)
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
            geckoWebBrowser.Navigate("about:memory");
            await Task.Delay(999999000);
        }
    }
}
