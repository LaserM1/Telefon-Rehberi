USE [rehber]
GO

/****** Object:  Table [dbo].[rehber]    Script Date: 13.02.2025 14:52:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[rehber](
	[no] [int] IDENTITY(1,1) NOT NULL,
	[isim] [nvarchar](255) NULL,
	[soyisim] [nvarchar](255) NULL,
	[dogum_gunu] [datetime] NULL,
	[tel] [nvarchar](255) NULL,
	[favori] [nvarchar](255) NULL,
 CONSTRAINT [PK_rehber] PRIMARY KEY CLUSTERED 
(
	[no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

