using Stellaris;

const string FilePath = @"C:\Users\alberto.diaz\Development\Stellaris Parser System\Test Files\user_empire_designs.txt";
Empire[] EmpireList = Parser.GetAllEmpires(FilePath);

foreach (Empire empire in EmpireList)
    Console.WriteLine(empire);