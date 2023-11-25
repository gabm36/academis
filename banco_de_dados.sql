-- Cria o banco de dados e o seleciona

CREATE DATABASE academis;
USE academis;

-- Cria as tabelas

CREATE TABLE tblPeriodos(
    perId INT NOT NULL PRIMARY KEY IDENTITY,
    perNome VARCHAR(50) NOT NULL,
    perSigla VARCHAR(5) NOT NULL UNIQUE,
);

CREATE TABLE tblCursos(
    curId INT NOT NULL PRIMARY KEY IDENTITY,
    curNome VARCHAR(50) NOT NULL,
    curSigla VARCHAR(5) NOT NULL UNIQUE, -- No diagrama de classe, esse campo conta como se pudesse ter 25 caracteres. Acredito que tenha sido um erro, então reduzi para 5.
    curObservacoes VARCHAR(500),
    perId INT NOT NULL,
	FOREIGN KEY (perId) REFERENCES tblPeriodos(perId)
);

CREATE TABLE tblDisciplinas(
    disId INT NOT NULL PRIMARY KEY IDENTITY,
    disNome VARCHAR(50) NOT NULL,
    disSigla VARCHAR(5) NOT NULL UNIQUE, -- Também reduzido para 5 caracteres.
    disObservacoes VARCHAR(500)
);

CREATE TABLE disciplinaCurso(
	curId INT NOT NULL,
	disId INT NOT NULL,
	FOREIGN KEY (curId) REFERENCES tblCursos(curId),
	FOREIGN KEY (disId) REFERENCES tblDisciplinas(disId)
);

CREATE TABLE tblUsuarios (
    usrId INT NOT NULL PRIMARY KEY IDENTITY,
	usrNome VARCHAR(50) NOT NULL,
	usrLogin VARCHAR(50) NOT NULL UNIQUE,
	usrSenha VARCHAR(32) NOT NULL
);

CREATE TABLE tblCategorias (
	catId INT NOT NULL PRIMARY KEY IDENTITY,
	catDescricao VARCHAR(50) NOT NULL
)

CREATE TABLE tblProdutos (
	prdId INT NOT NULL PRIMARY KEY IDENTITY,
	prdDescricao VARCHAR(50) NOT NULL,
	prdPrcCusto DECIMAL(10, 2) NOT NULL,
	prdPrcVenda DECIMAL(10, 2) NOT NULL,
	prdQuantidade INT NOT NULL,
	catId INT NOT NULL,
	FOREIGN KEY (catId) REFERENCES tblCategorias(catId)
)

-- Usuario admin para primeiro login

INSERT INTO tblUsuarios(usrNome, usrLogin, usrSenha) VALUES ('Gabriel', 'admin@admin','12345678');

-- Inserts de testes (como exercício)

INSERT INTO tblPeriodos(perNome, perSigla) VALUES ('periodo1', 'P1');
INSERT INTO tblPeriodos(perNome, perSigla) VALUES ('periodo2', 'P2');
INSERT INTO tblCursos(curNome, curSigla, curObservacoes, perId) VALUES ('Matemática', 'MT', DEFAULT, '1');
INSERT INTO tblCursos(curNome, curSigla, curObservacoes, perId) VALUES ('Informática', 'IF', DEFAULT, '2');
INSERT INTO tblCursos(curNome, curSigla, curObservacoes, perId) VALUES ('Finanças', 'FI', 'Sem professores', '2');