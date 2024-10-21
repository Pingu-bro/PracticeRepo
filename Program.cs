//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Xml.Linq;
//using Newtonsoft.Json;

//public interface IPersistence
//{
//    void Persist(int[] numbers);
//}

//public class TextFilePersistence : IPersistence
//{
//    private readonly string _filePath;

//    public TextFilePersistence(string filePath)
//    {
//        _filePath = filePath;
//    }

//    public void Persist(int[] numbers)
//    {
//        File.WriteAllText(_filePath, string.Join(",", numbers));
//        Console.WriteLine($"Numbers persisted to {_filePath}");
//    }
//}

//public class XmlPersistence : IPersistence
//{
//    private readonly string _filePath;

//    public XmlPersistence(string filePath)
//    {
//        _filePath = filePath;
//    }

//    public void Persist(int[] numbers)
//    {
//        var xml = new XElement("Numbers",
//            numbers.Select(n => new XElement("Number", n)));
//        xml.Save(_filePath);
//        Console.WriteLine($"Numbers persisted to {_filePath}");
//    }
//}

//public class JsonPersistence : IPersistence
//{
//    private readonly string _filePath;

//    public JsonPersistence(string filePath)
//    {
//        _filePath = filePath;
//    }

//    public void Persist(int[] numbers)
//    {
//        var json = JsonConvert.SerializeObject(numbers);
//        File.WriteAllText(_filePath, json);
//        Console.WriteLine($"Numbers persisted to {_filePath}");
//    }
//}

//public class 

//{
//    public static IPersistence CreatePersistence(string format, string filePath)
//    {
//        switch (format.ToUpper())
//        {
//            case "TEXT":
//                return new TextFilePersistence(filePath);
//            case "XML":
//                return new XmlPersistence(filePath);
//            case "JSON":
//                return new JsonPersistence(filePath);
//            default:
//                throw new ArgumentException("Invalid format");
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        if (args.Length != 2)
//        {
//            Console.WriteLine("Usage: NumberParser <comma-delimited-numbers> <format>");
//            return;
//        }

//        string numbersString = args[0];
//        string format = args[1];

//        int[] numbers = numbersString.Split(',')
//                                     .Select(int.Parse)
//                                     .OrderByDescending(x => x)
//                                     .ToArray();

//        IPersistence persistence = PersistenceFactory.CreatePersistence(format, "output." + format.ToLower());
//        persistence.Persist(numbers);
//    }
//}
