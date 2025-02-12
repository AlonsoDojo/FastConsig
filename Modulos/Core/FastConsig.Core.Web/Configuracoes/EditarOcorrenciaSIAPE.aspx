<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarOcorrenciaSIAPE.aspx.cs" Inherits="FastConsig.Core.Web.Configuracoes.EditarOcorrenciaSIAPE" %>

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
                  <div class="col-lg-5">
                     <div class="mt-4">
                        <div class="d-flex flex-wrap gap-3 mt-3 mx-auto">
                           <fmk:CustomLinkButton ID="btnSalvar" runat="server" class="btn btn-primary" OnClick="btnSalvar_Click" DialogConfirmarAcao="true">Salvar</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnExcluir" runat="server" class="btn btn-outline-danger" OnClick="btnExcluir_Click" DialogConfirmarExclusao="true">Excluir</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnVoltar" runat="server" class="btn btn-secondary waves-effect" OnClick="btnVoltar_Click" CausesValidation="false">Voltar</fmk:CustomLinkButton>
                        </div>

                        <div class="mb-3">
                        </div>

                        <div class="row">
                           <div class="col-md-3">
                              <div class="mb-1">
                                 <label class="form-label" for="txtCodigo">Código DATAPREV</label>
                                 <fmk:CustomTextBox ID="txtCodigo" runat="server"
                                    CssClass="form-control"
                                    TabIndex="1"
                                    placeholder="Código"
                                    BindSelectedType="Message"
                                    Required="false"
                                    Enabled="false"
                                    MaxLength="5"
                                    FormatType="Text"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="OcorrenciasSIAPE.Codigo"
                                    BindSourceValue="OcorrenciasSIAPE.Codigo"></fmk:CustomTextBox>
                              </div>
                           </div>
                        </div>

                        <div class="mb-3">
                           <label class="form-label" for="txtDescricao">Descrição</label>
                           <fmk:CustomTextBox ID="txtDescricao" runat="server"
                              CssClass="form-control"
                              TabIndex="2"
                              placeholder="Descrição"
                              BindSelectedType="Message"
                              Required="True"
                              Enabled="true"
                              FormatType="Text"
                              MaxLength="255"
                              onpaste="return false;"
                              autocomplete="off"
                              BindSourceType="Message"
                              BindSourceText="OcorrenciasSIAPE.Descricao"
                              BindSourceValue="OcorrenciasSIAPE.Descricao"></fmk:CustomTextBox>
                        </div>

                        <div class="mb-3">
                           <label class="form-label" for="ddlAcao">Ação</label>
                           <fmk:CustomDropDownList
                              ID="ddlAcao"
                              runat="server"
                              CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                              TabIndex="7"
                              BindSelectedType="Message"
                              Required="False"
                              BindSourceType="Message"
                              BindSelectedValue="OcorrenciasSIAPE.Acao"
                              DefaultSelectedItem="(Selecione a Ação)"
                              BindSourceText="OcorrenciasConsignadoAcao.Descricao"
                              BindSourceValue="OcorrenciasConsignadoAcao.Id">
                           </fmk:CustomDropDownList>
                        </div>

                        <div class="mb-3">
                           <label class="form-label" for="ddlOcorrencia">Ocorrência</label>
                           <fmk:CustomDropDownList
                              ID="ddlOcorrencia"
                              runat="server"
                              CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                              TabIndex="7"
                              BindSelectedType="Message"
                              Required="False"
                              BindSourceType="Message"
                              BindSelectedValue="OcorrenciasSIAPE.Ocorrencia"
                              DefaultSelectedItem="(Selecione a Ocorrência)"
                              BindSourceText="Ocorrencias.Descricao"
                              BindSourceValue="Ocorrencias.Id">
                           </fmk:CustomDropDownList>
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
</asp:Content>
