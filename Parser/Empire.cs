namespace Stellaris
{
    public class Empire
    {
        public readonly string code;
        public readonly string name;
        public readonly string description;

        public Empire(string filecode)
        {
            code = filecode;
            name = Search("key")?.FirstOrDefault().value ?? string.Empty;
            description = Search("species_bio")?.FirstOrDefault().value ?? string.Empty;
        }

        public struct Entry
        {
            public string key;
            public string value;

            public Entry(string key, string value)
            {
                this.key = key;
                this.value = value;
            }

            public Entry(string line)
            {
                string[] split = line.Trim().Split("=");
                key = Tools.Clean(split[0]);
                value = Tools.Clean(split[1]);
            }
        }

        public List<Entry>? Search(string key)
        {
            key += "=";
            List<Entry> results = new();
            IEnumerable<string> matches = code.Split("\n").Where(t => t.Trim().StartsWith(key));
            foreach (string entry in matches)
                results.Add(new Entry(entry));
            if(results.Count > 0)
                return results;
            return null;
        }

        public override string ToString() => name;
    }
}
