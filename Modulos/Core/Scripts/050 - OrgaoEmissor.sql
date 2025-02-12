CREATE TABLE FastConsig.dbo.OrgaoEmissor (
  Id int IDENTITY,
  Descricao varchar(50) NULL,
  Abreviatura varchar(10) NULL,
  CodigoIntegracaoMatera varchar(10) NULL,
  CodigoIntegracaoSicred varchar(2) NULL,
  CodigoIntegracaoBMP varchar(2) NULL,
  CONSTRAINT PK_OrgaoEmissor_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.OrgaoEmissor ON
GO
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (1, 'OUTROS ', 'OUTROS', 'OUTROS', '00', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (2, 'SSP', 'SSP', 'SSP', '01', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (3, 'CONS REG ECONOMIA', 'CRE', 'CRE', '02', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (4, 'MIN EXERCITO ', 'MEXERC', 'MEXERC', '03', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (5, 'OAB ', 'OAB', 'OAB', '04', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (6, 'CREA ', 'CREA', 'CREA', '05', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (7, 'SJS ', 'SJS', 'SJS', '06', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (8, 'CTPS ', 'CTPS', 'CTPS', '07', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (9, 'CREME ', 'CREME', 'CREME', '08', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (10, 'MINEX ', 'MINEX', 'MINEX', '09', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (11, 'CRM ', 'CRM', 'CRM', '10', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (12, 'SJTC', 'SJTC', 'SJTC', '11', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (13, 'MAER', 'MAER', 'MAER', '12', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (14, 'DPF ', 'DPF', 'DPF', '13', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (15, 'RBF ', 'RBF', 'RBF', '14', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (16, 'IML ', 'IML', 'IML', '15', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (17, 'CPROF ', 'CPROF', 'CPROF', '16', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (18, 'CRO ', 'CRO', 'CRO', '17', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (19, 'CRC ', 'CRC', 'CRC', '18', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (20, 'DPMAF ', 'DPMAF', 'DPMAF', '19', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (21, 'ME', 'ME', 'ME', '20', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (22, 'BM', 'BM', 'BM', '21', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (23, 'AERON', 'AERON', 'AERON', '22', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (24, 'SJT', 'SJT', 'SJT', '23', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (25, 'COREN', 'COREN', 'COREN', '24', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (26, 'DETRAN', 'DETRAN', 'DETRAN', '25', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (27, 'EXERC', 'EXERC', 'EXERC', '26', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (28, 'SSI', 'SSI', 'SSI', '27', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (29, 'CNH', 'CNH', 'CNH', '28', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (30, 'MINISTERIODA MARINHA', 'MM', 'MM', '29', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (31, 'DEPARTAMENTO DE INDICAÇÃO CIVIL', 'DIC', 'DIC', '30', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (32, 'CONS REG ADMINISTRACAO', 'CRA', 'CRA', '31', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (33, 'CONS REG PSICOLOGIA', 'CRP', 'CRP', '32', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (34, 'POLICIA MILITAR', 'PM', 'PM', '33', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (35, 'POLICIA CIVIL', 'PC', 'PC', '34', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (36, 'SSO', 'SSO', 'SSO', '35', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (37, 'CGPI', 'CGPI', 'CGPI', '38', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (38, 'GRTE', 'GRTE', 'GRTE', '39', NULL)
INSERT FastConsig.dbo.OrgaoEmissor(Id, Descricao, Abreviatura, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (39, 'IGP', 'IGP', 'IGP', '40', NULL)
GO
SET IDENTITY_INSERT FastConsig.dbo.OrgaoEmissor OFF
GO