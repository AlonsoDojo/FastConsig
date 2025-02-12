CREATE TABLE FastConsig.dbo.Configuracao (
  Chave varchar(250) NOT NULL,
  Conteudo varchar(max) NULL,
  CONSTRAINT PK_Configuracao PRIMARY KEY CLUSTERED (Chave)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.acess_token', '{"access_token":"283e4b00-5c81-31c2-b953-c7dc35ec6ca3","scope":"am_application_scope default","token_type":"Bearer","expires_in":3600,"Date":"2024-07-11T14:03:10.1840536-03:00"}')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.api.rootpath', '/e-consignado/')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.api.taxajuros', 'True')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.api.version', 'v7.0.0')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.auth.key', 'TmZySjA2RV9mb0VGR2xuVVdOUFREMkdzNEM4YTo4ZzNSdTdJdHg2el9sbjZJakNvblBUcDExdG9h')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.auth.url', 'https://hapi-bancos.dataprev.gov.br/')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.averbacao.validarautorizacao', 'False')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.certificado.codigosolicitante', '')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.certificado.password', '')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.certificado.url', '\Certificados\consignado_.pfx')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.demonstrativoinss.link', '')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.job.dataprevservice', '1')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.job.enviarinformacaocomplementar.ccb.path', 'E:\Web\FastConsig\')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.job.exclusao.dataprevservice', '2')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.job.informacaocomplementar.dataprevservice', '6')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.job.informacaocomplementar.path', 'E:\ConsignadoDataPrev')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.job.informacaocomplementar.tipodocumento.contrato', '6')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.job.refinanciamento.dataprevservice', '5')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.proposta.ocorrencia', '17')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.refinanciamento.validarautorizacao', 'False')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.dataprev.url', 'https://hapi-bancos.dataprev.gov.br')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.inss.produtos', '')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.serpro.job.siapeservice.anuencia', '4')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.serpro.job.siapeservice.averbacao', '3')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.serpro.job.siapeservice.refinanciamento', '8')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.serpro.job.siapeservice.renovacao', '8')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.siape.codigosolicitante', '')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.siape.notificacaoemaianuencia', '')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.siape.produtos', '')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.siape.senhaConsignado', '')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.siape.urlaceite', '')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'consignado.siape.urlrecusa', '')
INSERT FastConsig.dbo.Configuracao(Chave, Conteudo) VALUES (N'fastconsig.armazenamento', 'database')
GO