# **Итоговое контрольное задание.**
## **Задача:** 
### Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

* Блок схема находятся в папке Flowchart.
* Непосредстредсвенно программа - в папке Final_Task_Programm.

## **Описание алгоритма решения:**

### Пользователю предлагается самолично задать желаемую длину массива и его элементы. Основной алгоритм программы заключается в том, что при получение первого массива из пользовательского ввода, создается еще один с такой же длиной. Потом используется цикл for, в теле цикла проверка условия (длина элемента первого массива <= 3). Если да, элемент первого массива заносится в count элемента второго массива. Переменная count введена для того, чтобы поочередно вносить элементы из первого массива во второй, и чтобы потом не было пробелов. После присвоения переменная count увеличивается на 1 и возвращается к циклу for в котором i увеличивается на 1. Так продолжается пока i не станет равным длине первого массива. По окончанию цикла выводится второй массив с элементами первого массива длина которых <= 3.