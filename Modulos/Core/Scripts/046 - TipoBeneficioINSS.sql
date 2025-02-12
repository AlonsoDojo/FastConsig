CREATE TABLE FastConsig.dbo.TipoBeneficioINSS (
  Id int IDENTITY,
  Descricao varchar(100) NOT NULL,
  Utilizacao varchar(100) NULL,
  Aceito bit NULL DEFAULT (0),
  CONSTRAINT PK_TipoBeneficioINSS_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

TODO: Montar Script

Pensão por Morte	Trabalhador Rural	True
Pensão por Morte por Acidente de Trabalho	Trabalhador Rural	True
Pensão	Empregador Rural	True
Aposentadoria por Invalidez	Trabalhador Rural	True
Aposentadoria por Invalidez por Acidente de Trabalho	Trabalhador Rural	True
Aposentadoria por Invalidez	Empregador Rural	True
Aposentadoria por idade	Trabalhador Rural	True
Aposentadoria por idade	Empregador Rural	True
Complemento por Acidente de Trabalho	Trabalhador Rural	False
Auxílio Doença Acidentário	Empregador Rural	False
Amparo Previdenciário por Invalidez	Empregador Rural	False
Amparo Previdenciário por Idade	Empregador Rural	False
Auxílio Doença	Empregador Rural	False
Auxílio Reclusão	Empregador Rural	False
Pensão de Estudante (LEI 7004 / 82)	-	True
Pensão por Morte	Ex-Diplomata	True
Pensão por Morte Previdenciária (LOPS)	-	True
Pensão por Morte Estatutária ( EPU)	-	True
Pensão por Morte	Ex-Combatente	True
Pensão Especial ( Ato Institucional)	-	True
Auxílio Reclusão		False
Pensão Especial ( LEI 593 / 48) (EPU)	-	True
Pensão por Morte	Servidor Público Federal com dupla aposentadoria	True
Pensão por Morte do Regime Geral (Decreto 20465 / 31)	-	True
Pensão por Morte (LEI 1256 / 52)	Ex-Combatente Marítimo	True
Renda Mensal Vitalícia por Incapacidade (LEI 6179 / 74)		False
Auxílio Doença Previdenciário		False
Aposentadoria por Invalidez Previdenciária (LOPS)	-	True
Aposentadoria por Invalidez	Aeronauta	True
Aposentadoria por Morte	Ex-Combatente Marítimo	True
Auxílio acidente Previdenciário		False
Aposentadoria de extranumerário da União (EPU)	-	True
Aposentadoria da extinta CAPIN (EPU)	-	True
Auxílio Invalidez de Estudante (LEI 7004 / 82)		False
Renda Mensal Vitalícia a Maiores de 70 anos LEI6179/74		False
Aposentadoria por Idade (LOPS)	-	True
Aposentadoria por Tempo de Contribuição Previdenciária	-	True
Aposentadoria por Tempo de Contribuição	Ex-Combatente	True
Aposentadoria por Tempo de Contribuição	Aeronauta	True
Aposentadoria por Tempo de Contribuição	Jornalista Profissional	True
Aposentadoria por Tempo de Contribuição Especial	-	True
Abono de Permanência em Serviço (25%)		False
Abono de Permanência em Serviço (20%)		False
Aposentadoria por Tempo de Contribuição Ordinária	-	True
Auxílio Doença Extinto Plano Básico		False
Aposentadoria por Invalidez (Extinto plano Básico)	-	True
Aposentadoria por Idade (Extinto plano Básico)	-	True
Auxílio Reclusão Extinto Plano Básico		False
Pensão por Morte (Extinto plano Básico)	-	True
Pensão Especial Síndrome de Talidomida (LEI 7070 / 82)		True
Aposentadoria por Tempo de Contribuição	Professor (Emenda Constitucional 18/81)	True
Aposentadoria Excepcional (EPU)	Anistiado (Lei 6683 / 79 )	True
Pensão por Morte Excepcional (EPU)	Anistiado (Lei 6683 / 79 )	True
Auxílio Natalidade		False
Auxílio Funeral		False
Pecúlio Especial de Servidor Autárquico (LEI 3073 / 58)		False
Pecúlio Especial de Servidor Autárquico Decreto		False
Pecúlio Especial de Aposentado		False
Pecúlio de Estudante (LEI 7004 / 82)		False
Pecúlio Especial entrada com mais de 60 anos		False
Salário Família Previdenciário		False
Aposentadoria por Tempo de Contribuição	Ex-Combatente Marítimo (Lei 17556 / 52)	True
Salário Família Estatutário Decreto 73833 / 74		False
Complemento de Pensão à conta da União		False
Complemento a Aposentadoria à conta da União		False
Salário Família Estatutário Decreto 73833 / 74		False
Salário Família dos Servidores INPS / IAPFEST		False
Aposentadoria por Idade	Ex-Combatente Marítimo (Lei 17556 / 52)	True
Vantagens da Lei 1756/52 Servidor Aposentado		False
Salário Maternidade		False
Aposentadoria por Idade Compulsória (Ex-SASSE)	-	True
Aposentadoria por Tempo de Contribuição (Ex-SASSE)	-	True
Aposentadoria por Invalidez (Ex-SASSE)	-	True
Pensão por Morte ( Ex-SASSE)	-	True
Pensão mensal Vitalícia	Seringueiro (Lei 7986 / 89)	False
Pensão mensal Vitalícia	Dependente de Seringueiro (Lei 7986 / 89)	False
Amparo Assistencial ao deficiente		True
Amparo Assistencial ao Idoso		True
Pensão Espacial Hemodiálise		False
Auxílio Doença por Acidente de Trabalho		False
Aposentadoria por invalidez	Acidente de Trabalho	True
Pensão por Morte	Acidente de Trabalho	True
Auxílio Acidente		False
Auxílio Suplementar		False
Pecúlio por Invalidez por Acidente de Trabalho		False
Pecúlio por Morte por Acidente de Trabalho		False
Afastamento de 15 (quinze) dias para Acidente de Trabalho		False