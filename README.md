1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

Описание:
Задаем два массива. Первый массив включает в себя заданные символы (цифры и буквы), второй нужен для того, чтобы записать в него результат.
Применяем метод void, тип string (так как у нас и цифровые и буквенные символы), для проверки длины массива используем цикл for. Внутри цикла проверяется условие больше или равна длина каждого символа в массиве array1 трем. Если да, то элемент заносится во второй массив, если нет - переходим к следующему символу. После присвоения увеличиваем переменную g на 1 (переходим к следующей "ячейке" массива) и возвращаемся к циклу for в котором i увеличивается на 1 до тех пор, пока выполняется условие, что i меньше длины массива, т.е. проверяем следующий символ на соответствие условию. Цикл продолжается до тех пор, пока i меньше длины массива.
Когда мы достигаем значения i больше длины массива - заканчиваем цикл и выводим array2 на печать.
