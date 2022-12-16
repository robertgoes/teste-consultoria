CREATE TABLE Pessoas(
	Cod_Pessoa int primary key identity,
	Nome varchar(8000)not null, 
	Setor char(2)not null
)

CREATE TABLE Rubricas(
	Cod_Rubrica int primary key identity,
	Nome varchar(8000) not null,
	Classificacao char(1) not null
)

CREATE TABLE Eventos(
	Cod_Evento int primary key identity,
	Cod_Pessoa int foreign key references Pessoas not null,
	Cod_Rubrica int foreign key references Rubricas not null,
	Data datetime not null,
	Tipo char(1) not null,
	Valor decimal(19,2) not null
)

INSERT INTO Pessoas (Nome, Setor) VALUES ('DARLENE', 'CC')
INSERT INTO Pessoas (Nome, Setor) VALUES ('MARCUS', 'TI')
INSERT INTO Pessoas (Nome, Setor) VALUES ('JOSI', 'CC')
INSERT INTO Pessoas (Nome, Setor) VALUES ('CATIA', 'CC')
INSERT INTO Pessoas (Nome, Setor) VALUES ('RAFAEL', 'TI')
INSERT INTO Pessoas (Nome, Setor) VALUES ('ROBERTO', 'CC')

INSERT INTO Rubricas (Nome, Classificacao) VALUES ('SALARIO', 'F')
INSERT INTO Rubricas (Nome, Classificacao) VALUES ('VT', 'B')
INSERT INTO Rubricas (Nome, Classificacao) VALUES ('VR', 'B')
INSERT INTO Rubricas (Nome, Classificacao) VALUES ('ATRASOS', 'F')
INSERT INTO Rubricas (Nome, Classificacao) VALUES ('FALTAS', 'F')
INSERT INTO Rubricas (Nome, Classificacao) VALUES ('IRRF', 'F')
INSERT INTO Rubricas (Nome, Classificacao) VALUES ('INSS', 'F')

INSERT INTO Eventos (Cod_Pessoa, Cod_Rubrica, Data, Tipo, Valor) VALUES (1, 1, GETDATE(), 'P', 3000)
INSERT INTO Eventos (Cod_Pessoa, Cod_Rubrica, Data, Tipo, Valor) VALUES (2, 2, GETDATE(), 'P', 300)
INSERT INTO Eventos (Cod_Pessoa, Cod_Rubrica, Data, Tipo, Valor) VALUES (3, 3, GETDATE(), 'P', 300)
INSERT INTO Eventos (Cod_Pessoa, Cod_Rubrica, Data, Tipo, Valor) VALUES (4, 4, GETDATE(), 'D', 90)
INSERT INTO Eventos (Cod_Pessoa, Cod_Rubrica, Data, Tipo, Valor) VALUES (5, 5, GETDATE(), 'D', 90)
INSERT INTO Eventos (Cod_Pessoa, Cod_Rubrica, Data, Tipo, Valor) VALUES (6, 6, GETDATE(), 'D', 300)
INSERT INTO Eventos (Cod_Pessoa, Cod_Rubrica, Data, Tipo, Valor) VALUES (1, 7, GETDATE(), 'D', 300)

SELECT * FROM Eventos
WHERE Cod_Pessoa = 4;

SELECT Cod_Rubrica, Nome FROM Rubricas
WHERE Classificacao = 'F' AND Nome <> 'IRRF' AND Nome <> 'INSS';

SELECT * FROM Eventos
WHERE Cod_Pessoa = '2' OR Cod_Pessoa = '4' OR Cod_Pessoa = '5'

SELECT SUM(Valor) 'soma total dos proventos' FROM Eventos
WHERE Tipo = 'P'