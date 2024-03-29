﻿using POSWarehouse.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace POSWarehouse.Forms
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }

        public enum EnmAction
        {
            Wait,
            Start,
            Close
        }

        public enum EnmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        // usage: new Notification().ShowAlert("Success Alert", Notification.EnmType.Success);

        private Notification.EnmAction Action;
        private int x, y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.Action)
            {
                case EnmAction.Wait:
                    timer1.Interval = Classes.GlobalVars.NotificationTimeout;
                    Action = EnmAction.Close;
                    break;

                case EnmAction.Start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            Action = Notification.EnmAction.Wait;
                        }
                    }
                    break;

                case EnmAction.Close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left += 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        public void ShowAlert(string Message, EnmType Type)
        {

            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Notification frm = (Notification)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            SoundPlayer NotificationSound = null;

            switch (Type)
            {
                case EnmType.Success:
                    this.pictureBox1.Image = Resources.Notification_success;
                    this.BackColor = Color.SeaGreen;
                    NotificationSound = new SoundPlayer(Properties.Sound.notification_sound_success);
                    break;
                case EnmType.Error:
                    this.pictureBox1.Image = Resources.Notification_error;
                    this.BackColor = Color.IndianRed;
                    NotificationSound = new SoundPlayer(Properties.Sound.notification_sound_error);
                    break;
                case EnmType.Info:
                    this.pictureBox1.Image = Resources.Notification_info;
                    this.BackColor = Color.RoyalBlue;
                    NotificationSound = new SoundPlayer(Properties.Sound.notification_sound_information);
                    break;
                case EnmType.Warning:
                    this.pictureBox1.Image = Resources.Notification_warning;
                    this.BackColor = Color.DarkOrange;
                    NotificationSound = new SoundPlayer(Properties.Sound.notification_sound_warning);
                    break;
            }

            this.lbl_message.Text = Message;

            this.Show();
            this.Action = EnmAction.Start;
            this.timer1.Interval = 1;
            this.timer1.Start();

            if (NotificationSound != null)
                NotificationSound.Play();
        }
    }
}
