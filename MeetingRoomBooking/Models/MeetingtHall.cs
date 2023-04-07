using System;
using System.Collections.Generic;

namespace MeetingRoomBooking.Models;

public partial class MeetingtHall
{
    public int RowId { get; set; }

    public string HallName { get; set; } = null!;

    public bool? IsActive { get; set; }
}
