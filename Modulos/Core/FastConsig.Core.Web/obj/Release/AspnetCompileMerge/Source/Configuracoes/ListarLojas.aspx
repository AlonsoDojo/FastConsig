<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarLojas.aspx.cs" Inherits="FastConsig.Core.Web.Configuracoes.ListarLojas" %>

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
               <div class="table-responsive">
                  <div class="panel-button col-lg-1 col-sm-1">
                     <asp:LinkButton ID="btnNovo" runat="server" class="btn btn-primary" OnClick="btnNovo_Click">Novo</asp:LinkButton>
                  </div>
                  <asp:Repeater ID="LojasRepeater" runat="server" OnItemDataBound="LojasRepeater_ItemDataBound">
                     <HeaderTemplate>
                        <table class="table table-centered table-nowrap mb-0 no-footer dtr-inline nowrap table-card-list dt-responsive DataTables" style="width: 99%;" id="tabelaLojas">
                           <thead class="table-light">
                              <tr>
                                 <th style="width: 20px;"></th>
                                 <th>Rede de Lojas</th>
                                 <th>Loja</th>
                              </tr>
                           </thead>
                           <tbody>
                     </HeaderTemplate>
                     <ItemTemplate>
                        <tr>
                           <td class="list-inline-item">
                              <fmk:CustomLinkButton ID="lnkEditar" runat="server" CssClass="uil uil-pen font-size-16" ToolTip="Editar"
                                 CommandName="Editar" RequiredRole="" CausesValidation="false" OnClick="lnkEditar_Click" />
                           </td>
                           <td>
                              <fmk:CustomLabel ID="lblNomeRede" runat="server" /></td>
                           <td>
                              <fmk:CustomLabel ID="lblNomeLoja" runat="server" /></td>
                        </tr>
                     </ItemTemplate>
                     <FooterTemplate>
                        </tbody>
</table>
                     </FooterTemplate>
                  </asp:Repeater>
               </div>
            </div>
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
