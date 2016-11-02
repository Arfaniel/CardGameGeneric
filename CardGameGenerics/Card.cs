using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameGenerics
{
    class Card
    {
        public int Value { get; set; }
        public string CardSuit
        {
            get
            {
                switch (Value / 9)
                {
                    case 0: return "Пика";
                    case 1: return "Трефа";
                    case 2: return "Чирва";
                    case 3: return "Бубна";
                    default: return "unknown";
                }
            }
        }
        public string CardValue
        {
            get
            {
                switch (Value % 9)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4: return (Value % 9 + 6).ToString();
                    case 5: return "Валет";
                    case 6: return "Дама";
                    case 7: return "Король";
                    case 8: return "Туз";
                    default: return "unknown";
                        break;
                }
            }
        }
        public override string ToString()
        {
            return String.Format("{0}, {1}", CardSuit , CardValue); 
        }
        
    }
}
