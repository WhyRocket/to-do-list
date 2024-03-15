using ToDoList.Entity.Enums;
using ToDoList.Entity.Extensions;

namespace ToDoList.Entity;

// Этот класс описывает карточку задачи в "Списке дел".
public class Card(
    int number,
    string name,
    string? info,
    DateTime? date,
    CardStatus status)
{
    public int Number { get; set; } = number;
    public string Name { get; set; } = name;
    public string? Info { get; set; } = info;
    public DateTime? Date { get; set; } = date;
    public CardStatus Status { get; set; } = status;

    public override string ToString()
    {
        return $"{Number}\n{Name}\n{Info}\n{Date}\n{Status.GetName()}";
    }
}
