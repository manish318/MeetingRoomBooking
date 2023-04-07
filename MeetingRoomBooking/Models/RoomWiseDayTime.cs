using System;
using System.Collections.Generic;

namespace MeetingRoomBooking.Models;

public partial class RoomWiseDayTime
{
    public int RoomDayTimeId { get; set; }

    public int? RowId { get; set; }

    public string? SunStartTime { get; set; }

    public string? SunEndTime { get; set; }

    public string? Sunrange { get; set; }

    public string? MonStartTime { get; set; }

    public string? MonEndTime { get; set; }

    public string? Monrange { get; set; }

    public string? TueStartTime { get; set; }

    public string? TueEndTime { get; set; }

    public string? Tuerange { get; set; }

    public string? WedStartTime { get; set; }

    public string? WedEndTime { get; set; }

    public string? Wedrange { get; set; }

    public string? ThuStartTime { get; set; }

    public string? ThuEndTime { get; set; }

    public string? Thurange { get; set; }

    public string? FriStartTime { get; set; }

    public string? FriEndTime { get; set; }

    public string? Frirange { get; set; }

    public string? SatStartTime { get; set; }

    public string? SatEndTime { get; set; }

    public string? Satrange { get; set; }
}
