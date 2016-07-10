USE [taxis]
GO
/****** Object:  Table [dbo].[ASIGNACIONES]    Script Date: 7/10/2016 12:10:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ASIGNACIONES](
	[ID_ASIGNACIONES] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[ID_UNIDAD] [numeric](18, 0) NULL,
	[ID_CLIENTE] [numeric](18, 0) NULL,
	[FECHA] [datetime] NULL,
	[HORA] [datetime] NULL,
	[DIRECCION_ORIGEN] [nvarchar](500) NULL,
 CONSTRAINT [PK_ASIGNACIONES] PRIMARY KEY NONCLUSTERED 
(
	[ID_ASIGNACIONES] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 7/10/2016 12:10:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[ID_CLIENTE] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[TELEFONO] [varchar](15) NULL,
	[CELULAR] [varchar](15) NULL,
	[DIRECCION] [varchar](250) NULL,
	[REFERENCIA] [varchar](250) NULL,
	[NOMBRE] [varchar](250) NULL,
	[ESTADO] [char](1) NULL,
 CONSTRAINT [PK_CLIENTES] PRIMARY KEY NONCLUSTERED 
(
	[ID_CLIENTE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CONFIGURACIONES]    Script Date: 7/10/2016 12:10:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CONFIGURACIONES](
	[ID_CONFIGURACION] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[PUERTO] [varchar](10) NULL,
	[VELOCIDAD] [int] NULL,
	[PARIDAD] [varchar](10) NULL,
	[ESTADO] [char](1) NULL,
	[BITS_DATOS] [varchar](15) NULL,
	[BITS_PARADA] [varchar](15) NULL,
 CONSTRAINT [PK_CONFIGURACIONES] PRIMARY KEY NONCLUSTERED 
(
	[ID_CONFIGURACION] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ORGANIZACION]    Script Date: 7/10/2016 12:10:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ORGANIZACION](
	[ID_ORGANIZACION] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](250) NULL,
	[DIRECCION] [varchar](250) NULL,
	[TELEFONO1] [varchar](15) NULL,
	[TELEFONO2] [varchar](15) NULL,
	[EMAIL] [varchar](150) NULL,
	[RUC] [varchar](13) NULL,
	[CELULAR] [varchar](15) NULL,
 CONSTRAINT [PK_ORGANIZACION] PRIMARY KEY NONCLUSTERED 
(
	[ID_ORGANIZACION] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UNIDADES]    Script Date: 7/10/2016 12:10:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UNIDADES](
	[ID_UNIDAD] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[PROPIETARIO] [varchar](150) NULL,
	[CHOFER] [varchar](150) NULL,
	[NUMERO_UNIDAD] [int] NULL,
	[PLACA] [varchar](25) NULL,
	[COLOR] [varchar](25) NULL,
	[AUTORIZACION] [varchar](50) NULL,
	[MATRICULA] [varchar](100) NULL,
	[ESTADO] [char](1) NULL,
 CONSTRAINT [PK_UNIDADES] PRIMARY KEY NONCLUSTERED 
(
	[ID_UNIDAD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 7/10/2016 12:10:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[ID_USUARIO] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[ROL] [varchar](50) NULL,
	[PASS] [varchar](250) NULL,
	[USER] [varchar](150) NULL,
	[ESTADO] [char](1) NULL,
 CONSTRAINT [PK_USUARIOS] PRIMARY KEY NONCLUSTERED 
(
	[ID_USUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[ASIGNACIONES]  WITH CHECK ADD  CONSTRAINT [FK_ASIGNACI_RELATIONS_CLIENTES] FOREIGN KEY([ID_CLIENTE])
REFERENCES [dbo].[CLIENTES] ([ID_CLIENTE])
GO
ALTER TABLE [dbo].[ASIGNACIONES] CHECK CONSTRAINT [FK_ASIGNACI_RELATIONS_CLIENTES]
GO
ALTER TABLE [dbo].[ASIGNACIONES]  WITH CHECK ADD  CONSTRAINT [FK_ASIGNACI_RELATIONS_UNIDADES] FOREIGN KEY([ID_UNIDAD])
REFERENCES [dbo].[UNIDADES] ([ID_UNIDAD])
GO
ALTER TABLE [dbo].[ASIGNACIONES] CHECK CONSTRAINT [FK_ASIGNACI_RELATIONS_UNIDADES]
GO
