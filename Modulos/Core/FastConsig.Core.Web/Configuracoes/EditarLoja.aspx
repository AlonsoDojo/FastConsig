<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarLoja.aspx.cs" Inherits="FastConsig.Core.Web.Configuracoes.EditarLoja" %>

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
                     <div class="mt-4">
                        <div class="d-flex flex-wrap gap-3 mt-3 mx-auto">
                           <fmk:CustomLinkButton ID="btnSalvar" runat="server" class="btn btn-primary" OnClick="btnSalvar_Click" DialogConfirmarAcao="true">Salvar</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnExcluir" runat="server" class="btn btn-outline-danger" OnClick="btnExcluir_Click" DialogConfirmarExclusao="true">Excluir</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnVoltar" runat="server" class="btn btn-secondary waves-effect" OnClick="btnVoltar_Click" CausesValidation="false">Voltar</fmk:CustomLinkButton>
                        </div>

                        <div class="mb-3">
                        </div>

                        <div class="row">
                           <div class="col-md-1">
                              <div class="mb-12">
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
                                    BindSourceText="Lojas.Id"
                                    BindSourceValue="Lojas.Id"></fmk:CustomTextBox>
                              </div>
                           </div>
                           <div class="col-md-2">
                              <div class="mb-12">
                                 <label class="form-label" for="txtCnpj">CNPJ</label>
                                 <fmk:CustomTextBox ID="txtCnpj" runat="server"
                                    CssClass="form-control"
                                    TabIndex="2"
                                    placeholder="Nome"
                                    BindSelectedType="Message"
                                    Required="True"
                                    Enabled="true"
                                    MaxLength="14"
                                    FormatType="Integer"
                                    onkeypress="return isNumber(event)"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="Lojas.Cnpj"
                                    BindSourceValue="Lojas.Cnpj"></fmk:CustomTextBox>
                              </div>
                           </div>

                           <div class="col-md-2">
                              <div class="mb-12">
                                 <label class="form-label" for="txtCodigoLoja">Código</label>
                                 <fmk:CustomTextBox ID="txtCodigoLoja" runat="server"
                                    CssClass="form-control"
                                    TabIndex="2"
                                    placeholder="Nome"
                                    BindSelectedType="Message"
                                    Required="True"
                                    Enabled="true"
                                    MaxLength="4"
                                    FormatType="Integer"
                                    onkeypress="return isNumber(event)"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="Lojas.Loja"
                                    BindSourceValue="Lojas.Loja"></fmk:CustomTextBox>
                              </div>
                           </div>

                           <div class="col-md-7">
                              <div class="mb-12">
                                 <label class="form-label" for="txtDescricao">Nome</label>
                                 <fmk:CustomTextBox ID="txtDescricao" runat="server"
                                    CssClass="form-control"
                                    TabIndex="3"
                                    placeholder="Nome"
                                    BindSelectedType="Message"
                                    Required="True"
                                    Enabled="true"
                                    MaxLength="100"
                                    FormatType="Text"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="Lojas.Nome"
                                    BindSourceValue="Lojas.Nome"></fmk:CustomTextBox>
                              </div>
                           </div>
                        </div>

                        <div class="mb-3">
                        </div>
                        <div class="row">
                           <div class="col-md-12">
                              <div class="mb-12">
                                 <label class="form-label" for="ddlGerente">Rede de Lojas</label>
                                 <fmk:CustomDropDownList
                                    ID="ddlPromotora"
                                    runat="server"
                                    CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                                    TabIndex="5"
                                    BindSelectedType="Message"
                                    Required="true"
                                    BindSourceType="Message"
                                    BindSelectedValue="Lojas.RedeLoja"
                                    DefaultSelectedItem="(Selecione o Gerente)"
                                    BindSourceText="RedeLoja.Nome"
                                    BindSourceValue="RedeLoja.Id">
                                 </fmk:CustomDropDownList>
                              </div>
                           </div>
                        </div>

                        <div class="mb-3">
                        </div>

                        <div class="row">
                           <div class="col-md-1">
                              <div class="mb-12">
                                 <label class="form-label" for="txtCEP">CEP</label>
                                 <fmk:CustomTextBox ID="txtCEP" runat="server"
                                    CssClass="form-control"
                                    TabIndex="6"
                                    placeholder="Cep"
                                    BindSelectedType="Message"
                                    Required="false"
                                    Enabled="true"
                                    MaxLength="9"
									         onblur="BuscaCEP(this, 'PR');"
                                    FormatType="Integer"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="Lojas.Cep"
                                    BindSourceValue="Lojas.Cep"></fmk:CustomTextBox>
                              </div>
                           </div>
                           <div class="col-md-7">
                              <div class="mb-12">
                                 <label class="form-label" for="txtEndereco">Endereço</label>
                                 <fmk:CustomTextBox ID="txtEndereco" runat="server"
                                    CssClass="form-control"
                                    TabIndex="7"
                                    placeholder="Endereço"
                                    BindSelectedType="Message"
                                    Required="false"
                                    Enabled="true"
                                    MaxLength="100"
                                    FormatType="Text"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="Lojas.Endereco"
                                    BindSourceValue="Lojas.Endereco"></fmk:CustomTextBox>
                              </div>
                           </div>

                           <div class="col-md-1">
                              <div class="mb-12">
                                 <label class="form-label" for="txtNumero">Número</label>
                                 <fmk:CustomTextBox ID="txtNumero" runat="server"
                                    CssClass="form-control"
                                    TabIndex="8"
                                    placeholder="Número"
                                    BindSelectedType="Message"
                                    Required="false"
                                    Enabled="true"
                                    MaxLength="8"
                                    FormatType="Text"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="Lojas.Numero"
                                    BindSourceValue="Lojas.Numero"></fmk:CustomTextBox>
                              </div>
                           </div>

                           <div class="col-md-3">
                              <div class="mb-12">
                                 <label class="form-label" for="txtComplemento">Complemento</label>
                                 <fmk:CustomTextBox ID="txtComplemento" runat="server"
                                    CssClass="form-control"
                                    TabIndex="9"
                                    placeholder="Complemento"
                                    BindSelectedType="Message"
                                    Required="false"
                                    Enabled="true"
                                    MaxLength="50"
                                    FormatType="Text"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="Lojas.Complemento"
                                    BindSourceValue="Lojas.Complemento"></fmk:CustomTextBox>
                              </div>
                           </div>

                        </div>

                        <div class="mb-3">
                        </div>

                        <div class="row">
                           <div class="col-md-5">
                              <div class="mb-12">
                                 <label class="form-label" for="txtBairro">Bairro</label>
                                 <fmk:CustomTextBox ID="txtBairro" runat="server"
                                    CssClass="form-control"
                                    TabIndex="10"
                                    placeholder="Bairro"
                                    BindSelectedType="Message"
                                    Required="false"
                                    Enabled="true"
                                    MaxLength="50"
                                    FormatType="Text"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="Lojas.Bairro"
                                    BindSourceValue="Lojas.Bairro"></fmk:CustomTextBox>
                              </div>


                           </div>
                           <div class="col-md-5">

                              <div class="mb-12">
                                 <label class="form-label" for="txtCidade">Cidade</label>
                                 <fmk:CustomTextBox ID="txtCidade" runat="server"
                                    CssClass="form-control"
                                    TabIndex="11"
                                    placeholder="Cidade"
                                    BindSelectedType="Message"
                                    Required="false"
                                    Enabled="true"
                                    MaxLength="50"
                                    FormatType="Text"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="Lojas.Cidade"
                                    BindSourceValue="Lojas.Cidade"></fmk:CustomTextBox>
                              </div>
                           </div>
                           <div class="col-md-2">
                              <div class="mb-12">
                                 <label class="form-label" for="txtEstado">Estado</label>
                                 <fmk:CustomTextBox ID="txtEstado" runat="server"
                                    CssClass="form-control"
                                    TabIndex="12"
                                    placeholder="UF"
                                    BindSelectedType="Message"
                                    Required="false"
                                    Enabled="true"
                                    MaxLength="2"
                                    FormatType="Text"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="Lojas.Estado"
                                    BindSourceValue="Lojas.Estado"></fmk:CustomTextBox>
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
   <script>
      function BuscaCEP(cep, tipo) {
         $.ajax({
            url: '/Proposta/BuscaCEP?cep=' + cep.value,
            method: 'POST',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            success: function (data) {
               if (tipo == 'PR') {
                  $("#MainContent_txtEndereco").val(data.Logradouro);
                  $("#MainContent_txtBairro").val(data.Bairro);
                  $("#MainContent_txtCidade").val(data.Localidade);
                  $("#MainContent_txtEstado").val(data.UF);
               }
            },
            fail: function (jqXHR, textStatus) {
               alert("Request failed: " + textStatus);
            }
         });
      };
   </script>
</asp:Content>
