<%@ Page Language="C#" MasterPageFile="~/SecuritylessSite.Master" AutoEventWireup="true" CodeBehind="EsqueciMinhaSenha.aspx.cs" Inherits="FastConsig.Core.Web.EsqueciMinhaSenha" %>

<%@ Register Assembly="Framework" Namespace="Framework.Web.UI.Controls" TagPrefix="fmk" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <div class="account-pages my-5  pt-sm-5">
      <div class="container">
         <div class="row justify-content-center">
            <div class="col-md-8 col-lg-6 col-xl-5">
               <div>
                  <a class="mb-5 d-block auth-logo">
                     <img src="/Imagens/LogoFastConsig-light.png" alt="" height="66" class="logo logo-dark">
                     <img src="/Imagens/LogoFastConsig-light.png" alt="" height="66" class="logo logo-light">
                  </a>
                  <div class="card">

                     <div class="card-body p-4">

                        <div class="text-center mt-2">
                           <h5 class="text-primary">Recuperação de Senha</h5>
                        </div>
                        <div class="p-2 mt-4">
                           <div class="alert alert-success text-center mb-4" role="alert">
                              Informe seu usuário e as instruções serão enviadas para você!
                          
                           </div>
                           <form>

                              <div class="mb-3">
                                 <label class="form-label" for="useremail">Usuário</label>
                                 <fmk:CustomTextBox ID="txtUsuario" placeholder="Informe seu Usuário" CssClass="form-control" runat="server" TabIndex="1" />
                              </div>

                              <div class="mt-3 text-end">
                                 <fmk:CustomButton class="btn btn-primary w-sm waves-effect waves-light" ID="btnVoltar" runat="server" OnClick="btnVoltar_Click" Text="Voltar" />
                                 <fmk:CustomButton class="btn btn-primary w-sm waves-effect waves-light" ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Enviar" />
                              </div>

                           </form>
                        </div>

                     </div>
                  </div>
                  <div class="mt-5 text-center">
                  </div>
               </div>
            </div>
         </div>
         <!-- end row -->
      </div>
      <!-- end container -->
   </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>

