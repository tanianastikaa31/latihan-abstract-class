namespace ClassLibraryTania
{
    public class ClassRobot
    {
        #region DATAMEMBER
        private string nama;
        private string pemilik;
        private int tahun;
        #endregion

        #region PROPERTISE
        public string Nama { get => nama; set => nama = value; }
        public string Pemilik { get => pemilik; set => pemilik = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        #endregion

        #region METODH
        public void SetTahunPembuatan(int tahun)
        {

        }
        public void SetNama(string nama)
        {

        }
        public void DisplayData()
        {

        }
        #endregion
    }
}
