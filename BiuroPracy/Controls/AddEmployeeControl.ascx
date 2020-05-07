<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddEmployeeControl.ascx.cs" Inherits="BiuroPracy.Controls.AddEmployeeControl" %>
<div class="form-group">
    <label class="contorl-label col-sm-2">Email:</label>
    <div class="col-sm-10">
        <asp:TextBox ID="txtEmail" class="form-control" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="tfvEmail" ControlToValidate="txtEmail" runat="server" ErrorMessage="Wymagane pole"></asp:RequiredFieldValidator>
    </div>
</div>
<div class="form-group">
    <label class="contorl-label col-sm-2">Password:</label>
    <div class="col-sm-10">
        <asp:TextBox ID="txtPassword" class="form-control" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="tfvPassword" ControlToValidate="txtPassword" runat="server" ErrorMessage="Wymagane pole"></asp:RequiredFieldValidator>
    </div>
</div>
<div class="form-group">
    <label class="contorl-label col-sm-2">Imię:</label>
    <div class="col-sm-10">
        <asp:TextBox ID="txtName" class="form-control" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="tfvName" ControlToValidate="txtName" runat="server" ErrorMessage="Wymagane pole"></asp:RequiredFieldValidator>
    </div>
</div>
<div class="form-group">
    <label class="contorl-label col-sm-2">Nazwisko:</label>
    <div class="col-sm-10">
        <asp:TextBox ID="txtSureName" class="form-control" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="tfvSureName" ControlToValidate="txtSureName" runat="server" ErrorMessage="Wymagane pole"></asp:RequiredFieldValidator>
    </div>
</div>
<div class="form-group">
    <label class="contorl-label col-sm-2">Czy jest wsi</label>
    <div class="col-sm-10">
        <asp:RadioButtonList ID="rblType" runat="server">
            <asp:ListItem runat="server" Text="Tak" />
            <asp:ListItem runat="server" Text="Nie" selected="true"  />
        </asp:RadioButtonList>
    </div>
</div>
<div class="form-group">
    <label class="contorl-label col-sm-2">Data urodzenia:</label>
    <div class="col-sm-10">
        <asp:Calendar ID="calendarDateOfBirth" runat="server"></asp:Calendar>
        <br />
    </div>
</div>
<div class="form-group">
    <label class="contorl-label col-sm-2">Zawód:</label>
    <div class="col-sm-10">
        <asp:DropDownList ID="ddlProfession" class="form-control" runat="server"></asp:DropDownList>
    </div>
    <label class="contorl-label col-sm-2">
        Umowa o pracę:</label>
</div>
<asp:DropDownList ID="ddlContractOfEmployment" class="form-control" runat="server"></asp:DropDownList>
