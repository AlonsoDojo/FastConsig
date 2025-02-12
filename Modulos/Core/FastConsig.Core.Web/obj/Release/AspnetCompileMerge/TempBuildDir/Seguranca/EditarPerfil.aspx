<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarPerfil.aspx.cs" Inherits="FastConsig.Core.Web.Seguranca.EditarPerfil" %>

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

                        <div class="mb-3">
                           <label class="form-label" for="txtDescricao">Nome</label>
                           <fmk:CustomTextBox ID="txtNome" runat="server"
                              CssClass="form-control"
                              TabIndex="1"
                              placeholder="Nome"
                              BindSelectedType="Message"
                              Required="True"
                              Enabled="true"
                              MaxLength="50"
                              FormatType="Text"
                              onpaste="return false;"
                              autocomplete="off"
                              BindSourceType="Message"
                              BindSourceText="Perfil.Nome"
                              BindSourceValue="Perfil.Nome"></fmk:CustomTextBox>
                        </div>

                        <div class="mb-3">
                           <div class="form-check">
                              <fmk:CustomCheckBox
                                 ID="chkSelecionavel"
                                 runat="server"
                                 CssClass="form-check-input"
                                 BindSourceText="Perfil.Habilitado"
                                 BindSourceValue="Perfil.Habilitado"
                                 TabIndex="2"
                                 BindSourceType="Message"
                                 Text="" />
                              <label class="form-check-label" for="chkSelecionavel">Habilitado</label>
                           </div>
                        </div>

                        <div class="row">
                           <div class="col-md-12">
                              <div class="mb-3">
                                 <div class="form-check">
                                    <fmk:CustomCheckBox
                                       ID="chkExterno"
                                       runat="server"
                                       CssClass="form-check-input"
                                       BindSourceText="Perfil.Externo"
                                       BindSourceValue="Perfil.Externo"
                                       TabIndex="3"
                                       BindSourceType="Message"
                                       Text="" />
                                    <label class="form-check-label" for="chkExterno">Externo</label>
                                 </div>
                              </div>
                           </div>
                        </div>

                        <div class="row">
                           <div class="col-md-12">
                              <div class="mb-12">
                                 <asp:PlaceHolder ID="phFuncionalidades" runat="server" Visible="false">
                                    <div class="card-header bg-transparent border-bottom">
                                        <h5 class="mb-0">Funcionalidades Associadas ao Perfil</h5>
                                    </div>
                                    <div class="panel-body">
                                       <div class="table-responsive">
                                          <asp:Repeater ID="FuncionalidadesRepeater" runat="server" OnItemDataBound="FuncionalidadesRepeater_ItemDataBound">
                                             <HeaderTemplate>
                                                <table class="table table-striped table-bordered table-hover dataTables-example" id="tbContas">
                                                   <thead>
                                                      <tr>
                                                         <th style="width: 3%"></th>
                                                         <th>Grupo</th>
                                                         <th>Nome</th>
                                                         <th>Endereço</th>
                                                         <th style="width: 3%">Habilitado</th>
                                                      </tr>
                                                   </thead>
                                                   <tbody>
                                             </HeaderTemplate>
                                             <ItemTemplate>
                                                <tr class="gradeA odd" role="row">
                                                   <td>
                                                      <asp:Label ID="lblFuncionalidadeId" runat="server" Visible="false" />
                                                      <asp:Label ID="lblPerfilId" runat="server" Visible="false" />
                                                      <div class="checkbox checkbox-replace checkbox-primary">
                                                         <asp:CheckBox ID="chkFuncionalidade" runat="server" />
                                                         <label for="chkFuncionalidade"></label>
                                                      </div>
                                                   </td>
                                                   <td>
                                                      <asp:Label ID="lblNomeGrupo" runat="server" /></td>
                                                   <td>
                                                      <asp:Label ID="lblNomeFuncionalidade" runat="server" />
                                                      <!-- EVENTOS DA FUNCIONALIDADE -->
                                                      <asp:Repeater ID="rptEventosFuncionalidade" runat="server" OnItemDataBound="rptEventosFuncionalidade_ItemDataBound">
                                                         <ItemTemplate>
                                                            <div class="row">
                                                               <div class="col-md-12 alpha60" style="margin-top: 5px; padding-top: 10px;">
                                                                  <div class="mb-1 alpha60">
                                                                     <div class="checkbox checkbox-replace checkbox-primary">
                                                                        <asp:CheckBox ID="chkEventoFuncionalidade" runat="server" />
                                                                        <label for="chkEventoFuncionalidade"></label>
                                                                     </div>
                                                                  </div>
                                                                  <div class="mb-11 alpha60">
                                                                     <asp:Label ID="Id" runat="server" Visible="false" />
                                                                     <asp:Label ID="Nome" runat="server" />
                                                                  </div>
                                                               </div>
                                                            </div>
                                                         </ItemTemplate>
                                                      </asp:Repeater>
                                                      <!--// EVENTOS DA FUNCIONALIDADE -->
                                                   </td>
                                                   <td>
                                                      <asp:Label ID="lblUrl" runat="server" /></td>
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
