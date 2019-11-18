using System;

namespace Total
{
    [Serializable]
    class Expenditure
    {
        int originalPrice = 0;

        string[] cashNames = new string[10] { "지출", "지출", "지출", "지출", "지출", "지출", "지출", "지출", "지출", "지출" };
        string[] cashPrices = new string[10] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"};
        int[] cashTypes = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        int cashTotal = 0;



        public void Initialize_allData()
        {
            for (int i = 0; i < 10; i++)
            {
                cashNames[i] = "지출";
            }

            Initialize_valueData();
        }

        public void Initialize_valueData()
        {
            for (int i = 0; i < 10; i++)
            {
                cashPrices[i] = "0";
                cashTypes[i] = 0;
            }

            cashTotal = 0;

            originalPrice = 0;
        }

        public void Save_originalPrice(int _price) { originalPrice = _price; }

        public void Save_name(int _index, string _name) { cashNames[_index] = _name; }

        public void Save_price(int _index, string _price)
        {
            cashPrices[_index] = _price;

            Update_price();
        }

        public void Save_type(int _index, int _type)
        {
            cashTypes[_index] = _type;

            Update_price();
        }

        public int Load_originalPrice() { return originalPrice; }

        public string Load_name(int _index) { return cashNames[_index]; }

        public string Load_price(int _index) { return cashPrices[_index]; }

        public int Load_type(int _index) { return cashTypes[_index]; }

        public int Get_totalPrice()
        {
            return cashTotal;
        }

        public void Update_price()
        {
            cashTotal = 0;
            for (int i = 0; i < 10; i++)
            {
                if (cashTypes[i] == 1) cashTotal -= int.Parse(cashPrices[i]);
                else cashTotal += int.Parse(cashPrices[i]);
            }
        }
    }
}
