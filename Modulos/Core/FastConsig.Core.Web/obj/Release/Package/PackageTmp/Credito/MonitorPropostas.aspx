<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MonitorPropostas.aspx.cs" Inherits="FastConsig.Core.Web.Credito.MonitorPropostas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
   <style>
      div.dataTables_wrapper {
         width: 2400px;
         height: 690px;
         margin: 0 auto;
      }
   </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <div class="row">
      <!-- Filtros -->
      <div class="col-xl-3 col-lg-4">
         <div class="card">
            <div class="card-header bg-transparent border-bottom">
               <h5 class="font-size-16 mb-0">Filtros<span class="float-end">
                  <fmk:CustomLinkButton ID="btnPesquisar" runat="server" CssClass="btn btn-primary chat-send w-md waves-effect waves-light" TabIndex="8"
                     ToolTip="Pesquisar" RequiredRole="" CausesValidation="false" OnClick="btnPesquisar_Click">
                        <span class="d-none d-sm-inline-block me-2">Aplicar</span>
                  </fmk:CustomLinkButton></span></h5>
               <fmk:CustomLinkButton ID="btnPost" runat="server" OnClick="btnPost_Click" />
               <asp:HiddenField runat="server" ID="hfProposta" ClientIDMode="Static" />

            </div>

            <div class="p-4 border-bottom">
               <label class="form-label" for="formrow-Fullname-input">Nº da Proposta/Contrato</label>
               <fmk:CustomTextBox ID="txtProposta" runat="server" CssClass="form-control uppercase" TabIndex="1"
                  placeholder="Nº da Proposta"
                  BindSelectedType="Message"
                  Required="False"
                  FormatType="Integer"
                  onkeypress="return isNumber(event)"
                  onpaste="return false;"
                  autocomplete="off"
                  BindSourceType="Message"
                  BindSourceText="MonitorFiltroModel.Proposta"
                  BindSourceValue="MonitorFiltroModel.Proposta"></fmk:CustomTextBox>
               <fmk:CustomTextBox ID="txtContrato" runat="server" CssClass="form-control uppercase" TabIndex="2"
                  placeholder="Nº do Contrato"
                  BindSelectedType="Message"
                  Required="False"
                  FormatType="Integer"
                  autocomplete="off"
                  BindSourceType="Message"
                  BindSourceText="MonitorFiltroModel.Contrato"
                  BindSourceValue="MonitorFiltroModel.Contrato"></fmk:CustomTextBox>
            </div>

            <div class="p-4 border-bottom">
               <label class="form-label" for="periodo">Período</label>
               <fmk:CustomTextBox
                  ID="txtDataInicial"
                  placeholder="Data Inical"
                  runat="server"
                  CssClass="form-control flatpickr-input"
                  TabIndex="2"
                  BindSelectedType="Message"
                  Required="False"
                  BindSourceType="Message"
                  FormatType="Date"
                  Style="width: 120px;"
                  BindSourceText="MonitorFiltroModel.DataInicial"
                  BindSourceValue="MonitorFiltroModel.DataInicial">
               </fmk:CustomTextBox>
               <fmk:CustomTextBox
                  ID="txtDataFinal"
                  placeholder="Data Final"
                  runat="server"
                  CssClass="form-control flatpickr-input"
                  TabIndex="3"
                  BindSelectedType="Message"
                  Required="False"
                  BindSourceType="Message"
                  FormatType="Date"
                  Style="width: 120px;"
                  BindSourceText="MonitorFiltroModel.DataFinal"
                  BindSourceValue="MonitorFiltroModel.DataFinal">
               </fmk:CustomTextBox>
            </div>

            <div class="p-4 border-bottom">
               <label class="form-label" for="formrow-Fullname-input">Cliente</label>
               <fmk:CustomTextBox
                  ID="txtNomeCliente"
                  runat="server"
                  CssClass="form-control uppercase"
                  TabIndex="4"
                  placeholder="Nome do Cliente"
                  BindSelectedType="Message"
                  Required="False"
                  BindSourceType="Message"
                  BindSourceText="MonitorFiltroModel.Nome"
                  BindSourceValue="MonitorFiltroModel.Nome">
               </fmk:CustomTextBox>
               <fmk:CustomTextBox
                  ID="txtCPF"
                  runat="server"
                  CssClass="form-control"
                  Enabled="true"
                  placeholder="CPF"
                  BindSelectedType="Message"
                  Required="False"
                  FormatType="Integer"
                  BindSourceType="Message"
                  TabIndex="5"
                  onkeypress="return isNumber(event)"
                  onpaste="return false;"
                  MaxLength="11"
                  BindSourceText="MonitorFiltroModel.CPF"
                  BindSourceValue="MonitorFiltroModel.CPF">
               </fmk:CustomTextBox>
            </div>

            <div class="p-4">
               <div class="p-md-1">
                  <label class="form-label" for="ddlProduto">Produto</label>
                  <fmk:CustomDropDownList
                     ID="ddlProduto"
                     runat="server"
                     CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                     BindSelectedType="Message"
                     BindSelectedValue="FiltroMonitorModel.Produto"
                     BindSourceText="Produtos.Nome"
                     BindSourceType="Message"
                     BindSourceValue="Produtos.Id"
                     TabIndex="6"
                     DefaultSelectedItem="(Selecione o Produto)"
                     Width="100%"
                     RequiredMessage="<a title=&quot;O campo 'Produto' deve ser informado.&quot;><img src='/imagens/erro_validacao.png'/></a>"
                     ValidatorDisplay="Dynamic" />
               </div>
               <div class="p-md-1">
                  <label class="form-label" for="ddlFase">Fase</label>
                  <fmk:CustomDropDownList
                     ID="ddlFase"
                     runat="server"
                     CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                     TabIndex="7"
                     BindSelectedType="Message"
                     Required="False"
                     BindSourceType="Message"
                     BindSelectedValue="FiltroMonitorModel.Fase"
                     DefaultSelectedItem="(Selecione a Fase)"
                     BindSourceText="Fases.Descricao"
                     BindSourceValue="Fases.Id">
                  </fmk:CustomDropDownList>
               </div>
               <div class="p-md-1">
                  <label class="form-label" for="ddlStatus">Status</label>
                  <fmk:CustomDropDownList
                     ID="ddlStatus"
                     runat="server"
                     CssClass="form-control dropdown-toggle select2-selection select2-selection--single form-select select2"
                     TabIndex="8"
                     BindSelectedType="Message"
                     Required="False"
                     BindSourceType="Message"
                     BindSelectedValue="FiltroMonitorModel.Status"
                     DefaultSelectedItem="(Selecione o Status)"
                     BindSourceText="Status.Descricao"
                     BindSourceValue="Status.Id">
                  </fmk:CustomDropDownList>
               </div>
            </div>

         </div>
      </div>
      <!-- /Filtros -->

      <!-- Monitor -->
      <div class="col-xl-9 col-lg-8">
         <div class="card">
            <div class="card-body">
               <div>
                  <div class="row">
                     <div class="col-lg-12">
                        <div class="card">
                           <div class="card-body">
                              <div class="table-responsive">
                                 <table id="tabelaPropostas" class="table table-centered table-nowrap mb-0 no-footer dtr-inline nowrap table-card-list dt-responsive DataTables"></table>
                              </div>
                           </div>
                        </div>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
      <!-- /Monitor -->
   </div>
   <!-- end row -->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
   <script>
      function StartupPaginaJs() {
         $(document).ready(function () {
            $('#tabelaPropostas')
               .dataTable({
                  serverSide: true,
                  pageLength: 10,
                  paging: true,
                  "pagingType": "full_numbers",
                  "lengthMenu": [[0, 10, 25, 50, -1], [0, 10, 25, 50, "Todos"]],
                  "info": true,
                  "columnDefs": [
                     { 'targets': [0], 'className': 'dt-center', 'width': '1%' },
                     { 'targets': [1], className: 'dt-center', 'width': '3%' },
                     { 'targets': [2], className: 'dt-center', 'width': '5%' },
                     { type: 'de_datetime', 'targets': [3], className: 'dt-center', 'width': '6%' },
                     { 'targets': [4], className: 'dt-center', 'width': '8%' },
                     { 'targets': [5], className: 'dt-center', 'width': '20%' },
                     { 'targets': [6], className: 'datatable-right', 'width': '6%' },
                     { 'targets': [7], className: 'dt-left', 'width': '15%' },
                     { 'targets': [8], className: 'dt-center', 'width': '8%' },
                     { 'targets': [9], className: 'dt-center', 'width': '4%' },
                     { 'targets': [10], className: 'dt-center', 'width': '2%' },
                     { type: 'de_datetime', 'targets': [11], className: 'dt-center', 'width': '6%' },
                     { 'targets': [12], className: 'dt-center', 'width': '8%' },
                     { 'targets': [13], className: 'dt-center', 'width': '8%' }
                  ],
                  "order": [[1, "desc"]],
                  processing: true,
                  stateSave: true,
                  responsive: true,
                  searching: false,
                  dom: '<"html5buttons" B>lTfgitp',
                  autoWidth: false,
                  buttons: [
                     {
                        copy: 'Copiar',
                        extend: 'copyHtml5',
                        exportOptions: {
                           columns: [0, ':visible']
                        }
                     },
                     {
                        extend: 'excelHtml5',
                        exportOptions: {
                           columns: ':visible'
                        }
                     },
                     {
                        extend: 'pdfHtml5',
                        exportOptions: {
                           columns: [1, 2, 3, 4, 5, 6]
                        }
                     },
                     {
                        extend: 'colvis',
                        text: 'Colunas',
                        columns: ':not(.noVis)'
                     }
                  ],
                  language: {
                     "sEmptyTable": "Nenhum registro encontrado",
                     "sLoadingRecords": "Carregando...",
                     "sProcessing": "Processando...",
                     "sZeroRecords": "Nenhum registro encontrado",
                     "sInfo": "Mostrando de _START_ até _END_ de _TOTAL_ registros",
                     "sInfoEmpty": "Mostrando 0 até 0 de 0 registros",
                     "lengthMenu": "Exibir _MENU_ registros",
                     "colvis": "Colunas",
                     "oPaginate": {
                        "sNext": "Próximo",
                        "sPrevious": "Anterior",
                        "sFirst": "Primeiro",
                        "sLast": "Último"
                     },
                  },
                  "dom": '<"html5buttons" B><"top">rt<"bottom">p<"clear">',
                  ajax: {
                     "url": "/Proposta/ListarPropostas",
                     "data": function (data) {
                        data.param1 = "";
                        data.param2 = "";
                        data.param3 = "";
                        data.param4 = "";
                        data.param5 = "";
                        data.param6 = "";
                        data.param7 = "";
                        data.param8 = "";
                        data.param9 = "";
                        data.param10 = "";
                     },
                     "dataSrc": function (json) {
                        //console.log(json.rParam1);
                        //console.log(json.rParam2);
                        return json.data;
                     }
                  },
                  columns: [
                     {
                        name: 'usuarioPropostaFormatado',
                        data: 'usuarioPropostaFormatado',
                        title: "",
                        sortable: false,
                        searchable: false
                     },
                     {
                        name: 'aguardandoLiberacaoFormatado',
                        data: 'aguardandoLiberacaoFormatado',
                        title: "",
                        sortable: false,
                        searchable: false/*,
                                render: function (data, type, row, meta) {
                                    console.log(data, type, row, meta);
                                }*/
                     },
                     {
                        name: 'proposta',
                        data: 'proposta',
                        title: "Nº Proposta",
                        sortable: true,
                        searchable: false
                     },
                     {
                        name: 'dataCriacaoFormatado',
                        data: "dataCriacaoFormatado",
                        title: "Data Captura",
                        sortable: true,
                        searchable: false
                     },
                     {
                        name: 'cpfcnpjFormatado',
                        data: "cpfcnpjFormatado",
                        title: "CPF/CNPJ Proponente",
                        sortable: true,
                        searchable: false
                     },
                     {
                        name: 'nomeProponente',
                        data: "nomeProponente",
                        title: "Nome do Proponente",
                        sortable: true,
                        searchable: false
                     },
                     {
                        name: 'valorOperacaoFormatado',
                        data: "valorOperacaoFormatado",
                        title: "Valor Solicitado",
                        sortable: false,
                        searchable: false
                     },
                     {
                        name: 'nomeProduto',
                        data: "nomeProduto",
                        title: "Produto",
                        sortable: true,
                        searchable: false
                     },
                     {
                        name: 'descricaoFase',
                        data: "descricaoFase",
                        title: "Fase",
                        sortable: true,
                        searchable: false
                     },
                     {
                        name: 'descricaoStatus',
                        data: "descricaoStatus",
                        title: "Status",
                        sortable: true,
                        searchable: false
                     },
                     {
                        name: 'contratoLegado',
                        data: "contratoLegado",
                        title: "Contrato",
                        sortable: true,
                        searchable: false
                     },
                     {
                        name: 'dataAtualizacaoFormatado',
                        data: "dataAtualizacaoFormatado",
                        title: "Atualização",
                        sortable: true,
                        searchable: false
                     },
                     {
                        name: 'nomeLoja',
                        data: "nomeLoja",
                        title: "Loja/Sub",
                        sortable: true,
                        searchable: false
                     },
                     {
                        name: 'nomeRedeLojasAbreviado',
                        data: "nomeRedeLojasAbreviado",
                        title: "Lojista/Master",
                        sortable: true,
                        searchable: false
                     }
                  ]
               });
         });



         jQuery.extend(jQuery.fn.dataTableExt.oSort, {
            "date-eu-pre": function (date) {
               date = date.replace(" ", "");

               if (!date) {
                  return 0;
               }

               var year;
               var eu_date = date.split(/[\.\-\/]/);

               /*year (optional)*/
               if (eu_date[2]) {
                  year = eu_date[2];
               }
               else {
                  year = 0;
               }

               /*month*/
               var month = eu_date[1];
               if (month.length == 1) {
                  month = 0 + month;
               }

               /*day*/
               var day = eu_date[0];
               if (day.length == 1) {
                  day = 0 + day;
               }

               return (year + month + day) * 1;
            },

            "date-eu-asc": function (a, b) {
               return ((a < b) ? -1 : ((a > b) ? 1 : 0));
            },

            "date-eu-desc": function (a, b) {
               return ((a < b) ? 1 : ((a > b) ? -1 : 0));
            }
         });

         jQuery.extend(jQuery.fn.dataTableExt.oSort, {
            "de_datetime-asc": function (a, b) {
               var x, y;
               if (jQuery.trim(a) !== '') {
                  var deDatea = jQuery.trim(a).split(' ');
                  var deTimea = deDatea[1].split(':');
                  var deDatea2 = deDatea[0].split('/');
                  if (typeof deTimea[2] != 'undefined') {
                     x = (deDatea2[2] + deDatea2[1] + deDatea2[0] + deTimea[0] + deTimea[1] + deTimea[2]) * 1;
                  } else {
                     x = (deDatea2[2] + deDatea2[1] + deDatea2[0] + deTimea[0] + deTimea[1]) * 1;
                  }
               } else {
                  x = -Infinity; // = l'an 1000 ...
               }

               if (jQuery.trim(b) !== '') {
                  var deDateb = jQuery.trim(b).split(' ');
                  var deTimeb = deDateb[1].split(':');
                  deDateb = deDateb[0].split('/');
                  if (typeof deTimeb[2] != 'undefined') {
                     y = (deDateb[2] + deDateb[1] + deDateb[0] + deTimeb[0] + deTimeb[1] + deTimeb[2]) * 1;
                  } else {
                     y = (deDateb[2] + deDateb[1] + deDateb[0] + deTimeb[0] + deTimeb[1]) * 1;
                  }
               } else {
                  y = -Infinity;
               }
               var z = ((x < y) ? -1 : ((x > y) ? 1 : 0));
               return z;
            },

            "de_datetime-desc": function (a, b) {
               var x, y;
               if (jQuery.trim(a) !== '') {
                  var deDatea = jQuery.trim(a).split(' ');
                  var deTimea = deDatea[1].split(':');
                  var deDatea2 = deDatea[0].split('/');
                  if (typeof deTimea[2] != 'undefined') {
                     x = (deDatea2[2] + deDatea2[1] + deDatea2[0] + deTimea[0] + deTimea[1] + deTimea[2]) * 1;
                  } else {
                     x = (deDatea2[2] + deDatea2[1] + deDatea2[0] + deTimea[0] + deTimea[1]) * 1;
                  }
               } else {
                  x = Infinity;
               }

               if (jQuery.trim(b) !== '') {
                  var deDateb = jQuery.trim(b).split(' ');
                  var deTimeb = deDateb[1].split(':');
                  deDateb = deDateb[0].split('/');
                  if (typeof deTimeb[2] != 'undefined') {
                     y = (deDateb[2] + deDateb[1] + deDateb[0] + deTimeb[0] + deTimeb[1] + deTimeb[2]) * 1;
                  } else {
                     y = (deDateb[2] + deDateb[1] + deDateb[0] + deTimeb[0] + deTimeb[1]) * 1;
                  }
               } else {
                  y = -Infinity;
               }
               var z = ((x < y) ? 1 : ((x > y) ? -1 : 0));
               return z;
            },

            "de_date-asc": function (a, b) {
               var x, y;
               if (jQuery.trim(a) !== '') {
                  var deDatea = jQuery.trim(a).split('.');
                  x = (deDatea[2] + deDatea[1] + deDatea[0]) * 1;
               } else {
                  x = Infinity; // = l'an 1000 ...
               }

               if (jQuery.trim(b) !== '') {
                  var deDateb = jQuery.trim(b).split('.');
                  y = (deDateb[2] + deDateb[1] + deDateb[0]) * 1;
               } else {
                  y = -Infinity;
               }
               var z = ((x < y) ? -1 : ((x > y) ? 1 : 0));
               return z;
            },

            "de_date-desc": function (a, b) {
               var x, y;
               if (jQuery.trim(a) !== '') {
                  var deDatea = jQuery.trim(a).split('.');
                  x = (deDatea[2] + deDatea[1] + deDatea[0]) * 1;
               } else {
                  x = -Infinity;
               }

               if (jQuery.trim(b) !== '') {
                  var deDateb = jQuery.trim(b).split('.');
                  y = (deDateb[2] + deDateb[1] + deDateb[0]) * 1;
               } else {
                  y = Infinity;
               }
               var z = ((x < y) ? 1 : ((x > y) ? -1 : 0));
               return z;
            }
         });
      }

      function DoPostBackManualMonitor(proposta) {
         $("#hfProposta").val(proposta);
         WebForm_DoPostBackWithOptions(new WebForm_PostBackOptions("ctl00$MainContent$btnPost", "", true, "", "", false, true));
      }
   </script>
</asp:Content>

