using System;
using System.Collections.Generic;

namespace BlazorMusicApp.Models;

public partial class Track
{
    public int TrackId { get; set; }

    public string? Title { get; set; }

    public string? Artist { get; set; }

    public string? Genre { get; set; }

    public string? Playlist { get; set; }
}
