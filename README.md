# to-do-list

Приложение "Список дел"

Бизнес-требования:
- интерфейс взаимодействия с программой - консоль
- поддержка функций посмотра списка дел с поддержкой пагинации, список дел должен быть отсортирован по номеру дела
- поддержка функций добавления, редактирования, удаления дел из списка
- поддержка возможности отмечать дела как выполненные, отложенные, не выполненные, начатые
- поддержка функции просмотра 
только выполненных дел (или только отложенных и т.д.)
- дело должно иметь: 
номер, проставляемый автоматически
название
описание
срок выполнения
статус (выполнено, отложено и т.д.)
- ведение лога выполненных действий (добавление, удаление, редактирование, вход в программу, выход из программы)

Технические требования:

- список дел сохранять в json-файл (сериализация списка дел в json), который должен располагаться в той же директории, что и исполняемый файл приложения
- при закрытии приложения необходимо актуализировать список дел, подгружая данные из json-файла
- при открытии приложения необходимо загружать список дел из json-файла

Ограничения:

- максимальное количество дел в приложении - 30
- количество дел, которое отображается на одной странице при пагинации - 5