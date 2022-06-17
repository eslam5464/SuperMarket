using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMarket.UserControls
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private readonly IDictionary<int, Color> ColorsDict = new Dictionary<int, Color>();

        private void Settings_Load(object sender, EventArgs e)
        {
            SetupColorsDict();
        }

        private void SetupColorsDict()
        {
            Color[] colors = { Color.Red, Color.Green, Color.Blue,
                Color.Purple,Color.Brown};

            for (int i = 0; i < colors.Length; i++)
                ColorsDict.Add(i, colors[i]);

            for (int i = 0; i < ColorsDict.Count; i++)
                txt_color.Items.Add(ColorsDict[i].Name);
        }

        private void txt_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_color.SelectedIndex != -1)
                pan_color_sample.BackColor = ColorsDict[txt_color.SelectedIndex];
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            if (txt_color.SelectedIndex != -1)
                Properties.Settings.Default.AppColor = ColorsDict[txt_color.SelectedIndex];
        }
    }
}
