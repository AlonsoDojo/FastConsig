<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeBehind="CapturaSIAPE.aspx.cs" Inherits="FastConsig.Core.Web.Credito.SIAPE.CapturaSIAPE" EnableViewState="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <div class="row">
      <div class="col-lg-12">
         <div class="card">
            <div class="card-body">
               <div class="row">
                  <div class="col-lg-12">
                     <div class="mt-12">
                        <div class="d-flex flex-wrap gap-3 mt-3 mx-auto">
                           <fmk:CustomLinkButton ID="btnVoltar" runat="server" class="btn btn-secondary waves-effect" CausesValidation="false" OnClick="btnVoltar_Click">Voltar</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnSalvar" runat="server" class="btn btn-primary waves-light" DialogConfirmarAcao="true" OnClick="btnSalvar_Click">Salvar</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnRejeitarProposta" runat="server" class="btn btn-danger waves-effect waves-light" DialogConfirmarExclusao="true" OnClick="btnRejeitarProposta_Click">Rejeitar Proposta</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnPendenciar" runat="server" class="btn btn-warning waves-effect waves-light" DialogConfirmarAcao="true" OnClick="btnPendenciar_Click">Pendenciar Proposta</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnSubmeter" runat="server" class="btn btn-primary waves-light" DialogConfirmarAcao="true" OnClick="btnSubmeter_Click">Submeter</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnReenviarMensagem" runat="server" Visible="false" class="btn btn-info waves-effect waves-light" DialogConfirmarAcao="true" OnClick="btnReenviarMensagem_Click">Reenviar Mensagem</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnReenviarLinkCombateaFraude" runat="server" Visible="false" class="btn btn-info waves-effect waves-light" DialogConfirmarAcao="true" OnClick="btnReenviarLinkCombateaFraude_Click">Reenviar Link - Combate a Fraude</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnReenviarLinkAssinatura" runat="server" Visible="false" class="btn btn-info waves-effect waves-light" DialogConfirmarAcao="true" OnClick="btnReenviarLinkAssinatura_Click">Reenviar Link Assinatura Digital</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnDesbloquearProposta" runat="server" Visible="false" class="btn btn-secondary waves-effect waves-light" DialogConfirmarAcao="true" OnClick="btnDesbloquearProposta_Click">Desbloquear Proposta</fmk:CustomLinkButton>
                        </div>

                        <div class="mb-3">
                        </div>
                     </div>
                  </div>
               </div>

               <div class="row">
                  <div class="col-md-2">
                     <div class="nav flex-column nav-pills" id="v-pills-tab" role="tablist" aria-orientation="vertical">
                        <a class="nav-link mb-2 active" runat="server" id="tabPropostasTab" data-bs-toggle="pill" href="#tabPropostas" role="tab" aria-controls="tabPropostas" aria-selected="true">Proposta</a>
                        <a class="nav-link mb-2" runat="server" id="tabConsultasTab" data-bs-toggle="pill" href="#tabConsultas" role="tab" aria-controls="tabConsultas" aria-selected="false" tabindex="-1">Resultado das Consultas</a>
                        <a class="nav-link mb-2" runat="server" id="tabOcorrenciasTab" data-bs-toggle="pill" href="#tabOcorrencias" role="tab" aria-controls="tabOcorrencias" aria-selected="false" tabindex="-1">Ocorrências</a>
                        <a class="nav-link mb-2" runat="server" id="tabChecklistTab" data-bs-toggle="pill" href="#tabChecklist" role="tab" aria-controls="tabChecklist" aria-selected="false" tabindex="-1">Checklist</a>
                        <a class="nav-link mb-2" runat="server" id="tabTrilhaAuditoriaTab" data-bs-toggle="pill" href="#tabTrilhaAuditoria" role="tab" aria-controls="tabTrilhaAuditoria" aria-selected="false" tabindex="-1">Trilha de Auditoria</a>
                        <a class="nav-link mb-2" runat="server" id="tabHistoricoTab" data-bs-toggle="pill" href="#tabHistorico" role="tab" aria-controls="tabHistorico" aria-selected="false" tabindex="-1">Histórico de Alterações</a>
                        <a class="nav-link mb-2" runat="server" id="tabLogsTab" data-bs-toggle="pill" href="#tabLogs" role="tab" aria-controls="tabLogs" aria-selected="false" tabindex="-1">Logs</a>
                        <a class="nav-link mb-2" runat="server" id="tabArquivosTab" data-bs-toggle="pill" href="#tabArquivos" role="tab" aria-controls="tabArquivos" aria-selected="false" tabindex="-1">Arquivos</a>
                     </div>
                  </div>
                  <div class="col-md-10">
                     <div class="tab-content mt-4 mt-md-0" id="v-pills-tabContent">
                        <!-- Proposta -->
                        <div class="tab-pane fade active show" id="tabPropostas" role="tabpanel" aria-labelledby="tabPropostas-tab">
                           <div class="accordion" id="accordionProposta">
                              <!-- Dados de Captura -->
                              <div class="accordion-item">
                                 <h2 class="accordion-header" id="headingDadosCaptura">
                                    <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseDadosCaptura" aria-expanded="false" aria-controls="collapseDadosCaptura">
                                       <strong>Dados de Captura</strong>
                                    </button>
                                 </h2>
                                 <div id="collapseDadosCaptura" class="accordion-collapse collapse" aria-labelledby="headingDadosCaptura" data-bs-parent="#accordionProposta" style="">
                                    <div class="accordion-body">
                                       <div class="col-xl-12">
                                          <div class="card">
                                             <div class="card-body">

                                                <div class="row">
                                                   <div class="col-md-2">
                                                      <div class="mb-3">
                                                         <label class="form-label" for="txtProposta">Proposta</label>
                                                         <fmk:CustomTextBox ID="txtProposta" runat="server"
                                                            CssClass="form-control"
                                                            TabIndex="1"
                                                            placeholder="Id"
                                                            BindSelectedType="Message"
                                                            Required="false"
                                                            Enabled="false"
                                                            FormatType="Integer"
                                                            onkeypress="return isNumber(event)"
                                                            onpaste="return false;"
                                                            autocomplete="off"
                                                            BindSourceType="Message"
                                                            BindSourceText="PropostaModel.Id"
                                                            BindSourceValue="PropostaModel.Id"
                                                            Style="text-align: left; color: red; font-weight: bold;">
                                                         </fmk:CustomTextBox>
                                                      </div>
                                                   </div>
                                                   <div class="col-md-10">
                                                      <div class="mb-3">
                                                      </div>
                                                   </div>

                                                </div>

                                                <div class="row">
                                                   <div class="col-md-6">
                                                      <div class="mb-3">
                                                         <label class="form-label" for="ddlPromotora">Promotora</label>
                                                         <fmk:CustomDropDownList
                                                            ID="ddlPromotora"
                                                            runat="server"
                                                            CssClass="form-control dropdown-toggle select2-selection form-select"
                                                            TabIndex="2"
                                                            BindSelectedType="Message"
                                                            Required="true"
                                                            Enabled="false"
                                                            BindSourceType="Message"
                                                            BindSelectedValue="PropostaModel.Promotora.Id"
                                                            DefaultSelectedItem="(Selecione a Promotora)"
                                                            BindSourceText="Promotoras.Nome"
                                                            BindSourceValue="Promotoras.Id">
                                                         </fmk:CustomDropDownList>
                                                      </div>
                                                   </div>
                                                   <div class="col-md-6">
                                                      <div class="mb-3">
                                                         <label class="form-label" for="ddlGerente">Gerente</label>
                                                         <fmk:CustomDropDownList
                                                            ID="ddlGerente"
                                                            runat="server"
                                                            CssClass="form-control dropdown-toggle select2-selection form-select"
                                                            TabIndex="3"
                                                            BindSelectedType="Message"
                                                            Required="true"
                                                            Enabled="false"
                                                            BindSourceType="Message"
                                                            BindSelectedValue="PropostaModel.Gerente.Id"
                                                            DefaultSelectedItem="(Selecione o Gerente)"
                                                            BindSourceText="Gerentes.Nome"
                                                            BindSourceValue="Gerentes.Id">
                                                         </fmk:CustomDropDownList>

                                                      </div>
                                                   </div>

                                                </div>

                                                <div class="row">
                                                   <div class="col-md-6">
                                                      <div class="mb-3">
                                                         <label class="form-label" for="ddlRedeLojas">Rede de Lojas</label>
                                                         <fmk:CustomDropDownList
                                                            ID="ddlRedeLojas"
                                                            runat="server"
                                                            CssClass="form-control dropdown-toggle select2-selection form-select"
                                                            TabIndex="4"
                                                            BindSelectedType="Message"
                                                            Required="true"
                                                            Enabled="false"
                                                            BindSourceType="Message"
                                                            BindSelectedValue="PropostaModel.Operacoes.RedeLojas"
                                                            DefaultSelectedItem="(Selecione a Rede de Lojas)"
                                                            BindSourceText="RedeLoja.Nome"
                                                            BindSourceValue="RedeLoja.Id">
                                                         </fmk:CustomDropDownList>

                                                      </div>
                                                   </div>
                                                   <div class="col-md-6">
                                                      <div class="mb-3">
                                                         <label class="form-label" for="ddlLojas">Lojas</label>
                                                         <fmk:CustomDropDownList
                                                            ID="ddlLojas"
                                                            runat="server"
                                                            CssClass="form-control dropdown-toggle select2-selection form-select"
                                                            TabIndex="5"
                                                            BindSelectedType="Message"
                                                            Required="true"
                                                            Enabled="false"
                                                            BindSourceType="Message"
                                                            BindSelectedValue="PropostaModel.Operacoes.Loja"
                                                            DefaultSelectedItem="(Selecione a Loja)"
                                                            BindSourceText="Lojas.Nome"
                                                            BindSourceValue="Lojas.Id">
                                                         </fmk:CustomDropDownList>
                                                      </div>
                                                   </div>

                                                </div>

                                                <div class="row">
                                                   <div class="col-md-9">
                                                      <div class="mb-3">
                                                         <label class="form-label" for="ddlProduto">Produto</label>
                                                         <fmk:CustomDropDownList
                                                            ID="ddlProduto"
                                                            runat="server"
                                                            CssClass="form-control dropdown-toggle select2-selection form-select"
                                                            TabIndex="6"
                                                            BindSelectedType="Message"
                                                            Required="true"
                                                            Enabled="false"
                                                            BindSourceType="Message"
                                                            BindSelectedValue="PropostaModel.Operacoes.Produto"
                                                            DefaultSelectedItem="(Selecione o Produto)"
                                                            BindSourceText="Produtos.Nome"
                                                            BindSourceValue="Produtos.Id">
                                                         </fmk:CustomDropDownList>
                                                      </div>
                                                   </div>
                                                   <div class="col-md-3">
                                                      <div class="mb-3">
                                                         <label class="form-label" for="ddlTipoComunicacao">Tipo de Comunicação</label>
                                                         <fmk:CustomDropDownList
                                                            ID="ddlTipoComunicacao"
                                                            runat="server"
                                                            CssClass="form-control dropdown-toggle select2-selection form-select"
                                                            TabIndex="7"
                                                            BindSelectedType="Message"
                                                            Required="true"
                                                            Enabled="false"
                                                            BindSourceType="Message"
                                                            BindSelectedValue="PropostaModel.TipoComunicacao"
                                                            DefaultSelectedItem="(Selecione o Tipo de Comunicação)"
                                                            BindSourceText="TipoComunicacao.Descricao"
                                                            BindSourceValue="TipoComunicacao.Id">
                                                         </fmk:CustomDropDownList>
                                                      </div>
                                                   </div>

                                                </div>

                                                <div class="row">
                                                   <div class="col-md-6">
                                                      <div class="mb-3">
                                                         <label class="form-label" for="txtProfissionalCertificado">Profissional Certificado</label>
                                                         <fmk:CustomTextBox ID="txtProfissionalCertificado" runat="server"
                                                            CssClass="form-control"
                                                            TabIndex="8"
                                                            placeholder="Profissional Certificado"
                                                            BindSelectedType="Message"
                                                            Required="false"
                                                            Enabled="false"
                                                            onkeypress="return isNumber(event)"
                                                            onpaste="return false;"
                                                            autocomplete="off"
                                                            BindSourceType="Message"
                                                            BindSourceText="PropostaModel.NomeProfissionalCertificado">
                                                         </fmk:CustomTextBox>
                                                      </div>
                                                   </div>
                                                   <div class="col-md-6">
                                                      <div class="mb-3">
                                                         <label class="form-label" for="txtDigitador">Digitador</label>
                                                         <fmk:CustomTextBox ID="txtDigitador" runat="server"
                                                            CssClass="form-control"
                                                            TabIndex="9"
                                                            placeholder="Digitador"
                                                            BindSelectedType="Message"
                                                            Required="false"
                                                            Enabled="false"
                                                            onkeypress="return isNumber(event)"
                                                            onpaste="return false;"
                                                            autocomplete="off"
                                                            BindSourceType="Message"
                                                            BindSourceText="PropostaModel.NomeDigitador">
                                                         </fmk:CustomTextBox>

                                                      </div>
                                                   </div>

                                                </div>
                                             </div>
                                          </div>
                                       </div>

                                    </div>
                                 </div>
                              </div>
                              <!-- /Dados de Captura -->
                              <!-- Informações do Cliente -->
                              <div class="accordion-item">
                                 <h2 class="accordion-header" id="headingInformacoesCliente">
                                    <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapseInformacoesCliente" aria-expanded="false" aria-controls="collapseInformacoesCliente">
                                       <strong>Informações do Cliente</strong>
                                    </button>
                                 </h2>
                                 <div id="collapseInformacoesCliente" class="accordion-collapse collapse show" aria-labelledby="headingInformacoesCliente" data-bs-parent="#accordionProposta">
                                    <div class="accordion-body">
                                       <div class="col-xl-12">
                                          <div class="card">
                                             <div class="card-body">

                                                <div class="accordion" id="accordionCliente">
                                                   <!-- Dados Basicos -->
                                                   <div class="accordion-item">
                                                      <h2 class="accordion-header" id="headingDadosBasicos">
                                                         <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapseDadosBasicoa" aria-expanded="false" aria-controls="collapseDadosBasicos">
                                                            <strong>Dados Básicos</strong>
                                                         </button>
                                                      </h2>

                                                      <div id="collapseDadosBasicos" class="accordion-collapse collapse show" aria-labelledby="headingDadosBasicos" data-bs-parent="#accordionCliente" style="">
                                                         <div class="accordion-body">
                                                            <div class="card">
                                                               <div class="card-body">

                                                                  <div class="row">
                                                                     <div class="col-md-2">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtCPF">CPF</label>
                                                                           <fmk:CustomTextBox ID="txtCPF" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="8"
                                                                              placeholder="CPF"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="false"
                                                                              MaxLength="18"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.CpfCnpjFormatado"
                                                                              BindSourceValue="PropostaModel.Proponente.CpfCnpjFormatado"></fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>

                                                                     <div class="col-md-8">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtNome">Nome</label>
                                                                           <fmk:CustomTextBox ID="txtNome" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="12"
                                                                              placeholder="Nome"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="false"
                                                                              MaxLength="100"
                                                                              FormatType="Text"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.Nome"
                                                                              BindSourceValue="PropostaModel.Proponente.Nome"></fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>


                                                                     <div class="col-md-2">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtDataNascimento">Data de Nascto.</label>
                                                                           <fmk:CustomTextBox ID="txtDataNascimento" runat="server"
                                                                              CssClass="form-control flatpickr-input"
                                                                              TabIndex="9"
                                                                              MaxLength="13"
                                                                              Style="width: 120px;"
                                                                              placeholder="Data Nascimento"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="false"
                                                                              onkeypress="return isNumber(event)"
                                                                              FormatType="Date"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.DataNascimento"
                                                                              BindSourceValue="PropostaModel.Proponente.DataNascimento"></fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>
                                                                  </div>

                                                                  <div class="row">
                                                                     <div class="col-md-12">
                                                                        <div class="mb-12">
                                                                           &nbsp;
                                                                        </div>
                                                                     </div>
                                                                  </div>

                                                                  <div class="row">
                                                                     <div class="col-md-2">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="ddlNacionalidade">Nacionalidade</label>
                                                                           <fmk:CustomDropDownList
                                                                              ID="ddlNacionalidade"
                                                                              runat="server"
                                                                              CssClass="form-control dropdown-toggle select2-selection form-select"
                                                                              TabIndex="14"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="true"
                                                                              BindSourceType="Message"
                                                                              BindSelectedValue="PropostaModel.Proponente.Nacionalidade"
                                                                              DefaultSelectedItem="(Selecione a Nacionalidade)"
                                                                              BindSourceText="Nacionalidade.Descricao"
                                                                              BindSourceValue="Nacionalidade.Id">
                                                                           </fmk:CustomDropDownList>
                                                                        </div>
                                                                     </div>
                                                                     <div class="col-md-6">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtNaturalidade">Naturalidade</label>
                                                                           <fmk:CustomTextBox ID="txtNaturalidade" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="15"
                                                                              placeholder="Nome"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="true"
                                                                              MaxLength="100"
                                                                              FormatType="Text"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.Naturalidade"
                                                                              BindSourceValue="PropostaModel.Proponente.Naturalidade"></fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>
                                                                     <div class="col-md-2">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="ddlSexo">Sexo</label>
                                                                           <fmk:CustomDropDownList
                                                                              ID="ddlSexo"
                                                                              runat="server"
                                                                              CssClass="form-control dropdown-toggle select2-selection form-select"
                                                                              TabIndex="16"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="true"
                                                                              BindSourceType="Message"
                                                                              BindSelectedValue="PropostaModel.Proponente.Sexo"
                                                                              DefaultSelectedItem="(Selecione o Sexo)"
                                                                              BindSourceText="Sexo.Descricao"
                                                                              BindSourceValue="Sexo.Id">
                                                                           </fmk:CustomDropDownList>
                                                                        </div>
                                                                     </div>
                                                                     <div class="col-md-2">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="ddlEstadoCivil">Estado Civil</label>
                                                                           <fmk:CustomDropDownList
                                                                              ID="ddlEstadoCivil"
                                                                              runat="server"
                                                                              CssClass="form-control dropdown-toggle select2-selection form-select"
                                                                              TabIndex="17"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="true"
                                                                              BindSourceType="Message"
                                                                              BindSelectedValue="PropostaModel.Proponente.EstadoCivil"
                                                                              DefaultSelectedItem="(Selecione o Estado Civil)"
                                                                              BindSourceText="EstadoCivil.Descricao"
                                                                              BindSourceValue="EstadoCivil.Id">
                                                                           </fmk:CustomDropDownList>
                                                                        </div>
                                                                     </div>
                                                                  </div>

                                                                  <div class="row">
                                                                     <div class="col-md-12">
                                                                        <div class="mb-12">
                                                                           &nbsp;
                                                                        </div>
                                                                     </div>
                                                                  </div>

                                                                  <div class="row">
                                                                     <div class="col-md-2">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="ddlTipoDocumento">Tipo Documento</label>
                                                                           <fmk:CustomDropDownList
                                                                              ID="ddlTipoDocumento"
                                                                              runat="server"
                                                                              CssClass="form-control dropdown-toggle select2-selection form-select"
                                                                              TabIndex="18"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="true"
                                                                              BindSourceType="Message"
                                                                              BindSelectedValue="PropostaModel.Proponente.TipoDocumentoIdentidade"
                                                                              DefaultSelectedItem="(Selecione o Tipo de Documento)"
                                                                              BindSourceText="TipoDocumentoIdentidade.Abreviatura"
                                                                              BindSourceValue="TipoDocumentoIdentidade.Id">
                                                                           </fmk:CustomDropDownList>
                                                                        </div>
                                                                     </div>
                                                                     <div class="col-md-4">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtNumeroDocumentoIdentidade">Nº Documento</label>
                                                                           <fmk:CustomTextBox ID="txtNumeroDocumentoIdentidade" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="19"
                                                                              placeholder="Nº do Documento de Identificação"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="true"
                                                                              MaxLength="100"
                                                                              FormatType="Text"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.NumeroDocumentoIdentidade"
                                                                              BindSourceValue="PropostaModel.Proponente.NumeroDocumentoIdentidade"></fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>
                                                                     <div class="col-md-2">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="ddlEmissorDocumento">Orgão Emissor</label>
                                                                           <fmk:CustomDropDownList
                                                                              ID="ddlEmissorDocumento"
                                                                              runat="server"
                                                                              CssClass="form-control dropdown-toggle select2-selection form-select"
                                                                              TabIndex="20"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="true"
                                                                              BindSourceType="Message"
                                                                              BindSelectedValue="PropostaModel.Proponente.OrgaoEmissor"
                                                                              DefaultSelectedItem="(Selecione o Orgão Emissor)"
                                                                              BindSourceText="OrgaoEmissor.Abreviatura"
                                                                              BindSourceValue="OrgaoEmissor.Id">
                                                                           </fmk:CustomDropDownList>
                                                                        </div>
                                                                     </div>
                                                                     <div class="col-md-2">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="ddlUFEmissaoDocumentoIdentidade">UF Emissor</label>
                                                                           <fmk:CustomDropDownList
                                                                              ID="ddlUFEmissaoDocumentoIdentidade"
                                                                              runat="server"
                                                                              CssClass="form-control dropdown-toggle select2-selection form-select"
                                                                              TabIndex="21"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="true"
                                                                              BindSourceType="Message"
                                                                              BindSelectedValue="PropostaModel.Proponente.UFEmissaoDocumentoIdentidade"
                                                                              DefaultSelectedItem="(Selecione a UF de Emissão)"
                                                                              BindSourceText="UFEmissaoDocumentoIdentidade.Id"
                                                                              BindSourceValue="UFEmissaoDocumentoIdentidade.Id">
                                                                           </fmk:CustomDropDownList>
                                                                        </div>
                                                                     </div>
                                                                     <div class="col-md-2">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtDataEmissaoDocumentoIdentidade">Data Emissão</label>
                                                                           <fmk:CustomTextBox ID="txtDataEmissaoDocumentoIdentidade" runat="server"
                                                                              CssClass="form-control flatpickr-input"
                                                                              TabIndex="22"
                                                                              MaxLength="13"
                                                                              Style="width: 120px;"
                                                                              placeholder="Data Nascimento"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="true"
                                                                              onkeypress="return isNumber(event)"
                                                                              FormatType="Date"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.DataEmissaoDocumentoIdentidade"
                                                                              BindSourceValue="PropostaModel.Proponente.DataEmissaoDocumentoIdentidade"></fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>
                                                                  </div>

                                                                  <div class="row">
                                                                     <div class="col-md-12">
                                                                        <div class="mb-12">
                                                                           &nbsp;
                                                                        </div>
                                                                     </div>
                                                                  </div>

                                                                  <div class="row">
                                                                     <div class="col-md-6">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtMae">Mãe</label>
                                                                           <fmk:CustomTextBox ID="txtMae" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="23"
                                                                              placeholder="Nome da Mãe"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="true"
                                                                              MaxLength="100"
                                                                              FormatType="Text"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.Mae"
                                                                              BindSourceValue="PropostaModel.Proponente.Mae"></fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>
                                                                     <div class="col-md-6">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtPai">Pai</label>
                                                                           <fmk:CustomTextBox ID="txtPai" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="24"
                                                                              placeholder="Nome do Pai"
                                                                              BindSelectedType="Message"
                                                                              Required="false"
                                                                              Enabled="true"
                                                                              MaxLength="100"
                                                                              FormatType="Text"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.Pai"
                                                                              BindSourceValue="PropostaModel.Proponente.Pai"></fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>
                                                                  </div>

                                                                  <div class="row">
                                                                     <div class="col-md-12">
                                                                        <div class="mb-12">
                                                                           &nbsp;
                                                                        </div>
                                                                     </div>
                                                                  </div>

                                                                  <div class="row">
                                                                     <div class="col-md-2">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtCelular">Celular</label>
                                                                           <fmk:CustomTextBox ID="txtCelular" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="25"
                                                                              MaxLength="15"
                                                                              placeholder="Celular"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="false"
                                                                              onkeypress="return isNumber(event)"
                                                                              onkeyup="return TelefoneCelular(event, this)"
                                                                              FormatType="Text"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.CelularFormatado"
                                                                              BindSourceValue="PropostaModel.Proponente.CelularFormatado"></fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>
                                                                     <div class="col-md-8">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtEmail">Email</label>
                                                                           <fmk:CustomTextBox ID="txtEmail" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="26"
                                                                              placeholder="Email"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="false"
                                                                              MaxLength="100"
                                                                              FormatType="Text"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.Email"
                                                                              BindSourceValue="PropostaModel.Proponente.Email"></fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>
                                                                     <div class="col-md-2">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="ddlPPE">PEP</label>
                                                                           <fmk:CustomDropDownList
                                                                              ID="ddlPPE"
                                                                              runat="server"
                                                                              CssClass="form-control dropdown-toggle select2-selection form-select"
                                                                              TabIndex="27"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="true"
                                                                              BindSourceType="Message"
                                                                              BindSelectedValue="PropostaModel.Proponente.PPE"
                                                                              DefaultSelectedItem="(Selecione a Nacionalidade)">
                                                                              <asp:ListItem Text="Sim" Value="True"></asp:ListItem>
                                                                              <asp:ListItem Text="Não" Value="False" Selected></asp:ListItem>
                                                                           </fmk:CustomDropDownList>
                                                                        </div>
                                                                     </div>
                                                                  </div>
                                                               </div>
                                                            </div>
                                                         </div>
                                                      </div>
                                                   </div>
                                                   <!-- /Dados Basicos -->

                                                   <!-- Dados Residenciais -->
                                                   <div class="accordion-item">
                                                      <h2 class="accordion-header" id="headingDadosResidenciais">
                                                         <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapseDadosResidenciais" aria-expanded="false" aria-controls="collapseDadosResidenciais">
                                                            <strong>Dados Residenciais</strong>
                                                         </button>
                                                      </h2>

                                                      <div id="collapseDadosResidenciais" class="accordion-collapse collapse show" aria-labelledby="headingDadosResidenciais" data-bs-parent="#accordionCliente" style="">
                                                         <div class="accordion-body">
                                                            <div class="card">
                                                               <div class="card-body">

                                                                  <div class="row">
                                                                     <div class="col-md-2">
                                                                        <div class="mb-3">
                                                                           <label class="form-label" for="txtCEPResidencial">CEP</label>
                                                                           <fmk:CustomTextBox ID="txtCEPResidencial" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="28"
                                                                              placeholder="CEP"
                                                                              BindSelectedType="Message"
                                                                              Required="false"
                                                                              Enabled="true"
                                                                              MaxLength="9"
                                                                              FormatType="Integer"
                                                                              onblur="BuscaCEP(this, 'R');"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.CEPResidencial"
                                                                              BindSourceValue="PropostaModel.Proponente.CEPResidencial"></fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>

                                                                     <div class="col-md-6">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtEnderecoResidencial">Endereço</label>
                                                                           <fmk:CustomTextBox ID="txtEnderecoResidencial" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="29"
                                                                              placeholder="Endereço"
                                                                              BindSelectedType="Message"
                                                                              Required="false"
                                                                              Enabled="true"
                                                                              MaxLength="100"
                                                                              FormatType="Text"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.EnderecoResidencial"
                                                                              BindSourceValue="PropostaModel.Proponente.EnderecoResidencial"></fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>

                                                                     <div class="col-md-1">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtNumeroResidencial">Número</label>
                                                                           <fmk:CustomTextBox ID="txtNumeroResidencial" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="30"
                                                                              placeholder="Número"
                                                                              BindSelectedType="Message"
                                                                              Required="false"
                                                                              Enabled="true"
                                                                              MaxLength="8"
                                                                              FormatType="Text"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.NumeroResidencial"
                                                                              BindSourceValue="PropostaModel.Proponente.NumeroResidencial"></fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>

                                                                     <div class="col-md-3">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtComplementoResidencial">Complemento</label>
                                                                           <fmk:CustomTextBox ID="txtComplementoResidencial" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="31"
                                                                              placeholder="Complemento"
                                                                              BindSelectedType="Message"
                                                                              Required="false"
                                                                              Enabled="true"
                                                                              MaxLength="50"
                                                                              FormatType="Text"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.ComplementoResidencial"
                                                                              BindSourceValue="PropostaModel.Proponente.ComplementoResidencial"></fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>


                                                                  </div>

                                                                  <div class="row">
                                                                     <div class="col-md-4">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtBairroResidencial">Bairro</label>
                                                                           <fmk:CustomTextBox ID="txtBairroResidencial" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="32"
                                                                              placeholder="Bairro"
                                                                              BindSelectedType="Message"
                                                                              Required="false"
                                                                              Enabled="true"
                                                                              MaxLength="50"
                                                                              FormatType="Text"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.BairroResidencial"
                                                                              BindSourceValue="PropostaModel.Proponente.BairroResidencial"></fmk:CustomTextBox>
                                                                        </div>


                                                                     </div>
                                                                     <div class="col-md-5">

                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtCidadeResidencial">Cidade</label>
                                                                           <fmk:CustomTextBox ID="txtCidadeResidencial" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="33"
                                                                              placeholder="Cidade"
                                                                              BindSelectedType="Message"
                                                                              Required="false"
                                                                              Enabled="true"
                                                                              MaxLength="50"
                                                                              FormatType="Text"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.CidadeResidencial"
                                                                              BindSourceValue="PropostaModel.Proponente.CidadeResidencial"></fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>
                                                                     <div class="col-md-1">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtEstadoResidencial">Estado</label>
                                                                           <fmk:CustomTextBox ID="txtEstadoResidencial" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="34"
                                                                              placeholder="UF"
                                                                              BindSelectedType="Message"
                                                                              Required="false"
                                                                              Enabled="true"
                                                                              MaxLength="2"
                                                                              FormatType="Text"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.EstadoResidencial"
                                                                              BindSourceValue="PropostaModel.Proponente.EstadoResidencial"></fmk:CustomTextBox>
                                                                        </div>

                                                                     </div>
                                                                     <div class="col-md-2">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtTelefoneResidencial">Telefone</label>
                                                                           <fmk:CustomTextBox ID="txtTelefoneResidencial" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="35"
                                                                              MaxLength="15"
                                                                              placeholder="Nº Telefone"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="true"
                                                                              onkeypress="return isNumber(event)"
                                                                              onkeyup="return TelefoneCelular(event, this)"
                                                                              FormatType="Text"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.TelefoneResidencial"
                                                                              BindSourceValue="PropostaModel.Proponente.TelefoneResidencial"></fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>
                                                                  </div>
                                                               </div>
                                                            </div>
                                                         </div>
                                                      </div>

                                                   </div>
                                                   <!-- /Dados Residenciais -->

                                                   <!-- Dados Comerciais -->
                                                   <div class="accordion-item">
                                                      <h2 class="accordion-header" id="headingDadosComerciais">
                                                         <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapseDadosComerciais" aria-expanded="false" aria-controls="collapseDadosComerciais">
                                                            <strong>Dados Comerciais</strong>
                                                         </button>
                                                      </h2>
                                                      <div id="collapseDadosComerciais" class="accordion-collapse collapse show" aria-labelledby="headingDadosComerciais" data-bs-parent="#accordionCliente" style="">
                                                         <div class="accordion-body">
                                                            <div class="card">
                                                               <div class="card-body">
                                                                  <div class="row">
                                                                     <div class="col-md-8">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtEmpresa">Empresa</label>
                                                                           <fmk:CustomTextBox ID="txtEmpresa" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="36"
                                                                              placeholder="Empresa"
                                                                              BindSelectedType="Message"
                                                                              Required="false"
                                                                              Enabled="true"
                                                                              MaxLength="100"
                                                                              FormatType="Text"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.NomeEmpresa"
                                                                              BindSourceValue="PropostaModel.Proponente.NomeEmpresa"></fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>

                                                                     <div class="col-md-4">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtCargo">Cargo</label>
                                                                           <fmk:CustomTextBox ID="txtCargo" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="37"
                                                                              placeholder="Cargo"
                                                                              BindSelectedType="Message"
                                                                              Required="false"
                                                                              Enabled="true"
                                                                              MaxLength="100"
                                                                              FormatType="Text"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.Cargo"
                                                                              BindSourceValue="PropostaModel.Proponente.Cargo"></fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>

                                                                  </div>

                                                                  <div class="row">
                                                                     <div class="col-md-12">
                                                                        <div class="mb-12">
                                                                           &nbsp;
                                                                        </div>
                                                                     </div>
                                                                  </div>

                                                                  <div class="row">
                                                                     <div class="col-md-12">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="ddlOcupacao">Ocupação</label>
                                                                           <fmk:CustomDropDownList
                                                                              ID="ddlOcupacao"
                                                                              runat="server"
                                                                              CssClass="form-control dropdown-toggle select2-selection form-select"
                                                                              TabIndex="38"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="true"
                                                                              BindSourceType="Message"
                                                                              BindSelectedValue="PropostaModel.Proponente.CBO"
                                                                              DefaultSelectedItem="(Selecione a Ocupação)"
                                                                              BindSourceText="RamoAtividade.Descricao"
                                                                              BindSourceValue="RamoAtividade.Id">
                                                                           </fmk:CustomDropDownList>
                                                                        </div>
                                                                     </div>
                                                                  </div>

                                                                  <div class="row">
                                                                     <div class="col-md-12">
                                                                        <div class="mb-12">
                                                                           &nbsp;
                                                                        </div>
                                                                     </div>
                                                                  </div>

                                                                  <div class="row">
                                                                     <div class="col-md-8">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="ddlOrgao">Orgão</label>
                                                                           <fmk:CustomDropDownList
                                                                              ID="ddlOrgao"
                                                                              runat="server"
                                                                              CssClass="form-control dropdown-toggle select2-selection form-select"
                                                                              TabIndex="40"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="false"
                                                                              BindSourceType="Message"
                                                                              BindSelectedValue="PropostaModel.Proponente.Orgao"
                                                                              DefaultSelectedItem="(Selecione o Orgão)"
                                                                              BindSourceText="OrgaosSIAPE.DescricaoExibicao"
                                                                              BindSourceValue="OrgaosSIAPE.Codigo">
                                                                           </fmk:CustomDropDownList>
                                                                        </div>
                                                                     </div>

                                                                     <div class="col-md-2">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtNumeroBeneficio">N° Beneficio</label>
                                                                           <fmk:CustomTextBox ID="txtNumeroBeneficio" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="41"
                                                                              MaxLength="20"
                                                                              placeholder="N° Beneficio"
                                                                              BindSelectedType="Message"
                                                                              Required="true"
                                                                              Enabled="false"
                                                                              FormatType="Integer"
                                                                              onkeypress="return isNumber(event)"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.NumeroBeneficio"
                                                                              BindSourceValue="PropostaModel.Proponente.NumeroBeneficio">
                                                                           </fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>

                                                                     <div class="col-md-2" runat="server" visible="false" id="divInstituidor">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtInstituidor">Instituidor</label>
                                                                           <fmk:CustomTextBox ID="txtInstituidor" runat="server"
                                                                              CssClass="form-control"
                                                                              TabIndex="42"
                                                                              placeholder="Instituidor"
                                                                              BindSelectedType="Message"
                                                                              MaxLength="20"
                                                                              Visible="true"
                                                                              Required="false"
                                                                              Enabled="false"
                                                                              FormatType="Integer"
                                                                              onkeypress="return isNumber(event)"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.NumeroBeneficio2"
                                                                              BindSourceValue="PropostaModel.Proponente.NumeroBeneficio2">
                                                                           </fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>
                                                                  </div>

                                                                  <div class="row">
                                                                     <div class="col-md-12">
                                                                        <div class="mb-12">
                                                                           &nbsp;
                                                                        </div>
                                                                     </div>
                                                                  </div>

                                                                  <div class="row">
                                                                     <div class="col-md-2">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtRendimentos">Rendimentos</label>
                                                                           <fmk:CustomTextBox ID="txtRendimentos" runat="server"
                                                                              CssClass="form-control format-decimal-18-2"
                                                                              TabIndex="45"
                                                                              placeholder="Valor dos Rendimentos"
                                                                              BindSelectedType="Message"
                                                                              Required="false"
                                                                              Enabled="true"
                                                                              MaxLength="11"
                                                                              FormatType="Decimal"
                                                                              NumericLength="18"
                                                                              NumericPrecision="2"
                                                                              onkeypress="return isNumber(event)"
                                                                              Style="text-align: right"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.ValorRenda"
                                                                              BindSourceValue="PropostaModel.Proponente.ValorRenda">
                                                                           </fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>
                                                                     <div class="col-md-2">
                                                                        <div class="mb-12">
                                                                           <label class="form-label" for="txtOutrosRendimentos">Outros Rendimentos</label>
                                                                           <fmk:CustomTextBox ID="txtOutrosRendimentos" runat="server"
                                                                              CssClass="form-control format-decimal-18-2"
                                                                              TabIndex="46"
                                                                              placeholder="Valor dos Outros Rendimentos"
                                                                              BindSelectedType="Message"
                                                                              Required="false"
                                                                              Enabled="true"
                                                                              MaxLength="11"
                                                                              FormatType="Decimal"
                                                                              NumericLength="18"
                                                                              NumericPrecision="2"
                                                                              onkeypress="return isNumber(event)"
                                                                              Style="text-align: right"
                                                                              onpaste="return false;"
                                                                              autocomplete="off"
                                                                              BindSourceType="Message"
                                                                              BindSourceText="PropostaModel.Proponente.ValorOutrasRendas"
                                                                              BindSourceValue="PropostaModel.Proponente.ValorOutrasRendas">
                                                                           </fmk:CustomTextBox>
                                                                        </div>
                                                                     </div>
                                                                     <div class="col-md-8">
                                                                        <div class="mb-12">
                                                                        </div>
                                                                     </div>
                                                                  </div>
                                                               </div>
                                                            </div>
                                                         </div>
                                                      </div>
                                                   </div>
                                                   <!-- /Dados Comerciais -->
                                                </div>

                                             </div>
                                          </div>
                                       </div>
                                    </div>
                                 </div>
                              </div>
                              <!-- /Informações do Cliente -->
                              <!-- Contratos Refinanciados -->
                              <div id="divContratosRefin" runat="server" visible="false">
                                 <div class="accordion-item">
                                    <h2 class="accordion-header" id="headingContratosRefinanciados">
                                       <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseContratosRefinanciados" aria-expanded="false" aria-controls="collapseContratosRefinanciados">
                                          <strong>Contratos Refinanciados</strong>
                                       </button>
                                    </h2>
                                    <div id="collapseContratosRefinanciados" class="accordion-collapse collapse" aria-labelledby="headingContratosRefinanciados" data-bs-parent="#accordionProposta">
                                       <div class="accordion-body">
                                          <div class="card">
                                             <div class="card-body">
                                                <asp:Repeater ID="ContratosRepeater" runat="server" OnItemDataBound="ContratosRepeater_ItemDataBound">
                                                   <HeaderTemplate>
                                                      <table class="table table-centered table-nowrap mb-0 no-footer dtr-inline nowrap table-card-list dt-responsive DataTables" style="width: 99%;" id="tabelaContratosREFIN">
                                                         <thead class="table-light">
                                                            <tr>
                                                               <th>Contrato</th>
                                                               <th>Emissão</th>
                                                               <th>Vencimento</th>
                                                               <th>Dias Atraso</th>
                                                               <th>Prazo</th>
                                                               <th>Valor Contrato</th>
                                                               <th>Taxa Mensal</th>
                                                               <th>Valor Parcela</th>
                                                               <th>Saldo Devedor</th>
                                                            </tr>
                                                         </thead>
                                                         <tbody>
                                                   </HeaderTemplate>
                                                   <ItemTemplate>
                                                      <tr>
                                                         <td style="text-align: center;"><%# Eval("Contrato") %></td>
                                                         <td style="text-align: center;"><%# Eval("Emissao", "{0:dd/MM/yyyy}") %></td>
                                                         <td style="text-align: center;"><%# Eval("Vencimento", "{0:dd/MM/yyyy}") %></td>
                                                         <td style="text-align: center;"><%# Eval("DiasAtraso") %></td>
                                                         <td style="text-align: center;"><%# Eval("Prazo") %></td>
                                                         <td style="text-align: right;"><%# Eval("ValorContrato", "{0:c}") %></td>
                                                         <td style="text-align: right;"><%# Eval("TaxaMensal", "{0:#.00}") %></td>
                                                         <td style="text-align: center;"><%# Eval("ParcelasEmAberto") %></td>
                                                         <td style="text-align: right;"><%# Eval("ValorParcela", "{0:c}") %></td>
                                                         <td style="text-align: right;"><%# Eval("SaldoDevedor", "{0:c}") %></td>
                                                      </tr>
                                                   </ItemTemplate>
                                                   <FooterTemplate>
                                                      </tbody>
</table>
                                                   </FooterTemplate>
                                                </asp:Repeater>
                                             </div>
                                          </div>
                                       </div>
                                    </div>
                                 </div>
                              </div>
                              <!-- Contratos Refinanciados -->
                              <!-- Dados da Operação -->
                              <div class="accordion-item">
                                 <h2 class="accordion-header" id="headingDadosOperacao">
                                    <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseDadosOperacao" aria-expanded="false" aria-controls="collapseDadosOperacao">
                                       <strong>Dados da Operação</strong>
                                    </button>
                                 </h2>
                                 <div id="collapseDadosOperacao" class="accordion-collapse collapse" aria-labelledby="headingDadosOperacao" data-bs-parent="#accordionProposta">
                                    <div class="accordion-body">
                                       <div class="card">
                                          <div class="card-body">
                                             <div class="row">
                                                <!-- Lado Esquerdo -->
                                                <div class="col-md-6">
                                                   <div class="mb-12">
                                                      <div class="card">
                                                         <div class="card-body">
                                                            <div class="row">
                                                               <div class="col-md-6">
                                                                  <div class="mb-12">
                                                                     <label class="input-sm" for="lblDataLiberacaoPopUpSimulacaoOperacao">Data de Liberação</label>
                                                                  </div>
                                                               </div>
                                                               <div class="col-md-6" style="text-align: right;">
                                                                  <div class="mb-12">
                                                                     <fmk:CustomLabel
                                                                        ID="lblDataLiberacaoPopUpSimulacaoOperacao"
                                                                        runat="server"
                                                                        CssClass="uppercase"
                                                                        FormatType="Text"
                                                                        ValidatorDisplay="Dynamic"
                                                                        BindSourceText="PropostaModel.Operacoes.DataEmissaoFormatada"
                                                                        BindSourceType="Message"
                                                                        Enabled="false"
                                                                        Style="text-align: right; font-weight: bold;" />
                                                                  </div>
                                                               </div>
                                                            </div>

                                                            <div class="row">
                                                               <div class="col-md-6">
                                                                  <label class="input-sm" for="lblDataPrimeiroVencimentoPopUpSimulacaoOperacao">Primeiro Vencimento</label>
                                                               </div>
                                                               <div class="col-md-6" style="text-align: right;">
                                                                  <div class="mb-12">

                                                                     <fmk:CustomLabel
                                                                        ID="lblDataPrimeiroVencimentoPopUpSimulacaoOperacao"
                                                                        runat="server"
                                                                        CssClass="uppercase"
                                                                        FormatType="Text"
                                                                        ValidatorDisplay="Dynamic"
                                                                        BindSourceText="PropostaModel.Operacoes.DataPrimeiroVencimentoFormatada"
                                                                        BindSourceType="Message"
                                                                        Enabled="false"
                                                                        Style="text-align: right; font-weight: bold;" />
                                                                  </div>
                                                               </div>
                                                            </div>

                                                            <div class="row">
                                                               <div class="col-md-6">
                                                                  <label class="input-sm" for="lblValorFinanciadoTotalPopUpSimulacaoOperacao">Valor Financiado</label>
                                                               </div>
                                                               <div class="col-md-6" style="text-align: right;">
                                                                  <div class="mb-12">
                                                                     <fmk:CustomLabel
                                                                        ID="lblValorFinanciadoTotalPopUpSimulacaoOperacao"
                                                                        runat="server"
                                                                        CssClass="uppercase"
                                                                        FormatType="Text"
                                                                        ValidatorDisplay="Dynamic"
                                                                        BindSourceText="PropostaModel.Operacoes.ValorFinanciadoTotalFormatado"
                                                                        BindSourceType="Message"
                                                                        Enabled="false"
                                                                        Style="text-align: right; font-weight: bold;" />
                                                                  </div>
                                                               </div>
                                                            </div>

                                                            <div class="row">
                                                               <div class="col-md-6">
                                                                  <label class="input-sm" for="lblValorEntradaPopUpSimulacaoOperacao">Valor Entrada</label>
                                                               </div>
                                                               <div class="col-md-6" style="text-align: right;">
                                                                  <div class="mb-12">
                                                                     <fmk:CustomLabel
                                                                        ID="lblValorEntradaPopUpSimulacaoOperacao"
                                                                        runat="server"
                                                                        CssClass="uppercase"
                                                                        FormatType="Text"
                                                                        ValidatorDisplay="Dynamic"
                                                                        BindSourceText="PropostaModel.Operacoes.ValorEntradaFormatado"
                                                                        BindSourceType="Message"
                                                                        Enabled="false"
                                                                        Style="text-align: right; font-weight: bold;" />
                                                                  </div>
                                                               </div>
                                                            </div>

                                                            <div class="row">
                                                               <div class="col-md-6">
                                                                  <label class="input-sm" for="lblValorLiberadoPopUpSimulacaoOperacao">Valor Liberado</label>
                                                               </div>
                                                               <div class="col-md-6" style="text-align: right;">
                                                                  <div class="mb-12">
                                                                     <fmk:CustomLabel
                                                                        ID="lblValorLiberadoPopUpSimulacaoOperacao"
                                                                        runat="server"
                                                                        CssClass="uppercase"
                                                                        FormatType="Text"
                                                                        ValidatorDisplay="Dynamic"
                                                                        BindSourceText="PropostaModel.Operacoes.ValorLiberadoFormatado"
                                                                        BindSourceType="Message"
                                                                        Enabled="false"
                                                                        Style="text-align: right; color: blue; font-weight: bold;" />
                                                                  </div>
                                                               </div>
                                                            </div>

                                                            <div class="row">
                                                               <div class="col-md-6">
                                                                  <label class="input-sm" for="lblQtdParcelas">Quantidade de Parcelas</label>
                                                               </div>
                                                               <div class="col-md-6" style="text-align: right;">
                                                                  <div class="mb-12">
                                                                     <fmk:CustomLabel
                                                                        ID="lblQtdParcelas"
                                                                        runat="server"
                                                                        CssClass="uppercase"
                                                                        FormatType="Text"
                                                                        ValidatorDisplay="Dynamic"
                                                                        BindSourceText="PropostaModel.Operacoes.Prazo"
                                                                        BindSourceType="Message"
                                                                        Enabled="false"
                                                                        Style="text-align: right; font-weight: bold;" />
                                                                  </div>
                                                               </div>
                                                            </div>

                                                            <div class="row">
                                                               <div class="col-md-6">
                                                                  <label class="input-sm" for="lblValorParcela">Valor Parcela</label>
                                                               </div>
                                                               <div class="col-md-6" style="text-align: right;">
                                                                  <div class="mb-12">
                                                                     <fmk:CustomLabel
                                                                        ID="lblValorParcela"
                                                                        runat="server"
                                                                        CssClass="uppercase"
                                                                        FormatType="Text"
                                                                        ValidatorDisplay="Dynamic"
                                                                        BindSourceText="PropostaModel.Operacoes.ValorParcela"
                                                                        BindSourceType="Message"
                                                                        Enabled="false"
                                                                        Style="text-align: right; font-weight: bold;" />
                                                                  </div>
                                                               </div>
                                                            </div>

                                                            <div class="row">
                                                               <div class="col-md-6">
                                                                  <label class="input-sm" for="lblValorSeguroPopUpSimulacaoOperacao">Valor Seguro</label>
                                                               </div>
                                                               <div class="col-md-6" style="text-align: right;">
                                                                  <div class="mb-12">
                                                                     <fmk:CustomLabel
                                                                        ID="lblValorSeguroPopUpSimulacaoOperacao"
                                                                        runat="server"
                                                                        CssClass="uppercase"
                                                                        FormatType="Text"
                                                                        ValidatorDisplay="Dynamic"
                                                                        BindSourceText="PropostaModel.Operacoes.ValorSeguroFormatado"
                                                                        BindSourceType="Message"
                                                                        Enabled="false"
                                                                        Style="text-align: right; font-weight: bold;" />
                                                                  </div>
                                                               </div>
                                                            </div>
                                                         </div>
                                                      </div>
                                                   </div>
                                                </div>
                                                <!-- /Lado Esquerdo -->

                                                <!-- Lado Direito -->
                                                <div class="col-md-6">
                                                   <div class="mb-12">
                                                      <div class="card">
                                                         <div class="card-body">
                                                            <div class="row">
                                                               <div class="col-md-6">
                                                                  <div class="mb-12">
                                                                     <label class="input-sm" id="label2" runat="server" for="lblValorTAC">Valor TAC</label>
                                                                  </div>
                                                               </div>
                                                               <div class="col-md-6" style="text-align: right;">
                                                                  <div class="mb-12">
                                                                     <fmk:CustomLabel
                                                                        ID="txtValorTAC"
                                                                        runat="server"
                                                                        CssClass="uppercase"
                                                                        FormatType="Text"
                                                                        ValidatorDisplay="Dynamic"
                                                                        BindSourceText="PropostaModel.Operacoes.ValorTACFormatado"
                                                                        BindSourceType="Message"
                                                                        Enabled="false"
                                                                        Style="text-align: right; font-weight: bold;" />
                                                                  </div>
                                                               </div>
                                                            </div>

                                                            <div class="row">
                                                               <div class="col-md-6">
                                                                  <label class="input-sm" for="lblValorTFC">Valor TFC</label>
                                                               </div>
                                                               <div class="col-md-6" style="text-align: right;">
                                                                  <div class="mb-12">
                                                                     <fmk:CustomLabel
                                                                        ID="txtValorTF"
                                                                        runat="server"
                                                                        CssClass="uppercase"
                                                                        FormatType="Text"
                                                                        ValidatorDisplay="Dynamic"
                                                                        BindSourceText="PropostaModel.Operacoes.ValorTFCFormatado"
                                                                        BindSourceType="Message"
                                                                        Enabled="false"
                                                                        Style="text-align: right; font-weight: bold;" />
                                                                  </div>
                                                               </div>
                                                            </div>

                                                            <div class="row">
                                                               <div class="col-md-6">
                                                                  <label class="input-sm" for="lblValorPST">Valor PST</label>
                                                               </div>
                                                               <div class="col-md-6" style="text-align: right;">
                                                                  <div class="mb-12">
                                                                     <fmk:CustomLabel
                                                                        ID="txtValorPST"
                                                                        runat="server"
                                                                        CssClass="uppercase"
                                                                        FormatType="Text"
                                                                        ValidatorDisplay="Dynamic"
                                                                        BindSourceText="PropostaModel.Operacoes.ValorPSTFormatado"
                                                                        BindSourceType="Message"
                                                                        Enabled="false"
                                                                        Style="text-align: right; font-weight: bold;" />
                                                                  </div>
                                                               </div>
                                                            </div>

                                                            <div class="row">
                                                               <div class="col-md-6">
                                                                  <label class="input-sm" for="lblValorIOF">Valor IOF</label>
                                                               </div>
                                                               <div class="col-md-6" style="text-align: right;">
                                                                  <div class="mb-12">
                                                                     <fmk:CustomLabel
                                                                        ID="lblValorIOF"
                                                                        runat="server"
                                                                        CssClass="uppercase"
                                                                        FormatType="Text"
                                                                        ValidatorDisplay="Dynamic"
                                                                        BindSourceText="PropostaModel.Operacoes.ValorIOFFormatado"
                                                                        BindSourceType="Message"
                                                                        Enabled="false"
                                                                        Style="text-align: right; font-weight: bold;" />
                                                                  </div>
                                                               </div>
                                                            </div>

                                                            <div class="row">
                                                               <div class="col-md-6">
                                                                  <label class="input-sm" for="lblTaxaMes">Taxa Mês</label>
                                                               </div>
                                                               <div class="col-md-6" style="text-align: right;">
                                                                  <div class="mb-12">
                                                                     <fmk:CustomLabel
                                                                        ID="txtTaxaMes"
                                                                        runat="server"
                                                                        CssClass="uppercase"
                                                                        FormatType="Text"
                                                                        ValidatorDisplay="Dynamic"
                                                                        BindSourceText="PropostaModel.Operacoes.TaxaMesFormatado"
                                                                        BindSourceType="Message"
                                                                        Enabled="false"
                                                                        Style="text-align: right; font-weight: bold;" />
                                                                  </div>
                                                               </div>
                                                            </div>

                                                            <div class="row">
                                                               <div class="col-md-6">
                                                                  <label class="input-sm" for="lblTaxaAno">Taxa Ano</label>
                                                               </div>
                                                               <div class="col-md-6" style="text-align: right;">
                                                                  <div class="mb-12">
                                                                     <fmk:CustomLabel
                                                                        ID="txtTaxaAno"
                                                                        runat="server"
                                                                        CssClass="uppercase"
                                                                        FormatType="Text"
                                                                        ValidatorDisplay="Dynamic"
                                                                        BindSourceText="PropostaModel.Operacoes.TaxaAnoFormatado"
                                                                        BindSourceType="Message"
                                                                        Enabled="false"
                                                                        Style="text-align: right; font-weight: bold;" />
                                                                  </div>
                                                               </div>
                                                            </div>

                                                            <div class="row">
                                                               <div class="col-md-6">
                                                                  <label class="input-sm" for="lblCETMes">CET Mês</label>
                                                               </div>
                                                               <div class="col-md-6" style="text-align: right;">
                                                                  <div class="mb-12">
                                                                     <fmk:CustomLabel
                                                                        ID="lblCETMes"
                                                                        runat="server"
                                                                        CssClass="uppercase"
                                                                        FormatType="Text"
                                                                        ValidatorDisplay="Dynamic"
                                                                        BindSourceText="PropostaModel.Operacoes.CETMesFormatado"
                                                                        BindSourceType="Message"
                                                                        Enabled="false"
                                                                        Style="text-align: right; font-weight: bold;" />

                                                                  </div>
                                                               </div>
                                                            </div>

                                                            <div class="row">
                                                               <div class="col-md-6">
                                                                  <label class="input-sm" for="lblCETAno">CET Ano</label>
                                                               </div>
                                                               <div class="col-md-6" style="text-align: right;">
                                                                  <div class="mb-12">
                                                                     <fmk:CustomLabel
                                                                        ID="lblCETAno"
                                                                        runat="server"
                                                                        CssClass="uppercase"
                                                                        FormatType="Text"
                                                                        ValidatorDisplay="Dynamic"
                                                                        BindSourceText="PropostaModel.Operacoes.CETAnoFormatado"
                                                                        BindSourceType="Message"
                                                                        Enabled="false"
                                                                        Style="text-align: right; font-weight: bold;" />
                                                                  </div>
                                                               </div>
                                                            </div>
                                                         </div>
                                                      </div>
                                                   </div>
                                                </div>
                                                <!-- /Lado Direito -->
                                             </div>

                                          </div>
                                       </div>
                                    </div>
                                 </div>
                              </div>
                              <!-- /Dados da Operação -->
                              <!-- Meio de Liberação -->
                              <div class="accordion-item">
                                 <h2 class="accordion-header" id="headingMeioLiberacao">
                                    <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseMeioLiberacao" aria-expanded="false" aria-controls="collapseMeioLiberacao">
                                       <strong>Meio de Liberação</strong>
                                    </button>
                                 </h2>
                                 <div id="collapseMeioLiberacao" class="accordion-collapse collapse" aria-labelledby="headingMeioLiberacao" data-bs-parent="#accordionProposta">
                                    <div class="accordion-body">
                                       <div class="col-xl-12">
                                          <div class="card">
                                             <div class="card-body">
                                                <div class="row">
                                                   <div class="col-md-3">
                                                      <div class="mb-12">
                                                         <label class="form-label" for="ddlMeioLiberacao">Meio de Liberação</label>
                                                         <fmk:CustomDropDownList
                                                            ID="ddlMeioLiberacao"
                                                            runat="server"
                                                            CssClass="form-control dropdown-toggle select2-selection form-select"
                                                            TabIndex="400"
                                                            BindSelectedType="Message"
                                                            Required="true"
                                                            Enabled="true"
                                                            AutoPostBack="true"
                                                            OnSelectedIndexChanged="ddlMeioLiberacao_SelectedIndexChanged"
                                                            BindSourceType="Message"
                                                            BindSelectedValue="PropostaModel.Operacoes.MeioLiberacao"
                                                            DefaultSelectedItem="(Selecione o Meio de Liberação)"
                                                            BindSourceText="MeiosLiberacao.Descricao"
                                                            BindSourceValue="MeiosLiberacao.Id">
                                                         </fmk:CustomDropDownList>
                                                      </div>
                                                   </div>
                                                   <div class="col-md-1" id="divBancoLiberacao" runat="server" visible="false">
                                                      <div class="mb-12">
                                                         <label class="form-label" for="txtBancoLiberacao" id="lblBancoLiberacao" runat="server" visible="false">Banco</label>
                                                         <fmk:CustomTextBox ID="txtBancoLiberacao" runat="server"
                                                            CssClass="form-control"
                                                            TabIndex="401"
                                                            MaxLength="4"
                                                            placeholder="Banco"
                                                            BindSelectedType="Message"
                                                            Required="true"
                                                            Enabled="true"
                                                            Visible="false"
                                                            FormatType="Integer"
                                                            onkeypress="return isNumber(event)"
                                                            onpaste="return false;"
                                                            autocomplete="off"
                                                            BindSourceType="Message"
                                                            BindSourceText="PropostaModel.Operacoes.Banco"
                                                            BindSourceValue="PropostaModel.Operacoes.Banco">
                                                         </fmk:CustomTextBox>
                                                      </div>
                                                   </div>

                                                   <div class="col-md-1" id="divAgenciaLiberacao" runat="server" visible="false">
                                                      <div class="mb-12">
                                                         <label class="form-label" for="txtAgenciaLiberacao" id="lblAgenciaLiberacao" runat="server" visible="false">Agência</label>
                                                         <fmk:CustomTextBox ID="txtAgenciaLiberacao" runat="server"
                                                            CssClass="form-control"
                                                            TabIndex="402"
                                                            MaxLength="4"
                                                            placeholder="Agência"
                                                            BindSelectedType="Message"
                                                            Required="true"
                                                            Enabled="true"
                                                            Visible="false"
                                                            FormatType="Integer"
                                                            onkeypress="return isNumber(event)"
                                                            onpaste="return false;"
                                                            autocomplete="off"
                                                            BindSourceType="Message"
                                                            BindSourceText="PropostaModel.Operacoes.Agencia"
                                                            BindSourceValue="PropostaModel.Operacoes.Agencia">
                                                         </fmk:CustomTextBox>
                                                      </div>
                                                   </div>

                                                   <div class="col-md-3" id="divContaLiberacao" runat="server" visible="false">
                                                      <div class="mb-12">
                                                         <label class="form-label" for="txtContaLiberacao" id="lblContaLiberacao" runat="server" visible="false">Conta</label>
                                                         <fmk:CustomTextBox ID="txtContaLiberacao" runat="server"
                                                            CssClass="form-control"
                                                            TabIndex="403"
                                                            MaxLength="15"
                                                            placeholder="Conta"
                                                            BindSelectedType="Message"
                                                            Required="true"
                                                            Enabled="true"
                                                            Visible="false"
                                                            FormatType="Integer"
                                                            onkeypress="return isNumber(event)"
                                                            onpaste="return false;"
                                                            autocomplete="off"
                                                            BindSourceType="Message"
                                                            BindSourceText="PropostaModel.Operacoes.Conta"
                                                            BindSourceValue="PropostaModel.Operacoes.Conta">
                                                         </fmk:CustomTextBox>
                                                      </div>
                                                   </div>

                                                   <div class="col-md-4" id="divChavePIX" runat="server" visible="false">
                                                      <div class="mb-12">
                                                         <label class="form-label" for="txtChavePIX" id="lblChavePIX" runat="server" visible="false">Chave</label>
                                                         <fmk:CustomTextBox ID="txtChavePIX" runat="server"
                                                            CssClass="form-control"
                                                            TabIndex="403"
                                                            MaxLength="250"
                                                            placeholder="Conta"
                                                            BindSelectedType="Message"
                                                            Required="true"
                                                            Enabled="true"
                                                            Visible="false"
                                                            FormatType="Text"
                                                            onpaste="return false;"
                                                            autocomplete="off"
                                                            BindSourceType="Message"
                                                            BindSourceText="PropostaModel.Operacoes.ChavePIX"
                                                            BindSourceValue="PropostaModel.Operacoes.ChavePIX">
                                                         </fmk:CustomTextBox>
                                                      </div>
                                                   </div>
                                                </div>
                                             </div>
                                          </div>
                                       </div>
                                    </div>
                                 </div>
                              </div>
                              <!-- /Meio de Liberação -->
                           </div>
                        </div>
                        <!-- /Proposta -->
                        <!-- Resultado das Consultas -->
                        <div class="tab-pane fade" id="tabConsultas" role="tabpanel" aria-labelledby="tabConsultas-tab">
                           <div class="accordion-body">
                              <div class="card">
                                 <div class="card-body">
                                    <asp:TreeView ID="treeConsultas" NodeWrap="true" runat="server" Style="display: inline-block;"></asp:TreeView>
                                 </div>
                              </div>
                           </div>
                        </div>
                        <!-- /Resultado das Consultas -->
                        <!-- Ocorrências -->
                        <div class="tab-pane fade" id="tabOcorrencias" role="tabpanel" aria-labelledby="tabOcorrencias-tab">
                           <div class="accordion-body">
                              <div class="card">
                                 <div class="card-body">
                                    <div class="row">
                                       <div class="col-lg-12">
                                          <div class="mt-12">
                                             <div class="d-flex flex-wrap gap-3 mt-3 mx-auto">
                                                <fmk:CustomLinkButton ID="btnAdicionarOcorrencia" runat="server" class="btn btn-warning waves-effect" CausesValidation="false" OnClick="btnAdicionarOcorrencia_Click">Incluir Ocorrência</fmk:CustomLinkButton>
                                             </div>
                                             <div class="mb-3">
                                             </div>
                                          </div>
                                       </div>
                                    </div>
                                    <div class="row">
                                       <asp:Repeater ID="rptOcorrencias" runat="server" OnItemDataBound="rptOcorrencias_ItemDataBound" OnItemCommand="rptOcorrencias_ItemCommand">
                                          <HeaderTemplate>
                                             <table class="table table-centered table-nowrap mb-0 no-footer dtr-inline nowrap table-card-list dt-responsive DataTables" style="width: 99%;" id="tabelaOcorrencias">
                                                <thead class="table-light">
                                                   <tr>
                                                      <th style="width: 3%;"></th>
                                                      <th style="width: 3%;"></th>
                                                      <th style="width: 3%;"></th>
                                                      <th>Data Ocorrência</th>
                                                      <th>Ocorrência</th>
                                                      <th>Complemento</th>
                                                      <th>Usuário</th>
                                                   </tr>
                                                </thead>
                                                <tbody>
                                          </HeaderTemplate>
                                          <ItemTemplate>
                                             <tr>
                                                <td style="text-align: center; background-color: transparent; padding: 3px; width: 3%; vertical-align: central;">
                                                   <fmk:CustomLinkButton
                                                      ID="lnkVisualizarDetalhesOcorrencia"
                                                      runat="server"
                                                      CssClass="uil uil-eye font-size-16"
                                                      ToolTip="Visualizar"
                                                      CommandName="Visualizar"
                                                      RequiredRole=""
                                                      Style="text-align: left"
                                                      CausesValidation="false"
                                                      OnClick="lnkArquivoDownload_Click"
                                                      CommandArgument='<%# Eval("Id") %>'
                                                      TabIndex="-1">
                                                   </fmk:CustomLinkButton>
                                                </td>
                                                <td style="text-align: center; background-color: transparent; padding: 3px; width: 3%; vertical-align: central;">
                                                   <fmk:CustomLinkButton
                                                      ID="lnkLiberarOcorrencia"
                                                      runat="server"
                                                      CssClass="uil uil-pen font-size-16"
                                                      Width="50%"
                                                      CausesValidation="false"
                                                      Style="text-align: left"
                                                      RequiredRole=""
                                                      CommandName="Liberar"
                                                      CommandArgument='<%# Eval("Id") %>'
                                                      ToolTip="Liberar"
                                                      TabIndex="-1">
                                                   </fmk:CustomLinkButton>
                                                </td>
                                                <td style="text-align: center; background-color: transparent; padding: 3px; width: 3%; vertical-align: central;">
                                                   <fmk:CustomLabel
                                                      ID="lblInformacoes"
                                                      runat="server"
                                                      CssClass='<%# Eval("IconClass") %>'
                                                      Width="50%"
                                                      Style="text-align: center;"
                                                      ToolTip="Informações"
                                                      TabIndex="-1">
                                                   </fmk:CustomLabel>
                                                </td>
                                                <td style="text-align: center;">
                                                   <fmk:CustomLabel ID="lblDataOcorrencia" runat="server" /></td>
                                                <td style="text-align: left;">
                                                   <fmk:CustomLabel ID="lblOcorrencia" runat="server" /></td>
                                                <td style="text-align: left;">
                                                   <fmk:CustomLabel ID="lblComplemento" runat="server" /></td>
                                                <td style="text-align: left;">
                                                   <fmk:CustomLabel ID="lblUsuario" runat="server" /></td>
                                             </tr>
                                          </ItemTemplate>
                                          <FooterTemplate>
                                             </tbody>
</table>
                                          </FooterTemplate>
                                       </asp:Repeater>
                                    </div>
                                 </div>
                              </div>
                           </div>
                        </div>
                        <!-- /Ocorrências -->
                        <!-- Checklist -->
                        <div class="tab-pane fade" id="tabChecklist" role="tabpanel" aria-labelledby="tabChecklist-tab">
                           <div class="accordion-body">
                              <div class="card">
                                 <div class="card-body">
                                    <asp:Repeater ID="rptOcorrenciasCheckList" runat="server">
                                       <HeaderTemplate>
                                          <table class="table table-centered table-nowrap mb-0 no-footer dtr-inline nowrap table-card-list dt-responsive DataTables" style="width: 99%;" id="tabelaChecklist">
                                             <thead class="table-light">
                                                <tr>
                                                   <th style="width: 80%">Descrição</th>
                                                   <th style="width: 3%;">Informações</th>
                                                   <th style="width: 3%;">Liberado</th>
                                                </tr>
                                             </thead>
                                             <tbody>
                                       </HeaderTemplate>
                                       <ItemTemplate>
                                          <tr>
                                             <td style="text-align: left;">
                                                <fmk:CustomLabel ID="lblDescricaoOcorrenciaCheckList" runat="server" /><%# Eval("Descricao") %></td>
                                             <td style="text-align: left;">
                                                <fmk:CustomLabel ID="lblInformacoesCheckList" runat="server" /><i class="uil-info-circle" title="Adicionar o Documento: <%# Eval("DocumentoNecessario") %>" /></td>
                                             <td style="text-align: left;">
                                                <img src='<%# ((int)Eval("Cumprido") > 0) ? "/Imagens/bullet-green.png" : "/Imagens/bullet-red.png"  %>' style="width: 15px; height: 15px;" /></td>
                                          </tr>
                                       </ItemTemplate>
                                       <FooterTemplate>
                                          </tbody>
</table>
                                       </FooterTemplate>
                                    </asp:Repeater>
                                 </div>
                              </div>
                           </div>
                        </div>
                        <!-- /Checklist -->
                        <!-- Trilha de Auditoria -->
                        <div class="tab-pane fade" id="tabTrilhaAuditoria" role="tabpanel" aria-labelledby="tabTrilhaAuditoria-tab">
                           <div class="accordion-body">
                              <div class="card">
                                 <div class="card-body">
                                    <asp:Repeater ID="rptTrilhaAuditoria" runat="server" OnItemDataBound="rptTrilhaAuditoria_ItemDataBound">
                                       <HeaderTemplate>
                                          <table class="table table-centered table-nowrap mb-0 no-footer dtr-inline nowrap table-card-list dt-responsive DataTables" style="width: 99%;" id="tabelaTrilhaAuditoria">
                                             <thead class="table-light">
                                                <tr>
                                                   <th style="width: 15% !important;">Data</th>
                                                   <th style="width: 7%">Fase</th>
                                                   <th style="width: 7%">Tipo</th>
                                                   <th style="width: 71%;">Histórico</th>
                                                </tr>
                                             </thead>
                                             <tbody>
                                       </HeaderTemplate>
                                       <ItemTemplate>
                                          <tr>
                                             <td style="text-align: center; width: 15%;">
                                                <fmk:CustomLabel ID="lblDataLog" runat="server" CssClass="input-sm"></fmk:CustomLabel>
                                             </td>
                                             <td style="text-align: left; padding-left: 5px !important; width: 7%;">
                                                <fmk:CustomLabel ID="lblFaseLog" runat="server" CssClass="input-sm"></fmk:CustomLabel>
                                             </td>
                                             <td style="text-align: left; padding-left: 5px !important; width: 7%;">
                                                <fmk:CustomLabel ID="lblTipoLog" runat="server" CssClass="input-sm"></fmk:CustomLabel>
                                             </td>
                                             <td style="text-align: left; padding-left: 5px !important; width: 71%;">
                                                <fmk:CustomLabel ID="lblLog" runat="server" CssClass="input-sm"></fmk:CustomLabel>
                                             </td>
                                          </tr>
                                       </ItemTemplate>
                                       <FooterTemplate>
                                          </tbody>
</table>
                                       </FooterTemplate>
                                    </asp:Repeater>
                                 </div>
                              </div>
                           </div>
                        </div>
                        <!-- /Trilha de Auditoria -->
                        <!-- Historico -->
                        <div class="tab-pane fade" id="tabHistorico" role="tabpanel" aria-labelledby="tabHistorico-tab">
                           <div class="accordion-body">
                              <div class="accordion-body">
                                 <div class="col-xl-12">
                                    <div class="card">
                                       <div class="card-body">
                                          <div class="row">
                                             <div class="col-md-12">
                                                <div class="mb-12">
                                                   <div class="table-responsive">
                                                      <p id="ConteudoHistoricoAlteracoes" runat="server"></p>
                                                   </div>
                                                </div>
                                             </div>
                                          </div>
                                       </div>
                                    </div>
                                 </div>
                              </div>
                           </div>


                        </div>
                        <!-- /Historico -->
                        <!-- Logs -->
                        <div class="tab-pane fade" id="tabLogs" role="tabpanel" aria-labelledby="tabLogs-tab">
                           <div class="accordion-body">
                              <div class="card">
                                 <div class="card-body">
                                    <asp:Repeater ID="rptLog" runat="server" OnItemDataBound="rptLog_ItemDataBound">
                                       <HeaderTemplate>
                                          <table class="table table-centered table-nowrap mb-0 no-footer dtr-inline nowrap table-card-list dt-responsive DataTables" style="width: 99%;" id="tabelaLog">
                                             <thead class="table-light">
                                                <tr>
                                                   <th style="width: 15% !important;">Data</th>
                                                   <th style="width: 15%">Fase</th>
                                                   <th style="width: 15%">Ação</th>
                                                   <th style="width: 55%;">Usuário</th>
                                                </tr>
                                             </thead>
                                             <tbody>
                                       </HeaderTemplate>
                                       <ItemTemplate>
                                          <tr>
                                             <td style="text-align: center; width: 15%;">
                                                <fmk:CustomLabel ID="lblDataLogHistorico" runat="server" CssClass="input-sm"></fmk:CustomLabel>
                                             </td>
                                             <td style="text-align: left; padding-left: 5px !important; width: 15%;">
                                                <fmk:CustomLabel ID="lblFaseLogHistorico" runat="server" CssClass="input-sm"></fmk:CustomLabel>
                                             </td>
                                             <td style="text-align: left; padding-left: 5px !important; width: 15%;">
                                                <fmk:CustomLabel ID="lblAcaoLogHistorico" runat="server" CssClass="input-sm"></fmk:CustomLabel>
                                             </td>
                                             <td style="text-align: left; padding-left: 5px !important; width: 55%;">
                                                <fmk:CustomLabel ID="lblUsuarioLogHistorico" runat="server" CssClass="input-sm"></fmk:CustomLabel>
                                             </td>
                                          </tr>
                                       </ItemTemplate>
                                       <FooterTemplate>
                                          </tbody>
</table>
                                       </FooterTemplate>
                                    </asp:Repeater>
                                 </div>
                              </div>
                           </div>
                        </div>
                        <!-- /Logs -->
                        <!-- Arquivos -->
                        <div class="tab-pane fade" id="tabArquivos" role="tabpanel" aria-labelledby="tabArquivos-tab">
                           <div class="accordion-body">
                              <div class="accordion-body">
                                 <div class="col-xl-12">
                                    <div class="card">
                                       <div class="card-body">
                                          <div class="row">
                                             <div class="col-md-12">
                                                <div class="mb-12">
                                                   <div class="table-responsive">
                                                      <asp:Repeater ID="rptArquivos" runat="server" OnItemDataBound="rptArquivos_ItemDataBound" OnItemCommand="rptArquivos_ItemCommand">
                                                         <HeaderTemplate>
                                                            <table class="table table-centered table-nowrap mb-0 no-footer dtr-inline nowrap table-card-list dt-responsive DataTables" style="width: 99%;" id="tabelaLojas">
                                                               <thead class="table-light">
                                                                  <tr>
                                                                     <th style="width: 100px;"></th>
                                                                     <th>Tipo Documento</th>
                                                                     <th>Arquivo</th>
                                                                  </tr>
                                                               </thead>
                                                               <tbody>
                                                         </HeaderTemplate>
                                                         <ItemTemplate>
                                                            <tr>
                                                               <td class="list-inline-item" style="text-align: center; background-color: transparent; padding: 3px;">
                                                                  <fmk:CustomLinkButton
                                                                     ID="lnkArquivoDownload"
                                                                     runat="server"
                                                                     CssClass="uil uil-download-alt font-size-16"
                                                                     ToolTip="Download"
                                                                     CommandName="Download"
                                                                     RequiredRole=""
                                                                     CausesValidation="false"
                                                                     OnClick="lnkArquivoDownload_Click"
                                                                     CommandArgument='<%# Eval("Id") %>'
                                                                     TabIndex="-1">
                                                                  </fmk:CustomLinkButton>
                                                               </td>
                                                               <td class="list-inline-item" style="text-align: center; background-color: transparent; padding: 3px;">
                                                                  <fmk:CustomLinkButton
                                                                     ID="lnkExcluir"
                                                                     runat="server"
                                                                     CssClass="uil uil-trash-alt font-size-16"
                                                                     ToolTip="Excluir"
                                                                     CommandName="Excluir"
                                                                     RequiredRole=""
                                                                     CausesValidation="false"
                                                                     OnClick="lnkExcluir_Click"
                                                                     CommandArgument='<%# Eval("Id") %>'
                                                                     TabIndex="-1">
                                                                  </fmk:CustomLinkButton>
                                                               </td>
                                                               <td>
                                                                  <fmk:CustomLabel ID="lblTipoArquivo" runat="server" /></td>
                                                               <td>
                                                                  <fmk:CustomLabel ID="lblArquivo" runat="server" /></td>
                                                            </tr>
                                                         </ItemTemplate>
                                                         <FooterTemplate>
                                                            </tbody>
</table>
                                                         </FooterTemplate>
                                                      </asp:Repeater>
                                                   </div>


                                                </div>
                                             </div>
                                          </div>
                                          <div class="row" id="divCarregarArquivos" runat="server" visible="true">

                                             <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="conditional">
                                                <Triggers>
                                                   <asp:PostBackTrigger ControlID="btnCarregarArquivo" />
                                                </Triggers>
                                                <ContentTemplate>
                                                   <div class="row">
                                                      <div class="col-md-4">
                                                         <div class="mb-12">
                                                            <div>
                                                               <asp:FileUpload ID="fileUpload" runat="server" accept=".pdf" />
                                                            </div>
                                                         </div>
                                                         <asp:HiddenField ID="HdntipoArquivo" runat="server" />

                                                      </div>
                                                      <div class="col-md-6">
                                                         <div class="mb-12">
                                                            <fmk:CustomDropDownList
                                                               ID="ddlTipoDocumentoUpload"
                                                               runat="server"
                                                               BindSelectedType="Message"
                                                               BindSelectedValue="TipoDocumento.Id"
                                                               BindSourceText="TipoDocumento.Descricao"
                                                               CssClass="form-control dropdown-toggle form-select"
                                                               BindSourceType="Message"
                                                               BindSourceValue="TipoDocumentoSelecionado.Id"
                                                               DefaultSelectedItem="(Selecione o Tipo de Documento)"
                                                               RequiredMessage="<a title=&quot;O campo 'Tipo de Documento' deve ser informado.&quot;><img src='/imagens/erro_validacao.png'/></a>"
                                                               ValidatorDisplay="Dynamic" />
                                                         </div>
                                                      </div>
                                                      <div class="col-md-2">
                                                         <div class="mb-12">
                                                            <fmk:CustomLinkButton
                                                               ID="btnCarregarArquivo"
                                                               runat="server"
                                                               CssClass="btn btn-primary"
                                                               ToolTip="Carregar Arquivo"
                                                               CommandName="Excluir"
                                                               RequiredRole=""
                                                               CausesValidation="false"
                                                               OnClick="btnCarregarArquivo_Click"
                                                               TabIndex="-1"><span>Carregar Arquivo</span>
                                                            </fmk:CustomLinkButton>
                                                         </div>
                                                      </div>
                                                   </div>
                                                </ContentTemplate>
                                             </asp:UpdatePanel>
                                          </div>
                                       </div>
                                    </div>
                                 </div>
                              </div>
                           </div>
                        </div>
                        <!-- /Arquivos -->
                     </div>
                  </div>
                  <asp:HiddenField ID="HiddenTab" runat="server" />
               </div>

            </div>
         </div>
      </div>
   </div>

   <!--  Modal Motivo Aprovacao -->
   <asp:Panel ID="pnlPopupJustificativaAprovacao" runat="server" class="modal" TabIndex="-1" role="dialog" Style="display: none;">
      <div class="modal-dialog">
         <div class="modal-content">
            <div class="modal-header">
               <h4 class="modal-title">Justificativa</h4>
            </div>
            <div class="row p-t-20">
               <div class="col-lg-12">
                  <div class="modalValidacao">
                  </div>
               </div>
            </div>
            <div class="modal-body">
               <!-- Body Modal -->
               <div class="panel-body" style="display: block;">

                  <!-- Justificativa -->
                  <div class="form-group">
                     <div class="col-sm-12">
                        <fmk:CustomTextBox ID="CustomTextBox7"
                           CssClass="input-sm form-control uppercase"
                           runat="server"
                           FormatType="Text"
                           ValidatorDisplay="Dynamic"
                           idmodal="MainContent_pnlPopupJustificativaAprovacao"
                           Rows="5"
                           ismodal="true"
                           obrigatorio="True"
                           TextMode="MultiLine"
                           BindSourceText="Ocorrencia.Motivo"
                           BindSourceType="Message"
                           Style="text-align: left"
                           RequiredMessage="<a title=&quot;O campo 'Justificativa' deve ser informado.&quot;><img src='/Imagens/erro_validacao.png'/></a>"
                           TypeCheckMessage="<a title=&quot;O campo 'Justificativa' possui um valor incorreto.&quot;><img src='/Imagens/erro_validacao.png'/></a>" />
                     </div>
                     <div class="help-block col-sm-12"></div>
                  </div>
                  <!-- Justificativa -->

               </div>
            </div>
            <div class="modal-footer">
               <asp:Button ID="btnJustificativaAprovacaoOk"
                  CssClass="btn btn-primary waves-light"
                  OnClick="btnJustificativaAprovacaoOk_Click"
                  ValidarFormulario="true"
                  OnClientClick="if (ValidarFormulario(true)) {CloseModalJustificativaAprovacao();return true;} return false;"
                  Text="Ok"
                  runat="server" />
               <asp:Button ID="btnJustificativaAprovacaoCancelar"
                  CssClass="btn btn-secundary waves-effect"
                  data-dismiss="modal"
                  Text="Cancelar"
                  runat="server" />
            </div>
         </div>
      </div>
   </asp:Panel>
   <!-- / Modal Motivo Aprovacao -->

   <!--  Modal Ocorrencia -->
   <asp:Panel ID="pnlPopupOcorrencia" runat="server" class="modal" TabIndex="-1" role="dialog" Style="display: none;">
      <div class="modal-dialog">
         <div class="modal-content">
            <div class="modal-header">
               <h4 class="modal-title">Ocorrência</h4>
            </div>
            <div class="row p-t-20">
               <div class="col-lg-12">
                  <div class="modalValidacao">
                  </div>
               </div>
            </div>
            <div class="modal-body">
               <!-- Body Modal -->
               <div class="panel-body" style="display: block;">
                  <!-- Ocorrência -->
                  <div class="form-group">
                     <div class="col-sm-2">
                        <label class="" for="txtOcorrencia">Ocorrência</label>
                     </div>
                     <div class="col-sm-10">
                        <fmk:CustomTextBox ID="txtOcorrencia"
                           CssClass="input-sm form-control uppercase"
                           runat="server"
                           FormatType="Text"
                           ValidatorDisplay="Dynamic"
                           idmodal="MainContent_pnlPopupOcorrencia"
                           ismodal="true"
                           obrigatorio="True"
                           Enabled="false"
                           BindSourceText="DetalheOcorrencia.DescricaoOcorrencia"
                           BindSourceType="Message"
                           Style="text-align: left" />
                     </div>
                     <div class="help-block col-sm-12"></div>
                  </div>
                  <!-- Ocorrência -->

                  <!-- Data/Hora -->
                  <div class="form-group">
                     <div class="col-sm-2">
                        <label class="" for="txtDataHoraOcorrencia">Data/Hora</label>
                     </div>
                     <div class="col-sm-10">
                        <fmk:CustomTextBox ID="txtDataHoraOcorrencia"
                           CssClass="input-sm form-control uppercase"
                           runat="server"
                           FormatType="Text" ValidatorDisplay="Dynamic"
                           idmodal="MainContent_pnlPopupOcorrencia"
                           ismodal="true"
                           obrigatorio="True"
                           Enabled="false"
                           BindSourceText="DetalheOcorrencia.DataOcorrencia"
                           BindSourceType="Message"
                           Style="text-align: left" />
                     </div>
                     <div class="help-block col-sm-12"></div>
                  </div>
                  <!-- Data/Hora -->

                  <!-- Restritiva -->
                  <div class="form-group">
                     <div class="col-sm-2">
                        <label class="" for="txtOcorrenciaRestritiva">Restritiva</label>
                     </div>
                     <div class="col-sm-10">
                        <fmk:CustomTextBox ID="txtOcorrenciaRestritiva"
                           CssClass="input-sm form-control uppercase"
                           runat="server"
                           FormatType="Text" ValidatorDisplay="Dynamic"
                           idmodal="MainContent_pnlPopupOcorrencia"
                           ismodal="true"
                           obrigatorio="True"
                           Enabled="false"
                           BindSourceText="DetalheOcorrencia.RestritivaDescricao"
                           BindSourceType="Message"
                           Style="text-align: left" />
                     </div>
                     <div class="help-block col-sm-12"></div>
                  </div>
                  <!-- Restritiva -->

                  <!-- Complemento -->
                  <div class="form-group">
                     <div class="col-sm-2">
                        <label class="" for="txtComplementoOcorrencia">Complemento</label>
                     </div>
                     <div class="col-sm-10">
                        <fmk:CustomTextBox ID="txtComplementoOcorrencia" CssClass="input-sm form-control uppercase" runat="server"
                           FormatType="Text" ValidatorDisplay="Dynamic"
                           idmodal="MainContent_pnlPopupOcorrencia"
                           Rows="5"
                           ismodal="true"
                           obrigatorio="True"
                           Enabled="false"
                           TextMode="MultiLine"
                           BindSourceText="DetalheOcorrencia.Complemento"
                           BindSourceType="Message"
                           Style="text-align: left"
                           RequiredMessage="<a title=&quot;O campo 'Justificativa' deve ser informado.&quot;><img src='/Imagens/erro_validacao.png'/></a>"
                           TypeCheckMessage="<a title=&quot;O campo 'Justificativa' possui um valor incorreto.&quot;><img src='/Imagens/erro_validacao.png'/></a>" />
                     </div>
                     <div class="help-block col-sm-12"></div>
                  </div>
                  <!-- Complemento -->

                  <!-- Liberada -->
                  <div class="form-group">
                     <div class="col-sm-2">
                        <label class="" for="txtOcorrenciaLiberada">Liberada</label>
                     </div>
                     <div class="col-sm-10">
                        <fmk:CustomTextBox ID="txtOcorrenciaLiberada"
                           CssClass="input-sm form-control uppercase"
                           runat="server"
                           FormatType="Text" ValidatorDisplay="Dynamic"
                           idmodal="MainContent_pnlPopupOcorrencia"
                           ismodal="true"
                           obrigatorio="True"
                           Enabled="false"
                           BindSourceText="DetalheOcorrencia.LiberadaDescricao"
                           BindSourceType="Message"
                           Style="text-align: left" />
                     </div>
                     <div class="help-block col-sm-12"></div>
                  </div>
                  <!-- Liberada -->

                  <!-- Data/Hora -->
                  <div class="form-group">
                     <div class="col-sm-2">
                        <label class="" for="txtOcorrenciaDataLiberacao">Data/Hora</label>
                     </div>
                     <div class="col-sm-10">
                        <fmk:CustomTextBox ID="txtOcorrenciaDataLiberacao"
                           CssClass="input-sm form-control uppercase"
                           runat="server"
                           FormatType="Text" ValidatorDisplay="Dynamic"
                           idmodal="MainContent_pnlPopupOcorrencia"
                           ismodal="true"
                           obrigatorio="True"
                           Enabled="false"
                           BindSourceText="DetalheOcorrencia.DataHoraLiberacao"
                           BindSourceType="Message"
                           Style="text-align: left" />
                     </div>
                     <div class="help-block col-sm-12"></div>
                  </div>
                  <!-- Data/Hora -->

                  <!-- Usuário -->
                  <div class="form-group">
                     <div class="col-sm-2">
                        <label class="" for="txtOcorrenciaUsuarioLiberador">Usuário</label>
                     </div>
                     <div class="col-sm-10">
                        <fmk:CustomTextBox ID="txtOcorrenciaUsuarioLiberador"
                           CssClass="input-sm form-control uppercase"
                           runat="server"
                           FormatType="Text" ValidatorDisplay="Dynamic"
                           idmodal="MainContent_pnlPopupOcorrencia"
                           ismodal="true"
                           obrigatorio="True"
                           Enabled="false"
                           BindSourceText="DetalheOcorrencia.UsuarioLiberador"
                           BindSourceType="Message"
                           Style="text-align: left" />
                     </div>
                     <div class="help-block col-sm-12"></div>
                  </div>
                  <!-- Usuário -->

                  <!-- Justificativa -->
                  <div class="form-group">
                     <div class="col-sm-2">
                        <label class="" for="txtJustificativaOcorrencia">Justificativa</label>
                     </div>
                     <div class="col-sm-10">
                        <fmk:CustomTextBox ID="txtJustificativaOcorrencia" CssClass="input-sm form-control uppercase" runat="server"
                           FormatType="Text" ValidatorDisplay="Dynamic"
                           idmodal="MainContent_pnlPopupOcorrencia"
                           Rows="5"
                           ismodal="true"
                           obrigatorio="True"
                           Enabled="false"
                           TextMode="MultiLine"
                           BindSourceText="DetalheOcorrencia.Motivo"
                           BindSourceType="Message" Style="text-align: left"
                           RequiredMessage="<a title=&quot;O campo 'Justificativa' deve ser informado.&quot;><img src='/Imagens/erro_validacao.png'/></a>"
                           TypeCheckMessage="<a title=&quot;O campo 'Justificativa' possui um valor incorreto.&quot;><img src='/Imagens/erro_validacao.png'/></a>" />
                     </div>
                     <div class="help-block col-sm-12"></div>
                  </div>
                  <!-- Justificativa -->

               </div>
            </div>
            <div class="modal-footer">
               <asp:Button ID="btnSairOcorrencia"
                  CssClass="btn btn-primary waves-light"
                  data-dismiss="modal"
                  Text="Sair"
                  Visible="false"
                  runat="server" />
               <asp:Button ID="btnJustificativaAprovacaoOcorrenciaOk"
                  CssClass="btn btn-primary waves-light"
                  OnClick="btnJustificativaAprovacaoOk_Click"
                  ValidarFormulario="true"
                  OnClientClick="if (ValidarFormulario(true)) {CloseModalOcorrencia();return true;} return false;"
                  Text="Ok"
                  IsModal="true"
                  runat="server" />
               <asp:Button ID="btnCancelarOcorrencia"
                  CssClass="btn btn-secundary waves-effect"
                  data-dismiss="modal"
                  Text="Cancelar"
                  runat="server" />
            </div>
         </div>
      </div>
   </asp:Panel>
   <!-- / Modal Ocorrência -->

   <!--  Modal Motivo Recusa -->
   <asp:Panel ID="pnlPopupJustificativaRecusa" runat="server" class="modal" TabIndex="-1" role="dialog" Style="display: none;">
      <div class="modal-dialog">
         <div class="modal-content">
            <div class="modal-header">
               <h4 class="modal-title">Justificativa</h4>
            </div>
            <div class="row p-t-20">
               <div class="col-lg-12">
                  <div class="modalValidacao">
                  </div>
               </div>
            </div>
            <div class="modal-body">
               <!-- Body Modal -->
               <div class="panel-body" style="display: block;">
                  <!-- Ocorrência-->
                  <div class="form-group">
                     <div class="col-sm-2" style="padding: 1px 1px !important;">
                        <label class="input-sm" for="ddlOcorrenciaRecusa">Ocorrência</label>
                     </div>
                     <div class="col-sm-10" style="padding: 1px 1px !important;">
                        <fmk:CustomDropDownList
                           ID="ddlOcorrenciaRecusa"
                           runat="server"
                           Width="100%"
                           BindSelectedType="Message"
                           BindSelectedValue="OcorrenciaRecusa.Ocorrencia"
                           BindSourceText="ListaOcorrenciaRecusa.Descricao"
                           CssClass="form-control dropdown-toggle select2-selection form-select"
                           BindSourceType="Message"
                           BindSourceValue="ListaOcorrenciaRecusa.Id"
                           DefaultSelectedItem="(Selecione)"
                           RequiredMessage="<a title=&quot;O campo 'Ocorrência' deve ser informado.&quot;><img src='/Imagens/erro_validacao.png'/></a>"
                           idmodal="MainContent_pnlPopupJustificativaRecusa"
                           ismodal="true"
                           obrigatorio="True"
                           ValidatorDisplay="Dynamic">
                        </fmk:CustomDropDownList>
                     </div>
                     <div class="help-block col-sm-12"></div>
                  </div>
                  <!-- /Ocorrência-->
                  <!-- Justificativa -->
                  <div class="form-group">
                     <div class="col-sm-12">
                        <fmk:CustomTextBox ID="CustomTextBox6" CssClass="input-sm form-control" runat="server"
                           FormatType="Text" ValidatorDisplay="Dynamic"
                           idmodal="MainContent_pnlPopupJustificativaRecusa"
                           Rows="5"
                           ismodal="true"
                           obrigatorio="True"
                           TextMode="MultiLine"
                           BindSourceText="PropostaModel.MotivoRecusa" BindSourceType="Message" Style="text-align: left"
                           RequiredMessage="<a title=&quot;O campo 'Justificativa' deve ser informado.&quot;><img src='/Imagens/erro_validacao.png'/></a>"
                           TypeCheckMessage="<a title=&quot;O campo 'Justificativa' possui um valor incorreto.&quot;><img src='/Imagens/erro_validacao.png'/></a>" />
                     </div>
                     <div class="help-block col-sm-12"></div>
                  </div>
                  <!-- Justificativa -->

               </div>
            </div>
            <div class="modal-footer">
               <asp:Button ID="btnJustificativaRecusaOk"
                  CssClass="btn btn-primary waves-effect"
                  OnClick="btnJustificativaRecusaOk_Click"
                  ValidarFormulario="true"
                  OnClientClick="if (ValidarFormulario(true)) {CloseModalJustificativaRecusa();return true;} return false;"
                  Text="Ok"
                  IdModal="MainContent_pnlPopupJustificativaRecusa"
                  IsModal="true"
                  runat="server" />
               <asp:Button ID="btnJustificativaCancelar"
                  CssClass="btn btn-secundary waves-effect"
                  data-dismiss="modal"
                  Text="Cancelar"
                  runat="server" />
            </div>
         </div>
      </div>
   </asp:Panel>
   <!-- / Modal Motivo Recusa -->

   <!--  Modal Pendenciar Proposta -->
   <asp:Panel ID="pnlPopupPendenciarProposta" runat="server" class="modal" TabIndex="-1" role="dialog" Style="display: none;">
      <div class="modal-dialog">
         <div class="modal-content">
            <div class="modal-header">
               <h4 class="modal-title">Pendenciar</h4>
            </div>
            <div class="row p-t-20">
               <div class="col-lg-12">
                  <div class="modalValidacao">
                  </div>
               </div>
            </div>
            <div class="modal-body">
               <!-- Body Modal -->
               <div class="panel-body" style="display: block;">

                  <!-- Ocorrência-->
                  <div class="form-group">
                     <div class="col-sm-2" style="padding: 1px 1px !important;">
                        <label class="input-sm" for="ddlOcorrenciaPendencia">Ocorrência</label>
                     </div>
                     <div class="col-sm-10" style="padding: 1px 1px !important;">
                        <fmk:CustomDropDownList
                           ID="ddlOcorrenciaPendencia"
                           runat="server"
                           Width="100%"
                           BindSelectedType="Message"
                           BindSelectedValue="OcorrenciaPendencia.Ocorrencia"
                           BindSourceText="ListaOcorrenciaPendencia.DescricaoOcorrencia"
                           CssClass="form-control dropdown-toggle select2-selection form-select"
                           BindSourceType="Message"
                           BindSourceValue="ListaOcorrenciaPendencia.Ocorrencia"
                           DefaultSelectedItem="(Selecione)"
                           RequiredMessage="<a title=&quot;O campo 'Ocorrência' deve ser informado.&quot;><img src='/Imagens/erro_validacao.png'/></a>"
                           idmodal="MainContent_pnlPopupPendenciarProposta"
                           ismodal="true"
                           obrigatorio="True"
                           ValidatorDisplay="Dynamic">
                        </fmk:CustomDropDownList>
                     </div>
                     <div class="help-block col-sm-12"></div>
                  </div>
                  <!-- /Ocorrência-->

                  <!-- Observações -->
                  <div class="form-group">
                     <div class="col-sm-12" style="padding: 1px 1px !important;">
                        <fmk:CustomTextBox ID="txtObservacoesPendencia" CssClass="input-sm form-control" runat="server"
                           FormatType="Text" ValidatorDisplay="Dynamic"
                           idmodal="MainContent_pnlPopupPendenciarProposta"
                           Rows="5"
                           ismodal="true"
                           obrigatorio="False"
                           TextMode="MultiLine"
                           BindSourceText="OcorrenciaPendencia.Complemento" BindSourceType="Message" Style="text-align: left"
                           RequiredMessage="<a title=&quot;O campo 'Observações' deve ser informado.&quot;><img src='/Imagens/erro_validacao.png'/></a>"
                           TypeCheckMessage="<a title=&quot;O campo 'Observações' possui um valor incorreto.&quot;><img src='/Imagens/erro_validacao.png'/></a>" />
                     </div>
                     <div class="help-block col-sm-12"></div>
                  </div>
                  <!-- /Observações -->

               </div>
            </div>
            <div class="modal-footer">
               <asp:Button ID="btnPendenciarOk"
                  CssClass="btn btn-primary waves-effect"
                  OnClick="btnPendenciarOk_Click"
                  ValidarFormulario="true"
                  OnClientClick="if (ValidarFormulario(true)) {CloseModalPendenciarProposta();return true;} return false;"
                  Text="Ok"
                  IsModal="true"
                  runat="server" />
               <asp:Button ID="btnPendenciarPropostaCancelar"
                  CssClass="btn btn-secundary waves-effect"
                  data-dismiss="modal"
                  Text="Cancelar"
                  runat="server" />
            </div>
         </div>
      </div>
   </asp:Panel>
   <!-- / Modal Pendenciar Proposta -->

   <!--  Modal Adicionar Ocorrência Proposta -->
   <asp:Panel ID="pnlPopupAdicionarOcorrencia" runat="server" class="modal" TabIndex="-1" role="dialog" Style="display: none;">
      <div class="modal-dialog">
         <div class="modal-content">
            <div class="modal-header">
               <h4 class="modal-title">Adicionar Ocorrência</h4>
            </div>
            <div class="row p-t-20">
               <div class="col-lg-12">
                  <div class="modalValidacao">
                  </div>
               </div>
            </div>
            <div class="modal-body">
               <!-- Body Modal -->
               <div class="panel-body" style="display: block;">

                  <!-- Ocorrência-->
                  <div class="form-group">
                     <div class="col-sm-2" style="padding: 1px 1px !important;">
                        <label class="input-sm" for="ddlOcorrenciaProposta">Ocorrência</label>
                     </div>
                     <div class="col-sm-10" style="padding: 1px 1px !important;">
                        <fmk:CustomDropDownList
                           ID="ddlOcorrenciaProposta"
                           runat="server"
                           Width="100%"
                           BindSelectedType="Message"
                           BindSelectedValue="AdicionarOcorrencia.Ocorrencia"
                           CssClass="form-control dropdown-toggle select2-selection form-select"
                           BindSourceType="Message"
                           BindSourceValue="ListaOcorrenciaAdicionar.Id"
                           BindSourceText="ListaOcorrenciaAdicionar.Descricao"
                           DefaultSelectedItem="(Selecione)"
                           RequiredMessage="<a title=&quot;O campo 'Ocorrência' deve ser informado.&quot;><img src='/Imagens/erro_validacao.png'/></a>"
                           idmodal="MainContent_pnlPopupAdicionarOcorrencia"
                           ismodal="true"
                           obrigatorio="True"
                           ValidatorDisplay="Dynamic">
                        </fmk:CustomDropDownList>
                     </div>
                     <div class="help-block col-sm-12"></div>
                  </div>
                  <!-- /Ocorrência-->

                  <!-- Observações -->
                  <div class="form-group">
                     <div class="col-sm-12" style="padding: 1px 1px !important;">
                        <fmk:CustomTextBox ID="CustomTextBox1" CssClass="input-sm form-control" runat="server"
                           FormatType="Text" ValidatorDisplay="Dynamic"
                           idmodal="MainContent_pnlPopupAdicionarOcorrencia"
                           Rows="5"
                           ismodal="true"
                           obrigatorio="False"
                           TextMode="MultiLine"
                           BindSourceText="AdicionarOcorrencia.Complemento" BindSourceType="Message" Style="text-align: left"
                           RequiredMessage="<a title=&quot;O campo 'Observações' deve ser informado.&quot;><img src='/Imagens/erro_validacao.png'/></a>"
                           TypeCheckMessage="<a title=&quot;O campo 'Observações' possui um valor incorreto.&quot;><img src='/Imagens/erro_validacao.png'/></a>" />
                     </div>
                     <div class="help-block col-sm-12"></div>
                  </div>
                  <!-- /Observações -->

               </div>
            </div>
            <div class="modal-footer">
               <asp:Button ID="bntAdicionarOcorrenciaOK"
                  CssClass="btn btn-primary waves-effect"
                  OnClick="bntAdicionarOcorrenciaOK_Click"
                  ValidarFormulario="true"
                  OnClientClick="if (ValidarFormulario(true)) {CloseModalAdicionarOcorrencia();return true;} return false;"
                  Text="Ok"
                  IsModal="true"
                  runat="server" />
               <asp:Button ID="btnAdicionarOcorrenciaCancel"
                  CssClass="btn btn-secundary waves-effect"
                  data-dismiss="modal"
                  Text="Cancelar"
                  runat="server" />
            </div>
         </div>
      </div>
   </asp:Panel>
   <!-- / Modal Pendenciar Proposta -->

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
   <script>
      function StartupPaginaJs() {
         $("[id*=MainContent_ddlTipoDocumentoUpload]").change(function () {
            // Set the hidden field value
            $('#<%=HdntipoArquivo.ClientID%>').val($(this).find("option:selected").val());
            $("[id*=MainContent_ddlTipoDocumentoUpload").val($(this).find("option:selected").val());
         });

         Tabs();

      }

      function CloseModalJustificativaAprovacao() {
         $("#<%=pnlPopupJustificativaAprovacao.ClientID %>").modal('hide');
      }

      function CloseModalOcorrencia() {
         $("#<%=pnlPopupOcorrencia.ClientID %>").modal('hide');
      }

      function CloseModalJustificativaRecusa() {
         $("#<%=pnlPopupJustificativaRecusa.ClientID %>").modal('hide');
      }

      function CloseModalPendenciarProposta() {
         $("#<%=pnlPopupPendenciarProposta.ClientID %>").modal('hide');
      } 

      function CloseModalAdicionarOcorrencia() {
         $("#<%=pnlPopupAdicionarOcorrencia.ClientID %>").modal('hide');
      } 

      function Tabs() {

         var Tab = $("#<%=HiddenTab.ClientID%>");
         var tabId = Tab.val() != "" ? Tab.val() : "tabPropostas-tab";
         $('#v-pills-tab a[href="#' + tabId + '"]').tab('show');
         $("#v-pills-tab a").click(function () {
            Tab.val($(this).attr("href").substring(1));
         });

      }

      function BuscaCEP(cep, tipo) {
         $.ajax({
            url: '/Proposta/BuscaCEP?cep=' + cep.value,
            method: 'POST',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            success: function (data) {
               if (tipo == 'R') {
                  $("#MainContent_txtEnderecoResidencial").val(data.Logradouro);
                  $("#MainContent_txtBairroResidencial").val(data.Bairro);
                  $("#MainContent_txtCidadeResidencial").val(data.Localidade);
                  $("#MainContent_txtEstadoResidencial").val(data.UF);
               }
            },
            fail: function (jqXHR, textStatus) {
               alert("Request failed: " + textStatus);
            }
         });
      };
   </script>

</asp:Content>
