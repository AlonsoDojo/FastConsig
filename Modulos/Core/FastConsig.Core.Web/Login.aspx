<%@ Page Language="C#" MasterPageFile="~/SecuritylessSite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FastConsig.Core.Web.Login" %>

<%@ Register Assembly="Framework" Namespace="Framework.Web.UI.Controls" TagPrefix="fmk" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <div id="divLogin" runat="server">
      <div class="account-pages my-5 pt-sm-5">
         <div class="container">
            <div class="row">
               <div class="col-lg-12">
                  <div class="text-center">
                     <a class="mb-5 d-block auth-logo">
                        <img src="/Imagens/LogoFastConsig-light.png" alt="" height="66" class="logo logo-dark">
                        <img src="/Imagens/LogoFastConsig-light.png" alt="" height="66" class="logo logo-light">
                     </a>
                  </div>
               </div>
            </div>
            <div class="row align-items-center justify-content-center">
               <div class="col-md-8 col-lg-6 col-xl-5">
                  <div class="card">

                     <div class="card-body p-4">
                        <div class="text-center mt-2">
                           <h5 class="text-primary">Bem vindo!</h5>
                           <p class="text-muted">Informe suas credenciais</p>
                        </div>
                        <div class="p-2 mt-4">
                           <form>
                              <div class="mb-3">
                                 <label class="form-label" for="username">Usuário</label>
                                 <fmk:CustomTextBox ID="txtUsuario" placeholder="Informe o nome do usuário" CssClass="form-control" runat="server" TabIndex="1"/>
                              </div>

                              <div class="mb-3">
                                 <div class="float-end">
                                    <fmk:CustomLinkButton class="text-muted" Text="Esqueceu sua senha?"  runat="server" ID="lnkEsqueciMinhaSenha" OnClick="lnkEsqueciMinhaSenha_Click" />
                                 </div>
                                 <label class="form-label" for="userpassword">Senha</label>
                                 <asp:TextBox ID="txtSenha" placeholder="Senha" CssClass="form-control" runat="server" TabIndex="2" TextMode="Password" />
                              </div>

<%--                              <div class="form-check">
                                 <input type="checkbox" class="form-check-input" id="auth-remember-check">
                                 <label class="form-check-label" for="auth-remember-check">Lembrar-me</label>
                              </div>--%>

                              <div class="mt-3 text-end">
                                 <fmk:CustomButton class="btn btn-primary w-sm waves-effect waves-light" ID="cmdEntrar" runat="server" OnClick="cmdEntrar_Click" Text="Entrar" />
                              </div>
                           </form>
                        </div>

                     </div>
                  </div>

                  <div class="mt-5 text-center">

                  </div>

               </div>
            </div>
            <!-- end row -->
         </div>
         <!-- end container -->
      </div>
   </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>
