<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Login_page._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<main>
    <section class="row" aria-labelledby="registrationTitle">
        <h1 id="registrationTitle">Register for ASP.NET</h1>
        <p class="lead">Sign up to start building great web sites and web applications using ASP.NET.</p>
    </section>

    <div class="row">
        <section class="col-md-6">
            <form action="/register" method="post">
                <div class="form-group">
                    <label for="firstName">First Name</label>
                    <input type="text" class="form-control" id="firstName" name="firstName" required>
                </div>
                <div class="form-group">
                    <label for="lastName">Last Name</label>
                    <input type="text" class="form-control" id="lastName" name="lastName" required>
                </div>
                <div class="form-group">
                    <label for="email">Email address</label>
                    <input type="email" class="form-control" id="email" name="email" required>
                </div>
                <div class="form-group">
                    <label for="password">Password</label>
                    <input type="password" class="form-control" id="password" name="password" required>
                </div>
                <div class="form-group">
                    <label for="confirmPassword">Confirm Password</label>
                    <input type="password" class="form-control" id="confirmPassword" name="confirmPassword" required>
                </div>
               <asp:Button ID="btnRegister" runat="server" CssClass="btn btn-primary btn-md" Text="Register" OnClick="btnRegister_Click" />


            </form>
            
        </section>

        <section class="col-md-6">
            <h2>Already have an account?</h2>
            <p>
                If you already have an account, you can <a href="/login" class="btn btn-default">Log In &raquo;</a>
            </p>
        </section>
    </div>
</main>

</asp:Content>
