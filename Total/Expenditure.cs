using System;

namespace Total
{
    [Serializable]
    class Expenditure
    {
        int originalPrice = 0;
        int cardPrice = 0;

        string[] cashNames = new string[10] { "", "", "", "", "", "", "", "", "", "" };
        string[] cashPrices = new string[10] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"};
        bool?[] cashTypes = new bool?[10] { null, null, null, null, null, null, null, null, null, null };

        int cashTotal = 0;



        public void Reset_allData()
        {
            for (int i = 0; i < 10; i++)
            {
                cashNames[i] = "";
            }

            Reset_valueData();
        }

        public void Reset_valueData()
        {
            for (int i = 0; i < 10; i++)
            {
                cashPrices[i] = "0";
                cashTypes[i] = null;
            }

            cashTotal = 0;

            originalPrice = 0;
            cardPrice = 0;
        }

        public void Save_originalPrice(int _price) { originalPrice = _price; }

        public void Save_cardPrice(int _price) { cardPrice = _price; }

        public void Save_name(int _index, string _name) { cashNames[_index] = _name; }

        public void Save_price(int _index, string _price)
        {
            cashPrices[_index] = _price;

            Update_price();
        }

        public void Save_type(int _index, bool? _type)
        {
            cashTypes[_index] = _type;

            Update_price();
        }

        public int Load_originalPrice() { return originalPrice; }

        public int Load_cardPrice() { return cardPrice; }

        public string Load_name(int _index) { return cashNames[_index]; }

        public string Load_price(int _index) { return cashPrices[_index]; }

        public bool? Load_type(int _index) { return cashTypes[_index]; }

        public int Get_totalPrice()
        {
            return cashTotal;
        }

        public void Update_price()
        {
            cashTotal = 0;
            for (int i = 0; i < 10; i++)
            {
                if (cashTypes[i] == true) cashTotal -= int.Parse(cashPrices[i]);
                else if (cashTypes[i] == false) cashTotal += int.Parse(cashPrices[i]);
            }
        }
    }
}
