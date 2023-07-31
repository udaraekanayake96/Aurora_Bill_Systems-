﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Billing_System
{

    
    public partial class frm_motoBicycle : Form
    {
        public static string setCustomerName = "";
        public static string setvehicleModel = "";
        public static string setdateReceived = "";
        public static string settime = "";
        public static string setfuelType = "";
        public static string setaddress = "";
        public static string setregNo = "";
        public static string setodoMeter = "";
        public static string setphoneNumber = "";
        public static string setchassisNo = "";
        public static string setcName = "";
        public static string setcomplaints1 = "";
        public static string setcomplaints2 = "";
        public static string setcomplaints3 = "";
        public static string setcomplaints4 = "";
        public static string setdecision1 = "";
        public static string setdecision2 = "";
        public static string setdecision3 = "";
        public static string setdecision4 = "";
        public static string setremark1 = "";
        public static string setestimatedCost = "";
        public static string setpDate = "";
        public static string setdtime = "";
        public static string setcInform = "";
        

        public frm_motoBicycle()
        {
            InitializeComponent();
        }

        private bool IsValidNumericInput(string input)
        {
            // Regular expression pattern to check for only numbers
            string pattern = @"^\d+$";
            return Regex.IsMatch(input, pattern);
        }

        private bool IsValidStringInput(string input)
        {
            // Regular expression pattern to check for only string values
            string pattern = @"^[a-zA-Z]+$";
            return Regex.IsMatch(input, pattern);
        }

        //private void ValidateInputs()
        //{
        //    if (!IsValidStringInput(txt_regNo.Text))
        //    {
        //        MessageBox.Show("Invalid input! Please enter Correct Vehical Number.");
        //        txt_regNo.Clear();
        //        return;
        //    }
        //    else
        //    {
        //        if (!IsValidStringInput(txt_customerName.Text))
        //        {
        //            MessageBox.Show("Invalid input! Please enter Correct Vehical Number.");
        //            txt_customerName.Clear();
        //            return;
        //        }
        //        else
        //        {
        //            if (!IsValidStringInput(txt_fuel.Text))
        //            {
        //                MessageBox.Show("Invalid input! Please enter Correct Vehical Number.");
        //                txt_fuel.Clear();
        //                return;
        //            }
        //            else
        //            {
        //                if (!IsValidStringInput(txt_address.Text))
        //                {
        //                    MessageBox.Show("Invalid input! Please enter Correct Vehical Number.");
        //                    txt_address.Clear();
        //                    return;
        //                }
        //                else
        //                {
        //                    if (!IsValidStringInput(txt_odoMeter.Text))
        //                    {
        //                        MessageBox.Show("Invalid input! Please enter Correct Vehical Number.");
        //                        txt_odoMeter.Clear();
        //                        return;
        //                    }
        //                    else
        //                    {

        //                        if (!IsValidStringInput(txt_chassisNo.Text))
        //                        {
        //                            MessageBox.Show("Invalid input! Please enter Correct Vehical Number.");
        //                            txt_chassisNo.Clear();
        //                            return;
        //                        }
        //                        else
        //                        {
        //                            if (!IsValidStringInput(txt_company.Text))
        //                            {
        //                                MessageBox.Show("Invalid input! Please enter Correct Vehical Number.");
        //                                txt_company.Clear();
        //                                return;
        //                            }
        //                            else
        //                            {

        //                                if (!IsValidStringInput(txt_phoneNumber.Text))
        //                                {
        //                                    MessageBox.Show("Invalid input! Please enter Correct Vehical Number.");
        //                                    txt_phoneNumber.Clear();
        //                                    return;
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }


        //}
        private void btn_process_Click(object sender, EventArgs e)
        {
           

            connection_class.open_connection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `jobcard`( `registerNumber`, `customerName`, `vehicleModel`, `fuelType`, `customerAddress`, `dateReceived`,  `odoMeter`, `chassisNumber`, `companyName`, `phoneNumber`, `complaints1`,`complaints2`,`complaints3`,`complaints4`, `decision1`,`decision2`,`decision3`,`decision4`, `estimatedCost`, `dateProposed`, `customerInformed`, `remarks`) VALUES( @txt_registrationNo, @txt_customerName, @cmb_vehicleModel,  @txt_fuelType,  @txt_address, @date_Received, @txt_odoMoter, @txt_chassisNo, @txt_company, @txt_phoneNumber, @txt_complain1, @txt_complain2, @txt_complain3, @txt_complain4, @txt_decision1, @txt_decision2, @txt_decision3, @txt_decision4,  @txt_estimatedCost, @date_Proposed, @cmb_cInform, @txt_remarks )", connection_class.con);
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@txt_registrationNo", txt_regNo.Text);
            cmd.Parameters.AddWithValue("@txt_customerName", txt_customerName.Text);
            cmd.Parameters.AddWithValue("@cmb_vehicleModel", cmb_vehicleModel.Text);
            cmd.Parameters.AddWithValue("@txt_chassisNo", txt_chassisNo.Text);
            cmd.Parameters.AddWithValue("@txt_fuelType", txt_fuel.Text);
            cmd.Parameters.AddWithValue("@txt_odoMoter", txt_odoMeter.Text);
            cmd.Parameters.AddWithValue("@txt_address", txt_address.Text);
            cmd.Parameters.AddWithValue("@txt_company", txt_company.Text);
            cmd.Parameters.AddWithValue("@txt_phoneNumber", txt_phoneNumber.Text);


            cmd.Parameters.AddWithValue("@txt_complain1", txt_complain1.Text);
            cmd.Parameters.AddWithValue("@txt_complain2", txt_complain2.Text);
            cmd.Parameters.AddWithValue("@txt_complain3", txt_complain3.Text);
            cmd.Parameters.AddWithValue("@txt_complain4", txt_complain4.Text);
            cmd.Parameters.AddWithValue("@txt_decision1", txt_decision1.Text);
            cmd.Parameters.AddWithValue("@txt_decision2", txt_decision2.Text);
            cmd.Parameters.AddWithValue("@txt_decision3", txt_decision3.Text);
            cmd.Parameters.AddWithValue("@txt_decision4", txt_decision4.Text);

            cmd.Parameters.AddWithValue("@txt_remarks", txt_remarks.Text);
            cmd.Parameters.AddWithValue("@txt_estimatedCost", txt_estimatedCost.Text);
            cmd.Parameters.AddWithValue("@cmb_cInform", cmb_cInform.Text);

            cmd.Parameters.AddWithValue("@date_Received", date_Received.Text);
            cmd.Parameters.AddWithValue("@date_Proposed", date_Proposed.Text);




            cmd.ExecuteNonQuery();
            connection_class.close_connection();

            setCustomerName = txt_customerName.Text;
            setvehicleModel = cmb_vehicleModel.Text;
            setdateReceived = date_Received.Text;
            settime = DateTime.Now.ToString("hh:mm:ss tt"); 
            setfuelType = txt_fuel.Text;
            setaddress = txt_address.Text;
            setregNo = txt_regNo.Text;
            setodoMeter = txt_odoMeter.Text;
            setphoneNumber = txt_phoneNumber.Text;
            setchassisNo = txt_chassisNo.Text;
            setcName = txt_company.Text;
            setcomplaints1 = txt_complain1.Text;
            setcomplaints2 = txt_complain2.Text;
            setcomplaints3 = txt_complain3.Text;
            setcomplaints4 = txt_complain4.Text;
            setdecision1 = txt_decision1.Text;
            setdecision2 = txt_decision2.Text;
            setdecision3 = txt_decision3.Text;
            setdecision4 = txt_decision4.Text;
            setremark1 = txt_remarks.Text;
            setestimatedCost = txt_estimatedCost.Text;
            setpDate = date_Proposed.Text;
            setdtime = "";
            setcInform = cmb_cInform.Text;
            

            MessageBox.Show("Saved Successfully!");
            motobicycleJobCard mbcard = new motobicycleJobCard();
            mbcard.Show();


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            connection_class.open_connection();
            MySqlCommand cmd1 = new MySqlCommand("SELECT `registerNumber`, `customerName`, `vehicleModel`, `chassisNumber`, `fuelType`,`km`,`address`,`phoneNumber`,`Company` FROM `customer` WHERE registerNumber =@registerNumber", connection_class.con);
            cmd1.Parameters.AddWithValue("registerNumber", txt_search.Text);

            MySqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                txt_regNo.Text = reader1["registerNumber"].ToString();
                txt_customerName.Text = reader1["customerName"].ToString();
                cmb_vehicleModel.Text = reader1["vehicleModel"].ToString();
                txt_chassisNo.Text = reader1["chassisNumber"].ToString();
                txt_fuel.Text = reader1["fuelType"].ToString();
                txt_odoMeter.Text = reader1["km"].ToString();
                txt_company.Text = reader1["Company"].ToString();
                txt_address.Text = reader1["address"].ToString();
                txt_phoneNumber.Text = reader1["phoneNumber"].ToString();

            }
            else
            {
                MessageBox.Show("No data found");
            }
            connection_class.close_connection();
        }

        private void txt_search_Validating_1(object sender, CancelEventArgs e)
        {

        }
    }
}
