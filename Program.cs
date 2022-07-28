// // Автобусы
string result = String.Empty;
string[] itineries = { "1001", "1002", "1003", "1004", "1005" };
string[] drivers = { "Иванов И.И.", "Петров П.П.", "Сидоров С.С.", "Козлов К.К.", "Сергеев С.С." };
string[] konds = { "Иванова И.И.", "Петрова П.П.", "Сидорова С.С.", "Козлова К.К.", "Сергеева С.С." };

for (int id = 1; id <=5; id++)
{
    string driver = $"{drivers[new Random().Next(drivers.Length)]}";
    string kond = $"{konds[new Random().Next(konds.Length)]}";
    string itinerary = itineries[new Random().Next(itineries.Length)];

    result += $"{id}\t{itinerary}\t{driver}\t{kond}\n";
}
File.WriteAllText("db.csv", result, System.Text.Encoding.UTF32);


//Водители
// string result = String.Empty;
// string[] drivers = { "Иванов И.И.", "Петров П.П.", "Сидоров С.С.", "Козлов К.К.", "Сергеев С.С." };
// string[] itineries = { "1001", "1002", "1003", "1004", "1005" };
// string[] idbuses = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
// string[] phones = { "123", "222", "333", "412", "545", "612", "787", "834", "957", "145" };

// for (int id = 1; id <= 5; id++)
// {
//     string driver = $"{drivers[new Random().Next(drivers.Length)]}";
//     string idbus = $"{idbuses[new Random().Next(idbuses.Length)]}";
//     string itinerary = itineries[new Random().Next(itineries.Length)];
//     string phone = $"{phones[new Random().Next(phones.Length)]}";
    

//     result += $"{id}\t{driver}\t{idbus}\t{itinerary}\t{phone}\n";
// }
// File.WriteAllText("db2.csv", result, System.Text.Encoding.UTF32);

//Кондукторы
// string result = String.Empty;
// string[] konds = { "Иванова И.И.", "Петрова П.П.", "Сидорова С.С.", "Козлова К.К.", "Сергеева С.С." };
// string[] itineries = { "1001", "1002", "1003", "1004", "1005" };
// string[] idbuses = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
// string[] phones = { "098", "283", "188", "330", "654", "666", "110", "396", "966", "399" };

// for (int id = 1; id <= 5; id++)
// {
//     string kond = $"{konds[new Random().Next(konds.Length)]}";
//     string idbus = $"{idbuses[new Random().Next(idbuses.Length)]}";
//     string itinerary = itineries[new Random().Next(itineries.Length)];
//     string phone = $"{phones[new Random().Next(phones.Length)]}";
    

//     result += $"{id}\t{kond}\t{idbus}\t{itinerary}\t{phone}\n";
// }
// File.WriteAllText("db3.csv", result, System.Text.Encoding.UTF32);