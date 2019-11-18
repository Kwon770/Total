using System;
using System.Collections.Generic;

namespace Total
{
    [Serializable]
    class Counter
    {
        string name = "금고";

        public Dictionary<string, string> amount = new Dictionary<string, string>()
        {
            {"10", "0" },
            {"50", "0" },
            {"100", "0" },
            {"500", "0" },
            {"1000", "0" },
            {"5000", "0" },
            {"10000", "0" },
            {"50000", "0" },
            {"100000", "0" },
        };

        public Dictionary<string, string> price = new Dictionary<string, string>()
        {
            {"10", "0" },
            {"50", "0" },
            {"100", "0" },
            {"500", "0" },
            {"1000", "0" },
            {"5000", "0" },
            {"10000", "0" },
            {"50000", "0" },
            {"100000", "0" },
        };

        int totalPrice = 0;

        public void Initialize_allData()
        {
            name = "금고";

            Initialize_valueData();
        }

        public void Initialize_valueData()
        {
            amount["10"] = "0";
            amount["50"] = "0";
            amount["100"] = "0";
            amount["500"] = "0";
            amount["1000"] = "0";
            amount["5000"] = "0";
            amount["10000"] = "0";
            amount["50000"] = "0";
            amount["100000"] = "0";

            price["10"] = "0";
            price["50"] = "0";
            price["100"] = "0";
            price["500"] = "0";
            price["1000"] = "0";
            price["5000"] = "0";
            price["10000"] = "0";
            price["50000"] = "0";
            price["100000"] = "0";
        }

        public void UpdateData(int currency, int _amount, int _price)
        {
            string t_amount = _amount.ToString();
            string t_price = _price.ToString();
            // set data to variable
            switch (currency)
            {
                case 10:
                    amount["10"] = t_amount;
                    price["10"] = t_price;
                    break;
                case 50:
                    amount["50"] = t_amount;
                    price["50"] = t_price;
                    break;
                case 100:
                    amount["100"] = t_amount;
                    price["100"] = t_price;
                    break;
                case 500:
                    amount["500"] = t_amount;
                    price["500"] = t_price;
                    break;
                case 1000:
                    amount["1000"] = t_amount;
                    price["1000"] = t_price;
                    break;
                case 5000:
                    amount["5000"] = t_amount;
                    price["5000"] = t_price;
                    break;
                case 10000:
                    amount["10000"] = t_amount;
                    price["10000"] = t_price;
                    break;
                case 50000:
                    amount["50000"] = t_amount;
                    price["50000"] = t_price;
                    break;
                case 100000:
                    amount["100000"] = t_amount;
                    price["100000"] = t_price;
                    break;
            }

            totalPrice = 0;
            foreach (string price in price.Values) totalPrice += int.Parse(price);
        }

        public int GetAmountFromPrice(int currency, int _price)
        {
            int amount = 0;
            switch (currency)
            {
                case 10:
                    amount = _price % 10 == 0 ? _price / 10 : -1;
                    break;
                case 50:
                    amount = _price % 50 == 0 ? _price / 50 : -1;
                    break;
                case 100:
                    amount = _price % 100 == 0 ? _price / 100 : -1;
                    break;
                case 500:
                    amount = _price % 500 == 0 ? _price / 500 : -1;
                    break;
                case 1000:
                    amount = _price % 1000 == 0 ? _price / 1000 : -1;
                    break;
                case 5000:
                    amount = _price % 5000 == 0 ? _price / 5000 : -1;
                    break;
                case 10000:
                    amount = _price % 10000 == 0 ? _price / 10000 : -1;
                    break;
                case 50000:
                    amount = _price % 50000 == 0 ? _price / 50000 : -1;
                    break;
                case 100000:
                    amount = _price % 100000 == 0 ? _price / 100000 : -1;
                    break;
            }
            return amount;
        }

        public int GetPriceFromAmount(int currency, int _amount)
        {
            int price = 0;
            switch (currency)
            {
                case 10:
                    price = _amount * 10;
                    break;
                case 50:
                    price = _amount * 50;
                    break;
                case 100:
                    price = _amount * 100;
                    break;
                case 500:
                    price = _amount * 500;
                    break;
                case 1000:
                    price = _amount * 1000;
                    break;
                case 5000:
                    price = _amount * 5000;
                    break;
                case 10000:
                    price = _amount * 10000;
                    break;
                case 50000:
                    price = _amount * 50000;
                    break;
                case 100000:
                    price = _amount * 100000;
                    break;
            }
            return price;
        }

        public int Get_totalPrice()
        {
            return totalPrice;
        }
    }
}
