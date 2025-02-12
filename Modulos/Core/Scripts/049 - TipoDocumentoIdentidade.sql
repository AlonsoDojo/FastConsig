CREATE TABLE FastConsig.dbo.TipoDocumentoIdentidade (
  Id int IDENTITY,
  Descricao varchar(40) NOT NULL,
  Abreviatura varchar(10) NOT NULL,
  CodigoIntegracaoMatera varchar(5) NULL,
  CodigoIntegracaoSicred varchar(2) NULL,
  CodigoIntegracaoBMP varchar(5) NULL,
  Visivel bit null,
  CONSTRAINT PK_TipoDocumentoIdentidade_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.TipoDocumentoIdentidade ON
GO
INSERT FastConsig.dbo.TipoDocumentoIdentidade(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP, Visivel) VALUES (1, 'Cédula de Identidade RG ', 'RG', 'RG', '01', NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.TipoDocumentoIdentidade(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP, Visivel) VALUES (2, 'Cédula de Identidade das Forças Armadas', 'FORÇAS ARM', 'OUTRO', '02', NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.TipoDocumentoIdentidade(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP, Visivel) VALUES (3, 'Carteira da OAB ', 'OAB', 'OAB', '03', NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.TipoDocumentoIdentidade(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP, Visivel) VALUES (4, 'Cédula de Identidade da Polícia Militar', 'MILITAR', 'OUTRO', '04', NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.TipoDocumentoIdentidade(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP, Visivel) VALUES (5, 'Cédula de Identidade da Polícia', 'POL FEDERA', 'OUTRO', '05', NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.TipoDocumentoIdentidade(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP, Visivel) VALUES (6, 'Carteira CRC ', 'CRC', 'OUTRO', '07', NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.TipoDocumentoIdentidade(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP, Visivel) VALUES (7, 'Carteira CREA ', 'CREA', 'OUTRO', '08', NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.TipoDocumentoIdentidade(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP, Visivel) VALUES (8, 'Carteira do CRE ', 'CRE', 'OUTRO', '09', NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.TipoDocumentoIdentidade(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP, Visivel) VALUES (9, 'Carteira Nacional de Habilitação ', 'CNH', 'CNH', '10', NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.TipoDocumentoIdentidade(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP, Visivel) VALUES (10, 'Cartão de Identidade Minist da Marinha', 'MARINHA', 'OUTRO', '11', NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.TipoDocumentoIdentidade(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP, Visivel) VALUES (11, 'Carteira Profissional ', 'CTPS', 'CTPS', '12', NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.TipoDocumentoIdentidade(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP, Visivel) VALUES (12, 'Desp Depart Estadual De Segurança Publ', 'DESP', 'OUTRO', '13', NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.TipoDocumentoIdentidade(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP, Visivel) VALUES (13, 'Carteira de Identidade Profissional', 'CIP', 'OUTRO', '14', NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.TipoDocumentoIdentidade(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP, Visivel) VALUES (14, 'Certificado Militar ', 'CM', 'OUTRO', '15', NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.TipoDocumentoIdentidade(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP, Visivel) VALUES (15, 'Passaporte', 'PASSAPORTE', 'PAS', '16', NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.TipoDocumentoIdentidade(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP, Visivel) VALUES (16, 'Registro Nacional de Estrangeiros', 'RNE', 'OUTRO', '01', NULL, CONVERT(bit, 'True'))
GO
SET IDENTITY_INSERT FastConsig.dbo.TipoDocumentoIdentidade OFF
GO