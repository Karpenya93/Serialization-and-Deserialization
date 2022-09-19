using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using Serialization_and_deseralizaion;


XmlSerializer xmlSerializer = new XmlSerializer(typeof(Shape[]));




/*Написать программу выполняющую сериализацию и десериализацию.
 * Создать класс Point со свойствами float X, float Y.
 * Создать класс Shape со свойствами Point ShapePoint, float Length, float Height, string Name.
 * В методе Main создать массив из заполненных элементов типа Shape. Выполнить сериализацию и десериализацию этого массива.
 * Название файла для сериализации и десериализации вводить с клавиатуры. Сериализуемые форматы XML и JSON. Так же необходимо использовать блоки для обработки исключений.
 * После выполнения задания, скачать nuget-пакет Newtonsoft.Json. Попробовать выполнить сериализацию с помощью Json сериализатора из этого пакета
*/


Point squarePoint = new(10, 10);
Shape square = new(squarePoint, 100, 100, "Square");
Shape rectangle = new(new Point(20, 20), 100, 200, "Rectangle");
Shape romb = new(new Point(30, 30), 50, 50, "Romb");
Shape[] shapes = new Shape[] { square, rectangle, romb };

Console.WriteLine("Что вы хотите сделать ? xml или json");
string start = Console.ReadLine().ToLower();

if ( start == "json")
{
    try
    {


        Console.WriteLine("Введите имя для json сериализации ");
        string fileName = Console.ReadLine();
        using (Stream stream = new FileStream(fileName, FileMode.OpenOrCreate))
        {
            JsonSerializer.Serialize(stream, shapes);
        }

        Console.WriteLine("Введите имя для json десериализации");
        string filename = Console.ReadLine();
        using (Stream stream = new FileStream(filename, FileMode.OpenOrCreate))
        {
            shapes = JsonSerializer.Deserialize<Shape[]>(stream);

        }

    }

    catch
    {
        Console.WriteLine("Упс что то не так ");
    }
}
if (start == "xml")

{
    try
    {
        Console.WriteLine("Введите имя для xml сериализации ");
        string fileName1 = Console.ReadLine();
        using (Stream stream = new FileStream(fileName1, FileMode.OpenOrCreate))
        {
            xmlSerializer.Serialize(stream, shapes);
        }

        Console.WriteLine("Введите имя для xml десериализации");
        string filename2 = Console.ReadLine();
        using (Stream stream = new FileStream(filename2, FileMode.OpenOrCreate))
        {
            shapes = (Shape[]?)xmlSerializer.Deserialize(stream);

        }


    }

    catch
    {
        Console.WriteLine("что то не вышло ");
    }


}

