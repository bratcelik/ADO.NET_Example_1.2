namespace BLL
{
    public class UrunOzet
    {
        private string _aciklama;
        private string _listUrunToplam;
        private string _listeDisiUrunToplam;
        private decimal _minimumFiyat;
        private decimal _maximumFiyat;

        public string Aciklama { get => _aciklama; set => _aciklama = value; }
        public string ListUrunToplam { get => _listUrunToplam; set => _listUrunToplam = value; }
        public string ListeDisiUrunToplam { get => _listeDisiUrunToplam; set => _listeDisiUrunToplam = value; }
        public decimal MinimumFiyat { get => _minimumFiyat; set => _minimumFiyat = value; }
        public decimal MaximumFiyat { get => _maximumFiyat; set => _maximumFiyat = value; }

        public UrunOzet(string aciklama, string listUrunToplam, string listeDisiUrunToplam, decimal minimumFiyat, decimal maximumFiyat)
        {
            Aciklama = aciklama;
            ListUrunToplam = listUrunToplam;
            ListeDisiUrunToplam = listeDisiUrunToplam;
            MinimumFiyat = minimumFiyat;
            MaximumFiyat = maximumFiyat;
        }
    }
}
