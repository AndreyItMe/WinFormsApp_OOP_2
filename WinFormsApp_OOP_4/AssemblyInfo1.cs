using System.Runtime.InteropServices;

// В проектах SDK, таких как этот, некоторые атрибуты сборки, которые ранее определялись
// в этом файле, теперь автоматически добавляются во время сборки и заполняются значениями,
// заданными в свойствах проекта. Подробные сведения о том, какие атрибуты включены
// и как настроить этот процесс, см. на странице: https://aka.ms/assembly-info-properties.


// При установке значения false для параметра ComVisible типы в этой сборке становятся
// невидимыми для компонентов COM. Если вам необходимо получить доступ к типу в этой
// сборке из модели COM, установите значение true для атрибута ComVisible этого типа.

[assembly: ComVisible(false)]

// Следующий GUID служит для идентификации библиотеки типов typelib, если этот проект
// будет видимым для COM.

[assembly: Guid("ed71718a-d53b-4ffa-8f0b-4cee8f70aada")]
class Program
{
/*
    static void Main(string[] args)
    {
        var number = 5;
        var result = Square(number);
        Console.WriteLine($"Квадрат {number} равен {result}");
    }
*/
    static int Square(int n) => n * n;
}