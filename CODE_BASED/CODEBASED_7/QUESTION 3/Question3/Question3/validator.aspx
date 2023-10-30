﻿
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validator.aspx.cs" Inherits="Question_3.validator" %>
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>Validator</title>

</head>

<body>

    <form id="form1" runat="server">

         <h1>User Information</h1>

        <br /><br />

        <h2>Insert your details</h2>

       <div>

    <label for="name">Name:</label>

    <asp:TextBox ID="txtName" runat="server" placeholder="Enter your name"></asp:TextBox>

    <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" InitialValue=""

        Text="* Name is required" ForeColor="Red" Display="Dynamic" />

</div>

        <div>

            <label for="familyName">Family Name:</label>

            <asp:TextBox ID="txtFamilyName" runat="server" placeholder="Enter your family name (different from name)"></asp:TextBox>

            <asp:RequiredFieldValidator ID="rfvFamilyName" runat="server" ControlToValidate="txtFamilyName" InitialValue="" Text="* Family Name is required" ForeColor="Red" Display="Dynamic" />

        </div>

        <div>

            <label for="address">Address:</label>

            <asp:TextBox ID="txtAddress" runat="server" placeholder="Enter your address"></asp:TextBox>

            <asp:RequiredFieldValidator ID="rfvAddress" runat="server" ControlToValidate="txtAddress" InitialValue="" Text="* Address is required" ForeColor="Red" Display="Dynamic" />

        </div>

        <div>

            <label for="city">City:</label>

            <asp:TextBox ID="txtCity" runat="server" placeholder="At least 2 characters"></asp:TextBox>

            <asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="txtCity" InitialValue="" Text="* City is required" ForeColor="Red" Display="Dynamic" />

        </div>

        <div>

            <label for="zipCode">Zip Code:</label>

            <asp:TextBox ID="txtZipCode" runat="server" placeholder="Enter your zip code"></asp:TextBox>

            <asp:RequiredFieldValidator ID="rfvZipCode" runat="server" ControlToValidate="txtZipCode" InitialValue="" Text="* Zip Code is required" ForeColor="Red" Display="Dynamic" />

        </div>

        <div>

            <label for="phone">Phone:</label>

            <asp:TextBox ID="txtPhone" runat="server" placeholder="Enter your phone number"></asp:TextBox>

            <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ControlToValidate="txtPhone" InitialValue="" Text="* Phone is required" ForeColor="Red" Display="Dynamic" />

        </div>

        <div>

            <label for="email">E-Mail:</label>

            <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter your email address"></asp:TextBox>

            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" InitialValue="" Text="* Email is required" ForeColor="Red" Display="Dynamic" />

        </div>

        <asp:Button ID="btnCheck" runat="server" Text="Check" OnClick="btnCheck_Click" />

        <br />

        <asp:Label ID="resultLabel" runat="server" EnableViewState="false"></asp:Label>

    </form>

</body>

</html>


