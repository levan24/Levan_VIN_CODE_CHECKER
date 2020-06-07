using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace VinCodeChecker
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            MetroStyleManager.Default.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.vindecoderz.com/EN/check-lookup" + "/" + textBox1.Text); // URL
            label3.Text = textBox1.Text;
            // IWebElement SearchInput = Browser.FindElement(By.Id("vin_number")); // If your website have INPUT for searching, use this code and 
            // SearchInput.SendKeys("VIN_CODE / or Something else" + OpenQA.Selenium.Keys.Enter); // this code too, for tap enter and searching

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)    // make a placeholder
        {
            if (textBox1.Text == "ENTER VIN CODE HERE")
            {
                textBox1.Text = "";

                textBox1.ForeColor = Color.Black;

            }
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // this.Width = webBrowser1.Document.Body.ScrollRectangle.Width + 40;//Border
            //  this.Height = webBrowser1.Document.Body.ScrollRectangle.Height + 40;//Border
            // webBrowser1.Size = webBrowser1.Document.Body.ScrollRectangle.Size;

            //  if (IsHorizontalScrollbarPresent)
            //  {
            //      webBrowser1.Size = new Size(webBrowser1.Document.Body.ScrollRectangle.Width, webBrowser1.Document.Body.ScrollRectangle.Height);
            //     Form1.ActiveForm.Size = new Size(webBrowser1.Document.Body.ScrollRectangle.Width, webBrowser1.Document.Body.ScrollRectangle.Height);
            //}
        }
      //  public bool IsHorizontalScrollbarPresent
       // {
           //   get
         //    {
               //  var widthofScrollableArea = webBrowser1.Document.Body.ScrollRectangle.Width;
               //  var widthofControl = webBrowser1.Document.Window.Size.Width;

               //  return widthofScrollableArea > widthofControl;
            // }
        // }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }
    }
}
