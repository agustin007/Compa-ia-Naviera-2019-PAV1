USE [Compañia_Naviera]
GO
/****** Object:  Table [dbo].[camarotes]    Script Date: 3/9/2019 15:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[camarotes](
	[numero_camarote] [int] NOT NULL,
	[cod_navio] [int] NOT NULL,
	[cod_cubierta] [int] NOT NULL,
	[FK_tipo] [int] NOT NULL,
	[ubicacion] [varchar](50) NOT NULL,
	[cantidad_camas] [int] NOT NULL,
 CONSTRAINT [PK_camarotes] PRIMARY KEY CLUSTERED 
(
	[numero_camarote] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[clasificacion_navio]    Script Date: 3/9/2019 15:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[clasificacion_navio](
	[cod_clasificacion] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_clasificacion_navio] PRIMARY KEY CLUSTERED 
(
	[cod_clasificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cubiertas]    Script Date: 3/9/2019 15:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cubiertas](
	[cod_navio] [int] NOT NULL,
	[numero_cubierta] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[legajo_encargado] [int] NOT NULL,
 CONSTRAINT [PK_cubiertas] PRIMARY KEY CLUSTERED 
(
	[numero_cubierta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[itinerarios]    Script Date: 3/9/2019 15:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[itinerarios](
	[cod_intinerarios] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[categoria] [int] NOT NULL,
 CONSTRAINT [PK_itinerarios] PRIMARY KEY CLUSTERED 
(
	[cod_intinerarios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[navios]    Script Date: 3/9/2019 15:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[navios](
	[cod_navio] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[altura] [int] NOT NULL,
	[autonomia] [int] NOT NULL,
	[desplazamiento] [int] NOT NULL,
	[eslora] [int] NOT NULL,
	[manga] [int] NOT NULL,
	[cantidad_maxima_pasajeros] [int] NOT NULL,
	[cantidad_tripulantes] [int] NOT NULL,
	[tipo_clasificacion] [int] NOT NULL,
	[cantidad_motores] [int] NOT NULL,
 CONSTRAINT [PK_Navios] PRIMARY KEY CLUSTERED 
(
	[cod_navio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pasaje_camarote]    Script Date: 3/9/2019 15:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pasaje_camarote](
	[fecha_viaje] [date] NOT NULL,
	[numero_camarote] [int] NOT NULL,
	[FK_cod_navio] [int] NOT NULL,
	[FK_numero_cubierta] [int] NOT NULL,
	[FK_tipo_documento] [nchar](10) NOT NULL,
	[FK_numero_documento] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[pasajeros]    Script Date: 3/9/2019 15:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pasajeros](
	[tipo_documento] [int] NOT NULL,
	[numero_documento] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[ciudad] [nchar](10) NOT NULL,
	[pais] [nchar](10) NOT NULL,
 CONSTRAINT [PK_pasajeros] PRIMARY KEY CLUSTERED 
(
	[numero_documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[puerto_itinerario]    Script Date: 3/9/2019 15:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[puerto_itinerario](
	[numero_escala] [int] NOT NULL,
	[FK_cod_itinerario] [int] NOT NULL,
	[FK_cod_puerto] [int] NOT NULL,
 CONSTRAINT [PK_puerto_itinerario] PRIMARY KEY CLUSTERED 
(
	[numero_escala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[puertos]    Script Date: 3/9/2019 15:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[puertos](
	[cod_puerto] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_puertos] PRIMARY KEY CLUSTERED 
(
	[cod_puerto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[puestos]    Script Date: 3/9/2019 15:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[puestos](
	[cod_puesto] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_puestos] PRIMARY KEY CLUSTERED 
(
	[cod_puesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo_camarote]    Script Date: 3/9/2019 15:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_camarote](
	[tipo] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tipo_camarote] PRIMARY KEY CLUSTERED 
(
	[tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tripulaciones]    Script Date: 3/9/2019 15:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tripulaciones](
	[legajo] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[FK_legajo_jefe] [int] NOT NULL,
	[FK_cod_puesto] [int] NOT NULL,
 CONSTRAINT [PK_tripulaciones] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tripulante_x_viaje]    Script Date: 3/9/2019 15:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tripulante_x_viaje](
	[legajo] [int] NOT NULL,
	[cod_navio] [int] NOT NULL,
	[fecha_viaje] [date] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 3/9/2019 15:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[password] [int] NOT NULL,
	[perfil] [varchar](50) NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[viajes]    Script Date: 3/9/2019 15:26:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[viajes](
	[fecha_viaje] [date] NOT NULL,
	[duracion] [int] NOT NULL,
	[FK_cod_navio] [int] NOT NULL,
	[FK_cod_itinerario] [int] NOT NULL,
 CONSTRAINT [PK_viajes] PRIMARY KEY CLUSTERED 
(
	[fecha_viaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[usuarios] ([id_usuario], [nombre], [password], [perfil]) VALUES (1, N'agustin', 123, N'Administrador')
INSERT [dbo].[usuarios] ([id_usuario], [nombre], [password], [perfil]) VALUES (2, N'matias', 456, N'Tester')
INSERT [dbo].[usuarios] ([id_usuario], [nombre], [password], [perfil]) VALUES (3, N'mariano', 789, N'Desarrollador')
ALTER TABLE [dbo].[camarotes]  WITH CHECK ADD  CONSTRAINT [FK_camarotes_cubiertas] FOREIGN KEY([cod_cubierta])
REFERENCES [dbo].[cubiertas] ([numero_cubierta])
GO
ALTER TABLE [dbo].[camarotes] CHECK CONSTRAINT [FK_camarotes_cubiertas]
GO
ALTER TABLE [dbo].[camarotes]  WITH CHECK ADD  CONSTRAINT [FK_camarotes_navios] FOREIGN KEY([cod_navio])
REFERENCES [dbo].[navios] ([cod_navio])
GO
ALTER TABLE [dbo].[camarotes] CHECK CONSTRAINT [FK_camarotes_navios]
GO
ALTER TABLE [dbo].[camarotes]  WITH CHECK ADD  CONSTRAINT [FK_camarotes_tipo_camarote] FOREIGN KEY([FK_tipo])
REFERENCES [dbo].[tipo_camarote] ([tipo])
GO
ALTER TABLE [dbo].[camarotes] CHECK CONSTRAINT [FK_camarotes_tipo_camarote]
GO
ALTER TABLE [dbo].[cubiertas]  WITH CHECK ADD  CONSTRAINT [FK_cubiertas_tripulaciones] FOREIGN KEY([legajo_encargado])
REFERENCES [dbo].[tripulaciones] ([legajo])
GO
ALTER TABLE [dbo].[cubiertas] CHECK CONSTRAINT [FK_cubiertas_tripulaciones]
GO
ALTER TABLE [dbo].[navios]  WITH CHECK ADD  CONSTRAINT [FK_navios_clasificacion_navio] FOREIGN KEY([tipo_clasificacion])
REFERENCES [dbo].[clasificacion_navio] ([cod_clasificacion])
GO
ALTER TABLE [dbo].[navios] CHECK CONSTRAINT [FK_navios_clasificacion_navio]
GO
ALTER TABLE [dbo].[pasaje_camarote]  WITH CHECK ADD  CONSTRAINT [FK_pasaje_camarote_cubiertas] FOREIGN KEY([FK_numero_cubierta])
REFERENCES [dbo].[cubiertas] ([numero_cubierta])
GO
ALTER TABLE [dbo].[pasaje_camarote] CHECK CONSTRAINT [FK_pasaje_camarote_cubiertas]
GO
ALTER TABLE [dbo].[pasaje_camarote]  WITH CHECK ADD  CONSTRAINT [FK_pasaje_camarote_navios] FOREIGN KEY([FK_cod_navio])
REFERENCES [dbo].[navios] ([cod_navio])
GO
ALTER TABLE [dbo].[pasaje_camarote] CHECK CONSTRAINT [FK_pasaje_camarote_navios]
GO
ALTER TABLE [dbo].[pasaje_camarote]  WITH CHECK ADD  CONSTRAINT [FK_pasaje_camarote_pasajeros] FOREIGN KEY([FK_numero_documento])
REFERENCES [dbo].[pasajeros] ([numero_documento])
GO
ALTER TABLE [dbo].[pasaje_camarote] CHECK CONSTRAINT [FK_pasaje_camarote_pasajeros]
GO
ALTER TABLE [dbo].[puerto_itinerario]  WITH CHECK ADD  CONSTRAINT [FK_puerto_itinerario_itinerarios] FOREIGN KEY([FK_cod_itinerario])
REFERENCES [dbo].[itinerarios] ([cod_intinerarios])
GO
ALTER TABLE [dbo].[puerto_itinerario] CHECK CONSTRAINT [FK_puerto_itinerario_itinerarios]
GO
ALTER TABLE [dbo].[puerto_itinerario]  WITH CHECK ADD  CONSTRAINT [FK_puerto_itinerario_itinerarios1] FOREIGN KEY([FK_cod_itinerario])
REFERENCES [dbo].[itinerarios] ([cod_intinerarios])
GO
ALTER TABLE [dbo].[puerto_itinerario] CHECK CONSTRAINT [FK_puerto_itinerario_itinerarios1]
GO
ALTER TABLE [dbo].[puerto_itinerario]  WITH CHECK ADD  CONSTRAINT [FK_puerto_itinerario_puertos] FOREIGN KEY([FK_cod_puerto])
REFERENCES [dbo].[puertos] ([cod_puerto])
GO
ALTER TABLE [dbo].[puerto_itinerario] CHECK CONSTRAINT [FK_puerto_itinerario_puertos]
GO
ALTER TABLE [dbo].[tripulante_x_viaje]  WITH CHECK ADD  CONSTRAINT [FK_tripulante_x_viaje_navios] FOREIGN KEY([cod_navio])
REFERENCES [dbo].[navios] ([cod_navio])
GO
ALTER TABLE [dbo].[tripulante_x_viaje] CHECK CONSTRAINT [FK_tripulante_x_viaje_navios]
GO
ALTER TABLE [dbo].[tripulante_x_viaje]  WITH CHECK ADD  CONSTRAINT [FK_tripulante_x_viaje_tripulaciones] FOREIGN KEY([legajo])
REFERENCES [dbo].[tripulaciones] ([legajo])
GO
ALTER TABLE [dbo].[tripulante_x_viaje] CHECK CONSTRAINT [FK_tripulante_x_viaje_tripulaciones]
GO
ALTER TABLE [dbo].[tripulante_x_viaje]  WITH CHECK ADD  CONSTRAINT [FK_tripulante_x_viaje_viajes] FOREIGN KEY([fecha_viaje])
REFERENCES [dbo].[viajes] ([fecha_viaje])
GO
ALTER TABLE [dbo].[tripulante_x_viaje] CHECK CONSTRAINT [FK_tripulante_x_viaje_viajes]
GO
ALTER TABLE [dbo].[viajes]  WITH CHECK ADD  CONSTRAINT [FK_viajes_itinerarios] FOREIGN KEY([FK_cod_itinerario])
REFERENCES [dbo].[itinerarios] ([cod_intinerarios])
GO
ALTER TABLE [dbo].[viajes] CHECK CONSTRAINT [FK_viajes_itinerarios]
GO
ALTER TABLE [dbo].[viajes]  WITH CHECK ADD  CONSTRAINT [FK_viajes_navios] FOREIGN KEY([FK_cod_navio])
REFERENCES [dbo].[navios] ([cod_navio])
GO
ALTER TABLE [dbo].[viajes] CHECK CONSTRAINT [FK_viajes_navios]
GO
