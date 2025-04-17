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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ReservationReleasedEventMessage(object sender, ctrlTableReservation.TableReservationCostArgs e)
        {
            MessageBox.Show($"{e.TableName} has been released. Total Cost = {e.TotalCost}$", "Reservation Released", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
