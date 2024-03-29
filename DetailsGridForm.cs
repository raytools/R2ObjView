﻿using System.Windows.Forms;

namespace R2ObjView
{
    public partial class DetailsGridForm : ChildFrame
    {
        public DetailsGridForm(string title)
        {
            InitializeComponent();
            Text = title;
        }

        public void AddColumn(string name, int width = 60)
        {
            listView.Columns.Add(name, width);
        }

        public void AddItem(ListViewItem item)
        {
            listView.Items.Add(item);
        }

        public void AddItem(params ListViewItem[] items)
        {
            listView.Items.AddRange(items);
        }

        protected override void RefreshData()
        {

        }

        protected override void OnLevelChanged(string levelName)
        {
            DisableRefresh();
            DisableLevelChanged();
        }
    }
}
