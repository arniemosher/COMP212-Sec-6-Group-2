using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab2
{
    public partial class ManageSubscription : Form
    {
        Presenter presenter;
        bool invalidEmail;
        public ManageSubscription(Presenter presenter)
        {
            InitializeComponent();
            this.presenter = presenter;
            checkEmailText(txtEmail.Text);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            checkEmailText(txtEmail.Text);
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string text = txtTextNotification.Text;
            //check email
            if (chkSendEmail.Checked)
            {
                if (!String.IsNullOrEmpty(email)&&!invalidEmail)
                {
                    presenter.notificationHandler += subscribeEmail;
                    presenter.notificationHandler.Invoke(email);
                    presenter.notificationHandler = null;
                }
                else
                {
                    MessageBox.Show("You haven't either filled in a valid email");
                }
            }

            //check mobile/text
            if (chkTextNotification.Checked)
            {
                if (!String.IsNullOrEmpty(text))
                {
                    presenter.notificationHandler += subscribeText;
                    presenter.notificationHandler.Invoke(text);
                    presenter.notificationHandler = null;
                }
                else
                {
                    MessageBox.Show("You haven't either filled in a valid phone number");
                } 
            }
        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string text = txtTextNotification.Text;
            presenter.notificationHandler += unsubsrcibeEmail;
            presenter.notificationHandler.Invoke(email);
            presenter.notificationHandler = null;
            presenter.notificationHandler += unsubscribeText;
            presenter.notificationHandler.Invoke(text);
            presenter.notificationHandler = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NotificationSubscriptionManagercs n = new NotificationSubscriptionManagercs(this.presenter);
            this.Hide();
            n.ShowDialog();
            this.Close();
        }

        private void checkEmailText(string text)
        {
            // reg ex found at https://stackoverflow.com/questions/5342375/regex-email-validation
            Regex emalRX = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!emalRX.IsMatch(text))
            {
                lblInvalidEmail.Visible = true;
                invalidEmail = true;
            }
            else
            {
                lblInvalidEmail.Visible = false;
                invalidEmail = false;
            }
        }

        private void subscribeEmail(string email)
        {
            //add to presenter list
            if (!presenter.EmailNotifications.Contains(email))
            {
                presenter.EmailNotifications.Add(email);
                MessageBox.Show($"{email} successfully added to E-mail notifications.");
            }
            else
            {
                MessageBox.Show($"{email} is already added to E-mail notifications.");
            }
        }

        private void subscribeText(string text)
        {
            if (!presenter.TextNotifications.Contains(text))
            {
                presenter.TextNotifications.Add(text);
                MessageBox.Show($"{text} successfully added to text notifications.");
            }
            else
            {
                MessageBox.Show($"{text} is already added to text notifications.");
            }

        }

        private void unsubsrcibeEmail(string email)
        {
            if (!String.IsNullOrEmpty(email) && presenter.EmailNotifications.Contains(email))
            {
                presenter.EmailNotifications.Remove(email);
                MessageBox.Show($"{email} succesfully removed from E-mail notifications.");
            }
            else if (String.IsNullOrEmpty(email)||invalidEmail)
            {
                MessageBox.Show("Please enter a valid email address");
            }
            else
            {
                MessageBox.Show($"{email} is not in the list of E-mail notifications.");
            }
        }

        private void unsubscribeText(string text) 
        {
            if (!String.IsNullOrEmpty(text) && presenter.EmailNotifications.Contains(text))
            {
                presenter.EmailNotifications.Remove(text);
                MessageBox.Show($"{text} succesfully removed from text notifications.");
            }
            else if (String.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please enter a valid mobile number");
            }
            else
            {
                MessageBox.Show($"{text} is not in the list of text notifications.");
            }
        }

        
    }
}
