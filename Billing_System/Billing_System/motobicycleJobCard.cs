﻿using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class motobicycleJobCard : Form
    {

        // private string date;
        public motobicycleJobCard()
        {
            InitializeComponent();
            //date = DateTime.Now.ToString("mm/dd/yyyy");
        }

        private void print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private Bitmap memoryimg;

        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void motobicycleJobCard_Load(object sender, EventArgs e)
        {
            lbl_customerName.Text = frm_motoBicycle.setCustomerName;
            lbl_vehicleModel.Text = frm_motoBicycle.setvehicleModel;
            lbl_dateReceived.Text = frm_motoBicycle.setdateReceived;
            lbl_time.Text = frm_motoBicycle.settime;
            lbl_fuelType.Text = frm_motoBicycle.setfuelType;
            lbl_address.Text = frm_motoBicycle.setaddress;
            lbl_regNo.Text = frm_motoBicycle.setregNo;
            lbl_odoMeter.Text = frm_motoBicycle.setodoMeter;
            lbl_odoMeterb.Text = frm_motoBicycle.setodoMeter;
            lbl_phoneNumber.Text = frm_motoBicycle.setphoneNumber;
            lbl_chassisNo.Text = frm_motoBicycle.setchassisNo;
            lbl_cName.Text = frm_motoBicycle.setcName;
            lbl_complain1.Text =  frm_motoBicycle.setcomplaints1;
            lbl_complain2.Text =  frm_motoBicycle.setcomplaints2;
            lbl_complain3.Text =  frm_motoBicycle.setcomplaints3;
            lbl_complain4.Text =  frm_motoBicycle.setcomplaints4;
            lbl_decision1.Text =  frm_motoBicycle.setdecision1;
            lbl_decision2.Text =  frm_motoBicycle.setdecision2;
            lbl_decision3.Text =  frm_motoBicycle.setdecision3;
            lbl_decision4.Text =  frm_motoBicycle.setdecision4;
            lbl_remarks.Text = frm_motoBicycle.setResultRemark;
            lbl_estimatedCostb.Text = frm_motoBicycle.setestimatedCost;
            lbl_pDateb.Text = frm_motoBicycle.setpDate;
            lbl_dtimeb.Text = frm_motoBicycle.settime;
            lbl_cInformb.Text = frm_motoBicycle.setcInform;
            lbl_nDateb.Text = DateTime.Now.ToShortDateString();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            print(this.panel1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
