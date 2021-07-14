Create Procedure Clientes_Delete
@IdCliente int
AS
Delete from Clientes where IdCliente = @IdCliente