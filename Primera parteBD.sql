CREATE DATABASE ProyectoAyN
use ProyectoAyN

CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[dni] [nvarchar](8) NOT NULL,
	[telefono] [nvarchar](9) NOT NULL,
	[fecRegCliente] [date] NULL,
	[estCliente] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Empleado](
	[idEmpleado] [int] NOT NULL,
	[nombreEmpleado] [nvarchar](50) NOT NULL,
	[dni] [nvarchar](8) NOT NULL,
	[tipoEmpleado] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


--drop table Empleado

CREATE TABLE [dbo].[producto](
	[idProducto] [int] NOT NULL,
	[nombreProducto] [varchar](40) NOT NULL,
	[idtipoProducto] [int] NOT NULL,
	[descripcion] [varchar](140) NULL,
	[costoProducto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[Pagos](
	[idComprobantePagos] [int] NOT NULL,
	[MontoPago] [int] NOT NULL,
	[fechaPago] [datetime] NOT NULL,
	[idEmpleado] [int] NOT NULL,
	[idTipoPago] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idComprobantePagos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[tipoProducto](
	[idtipoProducto] [int] NOT NULL,
	[nombreTipoProducto] [varchar](20) NOT NULL,
	[descripcionTipoProducto] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[idtipoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[TipoPago](
	[idTipoPago] [int] NOT NULL,
	[NombreTP] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idTipoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[Venta](
	[idVenta] [int] NOT NULL,
	[idComprobante] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[Monto] [int] NOT NULL,
	[fecha_hora] [datetime] NOT NULL,
	[idCliente] [int] NOT NULL,
	[idTipoPago] [int] NOT NULL,
	[idEmpleado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_tipoProducto] FOREIGN KEY([idtipoProducto])
REFERENCES [dbo].[tipoProducto] ([idtipoProducto])
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_tipoProducto]


ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD  CONSTRAINT [FK_Pagos_Empleado] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
ALTER TABLE [dbo].[Pagos] CHECK CONSTRAINT [FK_Pagos_Empleado]


ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD  CONSTRAINT [FK_Pagos_TipoPago] FOREIGN KEY([idTipoPago])
REFERENCES [dbo].[TipoPago] ([idTipoPago])
ALTER TABLE [dbo].[Pagos] CHECK CONSTRAINT [FK_Pagos_TipoPago]

--

ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente]
--

ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Empleado] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Empleado]


ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Producto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Producto]


ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_TipoPago] FOREIGN KEY([idTipoPago])
REFERENCES [dbo].[TipoPago] ([idTipoPago])
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_TipoPago]

GO

CREATE PROCEDURE [dbo].[splistaCliente]
AS
BEGIN
	SELECT idCliente, Nombre, dni, telefono, fecRegCliente, estCliente 
	from Cliente
             where estCliente='1'
END
GO

CREATE PROCEDURE [dbo].[spinsertaCliente]
(@Nombre nvarchar(50),
@dni nvarchar(8),
@telefono nvarchar(9),
@fecRegCliente date,
@estCliente bit
)
as
begin 

	insert into Cliente(Nombre,dni, telefono, fecRegCliente, estCliente) values
	(@Nombre, @dni,@telefono, @fecRegCliente, @estCliente)
end

go
create procedure [dbo].[splistarEmpleado]
AS SELECT idEmpleado, nombreEmpleado, dni, TipoEmpleado
from Empleado


go
create procedure [dbo].[spinsertarEmpleado]
(
@idEmpleado int,
@nombreEmpleado nvarchar(50),
@dni nvarchar(8),
@TipoEmpleado nvarchar(50)
)
as 
begin 
insert into Empleado(idEmpleado, nombreEmpleado, dni, TipoEmpleado) values(@idEmpleado,@nombreEmpleado, @dni, @TipoEmpleado)
end

go

create procedure [dbo].[speditarEmpleado]
(
@idEmpleado int,
@nombreEmpleado nvarchar(50),
@dni nvarchar(8),
@TipoEmpleado nvarchar(50)
)
as 
begin 
update Empleado set

nombreEmpleado=@nombreEmpleado,
dni=@dni,
TipoEmpleado=@TipoEmpleado
where idEmpleado=@idEmpleado	
end

go

create procedure [dbo].[speditarTipoPago](
@idTipoPago int,
  @NombreTP varchar(40)
)
AS
begin
update TipoPago set 
NombreTP=@NombreTP
where idTipoPago =@idTipoPago
end
GO


create procedure [dbo].[splistarTipoPago]
AS
	SELECT * from TipoPago 
GO

create procedure [dbo].[spinsertarTipoPago](
@idTipoPago int,
@NombreTP varchar(30) 
)
AS
insert into TipoPago(idTipoPago,NombreTP)
values(@idTipoPago,@NombreTP)
go

create procedure [dbo].[splistarPagos]
	AS
	SELECT * from Pagos
	
GO
	GO
create procedure [dbo].[spinsertarPago](
@idComprobantePagos int,
@MontoPago int,
@fechaPago datetime,
@idEmpleado int ,
@idTipoPago int
)
AS
insert into Pagos(idComprobantePagos,MontoPago,fechaPago,idEmpleado,idTipoPago)
values(@idComprobantePagos,@MontoPago,@fechaPago,@idEmpleado,@idTipoPago)
GO


create OR ALTER procedure [dbo].[speditarProducto](
  @idProducto int,
  @nombreProducto varchar(40),
  @idtipoProducto int,
  @descripcion varchar(140),
  @costoProducto int
)
AS
begin
update Producto set 

nombreProducto=@nombreProducto,
idtipoProducto=@idtipoProducto,
descripcion=@descripcion,
costoProducto=@costoProducto
 where idProducto=@idProducto
end

go

CREATE OR alter  procedure [dbo].[spinsertarProducto](
  @idProducto int,
  @nombreProducto varchar(40),
  @idtipoProducto int,
  @descripcion varchar(140),
  @costoProducto int
)
AS
begin
insert into Producto(idProducto,nombreProducto,idtipoProducto,descripcion,costoProducto) values(@idProducto,@nombreProducto,@idtipoProducto,@descripcion,@costoProducto)
end
go


create procedure [dbo].[splistarProducto]
AS
	SELECT * from Producto
	


go
create procedure [dbo].[splistarTipoProducto]
AS
	SELECT idTipoProducto, nombreTipoProducto, descripcionTipoProducto
	from tipoProducto

go


create procedure [dbo].[spinsertarTipoProducto](
@idtipoProducto int,
@nombreTipoProducto varchar(20),
@descripcionTipoProducto varchar(40)
)
AS
insert into tipoProducto(idtipoProducto, nombreTipoProducto, descripcionTipoProducto)
values(@idtipoProducto, @nombreTipoProducto, @descripcionTipoProducto)

go


create procedure [dbo].[speditarTipoProducto](
 @idtipoProducto int,
@nombreTipoProducto varchar(20),
@descripcionTipoProducto varchar(40) null
)
AS
begin
update tipoProducto set 

nombreTipoProducto=@nombreTipoProducto,
descripcionTipoProducto=@descripcionTipoProducto
 where idtipoProducto =@idtipoProducto

end

go



Create procedure [dbo].[splistarVenta]
As
Select*from Venta

go

Create procedure [dbo].[spinsertarVenta]
(
@idVenta int,
@idComprobante int,
@idProducto int,
@Monto int,
@fecha_hora datetime ,
@idCliente int ,
@idTipoPago int,
@idEmpleado int
)
As
Begin
Insert into Venta (idVenta, idComprobante,idProducto, Monto,fecha_hora,idCliente,idTipoPago, idEmpleado) 
values(@idVenta,@idComprobante, @idProducto,@Monto,@fecha_hora,@idCliente, @idTipoPago, @idEmpleado)
End

go



