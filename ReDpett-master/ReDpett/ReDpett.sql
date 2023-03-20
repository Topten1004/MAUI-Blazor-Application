--sp
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpInsertProjectRecord]
  @GlobalRecordId nvarchar(255),
  @RALevel bit,
  @FETPFrontline nvarchar(255),
  @RPFL1_CohortNumber float,
  @RPFL2_CohortStart datetime,
  @RPFL3_CohortEnd datetime,
  @RPFL4_RosterNumber float,
  @RPFL5_NameLast nvarchar(4000),
  @RPFL6_NameFirst nvarchar(4000),
  @RPFL7_FullName nvarchar(4000),
  @RPFL8_Sex nvarchar(255),
  @RPFL_DateofBirth datetime,
  @RPFL9_Age float,
  @RPFL10_Email nvarchar(4000),
  @RPFL12_Employer nvarchar(4000),
  @RPFL11_ProBckgrd nvarchar(255),
  @RPFL11b_Other nvarchar(4000),
  @RPFL14_YearJob float,
  @RPFL13_JobTitle nvarchar(4000),
  @RPFL16_SupervisorName nvarchar(4000),
  @RPFL15_SiteName nvarchar(4000),
  @RPFL20_Latitude float,
  @RPFL21_Location ntext,
  @RPFL19_Longitude float,
  @RPFL17_District nvarchar(4000),
  @RPFL18_Region nvarchar(4000),
  @RPFL22_FacilityName nvarchar(4000),
  @RPFL23a_LevelFacility nvarchar(255),
  @RPFL23b_Other nvarchar(4000)
  AS
BEGIN
INSERT INTO [dbo].[Frontline36](
       [GlobalRecordId]
      ,[RALevel]
      ,[FETPFrontline]
      ,[RPFL1_CohortNumber]
      ,[RPFL2_CohortStart]
      ,[RPFL3_CohortEnd]
      ,[RPFL4_RosterNumber]
      ,[RPFL5_NameLast]
      ,[RPFL6_NameFirst]
      ,[RPFL7_FullName]
      ,[RPFL8_Sex]
      ,[RPFL_DateofBirth]
      ,[RPFL9_Age]
      ,[RPFL10_Email]
      ,[RPFL12_Employer]
      ,[RPFL11_ProBckgrd]
      ,[RPFL11b_Other]
      ,[RPFL14_YearJob]
      ,[RPFL13_JobTitle]
      ,[RPFL16_SupervisorName]
      ,[RPFL15_SiteName]
      ,[RPFL20_Latitude]
      ,[RPFL21_Location]
      ,[RPFL19_Longitude]
      ,[RPFL17_District]
      ,[RPFL18_Region]
      ,[RPFL22_FacilityName]
      ,[RPFL23a_LevelFacility]
      ,[RPFL23b_Other])
	  VALUES (
  @GlobalRecordId,
  @RALevel,
  @FETPFrontline,
  @RPFL1_CohortNumber,
  @RPFL2_CohortStart,
  @RPFL3_CohortEnd,
  @RPFL4_RosterNumber,
  @RPFL5_NameLast,
  @RPFL6_NameFirst,
  @RPFL7_FullName,
  @RPFL8_Sex,
  @RPFL_DateofBirth,
  @RPFL9_Age,
  @RPFL10_Email,
  @RPFL12_Employer,
  @RPFL11_ProBckgrd,
  @RPFL11b_Other,
  @RPFL14_YearJob,
  @RPFL13_JobTitle,
  @RPFL16_SupervisorName,
  @RPFL15_SiteName,
  @RPFL20_Latitude,
  @RPFL21_Location,
  @RPFL19_Longitude,
  @RPFL17_District,
  @RPFL18_Region,
  @RPFL22_FacilityName,
  @RPFL23a_LevelFacility,
  @RPFL23b_Other)
END
GO
--table
USE [TrackingMasterOLD]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectAttachment](
	[project_id] [nvarchar](255) NOT NULL,
	[file] varchar(max) NOT NULL,
	[FileName] [nvarchar](255) NULL,
	[fileContentType] [nvarchar](255)NULL,
	[fileSize] [nvarchar](255) NULL,
	[reportTitle] [nvarchar](225) NULL,
	[reportCategory] [nvarchar](255) NULL,
	CONSTRAINT FK_projectId FOREIGN KEY (project_id)
    REFERENCES Frontline36(GlobalRecordId)
) ON [PRIMARY]
GO
--sp
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpInsertAttachmentRecord]
  @record_id nvarchar(255),
  @project_id nvarchar(255),
  @file varchar(max),
  @FileName nvarchar(255),
  @fileContentType nvarchar(255),
  @fileSize nvarchar(255),
  @reportTitle nvarchar(255),
  @reportCategory nvarchar(255)
  AS
BEGIN
INSERT INTO [dbo].[ProjectAttachment](
      [project_id]
      ,[file]
      ,[FileName]
      ,[fileContentType]
      ,[fileSize]
      ,[reportTitle]
      ,[reportCategory]
      )
	  VALUES (
  @project_id,
  @file,
  @FileName,
  @fileContentType,
  @fileSize,
  @reportTitle,
  @reportCategory
 )
END
GO