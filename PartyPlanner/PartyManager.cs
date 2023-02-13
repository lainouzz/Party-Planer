using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    
    class PartyManager
    {
        //Main array
        private string[] guestList;

        //cost and fees.
        private double costPerPers;
        private double FeePerPerson;

        //get and set the values for the cost
        public double CostPerGuest {
            get { return costPerPers; }

            set
            {
                if (value >= 0)
                    costPerPers = value;
            }
        }

        //get and set the values for the fee
        public double FeePerGuest
        {
            get { return FeePerPerson; }

            set
            {
                if(value >= 0)
                    FeePerPerson = value;
            }
        }

        public PartyManager(int maxNumberofGuests)
        {
            guestList = new string[maxNumberofGuests];
        } 

        //wE accesses the guestList array that hold the amout of guests and we then count the amount.
        public int NumOfGuests()
        {
            int numGuests = 0;

            for(int i = 0; i < guestList.Length; i++)
            {
                if(!string.IsNullOrEmpty(guestList[i]))
                {
                    numGuests++;
                }
            }

            return numGuests;
        } 

        //Accesses the guestList to find where its empty, if there is a empty stringvlaue we then add new guest.
        private int FindVacantPos()
        {
            int vacantPos = -1;

            for (int i = 0; i < guestList.Length; i++)
            {
                if(string.IsNullOrEmpty(guestList[i]))
                {
                    vacantPos = i;
                    break;
                }
            }

            return vacantPos;
        } 

        //Takes the Inpit for our first name and last name and output it like: LASTNAME and firstname: LASTNAME + firstname.
        private string FullName(string firstName, string lastName)
        {
            return lastName.ToUpper() + ", " + firstName;
        } 


        public bool AddNewGuest(string firstName, string lastName)
        {
            bool ok = true;
            int vacantPos = FindVacantPos();

            if (vacantPos != -1)
            {
                guestList[vacantPos] = FullName(firstName, lastName);
            }
            else
                return false;

            return ok;
        } 

        public string[] GetGuestList()
        {
            int size = NumOfGuests();

            
            if (size <= 0)
                return null;

            string[] guests = new string[size];

            for(int i = 0, j = 0; i < guestList.Length; i++)
            {
                if(!string.IsNullOrEmpty(guestList[i]))
                {
                    guests[j++] = guestList[i]; 
                }
            }

            return guests;
        }

        public double CalcTotalCost()
        {
            return costPerPers * NumOfGuests();
        }

        public double CalcTotalFee()
        {
            return FeePerPerson * NumOfGuests();
        }

        public double CalcTotalSurplus()
        {
            return CalcTotalFee()- CalcTotalCost();
           
        }

        
        public bool DeleteGuest(int selectedIndex)
        {
            int size = GetGuestList().Length;

            if (size <= 0)
                return false;

            int[] map = new int[size];

            for (int i = 0, j = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    map[j++] = i;
                }
            }

            guestList[map[selectedIndex]] = string.Empty;
            return true;
        } 

        
        public bool ChangeGuest(int selectedIndex, string firstName, string lastName)
        {
            int size = GetGuestList().Length;

            if (size <= 0)
                return false;

            int[] map = new int[size];

            for (int i = 0, j = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    map[j++] = i;
                }
            }

            guestList[map[selectedIndex]] = FullName(firstName, lastName);
            return true;
        } 

        
        public string[] GetGuestName(int selectedIndex)
        {
            int size = GetGuestList().Length;

            if (size <= 0)
                return null;

            int[] map = new int[size];

            for (int i = 0, j = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    map[j++] = i;
                }
            }

            string temp = guestList[map[selectedIndex]];
            char delimiter = ',';
            string[] substrings = temp.Split(delimiter);

            return substrings;
        } 

    } 
} 
