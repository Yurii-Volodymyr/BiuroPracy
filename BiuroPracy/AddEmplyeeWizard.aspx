<%@ Page Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddEmplyeeWizard.aspx.cs" Inherits="BiuroPracy.AddEmplyeeWizard" %>

<%@ Register TagPrefix="employee" TagName="AddEmployeeControl" Src="Controls/AddEmployeeControl.ascx" %>
<%@ Register TagPrefix="place" TagName="AddPlaceOfResidenceControl" Src="Controls/AddPlaceOfResidenceControl.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/AddEmployee.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <h4>Dodawanie pracowników</h4>
    <asp:Panel ID="panelInfo" runat="server">
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
    </asp:Panel>
    <asp:Wizard ID="Wizard1" runat="server" Height="284px" Width="937px" ActiveStepIndex="0" OnFinishButtonClick="Wizard1_FinishButtonClick">
        <WizardSteps>
            <asp:WizardStep runat="server" Title="">
                <div class="bodyForm">

                    <employee:AddEmployeeControl ID="crtlAddEmployee" runat="server" />
                </div>
            </asp:WizardStep>

            <asp:WizardStep runat="server" Title="">
                <div class="bodyForm">

                    <place:AddPlaceOfResidenceControl ID="crtlAddPlaceOfResidence" runat="server" />
                </div>
            </asp:WizardStep>
        </WizardSteps>
    </asp:Wizard>
</asp:Content>
