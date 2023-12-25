namespace Currency_rates_store
{
    [Serializable]
    public class CurrencyRate
    {
        public int Id { get; set; }

        public string Ccy { get; set; }

        public string Base_ccy { get; set; }

        public decimal Buy { get; set; }

        public decimal Sale { get; set; }

    }
}