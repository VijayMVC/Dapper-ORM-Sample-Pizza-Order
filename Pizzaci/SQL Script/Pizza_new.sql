/****** Object:  Table [dbo].[Ebatlar]    Script Date: 19.07.2016 12:18:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ebatlar](
	[EbatId] [int] IDENTITY(1,1) NOT NULL,
	[Ebat] [varchar](50) NOT NULL,
	[Carpan] [decimal](5, 2) NOT NULL,
 CONSTRAINT [PK_Ebatlar] PRIMARY KEY CLUSTERED 
(
	[EbatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Malzemeler]    Script Date: 19.07.2016 12:18:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Malzemeler](
	[MalzemeId] [int] IDENTITY(1,1) NOT NULL,
	[Malzeme_Adi] [varchar](50) NOT NULL,
	[Fiyat] [decimal](5, 2) NOT NULL,
 CONSTRAINT [PK__tmp_ms_x__4ED155C0AAA51DE2] PRIMARY KEY CLUSTERED 
(
	[MalzemeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PizzaKenarTur]    Script Date: 19.07.2016 12:18:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PizzaKenarTur](
	[KenarTurId] [int] IDENTITY(1,1) NOT NULL,
	[KenarTurAdi] [varchar](50) NOT NULL,
	[Fiyat] [decimal](5, 2) NOT NULL,
 CONSTRAINT [PK_PizzaKenarTur] PRIMARY KEY CLUSTERED 
(
	[KenarTurId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PizzaTur]    Script Date: 19.07.2016 12:18:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PizzaTur](
	[PizzaTurId] [int] IDENTITY(1,1) NOT NULL,
	[PizzaTurAdi] [varchar](50) NOT NULL,
	[Fiyat] [decimal](5, 2) NOT NULL,
 CONSTRAINT [PK_Pizzalar] PRIMARY KEY CLUSTERED 
(
	[PizzaTurId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sepet]    Script Date: 19.07.2016 12:18:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sepet](
	[SepetId] [int] IDENTITY(1,1) NOT NULL,
	[durum] [bit] NOT NULL,
	[tarih] [datetime] NOT NULL,
	[GenelToplam] [decimal](5, 2) NULL,
 CONSTRAINT [PK_Sepet] PRIMARY KEY CLUSTERED 
(
	[SepetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Siparis]    Script Date: 19.07.2016 12:18:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparis](
	[SiparisId] [int] IDENTITY(1,1) NOT NULL,
	[SepetId] [int] NULL,
	[Adet] [int] NULL,
	[Fiyat] [decimal](5, 2) NULL,
 CONSTRAINT [PK_Siparis] PRIMARY KEY CLUSTERED 
(
	[SiparisId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SiparisEbat]    Script Date: 19.07.2016 12:18:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiparisEbat](
	[SiparisEbatId] [int] IDENTITY(1,1) NOT NULL,
	[EbatId] [int] NOT NULL,
	[SiparisId] [int] NULL,
 CONSTRAINT [PK_SiparisEbat] PRIMARY KEY CLUSTERED 
(
	[SiparisEbatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SiparisKenarTur]    Script Date: 19.07.2016 12:18:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiparisKenarTur](
	[SiparisKenarTurId] [int] IDENTITY(1,1) NOT NULL,
	[SiparisId] [int] NOT NULL,
	[KenarTurId] [int] NULL,
 CONSTRAINT [PK_SiparisKenarTur] PRIMARY KEY CLUSTERED 
(
	[SiparisKenarTurId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SiparisMalzeme]    Script Date: 19.07.2016 12:18:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiparisMalzeme](
	[SiparisMalzemeId] [int] IDENTITY(1,1) NOT NULL,
	[SiparisId] [int] NOT NULL,
	[MalzemeId] [int] NOT NULL,
 CONSTRAINT [PK_SiparisMalzeme] PRIMARY KEY CLUSTERED 
(
	[SiparisMalzemeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SiparisTur]    Script Date: 19.07.2016 12:18:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiparisTur](
	[SiparisTurId] [int] IDENTITY(1,1) NOT NULL,
	[PizzaTurId] [int] NOT NULL,
	[SiparisId] [int] NULL,
 CONSTRAINT [PK_SiparisTur] PRIMARY KEY CLUSTERED 
(
	[SiparisTurId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Ebatlar] ON 

INSERT [dbo].[Ebatlar] ([EbatId], [Ebat], [Carpan]) VALUES (1, N'Küçük', CAST(1.00 AS Decimal(5, 2)))
INSERT [dbo].[Ebatlar] ([EbatId], [Ebat], [Carpan]) VALUES (2, N'Orta', CAST(1.25 AS Decimal(5, 2)))
INSERT [dbo].[Ebatlar] ([EbatId], [Ebat], [Carpan]) VALUES (3, N'Büyük', CAST(1.75 AS Decimal(5, 2)))
INSERT [dbo].[Ebatlar] ([EbatId], [Ebat], [Carpan]) VALUES (4, N'Maxi', CAST(2.00 AS Decimal(5, 2)))
SET IDENTITY_INSERT [dbo].[Ebatlar] OFF
SET IDENTITY_INSERT [dbo].[Malzemeler] ON 

INSERT [dbo].[Malzemeler] ([MalzemeId], [Malzeme_Adi], [Fiyat]) VALUES (1, N'Dana Jambon', CAST(0.50 AS Decimal(5, 2)))
INSERT [dbo].[Malzemeler] ([MalzemeId], [Malzeme_Adi], [Fiyat]) VALUES (2, N'Sosis', CAST(0.50 AS Decimal(5, 2)))
INSERT [dbo].[Malzemeler] ([MalzemeId], [Malzeme_Adi], [Fiyat]) VALUES (3, N'Mısır', CAST(0.50 AS Decimal(5, 2)))
INSERT [dbo].[Malzemeler] ([MalzemeId], [Malzeme_Adi], [Fiyat]) VALUES (4, N'Kekik', CAST(0.50 AS Decimal(5, 2)))
INSERT [dbo].[Malzemeler] ([MalzemeId], [Malzeme_Adi], [Fiyat]) VALUES (5, N'Zeytin', CAST(0.50 AS Decimal(5, 2)))
INSERT [dbo].[Malzemeler] ([MalzemeId], [Malzeme_Adi], [Fiyat]) VALUES (6, N'Salam', CAST(0.50 AS Decimal(5, 2)))
INSERT [dbo].[Malzemeler] ([MalzemeId], [Malzeme_Adi], [Fiyat]) VALUES (7, N'Sucuk', CAST(0.50 AS Decimal(5, 2)))
INSERT [dbo].[Malzemeler] ([MalzemeId], [Malzeme_Adi], [Fiyat]) VALUES (8, N'Mantar', CAST(0.50 AS Decimal(5, 2)))
INSERT [dbo].[Malzemeler] ([MalzemeId], [Malzeme_Adi], [Fiyat]) VALUES (9, N'Ton Balığı', CAST(0.50 AS Decimal(5, 2)))
INSERT [dbo].[Malzemeler] ([MalzemeId], [Malzeme_Adi], [Fiyat]) VALUES (10, N'Peynir', CAST(0.50 AS Decimal(5, 2)))
SET IDENTITY_INSERT [dbo].[Malzemeler] OFF
SET IDENTITY_INSERT [dbo].[PizzaKenarTur] ON 

INSERT [dbo].[PizzaKenarTur] ([KenarTurId], [KenarTurAdi], [Fiyat]) VALUES (2, N'İnce Kenar', CAST(1.00 AS Decimal(5, 2)))
INSERT [dbo].[PizzaKenarTur] ([KenarTurId], [KenarTurAdi], [Fiyat]) VALUES (3, N'Kalın Kenar', CAST(2.00 AS Decimal(5, 2)))
SET IDENTITY_INSERT [dbo].[PizzaKenarTur] OFF
SET IDENTITY_INSERT [dbo].[PizzaTur] ON 

INSERT [dbo].[PizzaTur] ([PizzaTurId], [PizzaTurAdi], [Fiyat]) VALUES (2, N'KLASİK', CAST(14.00 AS Decimal(5, 2)))
INSERT [dbo].[PizzaTur] ([PizzaTurId], [PizzaTurAdi], [Fiyat]) VALUES (3, N'KARIŞIK', CAST(17.00 AS Decimal(5, 2)))
INSERT [dbo].[PizzaTur] ([PizzaTurId], [PizzaTurAdi], [Fiyat]) VALUES (4, N'ESTRAVAGANZA', CAST(21.00 AS Decimal(5, 2)))
INSERT [dbo].[PizzaTur] ([PizzaTurId], [PizzaTurAdi], [Fiyat]) VALUES (5, N'ITALIANO', CAST(23.00 AS Decimal(5, 2)))
INSERT [dbo].[PizzaTur] ([PizzaTurId], [PizzaTurAdi], [Fiyat]) VALUES (6, N'TURKISH', CAST(18.00 AS Decimal(5, 2)))
INSERT [dbo].[PizzaTur] ([PizzaTurId], [PizzaTurAdi], [Fiyat]) VALUES (7, N'TUNA', CAST(19.00 AS Decimal(5, 2)))
INSERT [dbo].[PizzaTur] ([PizzaTurId], [PizzaTurAdi], [Fiyat]) VALUES (8, N'SEAFEED', CAST(20.00 AS Decimal(5, 2)))
INSERT [dbo].[PizzaTur] ([PizzaTurId], [PizzaTurAdi], [Fiyat]) VALUES (9, N'CALYPSO', CAST(20.00 AS Decimal(5, 2)))
INSERT [dbo].[PizzaTur] ([PizzaTurId], [PizzaTurAdi], [Fiyat]) VALUES (10, N'AKDENİZ', CAST(21.00 AS Decimal(5, 2)))
INSERT [dbo].[PizzaTur] ([PizzaTurId], [PizzaTurAdi], [Fiyat]) VALUES (11, N'KARADENİZ', CAST(21.00 AS Decimal(5, 2)))
SET IDENTITY_INSERT [dbo].[PizzaTur] OFF
SET IDENTITY_INSERT [dbo].[Sepet] ON 

INSERT [dbo].[Sepet] ([SepetId], [durum], [tarih], [GenelToplam]) VALUES (41, 1, CAST(N'2016-06-17 09:05:32.940' AS DateTime), CAST(24.38 AS Decimal(5, 2)))
INSERT [dbo].[Sepet] ([SepetId], [durum], [tarih], [GenelToplam]) VALUES (42, 1, CAST(N'2016-06-17 13:14:19.433' AS DateTime), CAST(54.25 AS Decimal(5, 2)))
INSERT [dbo].[Sepet] ([SepetId], [durum], [tarih], [GenelToplam]) VALUES (43, 1, CAST(N'2016-06-17 15:03:46.677' AS DateTime), CAST(23.13 AS Decimal(5, 2)))
SET IDENTITY_INSERT [dbo].[Sepet] OFF
SET IDENTITY_INSERT [dbo].[Siparis] ON 

INSERT [dbo].[Siparis] ([SiparisId], [SepetId], [Adet], [Fiyat]) VALUES (42, 41, 1, CAST(24.38 AS Decimal(5, 2)))
INSERT [dbo].[Siparis] ([SiparisId], [SepetId], [Adet], [Fiyat]) VALUES (43, 42, 2, CAST(54.25 AS Decimal(5, 2)))
INSERT [dbo].[Siparis] ([SiparisId], [SepetId], [Adet], [Fiyat]) VALUES (44, 43, 1, CAST(23.13 AS Decimal(5, 2)))
SET IDENTITY_INSERT [dbo].[Siparis] OFF
SET IDENTITY_INSERT [dbo].[SiparisEbat] ON 

INSERT [dbo].[SiparisEbat] ([SiparisEbatId], [EbatId], [SiparisId]) VALUES (13, 2, 42)
INSERT [dbo].[SiparisEbat] ([SiparisEbatId], [EbatId], [SiparisId]) VALUES (14, 3, 43)
INSERT [dbo].[SiparisEbat] ([SiparisEbatId], [EbatId], [SiparisId]) VALUES (15, 2, 44)
SET IDENTITY_INSERT [dbo].[SiparisEbat] OFF
SET IDENTITY_INSERT [dbo].[SiparisKenarTur] ON 

INSERT [dbo].[SiparisKenarTur] ([SiparisKenarTurId], [SiparisId], [KenarTurId]) VALUES (11, 42, 3)
INSERT [dbo].[SiparisKenarTur] ([SiparisKenarTurId], [SiparisId], [KenarTurId]) VALUES (12, 43, 2)
INSERT [dbo].[SiparisKenarTur] ([SiparisKenarTurId], [SiparisId], [KenarTurId]) VALUES (13, 44, 2)
SET IDENTITY_INSERT [dbo].[SiparisKenarTur] OFF
SET IDENTITY_INSERT [dbo].[SiparisMalzeme] ON 

INSERT [dbo].[SiparisMalzeme] ([SiparisMalzemeId], [SiparisId], [MalzemeId]) VALUES (19, 42, 1)
INSERT [dbo].[SiparisMalzeme] ([SiparisMalzemeId], [SiparisId], [MalzemeId]) VALUES (20, 43, 1)
INSERT [dbo].[SiparisMalzeme] ([SiparisMalzemeId], [SiparisId], [MalzemeId]) VALUES (21, 44, 1)
SET IDENTITY_INSERT [dbo].[SiparisMalzeme] OFF
SET IDENTITY_INSERT [dbo].[SiparisTur] ON 

INSERT [dbo].[SiparisTur] ([SiparisTurId], [PizzaTurId], [SiparisId]) VALUES (10, 3, 42)
INSERT [dbo].[SiparisTur] ([SiparisTurId], [PizzaTurId], [SiparisId]) VALUES (11, 2, 43)
INSERT [dbo].[SiparisTur] ([SiparisTurId], [PizzaTurId], [SiparisId]) VALUES (12, 3, 44)
SET IDENTITY_INSERT [dbo].[SiparisTur] OFF
ALTER TABLE [dbo].[Siparis]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_Sepet1] FOREIGN KEY([SepetId])
REFERENCES [dbo].[Sepet] ([SepetId])
GO
ALTER TABLE [dbo].[Siparis] CHECK CONSTRAINT [FK_Siparis_Sepet1]
GO
ALTER TABLE [dbo].[SiparisEbat]  WITH CHECK ADD  CONSTRAINT [FK_SiparisEbat_Ebatlar] FOREIGN KEY([EbatId])
REFERENCES [dbo].[Ebatlar] ([EbatId])
GO
ALTER TABLE [dbo].[SiparisEbat] CHECK CONSTRAINT [FK_SiparisEbat_Ebatlar]
GO
ALTER TABLE [dbo].[SiparisEbat]  WITH CHECK ADD  CONSTRAINT [FK_SiparisEbat_Siparis] FOREIGN KEY([SiparisId])
REFERENCES [dbo].[Siparis] ([SiparisId])
GO
ALTER TABLE [dbo].[SiparisEbat] CHECK CONSTRAINT [FK_SiparisEbat_Siparis]
GO
ALTER TABLE [dbo].[SiparisKenarTur]  WITH CHECK ADD  CONSTRAINT [FK_SiparisKenarTur_PizzaKenarTur] FOREIGN KEY([KenarTurId])
REFERENCES [dbo].[PizzaKenarTur] ([KenarTurId])
GO
ALTER TABLE [dbo].[SiparisKenarTur] CHECK CONSTRAINT [FK_SiparisKenarTur_PizzaKenarTur]
GO
ALTER TABLE [dbo].[SiparisKenarTur]  WITH CHECK ADD  CONSTRAINT [FK_SiparisKenarTur_Siparis] FOREIGN KEY([SiparisId])
REFERENCES [dbo].[Siparis] ([SiparisId])
GO
ALTER TABLE [dbo].[SiparisKenarTur] CHECK CONSTRAINT [FK_SiparisKenarTur_Siparis]
GO
ALTER TABLE [dbo].[SiparisMalzeme]  WITH CHECK ADD  CONSTRAINT [FK_SiparisMalzeme_Malzemeler] FOREIGN KEY([MalzemeId])
REFERENCES [dbo].[Malzemeler] ([MalzemeId])
GO
ALTER TABLE [dbo].[SiparisMalzeme] CHECK CONSTRAINT [FK_SiparisMalzeme_Malzemeler]
GO
ALTER TABLE [dbo].[SiparisMalzeme]  WITH CHECK ADD  CONSTRAINT [FK_SiparisMalzeme_Siparis] FOREIGN KEY([SiparisId])
REFERENCES [dbo].[Siparis] ([SiparisId])
GO
ALTER TABLE [dbo].[SiparisMalzeme] CHECK CONSTRAINT [FK_SiparisMalzeme_Siparis]
GO
ALTER TABLE [dbo].[SiparisTur]  WITH CHECK ADD  CONSTRAINT [FK_SiparisTur_PizzaTur] FOREIGN KEY([PizzaTurId])
REFERENCES [dbo].[PizzaTur] ([PizzaTurId])
GO
ALTER TABLE [dbo].[SiparisTur] CHECK CONSTRAINT [FK_SiparisTur_PizzaTur]
GO
ALTER TABLE [dbo].[SiparisTur]  WITH CHECK ADD  CONSTRAINT [FK_SiparisTur_Siparis] FOREIGN KEY([SiparisId])
REFERENCES [dbo].[Siparis] ([SiparisId])
GO
ALTER TABLE [dbo].[SiparisTur] CHECK CONSTRAINT [FK_SiparisTur_Siparis]
GO
