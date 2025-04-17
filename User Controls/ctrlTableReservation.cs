using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiliardTableReservation
{
    public partial class ctrlTableReservation : UserControl
    {

        public class TableReservationCostArgs : EventArgs
        {
            public float TotalCost { get; }
            public string TableName { get; }
            public int Hours { get; }
            public int Minutes { get; }
            public int Seconds { get; }

            public TableReservationCostArgs(float prTotalCost, string prTableName, int prHours, int prMinutes, int prSeconds)
            {
                TotalCost = prTotalCost;
                TableName = prTableName;
                Hours = prHours;
                Minutes = prMinutes;
                Seconds = prSeconds;
            }
        }

        public string TableName
        {
            get { return lblTableName.Text; }
            set
            {
                lblTableName.Text = value;
            }
        }
        public ctrlTableReservation()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TableTimer.Start();
            txtOwner.Enabled = false;
            nudHourlyPrice.Enabled = false;
            btnStart.Enabled = false;
            btnEnd.Enabled = true;
            btnReset.Enabled = false;
        }

        private int seconds;
        private int minutes;
        private int hours;

        private void TableTimer_Tick(object sender, EventArgs e)
        {
            ++seconds;
            if (seconds == 60)
            {
                lblSec.Text = "00";
                seconds = 0;
                ++minutes;
            }
            else
            {
                if (seconds < 10)
                {
                    lblSec.Text = "0" + seconds.ToString();
                }
                else
                {
                    lblSec.Text = seconds.ToString();
                }
            }

            if (minutes == 60)
            {
                lblMin.Text = "00";
                minutes = 0;
                ++hours;
            }
            else
            {
                if (minutes < 10)
                {
                    lblMin.Text = "0" + minutes.ToString();
                }
                else
                {
                    lblMin.Text = minutes.ToString();
                }
            }
        }

        public event EventHandler<TableReservationCostArgs> ReservationEnded;

        private void btnEnd_Click(object sender, EventArgs e)
        {
            TableTimer.Stop();
            btnStart.Enabled = true;
            btnEnd.Enabled = false;
            btnReset.Enabled = true;

            int HourlyPrice = (int)nudHourlyPrice.Value;

            float TotalCostPerHour = (Convert.ToSingle(lblHour.Text) * HourlyPrice);
            float TotalCostPerMinute = (Convert.ToSingle(lblMin.Text) * HourlyPrice / 60);
            float TotalCostPerSecond = (Convert.ToSingle(lblSec.Text) * HourlyPrice / 3600);

            float TotalCost = TotalCostPerHour + TotalCostPerMinute + TotalCostPerSecond;

            ReservationEnded(this, new TableReservationCostArgs(TotalCost, TableName, Convert.ToInt32(lblHour.Text), 
                Convert.ToInt32(lblMin.Text), Convert.ToInt32(lblMin.Text)));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            hours = 0;
            minutes = 0;
            seconds = 0;

            lblHour.Text = "00";
            lblMin.Text = "00";
            lblSec.Text = "00";


            txtOwner.Text = "";
            txtOwner.Enabled = true;

            nudHourlyPrice.Value = nudHourlyPrice.Minimum;
            nudHourlyPrice.Enabled = true;
        }
    }
}
