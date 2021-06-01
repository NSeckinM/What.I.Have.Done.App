using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What.I.Have.Done
{
    public class Mesaj:IComparable
    {
        public string Metin { get; set; }

        public DateTime? OlusturmaZamani { get; set; }

        public bool YildizliMi { get; set; }

        public int CompareTo(object obj)
        {
            Mesaj digermesaj = (Mesaj)obj;
            if (OlusturmaZamani < digermesaj.OlusturmaZamani) return 1;
            if (OlusturmaZamani == digermesaj.OlusturmaZamani) return 0;
            if (OlusturmaZamani > digermesaj.OlusturmaZamani) return -1;

            return this.CompareTo(digermesaj.OlusturmaZamani);
        }

        public override string ToString()
        {
            if (OlusturmaZamani < DateTime.Today)
            {

                if (YildizliMi)
                {
                    return $"[{OlusturmaZamani}]: {Metin} ★ ";
                }

                return $"[{OlusturmaZamani}]: {Metin}";

            }
            else
            {
                if (YildizliMi)
                {
                    return $"[{OlusturmaZamani.Value.ToShortTimeString()}]: {Metin} ★ ";
                }

                return $"[{OlusturmaZamani.Value.ToShortTimeString()}]: {Metin}";

            }
        }

    }
}
