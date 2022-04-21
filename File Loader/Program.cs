using Stellaris;

const string FilePath = @"C:\Users\alberto.diaz\Downloads\Stellaris-Parser\Test Files\user_empire_designs.txt";
Empire[] EmpireList = Parser.GetAllEmpires(FilePath);

foreach (Empire empire in EmpireList)
    Console.WriteLine(Tools.ToJSON(empire));

Console.WriteLine(Tools.ToJSON(EmpireList.Where(inner => inner.description != "")));