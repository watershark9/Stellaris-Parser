namespace Stellaris
{
    public static class Tools
    {
        public static string Clean(string dirty) =>
            dirty
                .Replace("\n", "")
                .Replace("\"", "")
                .Replace("\t", "");

        public static string ToJSON(object obj) => Newtonsoft.Json.JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
    }
}
