<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarParametro.aspx.cs" Inherits="FastConsig.Core.Web.Seguranca.EditarParametro" %>

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

                        <div class="mb-6">
                        </div>

                        <div class="md-6">
                           <label class="form-label" for="txtCodigo">Código</label>
                           <fmk:CustomTextBox ID="txtCodigo" runat="server"
                              CssClass="form-control"
                              TabIndex="1"
                              placeholder="Chave"
                              BindSelectedType="Message"
                              Required="true"
                              Enabled="true"
                              MaxLength="250"
                              FormatType="Text"
                              onpaste="return false;"
                              autocomplete="off"
                              BindSourceType="Message"
                              BindSourceText="Configuracao.Chave"
                              BindSourceValue="Configuracao.Chave"></fmk:CustomTextBox>
                        </div>


                        <div class="mb-6">
                           <label class="form-label" for="txtDescricao">Descrição</label>
                           <fmk:CustomTextBox ID="txtDescricao" runat="server"
                              CssClass="form-control"
                              TabIndex="2"
                              placeholder="Valor"
                              BindSelectedType="Message"
                              Required="false"
                              Enabled="true"
                              FormatType="Text"
                              onpaste="return false;"
                              autocomplete="off"
                              BindSourceType="Message"
                              BindSourceText="Configuracao.Conteudo"
                              BindSourceValue="Configuracao.Conteudo"></fmk:CustomTextBox>
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
