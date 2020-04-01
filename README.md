# VerdeOliva
Este proyecto contempla ABMC, Transacciones, etc. contiene funciones tecnicas y funcional.
El proyecto de aplicacion de escritorio esta basado en C# con una base de datos de SQL SERVER

### Base de datos de ejemplo
```sql

USE [VerdeOliva]
GO
/****** Object:  Table [dbo].[DetallePedido]    Script Date: 01/04/2020 2:39:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetallePedido](
	[IdDetallePedido] [int] NULL,
	[Codigo] [int] NOT NULL,
	[Comida] [varchar](50) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[CostoUnitario] [int] NOT NULL,
	[CostoTotal] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 01/04/2020 2:39:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pedido](
	[IdPedido] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[Producto]    Script Date: 01/04/2020 2:39:45 PM ******/
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
ALTER TABLE [dbo].[DetallePedido]  WITH CHECK ADD  CONSTRAINT [FK_DetallePedido_Pedido] FOREIGN KEY([IdDetallePedido])
REFERENCES [dbo].[Pedido] ([IdPedido])
GO
ALTER TABLE [dbo].[DetallePedido] CHECK CONSTRAINT [FK_DetallePedido_Pedido]
GO


```
