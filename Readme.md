## Задача : 
*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами*

## Выполнение:

Мы объявляем два массива *(Первый - с рандомным текстом и соответствующей длиной, Второй - такой же длины, что и первый)*. Далее пишем метод **SortArray**, в котором создаём переменную *help*, которая изначально равна нулю, цикл для перебора массива и внутри него условие, согласно которому при вычислении каждого элемента массива, длина которого больше или равна трём, этот элемент уходит в массив2 с индексом *"help"*, после чего переменная *help* увеличивается