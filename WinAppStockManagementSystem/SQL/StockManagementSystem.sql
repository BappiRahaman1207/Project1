 CREATE DATABASE StockManagementSystem

  -- DROP TABLE Categories

  CREATE TABLE Categories(
   ID int IDENTITY (1,1)PRIMARY KEY,
   Name VARCHAR(50)
   )
   
   INSERT INTO Categories(Name) VALUES ('Stationary')

   SELECT * FROM Categories