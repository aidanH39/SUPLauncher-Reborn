using HeyRed.MarkdownSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SUPLauncher_Reborn.DupeMarket;

namespace SUPLauncher_Reborn
{
    public partial class DupeDetails : Form
    {

        Dupe dupe;

        public DupeDetails(Dupe dupe)
        {
            this.dupe = dupe;
            InitializeComponent();
            Markdown m = new Markdown();
            web_description.DocumentText = "<link rel=\"preconnect\" href=\"https://fonts.googleapis.com\"><link rel=\"preconnect\" href=\"https://fonts.gstatic.com\" crossorigin ><link href=\"https://fonts.googleapis.com/css2?family=Roboto&family=Source+Sans+Pro:wght@400;600&display=swap\" rel=\"stylesheet\">  <style>body { background: rgb(25,25,25); color: white; font-family: 'Roboto', sans-serif; }</style> " + m.Transform(dupe.description);
            if (dupe.img_url != null) img_screenshot.LoadAsync(dupe.img_url);
            frm_main.loadImage(img_creator, "https://superiorservers.co/api/avatar/" + dupe.creator);
            lbl_creator.Text = dupe.creator_name;
            lbl_dupeName.Text = dupe.title;
        }

        bool isTopPanelDragged = false;
        bool isWindowMaximized = false;
        Point offset;
        Size _normalWindowSize;
        Point _normalWindowLocation = Point.Empty;
        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point
                {
                    X = this.Location.X - pointStartPosition.X,
                    Y = this.Location.Y - pointStartPosition.Y
                };
            }
            else
            {
                isTopPanelDragged = false;
            }
            if (e.Clicks == 2)
            {
                isTopPanelDragged = false;

            }
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TopBar.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;

                if (this.Location.X > 2 || this.Location.Y > 2)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.Location = _normalWindowLocation;
                        this.Size = _normalWindowSize;

                        isWindowMaximized = false;
                    }
                }
            }
        }

        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
            if (this.Location.Y <= 5)
            {
                if (!isWindowMaximized)
                {
                    _normalWindowSize = this.Size;
                    _normalWindowLocation = this.Location;

                    Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                    this.Location = new Point(0, 0);
                    this.Size = new System.Drawing.Size(rect.Width, rect.Height);

                    isWindowMaximized = true;
                }
            }
        }

        private void DupeDetails_Load(object sender, EventArgs e)
        {
            if (dupe.creator != Program.steamid.ToString())
            {
                btn_download.Width = 452;
                btn_access.Visible = false;
                btn_remove.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DupeMarket.downloadDupe(this.dupe);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_access_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Steam ID of the person you wish to give access to.", "Enter SteamID");
            DupeMarket.DupeGiveAccess(dupe.id, input);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Are you sure? Type \"delete\" to delete this dupe from the market place. No caps!", "Are you sure?");
            if (input == "delete")
            {
                DupeMarket.removeDupe(dupe.id);
                this.Close();
            }
        }
    }
}
