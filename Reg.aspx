<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" Inherits="_3_tier_practice.Reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register page</title>
    <style>

        </style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="container-fluid">
            <h1 class=" text text-Success text-center">Register here</h1>
            <div class="col-lg-8 m-auto d-block"></div>
        
        <div class="formgroup">
            <label>Username</label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
             <div class="formgroup">
                 <label>Mobile</label>
                 <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                 </div>
             <div class="formgroup">
                 <label>Email</label>
                 <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                 </div>
             <div>
                 <label>Gender</label>
                 <asp:DropDownList ID="DropDownList2" runat="server">
                     <asp:ListItem>select Gender</asp:ListItem>
                     <asp:ListItem>Male</asp:ListItem>
                     <asp:ListItem>Female</asp:ListItem>
                 </asp:DropDownList>
             </div>
             <div class="formgroup">
                 <label>Usertype</label>
                 <asp:DropDownList ID="DropDownList1" runat="server">
                     <asp:ListItem>select item</asp:ListItem>
                     <asp:ListItem>User</asp:ListItem>
                     <asp:ListItem>Admin</asp:ListItem>
                 </asp:DropDownList>
                 </div>
             <div class="formgroup">
                 <label>Password</label>
                 <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                 </div>
             <div>
                 <asp:Button ID="INSERT" runat="server" Text="INSERT" OnClick="INSERT_Click1" />
             
</div>
             </div>

    </form>
</body>
</html>
