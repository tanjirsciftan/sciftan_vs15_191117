USE [master]
GO
/****** Object:  Database [SCIFTAN_DB_DEV]    Script Date: 11/15/2017 1:29:54 AM ******/
CREATE DATABASE [SCIFTAN_DB_DEV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SCIFTAN_DB_DEV', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SCIFTAN_DB_DEV.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SCIFTAN_DB_DEV_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SCIFTAN_DB_DEV_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SCIFTAN_DB_DEV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET ARITHABORT OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET  MULTI_USER 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SCIFTAN_DB_DEV]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 11/15/2017 1:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 11/15/2017 1:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 11/15/2017 1:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	[User_Id] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 11/15/2017 1:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[UserId] [nvarchar](128) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 11/15/2017 1:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 11/15/2017 1:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[Discriminator] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FREELANCER_CAREER_OBJECTIVE]    Script Date: 11/15/2017 1:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FREELANCER_CAREER_OBJECTIVE](
	[Freelancer_Id] [nvarchar](50) NOT NULL,
	[Career_Objective] [nvarchar](max) NULL,
 CONSTRAINT [PK_FREELANCER_CAREER_OBJECTIVE] PRIMARY KEY CLUSTERED 
(
	[Freelancer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FREELANCER_DOC_INFO]    Script Date: 11/15/2017 1:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FREELANCER_DOC_INFO](
	[Freelancer_Id] [nvarchar](50) NOT NULL,
	[NID_Path] [nvarchar](250) NULL,
	[Picture_Path] [nvarchar](250) NULL,
	[PVC_Path] [nvarchar](250) NULL,
 CONSTRAINT [PK_FREELANCER_DOC_INFO] PRIMARY KEY CLUSTERED 
(
	[Freelancer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FREELANCER_EDUCATION_INFO]    Script Date: 11/15/2017 1:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FREELANCER_EDUCATION_INFO](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Freelancer_Id] [nvarchar](50) NULL,
	[Degree] [nvarchar](50) NULL,
	[Institute] [nvarchar](250) NULL,
	[Year] [int] NULL,
	[Result] [nvarchar](50) NULL,
	[Subject] [nvarchar](50) NULL,
 CONSTRAINT [PK_FREELANCER_EDUCATION_INFO] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FREELANCER_EXPERIENCE_INFO]    Script Date: 11/15/2017 1:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FREELANCER_EXPERIENCE_INFO](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Freelancer_Id] [nvarchar](50) NOT NULL,
	[Organization] [nvarchar](250) NULL,
	[Designation] [nvarchar](50) NULL,
	[Responsibilities] [nvarchar](max) NULL,
	[AreaofExperiences] [nvarchar](max) NULL,
	[Location] [nvarchar](max) NULL,
	[FromDate] [date] NULL,
	[ToDate] [date] NULL,
 CONSTRAINT [PK_FREELANCER_EXPERIENCE_INFO] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FREELANCER_PERSONAL_INFO]    Script Date: 11/15/2017 1:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FREELANCER_PERSONAL_INFO](
	[Freelancer_Id] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[FatherName] [nvarchar](50) NULL,
	[MotherName] [nvarchar](50) NULL,
	[DOB] [nvarchar](50) NULL,
	[Gender] [nvarchar](10) NULL,
	[Religion] [nvarchar](20) NULL,
	[MaritalStatus] [nvarchar](10) NULL,
	[Nationality] [nvarchar](50) NULL,
	[NID] [nvarchar](50) NULL,
	[PresentAddress] [nvarchar](max) NULL,
	[PermanentAddress] [nvarchar](max) NULL,
	[Mobile1] [nvarchar](15) NULL,
	[Mobile2] [nvarchar](15) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_FREELANCER_PERSONAL_INFO] PRIMARY KEY CLUSTERED 
(
	[Freelancer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FREELANCER_SKILL_INFO]    Script Date: 11/15/2017 1:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FREELANCER_SKILL_INFO](
	[Id] [int] NOT NULL,
	[Freelancer_Id] [nvarchar](50) NULL,
	[Skill] [int] NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_FREELANCER_SKILL_INFO] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SKILL]    Script Date: 11/15/2017 1:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SKILL](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_SKILL] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_User_Id]    Script Date: 11/15/2017 1:29:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_User_Id] ON [dbo].[AspNetUserClaims]
(
	[User_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 11/15/2017 1:29:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_RoleId]    Script Date: 11/15/2017 1:29:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 11/15/2017 1:29:55 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_User_Id] FOREIGN KEY([User_Id])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_User_Id]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
USE [master]
GO
ALTER DATABASE [SCIFTAN_DB_DEV] SET  READ_WRITE 
GO
