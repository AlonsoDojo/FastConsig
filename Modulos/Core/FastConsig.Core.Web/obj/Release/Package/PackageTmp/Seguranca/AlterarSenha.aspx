<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlterarSenha.aspx.cs" Inherits="FastConsig.Core.Web.Seguranca.AlterarSenha" %>

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
         <div class="account-pages my-5 pt-sm-5">
            <div class="container">
               <div class="row align-items-center justify-content-center">
                  <div class="col-md-8 col-lg-6 col-xl-5">
                     <div class="card">
                        <div class="card-body p-4">
                           <div class="text-center mt-2">
                              <p class="text-muted">Informe suas credenciais</p>
                           </div>
                           <div class="p-2 mt-4">
                              <div class="mb-3">
                                 <label class="form-label" for="userpassword">Senha Atual</label>
                                 <fmk:CustomTextBox
                                    ID="txtSenhaAtual"
                                    placeholder="Senha"
                                    CssClass="form-control"
                                    runat="server"
                                    TabIndex="0"
                                    BindSelectedType="Message"
                                    Required="True"
                                    autocomplete="off"
                                    onpaste="return false;"
                                    BindSourceType="Message"
                                    BindSourceText="AlterarSenhaModel.SenhaAtual"
                                    BindSourceValue="AlterarSenhaModel.SenhaAtual"
                                    TextMode="Password" />
                              </div>

                              <div class="mb-3">
                                 <label class="form-label" for="userpassword">Nova Senha</label>
                                 <fmk:CustomTextBox
                                    ID="txtNovaSenha"
                                    placeholder="Nova Senha"
                                    CssClass="form-control"
                                    runat="server"
                                    TabIndex="2"
                                    BindSelectedType="Message"
                                    Required="True"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="AlterarSenhaModel.NovaSenha"
                                    BindSourceValue="AlterarSenhaModel.NovaSenha"
                                    TextMode="Password" />
                              </div>

                              <div class="mb-3">
                                 <label class="form-label" for="userpassword">Confirmação da Nova Senha</label>
                                 <fmk:CustomTextBox
                                    ID="txtConfirmacaoSenha"
                                    placeholder="Confirmação de Senha"
                                    CssClass="form-control"
                                    runat="server"
                                    TabIndex="2"
                                    BindSelectedType="Message"
                                    Required="True"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="AlterarSenhaModel.ConfirmacaoSenha"
                                    BindSourceValue="AlterarSenhaModel.ConfirmacaoSenha"
                                    TextMode="Password" />
                              </div>

                              <div class="mt-3 text-end">
                                 <fmk:CustomButton class="btn btn-primary w-sm waves-effect waves-light" ID="cmdAlterarSenha" runat="server" OnClick="cmdAlterarSenha_Click" Text="Alterar" />
                              </div>
                           </div>
                        </div>
                     </div>
                  </div>
               </div>
               <!-- end row -->
            </div>
            <!-- end container -->
         </div>
      </div>
   </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
   <script>
      function StartupPaginaJs() {
         $('.DataTables').DataTable({
            pageLength: 10,
            paging: true,
            "pagingType": "full_numbers",
            "lengthMenu": [[10, 25, 50, -1], [10, 25, 50, "All"]],
            info: false,
            bLengthChange: false,
            processing: true,
            serverSide: false,
            responsive: true,
            searching: false,
            "order": [[1, "asc"]],
            "columnDefs": [
               { 'targets': [0], orderable: false }
            ],
            language: {
               "sEmptyTable": "Nenhum registro encontrado",
               "sLoadingRecords": "Carregando...",
               "sProcessing": "Processando...",
               "sZeroRecords": "Nenhum registro encontrado",
               "sInfo": "Mostrando de _START_ até _END_ de _TOTAL_ registros",
               "sInfoEmpty": "Mostrando 0 até 0 de 0 registros",
               "lengthMenu": "Exibir _MENU_ registros",
               "oPaginate": {
                  "sNext": "Próximo",
                  "sPrevious": "Anterior",
                  "sFirst": "Primeiro",
                  "sLast": "Último"
               }
            }
         });
      }
   </script>
</asp:Content>
