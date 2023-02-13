using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner
{
    //Made by Linus................Project fun?....6/10......made brain think to hard :)
    public partial class MainForm : Form
    {     
        PartyManager party;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        } 
        private void InitializeGUI()
        {
            // Inputs cleared
            txtMaxNum.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;

            // Outputs cleared
            lblTotalCostOutput.Text = "0.0";
            lblTotalFeeOutput.Text = "0.0";
            lblTotalSurplusOutput.Text = "0.0";
            lblTotalGuestsOutput.Text = string.Empty;
            lstGuestList.Items.Clear();

            // group addguest disable.
            grpAddGuests.Enabled = false;

            // group paty enable.
            grpNewParty.Enabled = true;
        } 
      
        // when user clicked creat paty button, it will then validate our tex boxes before our party.
        private void btnCreateParty_Click(object sender, EventArgs e)
        {
            if (CreateParty() && CostPerPerson() && FeePerPerson())
            {
                grpAddGuests.Enabled = true;
                UpdateGUI();
            }
        } 

        //Creates a party after we enter all the data. like Cost, fee and max guests.
        private bool CreateParty()
        {
            int maxNumber = 0;
            bool ok = true;

            if(int.TryParse(txtMaxNum.Text, out maxNumber) && maxNumber > 0)
            {
                party = new PartyManager(maxNumber);
                MessageBox.Show($"Party List Created for {maxNumber} guests!", "Success");
            }
            else
            {
                MessageBox.Show("Invalid Number Please Try Again!", "Error");
                return false;
            }
            return ok;
        }

        // User enters the cost per person, if user enters a cost more then 0.0 then boolean is true else false. the txt and tryparse being validated
        private bool CostPerPerson()
        {
            double amount = 0.0;

            if (double.TryParse(txtAmount.Text, out amount) && amount > 0.0)
            {
                party.CostPerGuest = amount;
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a valid cost amount.", "Error");
                return false;
            }
        }

        // User enters the fee per person, if user enters a fee more then 0.0 then boolean is true else false. the txt and tryparse being validated
        private bool FeePerPerson()
        {
            double feeAmount = 0.0;

            if (double.TryParse(txtFeeAmount.Text, out feeAmount) && feeAmount > 0.0)
            {
                party.FeePerGuest = feeAmount;
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a valid fee amount.", "Error");
                return false;
            }
        }

        //calc the Surplus
        private bool SurplusTotal()
        {
            double num1 = Convert.ToDouble(FeePerPerson());
            double num2 = Convert.ToDouble(CostPerPerson());

            double totalVal = num2 - num1;

            return true;
        }

        
        //Lets the user Update our GUI in out list box of guests and the other inputs.
        private void UpdateGUI()
        {
            lstGuestList.Items.Clear();
            string[] guestList = party.GetGuestList();

            if(guestList != null)
            {
                for (int i = 0; i < guestList.Length; i++)
                {
                    string str = $"{i + 1,4} {guestList[i],-20} ";
                    lstGuestList.Items.Add(str);
                }
            } 

            double totalCost = party.CalcTotalCost();
            double totalFee = party.CalcTotalFee();
            double totalSurplus = party.CalcTotalSurplus();
            lblTotalSurplusOutput.Text = totalSurplus.ToString("0.0");
            lblTotalFeeOutput.Text = totalFee.ToString("0.0");
            lblTotalCostOutput.Text = totalCost.ToString("0.0");
            lblTotalGuestsOutput.Text = party.NumOfGuests().ToString();
        } 


        //when the user clicks "ADD" the button will add a new guest in the list box. if !ok, user get error, if ok is good and true we call updateGUI
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(TrimNames())
            {
                bool ok = party.AddNewGuest(txtFirstName.Text, txtLastName.Text);
                if(!ok)
                {
                    MessageBox.Show("List is full, new guest not added!", "Error");
                }
                else
                {
                    UpdateGUI();
                }
            }
        } 

        //Simple method that validates out text, like first and last name, if its empty show message.box else return true.
        private bool ValidateText(string text)
        {

            if(string.IsNullOrEmpty(text.Trim()))
            {
                MessageBox.Show("Please provide both the first name and last name.", "Error");
                return false;
            }
            else
            {
                return true;
            }
        } 


        private bool TrimNames()
        {
            if(!ValidateText(txtFirstName.Text) || !ValidateText(txtLastName.Text))
            {
                return false;
            }

            txtFirstName.Text = txtFirstName.Text.Trim();
            txtLastName.Text = txtLastName.Text.Trim();
            return true;
        } 

       //lets the user change the guest names thats in our list box, when changed the name is sent to our paty object. Then adds the name to our main Array.
        private void btnChange_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstGuestList.SelectedIndex;   
            if ((selectedIndex < 0) || (party == null))
                return;

            if (TrimNames() && selectedIndex >= 0 && party.ChangeGuest(selectedIndex, txtFirstName.Text, txtLastName.Text))
            {
                MessageBox.Show("Guest Changed", "Success");
            }
            else
            {
                MessageBox.Show("Guest Not Changed!", "Error");
            }
  
            UpdateGUI();
        } 


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstGuestList.SelectedIndex;
            if ((selectedIndex < 0) || (party == null))   
                return;

            if (selectedIndex >= 0 && party.DeleteGuest(selectedIndex))
            {
                MessageBox.Show("Guest Deleted", "Success");
            }
            else
            {
                MessageBox.Show("Guest Not Deleted!","Error");
            } 
            UpdateGUI();
        } 


        private void lstGuestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstGuestList.SelectedIndex;
            if ((selectedIndex < 0) || (party == null))
                return;

            string[] name = party.GetGuestName(selectedIndex);
            if(name != null)
            {
                txtLastName.Text = name[0].Trim();
                txtFirstName.Text = name[1].Trim();
            }
        } 

        private void lblGuestList_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    } 
} 
