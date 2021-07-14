Create Procedure Clientes_Insert
@Nome varchar(100),
@CPF varchar(14),
@IdTipoCliente int,
@Sexo varchar(1),
@IdSituacaoCliente int
AS
Insert into Clientes values (@Nome, @CPF, @IdTipoCliente, @Sexo, @IdSituacaoCliente)