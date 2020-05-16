/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [pub_id]
      ,[publisher_name]
      ,[city]
      ,[state]
      ,[country]
  FROM [BookStoresDB].[dbo].[Publisher]