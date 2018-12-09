USE [master]
GO
/****** Object:  Database [CafeDB]    Script Date: 08/12/2018 22:06:39 ******/
CREATE DATABASE [CafeDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CafeDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\CafeDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CafeDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\CafeDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CafeDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CafeDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CafeDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CafeDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CafeDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CafeDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CafeDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CafeDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CafeDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CafeDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CafeDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CafeDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CafeDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CafeDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CafeDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CafeDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CafeDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CafeDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CafeDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CafeDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CafeDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CafeDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CafeDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CafeDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CafeDB] SET RECOVERY FULL 
GO
ALTER DATABASE [CafeDB] SET  MULTI_USER 
GO
ALTER DATABASE [CafeDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CafeDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CafeDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CafeDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CafeDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CafeDB', N'ON'
GO
ALTER DATABASE [CafeDB] SET QUERY_STORE = OFF
GO
USE [CafeDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [CafeDB]
GO
/****** Object:  Table [dbo].[DetalleNotaPeso]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleNotaPeso](
	[IdDetalleNotaPeso] [int] IDENTITY(1,1) NOT NULL,
	[IdNotaPeso] [int] NOT NULL,
	[Peso] [decimal](10, 2) NOT NULL,
	[Saco] [int] NOT NULL,
 CONSTRAINT [PK__DetalleF__DB5F46310D9C5D08] PRIMARY KEY CLUSTERED 
(
	[IdDetalleNotaPeso] ASC,
	[IdNotaPeso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lugar]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lugar](
	[IdLugar] [int] IDENTITY(1,1) NOT NULL,
	[Lugar] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdLugar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotaPeso]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotaPeso](
	[IdNotaPeso] [int] NOT NULL,
	[IdProductor] [nvarchar](5) NOT NULL,
	[IdTipoCafe] [int] NOT NULL,
	[IdLugar] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[PesoBruto] [float] NOT NULL,
	[Tara] [decimal](10, 2) NOT NULL,
	[Descuento] [decimal](10, 2) NOT NULL,
	[Humedad] [float] NOT NULL,
	[Observaciones] [nvarchar](100) NULL,
	[PrecioUnitario] [decimal](10, 2) NOT NULL,
	[Anulada] [bit] NULL,
 CONSTRAINT [PK__Factura__50E7BAF1CAD3504C] PRIMARY KEY CLUSTERED 
(
	[IdNotaPeso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productor]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productor](
	[IdProductor] [nvarchar](5) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Apellido] [varchar](20) NOT NULL,
	[IdSexo] [int] NOT NULL,
	[Socio] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProductor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductorXLugar]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductorXLugar](
	[IdProductor] [nvarchar](5) NOT NULL,
	[IdLugar] [int] NOT NULL,
 CONSTRAINT [pk_Productor_Lugar] PRIMARY KEY CLUSTERED 
(
	[IdProductor] ASC,
	[IdLugar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sexo]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sexo](
	[IdSexo] [int] IDENTITY(1,1) NOT NULL,
	[Sexo] [varchar](9) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoCafe]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoCafe](
	[IdTipoCafe] [int] IDENTITY(1,1) NOT NULL,
	[TipoCafe] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoCafe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](20) NOT NULL,
	[Contrasena] [varchar](500) NULL,
	[Estado] [bit] NULL,
	[Administrador] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[NotaPeso] ADD  CONSTRAINT [DF__Factura__Fecha__31EC6D26]  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[DetalleNotaPeso]  WITH CHECK ADD  CONSTRAINT [FK_DetalleNotaPeso_NotaPeso] FOREIGN KEY([IdNotaPeso])
REFERENCES [dbo].[NotaPeso] ([IdNotaPeso])
GO
ALTER TABLE [dbo].[DetalleNotaPeso] CHECK CONSTRAINT [FK_DetalleNotaPeso_NotaPeso]
GO
ALTER TABLE [dbo].[NotaPeso]  WITH CHECK ADD  CONSTRAINT [fk_Factura_Productor] FOREIGN KEY([IdProductor])
REFERENCES [dbo].[Productor] ([IdProductor])
GO
ALTER TABLE [dbo].[NotaPeso] CHECK CONSTRAINT [fk_Factura_Productor]
GO
ALTER TABLE [dbo].[NotaPeso]  WITH CHECK ADD  CONSTRAINT [fk_Factura_TipoCafe] FOREIGN KEY([IdTipoCafe])
REFERENCES [dbo].[TipoCafe] ([IdTipoCafe])
GO
ALTER TABLE [dbo].[NotaPeso] CHECK CONSTRAINT [fk_Factura_TipoCafe]
GO
ALTER TABLE [dbo].[NotaPeso]  WITH CHECK ADD  CONSTRAINT [fk_Factura_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[NotaPeso] CHECK CONSTRAINT [fk_Factura_Usuario]
GO
ALTER TABLE [dbo].[NotaPeso]  WITH CHECK ADD  CONSTRAINT [FK_NotaPeso_Lugar] FOREIGN KEY([IdLugar])
REFERENCES [dbo].[Lugar] ([IdLugar])
GO
ALTER TABLE [dbo].[NotaPeso] CHECK CONSTRAINT [FK_NotaPeso_Lugar]
GO
ALTER TABLE [dbo].[Productor]  WITH CHECK ADD  CONSTRAINT [fk_Productor_Sexo] FOREIGN KEY([IdSexo])
REFERENCES [dbo].[Sexo] ([IdSexo])
GO
ALTER TABLE [dbo].[Productor] CHECK CONSTRAINT [fk_Productor_Sexo]
GO
ALTER TABLE [dbo].[ProductorXLugar]  WITH CHECK ADD  CONSTRAINT [fk_ProductorXLugar_Lugar] FOREIGN KEY([IdLugar])
REFERENCES [dbo].[Lugar] ([IdLugar])
GO
ALTER TABLE [dbo].[ProductorXLugar] CHECK CONSTRAINT [fk_ProductorXLugar_Lugar]
GO
ALTER TABLE [dbo].[ProductorXLugar]  WITH CHECK ADD  CONSTRAINT [fk_ProductorXLugar_Productor] FOREIGN KEY([IdProductor])
REFERENCES [dbo].[Productor] ([IdProductor])
GO
ALTER TABLE [dbo].[ProductorXLugar] CHECK CONSTRAINT [fk_ProductorXLugar_Productor]
GO
/****** Object:  StoredProcedure [dbo].[Sp_Actualizar_Lugar]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Actualizar_Lugar]
	@IdLugar int,
	@Lugar varchar(15)
AS
	BEGIN
		SET NOCOUNT OFF
		UPDATE Lugar
		SET Lugar = @Lugar
		WHERE IdLugar = @IdLugar
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Actualizar_Productor]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREATE PROCEDURE Sp_Guardar_Productor
--	@IdProductor nvarchar(5),
--	@Nombre varchar(20),
--	@Apellido varchar(20),
--	@IdSexo int,
--	@Socio bit
--AS
--	BEGIN
--	  SET NOCOUNT OFF
--		INSERT INTO Productor
--		VALUES(@IdProductor, @Nombre, @Apellido,@IdSexo, @Socio)
--	END

--GO


--CREATE PROCEDURE [dbo].[Sp_Mostrar_Sexo]
--AS
--	BEGIN
--	  SET NOCOUNT ON
--		SELECT * 
--		FROM Sexo
--	END
--GO


--CREATE PROCEDURE [dbo].[Sp_Mostrar_Todo_Productor]
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT *
--		FROM Productor
--	END
--GO

--CREATE PROCEDURE [dbo].[Sp_Eliminar_Productor]
--	@IdProductor nvarchar(5)
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		DELETE
--		FROM Productor
--		WHERE IdProductor = @IdProductor
--	END

--GO

CREATE PROCEDURE [dbo].[Sp_Actualizar_Productor]
	@IdProductor nvarchar(5),
	@Nombre varchar(20),
	@Apellido varchar(20),
	@IdSexo int,
	@Socio bit
AS
	BEGIN
		SET NOCOUNT OFF
		UPDATE Productor 
		SET IdProductor = @IdProductor, 
			Nombre = @Nombre, 
			Apellido = @Apellido,  
			IdSexo = @IdSexo, 
			Socio = @Socio
		WHERE IdProductor = @IdProductor
	END

GO
/****** Object:  StoredProcedure [dbo].[Sp_Actualizar_Usuario]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Actualizar_Usuario]
	@IdUsuario int,
	@Usuario varchar(20),
	@Contrasena varchar(500),
	@Estado bit,
	@Administrador bit
AS
	BEGIN
		SET NOCOUNT OFF
		UPDATE Usuario
		SET Usuario = @Usuario, 
			Contrasena = @Contrasena,  
			Estado = @Estado,
			Administrador = @Administrador
		WHERE IdUsuario = @IdUsuario
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Eliminar_Lugar]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Eliminar_Lugar]
	@IdLugar int
AS
	BEGIN
		SET NOCOUNT OFF
		DELETE 
		FROM Lugar
		WHERE IdLugar = @IdLugar
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Eliminar_LugarXProductor]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Eliminar_LugarXProductor]
	@IdProductor nvarchar(5)
AS
	BEGIN
		SET NOCOUNT OFF
		DELETE 
		FROM ProductorXLugar
		WHERE IdProductor = @IdProductor
	END

GO
/****** Object:  StoredProcedure [dbo].[Sp_Eliminar_Productor]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Eliminar_Productor]
	@IdProductor nvarchar(5)
AS
	BEGIN
		SET NOCOUNT OFF
		DELETE
		FROM Productor
		WHERE IdProductor = @IdProductor
	END

GO
/****** Object:  StoredProcedure [dbo].[Sp_Guardar_DetalleNotaPeso]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Guardar_DetalleNotaPeso]
	@IdNotaPeso int,
	@Peso decimal(10,2),
	@Saco int
AS
	BEGIN
		SET NOCOUNT OFF
		INSERT INTO DetalleNotaPeso(IdNotaPeso,Peso,Saco)
		VALUES(@IdNotaPeso,@Peso,@Saco)
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Guardar_Lugar]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Guardar_Lugar]
	@Lugar varchar(100)
AS
	BEGIN
		SET NOCOUNT OFF
		INSERT INTO Lugar
		VALUES(@Lugar)
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Guardar_NotaPeso]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Guardar_NotaPeso]
	@IdNotaPeso int,
	@IdProductor nvarchar(5),
	@IdTipoCafe int,
	@IdLugar int,
	@IdUsuario int,
	@Fecha date,
	@PesoBruto float,
	@Tara decimal(10,2),
	@Descuento decimal(10,2),
	@Humedad float,
	@Observaciones nvarchar(100),
	@PrecioUnitario decimal(10,2),
	@Anulada bit
AS
	BEGIN
	  SET NOCOUNT OFF
		INSERT INTO NotaPeso
		VALUES(@IdNotaPeso ,@IdProductor ,@IdTipoCafe ,@IdLugar ,@IdUsuario ,@Fecha ,@PesoBruto,@Tara,@Descuento ,@Humedad ,@Observaciones ,@PrecioUnitario ,@Anulada)
	END

GO
/****** Object:  StoredProcedure [dbo].[Sp_Guardar_Productor]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Guardar_Productor]
	@IdProductor nvarchar(5),
	@Nombre varchar(20),
	@Apellido varchar(20),
	@IdSexo int,
	@Socio bit
AS
	BEGIN
	  SET NOCOUNT OFF
		INSERT INTO Productor
		VALUES(@IdProductor, @Nombre, @Apellido,@IdSexo, @Socio)
	END

GO
/****** Object:  StoredProcedure [dbo].[Sp_Guardar_ProductorXLugar]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Guardar_ProductorXLugar]
	@IdProductor nvarchar(5),
	@IdLugar int
AS
	BEGIN
		SET NOCOUNT OFF
		INSERT INTO ProductorXLugar
		VALUES(@IdProductor,@IdLugar)
	END

GO
/****** Object:  StoredProcedure [dbo].[Sp_Guardar_Usuario]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Guardar_Usuario]
	@Usuario varchar(20),
	@Contrasena varchar(500),
	@Estado bit,
	@Administrador bit
AS
	BEGIN
	  SET NOCOUNT OFF
		INSERT INTO Usuario(Usuario, Contrasena, Estado ,Administrador)
		VALUES(@Usuario, @Contrasena, @Estado,@Administrador)
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Mostrar_LugarXProductor]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Mostrar_LugarXProductor]
	@IdProductor nvarchar(5)
AS
	BEGIN
		SET NOCOUNT ON
		SELECT p.IdLugar, l.Lugar
		FROM ProductorXLugar p inner join Lugar l
		on p.IdLugar = l.IdLugar
		WHERE IdProductor = @IdProductor
	END

GO
/****** Object:  StoredProcedure [dbo].[Sp_Mostrar_Productor_Combobox]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Mostrar_Productor_Combobox]
AS
	BEGIN
		SET NOCOUNT ON
		SELECT IdProductor, CONCAT(Nombre, ' ', Apellido) AS NombreCompleto
		FROM Productor
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Mostrar_Sexo]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Mostrar_Sexo]
AS
	BEGIN
	  SET NOCOUNT ON
		SELECT * 
		FROM Sexo
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Mostrar_TipoCafe]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Mostrar_TipoCafe]
AS
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM TipoCafe
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Mostrar_Todo_Lugar]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Mostrar_Todo_Lugar]
AS
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM Lugar
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Mostrar_Todo_NotaPeso]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------------------	PROCEDIMIENTOS ALMACENADOS PRODUCTOR --------------------------

--CREATE PROCEDURE Sp_Guardar_Productor
--	@IdProductor nvarchar(5),
--	@Nombre varchar(20),
--	@Apellido varchar(20),
--	@IdSexo int,
--	@Socio bit
--AS
--	BEGIN
--	  SET NOCOUNT OFF
--		INSERT INTO Productor
--		VALUES(@IdProductor, @Nombre, @Apellido,@IdSexo, @Socio)
--	END

--GO

--CREATE PROCEDURE [dbo].[Sp_Guardar_ProductorXLugar]
--	@IdProductor nvarchar(5),
--	@IdLugar int
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		INSERT INTO ProductorXLugar
--		VALUES(@IdProductor,@IdLugar)
--	END
--GO

----execute Sp_Guardar_ProductorXLugar 'CC000', 1

--CREATE PROCEDURE [dbo].[Sp_Mostrar_Sexo]
--AS
--	BEGIN
--	  SET NOCOUNT ON
--		SELECT * 
--		FROM Sexo
--	END
--GO


--CREATE PROCEDURE [dbo].[Sp_Mostrar_Todo_Productor]
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT *
--		FROM Productor
--	END
--GO

--CREATE PROCEDURE [dbo].[Sp_Eliminar_Productor]
--	@IdProductor nvarchar(5)
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		DELETE
--		FROM Productor
--		WHERE IdProductor = @IdProductor
--	END

--GO

--CREATE PROCEDURE [dbo].[Sp_Actualizar_Productor]
--	@IdProductor nvarchar(5),
--	@Nombre varchar(20),
--	@Apellido varchar(20),
--	@IdSexo int,
--	@Socio bit
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		UPDATE Productor 
--		SET IdProductor = @IdProductor, 
--			Nombre = @Nombre, 
--			Apellido = @Apellido,  
--			IdSexo = @IdSexo, 
--			Socio = @Socio
--		WHERE IdProductor = @IdProductor
--	END

--GO

--CREATE PROCEDURE [dbo].[Sp_Mostrar_Un_Productor]
--	@IdProductor nvarchar(5)
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT *
--		FROM Productor
--		WHERE IdProductor = @IdProductor
--	END
--GO


--CREATE PROCEDURE [dbo].[Sp_Eliminar_LugarXProductor]
--	@IdProductor nvarchar(5)
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		DELETE 
--		FROM ProductorXLugar
--		WHERE IdProductor = @IdProductor
--	END
--GO



-----------------------	PROCEDIMIENTOS ALMACENADOS USUARIO --------------------------

--CREATE PROCEDURE [dbo].[Sp_Guardar_Usuario]
--	@Usuario varchar(20),
--	@Contrasena varchar(500),
--	@Estado bit,
--	@Administrador bit
--AS
--	BEGIN
--	  SET NOCOUNT OFF
--		INSERT INTO Usuario(Usuario, Contrasena, Estado ,Administrador)
--		VALUES(@Usuario, @Contrasena, @Estado,@Administrador)
--	END
--GO

--alter table Usuario alter column Contrasena varchar(500)


--CREATE PROCEDURE [dbo].[Sp_Mostrar_Todo_Usuario]
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT *
--		FROM Usuario 
--	END
--GO

--CREATE PROCEDURE [dbo].[Sp_Mostrar_UnUsuario]
--	@IdUsuario int
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT  *
--		FROM Usuario
--		WHERE IdUsuario = @IdUsuario
--	END
--GO


--CREATE PROCEDURE [dbo].[Sp_Actualizar_Usuario]
--	@IdUsuario int,
--	@Usuario varchar(20),
--	@Contrasena varchar(500),
--	@Estado bit,
--	@Administrador bit
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		UPDATE Usuario
--		SET Usuario = @Usuario, 
--			Contrasena = @Contrasena,  
--			Estado = @Estado,
--			Administrador = @Administrador
--		WHERE IdUsuario = @IdUsuario
--	END
--GO

--CREATE PROCEDURE [dbo].[Sp_Mostrar_LugarXProductor]
--	@IdProductor nvarchar(5)
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT p.IdLugar, l.Lugar
--		FROM ProductorXLugar p inner join Lugar l
--		on p.IdLugar = l.IdLugar
--		WHERE IdProductor = @IdProductor
--	END
--GO

----execute Sp_Mostrar_LugarXProductor 'CC007'



--------------------------------------------PROCEDIMIENTOS ALMACENADOS LUGAR -----------------------------
--CREATE PROCEDURE [dbo].[Sp_Guardar_Lugar]
--	@Lugar varchar(100)
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		INSERT INTO Lugar
--		VALUES(@Lugar)
--	END
--GO

--alter table Lugar alter column Lugar varchar(100)

--CREATE PROCEDURE [dbo].[Sp_Mostrar_Todo_Lugar]
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT *
--		FROM Lugar
--	END
--GO

--CREATE PROCEDURE [dbo].[Sp_Eliminar_Lugar]
--	@IdLugar int
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		DELETE 
--		FROM Lugar
--		WHERE IdLugar = @IdLugar
--	END
--GO

--CREATE PROCEDURE [dbo].[Sp_Mostrar_Un_Lugar]
--	@IdLugar int
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT *
--		FROM Lugar
--		WHERE IdLugar = @IdLugar
--	END
--GO

--CREATE PROCEDURE [dbo].[Sp_Actualizar_Lugar]
--	@IdLugar int,
--	@Lugar varchar(15)
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		UPDATE Lugar
--		SET Lugar = @Lugar
--		WHERE IdLugar = @IdLugar
--	END
--GO

--------------------------------------------PROCEDIMIENTOS ALMACENADOS NOTA PESO -----------------------------

--CREATE PROCEDURE [dbo].[Sp_Mostrar_TipoCafe]
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT *
--		FROM TipoCafe
--	END
--GO


--CREATE PROCEDURE [dbo].[Sp_Mostrar_Productor_Combobox]
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT IdProductor, CONCAT(Nombre, ' ', Apellido) AS NombreCompleto
--		FROM Productor
--	END
--GO
--execute Sp_Mostrar_Productor_Combobox


--CREATE PROCEDURE [dbo].[Sp_Guardar_NotaPeso]
--	@IdNotaPeso int,
--	@IdProductor nvarchar(5),
--	@IdTipoCafe int,
--	@IdLugar int,
--	@IdUsuario int,
--	@Fecha date,
--	@PesoBruto float,
--	@Tara decimal(10,2),
--	@Descuento decimal(10,2),
--	@Humedad float,
--	@Observaciones nvarchar(100),
--	@PrecioUnitario decimal(10,2),
--	@Anulada bit
--AS
--	BEGIN
--	  SET NOCOUNT OFF
--		INSERT INTO NotaPeso
--		VALUES(@IdNotaPeso ,@IdProductor ,@IdTipoCafe ,@IdLugar ,@IdUsuario ,@Fecha ,@PesoBruto,@Tara,@Descuento ,@Humedad ,@Observaciones ,@PrecioUnitario ,@Anulada)
--	END

--GO


--CREATE PROCEDURE [dbo].[Sp_Guardar_DetalleNotaPeso]
--	@IdNotaPeso int,
--	@Peso decimal(10,2),
--	@Saco int
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		INSERT INTO DetalleNotaPeso(IdNotaPeso,Peso,Saco)
--		VALUES(@IdNotaPeso,@Peso,@Saco)
--	END
--GO

CREATE PROCEDURE [dbo].[Sp_Mostrar_Todo_NotaPeso]
AS
	BEGIN
		SET NOCOUNT ON
		SELECT  np.IdNotaPeso,CONCAT(p.Nombre, ' ', p.Apellido) AS NombreCompleto,l.Lugar,tc.TipoCafe,u.Usuario AS PesadoPor,
				np.Fecha,SUM(dnp.Peso) AS TotalPeso,SUM(dnp.Saco) as TotalSaco,np.PesoBruto,np.Tara,np.Descuento,
				(np.PesoBruto - np.Tara - Descuento) AS PesoNeto,((np.PesoBruto - np.Tara - Descuento)/ 1.25) AS QuintalOro,
				np.Observaciones,np.PrecioUnitario,((np.PesoBruto - np.Tara - Descuento)* np.PrecioUnitario) AS Total 
		FROM NotaPeso np inner join DetalleNotaPeso dnp
							on np.IdNotaPeso = dnp.IdNotaPeso
							inner join Productor p
							on np.IdProductor = p.IdProductor
							inner join TipoCafe tc
							on np.IdTipoCafe = tc.IdTipoCafe
							inner join Lugar l
							on np.IdLugar = l.IdLugar
							inner join Usuario u
							on np.IdUsuario = u.IdUsuario
		WHERE np.Anulada = 0
		GROUP BY np.IdNotaPeso,p.Nombre,p.Apellido,l.Lugar,tc.TipoCafe,u.Usuario,np.Fecha,np.PesoBruto,np.Tara,np.Descuento,
				np.Observaciones,np.PrecioUnitario
							
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Mostrar_Todo_Productor]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREATE PROCEDURE Sp_Guardar_Productor
--	@IdProductor nvarchar(5),
--	@Nombre varchar(20),
--	@Apellido varchar(20),
--	@IdSexo int,
--	@Socio bit
--AS
--	BEGIN
--	  SET NOCOUNT OFF
--		INSERT INTO Productor
--		VALUES(@IdProductor, @Nombre, @Apellido,@IdSexo, @Socio)
--	END

--GO


--CREATE PROCEDURE [dbo].[Sp_Mostrar_Sexo]
--AS
--	BEGIN
--	  SET NOCOUNT ON
--		SELECT * 
--		FROM Sexo
--	END
--GO


CREATE PROCEDURE [dbo].[Sp_Mostrar_Todo_Productor]
AS
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM Productor
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Mostrar_Todo_Usuario]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------------------	PROCEDIMIENTOS ALMACENADOS PRODUCTOR --------------------------

--CREATE PROCEDURE Sp_Guardar_Productor
--	@IdProductor nvarchar(5),
--	@Nombre varchar(20),
--	@Apellido varchar(20),
--	@IdSexo int,
--	@Socio bit
--AS
--	BEGIN
--	  SET NOCOUNT OFF
--		INSERT INTO Productor
--		VALUES(@IdProductor, @Nombre, @Apellido,@IdSexo, @Socio)
--	END

--GO


--CREATE PROCEDURE [dbo].[Sp_Mostrar_Sexo]
--AS
--	BEGIN
--	  SET NOCOUNT ON
--		SELECT * 
--		FROM Sexo
--	END
--GO


--CREATE PROCEDURE [dbo].[Sp_Mostrar_Todo_Productor]
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT *
--		FROM Productor
--	END
--GO

--CREATE PROCEDURE [dbo].[Sp_Eliminar_Productor]
--	@IdProductor nvarchar(5)
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		DELETE
--		FROM Productor
--		WHERE IdProductor = @IdProductor
--	END

--GO

--CREATE PROCEDURE [dbo].[Sp_Actualizar_Productor]
--	@IdProductor nvarchar(5),
--	@Nombre varchar(20),
--	@Apellido varchar(20),
--	@IdSexo int,
--	@Socio bit
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		UPDATE Productor 
--		SET IdProductor = @IdProductor, 
--			Nombre = @Nombre, 
--			Apellido = @Apellido,  
--			IdSexo = @IdSexo, 
--			Socio = @Socio
--		WHERE IdProductor = @IdProductor
--	END

--GO

--CREATE PROCEDURE [dbo].[Sp_Mostrar_Un_Productor]
--	@IdProductor nvarchar(5)
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT *
--		FROM Productor
--		WHERE IdProductor = @IdProductor
--	END
--GO


-----------------------	PROCEDIMIENTOS ALMACENADOS USUARIO --------------------------

--CREATE PROCEDURE [dbo].[Sp_Guardar_Usuario]
--	@Usuario varchar(20),
--	@Contrasena varchar(500),
--	@Estado bit,
--	@Administrador bit
--AS
--	BEGIN
--	  SET NOCOUNT OFF
--		INSERT INTO Usuario(Usuario, Contrasena, Estado ,Administrador)
--		VALUES(@Usuario, @Contrasena, @Estado,@Administrador)
--	END
--GO

--alter table Usuario alter column Contrasena varchar(500)


CREATE PROCEDURE [dbo].[Sp_Mostrar_Todo_Usuario]
AS
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM Usuario 
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Mostrar_Un_Lugar]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Mostrar_Un_Lugar]
	@IdLugar int
AS
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM Lugar
		WHERE IdLugar = @IdLugar
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Mostrar_Un_Productor]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREATE PROCEDURE Sp_Guardar_Productor
--	@IdProductor nvarchar(5),
--	@Nombre varchar(20),
--	@Apellido varchar(20),
--	@IdSexo int,
--	@Socio bit
--AS
--	BEGIN
--	  SET NOCOUNT OFF
--		INSERT INTO Productor
--		VALUES(@IdProductor, @Nombre, @Apellido,@IdSexo, @Socio)
--	END

--GO


--CREATE PROCEDURE [dbo].[Sp_Mostrar_Sexo]
--AS
--	BEGIN
--	  SET NOCOUNT ON
--		SELECT * 
--		FROM Sexo
--	END
--GO


--CREATE PROCEDURE [dbo].[Sp_Mostrar_Todo_Productor]
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT *
--		FROM Productor
--	END
--GO

--CREATE PROCEDURE [dbo].[Sp_Eliminar_Productor]
--	@IdProductor nvarchar(5)
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		DELETE
--		FROM Productor
--		WHERE IdProductor = @IdProductor
--	END

--GO

--CREATE PROCEDURE [dbo].[Sp_Actualizar_Productor]
--	@IdProductor nvarchar(5),
--	@Nombre varchar(20),
--	@Apellido varchar(20),
--	@IdSexo int,
--	@Socio bit
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		UPDATE Productor 
--		SET IdProductor = @IdProductor, 
--			Nombre = @Nombre, 
--			Apellido = @Apellido,  
--			IdSexo = @IdSexo, 
--			Socio = @Socio
--		WHERE IdProductor = @IdProductor
--	END

--GO

CREATE PROCEDURE [dbo].[Sp_Mostrar_Un_Productor]
	@IdProductor nvarchar(5)
AS
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM Productor
		WHERE IdProductor = @IdProductor
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Mostrar_UnUsuario]    Script Date: 08/12/2018 22:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Mostrar_UnUsuario]
	@IdUsuario int
AS
	BEGIN
		SET NOCOUNT ON
		SELECT  *
		FROM Usuario
		WHERE IdUsuario = @IdUsuario
	END
GO
USE [master]
GO
ALTER DATABASE [CafeDB] SET  READ_WRITE 
GO
