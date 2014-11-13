﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NetOfficeTools.ExtendedWordCS4
{
    public partial class SamplePane : UserControl, NetOffice.WordApi.Tools.ITaskPane // Not necessary to implement ITaskPane but its helpful
    {
        #region Ctor

        public SamplePane()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private DateTime StartTime { get; set; }

        #endregion

        #region ITaskpane

        public void OnConnection(NetOffice.WordApi.Application application, NetOffice.OfficeApi._CustomTaskPane parentPane, object[] customArguments)
        {
            StartTime = DateTime.Now;
            buttonEnabled_Click(buttonEnabled, new EventArgs());
        }

        public void OnDisconnection()
        {

        }

        public void OnDockPositionChanged(NetOffice.OfficeApi.Enums.MsoCTPDockPosition position)
        {
            
        }

        public void OnVisibleStateChanged(bool visible)
        {
            
        }

        #endregion

        #region UI Trigger

        private void buttonEnabled_Click(object sender, EventArgs e)
        {
            if (timerRunningTime.Enabled)
            {
                timerRunningTime.Enabled = false;
                buttonEnabled.Text = "Enable";
                buttonEnabled.ImageKey = "alarmclock_run.png";
                labelTime.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            }
            else
            {
                timerRunningTime.Enabled = true;
                buttonEnabled.Text = "Disable";
                buttonEnabled.ImageKey = "alarmclock_stop.png";
                labelTime.ForeColor = Color.White;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            StartTime = DateTime.Now;
            labelTime.Text = "00:00:00";
        }

        private void timerRunningTime_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - StartTime;
            labelTime.Text = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);

        }

        #endregion
    }
}
