-- Cria o banco de dados e o seleciona

CREATE DATABASE ACADEMIS;
USE ACADEMIS;

-- Cria as tabelas

CREATE TABLE tblPeriodos(
    perId INT NOT NULL IDENTITY, -- Trocar para AUTO_INCREMENT se for rodar fora do SQLServer (como no MySql, por exemplo)
    perNome VARCHAR(50) NOT NULL,
    perSigla VARCHAR(5) NOT NULL UNIQUE,
    PRIMARY KEY(perId) -- As chaves primárias foram colocadas no final por causa do AUTO_INCREMENT
);

CREATE TABLE tblCursos(
    curId INT NOT NULL IDENTITY,
    curNome VARCHAR(50) NOT NULL,
    curSigla VARCHAR(5) NOT NULL UNIQUE, -- No diagrama de classe, esse campo conta como se pudesse ter 25 caracteres. Acredito que tenha sido um erro, então reduzi para 5.
    curObservacoes VARCHAR(500),
    perId INT NOT NULL,
    PRIMARY KEY(curId)
);

CREATE TABLE disciplinaCurso(
	curId INT NOT NULL,
	disId INT NOT NULL
);

CREATE TABLE tblDisciplinas(
    disId INT NOT NULL IDENTITY,
    disNome VARCHAR(50) NOT NULL,
    disSigla VARCHAR(5) NOT NULL UNIQUE, -- Também reduzido para 5 caracteres.
    disObservacoes VARCHAR(500),
    PRIMARY KEY(disId)
);

CREATE TABLE tblUsuarios (
    usrId INT NOT NULL IDENTITY,
	usrNome VARCHAR(50) NOT NULL,
	usrLogin VARCHAR(50) NOT NULL UNIQUE,
	usrSenha VARCHAR(32) NOT NULL,
	PRIMARY KEY(usrId)
);

-- Chaves estrangeiras
-- Coloquei eles fora da criação de tabelas porque estavam gerando erros de acordo com a ordem de criação das tabelas

ALTER TABLE tblCursos ADD FOREIGN KEY (perId) REFERENCES tblPeriodos(perId);
ALTER TABLE disciplinaCurso ADD FOREIGN KEY (curId) REFERENCES tblCursos(curId);
ALTER TABLE disciplinaCurso ADD FOREIGN KEY (disId) REFERENCES tblDisciplinas(disId);

-- Usuario admin para primeiro login

INSERT INTO tblUsuarios(usrNome, usrLogin, usrSenha) VALUES ('Gabriel', 'admin@admin','12345678');

-- Inserts de testes (como exercício)

INSERT INTO tblPeriodos(perNome, perSigla) VALUES ('periodo1', 'P1');
INSERT INTO tblPeriodos(perNome, perSigla) VALUES ('periodo2', 'P2');
INSERT INTO tblCursos(curNome, curSigla, curObservacoes, perId) VALUES ('Matemática', 'MT', DEFAULT, '1');
INSERT INTO tblCursos(curNome, curSigla, curObservacoes, perId) VALUES ('Informática', 'IF', DEFAULT, '2');
INSERT INTO tblCursos(curNome, curSigla, curObservacoes, perId) VALUES ('Finanças', 'FI', 'Curso nota 1000', '2');

-- Teste com JOINs e CONCAT:

SELECT curId, curNome, curSigla, curObservacoes, CONCAT(perNome, ' (', perSigla,')') FROM tblCursos INNER JOIN tblPeriodos ON tblCursos.perId = tblPeriodos.perId;
SELECT * FROM tblCursos;
DELETE FROM disciplinaCurso WHERE curId = 2;
DELETE FROM tblCursos WHERE curId = 2;
SELECT tblPeriodos.perId, perNome, perSigla, CONCAT(curNome, ' (',curSigla, ')') as curNome FROM tblPeriodos INNER JOIN tblCursos ON tblPeriodos.perId = tblCursos.perId;