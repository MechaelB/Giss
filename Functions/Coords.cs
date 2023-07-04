using System;

namespace Giss
{
    internal static class Coords
    {
        static public double CoordsDMSToDD(string coordinate)
        {
            string[] parts = coordinate.Split('°', '\'', '\"');
            double degrees = Convert.ToDouble(parts[0]);
            double minutes = Convert.ToDouble(parts[1]);
            double seconds = Convert.ToDouble(parts[2].Replace('.', ','));

            return degrees + minutes / 60 + seconds / 3600; ;
        }
        static public string CoordsDDToDMS(double coordinate)
        {
            double degrees = Math.Truncate(coordinate);
            double minutes = Math.Truncate((coordinate - degrees) * 60);
            double seconds = (coordinate - degrees - minutes / 60) * 3600;

            return string.Format("{0}°{1}'{2:F1}\"", degrees, minutes, seconds);
        }

    }
}
