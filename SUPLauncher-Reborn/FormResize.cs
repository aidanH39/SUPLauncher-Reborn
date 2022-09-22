using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUPLauncher_Reborn
{
    class FormResize
    {
        private Form form;
        Panel topControlPanel;
        public FormResize (Form form, Panel topControlPanel = null)
        {
            this.topControlPanel = topControlPanel;

            if (topControlPanel != null)
            {
                topControlPanel.MouseDown += TopPanel_MouseDown;
                topControlPanel.MouseMove += TopPanel_MouseMove;
                topControlPanel.MouseUp += TopPanel_MouseUp;
                topControlPanel.Cursor = Cursors.SizeAll;
            }

            this.form = form;

            Panel topPanel = new Panel();
            Panel bottomPanel = new Panel();
            Panel leftPanel = new Panel();
            Panel rightPanel = new Panel();

            topPanel.Cursor = Cursors.SizeNS;
            bottomPanel.Cursor = Cursors.SizeNS;
            leftPanel.Cursor = Cursors.SizeWE;
            rightPanel.Cursor = Cursors.SizeWE;

            topPanel.Dock = DockStyle.Top;
            bottomPanel.Dock = DockStyle.Bottom;
            leftPanel.Dock = DockStyle.Left;
            rightPanel.Dock = DockStyle.Right;

            topPanel.Height = 2;
            bottomPanel.Height = 2;
            leftPanel.Width = 2;
            rightPanel.Width = 2;

            topPanel.BackColor = Color.FromArgb(25, 25, 25);
            bottomPanel.BackColor = Color.FromArgb(25, 25, 25);
            leftPanel.BackColor = Color.FromArgb(25, 25, 25);
            rightPanel.BackColor = Color.FromArgb(25, 25, 25);

            form.Controls.Add(topPanel);
            form.Controls.Add(bottomPanel);
            form.Controls.Add(leftPanel);
            form.Controls.Add(rightPanel);
            toolTip = new ToolTip();
            toolTip.BackColor = Color.FromArgb(45, 45, 45);
            toolTip.ForeColor = Color.White;
            //toolTip.ToolTipTitle = "";
            toolTip.SetToolTip(topPanel, "Resize window");
            toolTip.SetToolTip(bottomPanel, "Resize window");
            toolTip.SetToolTip(leftPanel, "Resize window");
            toolTip.SetToolTip(rightPanel, "Resize window");
            toolTip.Draw += toolTip_draw;
            toolTip.OwnerDraw = true;

            topPanel.MouseDown += TopBorderPanel_MouseDown;
            topPanel.MouseMove += TopBorderPanel_MouseMove;
            topPanel.MouseUp += TopBorderPanel_MouseUp;

            bottomPanel.MouseDown += BottomPanel_MouseDown;
            bottomPanel.MouseMove += BottomPanel_MouseMove;
            bottomPanel.MouseUp += BottomPanel_MouseUp;

            leftPanel.MouseDown += LeftPanel_MouseDown;
            leftPanel.MouseMove += LeftPanel_MouseMove;
            leftPanel.MouseUp += LeftPanel_MouseUp;

            rightPanel.MouseDown += RightPanel_MouseDown;
            rightPanel.MouseMove += RightPanel_MouseMove;
            rightPanel.MouseUp += RightPanel_MouseUp;
        }

        ToolTip toolTip;

        bool isTopPanelDragged = false;
        bool isLeftPanelDragged = false;
        bool isRightPanelDragged = false;
        bool isBottomPanelDragged = false;
        bool isTopBorderPanelDragged = false;
        bool isWindowMaximized = false;
        Point offset;
        Size _normalWindowSize;
        Point _normalWindowLocation = Point.Empty;


        private void toolTip_draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(47, 129, 255)), new Rectangle(0, 0, 3, e.Bounds.Height));
            e.DrawText();
            
        }

        //**********************************************************************
        //top border panel
        private void TopBorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopBorderPanelDragged = true;
            }
            else
            {
                isTopBorderPanelDragged = false;
            }
        }

        private void TopBorderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < form.Location.Y)
            {
                if (isTopBorderPanelDragged)
                {
                    if (form.Height < 50)
                    {
                        form.Height = 50;
                        isTopBorderPanelDragged = false;
                    }
                    else
                    {
                        if (form.MaximumSize.Height >= form.Height - e.Y || form.MinimumSize.Height <= form.Height - e.Y)
                        {
                            //return;
                        }

                        int height = form.Height;
                        form.Height = form.Height - e.Y;
                        if (form.Height != height)
                            form.Location = new Point(form.Location.X, form.Location.Y + e.Y);
                    }
                }
            }
        }

        private void TopBorderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopBorderPanelDragged = false;
        }

        //**********************************************************************
        //top panel
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = form.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = form.Location.X - pointStartPosition.X;
                offset.Y = form.Location.Y - pointStartPosition.Y;
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

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = topControlPanel.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                form.Location = newPoint;

                if (form.Location.X > 2 || form.Location.Y > 2)
                {
                    if (form.WindowState == FormWindowState.Maximized)
                    {
                        form.Location = _normalWindowLocation;
                        form.Size = _normalWindowSize;
                        isWindowMaximized = false;
                    }
                }
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
            if (form.Location.Y <= 5)
            {
                if (!isWindowMaximized)
                {
                    _normalWindowSize = form.Size;
                    _normalWindowLocation = form.Location;

                    Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                    form.Location = new Point(0, 0);
                    form.Size = new System.Drawing.Size(rect.Width, rect.Height);
                    isWindowMaximized = true;
                }
            }
        }

        //**********************************************************************
        //left panel
        private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (form.Location.X <= 0 || e.X < 0)
            {
                isLeftPanelDragged = false;
                form.Location = new Point(10, form.Location.Y);
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    isLeftPanelDragged = true;
                }
                else
                {
                    isLeftPanelDragged = false;
                }
            }
        }

        private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < form.Location.X)
            {
                if (isLeftPanelDragged)
                {
                    if (form.Width < 100)
                    {
                        form.Width = 100;
                        isLeftPanelDragged = false;
                    }
                    else
                    {
                        form.Location = new Point(form.Location.X + e.X, form.Location.Y);
                        form.Width = form.Width - e.X;
                    }
                }
            }
        }

        private void LeftPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftPanelDragged = false;
        }

        //**********************************************************************
        //right panel
        private void RightPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isRightPanelDragged = true;
            }
            else
            {
                isRightPanelDragged = false;
            }
        }

        private void RightPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightPanelDragged)
            {
                if (form.Width < 100)
                {
                    form.Width = 100;
                    isRightPanelDragged = false;
                }
                else
                {
                    form.Width = form.Width + e.X;
                }
            }
        }

        private void RightPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isRightPanelDragged = false;
        }

        //**********************************************************************
        //bottom panel
        private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isBottomPanelDragged = true;
            }
            else
            {
                isBottomPanelDragged = false;
            }
        }

        private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isBottomPanelDragged)
            {
                if (form.Height < 50)
                {
                    form.Height = 50;
                    isBottomPanelDragged = false;
                }
                else
                {
                    form.Height = form.Height + e.Y;
                }
            }
        }

        private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isBottomPanelDragged = false;
        }
    }
}
