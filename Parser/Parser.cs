namespace Stellaris
{
    public static class Parser
    {
        private static string GetFileText(string filepath) => File.ReadAllText(filepath);
        public static Empire[] GetAllEmpires(string filepath)
        {
            List<Empire> empires = new();

            string empireCode = string.Empty;
            foreach(string line in GetFileText(filepath).Split("\n"))
            {
                empireCode += line + "\n";
                if(line == "}")
                {
                    empires.Add(new Empire(empireCode));
                    empireCode = string.Empty;
                }
            }

            return empires.ToArray();
        }
    }
}