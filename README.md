# SQL-Queries

Certainly! Here are **some essential SQL Server queries** that every developer should be familiar with:

1. **Create Table**: To create a new table in SQL Server, use the following syntax:
    ```sql
    CREATE TABLE TableName (
        Id INT,
        Name NVARCHAR(500),
        Age INT
    );
    ```
2. **Create Table with Primary Key**: To create a table with a primary key, use:
    ```sql
    CREATE TABLE TableName (
        Id INT PRIMARY KEY,
        Name NVARCHAR(500),
        Age INT
    );
    ```
3. **Create Table with Primary Key and Identity Column**: For an auto-incrementing identity column:
    ```sql
    CREATE TABLE TableName (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Name NVARCHAR(500),
        Age INT
    );
    ```
4. **Insert Values into SQL Server Table**: To add data to a table:
    ```sql
    INSERT INTO TableName (Name, Age)
    VALUES ('Max', 30);
    ```
5. **Insert Multiple Rows in a Single Query**: Insert multiple records at once:
    ```sql
    INSERT INTO TableName (Name, Age)
    VALUES ('Max', 30), ('John', 28), ('Jack', 31);
    ```
6. **Update Query**:
    - Update a single record:
        ```sql
        UPDATE TableName
        SET Name = 'Max Payne'
        WHERE Id = 1;
        ```
    - Update all records:
        ```sql
        UPDATE TableName
        SET Age = 31;
        ```
7. **Delete Query**:
    - Delete a single record:
        ```sql
        DELETE FROM TableName
        WHERE Id = 1;
        ```
    - Delete all records:
        ```sql
        DELETE FROM TableName;
        ```
8. **Select**:
    - Select all columns from a table:
        ```sql
        SELECT * FROM TableName;
        ```
    - Select specific columns:
        ```sql
        SELECT ColumnName1, ColumnName2
        FROM TableName;
        ```
9. **Create View**: A view is a virtual table based on a SQL statement:
    ```sql
    CREATE VIEW view_name AS
    SELECT Id, Name, Age
    FROM TableName;
    ```
    Usage: `SELECT * FROM view_name;`
10. **Create Stored Procedure**:
    ```sql
    CREATE PROCEDURE getInfoFromTable AS
    SELECT * FROM TableName;
    ```
11. **Get All Column Names from Table**:
    - Retrieve column names:
        ```sql
        SELECT COLUMN_NAME
        FROM INFORMATION_SCHEMA.COLUMNS
        WHERE TABLE_NAME = 'TableName';
        ```
    - Get column names with data types:
        ```sql
        SELECT COLUMN_NAME, DATA_TYPE
        FROM INFORMATION_SCHEMA.COLUMNS
        WHERE TABLE_NAME = 'TableName';
        ```
12. **Search Column Name from Database**:
    - Find matching column names:
        ```sql
        SELECT c.name AS ColName, t.name AS TableName
        FROM sys.columns c
        JOIN sys.tables t ON c.object_id = t.object_id;
        ```

These queries cover a range of common tasks and are essential for any SQL Server developer. Feel free to explore and practice them! 🚀

Source: Conversation with Bing, 4/2/2024
(1) 75 Important queries in SQL Server every developer should know. https://www.codingfusion.com/Post/75-Important-queries-in-SQL-Server-every-developer-should-know.
(2) The Most Important SQL Queries for Beginners | LearnSQL.com. https://learnsql.com/blog/most-important-sql-queries-for-beginners/.
(3) 20 Basic SQL Query Examples for Beginners | LearnSQL.com. https://learnsql.com/blog/basic-sql-query-examples/.
