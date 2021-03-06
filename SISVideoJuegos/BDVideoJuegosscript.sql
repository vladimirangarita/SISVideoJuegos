USE [BDVideoJuegos]
GO
/****** Object:  StoredProcedure [dbo].[PABuscarCliente]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[PABuscarCliente]

@CedulaCliente nvarchar(9)
As

Begin
	Select 
		[IdCliente],
	    [CedulaCliente],
	    [Nombre],
	    [Apellido]
			From Cliente
			
			where CedulaCliente=@CedulaCliente
End
GO
/****** Object:  StoredProcedure [dbo].[PABuscarTipoVideoJuego]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[PABuscarTipoVideoJuego]

@DescripcionTipoVideoJuego nvarchar(150)
As

Begin
	Select 
		[IdTipoVideoJuego],
	    [DescripcionTipoVideoJuego],
	    [EstatusTipoVideoJuego]
			From TipoVideoJuego
			
			where DescripcionTipoVideoJuego=@DescripcionTipoVideoJuego
End
GO
/****** Object:  StoredProcedure [dbo].[PABuscarVideoJuego]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[PABuscarVideoJuego]

@DescripcionVideoJuego nvarchar(150)
As

Begin
	Select 
		[IdVideoJuego],
	    [DescripcionVideoJuego],
	    [IdTipoVideoJuego]
			From VideoJuegos
			
			where DescripcionVideoJuego=@DescripcionVideoJuego
End
GO
/****** Object:  StoredProcedure [dbo].[PAFiltrarClienteVideoJuegos]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[PAFiltrarClienteVideoJuegos]

@CedulaCliente nvarchar(9)
As

Begin
SELECT DISTINCT 
                      ClienteVideoJuegos_1.IdVideoJuego, dbo.Cliente.IdCliente, dbo.Cliente.CedulaCliente, dbo.Cliente.Nombre, dbo.Cliente.Apellido, 
                      VideoJuegos_1.DescripcionVideoJuego, TipoVideoJuego_1.DescripcionTipoVideoJuego, COUNT(ClienteVideoJuegos_1.IdVideoJuego) AS NAlquiladas, 
                      MAX(ClienteVideoJuegos_1.FechaAlquiler) AS UltimoAlquiler
FROM         dbo.Cliente INNER JOIN
                      dbo.ClienteVideoJuegos AS ClienteVideoJuegos_1 ON dbo.Cliente.IdCliente = ClienteVideoJuegos_1.IdCliente INNER JOIN
                      dbo.VideoJuegos AS VideoJuegos_1 ON ClienteVideoJuegos_1.IdVideoJuego = VideoJuegos_1.IdVideoJuego INNER JOIN
                      dbo.TipoVideoJuego AS TipoVideoJuego_1 ON VideoJuegos_1.IdTipoVideoJuego = TipoVideoJuego_1.IdTipoVideoJuego
GROUP BY dbo.Cliente.IdCliente, dbo.Cliente.Nombre, dbo.Cliente.Apellido, VideoJuegos_1.DescripcionVideoJuego, TipoVideoJuego_1.DescripcionTipoVideoJuego, 
                      ClienteVideoJuegos_1.IdVideoJuego, dbo.Cliente.CedulaCliente
HAVING      (Cliente.CedulaCliente = @CedulaCliente)
			
			
End
GO
/****** Object:  StoredProcedure [dbo].[PAInsertarCliente]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[PAInsertarCliente]
	@CedulaCliente nvarchar(9),
	@Nombre nvarchar(50),
	@Apellido nvarchar(50)
As
Begin
	Insert Into Cliente
		([CedulaCliente],[Nombre],[Apellido])
	Values
		(@CedulaCliente,@Nombre,@Apellido)

		

End
GO
/****** Object:  StoredProcedure [dbo].[PAInsertarClienteVideoJuego]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[PAInsertarClienteVideoJuego]
	@IdCliente int,
	@IdVideoJuego int,
	@FechaAlquiler Datetime
As
Begin
	Insert Into ClienteVideoJuegos
		([IdCliente],[IdVideoJuego],[FechaAlquiler])
	Values
		(@IdCliente,@IdVideoJuego,@FechaAlquiler)

		

End
GO
/****** Object:  StoredProcedure [dbo].[PAInsertarTipoVideoJuego]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[PAInsertarTipoVideoJuego]
	@DescripcionTipoVideoJuego nvarchar(50),
	@EstatusTipoVideoJuego bit
As
Begin
	Insert Into TipoVideoJuego
		([DescripcionTipoVideoJuego],[EstatusTipoVideoJuego])
	Values
		(@DescripcionTipoVideoJuego,@EstatusTipoVideoJuego)

		

End
GO
/****** Object:  StoredProcedure [dbo].[PAInsertarVideoJuegos]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[PAInsertarVideoJuegos]
	@DescripcionVideoJuego nvarchar(150),
	@IdTipoVideoJuego int
As
Begin
	Insert Into VideoJuegos
		([DescripcionVideoJuego],[IdTipoVideoJuego])
	Values
		(@DescripcionVideoJuego,@IdTipoVideoJuego)

		

End
GO
/****** Object:  StoredProcedure [dbo].[PAModificarCliente]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[PAModificarCliente]
	@CedulaCliente nvarchar(9),
	@Nombre nvarchar(50),
	@Apellido nvarchar(50)
As
Begin
Update Cliente set  CedulaCliente=@CedulaCliente,Nombre=@Nombre,Apellido=@Apellido  where CedulaCliente=@CedulaCliente

End
GO
/****** Object:  StoredProcedure [dbo].[PAModificarTipoVideoJuegos]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[PAModificarTipoVideoJuegos]
	@IdTipoVideoJuego int,
	@DescripcionTipoVideoJuego nvarchar(10),
	@EstatusTipoVideoJuego bit
As
Begin
	Update TipoVideoJuego set  DescripcionTipoVideoJuego=@DescripcionTipoVideoJuego,EstatusTipoVideoJuego=@EstatusTipoVideoJuego  where IdTipoVideoJuego=@IdTipoVideoJuego

End
GO
/****** Object:  StoredProcedure [dbo].[PAModificarVideoJuegos]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[PAModificarVideoJuegos]
	@IdVideoJuego int,
	@DescripcionVideoJuego nvarchar(100),
	@IdTipoVideoJuego int
As
Begin
	Update VideoJuegos set  DescripcionVideoJuego=@DescripcionVideoJuego,IdTipoVideoJuego=@IdTipoVideoJuego  where IdVideoJuego=@IdVideoJuego

End
GO
/****** Object:  StoredProcedure [dbo].[PAMostrarClientes]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[PAMostrarClientes]
As
Begin
	

SELECT     IdCliente, CedulaCliente, Nombre, Apellido
FROM         Cliente
End
GO
/****** Object:  StoredProcedure [dbo].[PAMostrarClienteVideoJuegos]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[PAMostrarClienteVideoJuegos]

As

Begin
SELECT DISTINCT 
                      ClienteVideoJuegos_1.IdVideoJuego, dbo.Cliente.IdCliente, dbo.Cliente.CedulaCliente, dbo.Cliente.Nombre, dbo.Cliente.Apellido, 
                      VideoJuegos_1.DescripcionVideoJuego, TipoVideoJuego_1.DescripcionTipoVideoJuego, COUNT(ClienteVideoJuegos_1.IdVideoJuego) AS NAlquiladas, 
                      MAX(ClienteVideoJuegos_1.FechaAlquiler) AS UltimoAlquiler
FROM         dbo.Cliente INNER JOIN
                      dbo.ClienteVideoJuegos AS ClienteVideoJuegos_1 ON dbo.Cliente.IdCliente = ClienteVideoJuegos_1.IdCliente INNER JOIN
                      dbo.VideoJuegos AS VideoJuegos_1 ON ClienteVideoJuegos_1.IdVideoJuego = VideoJuegos_1.IdVideoJuego INNER JOIN
                      dbo.TipoVideoJuego AS TipoVideoJuego_1 ON VideoJuegos_1.IdTipoVideoJuego = TipoVideoJuego_1.IdTipoVideoJuego
GROUP BY dbo.Cliente.IdCliente, dbo.Cliente.Nombre, dbo.Cliente.Apellido, VideoJuegos_1.DescripcionVideoJuego, TipoVideoJuego_1.DescripcionTipoVideoJuego, 
                      ClienteVideoJuegos_1.IdVideoJuego, dbo.Cliente.CedulaCliente
			
			
End
GO
/****** Object:  StoredProcedure [dbo].[PAMostrarTipoVideJuegos]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[PAMostrarTipoVideJuegos]
As
Begin
	Select 
		[IdTipoVideoJuego],
	    [DescripcionTipoVideoJuego],
	    [EstatusTipoVideoJuego]
			From TipoVideoJuego
			
End
GO
/****** Object:  StoredProcedure [dbo].[PAMostrarTipoVideJuegosActivos]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[PAMostrarTipoVideJuegosActivos]
As
Begin
	Select 
		[IdTipoVideoJuego],
	    [DescripcionTipoVideoJuego],
	    [EstatusTipoVideoJuego]
			From TipoVideoJuego
			where EstatusTipoVideoJuego=1
			
End
GO
/****** Object:  StoredProcedure [dbo].[PAMostrarVideoJuegos]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[PAMostrarVideoJuegos]
As
Begin
	

SELECT     VideoJuegos.IdVideoJuego, VideoJuegos.DescripcionVideoJuego, TipoVideoJuego.DescripcionTipoVideoJuego
FROM         VideoJuegos INNER JOIN
                      TipoVideoJuego ON VideoJuegos.IdTipoVideoJuego = TipoVideoJuego.IdTipoVideoJuego
End
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[CedulaCliente] [nvarchar](9) NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ClienteVideoJuegos]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClienteVideoJuegos](
	[IdClienteVideoJuego] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NULL,
	[IdVideoJuego] [int] NULL,
	[FechaAlquiler] [datetime] NULL,
 CONSTRAINT [PK_ClienteVideoJuegos] PRIMARY KEY CLUSTERED 
(
	[IdClienteVideoJuego] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoVideoJuego]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoVideoJuego](
	[IdTipoVideoJuego] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionTipoVideoJuego] [nvarchar](50) NULL,
	[EstatusTipoVideoJuego] [bit] NULL,
 CONSTRAINT [PK_TipoVideoJuego] PRIMARY KEY CLUSTERED 
(
	[IdTipoVideoJuego] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VideoJuegos]    Script Date: 01/09/2019 12:10:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VideoJuegos](
	[IdVideoJuego] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionVideoJuego] [nvarchar](150) NULL,
	[IdTipoVideoJuego] [int] NULL,
 CONSTRAINT [PK_VideoJuegos] PRIMARY KEY CLUSTERED 
(
	[IdVideoJuego] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ClienteVideoJuegos]  WITH CHECK ADD  CONSTRAINT [FK_ClienteVideoJuegos_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[ClienteVideoJuegos] CHECK CONSTRAINT [FK_ClienteVideoJuegos_Cliente]
GO
ALTER TABLE [dbo].[ClienteVideoJuegos]  WITH CHECK ADD  CONSTRAINT [FK_ClienteVideoJuegos_VideoJuegos] FOREIGN KEY([IdVideoJuego])
REFERENCES [dbo].[VideoJuegos] ([IdVideoJuego])
GO
ALTER TABLE [dbo].[ClienteVideoJuegos] CHECK CONSTRAINT [FK_ClienteVideoJuegos_VideoJuegos]
GO
ALTER TABLE [dbo].[VideoJuegos]  WITH CHECK ADD  CONSTRAINT [FK_VideoJuegos_TipoVideoJuego] FOREIGN KEY([IdTipoVideoJuego])
REFERENCES [dbo].[TipoVideoJuego] ([IdTipoVideoJuego])
GO
ALTER TABLE [dbo].[VideoJuegos] CHECK CONSTRAINT [FK_VideoJuegos_TipoVideoJuego]
GO
