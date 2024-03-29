# План тестирования  
---

# Содержание  
1 [Введение](#introduction)  
2 [Объект тестирования](#items)  
3 [Атрибуты качества](#quality)  
4 [Риски](#risk)  
5 [Аспекты тестирования](#features)  
6 [Подходы к тестированию](#approach)  
7 [Представление результатов](#pass)  
8 [Выводы](#conclusion)  

<a name="introduction"/>  

# 1 Введение  

Данный документ описывает план тестирования приложения ["Graphical Calculator"](https://github.com/EvGem7/Graphical-Calculator).

<a name="items"/>  

# 2 Объект тестирования  

В качестве объектов тестирования можно выделить основные [функциональные требования](https://github.com/EvGem7/Graphical-Calculator/blob/master/Documents/Requirements/RequirementsDocument.md).
 
 Пользователю должен предоставляться следующий функционал:
* Вычисление выражений;
* Решение уравнений;  
* История вычислений;  
* Построение графиков;  


<a name="quality"/>  

# 3 Атрибуты качества  

Важными атрибутами являются высокая производительность, малое потребление ресурсов, удобный интерфейс, отсутствие рекламы.

1. Требования к удобству использования
- Должен быть реализован понятный и удобный пользователю интерфейс.
- При отображении графиков должно быть реализовано распознавание жестов для приближения и отдаления.

2. Ограничения
- Приложение реализовано на языке Kotlin.
- Минимальная версия API будет 21+ (Android 5.0 Lollipop).


<a name="risk"/>  

# 4 Риски  

К рискам можно отнести:  
* Прерывание работы приложения при входящем звонке;   

<a name="features"/>  

# 5 Аспекты тестирования  

В ходе тестирования планируется проверить реализацию основных функций приложения. Данное тестрование будет проводится по типу "чёрного ящика", т.к. мы имеем поток входных и выходных данных, без доступа к коду. Также тестирование является интеграционным и программные модули тестрируются в группе.

Аспекты, подвергаемые тестированию:  
* Вычисление выражений;  
* Решение уравнений;
* История вычислений;
* Построение графиков.


##### Вычисление выражений 
* Пользователь может вводить математические выражения, чтобы узнать их результат.

##### Решение уравнений 
* Пользователь может вводить переменные в своих выражениях, с целью получить решение какого-либо уравнения.

##### История вычислений
* Пользователь может просматривать историю своих вычислений;
* Использовать результат старых вычислений в новых.

##### Нефункциональные требования  

* Плавный интерфейс - отсутствие фризов во время использования приложения.

<a name="approach"/>  

# 6 Подходы к тестированию  

Для тестирования приложения будет использован ручной подход.  

<a name="pass"/>  

# 7 Представление результатов  

Результаты тестирования представлены в документе ["Представление результатов"](../Testing/TestResult.md).  

<a name="conclusion"/>  

# 8 Выводы  

Данный тестовый план позволяет протестировать основной функционал приложения. Успешное прохождение всех тестов позволяет полагать, что данное программное обеспечение работает корректно. Тестирование показало, что приложение полностью работоспособно.
