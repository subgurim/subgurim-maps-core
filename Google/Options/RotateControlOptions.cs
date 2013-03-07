﻿using Subgurim.Maps.Collections;
using Subgurim.Maps.Google.Enums;

namespace Subgurim.Maps.Google.Options
{
    internal class RotateControlOptions
    {
        public ControlPosition? Position { get; set; }

        public override string ToString()
        {
            var options = new JsonCollection(false);

            if (Position.HasValue)
            {
                options.Add("position", "google.maps.ControlPosition." + Position.Value.ToString().ToUpperInvariant(), Position.Value != ControlPosition.Top_Left);
            }

            return options.ToString();
        }
    }
}