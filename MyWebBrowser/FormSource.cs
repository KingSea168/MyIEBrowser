using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using MyWebBrowserModels;

namespace MyWebBrowser
{
    public partial class FormSource : Form
    {
        private string currAddress;

        public FormSource(string address)
        {
            InitializeComponent();

            currAddress = address;
        }

        private void FormSource_Load(object sender, EventArgs e)
        {
            rtb_source.Text = GetPageSource();
        }

        private string GetPageSource()
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(currAddress);
                var response = (HttpWebResponse)request.GetResponse();
                var responseStream = response.GetResponseStream();
                if (responseStream != null)
                {
                    var objReader = new StreamReader(responseStream, Encoding.Default);
                    var sourceStr = objReader.ReadToEnd();
                    response.Close();
                    return sourceStr;
                }
            }
            catch (Exception ex)
            {
                FileLog.LogError(ex);
            }
            
            return "无法获取该网页源文件!";
        }
    }
}
