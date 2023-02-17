using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class PublishNotification : Form
    {
        Presenter presenter; 
        public PublishNotification(Presenter presenter)
        {
            InitializeComponent();
            this.presenter = presenter;
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            string message = txtPublish.Text;
            presenter.notificationHandler += publishMessage;
            presenter.notificationHandler.Invoke(message);
            presenter.notificationHandler = null;
        }

        private void publishMessage(string message)
        {
            string result = "";
            if (!String.IsNullOrEmpty(message) && presenter.getPublishSatus())
            {
                result = "This is a message to the following subscribers:\n";
                if (presenter.EmailNotifications != null && presenter.EmailNotifications.Count > 0)
                {
                    foreach (string email in presenter.EmailNotifications)
                    {
                        result += email + "\n";
                    }
                }
                if (presenter.TextNotifications != null && presenter.TextNotifications.Count > 0)
                {
                    foreach (string text in presenter.TextNotifications)
                    {
                        result += text + "\n";
                    }
                }
            }

            MessageBox.Show(result);
            MessageBox.Show(message);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
