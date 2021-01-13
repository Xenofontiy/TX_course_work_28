using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX_course_work_28.NewFolder1
{
    class Exhibitions
    {
        public List<interfacee> exh = new List<interfacee>();
        public Exhibitions(int mode)
        {
            if (mode == 0)
            {

                interfacee VincentvanGoghST = new Hall1(" Зал1", "Звездная ночь", "Год: 1889, Данные:73.0x92.0 см. ");
                interfacee VincentvanGoghIr = new Hall1(" ", "Ирисы", "Год:1889, Данные: 71.0x93.0 см ");
                interfacee VincentvanGoghRO = new Hall1(" ", "Дорога с кипарисом и звездой", "Год: 1890, Данные: 92.0x73.0 см.");
                exh.Add(VincentvanGoghST);
                exh.Add(VincentvanGoghIr);
                exh.Add(VincentvanGoghRO);
            }
            if (mode == 1)
            {
                interfacee LeonardodaVinciAn = new Hall2("Зал2", "Благовещение", "Год: 1472, Данные: Дерево, масло. 98 × 217 см ");
                interfacee LeonardodaVinciBa = new Hall2(" ", "Крещение", "Год: 1472, Данные: Дерево, масло. 177 × 151 см ");
                interfacee LeonardodaVinciMo = new Hall2(" ", "Мона Лиза", "Год: 1503, Данные:Дерево, масло. 76, 8 × 53 ");
                exh.Add(LeonardodaVinciAn);
                exh.Add(LeonardodaVinciBa);
                exh.Add(LeonardodaVinciMo);
            }
            if (mode == 2)
            {
                interfacee OscarClaudeMonetIm = new Hall3("Зал3", "Впечатление. Восход солнца", "Год:1872, Данные: масло, холст, 63 x 48 см ");
                interfacee OscarClaudeMonetFe = new Hall3(" ", "Женщины в саду ", "Год: 1866, Данные: масло, холст, 205 x 255 см");
                interfacee OscarClaudeMonetAq = new Hall3("  ", "Водяные лилии, вечерний эффект", "Год: 1897 - 1899, Данные: масло, холст, 205 x 255 см ");
                exh.Add(OscarClaudeMonetIm);
                exh.Add(OscarClaudeMonetFe);
                exh.Add(OscarClaudeMonetAq);

            }
            if (mode == 3)
            {
                interfacee JanVermeerGl = new Hall4("Зал4", "Бокал вина", "Год: 1658 - 1660, Данные: масло, холст, 66,3 x 76,5 см  ");
                interfacee JanVermeerHe = new Hall4(" ", "Девушка с жемчужиной", " Год: 1665, Данные:  масло, холст, 44,5 x 39 см ");
                interfacee JanVermeerCo = new Hall4(" ", "Концерт", "Год: 1664, Данные: масло, холст,72,5 x 64,7 см ");
                exh.Add(JanVermeerGl);
                exh.Add(JanVermeerHe);
                exh.Add(JanVermeerCo);
            }
            if (mode == 4)
            {
                interfacee PaulCezanneSt = new Hall5("Зал5", "Натюрморт с черепом", "Год: 1866, Данные: масло, холст");
                interfacee PaulCezanneLa = new Hall5(" ", "Пейзаж с мельницей", "Год: 1860, Данные: масло, холст,23 x 31 см ");
                interfacee PaulCezanneSto = new Hall5(" ", "Печка в ателье", "Год: 1865");
                exh.Add(PaulCezanneSt);
                exh.Add(PaulCezanneLa);
                exh.Add(PaulCezanneSto);
            }
            
        }
}   } 
