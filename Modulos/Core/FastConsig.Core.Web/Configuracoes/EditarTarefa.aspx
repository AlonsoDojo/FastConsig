<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarTarefa.aspx.cs" Inherits="FastConsig.Core.Web.Configuracoes.EditarTarefa" %>

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
                                 <label class="form-label" for="txtCodigo">Código</label>
                                 <fmk:CustomTextBox ID="txtCodigo" runat="server"
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
                                    BindSourceText="Tarefa.Id"
                                    BindSourceValue="Tarefa.Id"></fmk:CustomTextBox>
                              </div>
                           </div>
                        </div>

                        <div class="mb-3">
                           <label class="form-label" for="txtDescricao">Descrição</label>
                           <fmk:CustomTextBox ID="txtDescricao" runat="server"
                              CssClass="form-control"
                              TabIndex="2"
                              placeholder="Nome"
                              BindSelectedType="Message"
                              Required="True"
                              Enabled="true"
                              MaxLength="200"
                              FormatType="Text"
                              onpaste="return false;"
                              autocomplete="off"
                              BindSourceType="Message"
                              BindSourceText="Tarefa.Nome"
                              BindSourceValue="Tarefa.Nome"></fmk:CustomTextBox>
                        </div>

                        <div class="mb-3">
                           <label class="form-label" for="ddlTipoTarefa">Tipo de Tarefa</label>
                           <fmk:CustomDropDownList
                              ID="ddlTipoTarefa"
                              runat="server"
                              CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                              TabIndex="3"
                              BindSelectedType="Message"
                              Required="true"
                              BindSourceType="Message"
                              BindSelectedValue="Tarefa.TipoTarefa"
                              DefaultSelectedItem="(Selecione o Tipo de Tarefa)"
                              BindSourceText="TipoTarefa.Descricao"
                              BindSourceValue="TipoTarefa.Id">
                           </fmk:CustomDropDownList>
                        </div>

                        <div class="mb-3">
                           <label class="form-label" for="ddlTipoAgenda">Tipo de Agenda</label>
                           <fmk:CustomDropDownList
                              ID="ddlTipoAgenda"
                              runat="server"
                              CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                              TabIndex="4"
                              BindSelectedType="Message"
                              Required="true"
                              BindSourceType="Message"
                              BindSelectedValue="Tarefa.TipoAgenda"
                              DefaultSelectedItem="(Selecione o Tipo de Agenda)"
                              BindSourceText="TipoAgenda.Descricao"
                              BindSourceValue="TipoAgenda.Id">
                           </fmk:CustomDropDownList>
                        </div>

                        <div class="mb-3">
                           <label class="form-label" for="ddlFila">Fila</label>
                           <fmk:CustomDropDownList
                              ID="ddlFila"
                              runat="server"
                              CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                              TabIndex="5"
                              BindSelectedType="Message"
                              Required="true"
                              BindSourceType="Message"
                              BindSelectedValue="Tarefa.Fila"
                              DefaultSelectedItem="(Selecione a Fila)"
                              BindSourceText="Fila.Nome"
                              BindSourceValue="Fila.Id">
                           </fmk:CustomDropDownList>
                        </div>

                        <div class="mb-3">
                           <label class="form-label" for="txtAssembly">Assembly</label>
                           <fmk:CustomTextBox ID="txtAssembly" runat="server"
                              CssClass="form-control"
                              TabIndex="6"
                              placeholder="Assembly"
                              BindSelectedType="Message"
                              Required="true"
                              Enabled="true"
                              MaxLength="200"
                              FormatType="Text"
                              onpaste="return false;"
                              autocomplete="off"
                              BindSourceType="Message"
                              BindSourceText="Tarefa.Assembly"
                              BindSourceValue="Tarefa.Assembly"></fmk:CustomTextBox>
                        </div>

                        <div class="mb-3">
                           <label class="form-label" for="txtClassName">Classe</label>
                           <fmk:CustomTextBox ID="txtClassName" runat="server"
                              CssClass="form-control"
                              TabIndex="7"
                              placeholder="ClassName"
                              BindSelectedType="Message"
                              Required="true"
                              Enabled="true"
                              MaxLength="200"
                              FormatType="Text"
                              onpaste="return false;"
                              autocomplete="off"
                              BindSourceType="Message"
                              BindSourceText="Tarefa.ClassName"
                              BindSourceValue="Tarefa.ClassName"></fmk:CustomTextBox>
                        </div>

                        <div class="mb-3">
                           <label class="form-label" for="txtAgenda">Agenda (Expressão CRON)</label>
                           <fmk:CustomTextBox ID="txtAgenda" runat="server"
                              CssClass="form-control"
                              TabIndex="8"
                              placeholder="ClassName"
                              BindSelectedType="Message"
                              Required="true"
                              Enabled="true"
                              MaxLength="15"
                              FormatType="Text"
                              onpaste="return false;"
                              autocomplete="off"
                              BindSourceType="Message"
                              BindSourceText="Tarefa.Agenda"
                              BindSourceValue="Tarefa.Agenda"></fmk:CustomTextBox>
                           <label class="form-label" id="txtDescricaoAgenda" runat="server"></label>
                        </div>

                        <div class="mb-3">
                           <label class="form-label" for="txtParametros">Parâmetros</label>
                           <fmk:CustomTextBox ID="txtParametros" runat="server"
                              CssClass="form-control"
                              TabIndex="8"
                              placeholder="Parâmetros"
                              BindSelectedType="Message"
                              Required="false"
                              Enabled="true"
                              FormatType="Text"
                              TextMode="MultiLine"
                              onpaste="return false;"
                              autocomplete="off"
                              BindSourceType="Message"
                              BindSourceText="Tarefa.Parametros"
                              BindSourceValue="Tarefa.Parametros"></fmk:CustomTextBox>
                        </div>

                        <div class="mb-3">
                           <div class="form-check">
                              <fmk:CustomCheckBox
                                 ID="chkAtivo"
                                 runat="server"
                                 CssClass="form-check-input"
                                 BindSourceText="Tarefa.Ativo"
                                 BindSourceValue="Tarefa.Ativo"
                                 TabIndex="8"
                                 BindSourceType="Message"
                                 Text="" />
                              <label class="form-check-label" for="chkSelecionavel">Ativo?</label>
                           </div>
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
