using System.Text.RegularExpressions;

Console.WriteLine("escribe el parrafo");
string text = Console.ReadLine();
int n = 0;
//trim solamente sirve para quitar espacios al inicio y al final
text = text.Trim();
//regex para quitar patrones de espacio
text = Regex.Replace(text, @"\s+", " ").Trim();
//
var word = text.Split(" ");

n = word.Length;

Console.WriteLine("el numero de palabras es... " + n);  
