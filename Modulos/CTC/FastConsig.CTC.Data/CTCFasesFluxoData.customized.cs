
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.CTC.Entity;
#endregion

namespace FastConsig.CTC.Data
{
	public partial class CTCFasesFluxoData
	{
		
		public CTCFasesFluxoData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
			//*************************************************************************
			//*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
			//*************************************************************************

			//JOIN com a tabela CTCDominioArquivo
			//------------------------------------------------------------------
			//query.Join(CTCFasesFluxo.METADADO.TipoArquivo, Join.Inner, CTCDominioArquivo.METADADO.Id)
			//     .Field(CTCDominioArquivo.METADADO.NomeArquivo, "NomeArquivoCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Classe, "ClasseCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Monitorar, "MonitorarCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Entrada, "EntradaCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Saida, "SaidaCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.GradeHorariaInicial, "GradeHorariaInicialCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.GradeHorariaFinal, "GradeHorariaFinalCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Parser, "ParserCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Builder, "BuilderCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Process, "ProcessCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Arquivo, "ArquivoCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Protocolo, "ProtocoloCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Retorno, "RetornoCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Erro, "ErroCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Emissor, "EmissorCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Destinatario, "DestinatarioCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Online, "OnlineCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.LimiteRegistros, "LimiteRegistrosCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Descricao, "DescricaoCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Validator, "ValidatorCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.XSD, "XSDCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Domingo, "DomingoCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Segunda, "SegundaCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Terca, "TercaCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Quarta, "QuartaCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Quinta, "QuintaCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Sexta, "SextaCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.Sabado, "SabadoCTCDominioArquivo")
			//     .Field(CTCDominioArquivo.METADADO.ValidaDiaUtil, "ValidaDiaUtilCTCDominioArquivo");
			//------------------------------------------------------------------

			//JOIN com a tabela CTCTipoFluxo
			//------------------------------------------------------------------
			//query.Join(CTCFasesFluxo.METADADO.TipoFluxo, Join.Inner, CTCTipoFluxo.METADADO.Id)
			//     .Field(CTCTipoFluxo.METADADO.Descricao, "DescricaoCTCTipoFluxo");
			//------------------------------------------------------------------

			//JOIN com a tabela CTCFases
			//------------------------------------------------------------------
			//query.Join(CTCFasesFluxo.METADADO.Fase, Join.Inner, CTCFases.METADADO.Id)
			//     .Field(CTCFases.METADADO.Descricao, "DescricaoCTCFases");
			//------------------------------------------------------------------


		}

	}
}
