/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Message]
      ,[CrimeDate]
      ,[Name]
      ,[CriminalName]
      ,[Email]
      ,[Subject]
      ,[Location]
      ,[Files]
      ,[Status]
      ,[ReportingDate]
      ,[UpdateDate]
  FROM [OnlineCrimeReportingSystem].[dbo].[Crime]

  delete from Crime;