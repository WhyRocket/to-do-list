using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList;

internal class ToDoCard
{
    // Этот класс описывает карточку задачи в "Списке дел".

    public int TaskNumber { get; set; }
    public string? TaskName { get; set; }
    public string? TaskInfo { get; set; }
    public DateTime? TaskDate { get; set; }
    public Status TaskStatus { get; set; }

    public ToDoCard(int taskNumber, string taskName, string taskInfo, DateTime taskDate, Status taskStatus)
    {
        TaskNumber = taskNumber;
        TaskName = taskName;
        TaskInfo = taskInfo;
        TaskDate = taskDate;
        TaskStatus = taskStatus;
    }

    // Метод, который выводит на консоль данные карточки дела (экземпляра класса).
    public void PrintData()
    {
        Console.WriteLine($"{TaskNumber}\n{TaskName}\n{TaskInfo}\n{TaskDate}\n{StringStatus(TaskStatus)}\n");
    }

    // Метод, который возвращает статус дела в понятной форме
    private string StringStatus(Status taskStatus)
    {
        switch (taskStatus)
        {
            case Status.Done: return "Выполнено";
            case Status.NotDone: return "Не выполнено";
            case Status.Postoned: return "Отложено";
            case Status.Started: return "Начато";
            default: return "";
        }
    }

    // Перечисление возможных статусов задач.
    public enum Status
    {
        Done,       // Выполнено.
        NotDone,    // Не выполнено.
        Postoned,   // Отложено
        Started     // Начато.
    }
}
