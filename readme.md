# Итоговая проверочная работа
## Задача

 Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
 ***

 ## Описание решения

 Объявляется два массива:
 * первый, который включает в себя уже заданные строковые элементы;
 * второй объявляется пустым такой же длины как и первый.
 
 Создается цикл, который перебирает все элементы внутри заданного массива(счетчик *i*) и внутри цикла проверяем условие на количество символов каждого элемента массива, которое не должно быть более заданного в условии задачи количества.
 
 Все элементы первого массива, удовлетворяющие данному условию, последовательно заносятся во второй массив. При этом счетчик *count* увеличивается на 1 и это происходит только тогда, когда добавляется элемент во второй массив.

 Далее, по завершению цикла, счетчик *count* будет соответствовать длине второго массива, что позволит нам воспользоваться функцией Array.Resize() для получения нового массива из второго, который будет иметь законченный вид и количество элементов будет соответствовать количеству отобранных согласно условиям задачи.

 В завершение, создадим две функции, используя описанный выше алгоритм: 
 * SelectionArray() - для отбора заданного массива;
 * PrintArray() - для вывода результата на экран.

  Блок-схема для данной программы находится в папке *block_diagram*. Имя файла - *block_diagram.drawio*.

  Сама программа - в папке *program*. Имя файла - *Program.cs*.





