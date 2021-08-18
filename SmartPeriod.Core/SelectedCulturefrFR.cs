using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartPeriod.Core.DatePieces;

namespace SmartPeriod.Core
{
    public class SelectedCultureFrFr : ISelectedCulture
    {
        public DatePiece Year { get { return new YearPiece("année", "années"); } set { } }
        public DatePiece Month { get { return new MonthPiece("mois", "mois"); } set { } }
        public DatePiece Day { get { return new DayPiece("jour", "jours"); } set { } }
        public DatePiece Hour { get { return new HourPiece("heure", "heures"); } set { } }
        public DatePiece Minute { get { return new MinutePiece("minute", "minutes"); } set { } }
        public DatePiece Second { get { return new SecondPiece("seconde", "secondes"); } set { } }
    }
}
