using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace Gui
{
    public partial class TwitterForm : Form
    {
        private NotifyIcon notifyIcon;
        private ContextMenu contextMenu;
        private MenuItem menuItem;
        private MenuItem showFormMI;
        private bool realyClose;
        private string originalTwitt;

        public TwitterForm()
        {
            InitializeComponent();

            this.contextMenu = new ContextMenu();
            ConfigMenu();

            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Text = "Twitter Notifications";

            ConfigMenuItem();

            originalTwitt = new FeedManager().GetTwitts;

            Timer MyTimer = new Timer();
            MyTimer.Interval = (60 * 1000); // 1 min
            MyTimer.Tick += MyTimer_Tick;
            MyTimer.Start();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            if (!realyClose)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void ConfigMenuItem()
        {
            this.notifyIcon = new NotifyIcon(this.components);

            notifyIcon.Icon = Resource.appico;

            notifyIcon.ContextMenu = this.contextMenu;

            notifyIcon.Text = "Is there something new?";
            notifyIcon.Visible = true;

            notifyIcon.DoubleClick += this.notifyIcon1_DoubleClick;
        }

        private void ConfigMenu()
        {
            this.menuItem = new MenuItem();
            showFormMI = new MenuItem();

            this.contextMenu.MenuItems.AddRange(
                        new[] { this.menuItem, showFormMI });

            this.menuItem.Index = 0;
            this.menuItem.Text = "E&xit";
            this.menuItem.Click += this.menuItem1_Click;

            showFormMI.Text = "&Config";
            showFormMI.Click += config_click;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if (new FeedManager().IsModified(originalTwitt))
            {
                notifyIcon.ShowBalloonTip(10 * 1000, "changed", "changed", new ToolTipIcon());
            }
            else
            {
                notifyIcon.ShowBalloonTip(10 * 1000, "same", "same", new ToolTipIcon());
            }
        }


        private void notifyIcon1_DoubleClick(object Sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            this.Activate();
        }

        private void menuItem1_Click(object Sender, EventArgs e)
        {
            realyClose = true;
            Close();
        }

        private void config_click(object Sender, EventArgs e)
        {
            Show();
        }

        private void btnConfirmChange_Click(object sender, EventArgs e)
        {
            originalTwitt = new FeedManager().GetTwitts;
        }
    }
}
