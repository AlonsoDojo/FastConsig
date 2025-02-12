<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarUsuario.aspx.cs" Inherits="FastConsig.Core.Web.Seguranca.EditarUsuario" %>

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
                        <div class="d-flex flex-wrap gap-3 mt-3 mx-auto">
                           <fmk:CustomLinkButton ID="btnSalvar" runat="server" class="btn btn-primary" OnClick="btnSalvar_Click" DialogConfirmarAcao="true">Salvar</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnExcluir" runat="server" class="btn btn-outline-danger" OnClick="btnExcluir_Click" DialogConfirmarExclusao="true">Excluir</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnVoltar" runat="server" class="btn btn-secondary waves-effect" OnClick="btnVoltar_Click" CausesValidation="false">Voltar</fmk:CustomLinkButton>
                        </div>

                        <div class="mb-3">
                        </div>

                        <div class="row">
                           <div class="col-md-3">
                              <div class="mb-12">
                                 <label class="form-label" for="ddlDominio">Domínio</label>
                                 <fmk:CustomDropDownList
                                    ID="ddlDominio"
                                    runat="server"
                                    CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                                    TabIndex="1"
                                    BindSelectedType="Message"
                                    Required="true"
                                    Enabled="false"
                                    BindSourceType="Message"
                                    BindSelectedValue="Usuario.Dominio"
                                    DefaultSelectedItem="(Selecione o Domínio)"
                                    BindSourceText="Dominio.Descricao"
                                    BindSourceValue="Dominio.Id">
                                 </fmk:CustomDropDownList>
                              </div>
                           </div>

                           <div class="col-md-3">
                              <div class="mb-12">
                                 <label class="form-label" for="txtCodigo">Login</label>
                                 <fmk:CustomTextBox ID="txtCodigo" runat="server"
                                    CssClass="form-control"
                                    TabIndex="2"
                                    MaxLength="100"
                                    placeholder="Login"
                                    BindSelectedType="Message"
                                    Required="true"
                                    Enabled="false"
                                    FormatType="Text"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="Usuario.Login"
                                    BindSourceValue="Usuario.Login"></fmk:CustomTextBox>
                              </div>
                           </div>

                           <div class="col-md-6">
                              <div class="mb-12">
                                 <label class="form-label" for="txtNome">Nome</label>
                                 <fmk:CustomTextBox ID="txtNome" runat="server"
                                    CssClass="form-control"
                                    TabIndex="3"
                                    placeholder="Nome"
                                    BindSelectedType="Message"
                                    Required="true"
                                    Enabled="true"
                                    MaxLength="100"
                                    FormatType="Text"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="Usuario.Nome"
                                    BindSourceValue="Usuario.Nome"></fmk:CustomTextBox>
                              </div>
                           </div>
                        </div>

                        <div class="mb-3">
                        </div>

                        <div class="row">
                           <div class="col-md-3">
                              <div class="mb-12">
                                 <label class="form-label" for="txtCPF">CPF</label>
                                 <fmk:CustomTextBox ID="txtCPF" runat="server"
                                    CssClass="form-control"
                                    TabIndex="5"
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
                                    BindSourceText="Usuario.CpfCnpj"
                                    BindSourceValue="Usuario.CpfCnpj"></fmk:CustomTextBox>
                              </div>
                           </div>

                           <div class="col-md-3">
                              <div class="mb-12">
                                 <label class="form-label" for="txtCelular">Celular</label>
                                 <fmk:CustomTextBox ID="txtCelular" runat="server"
                                    CssClass="form-control"
                                    TabIndex="6"
                                    MaxLength="15"
                                    placeholder="Celular"
                                    BindSelectedType="Message"
                                    Required="false"
                                    Enabled="true"
                                    onkeypress="return isNumber(event)"
                                    onkeyup="return TelefoneCelular(event, this)"
                                    FormatType="Text"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="Usuario.Celular"
                                    BindSourceValue="Usuario.Celular"></fmk:CustomTextBox>
                              </div>
                           </div>

                           <div class="col-md-6">
                              <div class="mb-12">
                                 <label class="form-label" for="txtEmail">Email</label>
                                 <fmk:CustomTextBox ID="txtEmail" runat="server"
                                    CssClass="form-control"
                                    TabIndex="4"
                                    placeholder="Email"
                                    BindSelectedType="Message"
                                    MaxLength="250"
                                    Required="true"
                                    Enabled="true"
                                    FormatType="Text"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="Usuario.Email"
                                    BindSourceValue="Usuario.Email"></fmk:CustomTextBox>
                              </div>
                           </div>
                        </div>

                        <div class="mb-3">
                        </div>

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
                                    Required="false"
                                    OnSelectedIndexChanged="ddlPromotora_SelectedIndexChanged"
                                    BindSourceType="Message"
                                    BindSelectedValue="Usuario.Promotora"
                                    AutoPostBack="true"
                                    Enabled="false"
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
                           <div class="col-md-12">
                              <div class="mb-12">
                                 <label class="form-label" for="ddlRedeLojas">Rede de Lojas</label>
                                 <fmk:CustomDropDownList
                                    ID="ddlRedeLojas"
                                    runat="server"
                                    CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                                    TabIndex="1"
                                    BindSelectedType="Message"
                                    Required="false"
                                    AutoPostBack="true"
                                    Enabled="false"
                                    OnSelectedIndexChanged="ddlRedeLojas_SelectedIndexChanged"
                                    BindSourceType="Message"
                                    BindSelectedValue="Usuario.RedeLojas"
                                    DefaultSelectedItem="(Selecione a Rede de Lojas)"
                                    BindSourceText="RedeLoja.Nome"
                                    BindSourceValue="RedeLoja.Id">
                                 </fmk:CustomDropDownList>
                              </div>
                           </div>
                        </div>

                        <div class="mb-3">
                        </div>

                        <div class="row">
                           <div class="col-md-12">
                              <div class="mb-12">
                                 <label class="form-label" for="ddlLojas">Lojas</label>
                                 <fmk:CustomDropDownList
                                    ID="ddlLojas"
                                    runat="server"
                                    CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                                    TabIndex="1"
                                    BindSelectedType="Message"
                                    Required="false"
                                    Enabled="false"
                                    BindSourceType="Message"
                                    BindSelectedValue="Usuario.Loja"
                                    DefaultSelectedItem="(Selecione a Loja)"
                                    BindSourceText="Lojas.Nome"
                                    BindSourceValue="Lojas.Id">
                                 </fmk:CustomDropDownList>
                              </div>
                           </div>
                        </div>

                        <div class="mb-3">
                        </div>

                        <div class="row">
                           <div class="col-md-6">
                              <div class="mb-12">
                                 <div class="form-check">
                                    <fmk:CustomCheckBox
                                       ID="chkBloqueado"
                                       runat="server"
                                       CssClass="form-check-input"
                                       BindSourceText="Usuario.Bloqueado"
                                       BindSourceValue="Usuario.Bloqueado"
                                       TabIndex="16"
                                       BindSourceType="Message"
                                       Text="" />
                                    <label class="form-check-label" for="chkBloqueado">Bloqueado</label>
                                 </div>
                              </div>
                           </div>

                           <div class="col-md-6">
                              <div class="mb-12">
                                 <div class="form-check">
                                    <fmk:CustomCheckBox
                                       ID="chkHabilitado"
                                       runat="server"
                                       CssClass="form-check-input"
                                       BindSourceText="Usuario.Habilitado"
                                       BindSourceValue="Usuario.Habilitado"
                                       TabIndex="16"
                                       BindSourceType="Message"
                                       Text="" />
                                    <label class="form-check-label" for="chkHabilitado">Habilitado</label>
                                 </div>
                              </div>
                           </div>
                        </div>

                        <div class="mb-3">
                        </div>

                        <!-- Perfis -->
                        <div class="row">
                           <div class="col-md-12">
                              <div class="mb-12">
                                 <asp:PlaceHolder ID="phPerfis" runat="server" Visible="true">
                                    <div class="card-header bg-transparent border-bottom">
                                       <h5 class="mb-0">Perfis Associados ao Usuário</h5>
                                    </div>
                                    <div class="panel-body">
                                       <div class="table-responsive">
                                          <asp:Repeater ID="PerfisRepeater" runat="server" OnItemDataBound="PerfisRepeater_ItemDataBound">
                                             <HeaderTemplate>
                                                <table class="table table-striped table-bordered table-hover DataTables" id="tPerfis">
                                                   <thead>
                                                      <tr>
                                                         <th style="width: 3%; font-weight: 600;"></th>
                                                         <th style="width: 90%; font-weight: 600;">Pefil de usuário</th>
                                                         <th style="width: 10%; font-weight: 600;">Habilitado</th>
                                                      </tr>
                                                   </thead>
                                                   <tbody>
                                             </HeaderTemplate>
                                             <ItemTemplate>
                                                <tr class="gradeA odd" role="row">
                                                   <td>
                                                      <asp:Label ID="lblPerfilId" runat="server" Visible="false" />
                                                      <div class="checkbox checkbox-replace checkbox-primary">
                                                         <asp:CheckBox ID="chkPerfil" runat="server" CssClass="form-check-input" />
                                                         <label for="chkHabilitado" class="form-check-label"></label>
                                                      </div>
                                                   </td>
                                                   <td>
                                                      <asp:Label ID="lblNomePerfil" runat="server" /></td>
                                                   <td style="text-align: center">
                                                      <asp:Label ID="lblHabilitado" runat="server" /></td>
                                                </tr>
                                             </ItemTemplate>
                                             <FooterTemplate>
                                                </tbody>
                                            </table>
                                             </FooterTemplate>
                                          </asp:Repeater>
                                       </div>
                                    </div>
                                 </asp:PlaceHolder>
                              </div>
                           </div>
                        </div>
                        <!-- /Perfis -->

                        <div class="mb-3">
                        </div>

                        <!-- Produtos -->
                        <div class="row">
                           <div class="col-md-12">
                              <div class="mb-12">
                                 <asp:PlaceHolder ID="phProdutos" runat="server" Visible="true">
                                    <div class="card-header bg-transparent border-bottom">
                                       <h5 class="mb-0">Produtos Autorizados</h5>
                                    </div>


                                    <div class="panel-body">
                                       <div class="table-responsive">
                                          <asp:Repeater ID="ProdutosRepeater" runat="server" OnItemDataBound="ProdutosRepeater_ItemDataBound">
                                             <HeaderTemplate>
                                                <table class="table table-striped table-bordered table-hover DataTables" id="tbContas">
                                                   <thead>
                                                      <tr>
                                                         <th style="width: 3%; font-weight: 600;"></th>
                                                         <th style="width: 90%; font-weight: 600;">Produto</th>
                                                      </tr>
                                                   </thead>
                                                   <tbody>
                                             </HeaderTemplate>
                                             <ItemTemplate>
                                                <tr class="gradeA odd" role="row">
                                                   <td>
                                                      <asp:Label ID="lblProdutoId" runat="server" Visible="false" />
                                                      <div class="checkbox checkbox-replace checkbox-primary">
                                                         <asp:CheckBox ID="chkProduto" runat="server" CssClass="form-check-input" />
                                                         <label for="chkProduto" class="form-check-label"></label>
                                                      </div>
                                                   </td>
                                                   <td>
                                                      <asp:Label ID="lblProduto" runat="server" /></td>
                                                </tr>
                                             </ItemTemplate>
                                             <FooterTemplate>
                                                </tbody>
                                            </table>
                                             </FooterTemplate>
                                          </asp:Repeater>
                                       </div>
                                    </div>
                                 </asp:PlaceHolder>
                              </div>
                           </div>
                        </div>
                        <!-- /Produtos -->
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

         $("#MainContent_txtCPF").keyup(function (evt) {
            evt = evt || event;
            switch (evt.keyCode) {
               case 8:
                  $("#MainContent_txtCodigo").val('');
                  break;
               case 46:
                  $("#MainContent_txtCodigo").val('');
                  break;
               default:
                  break;
            }
         });

         $("#MainContent_txtCPF").keyup(function () {

            var promotora = $("#MainContent_ddlPromotora option:selected").val();
            var loja = $("#MainContent_ddlLojas option:selected").val();
            var cpf = $("#MainContent_txtCPF").val().replace(/[^0-9]/gi, '');
            var login = cpf + "_" + promotora + loja;
            $("#MainContent_txtCodigo").val(login);


         });

         $(document).ready(function () {
            if ($("#MainContent_txtCPF").val().replace(/[^0-9]/gi, '') != '') {
               $("#MainContent_txtCPF").val(formataCPF(padLeadingZeros($("#MainContent_txtCPF").val().replace(/[^0-9]/gi, ''), 11)));
            }
         });

      }
   </script>
</asp:Content>
