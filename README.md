# VerdeOliva
Este software es utilizado en un local de Comida Rapida.

Este proyecto contempla ABMC, Transacciones, Reportes, Programacion en multiples capas, etc. Contiene funciones tecnicas y funcional.

Es de aplicacion de escritorio basado en WinForm C# con una base de datos de SQL SERVER

### Base de datos
```sql

USE [master]
GO
/****** Object:  Database [VerdeOliva]    Script Date: 09/08/2020 2:01:37 AM ******/
CREATE DATABASE [VerdeOliva]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VerdeOliva', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\VerdeOliva.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VerdeOliva_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\VerdeOliva_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [VerdeOliva] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VerdeOliva].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VerdeOliva] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VerdeOliva] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VerdeOliva] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VerdeOliva] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VerdeOliva] SET ARITHABORT OFF 
GO
ALTER DATABASE [VerdeOliva] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VerdeOliva] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VerdeOliva] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VerdeOliva] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VerdeOliva] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VerdeOliva] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VerdeOliva] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VerdeOliva] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VerdeOliva] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VerdeOliva] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VerdeOliva] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VerdeOliva] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VerdeOliva] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VerdeOliva] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VerdeOliva] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VerdeOliva] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VerdeOliva] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VerdeOliva] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VerdeOliva] SET  MULTI_USER 
GO
ALTER DATABASE [VerdeOliva] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VerdeOliva] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VerdeOliva] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VerdeOliva] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [VerdeOliva] SET DELAYED_DURABILITY = DISABLED 
GO
USE [VerdeOliva]
GO
/****** Object:  Table [dbo].[DetallePedido]    Script Date: 09/08/2020 2:01:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetallePedido](
	[IdPedido] [int] NOT NULL,
	[IdDetallePedido] [int] NOT NULL,
	[Comida] [varchar](50) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[CostoUnitario] [int] NOT NULL,
	[CostoTotal] [int] NOT NULL,
 CONSTRAINT [PK_DetallePedido_1] PRIMARY KEY CLUSTERED 
(
	[IdDetallePedido] ASC,
	[IdPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 09/08/2020 2:01:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pedido](
	[IdPedido] [int] NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[MontoTotal] [int] NOT NULL,
 CONSTRAINT [PK_DetallePedido] PRIMARY KEY CLUSTERED 
(
	[IdPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 09/08/2020 2:01:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[Codigo] [int] NOT NULL,
	[Comida] [varchar](50) NOT NULL,
	[CostoUnitario] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 09/08/2020 2:01:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[Nombre] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
	[Identificacion] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[DetallePedido]  WITH CHECK ADD  CONSTRAINT [FK_DetallePedido_Pedido] FOREIGN KEY([IdPedido])
REFERENCES [dbo].[Pedido] ([IdPedido])
GO
ALTER TABLE [dbo].[DetallePedido] CHECK CONSTRAINT [FK_DetallePedido_Pedido]
GO
/****** Object:  StoredProcedure [dbo].[InsertarDetallePedido]    Script Date: 09/08/2020 2:01:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarDetallePedido] 
	@IdDetallePedido int,
	@Comida varchar(50),
	@Cantidad int,
	@CostoUnitario int,
	@CostoTotal int

AS

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
    -- Insert statements for procedure here
INSERT INTO DetallePedido(IdDetallePedido,Comida,Cantidad,CostoUnitario,CostoTotal) VALUES (@IdDetallePedido,@Comida,@Cantidad,@CostoUnitario,@CostoTotal)
END


GO
/****** Object:  StoredProcedure [dbo].[InsertarPedido]    Script Date: 09/08/2020 2:01:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarPedido]
@IdPedido int, @FechaHora datetime, @Direccion varchar(50), @MontoTotal int


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Pedido (IdPedido,FechaHora,Direccion,MontoTotal) VALUES (@IdPedido,@FechaHora,@Direccion,@MontoTotal)
END


GO
/****** Object:  StoredProcedure [dbo].[ObtenerProducto]    Script Date: 09/08/2020 2:01:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerProducto]
@Codigo int


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Comida,CostoUnitario FROM Producto WHERE codigo=@Codigo
END


GO
USE [master]
GO
ALTER DATABASE [VerdeOliva] SET  READ_WRITE 
GO

```
