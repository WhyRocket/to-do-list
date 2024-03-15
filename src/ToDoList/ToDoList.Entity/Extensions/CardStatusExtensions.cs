using System.ComponentModel;
using ToDoList.Entity.Enums;

namespace ToDoList.Entity.Extensions;

public static class CardStatusExtensions
{
    // Метод, который возвращает статус дела в понятной форме.
    public static string GetName(this CardStatus status) => status switch
    {
        CardStatus.Done => "Выполнено",
        CardStatus.NotDone => "Не выполнено",
        CardStatus.Postoned => "Отложено",
        CardStatus.Started => "Начато",
        _ => throw new InvalidEnumArgumentException(),
    };
}
