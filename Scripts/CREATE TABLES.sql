use FacilAssist

CREATE TABLE TipoCliente (
	IdTipoCliente INT PRIMARY KEY, 
	Descricao VARCHAR(200)
)

CREATE TABLE SituacaoCliente (
	IdSituacaoCliente INT PRIMARY KEY,
	Descricao VARCHAR(200)
)

CREATE TABLE Clientes (
	IdCliente INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(100),
	CPF VARCHAR(14) UNIQUE,
	IdTipoCliente INT FOREIGN KEY REFERENCES TipoCliente(IdTipoCliente),
	Sexo VARCHAR(1),
	IdSituacaoCliente INT FOREIGN KEY REFERENCES SituacaoCliente(IdSituacaoCliente)
)