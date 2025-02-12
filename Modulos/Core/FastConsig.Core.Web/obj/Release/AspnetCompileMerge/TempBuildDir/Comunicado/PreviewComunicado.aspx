<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PreviewComunicado.aspx.cs" Inherits="FastConsig.Core.Web.Comunicado.PreviewComunicado" ValidateRequest="false" %>

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
                           <fmk:CustomLinkButton ID="btnVoltar" runat="server" class="btn btn-secondary waves-effect" OnClick="btnVoltar_Click">Voltar</fmk:CustomLinkButton>
                        </div>

                        <div class="mb-3">
                        </div>

                        <div class="row">
                           <div class="col-md-12">
                              <div class="mb-12">
                                 <fmk:CustomTextBox ID="txtConteudo"
                                    CssClass="input-sm form-control"
                                    runat="server"
                                    FormatType="Text"
                                    ValidatorDisplay="Dynamic"
                                    BindSourceText="Comunicados.Conteudo"
                                    BindSourceType="Message"
                                    Enabled="true"
                                    Style="text-align: left;"
                                    Obrigatorio="True"
                                    Required="true" />
                              </div>
                           </div>
                        </div>

                        <div class="mb-3">
                        </div>

                        <div class="row">
                           <div class="col-md-12">
                              <div class="mb-12">
                                 <div class="card-header bg-transparent border-bottom">
                                    <h5 class="mb-0">Arquivos</h5>
                                 </div>
                                 <div class="panel-body">
                                    <div class="table-responsive">
                                       <table class="table table-centered table-nowrap mb-0 no-footer dtr-inline nowrap table-card-list dt-responsive DataTables" style="width: 99%;" id="tabelaUsuarios">
                                          <thead>
                                             <tr>
                                                <th style="width: 8px;"></th>
                                                <th>
                                                   <label class="header_left">Arquivo</label></th>
                                             </tr>
                                          </thead>
                                          <tbody>
                                             <asp:Repeater ID="rptArquivos" OnItemCommand="rptArquivos_ItemCommand" OnItemDataBound="rptArquivos_ItemDataBound" runat="server">
                                                <ItemTemplate>
                                                   <tr>
                                                      <td>
                                                         <table border="0" style="line-height: normal; background-color: transparent; padding: 0; align-content: center">
                                                            <tr style="text-align: center; background-color: transparent;">
                                                               <td style="text-align: center; background-color: transparent; padding: 3px;">
                                                                  <fmk:CustomLinkButton
                                                                     ID="lnkArquivoDownload"
                                                                     runat="server"
                                                                     CssClass="uil uil-download-alt font-size-16"
                                                                     Width="50%"
                                                                     CausesValidation="false"
                                                                     Style="text-align: left"
                                                                     RequiredRole=""
                                                                     CommandName="Download"
                                                                     CommandArgument='<%# Eval("Id") %>'
                                                                     ToolTip="Download"
                                                                     TabIndex="-1"></fmk:CustomLinkButton>
                                                               </td>
                                                            </tr>
                                                         </table>
                                                      </td>
                                                      <td>
                                                         <asp:Label ID="lblArquivo" runat="server" CssClass="input-sm" Width="100%"><%# Eval("NomeArquivo") %></asp:Label>
                                                      </td>
                                                   </tr>
                                                </ItemTemplate>
                                             </asp:Repeater>
                                          </tbody>
                                       </table>
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
      </div>
   </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
   <script src="https://cdn.tiny.cloud/1/xzfwsgsv0xvzfbvpyoce3jowbu0x4t9vyghwbs66ky18bm91/tinymce/6/tinymce.min.js" referrerpolicy="origin"></script>
   <script>
      tinymce.init({
         selector: '#MainContent_txtConteudo',
         plugins: 'none',
         toolbar: 'false',
         menubar: 'false',
         readonly: true
      });
   </script>
</asp:Content>
