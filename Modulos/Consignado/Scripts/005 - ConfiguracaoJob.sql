CREATE TABLE FastConsig.dbo.ConfiguracaoJob (
  Id int IDENTITY,
  IdJob int NOT NULL,
  HorarioExecucao varchar(100) NULL,
  ParametrosExtras varchar(max) NULL,
  Dom bit NULL,
  Seg bit NULL,
  Ter bit NULL,
  Qua bit NULL,
  Qui bit NULL,
  Sex bit NULL,
  Sab bit NULL,
  Habilitado bit NULL,
  EmailAvisoConclusao varchar(max) NULL,
  EmailAvisoErro varchar(max) NULL,
  TentativasExecucao int NOT NULL CONSTRAINT DF_ConfiguracaoJob_TentativasExecucao DEFAULT (3),
  DelayExecucao int NULL,
  CONSTRAINT PK_ConfiguracaoJob PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.ConfiguracaoJob
  ADD CONSTRAINT FK_ConfiguracaoJob_Job FOREIGN KEY (IdJob) REFERENCES dbo.Job (Id)
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.ConfiguracaoJob ON
GO
EXEC(N'INSERT FastConsig.dbo.ConfiguracaoJob(Id, IdJob, HorarioExecucao, ParametrosExtras, Dom, Seg, Ter, Qua, Qui, Sex, Sab, Habilitado, EmailAvisoConclusao, EmailAvisoErro, TentativasExecucao, DelayExecucao) VALUES (23, 1, ''06:00-22:00'', ''{"Excecao":[{"Id":1658883535,"DataInicio":"2022-08-10T00:00:00","DataFim":"2022-08-14T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1663101866,"DataInicio":"2022-09-14T00:00:00","DataFim":"2022-09-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"\tProcessamento da Folha - DATAPREV"},{"Id":1663159990,"DataInicio":"2022-10-18T00:00:00","DataFim":"2022-10-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1663160041,"DataInicio":"2022-11-09T00:00:00","DataFim":"2022-11-13T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1663160067,"DataInicio":"2022-12-14T00:00:00","DataFim":"2022-12-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756901,"DataInicio":"2023-02-08T00:00:00","DataFim":"2023-02-12T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756918,"DataInicio":"2023-03-15T00:00:00","DataFim":"2023-03-19T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756940,"DataInicio":"2023-04-12T00:00:00","DataFim":"2023-04-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756959,"DataInicio":"2023-05-10T00:00:00","DataFim":"2023-05-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"06:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756978,"DataInicio":"2023-06-14T00:00:00","DataFim":"2023-06-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756993,"DataInicio":"2023-07-12T00:00:00","DataFim":"2023-07-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757018,"DataInicio":"2023-08-09T00:00:00","DataFim":"2023-08-13T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757040,"DataInicio":"2023-09-13T00:00:00","DataFim":"2023-09-17T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757062,"DataInicio":"2023-10-11T00:00:00","DataFim":"2023-10-15T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757088,"DataInicio":"2023-11-08T00:00:00","DataFim":"2023-11-12T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1673612379,"DataInicio":"2023-01-11T00:00:00","DataFim":"2023-01-17T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1701808395,"DataInicio":"2023-12-13T00:00:00","DataFim":"2023-12-17T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703597691,"DataInicio":"2024-02-08T00:00:00","DataFim":"2024-02-11T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703597729,"DataInicio":"2024-03-14T00:00:00","DataFim":"2024-03-17T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703597761,"DataInicio":"2024-04-11T00:00:00","DataFim":"2024-04-14T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703597786,"DataInicio":"2024-05-09T00:00:00","DataFim":"2024-05-12T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":'
+ N'1703597817,"DataInicio":"2024-06-13T00:00:00","DataFim":"2024-06-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703597854,"DataInicio":"2024-07-11T00:00:00","DataFim":"2024-07-14T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703597882,"DataInicio":"2024-08-15T00:00:00","DataFim":"2024-08-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703597910,"DataInicio":"2024-09-12T00:00:00","DataFim":"2024-09-15T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703597940,"DataInicio":"2024-10-10T00:00:00","DataFim":"2024-10-13T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703597965,"DataInicio":"2024-11-14T00:00:00","DataFim":"2024-11-17T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703597995,"DataInicio":"2024-12-12T00:00:00","DataFim":"2024-12-15T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1704455731,"DataInicio":"2024-01-17T00:00:00","DataFim":"2024-01-21T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"}],"ParametroExtra":"Comunicação com a DATAPREV","TaxaJuros":null}'', CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), ''saulo.pastor@bancopaulista.com.br,luiz.giro@bancopaulista.com.br; gestao.corban@bancopaulista.com.br'', ''saulo.pastor@bancopaulista.com.br,luiz.giro@bancopaulista.com.br'', 1, 60)')
EXEC(N'INSERT FastConsig.dbo.ConfiguracaoJob(Id, IdJob, HorarioExecucao, ParametrosExtras, Dom, Seg, Ter, Qua, Qui, Sex, Sab, Habilitado, EmailAvisoConclusao, EmailAvisoErro, TentativasExecucao, DelayExecucao) VALUES (30, 2, ''06:00-22:00'', ''{"Excecao":[{"Id":1658883535,"DataInicio":"2022-08-10T00:00:00","DataFim":"2022-08-14T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1663101866,"DataInicio":"2022-09-14T00:00:00","DataFim":"2022-09-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"\tProcessamento da Folha - DATAPREV"},{"Id":1663159990,"DataInicio":"2022-10-18T00:00:00","DataFim":"2022-10-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1663160041,"DataInicio":"2022-11-09T00:00:00","DataFim":"2022-11-13T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1663160067,"DataInicio":"2022-12-14T00:00:00","DataFim":"2022-12-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756901,"DataInicio":"2023-02-08T00:00:00","DataFim":"2023-02-12T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756918,"DataInicio":"2023-03-15T00:00:00","DataFim":"2023-03-19T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756940,"DataInicio":"2023-04-12T00:00:00","DataFim":"2023-04-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756959,"DataInicio":"2023-05-10T00:00:00","DataFim":"2023-05-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"06:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756978,"DataInicio":"2023-06-14T00:00:00","DataFim":"2023-06-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756993,"DataInicio":"2023-07-12T00:00:00","DataFim":"2023-07-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757018,"DataInicio":"2023-08-09T00:00:00","DataFim":"2023-08-13T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757040,"DataInicio":"2023-09-13T00:00:00","DataFim":"2023-09-17T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757062,"DataInicio":"2023-10-11T00:00:00","DataFim":"2023-10-15T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757088,"DataInicio":"2023-11-08T00:00:00","DataFim":"2023-11-12T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757112,"DataInicio":"2023-12-06T00:00:00","DataFim":"2023-12-10T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1673612379,"DataInicio":"2023-01-11T00:00:00","DataFim":"2023-01-17T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1704478069,"DataInicio":"2024-01-18T00:00:00","DataFim":"2024-01-21T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1704478115,"DataInicio":"2024-02-08T00:00:00","DataFim":"2024-02-11T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1704478161,"DataInicio":"2024-03-14T00:00:00","DataFim":"2024-03-17T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1704478205,"DataInicio":"2024-04-11T00:00:00","DataFim":"2024-04-14T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":'
+ N'1704478238,"DataInicio":"2024-05-09T00:00:00","DataFim":"2024-05-12T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1704478289,"DataInicio":"2024-06-13T00:00:00","DataFim":"2024-06-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1704478323,"DataInicio":"2024-07-11T00:00:00","DataFim":"2024-07-14T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1704478356,"DataInicio":"2024-08-15T00:00:00","DataFim":"2024-08-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1704478402,"DataInicio":"2024-09-12T00:00:00","DataFim":"2024-09-15T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1704478437,"DataInicio":"2024-10-10T00:00:00","DataFim":"2024-10-13T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1704478469,"DataInicio":"2024-11-14T00:00:00","DataFim":"2024-11-17T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1704478498,"DataInicio":"2024-12-12T00:00:00","DataFim":"2024-12-15T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"}],"ParametroExtra":"Comunicação com a DATAPREV","TaxaJuros":null}'', CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''False''), ''saulo.pastor@bancopaulista.com.br,luiz.giro@bancopaulista.com.br; gestao.corban@bancopaulista.com.br'', ''saulo.pastor@bancopaulista.com.br,luiz.giro@bancopaulista.com.br; gestao.corban@bancopaulista.com.br'', 1, 60)')
INSERT FastConsig.dbo.ConfiguracaoJob(Id, IdJob, HorarioExecucao, ParametrosExtras, Dom, Seg, Ter, Qua, Qui, Sex, Sab, Habilitado, EmailAvisoConclusao, EmailAvisoErro, TentativasExecucao, DelayExecucao) VALUES (31, 3, '07:00-23:59', '{
  "Excecao": null,
  "ParametroExtra": "Comunicação com a Serpro",
  "TaxaJuros": null
}', CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), 'saulo.pastor@bancopaulista.com.br,luiz.giro@bancopaulista.com.br; gestao.corban@bancopaulista.com.br', 'saulo.pastor@bancopaulista.com.br,luiz.giro@bancopaulista.com.br; gestao.corban@bancopaulista.com.br', 1, 60)
INSERT FastConsig.dbo.ConfiguracaoJob(Id, IdJob, HorarioExecucao, ParametrosExtras, Dom, Seg, Ter, Qua, Qui, Sex, Sab, Habilitado, EmailAvisoConclusao, EmailAvisoErro, TentativasExecucao, DelayExecucao) VALUES (32, 4, '07:00-23:59', '{"Excecao":null,"ParametroExtra":"Comunicação com a Serpro","TaxaJuros":null}', CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), 'saulo.pastor@bancopaulista.com.br,luiz.giro@bancopaulista.com.br,gestao.corban@bancopaulista.com.br', 'saulo.pastor@bancopaulista.com.br,luiz.giro@bancopaulista.com.br,gestao.corban@bancopaulista.com.br', 1, 30)
INSERT FastConsig.dbo.ConfiguracaoJob(Id, IdJob, HorarioExecucao, ParametrosExtras, Dom, Seg, Ter, Qua, Qui, Sex, Sab, Habilitado, EmailAvisoConclusao, EmailAvisoErro, TentativasExecucao, DelayExecucao) VALUES (33, 6, '09:00-23:59', '{"Excecao":[{"Id":1658883535,"DataInicio":"2022-08-10T00:00:00","DataFim":"2022-08-14T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1663101866,"DataInicio":"2022-09-14T00:00:00","DataFim":"2022-09-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"\tProcessamento da Folha - DATAPREV"},{"Id":1663159990,"DataInicio":"2022-10-18T00:00:00","DataFim":"2022-10-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1663160041,"DataInicio":"2022-11-09T00:00:00","DataFim":"2022-11-13T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1663160067,"DataInicio":"2022-12-14T00:00:00","DataFim":"2022-12-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756901,"DataInicio":"2023-02-08T00:00:00","DataFim":"2023-02-12T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756918,"DataInicio":"2023-03-15T00:00:00","DataFim":"2023-03-19T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756940,"DataInicio":"2023-04-12T00:00:00","DataFim":"2023-04-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756959,"DataInicio":"2023-05-10T00:00:00","DataFim":"2023-05-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"06:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756978,"DataInicio":"2023-06-14T00:00:00","DataFim":"2023-06-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756993,"DataInicio":"2023-07-12T00:00:00","DataFim":"2023-07-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757018,"DataInicio":"2023-08-09T00:00:00","DataFim":"2023-08-13T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757040,"DataInicio":"2023-09-13T00:00:00","DataFim":"2023-09-17T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757062,"DataInicio":"2023-10-11T00:00:00","DataFim":"2023-10-15T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757088,"DataInicio":"2023-11-08T00:00:00","DataFim":"2023-11-12T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757112,"DataInicio":"2023-12-06T00:00:00","DataFim":"2023-12-10T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1673612379,"DataInicio":"2023-01-11T00:00:00","DataFim":"2023-01-17T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"}],"ParametroExtra":"Comunicação com a DATAPREV","TaxaJuros":null}', CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), 'saulo.pastor@bancopaulista.com.br,luiz.giro@bancopaulista.com.br', 'saulo.pastor@bancopaulista.com.br,luiz.giro@bancopaulista.com.br', 1, 60)
EXEC(N'INSERT FastConsig.dbo.ConfiguracaoJob(Id, IdJob, HorarioExecucao, ParametrosExtras, Dom, Seg, Ter, Qua, Qui, Sex, Sab, Habilitado, EmailAvisoConclusao, EmailAvisoErro, TentativasExecucao, DelayExecucao) VALUES (34, 5, ''06:00-22:00'', ''{"Excecao":[{"Id":1658883535,"DataInicio":"2022-08-10T00:00:00","DataFim":"2022-08-14T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1663101866,"DataInicio":"2022-09-14T00:00:00","DataFim":"2022-09-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"\tProcessamento da Folha - DATAPREV"},{"Id":1663159990,"DataInicio":"2022-10-18T00:00:00","DataFim":"2022-10-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1663160041,"DataInicio":"2022-11-09T00:00:00","DataFim":"2022-11-13T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1663160067,"DataInicio":"2022-12-14T00:00:00","DataFim":"2022-12-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756901,"DataInicio":"2023-02-08T00:00:00","DataFim":"2023-02-12T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756918,"DataInicio":"2023-03-15T00:00:00","DataFim":"2023-03-19T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756940,"DataInicio":"2023-04-12T00:00:00","DataFim":"2023-04-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756959,"DataInicio":"2023-05-10T00:00:00","DataFim":"2023-05-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"06:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756978,"DataInicio":"2023-06-14T00:00:00","DataFim":"2023-06-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756993,"DataInicio":"2023-07-12T00:00:00","DataFim":"2023-07-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757018,"DataInicio":"2023-08-09T00:00:00","DataFim":"2023-08-13T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757040,"DataInicio":"2023-09-13T00:00:00","DataFim":"2023-09-17T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757062,"DataInicio":"2023-10-11T00:00:00","DataFim":"2023-10-15T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757088,"DataInicio":"2023-11-08T00:00:00","DataFim":"2023-11-12T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757112,"DataInicio":"2023-12-13T00:00:00","DataFim":"2023-12-17T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1673612379,"DataInicio":"2023-01-11T00:00:00","DataFim":"2023-01-17T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703617561,"DataInicio":"2024-02-08T00:00:00","DataFim":"2024-02-11T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703617598,"DataInicio":"2024-03-14T00:00:00","DataFim":"2024-03-17T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703617630,"DataInicio":"2024-04-11T00:00:00","DataFim":"2024-04-14T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703617652,"DataInicio":"2024-05-09T00:00:00","DataFim":"2024-05-12T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":'
+ N'1703617679,"DataInicio":"2024-06-13T00:00:00","DataFim":"2024-06-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703617705,"DataInicio":"2024-07-11T00:00:00","DataFim":"2024-07-14T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703617729,"DataInicio":"2024-08-15T00:00:00","DataFim":"2024-08-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703617750,"DataInicio":"2024-09-12T00:00:00","DataFim":"2024-09-15T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703617771,"DataInicio":"2024-10-10T00:00:00","DataFim":"2024-10-13T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703617791,"DataInicio":"2024-11-14T00:00:00","DataFim":"2024-11-17T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1703617818,"DataInicio":"2024-12-12T00:00:00","DataFim":"2024-12-15T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1704478638,"DataInicio":"2024-01-17T00:00:00","DataFim":"2024-01-21T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"}],"ParametroExtra":"Comunicação com a DATAPREV","TaxaJuros":null}'', CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), ''saulo.pastor@bancopaulista.com.br,luiz.giro@bancopaulista.com.br'', ''saulo.pastor@bancopaulista.com.br,luiz.giro@bancopaulista.com.br'', 1, 60)')
EXEC(N'INSERT FastConsig.dbo.ConfiguracaoJob(Id, IdJob, HorarioExecucao, ParametrosExtras, Dom, Seg, Ter, Qua, Qui, Sex, Sab, Habilitado, EmailAvisoConclusao, EmailAvisoErro, TentativasExecucao, DelayExecucao) VALUES (35, 7, ''06:00-06:10'', ''{"Excecao":[{"Id":1658883535,"DataInicio":"2022-08-10T00:00:00","DataFim":"2022-08-14T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1663101866,"DataInicio":"2022-09-14T00:00:00","DataFim":"2022-09-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"\tProcessamento da Folha - DATAPREV"},{"Id":1663159990,"DataInicio":"2022-10-18T00:00:00","DataFim":"2022-10-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1663160041,"DataInicio":"2022-11-09T00:00:00","DataFim":"2022-11-13T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1663160067,"DataInicio":"2022-12-14T00:00:00","DataFim":"2022-12-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756901,"DataInicio":"2023-02-08T00:00:00","DataFim":"2023-02-12T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756918,"DataInicio":"2023-03-15T00:00:00","DataFim":"2023-03-19T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756940,"DataInicio":"2023-04-12T00:00:00","DataFim":"2023-04-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756959,"DataInicio":"2023-05-10T00:00:00","DataFim":"2023-05-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"06:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756978,"DataInicio":"2023-06-14T00:00:00","DataFim":"2023-06-18T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672756993,"DataInicio":"2023-07-12T00:00:00","DataFim":"2023-07-16T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757018,"DataInicio":"2023-08-09T00:00:00","DataFim":"2023-08-13T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757040,"DataInicio":"2023-09-13T00:00:00","DataFim":"2023-09-17T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757062,"DataInicio":"2023-10-11T00:00:00","DataFim":"2023-10-15T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757088,"DataInicio":"2023-11-08T00:00:00","DataFim":"2023-11-12T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1672757112,"DataInicio":"2023-12-06T00:00:00","DataFim":"2023-12-06T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"},{"Id":1673612379,"DataInicio":"2023-01-11T00:00:00","DataFim":"2023-01-17T00:00:00","HorarioInicial":"06:00","HorarioFinal":"22:00","Motivo":"Processamento da Folha - DATAPREV"}],"ParametroExtra":null,"TaxaJuros":{"ValorTaxaMensalMinima":1.44,"ValorTaxaMensalMaxima":1.66,"ValorTaxaMensalMinimaRMC":0.0,"ValorTaxaMensalMaximaRMC":0.0,"ValorTaxaMensalMinimaRCC":0.0,"ValorTaxaMensalMaximaRCC":0.0,"AtendimentoView":" [\n        { \"nome\": \"Central de Relacionamento\", \"descricao\": \" 0800 930 1000\" },\n        { \"nome\": \"SAC\", \"descricao\": \"0800 930 1000\" },\n        { \"nome\": \"Ouvidoria\", \"descricao\": \"0800 772 6116\" },\n        { \"nome\": \"WhatsApp\", \"descricao\": \"0800 930 1000\" },\n        { \"nome\": \"Central de Atendimento\", \"descricao\": \"0800 930 1000\" }\n    ]","Atendimento":[{"nome":"Central de Relacionamento","descricao":" 0800 930 1000"},{"nome"'
+ N':"SAC","descricao":"0800 930 1000"},{"nome":"Ouvidoria","descricao":"0800 772 6116"},{"nome":"WhatsApp","descricao":"0800 930 1000"},{"nome":"Central de Atendimento","descricao":"0800 930 1000"}]}}'', CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), ''saulo.pastor@bancopaulista.com.br,luiz.giro@bancopaulista.com.br; gestao.corban@bancopaulista.com.br'', ''saulo.pastor@bancopaulista.com.br,luiz.giro@bancopaulista.com.br; gestao.corban@bancopaulista.com.br'', 1, 60)')
EXEC(N'INSERT FastConsig.dbo.ConfiguracaoJob(Id, IdJob, HorarioExecucao, ParametrosExtras, Dom, Seg, Ter, Qua, Qui, Sex, Sab, Habilitado, EmailAvisoConclusao, EmailAvisoErro, TentativasExecucao, DelayExecucao) VALUES (36, 8, ''07:00-23:59'', ''{
  "Excecao": [
    {
      "Id": 1658883535,
      "DataInicio": "2022-08-10T00:00:00",
      "DataFim": "2022-08-14T00:00:00",
      "HorarioInicial": "06:00",
      "HorarioFinal": "22:00",
      "Motivo": "Processamento da Folha - DATAPREV"
    },
    {
      "Id": 1663101866,
      "DataInicio": "2022-09-14T00:00:00",
      "DataFim": "2022-09-18T00:00:00",
      "HorarioInicial": "06:00",
      "HorarioFinal": "22:00",
      "Motivo": "\tProcessamento da Folha - DATAPREV"
    },
    {
      "Id": 1663159990,
      "DataInicio": "2022-10-18T00:00:00",
      "DataFim": "2022-10-18T00:00:00",
      "HorarioInicial": "06:00",
      "HorarioFinal": "22:00",
      "Motivo": "Processamento da Folha - DATAPREV"
    },
    {
      "Id": 1663160041,
      "DataInicio": "2022-11-09T00:00:00",
      "DataFim": "2022-11-13T00:00:00",
      "HorarioInicial": "06:00",
      "HorarioFinal": "22:00",
      "Motivo": "Processamento da Folha - DATAPREV"
    },
    {
      "Id": 1663160067,
      "DataInicio": "2022-12-14T00:00:00",
      "DataFim": "2022-12-18T00:00:00",
      "HorarioInicial": "06:00",
      "HorarioFinal": "22:00",
      "Motivo": "Processamento da Folha - DATAPREV"
    },
    {
      "Id": 1672756901,
      "DataInicio": "2023-02-08T00:00:00",
      "DataFim": "2023-02-12T00:00:00",
      "HorarioInicial": "06:00",
      "HorarioFinal": "22:00",
      "Motivo": "Processamento da Folha - DATAPREV"
    },
    {
      "Id": 1672756918,
      "DataInicio": "2023-03-15T00:00:00",
      "DataFim": "2023-03-19T00:00:00",
      "HorarioInicial": "06:00",
      "HorarioFinal": "22:00",
      "Motivo": "Processamento da Folha - DATAPREV"
    },
    {
      "Id": 1672756940,
      "DataInicio": "2023-04-12T00:00:00",
      "DataFim": "2023-04-16T00:00:00",
      "HorarioInicial": "06:00",
      "HorarioFinal": "22:00",
      "Motivo": "Processamento da Folha - DATAPREV"
    },
    {
      "Id": 1672756959,
      "DataInicio": "2023-05-10T00:00:00",
      "DataFim": "2023-05-16T00:00:00",
      "HorarioInicial": "06:00",
      "HorarioFinal": "06:00",
      "Motivo": "Processamento da Folha - DATAPREV"
    },
    {
      "Id": 1672756978,
      "DataInicio": "2023-06-14T00:00:00",
      "DataFim": "2023-06-18T00:00:00",
      "HorarioInicial": "06:00",
      "HorarioFinal": "22:00",
      "Motivo": "Processamento da Folha - DATAPREV"
    },
    {
      "Id": 1672756993,
      "DataInicio": "2023-07-12T00:00:00",
      "DataFim": "2023-07-16T00:00:00",
      "HorarioInicial": "06:00",
      "HorarioFinal": "22:00",
      "Motivo": "Processamento da Folha - DATAPREV"
    },
    {
      "Id": 1672757018,
      "DataInicio": "2023-08-09T00:00:00",
      "DataFim": "2023-08-13T00:00:00",
      "HorarioInicial": "06:00",
      "HorarioFinal": "22:00",
      "Motivo": "Processamento da Folha - DATAPREV"
    },
    {
      "Id": 1672757040,
      "DataInicio": "2023-09-13T00:00:00",
      "DataFim": "2023-09-17T00:00:00",
      "HorarioInicial": "06:00",
      "HorarioFinal": "22:00",
      "Motivo": "Processamento da Folha - DATAPREV"
    },
    {
      "Id": 1672757062,
      "DataInicio": "2023-10-11T00:00:00",
      "DataFim": "2023-10-15T00:00:00",
      "HorarioInicial": "06:00",
      "HorarioFinal": "22:00",
      "Motivo": "Processamento da Folha - DATAPREV"
    },
    {
      "Id": 1672757088,
      "DataInicio": "2023-11-08T00:00:00",
      "DataFim": "2023-11-12T00:00:00",
      "HorarioInicial": "06:00",
      "HorarioFinal": "22:00",
      "Motivo": "Processamento da Folha - DATAPREV"
    },
    {
      "Id": 1672757112,
      "DataInicio": "2023-12-06T00:00:00",
 '
+ N'     "DataFim": "2023-12-10T00:00:00",
      "HorarioInicial": "06:00",
      "HorarioFinal": "22:00",
      "Motivo": "Processamento da Folha - DATAPREV"
    },
    {
      "Id": 1673612379,
      "DataInicio": "2023-01-11T00:00:00",
      "DataFim": "2023-01-17T00:00:00",
      "HorarioInicial": "06:00",
      "HorarioFinal": "22:00",
      "Motivo": "Processamento da Folha - DATAPREV"
    }
  ],
  "ParametroExtra": "Comunicação com a DATAPREV"
}'', CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), CONVERT(bit, ''True''), ''saulo.pastor@bancopaulista.com.br,luiz.giro@bancopaulista.com.br; gestao.corban@bancopaulista.com.br'', ''saulo.pastor@bancopaulista.com.br,luiz.giro@bancopaulista.com.br; gestao.corban@bancopaulista.com.br'', 1, 60)')
GO
SET IDENTITY_INSERT FastConsig.dbo.ConfiguracaoJob OFF
GO