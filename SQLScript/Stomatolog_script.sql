USE [Stomatolog]
GO
/****** Object:  Table [dbo].[Diagrams]    Script Date: 17.04.2016 19:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagrams](
	[DiagramId] [int] IDENTITY(1,1) NOT NULL,
	[PozX] [int] NOT NULL,
	[PozY] [int] NOT NULL,
	[Color] [int] NOT NULL,
	[Type] [int] NOT NULL,
	[State] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Diagrams] PRIMARY KEY CLUSTERED 
(
	[DiagramId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patients]    Script Date: 17.04.2016 19:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[PatientId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Surname] [nvarchar](max) NULL,
	[DateOfBirth] [datetime] NULL,
	[Address] [nvarchar](max) NULL,
	[Pesel] [nvarchar](max) NULL,
	[Nip] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[DiagramId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Patients] PRIMARY KEY CLUSTERED 
(
	[PatientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pictures]    Script Date: 17.04.2016 19:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pictures](
	[PictureId] [int] IDENTITY(1,1) NOT NULL,
	[PictureName] [nvarchar](max) NULL,
	[PatientId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Pictures] PRIMARY KEY CLUSTERED 
(
	[PictureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Visits]    Script Date: 17.04.2016 19:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visits](
	[VisitId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[DateOfVisit] [datetime] NULL,
	[PatientId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Visits] PRIMARY KEY CLUSTERED 
(
	[VisitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Patients]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Patients_dbo.Diagrams_DiagramId] FOREIGN KEY([DiagramId])
REFERENCES [dbo].[Diagrams] ([DiagramId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Patients] CHECK CONSTRAINT [FK_dbo.Patients_dbo.Diagrams_DiagramId]
GO
ALTER TABLE [dbo].[Pictures]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Pictures_dbo.Patients_PatientId] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([PatientId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pictures] CHECK CONSTRAINT [FK_dbo.Pictures_dbo.Patients_PatientId]
GO
ALTER TABLE [dbo].[Visits]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Visits_dbo.Patients_PatientId] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([PatientId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Visits] CHECK CONSTRAINT [FK_dbo.Visits_dbo.Patients_PatientId]
GO
