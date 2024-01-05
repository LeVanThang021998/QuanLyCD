using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_05
{
    class CD
    {
        private int macd;
        private string tuacd;
        private string casi;
        private int sobh;
        private int dongia;        
        public CD()
        {
        }
        public CD(int macd)
        {
            this.macd = macd;
        }
        public CD(int macd, string tuacd, string casi, int sobh, int dongia)
        {
            this.macd = macd;
            this.tuacd = tuacd;
            this.casi = casi;
            this.sobh = sobh;
            this.dongia = dongia;
        }
        public int MaCD
        {
            set { this.macd = value; }
            get { return macd; }
        }
        public string TuaCD
        {
            set { this.tuacd = value; }
            get { return tuacd; }
        }
        public string CaSi
        {
            set { this.casi = value; }
            get { return casi; }
        }
        public int SoBH
        {
            set { this.sobh = value; }
            get { return sobh; }
        }
        public int DonGia
        {
            set { this.dongia = value; }
            get { return dongia; }
        }
        public string Tostring()           
        {
            return string.Format("{0,10}", "{1,30}", "{2,30}", "{3,10}", "{4,15:#,##0}",
                macd, tuacd, casi, sobh, dongia);
        }

    }
}
