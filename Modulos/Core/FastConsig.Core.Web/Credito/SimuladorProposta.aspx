<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeBehind="SimuladorProposta.aspx.cs" Inherits="FastConsig.Core.Web.Credito.SimuladorProposta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
   <style type="text/css">
      .panel-nomargim {
         margin-right: 0;
         margin-left: 0;
         padding-left: 0;
         padding-right: 0;
      }

      .panel-invisible {
         background-color: transparent;
         -moz-box-shadow: none;
         -webkit-box-shadow: none;
         box-shadow: none;
      }

      .feed-title > span {
         font-weight: 300;
         font-size: 18px;
      }

      .dataTables_paginate {
         float: left !important;
      }
   </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <div class="row">
      <div class="col-lg-12">
         <div class="card">
            <div class="card-body">
               <div class="row">
                  <div class="col-lg-12">
                     <div class="mt-12">
                        <div id="Identificacao" runat="server" visible="true">
                           <div class="row">
                              <div class="col-md-12">
                                 <div class="mb-12">
                                    <label class="form-label" for="ddlPromotora">Promotora</label>
                                    <fmk:CustomDropDownList
                                       ID="ddlPromotora"
                                       runat="server"
                                       CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                                       TabIndex="1"
                                       BindSelectedType="Message"
                                       Required="true"
                                       OnSelectedIndexChanged="ddlPromotora_SelectedIndexChanged"
                                       BindSourceType="Message"
                                       BindSelectedValue="SimulacaoPropostaModel.Promotora"
                                       AutoPostBack="true"
                                       Enabled="true"
                                       DefaultSelectedItem="(Selecione a Promotora)"
                                       BindSourceText="Promotoras.Nome"
                                       BindSourceValue="Promotoras.Id">
                                    </fmk:CustomDropDownList>
                                 </div>
                              </div>
                           </div>

                           <div class="mb-3">
                           </div>

                           <div class="row">
                              <div class="col-md-6">
                                 <div class="mb-12">
                                    <label class="form-label" for="ddlRedeLojas">Rede de Lojas</label>
                                    <fmk:CustomDropDownList
                                       ID="ddlRedeLojas"
                                       runat="server"
                                       CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                                       TabIndex="2"
                                       BindSelectedType="Message"
                                       Required="true"
                                       AutoPostBack="true"
                                       Enabled="true"
                                       OnSelectedIndexChanged="ddlRedeLojas_SelectedIndexChanged"
                                       BindSourceType="Message"
                                       BindSelectedValue="SimulacaoPropostaModel.Operacao.RedeLojas"
                                       DefaultSelectedItem="(Selecione a Rede de Lojas)"
                                       BindSourceText="RedeLoja.Nome"
                                       BindSourceValue="RedeLoja.Id">
                                    </fmk:CustomDropDownList>
                                 </div>
                              </div>

                              <div class="col-md-6">
                                 <div class="mb-12">
                                    <label class="form-label" for="ddlLojas">Lojas</label>
                                    <fmk:CustomDropDownList
                                       ID="ddlLojas"
                                       runat="server"
                                       CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                                       TabIndex="3"
                                       BindSelectedType="Message"
                                       Required="true"
                                       Enabled="true"
                                       BindSourceType="Message"
                                       BindSelectedValue="SimulacaoPropostaModel.Operacao.Loja"
                                       DefaultSelectedItem="(Selecione a Loja)"
                                       BindSourceText="Lojas.Nome"
                                       BindSourceValue="Lojas.Id">
                                    </fmk:CustomDropDownList>
                                 </div>
                              </div>
                           </div>

                           <div class="mb-3">
                           </div>
                        </div>

                        <div class="row">
                           <div class="col-md-12">
                              <div class="mb-12">
                                 <label class="form-label" for="ddlProduto">Produto</label>
                                 <fmk:CustomDropDownList
                                    ID="ddlProduto"
                                    runat="server"
                                    CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                                    TabIndex="4"
                                    BindSelectedType="Message"
                                    Required="true"
                                    Enabled="true"
                                    BindSourceType="Message"
                                    BindSelectedValue="SimulacaoPropostaModel.Operacao.Produto"
                                    OnSelectedIndexChanged="ddlProduto_SelectedIndexChanged"
                                    AutoPostBack="true"
                                    DefaultSelectedItem="(Selecione o Produto)"
                                    BindSourceText="Produtos.Nome"
                                    BindSourceValue="Produtos.Id">
                                 </fmk:CustomDropDownList>
                              </div>
                           </div>
                        </div>

                        <div class="mb-3">
                        </div>

                        <div id="INSS" runat="server" visible="false">
                           <div class="row">
                              <div class="col-md-9">
                                 <div class="mb-12">
                                    <label class="form-label" for="ddlTipoBeneficio">Tipo de Benefício</label>
                                    <fmk:CustomDropDownList
                                       ID="ddlTipoBeneficio"
                                       runat="server"
                                       CssClass="select2 select2-container form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                                       TabIndex="5"
                                       BindSelectedType="Message"
                                       Required="true"
                                       Enabled="true"
                                       BindSourceType="Message"
                                       BindSelectedValue="SimulacaoPropostaModel.Proponente.EspecieBeneficio"
                                       DefaultSelectedItem="(Selecione o Tipo de Benefício)"
                                       BindSourceText="TipoBeneficioINSS.DescricaoFormatada"
                                       BindSourceValue="TipoBeneficioINSS.Id">
                                    </fmk:CustomDropDownList>
                                 </div>
                              </div>

                              <div class="col-md-2">
                                 <div class="mb-12">
                                    <label class="form-label" for="txtNumeroBeneficio">Número Benefício</label>
                                    <fmk:CustomTextBox ID="txtNumeroBeneficio" runat="server"
                                       CssClass="form-control"
                                       TabIndex="6"
                                       placeholder="Número do Benefício"
                                       BindSelectedType="Message"
                                       Required="true"
                                       Enabled="true"
                                       MaxLength="11"
                                       FormatType="Integer"
                                       onkeypress="return isNumber(event)"
                                       onpaste="return false;"
                                       autocomplete="off"
                                       BindSourceType="Message"
                                       BindSourceText="SimulacaoPropostaModel.Proponente.NumeroBeneficio"
                                       BindSourceValue="SimulacaoPropostaModel.Proponente.NumeroBeneficio"></fmk:CustomTextBox>
                                 </div>
                              </div>

                              <div class="col-md-1">
                                 <div class="mb-12">
                                    <label class="form-label" for="ddlIndicadorAnafalbetismo">Ind.Anafalb.</label>
                                    <fmk:CustomDropDownList
                                       ID="ddlIndicadorAnafalbetismo"
                                       runat="server"
                                       CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                                       TabIndex="7"
                                       BindSelectedType="Message"
                                       Required="true"
                                       Enabled="true"
                                       BindSourceType="Message"
                                       BindSelectedValue="SimulacaoPropostaModel.Proponente.IndicadorAnalfabetismo"
                                       DefaultSelectedItem="(Selecione)"
                                       BindSourceText="IndicadorAnafalbetismo.Descricao"
                                       BindSourceValue="IndicadorAnafalbetismo.Id">
                                    </fmk:CustomDropDownList>
                                 </div>
                              </div>
                           </div>
                        </div>

                        <div id="SIAPE" runat="server" visible="false">
                           <div class="row">
                              <div class="col-md-8">
                                 <div class="mb-12">
                                    <label class="form-label" for="ddlOrgao">Orgão</label>
                                    <fmk:CustomDropDownList
                                       ID="ddlOrgao"
                                       runat="server"
                                       CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                                       TabIndex="5"
                                       BindSelectedType="Message"
                                       Required="true"
                                       Enabled="true"
                                       BindSourceType="Message"
                                       BindSelectedValue="SimulacaoPropostaModel.Proponente.Orgao"
                                       DefaultSelectedItem="(Selecione o Orgão)"
                                       BindSourceText="OrgaoSIAPE.DescricaoFormatada"
                                       BindSourceValue="OrgaoSIAPE.Codigo">
                                    </fmk:CustomDropDownList>
                                 </div>
                              </div>

                              <div class="col-md-2">
                                 <div class="mb-12">
                                    <label class="form-label" for="txtNumeroBeneficio">Número Benefício</label>
                                    <fmk:CustomTextBox ID="CustomTextBox1" runat="server"
                                       CssClass="form-control"
                                       TabIndex="6"
                                       placeholder="Número do Benefício"
                                       BindSelectedType="Message"
                                       Required="true"
                                       Enabled="true"
                                       MaxLength="11"
                                       FormatType="Integer"
                                       onkeypress="return isNumber(event)"
                                       onpaste="return false;"
                                       autocomplete="off"
                                       BindSourceType="Message"
                                       BindSourceText="SimulacaoPropostaModel.Proponente.NumeroBeneficioSIAPE"
                                       BindSourceValue="SimulacaoPropostaModel.Proponente.NumeroBeneficioSIAPE"></fmk:CustomTextBox>
                                 </div>
                              </div>

                              <div class="col-md-2">
                                 <div class="mb-12">
                                    <label class="form-label" for="txtInstituidor" id="labelInstituidor" runat="server">Instituidor</label>
                                    <fmk:CustomTextBox ID="txtInstituidor" runat="server"
                                       CssClass="form-control"
                                       TabIndex="7"
                                       placeholder="Instituidor"
                                       BindSelectedType="Message"
                                       Required="true"
                                       Enabled="true"
                                       MaxLength="11"
                                       FormatType="Integer"
                                       onkeypress="return isNumber(event)"
                                       onpaste="return false;"
                                       autocomplete="off"
                                       BindSourceType="Message"
                                       BindSourceText="SimulacaoPropostaModel.Proponente.NumeroBeneficio2"
                                       BindSourceValue="SimulacaoPropostaModel.Proponente.NumeroBeneficio2"></fmk:CustomTextBox>
                                 </div>
                              </div>

                           </div>
                        </div>

                        <div class="mb-3">
                        </div>

                        <div id="DadosCliente" runat="server" visible="false">
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
                                       Enabled="true"
                                       MaxLength="11"
                                       FormatType="Integer"
                                       onkeypress="return isNumber(event)"
                                       onpaste="return false;"
                                       autocomplete="off"
                                       BindSourceType="Message"
                                       BindSourceText="SimulacaoPropostaModel.Proponente.CpfCnpj"
                                       BindSourceValue="SimulacaoPropostaModel.Proponente.CpfCnpj"></fmk:CustomTextBox>
                                 </div>
                              </div>

                              <div class="col-md-1">
                                 <div class="mb-12">
                                    <label class="form-label" for="txtDataNascimento">Data de Nascto.</label>
                                    <fmk:CustomTextBox ID="txtDataNascimento" runat="server"
                                       CssClass="form-control flatpickr-input"
                                       TabIndex="9"
                                       MaxLength="10"
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
                                       BindSourceText="SimulacaoPropostaModel.Proponente.DataNascimento"
                                       BindSourceValue="SimulacaoPropostaModel.Proponente.DataNascimento"></fmk:CustomTextBox>
                                 </div>
                              </div>

                              <div class="col-md-9">
                                 <div class="mb-12">
                                    <label class="form-label" for="txtNome">Nome</label>
                                    <fmk:CustomTextBox ID="txtNome" runat="server"
                                       CssClass="form-control"
                                       TabIndex="10"
                                       placeholder="Nome"
                                       BindSelectedType="Message"
                                       Required="true"
                                       Enabled="true"
                                       MaxLength="100"
                                       FormatType="Text"
                                       onpaste="return false;"
                                       autocomplete="off"
                                       BindSourceType="Message"
                                       BindSourceText="SimulacaoPropostaModel.Proponente.Nome"
                                       BindSourceValue="SimulacaoPropostaModel.Proponente.Nome"></fmk:CustomTextBox>
                                 </div>
                              </div>
                           </div>

                           <div class="mb-3">
                           </div>

                           <div class="row">
                              <div class="col-md-2">
                                 <div class="mb-12">
                                    <label class="form-label" for="txtCelular">Ceclular</label>
                                    <fmk:CustomTextBox ID="txtCelular" runat="server"
                                       CssClass="form-control"
                                       TabIndex="11"
                                       MaxLength="15"
                                       placeholder="Celular"
                                       BindSelectedType="Message"
                                       Required="true"
                                       Enabled="true"
                                       onkeypress="return isNumber(event)"
                                       onkeyup="return TelefoneCelular(event, this)"
                                       FormatType="Text"
                                       onpaste="return false;"
                                       autocomplete="off"
                                       BindSourceType="Message"
                                       BindSourceText="SimulacaoPropostaModel.Proponente.Celular"
                                       BindSourceValue="SimulacaoPropostaModel.Proponente.Celular"></fmk:CustomTextBox>
                                 </div>
                              </div>

                              <div class="col-md-8">
                                 <div class="mb-12">
                                    <label class="form-label" for="txtEmail">Email</label>
                                    <fmk:CustomTextBox ID="txtEmail" runat="server"
                                       CssClass="form-control"
                                       TabIndex="12"
                                       placeholder="Email"
                                       BindSelectedType="Message"
                                       Required="true"
                                       Enabled="true"
                                       MaxLength="100"
                                       FormatType="Text"
                                       onpaste="return false;"
                                       autocomplete="off"
                                       BindSourceType="Message"
                                       BindSourceText="SimulacaoPropostaModel.Proponente.Email"
                                       BindSourceValue="SimulacaoPropostaModel.Proponente.Email"></fmk:CustomTextBox>
                                 </div>
                              </div>

                              <div class="col-md-2">
                                 <div class="mb-12">
                                    <label class="form-label" for="ddlTipoComunicacao">Tipo de Comunicação</label>
                                    <fmk:CustomDropDownList
                                       ID="ddlTipoComunicacao"
                                       runat="server"
                                       CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                                       TabIndex="13"
                                       BindSelectedType="Message"
                                       Required="true"
                                       Enabled="true"
                                       BindSourceType="Message"
                                       BindSelectedValue="SimulacaoPropostaModel.TipoComunicacao"
                                       DefaultSelectedItem="(Selecione o Tipo de Comunicação)"
                                       BindSourceText="TipoComunicacao.Descricao"
                                       BindSourceValue="TipoComunicacao.Id">
                                    </fmk:CustomDropDownList>
                                 </div>
                              </div>
                           </div>
                        </div>

                        <div class="mb-3">
                        </div>

                        <div id="DadosOperacao" runat="server" visible="false">
                           <div class="row">
                              <div class="col-md-7">
                                 <div class="mb-12">
                                    <label class="form-label" for="ddlTabela">Tabela</label>
                                    <fmk:CustomDropDownList
                                       ID="ddlTabela"
                                       runat="server"
                                       CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                                       TabIndex="17"
                                       BindSelectedType="Message"
                                       Required="true"
                                       Enabled="true"
                                       BindSourceType="Message"
                                       BindSelectedValue="SimulacaoPropostaModel.Operacao.Tabela"
                                       DefaultSelectedItem="(Selecione a Tabela)"
                                       BindSourceText="TabelaFinanceiraModel.DescricaoPlano"
                                       BindSourceValue="TabelaFinanceiraModel.Plano">
                                    </fmk:CustomDropDownList>
                                 </div>
                              </div>

                              <div class="col-md-2">
                                 <div class="mb-12">
                                    <label class="form-label" for="txtValorSolicitado">Valor Solicitado</label>
                                    <fmk:CustomTextBox ID="txtValorSolicitado" runat="server"
                                       CssClass="form-control format-decimal-18-2"
                                       TabIndex="14"
                                       placeholder="Valor Solicitado"
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
                                       BindSourceText="SimulacaoPropostaModel.Operacao.ValorOperacao"
                                       BindSourceValue="SimulacaoPropostaModel.Operacao.ValorOperacao"></fmk:CustomTextBox>
                                 </div>
                              </div>

                              <div class="col-md-1">
                                 <div class="mb-12">
                                    <label class="form-label" for="txtPrazo">Prazo</label>
                                    <fmk:CustomTextBox ID="txtPrazo" runat="server"
                                       CssClass="form-control"
                                       TabIndex="15"
                                       placeholder="Prazo"
                                       BindSelectedType="Message"
                                       Required="true"
                                       Enabled="true"
                                       MaxLength="3"
                                       FormatType="Integer"
                                       onkeypress="return isNumber(event)"
                                       onpaste="return false;"
                                       autocomplete="off"
                                       BindSourceType="Message"
                                       BindSourceText="SimulacaoPropostaModel.Operacao.Prazo"
                                       BindSourceValue="SimulacaoPropostaModel.Operacao.Prazo"></fmk:CustomTextBox>
                                 </div>
                              </div>

                              <div class="col-md-2">
                                 <div class="mb-12">
                                    <label class="form-label" for="txtValorParcela">Valor da Parcela</label>
                                    <fmk:CustomTextBox ID="txtValorParcela" runat="server"
                                       CssClass="form-control format-decimal-18-2"
                                       TabIndex="16"
                                       placeholder="Valor Parcela"
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
                                       BindSourceText="SimulacaoPropostaModel.Operacao.ValorParcela"
                                       BindSourceValue="SimulacaoPropostaModel.Operacao.ValorParcela"></fmk:CustomTextBox>
                                 </div>
                              </div>
                           </div>

                        </div>

                        <div class="d-flex flex-wrap gap-5 mt-5 mx-auto">
                           <fmk:CustomLinkButton ID="btnSimular" runat="server" class="btn btn-success" OnClick="btnSimular_Click" Visible="false">Simular</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnNovaSimulacao" runat="server" class="btn btn-success" OnClick="btnNovaSimulacao_Click" Visible="false">Nova Simulação</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnEnviarAutorizacao" runat="server" class="btn btn-info waves-effect" OnClick="btnEnviarAutorizacao_Click" Visible="false">Enviar Autorização</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnSubmeter" runat="server" class="btn btn-danger waves-effect" OnClick="btnSubmeter_Click" Visible="false">Submeter</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnBuscarContratos" runat="server" class="btn btn-info waves-effect" OnClick="btnBuscarContratos_Click" Visible="false">Buscar Contratos</fmk:CustomLinkButton>
                        </div>

                        <div class="mb-3">
                        </div>

                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
   <script>
      function StartupPaginaJs() {

             }
   </script>
</asp:Content>
