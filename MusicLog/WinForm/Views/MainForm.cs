﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MusicLog
{
    public partial class MainForm : Form
    {
        private MusicLogClient _musicLog;

        public MainForm()
        {
            InitializeComponent();
            _musicLog = MusicLogClient.Instance;
        }

        private void Input_Click(object sender, EventArgs e)
        {
            if (!InputPanel.Controls.Contains(InputModule.Instance))
            {
                InputPanel.Controls.Add(InputModule.Instance);
                InputModule.Instance.Dock = DockStyle.Fill;
                InputModule.Instance.BringToFront();
                InputModule.Instance.UpdateMusicLog(_musicLog);              
            }
            else
            {
                InputModule.Instance.BringToFront();
            }
        }

        private void InputPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!InputPanel.Controls.Contains(DatabaseModule.Instance))
            {
                InputPanel.Controls.Add(DatabaseModule.Instance);
                DatabaseModule.Instance.Dock = DockStyle.Fill;
                DatabaseModule.Instance.BringToFront();
                DatabaseModule.Instance.UpdateMusicLog(_musicLog);
                DatabaseModule.Instance.PopulateArtistList();
            }
            else
            {
                DatabaseModule.Instance.BringToFront();
            }
        }

        private void DatabasePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _musicLog.UpdateAllArtists();
        }
    }
}
