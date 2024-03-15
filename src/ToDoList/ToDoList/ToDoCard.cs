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
    public string TaskName { get; set; }
    public string TaskInfo { get; set; }
    public DateTime? TaskDate { get; set; }
    public Status TaskStatus { get; set; }


    // Перечисление возможных статусов задач.
    public enum Status
    {
        Done,       // Выполнено.
        NotDone,    // Не выполнено.
        Postoned,   // Отложено
        Started     // Начато.
    }
}
