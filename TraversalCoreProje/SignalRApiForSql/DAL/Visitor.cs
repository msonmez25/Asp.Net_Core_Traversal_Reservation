using System;

namespace SignalRApiForSql.DAL
{   
        public enum ECity
        {
            İstanbul = 1,
            Ankara = 2,
            İzmit = 3,
            Erzurum = 4,
            Bursa = 5
        }
        public class Visitor
        {
            public int VisitorID { get; set; }
            public ECity City { get; set; }
            public int CityVisitCount { get; set; }
            public DateTime VisitDate { get; set; }
        }
    
}
