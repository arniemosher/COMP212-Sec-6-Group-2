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
    public partial class NotificationSubscriptionManagercs : Form
    {
        Presenter presenter;

        public NotificationSubscriptionManagercs(Presenter presenter)
        {
            this.presenter = presenter;
            InitializeComponent();

            if (!presenter.getPublishSatus())
            {
                btnPublish.Enabled = false;
            }
            else
            {
                btnPublish.Enabled = true;
            }
        }

        private void manageSub_Click(object sender, EventArgs e)
        {
            ManageSubscription manageForm = new ManageSubscription(presenter);
            manageForm.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            PublishNotification pubForm = new PublishNotification(presenter);
            pubForm.ShowDialog();
        }
    }
}
