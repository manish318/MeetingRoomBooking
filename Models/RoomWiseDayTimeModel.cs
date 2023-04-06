using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class RoomWiseDayTimeModel
    {
        public int RoomDayTimeId { get; set; }
        public int RowId { get; set; }
        public String SunStartTime { get; set; }
        public String SunEndTime { get; set; }
        public String SunRange { get; set; }
        public String MonStartTime { get; set; }
        public String MonEndTime { get; set; }
        public String MonRange { get; set; }
        public String TueStartTime { get; set; }
        public String TueEndTime { get; set; }
        public String TueRange { get; set; }
        public String wedStartTime { get; set; }
        public String WedEndTime { get; set; }
        public String WedRange { get; set; }
        public String ThuStartTime { get; set; }
        public String ThuEndTime { get; set; }
        public String ThuRange { get; set; }
        public String FriStartTime { get; set; }
        public String FriEndTime { get; set; }
        public String FriRange { get; set; }
        public String SatStartTime { get; set; }
        public String SatEndTime { get; set; }
        public String SatRange { get; set; }
    }
}
