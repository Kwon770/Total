using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total
{
    class Expenditure
    {
        string[] cashNames = new string[10] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", };
        string[] cashPrices = new string[10] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", };
        bool[] cashTypes = new bool[10] { false, false, false, false, false, false, false, false, false, false, };

        public int cashCount = 0;
        int cashTotal = 0;


        public void Save_name(int _index, string _name)
        {
            cashNames[_index] = _name;
        }

        public void Save_price(int _index, string _price)
        {
            cashPrices[_index] = _price;

            Update_price();
        }

        public void Update_price()
        {
            cashTotal = 0;
            for (int i = 0; i < 10; i++)
            {
                if (cashTypes[i]) cashTotal -= int.Parse(cashPrices[i]);
                else cashTotal += int.Parse(cashPrices[i]);
            }
        }

        public void Save_Type(int _index, int _Type)
        {
            if (_Type == 0) cashTypes[_index] = false;
            else cashTypes[_index] = true;
        }

        public int Get_totalPrice()
        {
            return cashTotal;
        }
    }
}
