namespace Total
{
    class Counter
    {
        string name = string.Empty;

        int amount_10 = 0;
        int amount_50 = 0;
        int amount_100 = 0;
        int amount_500 = 0;
        int amount_1000 = 0;
        int amount_5000 = 0;
        int amount_10000 = 0;
        int amount_50000 = 0;
        int amount_100000 = 0;

        int price_10 = 0;
        int price_50 = 0;
        int price_100 = 0;
        int price_500 = 0;
        int price_1000 = 0;
        int price_5000 = 0;
        int price_10000 = 0;
        int price_50000 = 0;
        int price_100000 = 0;

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
                    price = _amount % 10 == 0 ? _amount / 10 : -1;
                    break;
                case 50:
                    price = _amount % 50 == 0 ? _amount / 50 : -1;
                    break;
                case 100:
                    price = _amount % 100 == 0 ? _amount / 100 : -1;
                    break;
                case 500:
                    price = _amount % 500 == 0 ? _amount / 500 : -1;
                    break;
                case 1000:
                    price = _amount % 1000 == 0 ? _amount / 1000 : -1;
                    break;
                case 5000:
                    price = _amount % 5000 == 0 ? _amount / 5000 : -1;
                    break;
                case 10000:
                    price = _amount % 10000 == 0 ? _amount / 10000 : -1;
                    break;
                case 50000:
                    price = _amount % 50000 == 0 ? _amount / 50000 : -1;
                    break;
                case 100000:
                    price = _amount % 100000 == 0 ? _amount / 100000 : -1;
                    break;
            }
            return price;
        }

        public int GetTotalPrice()
        {
            return price_10 + price_50 + price_100 + price_500 + price_1000 + price_5000 + price_10000 + price_50000 + price_100000;
        }
    }
}
