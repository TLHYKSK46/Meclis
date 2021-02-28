USE [Meclis]
GO
/****** Object:  Table [dbo].[danisman]    Script Date: 22.02.2021 11:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[danisman](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tc_kimlik_no] [nchar](10) NULL,
	[ad] [nchar](10) NULL,
	[soyad] [nchar](10) NULL,
	[il_id] [int] NULL,
	[mail] [nchar](10) NULL,
	[tel_no] [nchar](10) NULL,
	[vekil_id] [nchar](10) NULL,
 CONSTRAINT [PK_danisman] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[genel_merkez_gorev]    Script Date: 22.02.2021 11:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[genel_merkez_gorev](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[genel_merkez_gorev_adi] [nvarchar](50) NULL,
 CONSTRAINT [PK_genel_merkez_gorev] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hatirlatma]    Script Date: 22.02.2021 11:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hatirlatma](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[baslik] [nvarchar](50) NULL,
	[aciklama] [nvarchar](max) NULL,
	[hatirlatma_tarihi] [datetime] NULL,
	[olusturma_tarihi] [datetime] NULL,
 CONSTRAINT [PK_hatirlatma] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[il]    Script Date: 22.02.2021 11:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[il](
	[id] [int] NOT NULL,
	[il_kodu] [int] NULL,
	[il_adi] [nvarchar](50) NULL,
	[il_bölgesi] [nvarchar](50) NULL,
 CONSTRAINT [PK_il] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[komisyon]    Script Date: 22.02.2021 11:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[komisyon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ihtisas_id] [int] NULL,
	[uluslararası_id] [int] NULL,
 CONSTRAINT [PK_komisyonlar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[komisyon_ihtisas]    Script Date: 22.02.2021 11:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[komisyon_ihtisas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ihtisas_komisyon_adi] [nvarchar](max) NULL,
 CONSTRAINT [PK_komisyon_ihtisas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[komisyon_uluslararasi]    Script Date: 22.02.2021 11:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[komisyon_uluslararasi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[uluslararasi_adi] [nvarchar](max) NULL,
 CONSTRAINT [PK_komisyon_uluslararasi] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mazeret]    Script Date: 22.02.2021 11:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mazeret](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[vekil_id] [int] NULL,
	[il_id] [int] NULL,
	[mazaret_kod_id] [int] NULL,
	[mazaret_nedeni] [nvarchar](max) NULL,
	[baslama_tarihi] [datetime] NULL,
	[bitis_tarihi] [datetime] NULL,
 CONSTRAINT [PK_mazaret] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mazeret_kod]    Script Date: 22.02.2021 11:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mazeret_kod](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[mazeret_kodu] [nvarchar](50) NULL,
 CONSTRAINT [PK_mazeret_kod] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[meclis_gorev]    Script Date: 22.02.2021 11:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[meclis_gorev](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[meclis_gorev_adi] [nvarchar](100) NULL,
 CONSTRAINT [PK_meclis_gorev] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vekil]    Script Date: 22.02.2021 11:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vekil](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tc_kimlik_no] [nvarchar](50) NULL,
	[ad] [nvarchar](100) NULL,
	[soyad] [nvarchar](100) NULL,
	[kurumsal_tel_no] [nvarchar](15) NULL,
	[kisisel_tel_no] [nvarchar](15) NULL,
	[kurumsal_mail] [nvarchar](100) NULL,
	[kisisel_mail] [nvarchar](100) NOT NULL,
	[cinsiyet] [int] NULL,
	[oda_no] [nvarchar](20) NULL,
	[gorev_id] [int] NULL,
	[meclis_gorev_id] [int] NULL,
	[genel_merkez_gorev_id] [int] NULL,
	[komisyon_id] [int] NULL,
	[il_id] [int] NULL,
	[donem] [int] NULL,
	[aciklama] [nvarchar](max) NULL,
	[yabanci_dil_id] [int] NULL,
	[yabanci_dil_seviye_id] [int] NULL,
	[mazaret_id] [int] NULL,
	[danisman_1_id] [int] NOT NULL,
	[danisman_2_id] [int] NULL,
	[danisman_3_id] [int] NULL,
 CONSTRAINT [PK_ozluk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[yabanci_dil]    Script Date: 22.02.2021 11:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[yabanci_dil](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[yabanci_dil_adi] [nvarchar](50) NULL,
 CONSTRAINT [PK_yabanci_dil] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[yabanci_dil_seviye]    Script Date: 22.02.2021 11:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[yabanci_dil_seviye](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[yabanci_dil_id] [nvarchar](50) NULL,
	[yabanci_dil_seviye] [nvarchar](50) NULL,
 CONSTRAINT [PK_yabanci_dil_seviye] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[vekil]  WITH CHECK ADD  CONSTRAINT [FK_vekil_danisman] FOREIGN KEY([danisman_1_id])
REFERENCES [dbo].[danisman] ([id])
GO
ALTER TABLE [dbo].[vekil] CHECK CONSTRAINT [FK_vekil_danisman]
GO
ALTER TABLE [dbo].[vekil]  WITH CHECK ADD  CONSTRAINT [FK_vekil_danisman1] FOREIGN KEY([danisman_2_id])
REFERENCES [dbo].[danisman] ([id])
GO
ALTER TABLE [dbo].[vekil] CHECK CONSTRAINT [FK_vekil_danisman1]
GO
ALTER TABLE [dbo].[vekil]  WITH CHECK ADD  CONSTRAINT [FK_vekil_danisman2] FOREIGN KEY([danisman_3_id])
REFERENCES [dbo].[danisman] ([id])
GO
ALTER TABLE [dbo].[vekil] CHECK CONSTRAINT [FK_vekil_danisman2]
GO
ALTER TABLE [dbo].[vekil]  WITH CHECK ADD  CONSTRAINT [FK_vekil_genel_merkez_gorev] FOREIGN KEY([genel_merkez_gorev_id])
REFERENCES [dbo].[genel_merkez_gorev] ([id])
GO
ALTER TABLE [dbo].[vekil] CHECK CONSTRAINT [FK_vekil_genel_merkez_gorev]
GO
ALTER TABLE [dbo].[vekil]  WITH CHECK ADD  CONSTRAINT [FK_vekil_il] FOREIGN KEY([donem])
REFERENCES [dbo].[il] ([id])
GO
ALTER TABLE [dbo].[vekil] CHECK CONSTRAINT [FK_vekil_il]
GO
ALTER TABLE [dbo].[vekil]  WITH CHECK ADD  CONSTRAINT [FK_vekil_komisyon] FOREIGN KEY([komisyon_id])
REFERENCES [dbo].[komisyon] ([id])
GO
ALTER TABLE [dbo].[vekil] CHECK CONSTRAINT [FK_vekil_komisyon]
GO
ALTER TABLE [dbo].[vekil]  WITH CHECK ADD  CONSTRAINT [FK_vekil_mazeret] FOREIGN KEY([mazaret_id])
REFERENCES [dbo].[mazeret] ([id])
GO
ALTER TABLE [dbo].[vekil] CHECK CONSTRAINT [FK_vekil_mazeret]
GO
ALTER TABLE [dbo].[vekil]  WITH CHECK ADD  CONSTRAINT [FK_vekil_mazeret_kod] FOREIGN KEY([mazaret_id])
REFERENCES [dbo].[mazeret_kod] ([id])
GO
ALTER TABLE [dbo].[vekil] CHECK CONSTRAINT [FK_vekil_mazeret_kod]
GO
ALTER TABLE [dbo].[vekil]  WITH CHECK ADD  CONSTRAINT [FK_vekil_meclis_gorev] FOREIGN KEY([gorev_id])
REFERENCES [dbo].[meclis_gorev] ([id])
GO
ALTER TABLE [dbo].[vekil] CHECK CONSTRAINT [FK_vekil_meclis_gorev]
GO
ALTER TABLE [dbo].[vekil]  WITH CHECK ADD  CONSTRAINT [FK_vekil_yabanci_dil] FOREIGN KEY([yabanci_dil_id])
REFERENCES [dbo].[yabanci_dil] ([id])
GO
ALTER TABLE [dbo].[vekil] CHECK CONSTRAINT [FK_vekil_yabanci_dil]
GO
ALTER TABLE [dbo].[vekil]  WITH CHECK ADD  CONSTRAINT [FK_vekil_yabanci_dil_seviye] FOREIGN KEY([yabanci_dil_seviye_id])
REFERENCES [dbo].[yabanci_dil_seviye] ([id])
GO
ALTER TABLE [dbo].[vekil] CHECK CONSTRAINT [FK_vekil_yabanci_dil_seviye]
GO
