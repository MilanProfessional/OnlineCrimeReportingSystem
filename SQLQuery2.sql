/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [AdminID]
      ,[FullName]
      ,[Email]
      ,[Password]
  FROM [OnlineCrimeReportingSystem].[dbo].[AdminProfile]
  delete from AdminProfile;