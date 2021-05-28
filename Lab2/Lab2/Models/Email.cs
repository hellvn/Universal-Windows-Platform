using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Lab2.Models
{
    class Email
    {
        private string mailTo;
        private string title;
        private string content;
        private TextBox emailAddress;
        private TextBox title1;
        private TextBox content1;

        public Email(string mailTo, string title, string content)
        {
            MailTo = mailTo;
            Title = title;
            Content = content;

        }

        public Email(TextBox emailAddress, TextBox title1, TextBox content1)
        {
            this.emailAddress = emailAddress;
            this.title1 = title1;
            this.content1 = content1;
        }

        public string MailTo
        {
            get => mailTo;
            set => mailTo = value;
        }
        public string Title
        {
            get => title;
            set => title = value;
        }
        public string Content
        {
            get => content;
            set => content = value;
        }
    }
}
