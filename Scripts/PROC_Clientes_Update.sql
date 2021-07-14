Create Procedure Clientes_Update
@IdCliente int,
@Nome varchar(100),
@CPF varchar(14),
@IdTipoCliente int,
@Sexo varchar(1),
@IdSituacaoCliente int
AS
Update Clientes
set Nome = @Nome,
CPF = @CPF,
IdTipoCliente = @IdTipoCliente,
Sexo = @Sexo,
IdSituacaoCliente = @IdSituacaoCliente
where IdCliente = @IdCliente