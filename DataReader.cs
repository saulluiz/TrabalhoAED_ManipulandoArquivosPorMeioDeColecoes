using System;
using System.IO;
public static class DataReader
{
    public static List<string> CsvToStringList(string path)
    {
        StreamReader reader = new StreamReader(path);
        List<string> list = new List<string>();
         reader.ReadLine();
        string? line = reader.ReadLine();
        
        while (line != null)
        {

            list.Add(line);
            line = reader.ReadLine();
        }
        reader.Close();

        return list;
    }
    
    public static List<People> CsvToPeopleList(string path)
    {
        var StringList = CsvToStringList(path);
        var peopleList = new List<People>();
        foreach (string people in StringList)
        {
            peopleList.Add(new People(people));
        }
        return peopleList;


    }
    public static Lista CsvToListaPeople(string path)
    {
        var StringList = CsvToStringList(path);
        var peopleList = new Lista();
        foreach (string people in StringList)
        {
            peopleList.Add(new People(people));
        }
        return peopleList;


    }

}