<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarComunicado.aspx.cs" Inherits="FastConsig.Core.Web.Comunicado.EditarComunicado" ValidateRequest="false" %>

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
                           <fmk:CustomLinkButton ID="btnExcluir" runat="server" class="btn btn-outline-danger" OnClick="btnExcluir_Click" Visible="false" DialogConfirmarExclusao="true">Excluir</fmk:CustomLinkButton>
                           <fmk:CustomLinkButton ID="btnVoltar" runat="server" class="btn btn-secondary waves-effect" OnClick="btnVoltar_Click" CausesValidation="false">Voltar</fmk:CustomLinkButton>
                        </div>

                        <div class="mb-3">
                        </div>

                        <div class="row">
                           <div class="col-md-10">
                              <div class="mb-12">
                                 <label class="form-label" for="txtTitulo">Título</label>
                                 <fmk:CustomTextBox ID="txtTitulo" runat="server"
                                    CssClass="form-control"
                                    TabIndex="2"
                                    placeholder="Título"
                                    BindSelectedType="Message"
                                    Required="True"
                                    Enabled="true"
                                    MaxLength="200"
                                    FormatType="Text"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="Comunicados.Titulo"
                                    BindSourceValue="Comunicados.Titulo"></fmk:CustomTextBox>
                              </div>
                           </div>
                           <div class="col-md-1">
                              <div class="mb-12">
                                 <label class="form-label" for="txtVigenciaInicial">Vigência Inicial</label>
                                 <fmk:CustomTextBox ID="txtVigenciaInicial"
                                    runat="server"
                                    CssClass="form-control flatpickr-input"
                                    BindSelectedType="Message"
                                    Style="width: 120px;"
                                    TabIndex="1"
                                    placeholder="Vigência Inicial"
                                    Required="true"
                                    MaxLength="10"
                                    Enabled="true"
                                    FormatType="Date"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="Comunicados.DataVigenciaInicial"
                                    BindSourceValue="Comunicados.DataVigenciaInicial"></fmk:CustomTextBox>
                              </div>
                           </div>
                           <div class="col-md-1">
                              <div class="mb-12">
                                 <label class="form-label" for="txtVigenciaFinal">Vigência Final</label>
                                 <fmk:CustomTextBox ID="txtVigenciaFinal"
                                    runat="server"
                                    CssClass="form-control flatpickr-input"
                                    BindSelectedType="Message"
                                    Style="width: 120px;"
                                    TabIndex="1"
                                    placeholder="Vigência Inicial"
                                    Required="true"
                                    MaxLength="10"
                                    Enabled="true"
                                    FormatType="Date"
                                    onpaste="return false;"
                                    autocomplete="off"
                                    BindSourceType="Message"
                                    BindSourceText="Comunicados.DataVigenciaFinal"
                                    BindSourceValue="Comunicados.DataVigenciaFinal"></fmk:CustomTextBox>
                              </div>
                           </div>
                        </div>

                        <div class="mb-3">
                        </div>

                        <div class="row">
                           <div class="col-md-2">
                              <div class="mb-12">
                                 <label class="form-label" for="ddlStatus">Status</label>
                                 <fmk:CustomDropDownList
                                    ID="ddlStatus"
                                    runat="server"
                                    CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                                    TabIndex="1"
                                    BindSelectedType="Message"
                                    Required="true"
                                    Enabled="true"
                                    BindSourceType="Message"
                                    BindSelectedValue="Comunicados.Status"
                                    DefaultSelectedItem="(Selecione o Status)"
                                    BindSourceText="ComunicadosStatus.Descricao"
                                    BindSourceValue="ComunicadosStatus.Id">
                                 </fmk:CustomDropDownList>
                              </div>
                           </div>
                           <div class="col-md-2">
                              <div class="mb-12">
                                 <label class="form-label" for="ddlConfirmacaoLeitura">Confirmação de Leitura</label>
                                 <fmk:CustomDropDownList
                                    ID="ddlConfirmacaoLeitura"
                                    runat="server"
                                    CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                                    TabIndex="1"
                                    BindSelectedType="Message"
                                    Required="true"
                                    Enabled="true"
                                    BindSourceType="Message"
                                    BindSelectedValue="Comunicados.ConfirmacaoLeitura"
                                    DefaultSelectedItem="(Selecione)"
                                    BindSourceText="ConfirmacaoLeitura.Descricao"
                                    BindSourceValue="ConfirmacaoLeitura.Id">
                                 </fmk:CustomDropDownList>
                              </div>
                           </div>
                        </div>

                        <div class="mb-3">
                        </div>

                        <div class="row">
                           <div class="col-md-12">
                              <div class="mb-12">
                                 <label class="form-label" for="txtConteudo">Conteúdo</label>

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
                                                               <td style="text-align: center; background-color: transparent; padding: 3px;">
                                                                  <fmk:CustomLinkButton
                                                                     ID="lnkArquivoExcluir"
                                                                     runat="server"
                                                                     CssClass="uil uil-trash-alt font-size-16"
                                                                     Width="50%"
                                                                     CausesValidation="false"
                                                                     Style="text-align: left"
                                                                     RequiredRole=""
                                                                     CommandName="Excluir"
                                                                     CommandArgument='<%# Eval("Id") %>'
                                                                     ToolTip="Excluir"
                                                                     DialogConfirmarExclusao="true"
                                                                     TabIndex="-1">
                                                                  </fmk:CustomLinkButton>
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

                                 <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="conditional">
                                    <Triggers>
                                       <asp:PostBackTrigger ControlID="btnCarregarArquivo" />
                                    </Triggers>
                                    <ContentTemplate>
                                       <div class="row">
                                          <div class="col-md-6">
                                             <div class="mb-12">
                                                <div>
                                                   <asp:FileUpload ID="fileUpload" runat="server" accept=".pdf" />
                                                </div>
                                             </div>
                                             <asp:HiddenField ID="HdntipoArquivo" runat="server" />
                                          </div>
                                          <div class="col-md-6">
                                             <div class="mb-12">
                                                <asp:LinkButton
                                                   ID="btnCarregarArquivo"
                                                   runat="server"
                                                   CssClass="btn btn-primary"
                                                   ToolTip="Carregar Arquivo"
                                                   CausesValidation="false"
                                                   OnClick="btnCarregarArquivo_Click"
                                                   TabIndex="-1"><span>Carregar Arquivo</span>                                    
                                                </asp:LinkButton>
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
         </div>
      </div>
   </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
   <script src="https://cdn.tiny.cloud/1/xzfwsgsv0xvzfbvpyoce3jowbu0x4t9vyghwbs66ky18bm91/tinymce/6/tinymce.min.js" referrerpolicy="origin"></script>
   <script>
      tinymce.init({
         selector: '#MainContent_txtConteudo',
         language: 'pt_BR',
         language_url: '/js/plugins/TinyMCE/langs/pt_BR.js',
         setup: function (editor) {
            editor.on('change', function () {
               tinymce.triggerSave();
            });
         },
         plugins: ['advlist', 'autolink', 'lists', 'link', 'image', 'charmap', 'preview', 'anchor', 'searchreplace', 'visualblocks', 'fullscreen', 'insertdatetime', 'media', 'table', 'help', 'wordcount'],
         toolbar: 'undo redo | formatpainter casechange blocks | bold italic backcolor | ' +
            'alignleft aligncenter alignright alignjustify | ' +
            'bullist numlist checklist outdent indent | removeformat | a11ycheck code table help',
         file_browser_callback_types: 'file image',
         automatic_uploads: true,
         images_upload_url: '/Content/UploadContentImg',
         file_picker_types: 'file image',

      });
   </script>
</asp:Content>
