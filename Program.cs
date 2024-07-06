using System.Xml.Serialization;

using var fileStream = File.OpenRead("sample1.xml");

var root = (Root)new XmlSerializer(typeof(Root)).Deserialize(fileStream);

Console.WriteLine($"string value : |{root.Item[0].String}|");
Console.WriteLine($"normalized string value : |{root.Item[0].Normalizedstring}|");
Console.WriteLine($"token value : |{root.Item[0].Token}|");
Console.WriteLine($"language value : |{root.Item[0].Language}|");
Console.WriteLine($"Name value : |{root.Item[0].Name}|");