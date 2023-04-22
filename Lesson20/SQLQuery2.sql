/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
--SELECT * FROM таблица  

SELECT * FROM Person


SELECT [FirstName] FROM Person
SELECT [LastName] FROM Person


SELECT [FirstName],[Email] FROM Person

--Для выборки данных используется команда SELECT.

--SELECT [DISTINCT] <список столбцов>
--FROM <имя таблицы> [JOIN <имя таблицы> ON <условия связывания>]
--[WHERE <условия выборки>]
--[GROUP BY <список столбцов для группировки> [HAVING <условия выборки групп>] ]
--[ORDER BY <список столбцов для сортировки>]

--Оператор DISTINCT позволяет выбрать уникальные строки. 

SELECT DISTINCT[LastName]
FROM Person

--Оператор ORDER BY позволяет отсортировать извлекаемые значения по определенному столбцу:

SELECT *
FROM Person
ORDER BY [LastName]

--Оператор TOP позволяет выбрать определенное количество строк из таблицы:
SELECT TOP 2 [FirstName]
FROM Person

--Для фильтрации в команде SELECT применяется оператор WHERE. 
--   =  сравнение на равенство (в отличие от си-подобных языков в T-SQL для сравнения на равенство используется один знак равно)

--  <> сравнение на неравенство

--  < меньше чем

--  > больше чем

--  !< не меньше чем

--  !> не больше чем

--  <= меньше чем или равно

--  >= больше чем или равно

SELECT DISTINCT * FROM Person
WHERE NOT LastName = N'ExampleExample'
 --WHERE NOT выражение 
 
-- Операторы фильтрации
--AND 
--OR
--NOT 
--IS NULL

 --WHERE выражение BETWEEN начальное_значение AND конечное_значение

 --Оператор IN позволяет определить набор значений, которые должны иметь столбцы
SELECT * FROM Person
WHERE [LastName] IN ('Example')

SELECT TOP 5 * FROM Person
WHERE [LastName]  LIKE 'By%' 
--WHERE столбец LIKE 'значение%'

SELECT * FROM Orders
WHERE PersonId BETWEEN 1 AND 2


--Для изменения уже имеющихся строк в таблице применяется команда UPDATE.
-- UPDATE таблица
-- SET LastName = 'ExampleRoot'
-- WHERE выражение

-- SET столбец1 = значение1, столбец2 = значение2,столбец3 = значение3
UPDATE Person
SET LastName = 'ExampleRoot'
WHERE Id = 2

--Для удаления применяется команда DELETE:
-- DELETE таблица
-- WHERE выражение
DELETE Person
WHERE Id=3


--Агрегатные функции выполняют вычисления над значениями в наборе строк. В T-SQL имеются следующие агрегатные функции:

--AVG: находит среднее значение

--SUM: находит сумму значений

--MIN: находит наименьшее значение

--MAX: находит наибольшее значение

--COUNT: находит количество строк в запросе




 SELECT AVG(PersonId) AS Average FROM Orders

 SELECT COUNT([LastName]) AS COUNTPerson FROM Person

--SELECT MIN(столбец) FROM Person

--SELECT MAX(столбец) FROM Person

--SELECT SUM(ProductCount) FROM Person




INSERT [dbo].[Person] VALUES(4,'Yuri','Example','yuri@mail.ru' );
INSERT [dbo].[Person] VALUES(5,'Yuri','Example','yuri2@mail.ru' );

SELECT [LastName],[FirstName]
FROM [dbo].[Person]
GROUP BY [LastName], [FirstName]

--GROUP BY Определяет как наши строки будут групироваться
--https://sql-academy.org/ru/trainer?difficulty=easy&sort=byId&type=select