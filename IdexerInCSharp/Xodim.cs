using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdexerInCSharp
{
    public class Xodim
    {
        public int Id { get; set; }
        public string Ismi { get; set; }
        public string Fsmiliya { get; set; }
        public string Tugilgankuni { get; set; }

        public string Jinsi { get; set; }
        public string Millati { get; set; }
        public string TelefonRaqami { get; set; }
        public string Email { get; set; }
        public decimal Maoshi { get; set; }

        public Xodim( int id, string ism, string fsmiliya, string tugilgankuni, string jinsi, string millati, string telefonraqami, string email, decimal maoshi)
        {
            Id = id;
            Ismi = ism;
            Fsmiliya = fsmiliya;
            Tugilgankuni = tugilgankuni;
            Jinsi = jinsi;
            Millati = millati;
            TelefonRaqami = telefonraqami;
            Email = email;
            Maoshi = maoshi;
        }
        public object this[int index]
        {
            get
            {
                switch (index) 
                {
                    case 0:
                        return Id;
                    case 1:
                    return Ismi;
                    case 2:
                    return Fsmiliya;
                    case 3:
                    return Tugilgankuni;
                    case 4:
                    return Jinsi;
                    case 5:
                    return Millati;
                    case 6:
                    return TelefonRaqami;
                    case 7:
                    return Email;
                    case 8:
                    return Maoshi;
                    default:
                    return null;
                }
            }
            set
            {
                switch (index) 
                {
                    case 0:
                        Id = (int)value;
                        break;
                    case 1:
                        Ismi = (string)value;
                        break;
                    case 2:
                        Fsmiliya = (string)value;
                        break;
                    case 3:
                        Tugilgankuni = (string)value;
                        break;
                    case 4:
                        Jinsi = (string)value;
                        break;
                    case 5:
                        Millati = (string)value;
                        break;
                    case 6:
                        TelefonRaqami = (string)value;
                        break;
                    case 7:
                        Email = (string)value;
                        break;
                    case 8:
                        Maoshi = (decimal)value;
                        break;
                   
                }
            }
        }
    }
}
