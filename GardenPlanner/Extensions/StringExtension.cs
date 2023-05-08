namespace GardenPlanner.Extensions
{
    public static class StringExtension
    {
        public static string ToCapitalized(this string value)
        {
            return $"{value.Substring(0, 1).ToUpper()}{value.Substring(1).ToLower()}";
        }
    }
}
