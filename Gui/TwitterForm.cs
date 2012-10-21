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
        private NotifyIcon notifyIcon1;
        private ContextMenu contextMenu1;
        private MenuItem menuItem1;
        private bool realyClose;
        private string originalTwitt;

        public TwitterForm()
        {
            InitializeComponent();
            
            this.contextMenu1 = new ContextMenu();
            this.menuItem1 = new MenuItem();

            // Initialize contextMenu1 
            this.contextMenu1.MenuItems.AddRange(
                        new[] { this.menuItem1 });

            // Initialize menuItem1 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "E&xit";
            this.menuItem1.Click += this.menuItem1_Click;

            // Set up how the form should be displayed. 
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Text = "Notify Icon Example";

            // Create the NotifyIcon. 
            this.notifyIcon1 = new NotifyIcon(this.components);

            // The Icon property sets the icon that will appear 
            // in the systray for this application.
            notifyIcon1.Icon = Resource.appico;

            // The ContextMenu property sets the menu that will 
            // appear when the systray icon is right clicked.
            notifyIcon1.ContextMenu = this.contextMenu1;

            // The Text property sets the text that will be displayed, 
            // in a tooltip, when the mouse hovers over the systray icon.
            notifyIcon1.Text = "Form1 (NotifyIcon example)";
            notifyIcon1.Visible = true;

            // Handle the DoubleClick event to activate the form.
            notifyIcon1.DoubleClick += this.notifyIcon1_DoubleClick;

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

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if (new FeedManager().IsModified(originalTwitt))
            {
                notifyIcon1.ShowBalloonTip(10 * 1000, "changed", "changed", new ToolTipIcon());
            }
            else
            {
                notifyIcon1.ShowBalloonTip(10 * 1000, "same", "same", new ToolTipIcon());
            }
            //MessageBox.Show("The form will now be closed.", "Time Elapsed");
            //this.Close();
        }


        private void notifyIcon1_DoubleClick(object Sender, EventArgs e)
        {
            // Show the form when the user double clicks on the notify icon.

            // Set the WindowState to normal if the form is minimized.
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            // Activate the form.
            this.Activate();
        }

        private void menuItem1_Click(object Sender, EventArgs e)
        {
            realyClose = true;
            Close();
        }

    }
}
